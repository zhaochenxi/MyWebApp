using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Model
{
    public class MyWebAppDbContext:DbContext
    {
        public MyWebAppDbContext(DbContextOptions<MyWebAppDbContext> options)
               : base(options)
        {
        }

        public DbSet<TUser> Users { get; set; }
        public DbSet<TRole> Roles { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            //modelBuilder.Entity<TUser>().ToTable("TUser");
            //modelBuilder.Entity<TRole>().ToTable("TRole");
        }

    }
}
