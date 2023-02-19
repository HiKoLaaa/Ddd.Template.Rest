namespace Ddd.Template.Application.Features.ExampleCreate.Commands;

using JetBrains.Annotations;
using MediatR;

[UsedImplicitly]
internal class ExampleCreateCommandHandler : IRequestHandler<ExampleCreateCommand>
{
    public Task Handle(ExampleCreateCommand request, CancellationToken cancellationToken)
    {
        Console.WriteLine($"Example create command with string: {request.SomeExampleCommandString}");

        return Task.CompletedTask;
    }
}