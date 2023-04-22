using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Obligatorio1
{
    public class Sistema
    {
        private static Sistema _instance = null;
        private Sistema()
        {
        }
        public static Sistema GetInstancia()
        {
            if (_instance == null)
            {
                _instance = new Sistema();
            }
            return _instance;
        }
        List<Usuario> _usuarios = new List<Usuario>();
        List<Actividad> _actividades = new List<Actividad>();
        List<Proveedor> _proveedores = new List<Proveedor>();

        public List<Usuario> GetUsuarios() {
            return _usuarios;
        }
        public List<Actividad> GetActividades() { return _actividades; }
        public List<Proveedor> GetProveedor() { return _proveedores; }

        public void AltaUsuario(Usuario usu)
        {
            try
            {
                //TODO
            }
            catch (Exception)
            {

                throw;
            }
        }
        public void AltaActividad(Actividad act)
        {
            try
            {
                //TODO
            }
            catch (Exception)
            {

                throw;
            }
        }
        public void AltaProveedor(Proveedor prov)
        {
            try
            {
                prov.EsValido();
                _proveedores.Add(prov);
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
