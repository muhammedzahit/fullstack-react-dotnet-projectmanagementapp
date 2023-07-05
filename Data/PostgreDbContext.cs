using Microsoft.EntityFrameworkCore;

namespace WebApplication3.Data;

public class PostgreDbContext : DbContext
{
    public PostgreDbContext(DbContextOptions options) : base(options)
    {
        
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        
        
    }
}