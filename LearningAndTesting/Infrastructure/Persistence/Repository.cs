namespace LearningAndTesting.Infrastructure.Persistence;

using LearningAndTesting.Domain.Repositories;

public class Repository<T> : IRepository<T> where T : class
{
    public virtual Task<T> GetByIdAsync(int id)
    {
        throw new NotImplementedException();
    }

    public virtual Task<IEnumerable<T>> GetAllAsync()
    {
        throw new NotImplementedException();
    }

    public virtual Task AddAsync(T entity)
    {
        throw new NotImplementedException();
    }

    public virtual Task UpdateAsync(T entity)
    {
        throw new NotImplementedException();
    }

    public virtual Task DeleteAsync(T entity)
    {
        throw new NotImplementedException();
    }
}
