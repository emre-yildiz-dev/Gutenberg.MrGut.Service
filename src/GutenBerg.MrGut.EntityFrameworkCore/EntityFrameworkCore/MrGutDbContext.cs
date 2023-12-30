using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using GutenBerg.MrGut.Authorization.Roles;
using GutenBerg.MrGut.Authorization.Users;
using GutenBerg.MrGut.Domain.Authors;
using GutenBerg.MrGut.Domain.Books;
using GutenBerg.MrGut.Domain.Pages;
using GutenBerg.MrGut.MultiTenancy;

namespace GutenBerg.MrGut.EntityFrameworkCore
{
    public class MrGutDbContext : AbpZeroDbContext<Tenant, Role, User, MrGutDbContext>
    {
        public DbSet<Author> Authors { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<Page> Pages { get; set; }
        public DbSet<UserBookMapping> UserBookMappings { get; set; }


        
        public MrGutDbContext(DbContextOptions<MrGutDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ChangeAbpTablePrefix<Tenant, Role, User>("");
            modelBuilder.Entity<Book>(b =>
            {
                b.ToTable("Book"); // Customize the table name
                b.Property(book => book.Title).IsRequired().HasMaxLength(256);
                b.Property(book => book.Languages);
                b.Property(book => book.Content);
                b.Property(book => book.ContentUrl);
                b.Property(book => book.GutenbergId).IsRequired();
                b.HasOne(book => book.Author)
                    .WithMany(author => author.Books)
                    .HasForeignKey(book => book.AuthorId);

                b.HasMany(book => book.Page)
                    .WithOne(page => page.Book)
                    .HasForeignKey(page => page.BookId);
            });
            
            modelBuilder.Entity<Page>(entity =>
            {
                entity.ToTable("Page"); // Customize the table name as needed

                entity.HasKey(p => p.Id); // Primary key

                entity.Property(p => p.Content)
                    .IsRequired(); // Assuming the Content is required

                // Define the relationship between Page and Book
                entity.HasOne(p => p.Book)
                    .WithMany(b => b.Page) // Assuming the Book entity has a collection of Pages
                    .HasForeignKey(p => p.BookId); // Foreign key pointing to the Book entity
            });

            modelBuilder.Entity<Author>(b =>
            {
                b.ToTable("Author"); // Table name if you want to customize
                b.Property(a => a.Name).IsRequired().HasMaxLength(128);
                b.Property(a => a.BirthYear);
                b.Property(a => a.DeathYear);
                b.HasMany(a => a.Books).WithOne(b => b.Author).HasForeignKey(b => b.AuthorId);
            });
            modelBuilder.Entity<UserBookMapping>(b =>
            {
                b.ToTable("UserBookMappings"); // Customize the table name
                b.HasOne(ubm => ubm.User)
                    .WithMany()
                    .HasForeignKey(ubm => ubm.UserId)
                    .IsRequired(false); // If the UserId can be null

                b.HasOne(ubm => ubm.Book)
                    .WithMany()
                    .HasForeignKey(ubm => ubm.BookId);
            });

        }
    }
}
