using Abp.Domain.Entities.Auditing;
using GutenBerg.MrGut.Authorization.Users;

namespace GutenBerg.MrGut.Domain.Books;

public class UserBookMapping: FullAuditedEntity
{
    public long? UserId { get; set; }
    public User User { get; set; }
    public int BookId { get; set; }
    public Book Book { get; set; }
}