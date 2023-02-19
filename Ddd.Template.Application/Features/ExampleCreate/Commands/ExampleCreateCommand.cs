namespace Ddd.Template.Application.Features.ExampleCreate.Commands;

using MediatR;

public class ExampleCreateCommand : IRequest
{
    public string SomeExampleCommandString { get; set; } = null!;
}