namespace _468Insider.Core.Interfaces.Persintence;

public interface IAsyncRepository<T> where T : class
{
    public Task<T?> GetByIdAsync(Guid id);
    public Task<IReadOnlyList<T>> ListAllAsync();
    public Task<T> AddAsync(T entity);
    public Task UpdateAsync(T entity);
    public Task DeleteAsync(T entity);
}