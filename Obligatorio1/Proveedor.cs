using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Obligatorio1
{
    public class Proveedor:IValidacion
    {
        public static int UltimoId { get; set; }
        public int Id { get; set; }
        public string NombreUnico { get; set; }
        public string Telefono { get; set; }
        public string Direccion { get; set; }
        public int Descuento { get; set; }

        

        public bool FijarDescuentoActividad(int Descuento)
        {
            //TODO
            return false;
        }

        public void EsValido()
        {
            if (string.IsNullOrEmpty(NombreUnico))
            {
                throw new Exception("Nombre no puede ser vacio o nulo");
            }
            if (string.IsNullOrEmpty(Telefono))
            {
                throw new Exception("Telefono no puede ser vacio o nulo");
            }
            if (string.IsNullOrEmpty(Direccion))
            {
                throw new Exception("La direccion de correo no puede ser vacio o nulo");
            }
        }

        public Proveedor()
        {
            Id = UltimoId;
            UltimoId++;
        }

        public Proveedor(string telefono, string direccion, int descuento)
        {
            Telefono = telefono;
            Direccion = direccion;
            Descuento = descuento;
        }
    }
}
