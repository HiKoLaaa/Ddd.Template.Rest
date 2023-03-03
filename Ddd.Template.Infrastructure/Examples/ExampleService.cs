namespace Ddd.Template.Infrastructure.Examples;

using Application.Services;
using Domain.Entities;

internal class ExampleService : IExampleService
{
    public Task CreateNotification(Example example)
    {
        Console.WriteLine("Send notification to external service!");

        return Task.CompletedTask;
    }
}
