using System.Linq.Expressions;

namespace Eah.WorkSafety.WebApp.Back.Core.Application.Interfaces
{
    public interface IRepository<T> where T : class, new()
    {

        Task CreateAsync(T entity);
        Task<List<T>> GetAllAsync();
        Task<T?> GetByIdAsync(object id);
        Task<T?> GetByFilterAsync(Expression<Func<T, bool>> filter);
        Task UpdateAsync(T updatedEntity);
        Task DeleteAsync(T deletedEntity);



    }
}
