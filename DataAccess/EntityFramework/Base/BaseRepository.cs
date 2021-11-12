using Core.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace BAMentorApp.DataAccess.EntityFramework.Abstract
{
    public abstract class BaseRepository<T> : IRepository<T> where T : class, IBaseEntity
    {
        private readonly BAMentorAppDbContext _context;
        protected DbSet<T> _table;
        public BaseRepository(BAMentorAppDbContext applicationDbContext)
        {
            _context = applicationDbContext;
            _table = _context.Set<T>();
        }
        public async Task<bool> Add(T entity)
        {
            await _table.AddAsync(entity);
            return await Save() > 0;
        }
        public async Task<bool> AddRange(List<T> entities)
        {
            await _table.AddRangeAsync(entities);

            return await Save() > 0;

        }
        public async Task<bool> Any(Expression<Func<T, bool>> expression) => await _table.AnyAsync(expression);
        public async Task<bool> Delete(T entity)
        {
            _table.Remove(entity);
            return await Save() > 0;
        }
        public async Task<T> FirstOrDefault(Expression<Func<T, bool>> expression) => await _table.Where(expression).FirstOrDefaultAsync();

        public async Task<T> Get(Expression<Func<T, bool>> expression)
        {
            return await _table.SingleOrDefaultAsync(expression);
        }

        public async Task<List<T>> GetAll() => await _table.ToListAsync();

        public async Task<List<T>> GetAll(Expression<Func<T, bool>> expression) => await _table.Where(expression).ToListAsync();

        public virtual async Task<T> GetByID(Guid ID) => await _table.FindAsync(ID);

        public async Task<int> Save()
        {
            return await _context.SaveChangesAsync();
        }
        public async Task<bool> Update(T entity)
        {
            _context.Entry<T>(entity).State = EntityState.Modified;
            return await Save() > 0;
        }
    }
}
