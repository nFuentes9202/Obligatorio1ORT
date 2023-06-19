using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Obligatorio1
{
    public abstract class Actividad : IValidacion, IComparable<Actividad>
    {
 
    public static int UltimoId = 1;
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
            Id = UltimoId;
            UltimoId++;
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

        //Validaciones 
        public abstract string GetTipo();
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



        /* //Nos devuelve la lista de actividades ordenada por costo descendente
         public int CompareTo(Actividad? other)
     {
         if (CostoDolares.CompareTo(other.CostoDolares) > 0)
         {
             return -1;
         }
         else if (CostoDolares.CompareTo(other.CostoDolares) < 0)
         {
             return 1;
         }
         else
         {
             return 0;

         }
     }
        */
        //Nos devuelve la lista con las fechas ordenadas descendentemente
        public int CompareTo(Actividad other)
        {
            if (Fecha < other.Fecha)
            {
                return 1; // Mayor
            }
            else if (Fecha > other.Fecha)
            {
                return -1; // Menor
            }
            else
            {
                return 0; // Igual
            }
        }
        //Formateamos el ToString para que se muestre la lista de Actividades como quieramos.
        public override string ToString()
        {
            return $"Id:{Id},Nombre:{Nombre},Desc.:{Descripcion},Fecha:{Fecha.ToShortDateString()},Cant.max:{CantMaxPersonas},Edad Min.:{EdadMinima}";
        }


    }
}
