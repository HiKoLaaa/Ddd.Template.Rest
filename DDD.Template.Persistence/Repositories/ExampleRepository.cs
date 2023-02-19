namespace DDD.Template.Persistence.Repositories;

using Domain.Entities;
using Domain.Services.Repositories;

internal class ExampleRepository : IExampleRepository
{
    private readonly DddTemplateDbContext _dbContext;

    public ExampleRepository(DddTemplateDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public async ValueTask<Example> AddAsync(Example example)
    {
        await _dbContext.Examples.AddAsync(example);

        return example;
    }
}