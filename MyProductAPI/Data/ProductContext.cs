using Microsoft.EntityFrameworkCore;
using MyProductAPI.Entity;

namespace MyProductAPI.Data
{
	public class ProductContext : DbContext
	{
		public ProductContext(DbContextOptions<ProductContext> options) : base(options) { }
		public DbSet<Product> Products { get; set; } = null!;
		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<Product>().HasData(
				new Product
				{ 
					Id = 1,
					Name = "Product 1",
					Description = "Description 1",
					Price = 100,
					Stock = 10
				},
				new Product
				{
					Id = 2,
					Name = "Product 2",
					Description = "Description 2",
					Price = 200,
					Stock = 20
				},
				new Product
				{					
					Id = 3,
					Name = "Product 3",
					Description = "Description 3",
					Price = 300,
					Stock = 30
				});
		}
	}

}
