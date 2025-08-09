using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using PracticeWebApiOntoMany.Cofiguration;
using PracticeWebApiOntoMany.Model;
using PracticeWebApiOntoMany.User;

namespace PracticeWebApiOntoMany.Data
{
    public class ApplicationDbContext:IdentityDbContext<ApiUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options):base(options) 
        {
            
        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Product>()
                .HasOne(p => p.Category)
                .WithMany(p => p.Products)
                .HasForeignKey(p => p.CategoryId);
            modelBuilder.ApplyConfiguration(new RoleNameConfig());

            modelBuilder.ApplyConfiguration(new CategoryConfig());

            modelBuilder.ApplyConfiguration(new ProductConfig());

            var hasher = new PasswordHasher<ApiUser>();
            modelBuilder.Entity<ApiUser>().HasData(new ApiUser
            {
                Id = "69321195-8b73-4f1a-919b-e7deee4b3909",
                UserName = "user1adin@gmail.com",
                NormalizedUserName = "USER1admin@GMAIL.COM",
                Email = "user1adin@gmail.com",
                NormalizedEmail = "USER1admin@GMAIL.COM",
                PasswordHash = hasher.HashPassword(null, "Longbadao123@"),
                EmailConfirmed = true,
                FirstName = "Jay",
                LastName = "Van",


            });
        }
    }
}
