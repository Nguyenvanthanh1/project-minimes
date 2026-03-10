using AppGenealogySystem.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using System.Diagnostics;

namespace AppGenealogySystem.Context
{
    public class AppDBContext : DbContext
    {
        public DbSet<Products> Products { get; set; }
        public DbSet<Bom> Bom { get; set; }
        public DbSet<Suppliers> Suppliers { get; set; }
        public DbSet<Lots> Lots { get; set; }
        public DbSet<Operators> Operators { get; set; }
        public DbSet<SerialNumbers> SerialNumbers { get; set; }
        public DbSet<ProductionStations> ProductionStations { get; set; }
        public DbSet<WorkOrders> workOrders { get; set; }
        public DbSet<GenealogyTransactions> GenealogyTransactions { get; set; }
        public DbSet<UnitOfMeasureConversions> UnitOfMeasureConversions { get; set; }
        public DbSet<WorkOrderMaterials> WorkOrderMaterials { get; set; }
        public DbSet<InventoryTransactions> InventoryTransactions { get; set; }
        public DbSet<BomVersion> BomVersions { get; set; }


        public AppDBContext(DbContextOptions<AppDBContext> options)
        : base(options)
        {
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionString = "server=localhost;port=3306;user=root;password=123456;database=project_app;";
            if (!string.IsNullOrEmpty(connectionString))
            {
                if (!optionsBuilder.IsConfigured)
                {
                    optionsBuilder.UseMySql(
                        connectionString,
                        ServerVersion.AutoDetect(
                            connectionString
                        )
                    ).LogTo(message =>
                    {
                        // Ghi vào file log
                        File.AppendAllText("sql_log.txt", message + Environment.NewLine);
                    }, LogLevel.Information);
                }
                Console.WriteLine("Connect DB Success");
            }
            else
            {
                Console.WriteLine("Config DB Fail");
            }

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Bom model
            modelBuilder.Entity<Bom>(entity =>
            {
                //Constrain Check 
                entity.ToTable(x => x.HasCheckConstraint("CK_BOM_NoSelfRef", "ParentProductId != ChildProductId"));
                entity.ToTable(x => x.HasCheckConstraint("CK_BOM_Dates", "ExpiryDate IS NULL OR ExpiryDate > EffectiveDate"));
                // FK: Parent
                entity.HasOne(x => x.ParentProduct)
                      .WithMany(p => p.ParentBoms)
                      .HasForeignKey(x => x.ParentProductId)
                      .HasConstraintName("FK_Bom_Parent")
                      .OnDelete(DeleteBehavior.Restrict);

                // FK: Child
                entity.HasOne(x => x.ChildProduct)
                      .WithMany(p => p.ChildBoms)
                      .HasForeignKey(x => x.ChildProductId)
                      .HasConstraintName("FK_Bom_Child")
                      .OnDelete(DeleteBehavior.Restrict);
                entity.HasOne(x => x.BomVersion)
                       .WithMany(x => x.Boms)
                       .HasForeignKey(x => x.VersionId)
                       .HasConstraintName("FK_Bomversion_Bom")
                       .OnDelete(DeleteBehavior.Restrict);
                // Index 
                entity.HasIndex(x => x.ParentProductId)
                      .HasDatabaseName("IX_Bom_ParentId");

                entity.HasOne(x => x.ParentBom)
                .WithMany(x => x.ChildBom)
                .HasForeignKey(x => x.ParentBomId)
                .HasConstraintName("FK_BOM_Child_Parent").OnDelete(DeleteBehavior.Restrict);
                entity.HasIndex(x => x.ChildProductId)
                      .HasDatabaseName("IX_Bom_ChildId");
                entity.HasIndex(x => new { x.EffectiveDate, x.ExpiryDate })
                      .HasDatabaseName("IX_Bom_Effective");
                entity.HasIndex(e => new { e.ParentProductId, e.ChildProductId, e.EffectiveDate })
             .IsUnique()
             .HasDatabaseName("UQ_BOM_Structure");
            });


            // Lots Model
            modelBuilder.Entity<Lots>(entity =>
            {
                // AS
                entity.Property(x => x.QuantityAvailable).HasComputedColumnSql("`QuantityRemaining` - `QuantityReserved`", stored: true);
                //Row Version
                entity.Property(x => x.RowVersion).IsRowVersion().ValueGeneratedOnAddOrUpdate();
                entity.HasIndex(x => x.LotNumber).HasDatabaseName("IX_Lots_Number").IsUnique();
                //IX
                entity.HasIndex(x => new { x.ProductId, x.Status, x.QuantityStatus }).HasDatabaseName("IX_Lots_Product");
                entity.HasIndex(x => new { x.Status, x.ExpiryDate }).HasDatabaseName("IX_Lots_Status");
                entity.HasIndex(x => x.WOId).HasDatabaseName("IX_Lots_WO");
                entity.HasIndex(x => x.ParentLotId).HasDatabaseName("IX_Lots_Parent");
                //Check 
                entity.ToTable(e => e.HasCheckConstraint("CK_Lot_Quantity", "QuantityRemaining >= 0 AND QuantityRemaining <= QuantityTotal"));
                entity.ToTable(e => e.HasCheckConstraint("CK_Lot_Reserve", "QuantityReserved >= 0 AND QuantityReserved <= QuantityRemaining"));
                //FK
                //Supplier
                entity.HasOne(x => x.SuppliersLot)
                .WithMany(sp => sp.Supplier)
                .HasForeignKey(x => x.SupplierId)
                .HasConstraintName("FK_Lot_Supplier")
                .OnDelete(DeleteBehavior.Restrict);
                //Product
                entity.HasOne(x => x.ProductsLot)
                .WithMany(p => p.ProductLots)
                .HasForeignKey(x => x.ProductId)
                .HasConstraintName("FK_Lot_Product")
                .OnDelete(DeleteBehavior.Restrict);
                //WorkOrder
                entity.HasOne(x => x.WorkOrders)
                .WithMany(x => x.Lots).HasForeignKey(x => x.WOId)
                .HasConstraintName("FK_Lot_WO").OnDelete(DeleteBehavior.Restrict);
                //Lot
                entity.HasOne(x => x.ParentLots).WithMany(x => x.ChildLot).HasForeignKey(x => x.ParentLotId)
                .HasConstraintName("FK_Lot_Parent").OnDelete(DeleteBehavior.Restrict);


            }

            );
            // SerialNumber Model

            modelBuilder.Entity<SerialNumbers>(entity =>
            {
                //RowVersion
                entity.Property(x => x.RowVersion).IsRowVersion().ValueGeneratedOnAddOrUpdate();
                //IX
                entity.HasIndex(x => x.SerialNumber).HasDatabaseName("IX_SN_Number").IsUnique();
                entity.HasIndex(x => new { x.ProductId, x.Status }).HasDatabaseName("IX_SN_Product");
                entity.HasIndex(x => x.WorkOrderId).HasDatabaseName("IX_SN_WO");
                entity.HasIndex(x => new { x.ParentSerialId, x.HierarchyLevel }).HasDatabaseName("IX_SN_Parent");
                entity.HasIndex(x => new { x.Status, x.CompletedDate }).HasDatabaseName("IX_SN_Status");

                //FK
                //FK:Product
                entity.HasOne(x => x.Products)
                .WithMany(p => p.SNProduct)
                .HasForeignKey(x => x.ProductId)
                .HasConstraintName("FK_SN_Product")
                .OnDelete(DeleteBehavior.Restrict);
                //FK:ParentSerial
                entity
                .HasOne(x => x.ParentSN)
                .WithMany(sn => sn.SN)
                .HasForeignKey(x => x.ParentSerialId)
                .HasConstraintName("FK_SN_Parent")
                .OnDelete(DeleteBehavior.Restrict);
                //FK WorkOrder
                entity.HasOne(x => x.SNWorkOrder)
                .WithMany(x => x.SN)
                .HasForeignKey(x => x.WorkOrderId)
                .HasConstraintName("FK_SN_WO")
                .OnDelete(DeleteBehavior.Restrict);
                //FK Lot
                entity.HasOne(x => x.Lots).WithMany(x => x.SN).HasForeignKey(x => x.SourceLotId)
                .HasConstraintName("FK_SN_Lot").OnDelete(DeleteBehavior.Restrict);

            });

            //Genealogy Transaction Model

            modelBuilder.Entity<GenealogyTransactions>(entity =>
            {

                //Index
                entity.HasIndex(e => new { e.ParentSerialId, e.TransactionDate }).HasDatabaseName("IX_GT_Parent");
                entity.HasIndex(e => new { e.ChildLotId, e.TransactionDate }).HasDatabaseName("IX_GT_Child");
                entity.HasIndex(e => new { e.ChildSerialId, e.TransactionDate }).HasDatabaseName("IX_GT_Serial");
                entity.HasIndex(x => x.OperationBatchId).HasDatabaseName("IX_GT_Batch");
                entity.HasIndex(x => x.TransactionDate).HasDatabaseName("IX_GT_Date");
                entity.HasIndex(e => new { e.WorkOrderId, e.TransactionDate }).HasDatabaseName("IX_GT_WO");
                entity.HasIndex(e => new { e.ParentSerialId, e.ChildSerialId, e.ChildLotId, e.ChildType, e.QuantityUsed, e.TransactionDate, e.StationId })
                .HasDatabaseName("IX_GT_Trace_Covering");
                entity.HasIndex(e => new { e.ChildLotId, e.ParentSerialId, e.QuantityUsed, e.TransactionDate })
                .HasDatabaseName("IX_GT_ReverseTrace");

                //CK 
                entity.ToTable(x => x.HasCheckConstraint("CK_GT_ChildType", "(ChildType = 0 AND ChildLotId IS NOT NULL AND ChildSerialId IS NULL) OR  (ChildType = 1 AND ChildLotId IS NULL AND ChildSerialId IS NOT NULL)"));
                entity.ToTable(x => x.HasCheckConstraint("CK_GT_Reverse", "(IsReversed = 0 AND ReversedById IS NULL AND ReversedDate IS NULL) OR (IsReversed = 1 AND ReversedById IS NOT NULL AND ReversedDate IS NOT NULL)"));
                entity.ToTable(x => x.HasCheckConstraint("CK_GT_Quantity", "QuantityUsed > 0"));
                //FK 
                //FK Parent Serial
                entity
                .HasOne(x => x.ParentSN)
                .WithMany(sn => sn.ParentSNGenealogy)
                .HasForeignKey(x => x.ParentSerialId)
                .HasConstraintName("FK_GT_Parent")
                .OnDelete(DeleteBehavior.Restrict);
                //FK Child Lot
                entity.HasOne(x => x.LotGT)
                .WithMany(x => x.GenealogyLots)
                .HasForeignKey(x => x.ChildLotId)
                .HasConstraintName("FK_GT_Lot")
                .OnDelete(DeleteBehavior.Restrict);
                //FK Child Serial
                entity.HasOne(x => x.ChildSN)
                .WithMany(x => x.ChildSNGenealogy)
                .HasForeignKey(x => x.ChildSerialId)
                .HasConstraintName("FK_GT_Serial")
                .OnDelete(DeleteBehavior.Restrict);
                // FK Operator
                entity.HasOne(x => x.Operators)
                .WithMany(x => x.GT)
                .HasForeignKey(x => x.OperationId).HasConstraintName("FK_GT_Operator")
                .OnDelete(DeleteBehavior.Restrict);
                //FK WorkOrder
                entity.HasOne(x => x.workOrders)
                .WithMany(x => x.GT)
                .HasForeignKey(x => x.WorkOrderId).HasConstraintName("FK_GT_WO")
                .OnDelete(DeleteBehavior.Restrict);
                //FK Bom
                entity.HasOne(x => x.Boms)
                .WithMany(x => x.GT)
                .HasForeignKey(x => x.BomId).HasConstraintName("FK_GT_BOM")
                .OnDelete(DeleteBehavior.Restrict);
                //FK ProductionStation
                entity.HasOne(x => x.PStation)
                .WithMany(x => x.GT)
                .HasForeignKey(x => x.StationId)
                .HasConstraintName("FK_GT_Station").OnDelete(DeleteBehavior.Restrict);
                // FK Reverse GT
                entity.HasOne(x => x.GT).WithMany(x => x.ReverseGT)
                .HasForeignKey(x => x.ReversedById).HasConstraintName("FK_GT_Reversed")
                .OnDelete(DeleteBehavior.Restrict);


            });

            // Operator Model
            modelBuilder.Entity<Operators>().HasIndex(x => x.OperatorCode).HasDatabaseName("IX_Operators_Code").IsUnique();
            modelBuilder.Entity<Operators>().HasIndex(x => new { x.Department, x.Role, x.IsActive }).HasDatabaseName("IX_Operators_Dept");

            ////Supplier Model 
            modelBuilder.Entity<Suppliers>(entity =>
            {
                //entity.Property(e => e.SupplierName).HasMaxLength(200); 
                entity.HasIndex(x => x.SupplierCode).HasDatabaseName("IX_Suppliers_Code");
                entity.HasIndex(x => new { x.CertStatus, x.IsActive }).HasDatabaseName("IX_Suppliers_Status");
            });

            // Product Model
            //Create index product type
            modelBuilder.Entity<Products>().HasIndex(p => p.ProductCode).HasDatabaseName("IX_Product_Code").IsUnique();
            modelBuilder.Entity<Products>().HasIndex(p => p.TrackingMethod).HasDatabaseName("IX_Product_Tracking");
            //Create index product code
            modelBuilder.Entity<Products>().HasIndex(p => new { p.ProductType, p.IsActive }).HasDatabaseName("IX_Product_Type");
            //1-N
            modelBuilder.Entity<Products>().HasMany(x => x.UOM).WithOne(x => x.ProductUOM).HasForeignKey(x => x.ProductId).OnDelete(DeleteBehavior.Restrict);
            modelBuilder.Entity<Products>().Property(e => e.RowVersion)
              .IsRowVersion()
              .ValueGeneratedOnAddOrUpdate();

            // UOM Model 
            modelBuilder.Entity<UnitOfMeasureConversions>(entity =>
            {
                entity.HasIndex(x => new { x.FromUOM, x.ToUOM, x.ProductId }).HasDatabaseName("UQ_UOM_Conversion").IsUnique();
            });

            //WorkOrder Model 
            modelBuilder.Entity<WorkOrders>(entity =>
            {
                //IX
                entity.HasIndex(x => x.WONumber).HasDatabaseName("IX_WO_Number").IsUnique();
                entity.HasIndex(x => new { x.Status, x.ProductId }).HasDatabaseName("IX_WO_Product");
                entity.HasIndex(x => new { x.Status, x.PlannedStart }).HasDatabaseName("IX_WO_Status");
                entity.HasIndex(x => new { x.PlannedStart, x.PlannedEnd }).HasDatabaseName("IX_WO_Date");


                //FK
                entity.HasOne(x => x.Products).WithMany(x => x.WorkOrders)
                .HasForeignKey(x => x.ProductId)
                .HasConstraintName("FK_WO_Product").OnDelete(DeleteBehavior.Restrict);
                entity.HasOne(x => x.ParentWO).WithMany(x => x.WO)
                .HasForeignKey(x => x.WorkOrderId)
                .HasConstraintName("FK_WO_Parent").OnDelete(DeleteBehavior.Restrict);

            });
            //BomVersion Model 
            modelBuilder.Entity<BomVersion>(entity =>
            {
                entity.HasKey(bv => bv.VersionId);
                entity.HasIndex(x => new { x.EffectiveDate, x.ExpiryDate }).HasDatabaseName("IX_Date");
                entity.HasIndex(x => new { x.ParentProductId, x.IsDefault }).HasDatabaseName("IX_ParentProductId");
                entity.HasOne(bv => bv.Products)
              .WithMany(p => p.BomVersions)
              .HasForeignKey(bv => bv.ParentProductId)
              .HasConstraintName("FK_Product_BomVersion")
              .OnDelete(DeleteBehavior.Restrict);

                entity.HasIndex(x => new { x.ParentProductId, x.BOMVersion }).IsUnique();
            });
            //Production Station Model
            modelBuilder.Entity<ProductionStations>(entity =>
            {
                entity.HasIndex(x => x.StationCode).HasDatabaseName("IX_Stations_Code").IsUnique();
                entity.HasIndex(x => new { x.StationType, x.IsActive });
            });
            //WorkOrder Material Model

            modelBuilder.Entity<WorkOrderMaterials>(entity =>
            {

                //IX
                entity.HasIndex(x => new { x.WorkOrderId, x.Status }).HasDatabaseName("IX_WOM_WO");
                entity.HasIndex(x => x.ProductId).HasDatabaseName("IX_WOM_Product");
                entity.HasIndex(x => x.AllocatedLotId).HasDatabaseName("IX_WOM_Lot");

                //FK
                //Product
                entity.HasOne(x => x.Products).WithMany(x => x.WOM)
                .HasForeignKey(x => x.ProductId).HasConstraintName("FK_WOM_Product").OnDelete(DeleteBehavior.Restrict);
                //Work Order 
                entity.HasOne(x => x.WorkOrders).WithMany(x => x.WOM)
                .HasForeignKey(x => x.WorkOrderId).HasConstraintName("FK_WOM_WO").OnDelete(DeleteBehavior.Restrict);
                //Bom 
                entity.HasOne(x => x.Bom).WithMany(x => x.WOM)
                .HasForeignKey(x => x.BomId).HasConstraintName("FK_WOM_Bom").OnDelete(DeleteBehavior.Restrict);
                //Lot 
                entity.HasOne(x => x.Lots).WithMany(x => x.WOM).HasForeignKey(x => x.AllocatedLotId)
                .HasConstraintName("FK_WOM_Lot").OnDelete(DeleteBehavior.Restrict);

            });
            //MaterialSubstitutions Model 
            modelBuilder.Entity<MaterialSubstitutions>(entity =>
            {

                //IX
                entity.HasIndex(x => new { x.OriginalBOMId, x.EffectiveDate }).HasDatabaseName("IX_Sub_Original");
                entity.HasIndex(x => new { x.OriginalProductId, x.SubstituteProductId }).HasDatabaseName("IX_Sub_Product");

                //FK
                //Bom
                entity.HasOne(x => x.Boms).WithMany(x => x.MS)
                .HasForeignKey(x => x.OriginalBOMId)
                .HasConstraintName("FK_Sub_OriginalBOM").OnDelete(DeleteBehavior.Restrict);
                //Operator
                entity.HasOne(x => x.Operators).WithMany(x => x.MS)
               .HasForeignKey(x => x.ApprovedBy)
               .HasConstraintName("FK_Sub_Approver").OnDelete(DeleteBehavior.Restrict);
                //Product 
                entity.HasOne(x => x.Products).WithMany(x => x.MS)
              .HasForeignKey(x => x.OriginalProductId)
              .HasConstraintName("FK_Sub_OriginalProd").OnDelete(DeleteBehavior.Restrict);
                // Sub Product
                entity.HasOne(x => x.SubtituteP).WithMany(x => x.SubMS)
              .HasForeignKey(x => x.SubstituteProductId)
              .HasConstraintName("FK_Sub_SubstProd").OnDelete(DeleteBehavior.Restrict);

                // Inventory Transaction Model
                modelBuilder.Entity<InventoryTransactions>(entity =>
                {
                    //IX
                    entity.HasIndex(x => x.WorkOrderId).HasDatabaseName("IX_Inv_WO");
                    entity.HasIndex(x => new { x.LotId, x.TransactionDate }).HasDatabaseName("IX_Inv_Lot");
                    entity.HasIndex(x => new { x.SerialId, x.TransactionDate }).HasDatabaseName("IX_Inv_Serial");
                    entity.HasIndex(x => new { x.TransactionType, x.TransactionDate }).HasDatabaseName("IX_Inv_Type");
                    //Check
                    entity.ToTable(x => x.HasCheckConstraint("CK_Inv_Type", "(LotId IS NOT NULL AND SerialId IS NULL) OR (LotId IS NULL AND SerialId IS NOT NULL)"));
                    //FK
                    //Lots
                    entity.HasOne(x => x.Lots).WithMany(x => x.IT)
              .HasForeignKey(x => x.LotId)
              .HasConstraintName("FK_Inv_Lot").OnDelete(DeleteBehavior.Restrict);
                    //Serial Number 
                    entity.HasOne(x => x.SerialNumbers).WithMany(x => x.IT)
              .HasForeignKey(x => x.SerialId)
              .HasConstraintName("FK_Inv_Serial").OnDelete(DeleteBehavior.Restrict);
                    //Work Order
                    entity.HasOne(x => x.WorkOrders).WithMany(x => x.IT)
              .HasForeignKey(x => x.WorkOrderId)
              .HasConstraintName("FK_Inv_WO").OnDelete(DeleteBehavior.Restrict);
                    //Operator
                    entity.HasOne(x => x.Operators).WithMany(x => x.IT)
              .HasForeignKey(x => x.OperatorId)
              .HasConstraintName("FK_Inv_Operator").OnDelete(DeleteBehavior.Restrict);

                });
                //AuditLog Model
                modelBuilder.Entity<AuditLog>(entity =>
                {
                    entity.HasIndex(x => x.ModifiedDate).HasDatabaseName("IX_Audit_Date");
                    entity.HasIndex(x => new { x.ModifiedDate, x.ModifiedBy }).HasDatabaseName("IX_Audit_User");
                    entity.HasIndex(x => new { x.TableName, x.RecordId, x.ModifiedDate }).HasDatabaseName("IX_Audit_Table");

                });

            });
            base.OnModelCreating(modelBuilder);
        }
    }
}
