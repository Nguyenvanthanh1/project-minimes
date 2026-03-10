
using AppGenealogySystem.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AppGenealogySystem.Models.Dto
{
    public class BomDto
    {
        public int BomId { get; set; }
        public long ParentProductId { get; set; }
        public string? BomVersion { get; set; }
        public string? ProductName { get; set; }
        public string? ProductCode { get; set; }
        public string? DisplayName => $"{ProductCode} - {ProductName}";
        public long ChildProductId { get; set; }
        public ProductType? ProductType { get; set; }
        public TrackingMethod? TrackingMethod { get; set; }
        public string? UOM { get; set; }
        public string? ChildProductName { get; set; }
        public string? ChildProductCode { get; set; }
        public decimal Quantity { get; set; }
        public bool IsCritical { get; set; }
        public int Sequence { get; set; }
        public int? ParentBomId { get; set; }
        public int VersionId { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.Now;
        public string? AlternateGroup { get; set; }
        public DateOnly EffectiveDate { get; set; }
        public DateOnly? ExpiryDate { get; set; }
        public string EffectDateText => EffectiveDate.ToString();
        public string? ExpiryDateText => ExpiryDate.ToString();
        public string? ChangeReason { get; set; }

    }

    public class BomVersionProduct
    {
        public int? BomId { get; set; }
        public long? ParentBomId { get; set; }
        public string? ProductCode { get; set; }
        public string? ProductName { get; set; }
        public ProductType? ProductType { get; set; }
        public int? VersionId { get; set; }
    }
    public class BomTreeNode
    {
        public int BomId { get; set; }
        public int? ParentBomId { get; set; }
        public long ChildProductId { get; set; }
        public string ComponentCode { get; set; }
        public string ComponentName { get; set; }
        public decimal Quantity { get; set; }
        public string UOM { get; set; }
        public int VersionId { get; set; }
        public bool IsCritical { get; set; }
        public int Sequence { get; set; }
        public string? LineEffectiveDate { get; set; }
        public string? LineExpiryDate { get; set; }
        public int Level { get; set; } // sẽ tính sau
        public string Status { get; set; } // Active/Inactive/Future
        public List<BomTreeNode> Children { get; set; } = new List<BomTreeNode>();
    }

    public class BomTreeCTE
    {
        public int Sequence { get; set; }
        public int Level { get; set; }
        public string? DisplayName { get; set; }
        public int BomId { get; set; }
        public string UOM { get; set; }
        public decimal QtyPerParent { get; set; }
        public string? ComponentCode { get; set; }
        public ProductType ProductType { get; set; }
        public bool IsCritical { get; set; }

    }

}
