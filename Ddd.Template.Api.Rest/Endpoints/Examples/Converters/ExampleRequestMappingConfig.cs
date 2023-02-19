namespace Ddd.Template.Api.Rest.Endpoints.Examples.Converters;

using Application.Features.ExampleCreate.Commands;
using Dtos;
using Mapster;

internal static class ExampleRequestMappingConfig
{
    public static void CreateMappings()
    {
        TypeAdapterConfig<ExampleDto, ExampleCreateCommand>.NewConfig().Map(d => d.SomeExampleCommandString, s => s.SomeExampleRequestString);
    }
}