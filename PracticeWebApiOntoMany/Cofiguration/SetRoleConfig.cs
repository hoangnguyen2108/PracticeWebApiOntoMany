using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace PracticeWebApiOntoMany.Cofiguration
{
    public class SetRoleConfig : IEntityTypeConfiguration<IdentityUserRole<string>>
    {
        public void Configure(EntityTypeBuilder<IdentityUserRole<string>> builder)
        {
            builder.HasData(new IdentityUserRole<string>
            {
                UserId = "69321195-8b73-4f1a-919b-e7deee4b3909",
                RoleId = "1b1bb66e-6aa2-4728-8b5b-4e6de4fd899b"
            });
        }
    }
}
