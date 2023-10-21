using DesignPatterns.Composite.SampleWithEntity.Entities;
using Microsoft.EntityFrameworkCore;
 

namespace DesignPatterns.Composite.SampleWithEntity.Contexts;

public class DBContext:DbContext
{
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseInMemoryDatabase(@"Test");
        base.OnConfiguring(optionsBuilder);
    }

    public DbSet<CategoryComponent> CategoryComponents { get; set; }
    private DbSet<Category> Categories { get; set; }
    private DbSet<CategoryItem> CategoryItems { get; set; }

    public DbSet<Product> Products { get; set; }
}
