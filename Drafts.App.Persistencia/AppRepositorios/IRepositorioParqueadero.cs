using System.Collections.Generic;
using Drafts.App.Dominio;

namespace Drafts.App.Persistencia
{
    public interface IRepositorioParqueadero
    {
        IEnumerable<Parqueadero> GetAllParqueadero();
        Parqueadero AddParqueadero(Parqueadero Parqueadero);
        Parqueadero UpdateParqueadero(Parqueadero Parqueadero);
        void DeleteParqueadero(int idParqueadero);
        Parqueadero GetParqueadero(int idParqueadero);
    }
}