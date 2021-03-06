using Microsoft.EntityFrameworkCore;
using Parking.App.Dominio;

namespace Parking.App.Persistencia
{
    public class AppContext:DbContext
    {
        public DbSet<Persona> Personas {get;set;}
        public DbSet<Reserva> Reservas {get;set;}
    
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (!optionsBuilder.IsConfigured)
        {
            optionsBuilder
            .UseSqlServer("Data Source = (localdb)\\MSSQLLocalDB; Initial Catalog = ParkingData");
        }
    }
    }
}