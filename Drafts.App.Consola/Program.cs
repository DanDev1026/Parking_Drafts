using System;
using Drafts.App.Dominio;
using Drafts.App.Persistencia;

namespace Drafts.App.Consola
{
    class Program
    {
        private static IRepositorio _repoClientes = new Repositorio(new Drafts.App.Persistencia.AppContext());
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World");
            //AddPerson();

            //buscarCliente(1);
        }
        private static void AddCliente(){
            var cliente = new Cliente {
                Usuario_Frecuente= "No",
                
                Usuario_Nuevo = "Si",
                Usuario_Normal = "Si",
                Nombre_Cliente = "Daniela",
                Telefono = 30256,
                
                


            };
            _repoClientes.AddCliente(cliente);

            

        }

        private static void buscarCliente (int Id_Clientes){
            var cliente = _repoClientes.GetCliente(Id_Clientes);

            if (person != null){
                Console.WriteLine("Usuario Frecuente: "+cliente.Usuario_Frecuente+
                "\n Usuario nuevo: "+cliente.Usuario_Nuevo+"/n Usuario Normal: "+cliente.Usuario_Normal+
                "\n Nombre del Cliente: "+cliente.Nombre_Cliente+
                "\n Telefono: "+ cliente.Telefono
                );
            }


        }
    }
}
