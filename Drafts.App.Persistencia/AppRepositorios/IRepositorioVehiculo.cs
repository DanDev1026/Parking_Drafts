using System.Collections.Generic;
using Drafts.App.Dominio;

namespace Drafts.App.Persistencia.AppRepositorios
{
    public interface IRepositorioVehiculo
    {
        IEnumerable<Vehiculo> GetAllVehiculo();
        Vehiculo AddVehiculo(Vehiculo Vehiculo);
        Vehiculo UpdateVehiculo(Vehiculo Vehiculo);
        void DeleteVehiculo(int idAuto);
        Vehiculo GetVehiculo(int idAuto);
    }
}