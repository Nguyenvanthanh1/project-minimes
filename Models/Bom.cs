using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace AppGenealogySystem.Models
{
    public class Bom
    {
        [Key]
        public int BomId { get; set; }
        [Required]
        public long ParentProductId { get; set; }
        [Required]
        public long ChildProductId { get; set; }
        [Required]
        [Column(TypeName = "decimal(18,4)")]
        public decimal Quantity { get; set; }
        public bool IsCritical { get; set; }
        public int? ParentBomId { get; set; }
        public int Sequence { get; set; }
        [Required]
        public DateOnly EffectiveDate { get; set; }
        public DateOnly? ExpiryDate { get; set; }
        public int CreatedBy { get; set; } = 1;
        public int ModifiedBy { get; set; } = 1;
        [Required]
        public int VersionId { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.Now;
        public DateTime ModifiedDate { get; set; }
        [Required]
        [MaxLength(20)]
        public string? AlternateGroup { get; set; }
        [Required]
        [MaxLength(50)]
        public string? ChangeReason { get; set; }
        public Products ParentProduct { get; set; }
        public Products ChildProduct { get; set; }
        public Bom ParentBom { get; set; }
        public ICollection<Bom> ChildBom { get; set; }
        public ICollection<WorkOrderMaterials> WOM { get; set; } = new List<WorkOrderMaterials>();
        public ICollection<GenealogyTransactions> GT { get; set; } = new List<GenealogyTransactions>();
        public ICollection<MaterialSubstitutions> MS { get; set; } = new List<MaterialSubstitutions>();
        public BomVersion BomVersion { get; set; }

    }
}
