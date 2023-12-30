using System;
using System.Linq;
using System.Linq.Expressions;
using GutenBerg.MrGut.Domain.Books;

namespace GutenBerg.MrGut.Stores.UserBookMappings;

public interface IUserBookMappingStore : IBaseStore<UserBookMapping>
{
    IQueryable<UserBookMapping> GetAllList(Expression<Func<UserBookMapping, bool>> filter = null, bool noTracking = true);
}
