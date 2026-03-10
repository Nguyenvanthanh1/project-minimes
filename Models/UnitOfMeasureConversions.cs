using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AppGenealogySystem.Models
{
    public class UnitOfMeasureConversions
    {
        [Key]
        public int ConversionId { get; set; }
        [Required]
        [MaxLength(20)]
        public string FromUOM { get; set; }
        [Required]
        [MaxLength(20)]
        public string ToUOM { get; set; }
        [Required]
        public long? ProductId { get; set; }
        [Required]
        [Column(TypeName ="decimal(18,4)")]
        public decimal ConversionFactor { get; set; }
        public bool IsActive { get; set; } = true;

        public  Products ProductUOM { get; set; }
    }
}
