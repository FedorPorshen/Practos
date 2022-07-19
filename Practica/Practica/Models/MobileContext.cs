using Microsoft.EntityFrameworkCore;
using Practica.Models;

namespace Practica.Models
{
    public class MobileContext : DbContext
    {
        public DbSet<Player> Players { get; set; }
        public DbSet<Order> Orders { get; set; }

        public MobileContext(DbContextOptions<MobileContext> options)
            : base(options)
        {
            Database.EnsureCreated();
            //Database.EnsureDeleted();
        }
    }
}