using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace AppGenealogySystem.Models
{
    public class MaterialSubstitutions
    {
        [Key]
        public int SubstitutionId { get; set; }
        [Required]
        public int OriginalBOMId { get; set; }
        [Required]
        public long OriginalProductId { get; set; }
        [Required]
        public long SubstituteProductId { get; set; }
        [Required]
        [MaxLength(200)]
        public string SubstitutionReason { get; set; }
        [Required]
        public int ApprovedBy { get; set; }
        [Required]
        public DateTime ApprovedDate { get; set; }
        [Required]
        public DateTime EffectiveDate { get; set; }
        public DateOnly? ExpireDate { get; set; }
        public bool IsActive { get; set; }=true;
        public DateTime CreatedDate { get; set; }

        public Products Products { get; set; }
        public Products SubtituteP { get; set; }
        public Bom Boms { get; set; }
        public Operators Operators { get; set; } 

    }
}
