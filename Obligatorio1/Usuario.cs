using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Obligatorio1
{
    public abstract class Usuario
    {
        public int UltimoId { get; set; }
        public int Id { get; set; }
        public string Email { get; set; }
        public string Contrasenia { get; set; }

        public Usuario()
        {

        }

        public Usuario(string email, string contrasenia)
        {
            Id = UltimoId;
            UltimoId++;
            Email = email;
            Contrasenia = contrasenia;
        }

        public abstract void EsValido();
    }
}
