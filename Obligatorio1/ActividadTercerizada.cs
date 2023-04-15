﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Obligatorio1
{
    public class ActividadTercerizada : Actividad
    {
        public bool EstaConfirmada { get; set; }
        public DateTime FechaConfirmacion { get; set; }
        public ActividadTercerizada() { }
        //TODO - Falta agregar proveedor a la actividad tercerizada
        public ActividadTercerizada(string nombre, string descripcion, DateTime fecha, int cantMaxPersonas, int edadMinima, double costoDolares, int lugaresDisponibles, bool estaConfirmada, DateTime fechaConfirmacion ) : base(nombre, descripcion, fecha, cantMaxPersonas, edadMinima, costoDolares, lugaresDisponibles)
        {
            EstaConfirmada = estaConfirmada;
            FechaConfirmacion = fechaConfirmacion;
        }
        public override void EsValido()
        {
            throw new NotImplementedException();
        }
    }
}
