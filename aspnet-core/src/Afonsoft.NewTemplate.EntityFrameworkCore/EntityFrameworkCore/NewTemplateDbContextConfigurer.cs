using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace Afonsoft.NewTemplate.EntityFrameworkCore
{
    public static class NewTemplateDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<NewTemplateDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<NewTemplateDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}