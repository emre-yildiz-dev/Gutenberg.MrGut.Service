namespace GutenBerg.MrGut.Stores;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Abp.Domain.Entities;

public interface IBaseStore<TEntity> where TEntity : class, IEntity
{
    Task<TEntity> GetAsync(int id);
    IQueryable<TEntity> GetList(Expression<Func<TEntity, bool>> filter = null, bool noTracking = true);
    Task<TEntity> CreateAsync(TEntity entity);
    Task CreateBatchAsync(List<TEntity> entities);
    void UpdateBatch(List<TEntity> entities);
    Task<TEntity> UpdateAsync(TEntity entity);
    //Task<TEntity> CreateOrUpdateAsync(TEntity entity);
    Task DeleteAsync(int id);
    Task DeleteAsync(Expression<Func<TEntity, bool>> filter);
    void DetachFromDbContext(TEntity entity);
    bool EntityExist(int id);
}
public interface IBaseStore
{ 
    
}