using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using OplugAbpProject.Authorization.Roles;
using OplugAbpProject.Authorization.Users;
using OplugAbpProject.MultiTenancy;

namespace OplugAbpProject.EntityFrameworkCore
{
    public class OplugAbpProjectDbContext : AbpZeroDbContext<Tenant, Role, User, OplugAbpProjectDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public OplugAbpProjectDbContext(DbContextOptions<OplugAbpProjectDbContext> options)
            : base(options)
        {
        }
    }
}
