using GutenBerg.MrGut.Domain.Books;

namespace GutenBerg.MrGut.Stores.Books;

using System;
using System.Linq;
using System.Linq.Expressions;


public interface IBookStore : IBaseStore<Book>
{
    IQueryable<Book> GetAllList(Expression<Func<Book, bool>> filter = null, bool noTracking = true);
}
