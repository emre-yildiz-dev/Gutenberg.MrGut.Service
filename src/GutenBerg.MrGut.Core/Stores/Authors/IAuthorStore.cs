using System;
using System.Linq;
using System.Linq.Expressions;
using GutenBerg.MrGut.Domain.Authors;

namespace GutenBerg.MrGut.Stores.Authors;

public interface IAuthorStore : IBaseStore<Author>
{
    IQueryable<Author> GetAllList(Expression<Func<Author, bool>> filter = null, bool noTracking = true);
    bool AuthorExists(string name);
}
