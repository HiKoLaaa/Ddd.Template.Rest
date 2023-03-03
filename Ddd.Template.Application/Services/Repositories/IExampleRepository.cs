namespace Ddd.Template.Application.Services.Repositories;

using Domain.Entities;

public interface IExampleRepository
{
    ValueTask<Example> AddAsync(Example example);
}
