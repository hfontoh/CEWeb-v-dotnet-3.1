
using Microsoft.EntityFrameworkCore;

namespace CEWeb_v_dotnet_3._1
{
    public class DatabaseContext : DbContext
    {


       /* protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Seed();
        }
       */
        public DatabaseContext(DbContextOptions<DatabaseContext> options)
            : base(options) { }

        //public DbSet<Reservation> Reservations { get; set; }

        public DbSet<User> Users { get; set; }

        //public DbSet<Vehicle> Vehicles { get; set; }
    }

}
