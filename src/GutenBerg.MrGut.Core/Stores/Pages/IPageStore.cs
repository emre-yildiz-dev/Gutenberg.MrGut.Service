using System;
using System.Linq;
using System.Linq.Expressions;
using GutenBerg.MrGut.Domain.Pages;

namespace GutenBerg.MrGut.Stores.Pages;

public interface IPageStore : IBaseStore<Page>
{
    IQueryable<Page> GetAllList(Expression<Func<Page, bool>> filter = null, bool noTracking = true);
}
