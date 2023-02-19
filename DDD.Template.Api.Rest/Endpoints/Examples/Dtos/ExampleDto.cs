namespace DDD.Template.Api.Rest.Endpoints.Examples.Dtos;

using System.Text.Json.Serialization;

public class ExampleDto
{
    [JsonPropertyName("some_example_request_string")]
    public string SomeExampleRequestString { get; set; } = null!;
}
