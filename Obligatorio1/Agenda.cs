using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Obligatorio1
{
    public class Agenda
    {
        public DateTime FechaCreacion { get; set; }
        public bool Estado { get; set; }
        public Huesped Huesped { get; set; }
        public Actividad Actividad { get; set; }
        public Agenda() { }

        public Agenda(bool estado, Huesped huesped, Actividad actividad)
        {
            FechaCreacion = DateTime.Now;
            Estado = estado;
            Huesped = huesped;
            Actividad = actividad;
        }
    }

}
