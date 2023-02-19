namespace Ddd.Template.Persistence;

using JetBrains.Annotations;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

[UsedImplicitly]
public class DddTemplateDbContextFactory : IDesignTimeDbContextFactory<DddTemplateDbContext>
{
    public DddTemplateDbContext CreateDbContext(string[] args)
    {
        var optionsBuilder = new DbContextOptionsBuilder<DddTemplateDbContext>();
        optionsBuilder.UseNpgsql(args[0]);

        return new DddTemplateDbContext(optionsBuilder.Options);
    }
}