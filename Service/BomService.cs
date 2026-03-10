using AppGenealogySystem.Context;
using AppGenealogySystem.Enums;
using AppGenealogySystem.Models;
using AppGenealogySystem.Models.Dto;
using FontAwesome.Sharp;
using Microsoft.EntityFrameworkCore;
using MySqlConnector;
using System.Linq.Expressions;



namespace AppGenealogySystem.Service
{
    public class BomService : IBomService
    {
        private readonly IDbContextFactory<AppDBContext> _dbFactory;
        public BomService(IDbContextFactory<AppDBContext> dbFactory)
        {
            _dbFactory = dbFactory;
        }
        public async Task<List<ProductDto>> GetCodeAndName()
        {
            await using var db = _dbFactory.CreateDbContext();
            return await db.Products.Where(p => p.ProductType == ProductType.FinishedGood || p.ProductType == ProductType.SubAssembly)
                .AsNoTracking()
        .Select(p => new ProductDto
        {
            ProductId = p.ProductId,
            ProductCode = p.ProductCode,
            ProductName = p.ProductName
        }).Take(50)
        .ToListAsync();
        }
        public async void WarmUp()
        {
            await using var db = _dbFactory.CreateDbContext();
            var _ = db.Products.Take(1).ToList();

        }

        public async Task<List<BomTreeNode>> GetListBom(int versionId)
        {
            await using var db = _dbFactory.CreateDbContext();
            return await db.Set<Bom>().Join(db.Products, bom => bom.ChildProductId, product => product.ProductId, (bom, product) => new BomTreeNode()
            {
                VersionId = bom.VersionId,
                Sequence = bom.Sequence,
                ComponentName = product.ProductName,
                ComponentCode = product.ProductCode,
                Quantity = bom.Quantity,
                BomId = bom.BomId,
                ParentBomId = bom.ParentBomId,
                IsCritical = bom.IsCritical,
                LineEffectiveDate = bom.EffectiveDate.ToString(),
                LineExpiryDate = bom.ExpiryDate.ToString(),
                UOM = product.BaseUOM,
                Status = product.IsActive ? "Active" : "UnActive"
            }).Where(x => x.VersionId == versionId).ToListAsync();
        }
        public async Task<List<BomVerDto>> GetListVersionAsync(long? parentProductId)
        {
            await using var db = _dbFactory.CreateDbContext();
            return await db.Set<BomVersion>().Select(x => new BomVerDto()
            {
                VersionId = x.VersionId,
                BomVersion = x.BOMVersion,
                EffectiveDate = x.EffectiveDate,
                ExpiryDate = x.ExpiryDate,
                EffectDateText = x.EffectDateText,
                IsDefault = x.IsDefault,
                ParentProductId = x.ParentProductId,
                ExpiryDateText = x.ExpiryDateText
            }).Where(x => x.ParentProductId == parentProductId).ToListAsync();
        }
        public async Task<List<BomVersionProduct>> GetParentComponent(int? parentBomId)
        {

            using var db = _dbFactory.CreateDbContext();
            return await db.Set<Bom>().Join(db.Products, b => b.ChildProductId, p => p.ProductId, (b, p) => new BomVersionProduct()
            {
                ProductName = p.ProductName,
                ParentBomId = b.ParentBomId,
                BomId = b.BomId
            }).Where(x => x.BomId == parentBomId).ToListAsync();
        }
        public async Task<List<BomVersionProduct>> GetBomVersionProduct(int versionId)
        {
            using var db = _dbFactory.CreateDbContext();
            return await db.Set<Bom>().Join(db.Products, bom => bom.ChildProductId, product => product.ProductId, (bom, product) => new BomVersionProduct()
            {

                ProductCode = product.ProductCode,
                ProductName = product.ProductName,
                ProductType = product.ProductType,
                BomId = bom.BomId,
                VersionId = bom.VersionId,
                ParentBomId = bom.ParentProductId
            }).Where(x => x.VersionId == versionId && x.ProductType == ProductType.SubAssembly).ToListAsync();
        }
        public async Task<BomVerDto?> GetDataVersionById(int versionId)
        {
            await using var db = _dbFactory.CreateDbContext();
            return await db.Set<BomVersion>()
                           .Where(x => x.VersionId == versionId)
                           .Select(x => new BomVerDto
                           {
                               VersionId = x.VersionId,
                               BomVersion = x.BOMVersion,
                               EffectDateText = x.EffectDateText,
                               IsDefault = x.IsDefault,
                               ExpiryDateText = x.ExpiryDateText
                           })
                           .FirstOrDefaultAsync();

        }
        public async void AddAsync(BomVersion entity)
        {
            using var db = _dbFactory.CreateDbContext();
            var existing = await db.Set<BomVersion>().FirstOrDefaultAsync(x => x.VersionId == entity.VersionId);
            try
            {
                if (existing != null)
                {
                    existing.BOMVersion = entity.BOMVersion;
                    //existing.VersionId = entity.VersionId;
                    existing.ParentProductId = entity.ParentProductId;
                    existing.EffectiveDate = entity.EffectiveDate;
                    await db.SaveChangesAsync();
                }
                else
                {
                    db.Add(entity);
                    await db.SaveChangesAsync();
                }
            }
            catch (Exception ex)
            {
                Logger.LogError(ex);
            }
        }
        //Query CTE SQL lib linq2db
        public async Task<List<BomTreeCTE>> GetTreeBomNode(long parentProductId, int versionId)
        {
            using var db = _dbFactory.CreateDbContext();

            var sql = @"
                WITH RECURSIVE BOM_CTE AS (
    -- Anchor member: các thành phần con trực tiếp của sản phẩm gốc
    SELECT
        bd.BomId,
        bd.VersionID,
        bd.ParentProductID,
        bd.ChildProductID,
        bd.Quantity,
        bd.Sequence,
        bd.IsCritical,
        1 AS Level,
        CAST(bd.Quantity AS DECIMAL(18,4)) AS AccumulatedQuantity,
        CAST(CONCAT(bd.ParentProductID, '>', bd.ChildProductID) AS CHAR(1000)) AS Path,
        0 AS IsCycle
    FROM bom bd
    WHERE bd.VersionID = @versionId
      AND bd.ParentProductId = @parentProductId

    UNION ALL

    -- Recursive member: lấy các thành phần con sâu hơn
    SELECT
        bd.BomId,
        bd.VersionID,
        bd.ParentProductID,
        bd.ChildProductID,
        bd.Quantity,
        bd.Sequence,
        bd.IsCritical,
        cte.Level + 1 AS Level,
        CAST(cte.AccumulatedQuantity * bd.Quantity AS DECIMAL(18,4)) AS AccumulatedQuantity,
        CAST(CONCAT(cte.Path, '>', bd.ChildProductID) AS CHAR(1000)) AS Path,
        CASE
            WHEN cte.Path LIKE CONCAT('%>', bd.ChildProductID, '>%')
                 OR cte.Path LIKE CONCAT(bd.ChildProductID, '>%')
                 OR cte.Path LIKE CONCAT('%>', bd.ChildProductID)
            THEN 1
            ELSE 0
        END AS IsCycle
    FROM bom bd
    INNER JOIN BOM_CTE cte ON bd.ParentProductID = cte.ChildProductID
    WHERE bd.VersionID = (
        SELECT bv.VersionId 
        FROM BOMVersion bv 
        WHERE bv.ParentProductId = cte.ChildProductID 
          AND bv.IsDefault = 1
        LIMIT 1
    )
      AND cte.IsCycle = 0
)
-- Kết quả cuối cùng, kết hợp thông tin sản phẩm cha và con
SELECT
    cte.Level,
    cte.Sequence,
    cte.BomId,
    child.ProductCode AS ComponentCode,
    child.ProductName AS ComponentName,
    child.ProductType,
    cte.Quantity AS QtyPerParent,
    cte.AccumulatedQuantity AS TotalQtyForRoot,
    cte.IsCritical,
    child.BaseUOM AS UOM,
    parent.ProductCode AS ParentCode,
    parent.ProductName AS ParentName,
    cte.Path,
    CONCAT(
        REPEAT('    ', cte.Level - 1),
        IF(cte.Level > 1, '├─ ', ''),
        child.ProductName
    ) AS DisplayName
FROM BOM_CTE cte
INNER JOIN products parent ON cte.ParentProductID = parent.ProductID
INNER JOIN products child ON cte.ChildProductID = child.ProductID
ORDER BY cte.Path;";
            return await db.Database
            .SqlQueryRaw<BomTreeCTE>(sql, new MySqlParameter("@versionId", versionId),
    new MySqlParameter("@parentProductId", parentProductId))
            .ToListAsync();
        }


