
using AppGenealogySystem.Enums;
using AppGenealogySystem.Models;
using AppGenealogySystem.Service;
using Bogus;

namespace AppGenealogySystem.Context
{
    internal class FakeData
    {
        public static List<Products> GenerateFakeProducts(int count)
        {
            var faker = new Faker<Products>()
                .RuleFor(p => p.ProductId, f => 0) // Auto increment DB
                .RuleFor(p => p.ProductCode, f => f.Commerce.Ean13())
                .RuleFor(p => p.ProductName, f => f.Commerce.ProductName())
                .RuleFor(p => p.Description, f => f.Commerce.ProductDescription())
                .RuleFor(p => p.ProductType, f => (ProductType)f.Random.Int(0, 3))
                .RuleFor(p => p.TrackingMethod, f => (TrackingMethod)f.Random.Int(0, 2))
                .RuleFor(p => p.BaseUOM, f => f.PickRandom(new[] { "PCS", "KG", "BOX" }))
                .RuleFor(p => p.DefaultShelfLife, f => f.Random.Int(30, 365))
                .RuleFor(p => p.CostStandard, f => f.Random.Decimal(10, 1000))
                .RuleFor(p => p.RevisionCurrent, f => $"REV-{f.Random.Int(1, 10)}")
                .RuleFor(p => p.DrawingNumber, f => $"DWG-{f.Random.Int(1000, 9999)}")
                .RuleFor(p => p.CreatedBy, f => 1)
                .RuleFor(p => p.ModifiedBy, f => 1)
                .RuleFor(p => p.IsActive, f => true)
                .RuleFor(p => p.CreatedDate, f => DateTime.Now)
                .RuleFor(p => p.ModifiedDate, f => DateTime.Now);


            return faker.Generate(count);
        }

    }

}
