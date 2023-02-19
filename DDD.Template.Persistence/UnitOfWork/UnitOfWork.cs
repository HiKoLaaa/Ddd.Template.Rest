namespace DDD.Template.Persistence.UnitOfWork;

using Domain.Services.Repositories;
using Domain.Services.UnitOfWork;

internal class UnitOfWork : IUnitOfWork
{
    private readonly DddTemplateDbContext _dbContext;

    public IExampleRepository ExampleRepository { get; }

    public UnitOfWork(DddTemplateDbContext dbContext, IExampleRepository exampleRepository)
    {
        _dbContext = dbContext;
        ExampleRepository = exampleRepository;
    }


    public Task SaveAsync() => _dbContext.SaveChangesAsync();
}
