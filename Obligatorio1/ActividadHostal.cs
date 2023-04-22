using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Obligatorio1
{
    public class ActividadHostal : Actividad
    {
        public string NomPersonaResponsable { get; set; }
        public string Lugar { get; set;}
        public bool EsAlAireLibre { get; set; }
        public ActividadHostal() { }
        public ActividadHostal(string nombre, string descripcion, DateTime fecha, int cantMaxPersonas, int edadMinima, double costoDolares, int lugaresDisponibles, string nomPersonaResponable, string lugar, bool esAlAireLibre) : base( nombre, descripcion, fecha, cantMaxPersonas, edadMinima, costoDolares, lugaresDisponibles)
        {
            NomPersonaResponsable = nomPersonaResponable;
            Lugar = lugar;
            EsAlAireLibre = esAlAireLibre;
        }


        public override void EsValido()
        {
            throw new NotImplementedException();
        }
    }
}
