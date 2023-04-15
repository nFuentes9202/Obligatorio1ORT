using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Obligatorio1
{
    public abstract class Actividad
    {
        public static int UltimoId { get; set; }
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public DateTime Fecha { get; set; }
        public int CantMaxPersonas { get; set; }
        public int EdadMinima { get; set; }
        public double CostoDolares { get; set; }
        public int LugaresDisponibles { get; set; }
        public Actividad()
        {

        }
        public Actividad(string nombre, string descripcion, DateTime fecha, int cantMaxPersonas, int edadMinima, double costoDolares, int lugaresDisponibles)
        {
            Id = UltimoId;
            UltimoId++;
            Nombre = nombre;
            Descripcion = descripcion;
            Fecha = fecha;
            CantMaxPersonas = cantMaxPersonas;
            EdadMinima = edadMinima;
            CostoDolares = costoDolares;
            LugaresDisponibles = lugaresDisponibles;
        }
        public abstract void EsValido();
    }
}
