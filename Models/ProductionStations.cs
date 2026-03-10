using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace AppGenealogySystem.Models
{
    public class ProductionStations
    {
        [Key]
        public int StationId { get; set; }
        [Required]
        [MaxLength(50)]
        public string StationCode { get; set; }
        [Required]
        [MaxLength (100)]
        public string StationName { get; set; }
        [Required]
        [MaxLength(200)]
        public string? Location { get; set; }
        public byte StationType { get; set; }
        public bool IsActive { get; set; } = true;
        [MaxLength(50)]
        public string? CostCenter { get; set; }

        public DateTime CreatedDate { get; set; }= DateTime.Now;

        public ICollection<GenealogyTransactions> GT {  get; set; } = new List<GenealogyTransactions>();


    }
}
