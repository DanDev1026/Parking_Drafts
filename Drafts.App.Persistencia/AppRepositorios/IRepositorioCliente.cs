using System.Collections.Generic;
using Drafts.App.Dominio;
 
namespace Drafts.App.Persistencia
{
    public interface IRepositorioCliente
    {
 
        IEnumerable<Cliente> GetAllCliente();
        Cliente AddCliente(Cliente cliente);
        Cliente UpdateCliente(Cliente cliente);
        void DeleteCliente(int idcliente);
        Cliente GetCliente(int idcliente);
 
    }
}