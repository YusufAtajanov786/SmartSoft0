using Entities.Model.User;
using Entities.Model.User_Warehouse;
using Entities.Model.Warehouse;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class RepoContext:DbContext
    {
        public RepoContext(DbContextOptions<RepoContext> dbContextOptions)
            :base(dbContextOptions)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User_Warehouse>()
                .HasOne(u => u.User)
                .WithMany(uw => uw.User_Warehouses)
                .HasForeignKey(ui => ui.UserId);

            modelBuilder.Entity<User_Warehouse>()
              .HasOne(u => u.Warehouse)
              .WithMany(uw => uw.User_Warehouses)
              .HasForeignKey(ui => ui.WarehouseId);
        }

        public DbSet<User> User { get; set; }
        public DbSet<Warehouse> Warehouse { get; set; }

        public DbSet<User_Warehouse> User_Warehouses { get; set; }
    }
}
