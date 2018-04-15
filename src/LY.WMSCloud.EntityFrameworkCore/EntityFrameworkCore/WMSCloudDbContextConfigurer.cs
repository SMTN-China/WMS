using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace LY.WMSCloud.EntityFrameworkCore
{
    public static class WMSCloudDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<WMSCloudDbContext> builder, string connectionString)
        {
            builder.UseMySql(connectionString);
            builder.UseLolita();
        }

        public static void Configure(DbContextOptionsBuilder<WMSCloudDbContext> builder, DbConnection connection)
        {
            builder.UseMySql(connection);
            builder.UseLolita();
        }
    }
}
