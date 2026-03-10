
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace AppGenealogySystem.Models
{
    [Table("Bomversion")]
    public class BomVersion
    {
        [Key]
        public int VersionId { get; set; }
        [Required]
        public long ParentProductId { get; set; }
        [Required]
        [MaxLength(50)]
        public string BOMVersion { get; set; }
        [Required]
        public DateOnly EffectiveDate { get; set; }
        public DateOnly? ExpiryDate { get; set; }
        [Required]
        public bool IsDefault { get; set; } = false;
        [MaxLength(255)]
        public string? ChangeReason { get; set; }
        [Required]
        public int CreatedBy { get; set; } = 1;
        [Required]
        public DateTime CreatedDate { get; set; } = DateTime.Now;
        [Required]
        public int ModifiedBy { get; set; } = 1;
        [Required]
        public DateTime ModifiedDate { get; set; } = DateTime.Now;
        public string EffectDateText => EffectiveDate.ToString();
        public string? ExpiryDateText => ExpiryDate.ToString();

        public Products Products { get; set; }
        public ICollection<Bom> Boms { get; set; } = new List<Bom>();
    }
}
