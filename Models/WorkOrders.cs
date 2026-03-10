using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace AppGenealogySystem.Models
{
    public class WorkOrders
    {
        [Key]
        public int WorkOrderId { get; set; }

        [MaxLength(50)]
        public string WONumber { get; set; }
        [Required]
        public long ProductId { get; set; }
        public byte WOType { get; set; }
        [Required]
        [Column(TypeName ="decimal(18,4)")]
        public decimal QuantityPlanned {  get; set; }
        [Column(TypeName = "decimal(18,4)")]
        public decimal QuantityCompleted { get; set; } = 0;

        [Column(TypeName = "decimal(18,4)")]
        public decimal QuantityScrapped { get; set; } = 0;
        public byte Status { get; set; }
        public DateTime PlannedStart { get; set; }
        public DateTime PlannedEnd { get; set; }
        public DateTime? ActualStart { get; set; }
        public DateTime? ActualEnd { get; set; }
        public int ParentWOId { get; set; }
        public int CustomerId { get; set; }
        public int SalesOrderId { get; set; }
        public bool MaterialShortage { get; set; } = false;
        [MaxLength(500)]
        public string Notes { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }= DateTime.Now;
        public int ModifiedBy {  get; set; }
        public DateTime ModifiedDate { get; set; }

        public Products Products { get; set; }

        public ICollection<SerialNumbers> SN { get; set; }
        public ICollection<Lots> Lots { get; set; }
        public ICollection<WorkOrderMaterials> WOM { get; set;  }
        public ICollection<WorkOrders> WO { get; set; }= new List<WorkOrders>();
        public ICollection<GenealogyTransactions> GT { get; set; }=new List<GenealogyTransactions>();
        public ICollection<InventoryTransactions> IT { get; set; }=new List<InventoryTransactions>();
        public WorkOrders ParentWO { get; set; }


    }
}
