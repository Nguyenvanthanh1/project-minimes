using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
namespace AppGenealogySystem.Models
{
    public class Operators
    {
        [Key]
        public int OperatorId { get; set; }
        [Required]
        [MaxLength(50)]
        public string OperatorCode { get; set; }
        [Required]
        [MaxLength(100)]
        public string OperatorName { get; set; }
        public byte SkillLevel { get; set; } 
        [Required]
        [MaxLength(50)]
        public string Department { get; set; }
        public byte Role { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreatedDate { get; set; }= DateTime.Now;
        public ICollection<GenealogyTransactions> GT {  get; set; }=new List<GenealogyTransactions>();
        public ICollection<MaterialSubstitutions> MS {  get; set; }=new List<MaterialSubstitutions>();
        public ICollection<InventoryTransactions> IT {  get; set; }=new List<InventoryTransactions>();
    }
}
