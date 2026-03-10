using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AppGenealogySystem.Models
{
    public class Lots
    {
        [Key]
        public long LotId { get; set; }
        [Required]
        [MaxLength(50)]
        public string LotNumber { get; set; }
        [Required]
        public long ProductId { get; set; }
        public int? SupplierId { get; set; }
        public int? WOId { get; set; }
        [Required]

        [Column(TypeName ="decimal(18,4)")]
        public decimal QuantityTotal { get; set; }
        [Required]
        [Column(TypeName = "decimal(18,4)")]
        public decimal QuantityRemaining { get; set; }
        [Column(TypeName = "decimal(18,4)")]
        public decimal QuantityReserved { get; set; } = 0;
        public int QuantityAvailable { get; private set; }
        public DateOnly? ManufacturingDate { get; set; }
        public DateOnly? ExpiryDate { get; set; }
        public byte QuantityStatus { get; set; }
        public byte Status { get; set; }
       
        [MaxLength(500)]
        public string? QuantityCert { get; set; }
        public DateTime ReceivedDate { get; set; }
  
        [MaxLength(100)]
        public string? Location { get; set; }
        public long? ParentLotId { get; set; }
        public int? InspectedBy {  get; set; }
        public DateTime? InspectedDate { get; set; }
        [MaxLength(500)]
        public string? Notes { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }= DateTime.Now;
        public byte[] RowVersion { get; set; }



        public Products ProductsLot { get; set; }
        public Suppliers SuppliersLot { get; set; }
        public WorkOrders WorkOrders { get; set; }

        public Lots ParentLots { get; set; }
        public ICollection<Lots> ChildLot { get; set; } = new List<Lots>();
        public ICollection<WorkOrderMaterials> WOM { get; set; }=new List<WorkOrderMaterials>();
        public ICollection<SerialNumbers> SN { get; set; }=new List<SerialNumbers>();
        public ICollection<InventoryTransactions> IT { get; set; }=new List<InventoryTransactions>();

        public ICollection<GenealogyTransactions> GenealogyLots { get; set; }


    }
}
