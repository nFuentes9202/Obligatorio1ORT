using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Obligatorio1
{
    public abstract class Usuario:IValidacion
    {
        public static int UltimoId { get; set; }
        public int Id { get; set; }
        public string Email { get; set; }
        public string Contrasenia { get; set; }

        public Usuario()
        {
            Id = UltimoId;
            UltimoId++;
        }

        public Usuario(string email, string contrasenia)
        {
            Id = UltimoId;
            UltimoId++;
            Email = email;
            Contrasenia = contrasenia;
        }

        //Validacion
        public virtual void EsValido()
        {
            if (!Email.Contains("@"))
            {
                throw new Exception("El email debe tener el simbolo '@'");
            }
            if(Email.IndexOf("@") == 0 || Email.IndexOf("@") == Email.Length - 1)
            {
                throw new Exception("El simbolo '@' no puede estar al final o al inicio del email");
            }
            if(Contrasenia.Length < 8)
            {
                throw new Exception("La contraseña debe ser mayor o igual a 8 caracteres");
            }
        }
    }
}
