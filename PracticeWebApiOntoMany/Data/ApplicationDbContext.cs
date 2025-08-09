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
                
                
        }
    }
}
