using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Obligatorio1
{
    public class Proveedor
    {
        public static int UltimoId { get; set; }
        public int Id { get; set; }
        public static string NombreUnico { get; set; }
        public string Telefono { get; set; }
        public string Direccion { get; set; }
        public int Descuento { get; set; }

        public void EsVAlido()
        { 
        }

        public bool FijarDescuentoActividad(int Descuento)
        {
            return false;
        }

        public Proveedor()
        {
            Id = UltimoId;
            UltimoId++;
        }

        public Proveedor(int id, string telefono, string direccion, int descuento)
        {
            Id = id;
            Telefono = telefono;
            Direccion = direccion;
            Descuento = descuento;
        }
    }
}
