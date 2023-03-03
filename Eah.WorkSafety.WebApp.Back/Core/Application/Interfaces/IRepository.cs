﻿using Eah.WorkSafety.WebApp.Back.Core.Application.Filter;
using Eah.WorkSafety.WebApp.Back.Core.Domain;
using System.Linq.Expressions;

namespace Eah.WorkSafety.WebApp.Back.Core.Application.Interfaces
{
    public interface IRepository<T> where T : class, new()
    {

        Task CreateAsync(T entity);
        Task<List<T>> GetAllAsync();

        Task<List<T>> GetAllWithPaginationAsync(PaginationFilter filter, Expression<Func<T, DateTime>> orderBy);
        Task<List<T>> GetAllByFilterAsync(Expression<Func<T, bool>> filter);

        Task<List<T>> GetAllByKeyWithPaginationAsync(PaginationFilter filter,Expression<Func<T, bool>> key, params Expression<Func<T, object>>[] includeProperties);
        Task<List<Accident>> GetAllByKeyWithPaginationAsync2(PaginationFilter filter, Expression<Func<Accident, bool>> key, params Expression<Func<T, object>>[] includeProperties);
        Task<List<NearMiss>> GetAllByKeyWithPaginationAsync3(PaginationFilter filter, Expression<Func<NearMiss, bool>> key, params Expression<Func<T, object>>[] includeProperties);

        Task<T?> GetByFilterAsync(Expression<Func<T, object>> filter);
        //Task<List<T>> GetAllByPropertyAsync<TProperty>(Expression<Func<T, TProperty>> include);
        Task<int> GetAllCountAsync();
        Task<int> GetAllCountAsync(Expression<Func<T, bool>> filter);
        Task<int> GetCountByJoin();
        Task<int> GetNearMissCountByJoin();
        Task<int> GetSumAsync(Expression<Func<T, int>> selector);
        Task<double?> GetAverageAsync(Expression<Func<T, bool>> filter, Expression<Func<T, int?>> selector);
        Task<List<T>> GetAllByPropertyAsync(params Expression<Func<T, object>>[] includeProperties);
        Task<List<T>> GetAllByPropertyWithPaginationAsync(PaginationFilter filter, params Expression<Func<T, object>>[] includeProperties);
        Task<List<Accident>> GetAllByPropertyWithPaginationAsync2(PaginationFilter filter, params Expression<Func<T, object>>[] includeProperties);
        Task<List<NearMiss>> GetAllByPropertyWithPaginationAsync3(PaginationFilter filter, params Expression<Func<T, object>>[] includeProperties);

        Task<T?> GetByIdAsync(object id);
        //Task<T?> GetByIdAsync<TProperty>(Expression<Func<T, TProperty>> include, Expression<Func<T, bool>> filter);
        Task<T?> GetByIdAsync(Expression<Func<T, bool>> filter, params Expression<Func<T, object>>[] includeProperties);
        Task<Accident?> GetByIdAsync2(Expression<Func<Accident, bool>> filter, params Expression<Func<T, object>>[] includeProperties);

        Task<T?> GetByFilterAsync(Expression<Func<T, bool>> filter);
        Task UpdateAsync(T updatedEntity);
        Task DeleteAsync(T deletedEntity);
    }
}
