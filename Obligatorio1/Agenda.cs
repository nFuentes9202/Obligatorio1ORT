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

   // public double CalcularCosto()
   // {
        //preguntarle a actividad si la misma es del hostal o tercerizada
        //if(Actividad a is ActividadHostal){
            //preguntar el tipo de fidelidad del huesped y retornar el costo base con el % adecuado
        //}
    //}

    //public void FijarEstado(bool estado)
    //{
    //    if (!estado)
    //    {
    //        estado = true;
    //    }
    //}
}
