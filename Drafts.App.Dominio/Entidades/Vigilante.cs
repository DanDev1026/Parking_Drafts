using System;

namespace Drafts.App.Dominio
{
    public class Vigilante
    {
        public int Id { get; set; }
        public string Pisos { get; set; }
        public string Zona { get; set; }
        public string Distribucion_AlfaNum { get; set; }
        public string Espacio_Libre { get; set; }
        public string Espacio_Ocupado { get; set; }
    }
}