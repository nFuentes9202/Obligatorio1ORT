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
        public string? Email { get; set; }
        public string? Contrasenia { get; set; }

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

        //Validación
        public virtual void EsValido()
        {   
            if (Email != null && !Email.Contains("@"))
            {
                throw new Exception("El email debe tener el símbolo '@'");
            }
            if(Email != null &&  Email.IndexOf("@") == 0 || Email != null && Email.IndexOf("@") == Email.Length - 1)
            {
                throw new Exception("El símbolo '@' no puede estar al final o al inicio del email");
            }
            if(Contrasenia.Length < 8)
            {
                throw new Exception("La contraseña debe ser mayor o igual a 8 caracteres");
            }
        }
    }
}
