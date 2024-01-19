using AdminApi.Models.App;
using AdminApi.Models.Helper;
using AdminApi.Models.Menu;
using AdminApi.Models.User;
using Microsoft.EntityFrameworkCore;
using System;
using AdminApi.Models.App.Invoice;


//using AdminApi.Models.App;

namespace AdminApi.Models
{
    public class AppDbContext:DbContext
    {
        internal object DistrictName;

        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Users> Users { get; set; }
        public virtual DbSet<UserRole> UserRole { get; set; }
        public virtual DbSet<LogHistory> LogHistory { get; set; }
        public virtual DbSet<AppMenu> Menu { get; set; }
        public virtual DbSet<MenuGroup> MenuGroup { get; set; }
        public virtual DbSet<MenuGroupWiseMenuMapping> MenuGroupWiseMenuMapping { get; set; }
        public virtual DbSet<Invoice> Invoice { get; set; }
        public virtual DbSet<SubInvoice> SubInvoice { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {   

            modelBuilder.Seed();//use this for Sql server,Mysql,Sqlite and PostgreSql
                                //modelBuilder.SeedOracle();//use this only for Oracle
            #region 


            //Invoice

            modelBuilder.Entity<Invoice>()
              .Property(s => s.CreatedOn)
              .HasDefaultValue(System.DateTime.Now);

            modelBuilder.Entity<Invoice>()
                .Property(s => s.IsDeleted)
                .HasDefaultValue(false)
                .ValueGeneratedNever();

            //SubInvoice

            modelBuilder.Entity<SubInvoice>()
              .Property(s => s.CreatedOn)
              .HasDefaultValue(System.DateTime.Now);

            modelBuilder.Entity<SubInvoice>()
                .Property(s => s.IsDeleted)
                .HasDefaultValue(false)
                .ValueGeneratedNever();

            #endregion
        }

    }
}
