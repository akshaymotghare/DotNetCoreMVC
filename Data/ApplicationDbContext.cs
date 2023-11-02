using buybook.Models;
using Microsoft.EntityFrameworkCore;

namespace buybook.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options):base(options)
        {

            
        }

        public DbSet<Category> Categories { get; set; } 

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<Category>().HasData(
        //        new Category { CategoryId=1, Name="Adventure", DisplayOrder=1},
        //        new Category { CategoryId = 2, Name = "Mythology", DisplayOrder = 2 },
        //        new Category { CategoryId = 3, Name = "Modern", DisplayOrder = 3 }
        //        );
        //}
    }
}
