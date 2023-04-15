using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Obligatorio1
{
    public class Huesped
    {
        public string TipoDocumento { get; set; }

        public int NumeroDocumento { get; set; }

        public string Nombre {get; set; }

        public string Apellido { get; set; }

        public int Habitacion { get; set; }

        public DateTime FechaNacimiento { get; set; }

        public int NivelFidelizacion { get; set; }



        public Huesped()
        {
            
        }

        public Huesped(string tipoDocumento, int numeroDocumento, string nombre, string apellido, int habitacion, DateTime fechaNacimiento, int nivelFidelizacion)
        {
            TipoDocumento = tipoDocumento;
            NumeroDocumento = numeroDocumento;
            Nombre = nombre;
            Apellido = apellido;
            Habitacion = habitacion;
            FechaNacimiento = fechaNacimiento;
            NivelFidelizacion = nivelFidelizacion;
        }
    }
}
