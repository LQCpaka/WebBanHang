using Microsoft.EntityFrameworkCore;

namespace WebBanHang.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) :
        base(options)
        {
        }
        public DbSet<Category> Categories { set; get; }
        public DbSet<Product> Products { set; get; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //seed data to table Categories
            modelBuilder.Entity<Category>().HasData(
            new Category { Id = 1, Name = "Điện thoại", DisplayOrder = 1 },
            new Category { Id = 2, Name = "Máy tính bảng", DisplayOrder = 2 },
            new Category { Id = 3, Name = "Laptop", DisplayOrder = 3 });
            //seed data to table Product
            modelBuilder.Entity<Product>().HasData(
            new Product { Id = 1, Name = "Iphone 7", Description="Hello", Price = 300, CategoryId = 1, ImageUrl="" },
            new Product { Id = 2, Name = "Iphone 7s", Description = "Hello", Price = 350, CategoryId = 1, ImageUrl = "" },
            new Product { Id = 3, Name = "Iphone 8", Description = "Hello", Price = 400, CategoryId = 1, ImageUrl = "" },
            new Product { Id = 4, Name = "Iphone 8s", Description = "Hello", Price = 420, CategoryId = 1 , ImageUrl = "" },
            new Product { Id = 5, Name = "Iphone 12", Description = "Hello", Price = 630, CategoryId = 1, ImageUrl = "" },
            new Product { Id = 6, Name = "Iphone 12 Pro", Description = "Hello", Price = 750, CategoryId = 1, ImageUrl = "" },
            new Product { Id = 7, Name = "Iphone 14", Description = "Hello", Price = 820, CategoryId = 1, ImageUrl = "" },
            new Product { Id = 8, Name = "Iphone 14 Pro", Description = "Hello", Price = 950, CategoryId = 1, ImageUrl = "" },
            new Product { Id = 9, Name = "Iphone 15", Description = "Hello", Price = 1200, CategoryId = 1 , ImageUrl = "" },
            new Product { Id = 10, Name = "Iphone 15 Pro Max ", Description = "Hello", Price = 1450, CategoryId = 1 , ImageUrl = "" },
            new Product { Id = 11, Name = "Ipad Gen 10", Description = "Hello", Price = 750, CategoryId = 2, ImageUrl = "" },
            new Product { Id = 12, Name = "Ipad Pro 11", Description = "Hello", Price = 1250, CategoryId = 2 , ImageUrl = "" });

        }
    }
}
