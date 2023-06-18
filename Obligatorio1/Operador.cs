using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Obligatorio1
{
    public class Operador : Usuario
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public DateTime FechaEmpezoTrabajar { get; set; }


        public override void EsValido()
        {
            base.EsValido();
        }

        public Operador(string nombre, string apellido, DateTime fechaEmpezoTrabajar,string email, string contrasenia):base(email,contrasenia)
        {
            Nombre = nombre;
            Apellido = apellido;
            FechaEmpezoTrabajar = fechaEmpezoTrabajar;
        }
    }
}
