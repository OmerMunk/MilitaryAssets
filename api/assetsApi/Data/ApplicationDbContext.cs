using System;
using Microsoft.EntityFrameworkCore;

namespace assetsApi.Data;
{
    public class ApplicationDbContext : DbContext
    {

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            Database.EnsureCreated();
        }


        public DbSet<Weapon> Weapons { get; set; }
        public DbSet<Soldier> Soldiers { get; set; }
        public DbSet<Vehicle> Vehicles { get; set; }
        public DbSet<Users> Users { get; set; }
        public DbSet<Unit> Units { get; set; }

    }
}



