namespace DDD.Template.Persistence;

using Domain.Entities;
using Microsoft.EntityFrameworkCore;

public class DddTemplateDbContext : DbContext
{
    public DddTemplateDbContext(DbContextOptions<DddTemplateDbContext> options) : base(options)
    {
    }

    public DbSet<Example> Examples => Set<Example>();

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(DddTemplateDbContext).Assembly);
    }
}
