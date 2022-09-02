using System;
using System.Linq.Expressions;
using Entity.Base;

namespace Core.EFRepository.EFBase
{
    public interface IEntityRepositoryBase<TEntity>
        where TEntity: class,IEntity,new()
    {
        Task<TEntity> GetAsync(Expression<Func<TEntity, bool>> expression);
        Task<List<TEntity>> GetAllASync(Expression<Func<TEntity, bool>> expression);
        Task CreateAsync(TEntity entity);
        Task UpdateAsync(TEntity entity);
        Task DeleteAsync(TEntity entity);

    }
}