        public async Task<BomDto?> GetBomById(int id)
        {
            using var db = _dbFactory.CreateDbContext();
            return await db.Set<Bom>().Where(x => x.BomId == id)
                .Join(
                db.Products
                , b => b.ParentProductId,
                p => p.ProductId,
                (b, p) => new { b, p })
                .Join(db.Products, pbc => pbc.b.ChildProductId, pc => pc.ProductId, (pcb, pc) => new { pcb, pc })
                .Join(db.BomVersions,
                bp => bp.pcb.b.VersionId,
                bv => bv.VersionId,
                (pb, bv) => new BomDto()
                {
                    BomId = pb.pcb.b.BomId,
                    VersionId = bv.VersionId,
                    ProductCode = pb.pcb.p.ProductCode,
                    BomVersion = bv.BOMVersion,
                    ChildProductId = pb.pcb.b.ChildProductId,
                    ChildProductCode = pb.pc.ProductCode,
                    ChildProductName = pb.pc.ProductName,
                    ParentBomId = pb.pcb.b.ParentBomId,
                    UOM = pb.pc.BaseUOM,
                    TrackingMethod = pb.pc.TrackingMethod,
                    ProductType = pb.pc.ProductType,
                    IsCritical = pb.pcb.b.IsCritical,
                    ProductName = pb.pcb.p.ProductName,
                    AlternateGroup = pb.pcb.b.AlternateGroup,
                    ChangeReason = pb.pcb.b.ChangeReason,
                    ExpiryDate = pb.pcb.b.ExpiryDate,
                    Quantity = pb.pcb.b.Quantity,
                    Sequence = pb.pcb.b.Sequence,
                    EffectiveDate = pb.pcb.b.EffectiveDate
                }).FirstOrDefaultAsync();
        }
        public async Task<bool> SaveBomAsync(Bom entity)
        {
            bool saveSuccess = true;
            using var db = _dbFactory.CreateDbContext();
            var existBom = await db.Set<Bom>().FirstOrDefaultAsync(x => x.BomId == entity.BomId);
            try
            {
                if (existBom != null)
                {
                    existBom.VersionId = entity.VersionId;
                    existBom.Sequence = entity.Sequence;
                    existBom.AlternateGroup = entity.AlternateGroup;
                    existBom.ChildProductId = entity.ChildProductId;
                    if (entity.ParentProductId != 0 && entity.ParentBomId != null)
                    {
                        existBom.ParentProductId = entity.ParentProductId;
                        existBom.ParentBomId = entity.ParentBomId;
                    }
                    existBom.ChangeReason = entity.ChangeReason;
                    existBom.EffectiveDate = entity.EffectiveDate;
                    existBom.ExpiryDate = entity.ExpiryDate;
                    existBom.IsCritical = entity.IsCritical;
                    existBom.Quantity = entity.Quantity;
                    await db.SaveChangesAsync();
                }
                else
                {
                    db.Add(entity);
                    await db.SaveChangesAsync();
                }
            }
            catch (Exception ex)
            {
                Logger.LogError(ex);
                saveSuccess = false;
            }
            return saveSuccess;

        }
        public async Task<List<BomVerHistory>> GetBomVersionByProductId(long id)
        {
            await using var db = _dbFactory.CreateDbContext();
            var query = db.Set<BomVersion>().Include(c => c.Boms)
            .Select(x => new BomVerHistory
            {
                VersionId = x.VersionId,
                BomVersion = x.BOMVersion,
                EffectiveDate = x.EffectiveDate,
                ExpiryDate = x.ExpiryDate,
                ParentProductId = x.ParentProductId,
                IsDefault = x.IsDefault,
                Components = x.Boms.ToList().Count()

            });
            return await query.Where(x => x.ParentProductId == id).ToListAsync();
        }
        public async Task<List<ProductLookup>> GetProductLookup(string searchText, Expression<Func<Products, bool>>? filter)
        {
            await using var db = _dbFactory.CreateDbContext();
            var query = db.Products.AsQueryable();

            if (filter != null)
                query = query.Where(filter);

            if (!string.IsNullOrWhiteSpace(searchText))
            {
                query = query.Where(x =>
                    x.ProductCode.Contains(searchText) ||
                    x.ProductName.Contains(searchText));
            }
            // Trả về kết quả
            return await query
                .Select(x => new ProductLookup
                {
                    ProductId = x.ProductId,
                    ProductCode = x.ProductCode,
                    ProductName = x.ProductName,
                    ProductType = x.ProductTypeText,
                    TrackingMethod = x.TrackingMethodText,
                    BaseUOM = x.BaseUOM
                })
                .Take(50)
                .ToListAsync();
        }

    }
}
