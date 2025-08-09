using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PracticeWebApiOntoMany.Model;

namespace PracticeWebApiOntoMany.Cofiguration
{
    public class ProductConfig : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasData(new Product
            {
                ProductId = 1,
                Name = "Product1",
                Price = 15,
                CategoryId = 1
            }, new Product
            {
                ProductId = 2,
                Name = "Product2",
                Price = 20,
                CategoryId = 1
            }, new Product
            {
                ProductId = 3,
                Name = "Product3",
                Price = 30,
                CategoryId = 2
            });
        }
    }
}
