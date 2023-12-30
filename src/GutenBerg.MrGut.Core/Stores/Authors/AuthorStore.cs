using System;
using System.Linq;
using System.Linq.Expressions;
using GutenBerg.MrGut.Domain.Authors;
using GutenBerg.MrGut.Domain.Books;
using GutenBerg.MrGut.Stores.Books;

namespace GutenBerg.MrGut.Stores.Authors;

public class AuthorStore : BaseStore<Author>, IAuthorStore
{
    public IQueryable<Author> GetAllList(Expression<Func<Author, bool>> filter = null, bool noTracking = true)
    {
        return base.GetList(filter, noTracking);
    }
}
