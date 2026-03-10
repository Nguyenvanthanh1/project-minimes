using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
namespace AppGenealogySystem.Models
{
    public class InventoryTransactions
    {
        [Key]
        public int InvTransId { get; set; }
        public long? LotId { get; set; }
        public long? SerialId { get; set; }
        [Required]
        public byte TransactionType { get; set; }
        [Required]
        [Column(TypeName ="decimal(18,4)")]
        public decimal Quantity { get; set; }
        public int? WorkOrderId { get; set; }
        public string? ReferenceDocs { get; set; }
        public string? FormLocation { get; set; }
        public string? ToLocation { get; set; }
        public int? OperatorId { get; set; }
        public DateTime TransactionDate { get; set; }= DateTime.Now;
        [MaxLength(500)]
        public string? Notes { get; set; }
        public DateTime CreatedDate { get; set; }= DateTime.Now;

        public SerialNumbers SerialNumbers {  get; set; }
        public Lots Lots { get; set; }
        public WorkOrders WorkOrders { get; set; }
        public Operators Operators { get; set; }




    }
}
