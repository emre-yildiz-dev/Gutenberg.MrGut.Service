namespace GutenBerg.MrGut.Stores;

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Abp.Dependency;
using Abp.Domain.Entities;
using Abp.Domain.Repositories;
using Abp.EntityFrameworkCore.Repositories;
using Abp.Events.Bus.Entities;
using Abp.Events.Bus.Handlers;
using Abp.Runtime.Caching;
using Microsoft.EntityFrameworkCore;

public abstract class BaseStore<TEntity> : IBaseStore<TEntity>, ITransientDependency,
    IEventHandler<EntityChangedEventData<TEntity>>
    where TEntity : class, IEntity
{
    protected readonly IRepository<TEntity, int> _repository;
    protected readonly ICacheManager _cacheManager;

    public BaseStore()
    {
        _repository = IocManager.Instance.Resolve<IRepository<TEntity,int>>();
        _cacheManager = IocManager.Instance.Resolve<ICacheManager>();
    }

    public virtual async Task<TEntity> GetAsync(int id)
    {
        return await _repository.FirstOrDefaultAsync(id);
    }

    public virtual IQueryable<TEntity> GetList(Expression<Func<TEntity, bool>> filter = null, bool noTracking = true)
    {
        var repo = _repository.GetAll();
        if (noTracking)
            repo = repo.AsNoTracking();

        return repo.Where(filter ?? (s => true));
    }

    public virtual async Task<TEntity> CreateAsync(TEntity entity)
    {
        return await _repository.InsertAsync(entity);
    }

    public virtual async Task CreateBatchAsync(List<TEntity> entities)
    {
        await _repository.GetDbContext().Set<TEntity>().AddRangeAsync(entities);
    }

    public virtual void UpdateBatch(List<TEntity> entities)
    {
        _repository.GetDbContext().Set<TEntity>().UpdateRange(entities);
    }

    public virtual async Task<TEntity> UpdateAsync(TEntity entity)
    {
        return await _repository.UpdateAsync(entity);
    }

    public virtual async Task DeleteAsync(int id)
    {
        await _repository.DeleteAsync(id);
    }

    public virtual async Task DeleteAsync(Expression<Func<TEntity, bool>> filter)
    {
        await _repository.DeleteAsync(filter);
    }

    public virtual void DetachFromDbContext(TEntity entity)
    {
        _repository.DetachFromDbContext(entity);
    }

    public virtual void HandleEvent(EntityChangedEventData<TEntity> eventData)
    {
        // do nothing here
        // will be implememented on store class
    }

    public virtual bool EntityExist(int id)
    {
        return _repository.GetAll().Any(x => x.Id == id);
    }
  
}
public abstract class BaseStore : ITransientDependency
{
    public BaseStore()
    {
    }
} 
