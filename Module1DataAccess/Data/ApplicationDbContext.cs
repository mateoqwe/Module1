using Microsoft.EntityFrameworkCore;
using Module1Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Module1DataAccess.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<AdminUser> AdminUsers { get; set; }

        public DbSet<AdminUserRole> AdminUserRoles { get; set; }

        public DbSet<Screen> Screens { get; set; }

        public DbSet<AdminUserFromView> AdminUserFromViews { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //configure SQL View
            modelBuilder.Entity<AdminUserFromView>().HasNoKey().ToView("GetAdminUserInfo");
        }
    }
}
