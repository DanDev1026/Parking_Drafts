using Microsoft.EntityFrameworkCore;
using Drafts.App.Dominio;

namespace Drafts.App.Persistencia
{
    public class AppContext: DbContext
    {
        public DbSet <Cliente> Clientes {get; set;}
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured){
                optionsBuilder
                .UseSqlServer("Data Source = (localDb)\\MSSQLLocalDb; Initial Catalog =DraftstData");
            }
        }
    }


}