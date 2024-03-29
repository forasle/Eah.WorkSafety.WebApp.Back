﻿using Azure.Core;
using Eah.WorkSafety.WebApp.Back.Core.Application.Interfaces;
using Eah.WorkSafety.WebApp.Back.Persistance.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;
using System.Linq.Expressions;

namespace Eah.WorkSafety.WebApp.Back.Persistance.Repositories
{
    public class Repository<T> : IRepository<T> where T : class, new()
    {
        private readonly WorkSafetyDbContext workSafetyContext;

        public Repository(WorkSafetyDbContext workSafetyContext)
        {
            this.workSafetyContext = workSafetyContext;
        }

        public async Task CreateAsync(T entity)
        {
            await this.workSafetyContext.Set<T>().AddAsync(entity);
            await this.workSafetyContext.SaveChangesAsync();
        }

        public async Task<List<T>> GetAllAsync()
        {
            return await this.workSafetyContext.Set<T>().AsNoTracking().ToListAsync();
        }
        public async Task<List<T>> GetAllByFilterAsync(Expression<Func<T, bool>> filter)
        {
            return await this.workSafetyContext.Set<T>().Where(filter).AsNoTracking().ToListAsync();
        }

        //public async Task<List<T>> GetAllByPropertyAsync<TProperty>(Expression<Func<T, TProperty>> include)
        //{
        //    return await this.workSafetyContext.Set<T>().Include(include).ToListAsync();
        //}

        public async Task<List<T>> GetAllByPropertyAsync(params Expression<Func<T, object>>[] includeProperties)
        {
            IQueryable<T> set = this.workSafetyContext.Set<T>();
            foreach (var includeProperty in includeProperties)
            {
                set = set.Include(includeProperty);
            }

            return await set.ToListAsync();
        }
        //public Task<T?> GetByIdAsync(Expression<Func<T, bool>> filter, params Expression<Func<T, object>>[] includeProperties)
        //{
        //    IQueryable<T> set = this.workSafetyContext.Set<T>();
        //    foreach (var includeProperty in includeProperties)
        //    {
        //        set = set.Include(includeProperty);
        //    }

        //    return set.SingleOrDefaultAsync(filter);
        //}

        public async Task<T?> GetByFilterAsync(Expression<Func<T, bool>> filter)
        {
            return await this.workSafetyContext.Set<T>().AsNoTracking().SingleOrDefaultAsync(filter);
        }

        public async Task<T?> GetByIdAsync(object id)
        {
            return await this.workSafetyContext.Set<T>().FindAsync(id);
        }
        //public async Task<T?> GetByIdAsync<TProperty>(Expression<Func<T, TProperty>> include, Expression<Func<T, bool>> filter)
        //{
        //    return await this.workSafetyContext.Set<T>().Include(include).SingleOrDefaultAsync(filter);
        //}
        public Task<T?> GetByIdAsync(Expression<Func<T, bool>> filter, params Expression<Func<T, object>>[] includeProperties)
        {
            IQueryable<T> set = this.workSafetyContext.Set<T>();
            foreach (var includeProperty in includeProperties)
            {
                set = set.Include(includeProperty);
            }

            return set.SingleOrDefaultAsync(filter);
        }

        public async Task UpdateAsync(T updatedEntity)
        {
            this.workSafetyContext.Set<T>().Update(updatedEntity);
            await this.workSafetyContext.SaveChangesAsync();
        }

        public async Task DeleteAsync(T deletedEntity)
        {
            this.workSafetyContext.Set<T>().Remove(deletedEntity);
            await this.workSafetyContext.SaveChangesAsync();
        }

    }
}
