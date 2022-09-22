using System.Collections.Generic;
using Drafts.App.Dominio;

namespace Drafts.App.Persistencia
{
    public interface IRepositorioAdmin
    {
       
        IEnumerable<Administrador> GetAllAdministrador();
        Administrador AddAdmin(Administrador Administrador);
        Administrador UpdateAdmin(Administrador Administrador);
        void DeleteAdmin(int idAdmin);
        Administrador GetAdmin(int idAdmin);

    }
}