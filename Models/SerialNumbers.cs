using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace AppGenealogySystem.Models
{
    public class SerialNumbers
    {
        [Key]
        public long SerialId { get; set; }
        [Required]
        [MaxLength(100)]
        public string SerialNumber { get; set; }
        [Required]
        public long ProductId  { get; set; }
        public byte Status { get; set; } = 0;
        [MaxLength(100)]
        public string? CurrentLocation { get; set; }
        [Required]
        public int WorkOrderId { get; set; }
        public int? ECOId { get; set; }
        public long? SourceLotId { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.Now;
        public DateTime? ShippedDate { get; set; }
        [MaxLength(200)]
        public string? ShippedTo { get; set; }
        public DateTime? CompletedDate { get; set; }
        public long? ParentSerialId { get; set; } 
        public int HierarchyLevel { get; set; } = 0;
        [MaxLength(500)]
        public string? Notes { get; set; }

        [MaxLength(20)]
        public string? ProductRevision { get; set; }
        public byte[] RowVersion { get; set; }

        public Products Products { get; set; }
        public SerialNumbers ParentSN { get; set; }
        public WorkOrders SNWorkOrder { get; set; }
        public Lots Lots { get; set; }

        public ICollection<SerialNumbers> SN {  get; set; }
        public ICollection<GenealogyTransactions> ParentSNGenealogy {  get; set; }= new List<GenealogyTransactions>();
        public ICollection<GenealogyTransactions> ChildSNGenealogy {  get; set; }=new List<GenealogyTransactions>();
        public ICollection<InventoryTransactions> IT {  get; set; }=new List<InventoryTransactions>();
        
    }
}
