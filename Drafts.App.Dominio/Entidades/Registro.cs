using System;

namespace Drafts.App.Dominio
{
    public class Registro
    {
        public int Id_Usuario { get; set; }
        public string Hora_Entrada { get; set; }
        public string Fecha_Entrada { get; set;}
        public string Numero_Puesto { get ; set; }
        public string Hora_Salida { get; set; }
        public string Fecha_Salida { get; set; }
        public string Tiempo_Total { get; set; }
    }
}