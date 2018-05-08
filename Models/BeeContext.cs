using Microsoft.EntityFrameworkCore;

namespace BEE.Models
{
    public class BeeContext : DbContext
    {
        // base() calls the parent class' constructor passing the "options" parameter along
        public BeeContext(DbContextOptions<BeeContext> options) : base(options) { }
<<<<<<< HEAD
        // public DbSet<user> users { get; set; }
        // public DbSet<hive> hives { get; set; }
        public DbSet<permission> permissions { get; set; }
=======
        public DbSet<user> users { get; set; }
        // public DbSet<hive> hives { get; set; }
        // public DbSet<permission> permissions { get; set; }
>>>>>>> mags

    }
}