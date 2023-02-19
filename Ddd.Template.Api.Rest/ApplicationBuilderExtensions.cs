namespace Ddd.Template.Api.Rest;

using Endpoints.Examples;
using Microsoft.AspNetCore.Routing;

public static class ApplicationBuilderExtensions
{
    public static IEndpointRouteBuilder MapRest(this IEndpointRouteBuilder app)
    {
        app.MapExampleEndpoints();

        return app;
    }
}