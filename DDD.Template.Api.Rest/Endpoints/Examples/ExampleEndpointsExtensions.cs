namespace DDD.Template.Api.Rest.Endpoints.Examples;

using Application.Features.ExampleCreate.Commands;
using Application.Features.ExampleGet.Queries;
using Converters;
using Dtos;
using Mapster;
using MediatR;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;

internal static class ExampleEndpointsExtensions
{
    public static IEndpointRouteBuilder MapExampleEndpoints(this IEndpointRouteBuilder app)
    {
        var mapGroup = app.MapGroup("examples");
        mapGroup
            .MapExampleGet()
            .MapExampleCreate();

        ExampleRequestMappingConfig.CreateMappings();

        return mapGroup;
    }

    private static IEndpointRouteBuilder MapExampleGet(this IEndpointRouteBuilder app)
    {
        app.MapGet("/", async ([FromServices] IMediator mediator) => await mediator.Send(new ExampleGetQuery()));

        return app;
    }

    private static IEndpointRouteBuilder MapExampleCreate(this IEndpointRouteBuilder app)
    {
        app.MapPost(
            "/",
            async ([FromBody] ExampleDto exampleDto, [FromServices] IMediator mediator) => await mediator.Send(exampleDto.Adapt<ExampleCreateCommand>()));

        return app;
    }
}