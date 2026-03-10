using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using AppGenealogySystem.Enums;
namespace AppGenealogySystem.Models
{
    [Table("products")]
    public class Products
    {
        [Key]
        public long ProductId { get; set; }
        [Required]
        [MaxLength(50)]
        public string ProductCode { get; set; }
        [Required]
        [MaxLength(200)]
        public string ProductName { get; set; }
        [Required]
        [MaxLength(300)]
        public string? Description { get; set; }

        public ProductType ProductType { get; set; }
        public TrackingMethod TrackingMethod { get; set; }
        [Required]
        [MaxLength(20)]
        public string? BaseUOM { get; set; }
        public int DefaultShelfLife { get; set; }
        [Column(TypeName = "decimal(18,4)")]
        public decimal CostStandard { get; set; }

        [Required]
        [MaxLength(20)]
        public string RevisionCurrent { get; set; } = "A";
        [Required]
        [MaxLength(50)]
        public string DrawingNumber { get; set; }
        public int CreatedBy { get; set; }
        public int ModifiedBy { get; set; }

        public bool IsActive { get; set; } = true;

        public DateTime CreatedDate { get; set; } = DateTime.Now;
        public DateTime ModifiedDate { get; set; }
        public byte[] RowVersion { get; set; }

        public string ProductTypeText => ProductType.ToString();
        public string TrackingMethodText => TrackingMethod.ToString();
        public string StatusText => IsActive ? "Active" : "Inactive";
        public virtual ICollection<Bom> ParentBoms { get; set; } = new List<Bom>();
        public virtual ICollection<Bom> ChildBoms { get; set; } = new List<Bom>();
        public virtual ICollection<WorkOrders> WorkOrders { get; set; } = new List<WorkOrders>();
        public virtual ICollection<Lots> ProductLots { get; set; } = new List<Lots>();
        public virtual ICollection<SerialNumbers> SNProduct { get; set; } = new List<SerialNumbers>();
        public virtual ICollection<WorkOrderMaterials> WOM { get; set; } = new List<WorkOrderMaterials>();

        public virtual ICollection<MaterialSubstitutions> MS { get; set; } = new List<MaterialSubstitutions>();
        public virtual ICollection<MaterialSubstitutions> SubMS { get; set; } = new List<MaterialSubstitutions>();
        public virtual ICollection<BomVersion> BomVersions { get; set; } = new List<BomVersion>();
        public virtual ICollection<UnitOfMeasureConversions> UOM { get; set; } = new List<UnitOfMeasureConversions>();
    }
}
