using Azure.Core;
using Eah.WorkSafety.WebApp.Back.Core.Application.Filter;
using Eah.WorkSafety.WebApp.Back.Core.Application.Interfaces;
using Eah.WorkSafety.WebApp.Back.Core.Domain;
using Eah.WorkSafety.WebApp.Back.Persistance.Context;
using Microsoft.AspNetCore.Mvc.Formatters;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;
using Microsoft.EntityFrameworkCore.Query;
using Microsoft.VisualBasic;
using System;
using System.Linq;
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

        public async Task<T?> GetByFilterAsync(Expression<Func<T, object>> filter)
        {
            return await this.workSafetyContext.Set<T>().AsNoTracking().OrderByDescending(filter).FirstOrDefaultAsync();

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

            return await set.AsSplitQuery().AsNoTracking().ToListAsync();
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

            return set.AsSplitQuery().AsNoTracking().SingleOrDefaultAsync(filter);
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


        public async Task<int> GetAllCountAsync()
        {
            return await this.workSafetyContext.Set<T>().AsNoTracking().CountAsync();
        }

        public async Task<double?> GetAverageAsync(Expression<Func<T, bool>> filter, Expression<Func<T, int?>> selector)
        {
            return await this.workSafetyContext.Set<T>().Where(filter).AsNoTracking().AverageAsync(selector);
        }

        public async Task<int> GetSumAsync(Expression<Func<T, int>> selector)
        {
            //var data = await this.workSafetyContext.Accidents.AsNoTracking().Select(x => x.Employees.Select(x => x.LostDays)).ToListAsync();
            return await this.workSafetyContext.Set<T>().AsNoTracking().SumAsync(selector);
        }

        public async Task<int> GetAllCountAsync(Expression<Func<T, bool>> filter)
        {
            return await this.workSafetyContext.Set<T>().AsNoTracking().CountAsync(filter);
        }

        public async Task<int> GetCountByJoin()
        {
            // var data = await this.workSafetyContext.Accidents.Join(workSafetyContext.EmployeeAccident, x => x.Id, y => y.AccidentId, (x, y) => new
            // {
            //    x.MedicalIntervention,
            //     y.LostDays
            // }).Where(x=>x.MedicalIntervention==true).AsNoTracking().CountAsync(x=>x.LostDays==0);
            //  return data;
            return await this.workSafetyContext.Accidents.Include(x => x.Employees).SelectMany(x => x.Employees, (x, y) => new
            {
                x.MedicalIntervention,
                y.LostDays
            }).Where(x=>x.MedicalIntervention==true).AsNoTracking().CountAsync(x=>x.LostDays==0);
        }
        public async Task<int> GetNearMissCountByJoin()
        {
            // var data = await this.workSafetyContext.Accidents.Join(workSafetyContext.EmployeeAccident, x => x.Id, y => y.AccidentId, (x, y) => new
            // {
            //    x.MedicalIntervention,
            //     y.LostDays
            // }).Where(x=>x.MedicalIntervention==true).AsNoTracking().CountAsync(x=>x.LostDays==0);
            //  return data;
            return await this.workSafetyContext.NearMisses.Include(x => x.Employees).SelectMany(x => x.Employees, (x, y) => new
            {
                x.MedicalIntervention,
                y.LostDays
            }).Where(x => x.MedicalIntervention == true).AsNoTracking().CountAsync(x => x.LostDays == 0);
        }

        public async Task<List<T>> GetAllByPropertyWithPaginationAsync(PaginationFilter filter,params Expression<Func<T, object>>[] includeProperties)
        {
            var validFilter = new PaginationFilter(filter.PageNumber, filter.PageSize);
            IQueryable<T> set = this.workSafetyContext.Set<T>();
            foreach (var includeProperty in includeProperties)
            {
                set = set.Include(includeProperty);
            }
            return await set.Skip((validFilter.PageNumber - 1) * validFilter.PageSize)
                .Take(validFilter.PageSize)
                .AsNoTracking()
                .ToListAsync();
        }

        public async Task<List<Accident>> GetAllByPropertyWithPaginationAsync2(PaginationFilter filter, params Expression<Func<T, object>>[] includeProperties)
        {
            var validFilter = new PaginationFilter(filter.PageNumber, filter.PageSize);
            var set = await this.workSafetyContext.Accidents.OrderByDescending(x=>x.CreationDate)
                .Include(x=>x.Employees).ThenInclude(x=>x.Employee)
                .Skip((validFilter.PageNumber - 1) * validFilter.PageSize)
                .Take(validFilter.PageSize)
                .AsNoTracking()
                .ToListAsync();

            return set;
        }
        public async Task<List<NearMiss>> GetAllByPropertyWithPaginationAsync3(PaginationFilter filter, params Expression<Func<T, object>>[] includeProperties)
        {
            var validFilter = new PaginationFilter(filter.PageNumber, filter.PageSize);
            var set = await this.workSafetyContext.NearMisses.OrderByDescending(x=>x.CreationDate)
                .Include(x => x.Employees).ThenInclude(x => x.Employee)
                .Skip((validFilter.PageNumber - 1) * validFilter.PageSize)
                .Take(validFilter.PageSize)
                .AsNoTracking()
                .ToListAsync();

            return set;
        }


        public async Task<List<Accident>> GetAllByKeyWithPaginationAsync2(PaginationFilter filter, Expression<Func<Accident, bool>> key, params Expression<Func<T, object>>[] includeProperties)
        {

            var validFilter = new PaginationFilter(filter.PageNumber, filter.PageSize);
            return await this.workSafetyContext.Accidents.OrderByDescending(x=>x.CreationDate)
                .AsNoTracking().Where(key)
                .Include(x => x.Employees).ThenInclude(x => x.Employee)
                .Skip((validFilter.PageNumber - 1) * validFilter.PageSize)
                .Take(validFilter.PageSize)
                .AsNoTracking()
                .ToListAsync();
        }

        public async Task<List<NearMiss>> GetAllByKeyWithPaginationAsync3(PaginationFilter filter, Expression<Func<NearMiss, bool>> key, params Expression<Func<T, object>>[] includeProperties)
        {

            var validFilter = new PaginationFilter(filter.PageNumber, filter.PageSize);
            return await this.workSafetyContext.NearMisses.OrderByDescending(x => x.CreationDate)
                .AsNoTracking().Where(key)
                .Include(x => x.Employees).ThenInclude(x => x.Employee)
                .Skip((validFilter.PageNumber - 1) * validFilter.PageSize)
                .Take(validFilter.PageSize)
                .AsNoTracking()
                .ToListAsync();
        }

        public async Task<Accident?> GetByIdAsync2(Expression<Func<Accident, bool>> filter, params Expression<Func<T, object>>[] includeProperties)
        {
            var set = await this.workSafetyContext.Accidents

                .Where(filter)
                .Include(x => x.Employees).ThenInclude(x => x.Employee).SingleOrDefaultAsync();
            return set;
        }
        
       // public async Task<List<T>> GetAllWithPaginationAsync(PaginationFilter filter)
        //{
         //   var validFilter = new PaginationFilter(filter.PageNumber, filter.PageSize);
         //   return await this.workSafetyContext.Set<T>()
        //        .Skip((validFilter.PageNumber - 1) * validFilter.PageSize)
         //       .Take(validFilter.PageSize)
       //         .AsNoTracking()
       //         .ToListAsync();
       // }

        public async Task<List<T>> GetAllWithPaginationAsync(PaginationFilter filter, Expression<Func<T, DateTime>> orderBy)
        {
            var validFilter = new PaginationFilter(filter.PageNumber, filter.PageSize);
            return await this.workSafetyContext.Set<T>()
                .OrderByDescending(orderBy)
                .Skip((validFilter.PageNumber - 1) * validFilter.PageSize)
                .Take(validFilter.PageSize)
                .AsNoTracking()
                .ToListAsync();
        }

        public async Task<List<T>> GetAllByKeyWithPaginationAsync(PaginationFilter filter, Expression<Func<T, bool>> key, params Expression<Func<T, object>>[] includeProperties)
        {

            var validFilter = new PaginationFilter(filter.PageNumber, filter.PageSize);
            IQueryable<T> set = this.workSafetyContext.Set<T>();
            foreach (var includeProperty in includeProperties)
            {
                set = set.Include(includeProperty);
            }
            return await set.Where(key).Skip((validFilter.PageNumber - 1) * validFilter.PageSize)
                .Take(validFilter.PageSize)
                .AsNoTracking()
                .ToListAsync();
        }
    }
}
