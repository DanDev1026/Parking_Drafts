using System.Collections.Generic;
using System.Linq;
using Drafts.App.Dominio;

namespace Drafts.App.Persistencia.AppRepositorios
{
    public class RepositorioVehiculo : IRepositorioVehiculo
    {
        private readonly AppContext appcox;
        public RepositorioVehiculo(AppContext appcontext)
        {
            appcox = appcontext;
        }
        Vehiculo IRepositorioVehiculo.AddVehiculo(Drafts.App.Dominio.Vehiculo Vehiculo){

            var agregarAuto = appcox.Vehiculoss.Add(Vehiculo);
            appcox.SaveChanges();
            return agregarAuto.Entity;
        }
        // Eliminar
        void IRepositorioVehiculo.DeleteVehiculo(int idAuto) {

            var encontrarAuto = appcox.Vehiculoss.FirstOrDefault (p=> p.Id == idAuto);

            if (encontrarAuto == null){
                return;
            }
            appcox.Vehiculoss.Remove(encontrarAuto);
            appcox.SaveChanges ();

        }
        ////llamar a todos los datos de la tabla 
        IEnumerable<Vehiculo> IRepositorioVehiculo.GetAllVehiculo(){
            return appcox.Vehiculoss;
        }

        //llamar a una persona en especifico
        Vehiculo IRepositorioVehiculo.GetVehiculo(int idAuto){

            return appcox.Vehiculoss.FirstOrDefault (p => p.Id == idAuto);
        }
        //Actualizar 
       
        Vehiculo IRepositorioVehiculo.UpdateVehiculo(Drafts.App.Dominio.Vehiculo Vehiculo){

            var AutoEncontrado = appcox.Vehiculoss.FirstOrDefault (p => p.Id== Vehiculo.Id);

            if(AutoEncontrado != null){
                AutoEncontrado.Propietario = Vehiculo.Propietario;
                appcox.SaveChanges();
            }
            return AutoEncontrado;
        
            
        }
    }
}