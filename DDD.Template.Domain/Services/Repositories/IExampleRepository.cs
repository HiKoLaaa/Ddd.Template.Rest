namespace DDD.Template.Domain.Services.Repositories;

using Entities;

public interface IExampleRepository
{
    ValueTask<Example> AddAsync(Example example);
}