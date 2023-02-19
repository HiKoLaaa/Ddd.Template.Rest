namespace Ddd.Template.Host;

using Application.Features.ExampleCreate.Commands;
using Infrastructure;
using Microsoft.AspNetCore.HttpLogging;
using Persistence;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddHost(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddConfigurations(configuration);
        services.AddPersistence(configuration);
        services.AddInfrastructure();
        services.AddMediatR(mediatrConfiguration => mediatrConfiguration.RegisterServicesFromAssembly(typeof(ExampleCreateCommand).Assembly));
        services.AddHttpLogging(logging => logging.LoggingFields = HttpLoggingFields.All);

        return services;
    }

    private static IServiceCollection AddConfigurations(this IServiceCollection services, IConfiguration configuration)
    {
        return services;
    }
}