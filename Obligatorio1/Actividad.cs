using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Obligatorio1
{
    public abstract class Actividad:IValidacion
    {
        public static int UltimoId = 121;
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
        public virtual void EsValido()
        {
            if (String.IsNullOrEmpty(Nombre))
            {
                throw new Exception("Nombre no puede ser vacio o nulo");
            }
            if(String.IsNullOrEmpty(Descripcion))
            {
                throw new Exception("Descripcion no puede ser vacia o nula");
            }
            if(Fecha < DateTime.Now)
            {
                throw new Exception("La fecha debe ser mayor o igual a la actual");
            }
            if(Nombre.Length > 25)
            {
                throw new Exception("El nombre no puede contener más de 25 caracteres");
            }
        }


        public override string ToString()
        {
            return $"Id:{Id},Nombre:{Nombre},Desc.:{Descripcion},Fecha:{Fecha.ToShortDateString()},Cant.max:{CantMaxPersonas},Edad Min.:{EdadMinima}";
        }


    }
}
