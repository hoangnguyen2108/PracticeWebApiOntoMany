using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PracticeWebApiOntoMany.Model;

namespace PracticeWebApiOntoMany.Cofiguration
{
    public class CategoryConfig : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasData(new Category
            {
                CategoryId = 1,
                Name = "Category1"
            }, new Category
            {
                CategoryId = 2,
                Name = "Category2"
            });
        }
    }
}
