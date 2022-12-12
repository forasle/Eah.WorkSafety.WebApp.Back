﻿using System.Linq.Expressions;

namespace Eah.WorkSafety.WebApp.Back.Core.Application.Interfaces
{
    public interface IRepository<T> where T : class, new()
    {

        Task CreateAsync(T entity);
        Task<List<T>> GetAllAsync();
        Task<List<T>> GetAllByFilterAsync(Expression<Func<T, bool>> filter);

        Task<T?> GetByFilterAsync(Expression<Func<T, object>> filter);
        //Task<List<T>> GetAllByPropertyAsync<TProperty>(Expression<Func<T, TProperty>> include);

        Task<List<T>> GetAllByPropertyAsync(params Expression<Func<T, object>>[] includeProperties);
        Task<T?> GetByIdAsync(object id);
        //Task<T?> GetByIdAsync<TProperty>(Expression<Func<T, TProperty>> include, Expression<Func<T, bool>> filter);
        Task<int> GetAllCountAsync();
        Task<double?> GetAverageAsync(Expression<Func<T, bool>> filter, Expression<Func<T, int?>> selector);
        Task<T?> GetByIdAsync(Expression<Func<T, bool>> filter, params Expression<Func<T, object>>[] includeProperties);
        Task<T?> GetByFilterAsync(Expression<Func<T, bool>> filter);
        Task UpdateAsync(T updatedEntity);
        Task DeleteAsync(T deletedEntity);
    }
}
