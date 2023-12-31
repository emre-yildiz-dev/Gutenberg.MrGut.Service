using System;
using System.Linq;
using System.Linq.Dynamic.Core;
using System.Linq.Expressions;
using GutenBerg.MrGut.Domain.Books;

namespace GutenBerg.MrGut.Stores.UserBookMappings;

public class UserBookMappingStore : BaseStore<UserBookMapping>, IUserBookMappingStore
{
    public  override IQueryable<UserBookMapping> GetList(Expression<Func<UserBookMapping, bool>> filter = null, bool noTracking = true)
    {
        return base.GetList(filter, noTracking).Where(p=>!p.IsDeleted);
    }
    public IQueryable<UserBookMapping> GetAllList(Expression<Func<UserBookMapping, bool>> filter = null, bool noTracking = true)
    {
        return base.GetList(filter, noTracking);
    }

    public bool UserBookMappingExists(int bookId, long? userId)
    {
        return base.GetList(mapping => mapping.UserId == userId && mapping.BookId == bookId).Any();
    }
}
