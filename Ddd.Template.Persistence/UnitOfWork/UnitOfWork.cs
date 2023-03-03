namespace Ddd.Template.Persistence.UnitOfWork;

using Application.Services.Repositories;
using Application.Services.UnitOfWork;

internal class UnitOfWork : IUnitOfWork
{
    private readonly DddTemplateDbContext _dbContext;

    public UnitOfWork(DddTemplateDbContext dbContext, IExampleRepository exampleRepository)
    {
        _dbContext = dbContext;
        ExampleRepository = exampleRepository;
    }

    public IExampleRepository ExampleRepository { get; }


    public Task SaveAsync()
    {
        return _dbContext.SaveChangesAsync();
    }
}
