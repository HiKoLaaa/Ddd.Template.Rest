namespace Ddd.Template.Domain.Services.UnitOfWork;

using Repositories;

public interface IUnitOfWork
{
    IExampleRepository ExampleRepository { get; }

    Task SaveAsync();
}
