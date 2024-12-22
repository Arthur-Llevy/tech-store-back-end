using api.entities;
using Microsoft.EntityFrameworkCore;

namespace Api.Context;

public class Context : DbContext 
{
    public Context(DbContextOptions<Context> options) : base(options)
    {
        
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        base.OnConfiguring(optionsBuilder);
    }
    public DbSet<Product> Product { get; set; } = default!;
}