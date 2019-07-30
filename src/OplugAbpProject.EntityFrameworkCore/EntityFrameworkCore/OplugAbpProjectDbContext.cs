﻿using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using OplugAbpProject.Authorization.Roles;
using OplugAbpProject.Authorization.Users;
using OplugAbpProject.MultiTenancy;
using OplugAbpProject.CMS;
using OplugAbpProject.ERP;

namespace OplugAbpProject.EntityFrameworkCore
{
    public class OplugAbpProjectDbContext : AbpZeroDbContext<Tenant, Role, User, OplugAbpProjectDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public OplugAbpProjectDbContext(DbContextOptions<OplugAbpProjectDbContext> options)
            : base(options)
        {
        }

        public DbSet<Article> Article { get; set; }
        public DbSet<Category> Category { get; set; }
        public DbSet<Comments> Comments { get; set; }
        public DbSet<Members> Members { get; set; }
        public DbSet<Businesses> Businesses { get; set; }
        public DbSet<JobHead> JobHead { get; set; }
        public DbSet<JobMtl> JobMtl { get; set; }
        public DbSet<JobAsmbl> JobAsmbl { get; set; }
        public DbSet<JobOper> JobOper { get; set; }
        public DbSet<JobOpDtl> JobOpDtl { get; set; }
        public DbSet<JobPart> JobPart { get; set; }
        public DbSet<OpMaster> OpMaster { get; set; }
        public DbSet<OrderHed> OrderHed { get; set; }
        public DbSet<OrderDtl> OrderDtl { get; set; }
        public DbSet<OrderRel> OrderRel { get; set; }
        public DbSet<POHeader> POHeader { get; set; }
        public DbSet<PODetail> PODetail { get; set; }
        public DbSet<PORel> PORel { get; set; }
        public DbSet<Vendor> Vendor { get; set; }
        public DbSet<VendPart> VendPart { get; set; }
    }
}
