using System.Collections.Generic;
using System.Linq;
using Drafts.App.Dominio;


namespace Drafts.App.Persistencia
{
    public class Repositorio : IRepositorio
    {
        private readonly AppContext appcox;
        public Repositorio(AppContext appcontext)
        {
            appcox = appcontext;
        }
        Cliente IRepositorio.AddCliente (Drafts.App.Dominio.Cliente cliente){

            var agregarCliente = appcox.Clientes.Add(cliente);
            appcox.SaveChanges();
            return agregarCliente.Entity;
        }
        // Eliminar
        void IRepositorio.DeleteCliente (int id_clientes) {

            var encontrarCliente = appcox.Clientes.FirstOrDefault (p=> p.Id == id_clientes);

            if (encontrarCliente == null){
                return;
            }
            appcox.Clientes.Remove(encontrarCliente);
            appcox.SaveChanges ();

        }
        ////llamar a todos los datos de la tabla 
        IEnumerable<Cliente> IRepositorio.GetAllCliente(){
            return appcox.Clientes;
        }

        //llamar a una persona en especifico
        Cliente IRepositorio.GetCliente(int id_clientes){

            return appcox.Clientes.FirstOrDefault (p => p.Id == id_clientes);
        }
        //Actualizar 
       
        Cliente IRepositorio.UpdateCliente(Drafts.App.Dominio.Cliente cliente) {

            var ClienteEncontrado = appcox.Clientes.FirstOrDefault (p => p.Id== cliente.Id);

            if(ClienteEncontrado != null){
                ClienteEncontrado.Nombre_Cliente = cliente.Nombre_Cliente;
                appcox.SaveChanges();
            }
            return ClienteEncontrado;
        
            
        }


    }


}