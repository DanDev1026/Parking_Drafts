using Microsoft.EntityFrameworkCore;
using Drafts.App.Dominio;

namespace Drafts.App.Persistencia
{
    public class AppContext : DbContext
    {
        public DbSet<Administrador> Admin { get; set; }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<FormaPago> Pago { get; set; }
        public DbSet<Parqueadero> Parking { get; set; }
        public DbSet<Registro> Registrar { get; set; }
        public DbSet<TipoVehiculo> TipoVehiculoss { get; set; }
        public DbSet <Vehiculo> Vehiculoss {get; set;}
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder
                .UseSqlServer("Data Source = (localDb)\\MSSQLLocalDb; Initial Catalog =DraftstData");
            }
        }
    }


}