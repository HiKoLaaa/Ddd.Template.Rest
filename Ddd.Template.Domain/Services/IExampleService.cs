namespace Ddd.Template.Domain.Services;

using Entities;

public interface IExampleService
{
    Task CreateNotification(Example example);
}