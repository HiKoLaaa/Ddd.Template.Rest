namespace Ddd.Template.Infrastructure.Examples;

using Domain.Entities;
using Domain.Services;

internal class ExampleService : IExampleService
{
    public Task CreateNotification(Example example)
    {
        Console.WriteLine("Send notification to external service!");

        return Task.CompletedTask;
    }
}