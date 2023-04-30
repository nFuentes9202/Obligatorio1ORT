using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Obligatorio1
{
    public class Proveedor:IValidacion, IComparable<Proveedor>
    {
        public static int UltimoId { get; set; }
        public int Id { get; set; }
        public string NombreUnico { get; set; }
        public string Telefono { get; set; }
        public string Direccion { get; set; }
        public double Descuento { get; set; }




         

        public void EsValido()
        {
            if (string.IsNullOrEmpty(NombreUnico))
            {
                throw new Exception("Nombre no puede ser vacio");
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

        public int CompareTo(Proveedor? other)
        {
            if (NombreUnico.CompareTo(other.NombreUnico) > 0)
            {
                return 1;
            }
            else if (NombreUnico.CompareTo(other.NombreUnico) < 0) {
                return -1;
            }
            else
            {
                return 0;

            }
        }

        public Proveedor()
        {
            Id = UltimoId;
            UltimoId++;
        }

        public Proveedor(string nombreUnico,string telefono, string direccion, double descuento)
        {
            Id = UltimoId;
            UltimoId++;
            NombreUnico = nombreUnico;
            Telefono = telefono;
            Direccion = direccion;
            Descuento = descuento;
        }

        public override string ToString()
        {
            return $"Id:{Id},Nombre:{NombreUnico},Tel:{Telefono},Dir:{Direccion},Descuento:{Descuento}%";
        }

    }
}
