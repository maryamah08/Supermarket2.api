using Microsoft.EntityFrameworkCore;
using Supermarket2.api.Models;

public class SuperMarketDbContext : DbContext
{
    public SuperMarketDbContext(DbContextOptions<SuperMarketDbContext> options) : base(options) { }

    public DbSet<Product> Products { get; set; }
    public DbSet<Category> Categories { get; set; }
    public DbSet<Order> Orders { get; set; }
}
