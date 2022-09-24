using System.Collections.Generic;
using System.Linq;
using Drafts.App.Dominio;


namespace Drafts.App.Persistencia.AppRepositorios
{
    public class RepositorioRegistro : IRepositorioRegistro
    {
        private readonly AppContext appcox;
        public RepositorioRegistro(AppContext appcontext)
        {
            appcox = appcontext;
        }
        Registro IRepositorioRegistro.AddRegistro(Drafts.App.Dominio.Registro Registro){

            var agregarRegistro = appcox.Registrar.Add(Registro);
            appcox.SaveChanges();
            return agregarRegistro.Entity;
        }
        // Eliminar
        void IRepositorioRegistro.DeleteRegistro(int idRegis) {

            var encontrarRegistro = appcox.Registrar.FirstOrDefault (p=> p.Id == idRegis);

            if (encontrarRegistro == null){
                return;
            }
            appcox.Registrar.Remove(encontrarRegistro);
            appcox.SaveChanges ();

        }
        ////llamar a todos los datos de la tabla 
        IEnumerable<Registro> IRepositorioRegistro.GetAllRegistro(){
            return appcox.Registrar;
        }

        //llamar a una persona en especifico
        Registro IRepositorioRegistro.GetRegistro(int idRegis){

            return appcox.Registrar.FirstOrDefault (p => p.Id == idRegis);
        }
        //Actualizar 
       
        Registro IRepositorioRegistro.UpdateRegistro(Drafts.App.Dominio.Registro Registro){

            var RegisEncontrado = appcox.Registrar.FirstOrDefault (p => p.Id== Registro.Id);

            if(RegisEncontrado != null){
                RegisEncontrado.Numero_Puesto = Registro.Numero_Puesto;
                appcox.SaveChanges();
            }
            return RegisEncontrado;
        
            
        }
        
    }
}