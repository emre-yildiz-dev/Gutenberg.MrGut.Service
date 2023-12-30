using GutenBerg.MrGut.Domain.Books;

namespace GutenBerg.MrGut.Stores.Books;

using System;
using System.Linq;
using System.Linq.Expressions;


public class ShopStore : BaseStore<Book>, IBookStore
{
    public  override IQueryable<Book> GetList(Expression<Func<Book, bool>> filter = null, bool noTracking = true)
    {
        return base.GetList(filter, noTracking).Where(p=>!p.IsDeleted);
    }
    public IQueryable<Book> GetAllList(Expression<Func<Book, bool>> filter = null, bool noTracking = true)
    {
        return base.GetList(filter, noTracking);
    }
}
