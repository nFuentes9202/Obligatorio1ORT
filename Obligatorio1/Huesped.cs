﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Obligatorio1
{
    public class Huesped: Usuario
    {
        public string TipoDocumento { get; set; }

        public string NumeroDocumento { get; set; }

        public string Nombre {get; set; }

        public string Apellido { get; set; }

        public string Habitacion { get; set; }

        public DateTime FechaNacimiento { get; set; }

        public int NivelFidelizacion { get; set; }



        public Huesped()
        {
            
        }

        public Huesped(string tipoDocumento, string numeroDocumento, string nombre, string apellido, string habitacion, DateTime fechaNacimiento, int nivelFidelizacion ,string email, string contrasenia):base(email, contrasenia)
        {
            TipoDocumento = tipoDocumento;
            NumeroDocumento = numeroDocumento;
            Nombre = nombre;
            Apellido = apellido;
            Habitacion = habitacion;
            FechaNacimiento = fechaNacimiento;
            NivelFidelizacion = nivelFidelizacion;
        }

        public override void EsValido()
        {
            if (String.IsNullOrEmpty(Habitacion))
            {
                if(TipoDocumento == "CI")
                {
                    if (!EsCedulaValida(NumeroDocumento))
                    {
                        throw new Exception("Cedula no válida");
                    }
                }
            }

        }
        private static bool EsCedulaValida(string cedula)
        {
            if(cedula.Length != 8)
            {
                return false;
            }
            List<int> Multiplicadores = new List<int> { 2, 9, 8, 7, 6, 3, 4 };
            int suma = 0;
            for (int i = 0; i < 7; i++)
            {
                int digito = int.Parse(cedula[i].ToString());
                int producto = digito * Multiplicadores[i];
                suma += producto;
            }
            int resto = suma % 10;
            int verificador;
            if(resto == 0)
            {
                verificador = 0;
            }
            else
            {
                verificador = 10 - resto;
            }
            int digitoVerificador = int.Parse(cedula[7].ToString());
            return verificador == digitoVerificador;
        }
    }
}
