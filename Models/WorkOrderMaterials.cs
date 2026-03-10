using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AppGenealogySystem.Models
{
    public class WorkOrderMaterials
    {
        [Key]
        public int WOMateriaId { get; set; }
        [Required]
        public int WorkOrderId { get; set; }
        [Required]
        public int BomId { get; set; }
        [Required]
        public long ProductId { get; set; }
        [Required]
        [Column(TypeName = "decimal(18,4)")]
        public decimal QuantityRequired { get; set; }
        [Column(TypeName = "decimal(18,4)")]
        public decimal QuantityIssued { get; set; } = 0;
        [Column(TypeName = "decimal(18,4)")]
        public decimal QuantityConsumed { get; set; } = 0;
        [Column(TypeName = "decimal(18,4)")]
        public decimal QuantityReturned { get; set; } = 0;
        public byte Status { get; set; } = 0;

        public long  AllocatedLotId { get; set; }
        public DateTime? IssuedDate { get; set; }
        public DateTime? ConsumedDate { get; set; }
        [MaxLength(255)]
        public string? Notes { get; set; }
        public Products Products {  get; set; }

        public WorkOrders WorkOrders { get; set; }
        public Bom Bom { get; set; }
        public Lots Lots { get; set; }
    }
}
