using FTELMarket.Api.Models;
using Microsoft.EntityFrameworkCore;

namespace FTELMarket.Api.DbConf;
public class PostgresDbContext : DbContext
{
    public PostgresDbContext(DbContextOptions<PostgresDbContext> options) : base(options)
    {
    }

    // Déclarez vos tables
    public DbSet<Product> Products { get; set; }
    public DbSet<Category> Categories { get; set; }
}