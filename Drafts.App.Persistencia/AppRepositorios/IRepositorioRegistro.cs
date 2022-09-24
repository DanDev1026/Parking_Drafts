using System.Collections.Generic;
using Drafts.App.Dominio;

namespace Drafts.App.Persistencia.AppRepositorios
{
    public interface IRepositorioRegistro 
    {
        IEnumerable<Registro> GetAllRegistro();
        Registro AddRegistro(Registro Registro);
        Registro UpdateRegistro(Registro Registro);
        void DeleteRegistro(int idRegis);
        Registro GetRegistro(int idRegis);
    }
}