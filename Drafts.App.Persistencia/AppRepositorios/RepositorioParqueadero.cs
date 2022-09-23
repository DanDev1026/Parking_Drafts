using System.Collections.Generic;
using System.Linq;
using Drafts.App.Dominio;

namespace Drafts.App.Persistencia.AppRepositorios
{
    public class RepositorioParqueadero: IRepositorioParqueadero
    {
        
        private readonly AppContext appcox;
        public RepositorioParqueadero(AppContext appcontext)
        {
            appcox = appcontext;
        }
        Parqueadero IRepositorioParqueadero.AddParqueadero(Drafts.App.Dominio.Parqueadero parqueadero){

            var agregarParqueadero = appcox.Parking.Add(parqueadero);
            appcox.SaveChanges();
            return agregarParqueadero.Entity;
        }
        // Eliminar
        void IRepositorioParqueadero.DeleteParqueadero(int idParqueadero) {

            var encontrarParqueadero = appcox.Parking.FirstOrDefault (p=> p.Id == idParqueadero);

            if (encontrarParqueadero == null){
                return;
            }
            appcox.Parking.Remove(encontrarParqueadero);
            appcox.SaveChanges ();

        }
        ////llamar a todos los datos de la tabla 
        IEnumerable<Parqueadero> IRepositorioParqueadero.GetAllParqueadero(){
            return appcox.Parking;
        }

        //llamar a una persona en especifico
        Parqueadero IRepositorioParqueadero.GetParqueadero(int idParqueadero){

            return appcox.Parking.FirstOrDefault (p => p.Id == idParqueadero);
        }
        //Actualizar 
       
        Parqueadero IRepositorioParqueadero.UpdateParqueadero(Drafts.App.Dominio.Parqueadero parqueadero){

            var ParqueaderoEncontrado = appcox.Parking.FirstOrDefault (p => p.Id== parqueadero.Id);

            if(ParqueaderoEncontrado != null){
                ParqueaderoEncontrado.Distribucion_AlfaNum = parqueadero.Distribucion_AlfaNum;
                appcox.SaveChanges();
            }
            return ParqueaderoEncontrado;
        
            
        }

    }
}