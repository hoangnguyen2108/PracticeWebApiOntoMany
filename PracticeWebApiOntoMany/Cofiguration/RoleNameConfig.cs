using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PracticeWebApiOntoMany.Migrations;

namespace PracticeWebApiOntoMany.Cofiguration
{
    public class RoleNameConfig : IEntityTypeConfiguration<IdentityRole>
    {
        public void Configure(EntityTypeBuilder<IdentityRole> builder)
        {
            builder.HasData(new IdentityRole
            {
                Id = "1b1bb66e-6aa2-4728-8b5b-4e6de4fd899b",
                Name = "Admin",
                NormalizedName = "ADMIN"
            }, new IdentityRole
            {
                Name = "User",
                NormalizedName = "USER"
            });
        }
    }
}
