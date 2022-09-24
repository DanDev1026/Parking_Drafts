using System.Collections.Generic;
using System.Linq;
using Drafts.App.Dominio;


namespace Drafts.App.Persistencia
{
    public class RepositorioCliente : IRepositorioCliente
    {
        private readonly AppContext appcox;
        public RepositorioCliente()
        {
           
        }
        public RepositorioCliente(AppContext appcontext)
        {
            appcox = appcontext;
        }
        Cliente IRepositorioCliente.AddCliente (Drafts.App.Dominio.Cliente cliente){

            var agregarCliente = appcox.Clientes.Add(cliente);
            appcox.SaveChanges();
            return agregarCliente.Entity;
        }
        // Eliminar
        void IRepositorioCliente.DeleteCliente (int id_clientes) {

            var encontrarCliente = appcox.Clientes.FirstOrDefault (p=> p.Id == id_clientes);

            if (encontrarCliente == null){
                return;
            }
            appcox.Clientes.Remove(encontrarCliente);
            appcox.SaveChanges ();

        }
        ////llamar a todos los datos de la tabla 
        IEnumerable<Cliente> IRepositorioCliente.GetAllCliente(){
            return appcox.Clientes;
        }

        //llamar a una persona en especifico
        Cliente IRepositorioCliente.GetCliente(int id_clientes){

            return appcox.Clientes.FirstOrDefault (p => p.Id == id_clientes);
        }
        //Actualizar 
       
        Cliente IRepositorioCliente.UpdateCliente(Drafts.App.Dominio.Cliente cliente) {

            var ClienteEncontrado = appcox.Clientes.FirstOrDefault (p => p.Id== cliente.Id);

            if(ClienteEncontrado != null){
                ClienteEncontrado.Nombre_Cliente = cliente.Nombre_Cliente;
                appcox.SaveChanges();
            }
            return ClienteEncontrado;
        
            
        }


    }


}