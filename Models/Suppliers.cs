using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AppGenealogySystem.Models
{
    public class Suppliers
    {
        [Key]
        public int SupplierId { get; set; }
        [Required]
        [MaxLength(50)]
        public string SupplierCode { get; set; }
        [Required]
        [MaxLength(200)]
        public string SupplierName { get; set; }

        [Required]
        [MaxLength(300)]
        public string ContactInfo { get; set; }
        public byte QualityRating { get; set; }
        public byte CertStatus { get; set; }

        public bool IsActive { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.Now;
        public ICollection<Lots> Supplier { get; set; }
    }
}
