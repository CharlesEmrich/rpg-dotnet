using System;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;

namespace RPG.Models
{
    public class RPGDbContext : IdentityDbContext<ApplicationUser>
    {
        public RPGDbContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Door> Doors { get; set; }
        public DbSet<Key> Keys { get; set; }
        public DbSet<Player> Players { get; set; }
        public DbSet<Room> Rooms { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=RPG;integrated security=True");
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
    }
}