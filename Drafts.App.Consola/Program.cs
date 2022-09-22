using System;
using Drafts.App.Dominio;
using Drafts.App.Persistencia;

namespace Drafts.App.Consola
{
    class Program
    {
        private static IRepositorioCliente _repoClientes = new RepositorioCliente(new Drafts.App.Persistencia.AppContext());
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World");
           // AddCliente();
            
            buscarCliente(1);

        }
        private static void AddCliente(){
            var cliente = new Cliente {
                Usuario_Frecuente= "Si",
                
                Usuario_Nuevo = "Si",
                Usuario_Normal = "No",
                Nombre_Cliente = "Andres",
                Telefono = "3032558885",
                


            };
            _repoClientes.AddCliente(cliente);

            

        }

        private static void buscarCliente (int Id_Clientes){
            var cliente = _repoClientes.GetCliente(Id_Clientes);

            if (cliente != null){
                Console.WriteLine ( "Usuario Frecuente: "+cliente.Usuario_Frecuente+
                "\n Usuario nuevo: "+cliente.Usuario_Nuevo+"/n Usuario Normal: "+cliente.Usuario_Normal+
                "\n Nombre del Cliente: "+cliente.Nombre_Cliente+
                "\n Telefono: "+ cliente.Telefono
                );
            }


        }
    }
}
