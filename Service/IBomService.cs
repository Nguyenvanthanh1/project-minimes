
using AppGenealogySystem.Models;
using AppGenealogySystem.Models.Dto;
using System.ComponentModel;
using System.Linq.Expressions;

namespace AppGenealogySystem.Service
{
    public interface IBomService
    {
        Task<List<ProductDto>> GetCodeAndName();
        Task<List<ProductLookup>> GetProductLookup(string searchText, Expression<Func<Products, bool>>? filter);
        void AddAsync(BomVersion entity);
        Task<List<BomVerDto>> GetListVersionAsync(long? parentProductId);
        void WarmUp();
        Task<List<BomTreeNode>> GetListBom(int versionId);
        Task<List<BomVersionProduct>> GetBomVersionProduct(int versionId);
        Task<bool> SaveBomAsync(Bom entity);
        Task<BomVerDto?> GetDataVersionById(int versionId);
        Task<List<BomTreeCTE>> GetTreeBomNode(long parentProductId, int versionId);
        Task<BomDto?> GetBomById(int id);
        Task<List<BomVersionProduct>> GetParentComponent(int? parentBomId);
        Task<List<BomVerHistory>> GetBomVersionByProductId(long id);

    }
}