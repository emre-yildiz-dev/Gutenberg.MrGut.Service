using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using GutenBerg.MrGut.Authorization.Roles;
using GutenBerg.MrGut.Authorization.Users;
using GutenBerg.MrGut.Domain.Authors;
using GutenBerg.MrGut.Domain.Books;
using GutenBerg.MrGut.Domain.Genres;
using GutenBerg.MrGut.MultiTenancy;

namespace GutenBerg.MrGut.EntityFrameworkCore
{
    public class MrGutDbContext : AbpZeroDbContext<Tenant, Role, User, MrGutDbContext>
    {
        public DbSet<Author> Authors { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<Genre> Genres { get; set; }


        
        public MrGutDbContext(DbContextOptions<MrGutDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ChangeAbpTablePrefix<Tenant, Role, User>("");
        }
    }
}
