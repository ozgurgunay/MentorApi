using Core.Entities.Abstract;
using Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace BAMentorApp.DataAccess.EntityFramework.Abstract
{
    public abstract class BaseRepository<T> : IRepository<T> where T : class, IBaseEntity
    {
        protected readonly BAMentorAppDbContext _context;
        protected DbSet<T> _table;
        public BaseRepository(BAMentorAppDbContext applicationDbContext)
        {
            _context = applicationDbContext;
            _table = _context.Set<T>();
        }
        public async Task<bool> AddAsync(T entity)
        {
            await _table.AddAsync(entity);
            return await SaveAsync() > 0;
        }
        public async Task<bool> AddRangeAsync(List<T> entities)
        {
            await _table.AddRangeAsync(entities);

            return await SaveAsync() > 0;

        }
        public async Task<bool> AnyAsync(Expression<Func<T, bool>> expression) => await _table.AnyAsync(expression);
        public async Task<bool> DeleteAsync(T entity)
        {
            _table.Remove(entity);
            return await SaveAsync() > 0;
        }
        public async Task<T> FirstOrDefaultAsync(Expression<Func<T, bool>> expression) => await _table.Where(expression).FirstOrDefaultAsync();

        public async Task<T> GetAsync(Expression<Func<T, bool>> expression)
        {
            return await _table.SingleOrDefaultAsync(expression);
        }

        public async Task<IEnumerable<T>> GetAllAsync() => await _table.ToListAsync();

        public async Task<IEnumerable<T>> GetAllAsync(Expression<Func<T, bool>> expression) => await _table.Where(expression).ToListAsync();

        public virtual async Task<T> GetByIDAsync(Guid ID) => await _table.FindAsync(ID);

        public async Task<int> SaveAsync()
        {
            return await _context.SaveChangesAsync();
        }
        public async Task<bool> UpdateAsync(T entity)
        {
            _context.Entry<T>(entity).State = EntityState.Modified;
            return await SaveAsync() > 0;
        }

        public async Task<IEnumerable<T>> GetAllAsync<TKey>(Expression<Func<T, bool>> expression, Expression<Func<T, TKey>> selector, int count)
        {
            return await _table.Where(expression).OrderBy(selector).Take(count).ToListAsync();
        }


        public async Task<IEnumerable<T>> GetAllAsync<TKey>(Expression<Func<T, bool>> expression, Expression<Func<T, TKey>> selector)
        {
            return await _table.Where(expression).OrderBy(selector).ToListAsync();
        }
    }
}
