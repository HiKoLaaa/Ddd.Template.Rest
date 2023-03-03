namespace Ddd.Template.Application.Services.UnitOfWork;

using Repositories;

public interface IUnitOfWork
{
    IExampleRepository ExampleRepository { get; }

    Task SaveAsync();
}
