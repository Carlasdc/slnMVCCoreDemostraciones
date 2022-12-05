using Microsoft.EntityFrameworkCore;
using WebPasajeros.Models;

namespace WebPasajeros.Data
{
    public class PasajeroContext : DbContext
    {
        public PasajeroContext(DbContextOptions<PasajeroContext> options) : base(options) { }

        public DbSet<Pasajero> Pasajeros { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Pasajero>().HasData(
               new Pasajero
               {
                   Id = 1,
                   Nombre = "Tara",
                   Apellido = "Brewer",
                   FechaNacimiento = new System.DateTime(2001 / 11 / 6),
                   Ciudad = "Ocala",

               },
               new Pasajero
               {
                   Id = 2,
                   Nombre = "Andrew",
                   Apellido = "Tippett",
                   FechaNacimiento = new System.DateTime(2001 / 12 / 6),
                   Ciudad = "Anaheim",

               });

        }
    }
}
