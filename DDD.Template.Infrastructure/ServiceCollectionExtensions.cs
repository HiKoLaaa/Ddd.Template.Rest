namespace DDD.Template.Infrastructure;

using Domain.Services;
using Examples;
using Microsoft.Extensions.DependencyInjection;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddInfrastructure(this IServiceCollection services)
    {
        services.AddScoped<IExampleService, ExampleService>();

        return services;
    }
}