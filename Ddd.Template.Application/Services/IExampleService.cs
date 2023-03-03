namespace Ddd.Template.Application.Services;

using Domain.Entities;

public interface IExampleService
{
    Task CreateNotification(Example example);
}
