using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Core.Repositories
{
    public interface IRepository<T> where T : class
    {
        Task<bool> AddAsync(T entity);
        Task<bool> AddRangeAsync(List<T> entities);
        Task<bool> AnyAsync(Expression<Func<T, bool>> expression);
        Task<bool> UpdateAsync(T entity);
        Task<bool> DeleteAsync(T entity);
        Task<T> FirstOrDefaultAsync(Expression<Func<T, bool>> expression);
        Task<IEnumerable<T>> GetAllAsync();
        Task<IEnumerable<T>> GetAllAsync(Expression<Func<T, bool>> expression);
        Task<IEnumerable<T>> GetAllAsync<TKey>(Expression<Func<T, bool>> expression, Expression<Func<T, TKey>> selector, int count);
        Task<IEnumerable<T>> GetAllAsync<TKey>(Expression<Func<T, bool>> expression, Expression<Func<T, TKey>> selector);
        Task<T> GetAsync(Expression<Func<T, bool>> expression);
        Task<T> GetByIDAsync(Guid id);
        Task<int> SaveAsync();
    }
}
