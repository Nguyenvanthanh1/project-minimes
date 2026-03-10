using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AppGenealogySystem.Models
{
    public class GenealogyTransactions
    {
        [Key]
        public long Id { get; set; }
        [Required]
        public long  ParentSerialId { get; set; }
        [Required]
        public byte ChildType { get; set; }
        public long? ChildLotId { get; set; }
        public long ChildSerialId { get; set; }
        [Required]
        [Column(TypeName ="decimal(18,4)")]
        public decimal QuantityUsed { get; set; }
        public byte TransactionType { get; set; }
        [MaxLength(50)]
        public string? OperationBatchId { get; set; }

        public DateTime TransactionDate { get; set; }
        [Required]
        public int StationId { get; set; }
        [Required]
        public int OperationId { get; set; }
        public int? BomId { get; set; }
        [Required]
        public int WorkOrderId { get; set; }
        public bool IsReversed { get; set; } = false;
        public long? ReversedById { get; set; }
        public DateTime? ReversedDate { get; set; }
        [Required]
        [MaxLength(500)]
        public string Remarks { get; set; }
        public DateTime CreatedDate { get; set; }= DateTime.Now;
        public byte[] RowVersion { get; set; }

        public SerialNumbers ParentSN { get; set; }
        public SerialNumbers ChildSN { get; set; }
        public Operators Operators { get; set; }
        public WorkOrders workOrders    { get; set; }
        public Bom Boms    { get; set; }
        public ProductionStations PStation { get; set; }
        public GenealogyTransactions GT { get; set; }
        public ICollection<GenealogyTransactions> ReverseGT { get; set; }= new List<GenealogyTransactions>();

        public Lots LotGT { get; set; }


    }
}
