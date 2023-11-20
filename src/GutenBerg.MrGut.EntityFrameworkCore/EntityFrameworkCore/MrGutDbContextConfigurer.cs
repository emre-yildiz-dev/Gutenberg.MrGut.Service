using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace GutenBerg.MrGut.EntityFrameworkCore
{
    public static class MrGutDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<MrGutDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<MrGutDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
