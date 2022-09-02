using System;
using System.Linq.Expressions;
using Core.EFRepository.EFBase;
using Entity.Base;
using Microsoft.EntityFrameworkCore;

namespace Core.EFRepository
{
    public class EfEntityRepositoryBase<TEntity,TContext> : IEntityRepositoryBase<TEntity>
        where TEntity:class,IEntity,new()
        where TContext : DbContext 
    {

        private readonly TContext _context;

        public EfEntityRepositoryBase(TContext context)
        {
            _context = context;
        }

        public async Task<TEntity> GetAsync(Expression<Func<TEntity, bool>> expression)
        {
            var data = expression == null
                ? await _context.Set<TEntity>().FirstOrDefaultAsync()
                : await _context.Set<TEntity>().Where(expression).FirstOrDefaultAsync();

#pragma warning disable CS8603 // Possible null reference return.
            return data;
#pragma warning restore CS8603 // Possible null reference return.
        }
        public async Task<List<TEntity>> GetAllASync(Expression<Func<TEntity, bool>> expression)
        {
            var data = expression == null
                ? await _context.Set<TEntity>().ToListAsync()
                : await _context.Set<TEntity>().Where(expression).ToListAsync();

        }

        public async Task CreateAsync(TEntity entity)
        {
            var entry = _context.Entry(entity);
            entry.State = EntityState.Added;            
            await _context.SaveChangesAsync();

        }

        public async Task UpdateAsync(TEntity entity)
        {
            var entry = _context.Entry(entity);
            entry.State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(TEntity entity)
        {
            var entry = _context.Entry(entity);
            entry.State = EntityState.Deleted;
            await _context.SaveChangesAsync();
        }


    }
}

