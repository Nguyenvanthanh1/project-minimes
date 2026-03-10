using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppGenealogySystem.Models.Dto
{
    public class ProductDto
    {
        public long ProductId { get; set; }
        public string? ProductCode { get; set; }

        public string? ProductName { get; set; }
        public string DisplayName => $"{ProductCode} - {ProductName}";

    }

    public class ProductLookup
    {
        public long ProductId { get; set; }
        public string? ProductCode { get; set; }

        public string? ProductName { get; set; }
        public string? TrackingMethod { get; set; }
        public string? ProductType { get; set; }
        public string? BaseUOM { get; set; }

    }

    public class ComboItem<T> where T : struct, Enum
    {
        public T? Value { get; set; }
        public string? Text { get; set; }
        public bool IsAll => !Value.HasValue;
    }
}
