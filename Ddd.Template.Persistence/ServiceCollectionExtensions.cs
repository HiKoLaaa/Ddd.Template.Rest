namespace Ddd.Template.Persistence;

using Application.Services.Repositories;
using Application.Services.UnitOfWork;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Repositories;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddPersistence(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddDbContextPool<DddTemplateDbContext>(options => { options.UseNpgsql(configuration["ConnectionStrings:Postgres"]); });

        services.AddDatabase();

        return services;
    }

    private static IServiceCollection AddDatabase(this IServiceCollection services)
    {
        services.AddScoped<IUnitOfWork, UnitOfWork.UnitOfWork>();
        services.AddScoped<IExampleRepository, ExampleRepository>();

        return services;
    }
}
