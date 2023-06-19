using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Obligatorio1
{
    public class Agenda:IComparable<Agenda>
    {
        public static int UltimoId { get; set; } = 1;
        public int Id { get; set; }
        public DateTime FechaCreacion { get; set; }
        public bool Estado { get; set; }
        public Huesped Huesped { get; set; }
        public Actividad Actividad { get; set; }


        public Agenda() {
            Estado = false;
            Id = UltimoId;
            UltimoId++;
        }

        public Agenda(bool estado, Huesped huesped, Actividad actividad)
        {
            Id = UltimoId;
            UltimoId++;
            FechaCreacion = DateTime.Now;
            Estado = estado;
            Huesped = huesped;
            Actividad = actividad;
        }

        // valida la edad y disponibilidad para saber si puede agendarse
        public static bool Cumple(Actividad act, Huesped hue)
        {
            bool ret = false;

            int edad = DateTime.Now.Year - hue.FechaNacimiento.Year;

            if (edad >= act.EdadMinima && act.LugaresDisponibles > 0)
            {
                ret = true;
            }

            return ret;
        }

        public int CompareTo(Agenda other)
        {
            if (Actividad.Fecha > other.Actividad.Fecha)
            {
                // Si la fecha de esta agenda es mayor que la fecha de la otra agenda
                return 1; // Mayor
            }
            else if (Actividad.Fecha < other.Actividad.Fecha)
            {
                // Si la fecha de esta agenda es menor que la fecha de la otra agenda
                return -1; // Menor
            }
            else
            {
                // Si las fechas son iguales, compara por el nombre de actividad
                if (Actividad.Nombre.CompareTo(other.Actividad.Nombre) > 0)
                {
                    return 1; // Mayor
                }
                else if (Actividad.Nombre.CompareTo(other.Actividad.Nombre) < 0)
                {
                    return -1; // Menor
                }
                else
                {
                    return 0; // Igual
                }
            }
        }
    }
}

