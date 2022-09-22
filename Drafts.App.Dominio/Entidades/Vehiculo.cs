using System;

namespace Drafts.App.Dominio
{
    public class Vehiculo
    {
        public int Id { get; set; }
        public string Propietario {get; set; }
        public string Placa { get; set; }
        public string Marca { get; set;}
        public string Observaciones { get; set;}
    }
}