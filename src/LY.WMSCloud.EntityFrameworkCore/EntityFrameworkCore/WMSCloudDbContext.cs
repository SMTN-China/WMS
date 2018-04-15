using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using LY.WMSCloud.Authorization.Roles;
using LY.WMSCloud.Authorization.Users;
using LY.WMSCloud.MultiTenancy;
using LY.WMSCloud.Entities;

namespace LY.WMSCloud.EntityFrameworkCore
{
    public class WMSCloudDbContext : AbpZeroDbContext<Tenant, Role, User, WMSCloudDbContext>
    {
        /* Define a DbSet for each entity of the application */

        public virtual DbSet<Org> Orgs { set; get; }

        public virtual DbSet<Menu> Menus { set; get; }


        public WMSCloudDbContext(DbContextOptions<WMSCloudDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // modelBuilder.Entity<TestEntitie>(b => b.ToTable("MesTestEntitie"));

        }
    }
}
