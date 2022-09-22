using System.Collections.Generic;
using System.Linq;
using Drafts.App.Dominio;

namespace Drafts.App.Persistencia
{
    public class RepositorioAdmin : IRepositorioAdmin
    {
       private readonly AppContext appcox;
        public RepositorioAdmin(AppContext appcontext)
        {
            appcox = appcontext;
        }
        Administrador IRepositorioAdmin.AddAdmin(Drafts.App.Dominio.Administrador Administrador){

            var agregarAdmin = appcox.Admin.Add(Administrador);
            appcox.SaveChanges();
            return agregarAdmin.Entity;
        }
        // Eliminar
        void IRepositorioAdmin.DeleteAdmin(int id_Admin) {

            var encontrarAdmin = appcox.Admin.FirstOrDefault (p=> p.Id == id_Admin);

            if (encontrarAdmin == null){
                return;
            }
            appcox.Admin.Remove(encontrarAdmin);
            appcox.SaveChanges ();

        }
        ////llamar a todos los datos de la tabla 
        IEnumerable<Administrador> IRepositorioAdmin.GetAllAdministrador(){
            return appcox.Admin;
        }

        //llamar a una persona en especifico
        Administrador IRepositorioAdmin.GetAdmin(int idAdmin){

            return appcox.Admin.FirstOrDefault (p => p.Id == idAdmin);
        }
        //Actualizar 
       
        Administrador IRepositorioAdmin.UpdateAdmin(Drafts.App.Dominio.Administrador administrador) {

            var AdminEncontrado = appcox.Admin.FirstOrDefault (p => p.Id== administrador.Id);

            if(AdminEncontrado!= null){
                AdminEncontrado.Nombre_Admin = administrador.Nombre_Admin;
                appcox.SaveChanges();
            }
            return AdminEncontrado;
        
            
        }


    }
}