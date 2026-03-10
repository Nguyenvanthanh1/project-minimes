using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
namespace AppGenealogySystem.Models
{
    public class AuditLog
    {
        [Key]
        public long AuditId { get; set; }
        [MaxLength(50)]
        public string TableName { get; set; }
        [MaxLength(50)]
        public int RecordId { get; set; }
        [MaxLength(10)]
        public string ActionType { get; set; }
        [MaxLength()]
        public string OldValue { get; set; }
        [MaxLength()]
        public string NewValue { get; set; }
        [Required]
        public int ModifiedBy { get; set; }
        public DateTime ModifiedDate { get; set; }=DateTime.Now;
        [MaxLength(50)]
        public string? IPAdress { get; set; }
        [MaxLength(100)]
        public string? ApplicationName { get; set; }


    }
}
