using System.Linq.Expressions;

namespace Eah.WorkSafety.WebApp.Back.Core.Application.Interfaces
{
    public interface IRepository<T> where T : class, new()
    {

        Task CreateAsync(T entity);
        Task<List<T>> GetAllAsync();
        Task<T?> GetByIdAsync(object id);
        Task<List<T>> GetAllByFilterAsync<TProperty>(Expression<Func<T, TProperty>> include);

        Task<T?> GetByIdAsync<TProperty>(Expression<Func<T, TProperty>> include, Expression<Func<T, bool>> filter);
        Task<List<T>> GetAllByFilterAsync(Expression<Func<T, bool>> filter);
        Task<T?> GetByFilterAsync(Expression<Func<T, bool>> filter);
        Task UpdateAsync(T updatedEntity);
        Task DeleteAsync(T deletedEntity);
    }
}
