using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppGenealogySystem.Models.Dto
{
    public class BomVerDto
    {
        public int VersionId { get; set; }
        public string BomVersion { get; set; }
        public DateOnly EffectiveDate { get; set; }
        public DateOnly? ExpiryDate { get; set; }
        public string EffectDateText { get; set; }
        public string? ExpiryDateText { get; set; }
        public bool IsDefault { get; set; }
        public long ParentProductId { get; set; }
        public int Sequence { get; set; }
        public int? Components { get; set; }
        public ICollection<Bom> Boms { get; set; }
        public string VersionActive => IsDefault ? $"{BomVersion}(Active)" : BomVersion;
    }

    public class BomVerHistory()
    {
        public int VersionId { get; set; }
        public string BomVersion { get; set; }
        public DateOnly EffectiveDate { get; set; }
        public DateOnly? ExpiryDate { get; set; }
        public bool IsDefault { get; set; }
        public long ParentProductId { get; set; }
        public int? Components { get; set; }
        public ICollection<Bom> Boms { get; set; }
        public int CreatedBy { get; set; }
    }
}
