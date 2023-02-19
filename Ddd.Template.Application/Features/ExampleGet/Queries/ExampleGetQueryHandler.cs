namespace Ddd.Template.Application.Features.ExampleGet.Queries;

using Domain.Entities;
using JetBrains.Annotations;
using MediatR;

[UsedImplicitly]
internal class ExampleGetQueryHandler : IRequestHandler<ExampleGetQuery, Example>
{
    public Task<Example> Handle(ExampleGetQuery request, CancellationToken cancellationToken)
    {
        var example = new Example { Id = 17 };

        return Task.FromResult(example);
    }
}