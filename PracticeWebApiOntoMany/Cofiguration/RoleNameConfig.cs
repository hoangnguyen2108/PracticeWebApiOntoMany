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
