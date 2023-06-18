﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace Obligatorio1
{
    public class Sistema
    {
        #region Singleton
        //Singleton
        private static Sistema _instance = null;
        private Sistema()
        {
            Precarga();
        }
        public static Sistema GetInstancia()
        {
            if (_instance == null)
            {
                _instance = new Sistema();
            }
            return _instance;
        }

        #endregion

        #region Precarga 
        //Datos de Precarga

        private void Precarga()
        {


            Proveedor pro1 = new Proveedor("DreamWorks S.R.L.", "23048549", "Suarez 3380 Apto 304", 10);
            Proveedor pro2 = new Proveedor("Estela Umpierrez S.A.", "33459678", "Lima 2456", 7);
            Proveedor pro3 = new Proveedor("TravelFun", "29152020", "Misiones 1140", 9);
            Proveedor pro4 = new Proveedor("Rekreation S.A.", "29162019", "Bacacay 1211", 11);
            Proveedor pro5 = new Proveedor("Alonso & Umpierrez", "24051920", "18 de Julio 1956 Apto 4", 10);
            Proveedor pro6 = new Proveedor("Electric Blue", "26018945", "Cooper 678", 5);
            Proveedor pro7 = new Proveedor("Lúdica S.A.", "26142967", "Dublin 560", 4);
            Proveedor pro8 = new Proveedor("Gimenez S.R.L.", "29001010", "Andes 1190", 7);
            Proveedor pro9 = new Proveedor("toto", "22041120", "Agraciada 2512 Apto. 1", 8);
            Proveedor pro10 = new Proveedor("Norberto Molina", "22001189", "Paraguay 2100", 9);
            AltaProveedor(pro1);
            AltaProveedor(pro2);
            AltaProveedor(pro3);
            AltaProveedor(pro4);
            AltaProveedor(pro5);
            AltaProveedor(pro6);
            AltaProveedor(pro7);
            AltaProveedor(pro8);
            AltaProveedor(pro9);
            AltaProveedor(pro10);


            Actividad ac1 = new ActividadHostal("Campeonato de Pool", "Juego de mesa indoor", DateTime.Now.AddDays(65), 20, 18, 15, 20, "Roberto", "Salon de Juegos", false);
            Actividad ac2 = new ActividadHostal("Campeonato de Ping Pong", "Juego de mesa indoor", DateTime.Now.AddDays(32), 26, 15, 10, 26, "Roberto", "Salon de Juegos", false);
            Actividad ac3 = new ActividadHostal("Campeonato de Tenis", "Partidos de Tenis singles", DateTime.Now.AddDays(100), 12, 18, 25, 12, "Andres", "Canchas de Tenis", true);
            Actividad ac4 = new ActividadHostal("Campeonato de Futbol 5", "Partidos de futbol 5 por equipo", DateTime.Now.AddDays(5), 30, 18, 75, 30, "Andres", "Canchas de Futbol", true);
            Actividad ac5 = new ActividadHostal("Campeonato de Ajedrez", "Juego de mesa indoor", DateTime.Now.AddDays(54), 8, 5, 0, 8, "Roberto", "Salon de Juegos", false);
            Actividad ac6 = new ActividadHostal("Campeonato de Pesca", "Actividad Acuatica", DateTime.Now.AddDays(1), 50, 10, 30, 50, "Sebastian", "Lago", true);
            Actividad ac7 = new ActividadHostal("Torneo de Golf", "Competencia mixta a 9 hoyos", DateTime.Now.AddDays(2), 35, 21, 100, 35, "Andres", "Campo de Golf", true);
            Actividad ac8 = new ActividadHostal("Torneo de Poker", "Juego de mesa indoor", DateTime.Now.AddDays(45), 25, 18, 0, 25, "Roberto", "Salon de Juegos", false);
            Actividad ac9 = new ActividadHostal("Cabalgata", "Recorriendo el Lago y los Jardines", DateTime.Now.AddDays(23), 10, 15, 10, 10, "Sebastian", "Perimetro Exterior", true);
            Actividad ac10 = new ActividadHostal("Senderismo", "Descubriendo los Alrededores", DateTime.Now.AddDays(15), 24, 10, 0, 24, "Sebastian", "Cerro y Cascadas", true);
            Actividad ac11 = new ActividadTercerizada("Avatar 2", "Cine al aire libre", DateTime.Now.AddDays(5), 50, 1, 10, 50, false, new DateTime(2023, 04, 04), pro1);
            Actividad ac12 = new ActividadTercerizada("Super Mario Bros", "Cine al aire libre", DateTime.Now.AddDays(9), 50, 1, 10, 50, false, new DateTime(2023, 03, 26), pro1);
            Actividad ac13 = new ActividadTercerizada("Dick Tracy", "Cine al aire libre", DateTime.Now.AddDays(6), 50, 1, 10, 50, false, new DateTime(2023, 05, 28), pro1);
            Actividad ac14 = new ActividadTercerizada("Salto Bungee", "Salto desde el puente del Rio Negro", DateTime.Now.AddDays(5), 15, 21, 30, 5, true, new DateTime(2023, 04, 19), pro4);
            Actividad ac15 = new ActividadTercerizada("Salto Bungee", "Salto desde el puente del Rio Negro", DateTime.Now.AddDays(5), 15, 21, 30, 15, false, new DateTime(2023, 06, 12), pro4);
            Actividad ac16 = new ActividadTercerizada("Salto Bungee", "Salto desde el puente del Rio Negro", DateTime.Now.AddDays(5), 15, 21, 30, 15, false, new DateTime(2023, 05, 15), pro4);
            Actividad ac17 = new ActividadTercerizada("NTVG", "Concierto", DateTime.Now.AddDays(10), 100, 1, 10, 65, true, new DateTime(2023, 08, 29), pro3);
            Actividad ac18 = new ActividadTercerizada("Once Tiros", "Concierto", DateTime.Now.AddDays(11), 100, 1, 10, 50, false, new DateTime(2023, 07, 19), pro3);
            Actividad ac19 = new ActividadTercerizada("Sordromo", "Concierto", DateTime.Now.AddDays(14), 100, 1, 10, 50, false, new DateTime(2023, 04, 06), pro3);
            Actividad ac20 = new ActividadTercerizada("Pica-Pica", "Show musical infantil", DateTime.Now.AddDays(13), 50, 1, 10, 50, false, new DateTime(2023, 04, 09), pro6);
            Actividad ac21 = new ActividadTercerizada("Mago Daniel K", "Show de magia para ninios", DateTime.Now.AddDays(123), 50, 1, 10, 50, false, new DateTime(2023, 05, 26), pro6);
            Actividad ac22 = new ActividadTercerizada("Los Rokilis", "Show musical infantil", DateTime.Now.AddDays(54), 50, 1, 10, 50, true, new DateTime(2023, 06, 15), pro6);
            Actividad ac23 = new ActividadTercerizada("tim harford", "Charlas Motivadoras", DateTime.Now.AddDays(34), 35, 18, 0, 35, false, new DateTime(2023, 09, 05), pro10);
            Actividad ac24 = new ActividadTercerizada("steven johnson", "Charlas Motivadoras", DateTime.Now.AddDays(23), 35, 18, 0, 35, false, new DateTime(2023, 05, 25), pro10);
            Actividad ac25 = new ActividadTercerizada("diana laufenberg", "Charlas Motivadoras", DateTime.Now.AddDays(65), 35, 18, 0, 35, false, new DateTime(2023, 08, 12), pro10);
            AltaActividad(ac1);
            AltaActividad(ac2);
            AltaActividad(ac3);
            AltaActividad(ac4);
            AltaActividad(ac5);
            AltaActividad(ac6);
            AltaActividad(ac7);
            AltaActividad(ac8);
            AltaActividad(ac9);
            AltaActividad(ac10);
            AltaActividad(ac11);
            AltaActividad(ac12);
            AltaActividad(ac13);
            AltaActividad(ac14);
            AltaActividad(ac15);
            AltaActividad(ac16);
            AltaActividad(ac17);
            AltaActividad(ac18);
            AltaActividad(ac19);
            AltaActividad(ac20);
            AltaActividad(ac21);
            AltaActividad(ac22);
            AltaActividad(ac23);
            AltaActividad(ac24);
            AltaActividad(ac25);
            _actividades[4].Fecha = new DateTime(2023,4,12);
            _actividades[9].Fecha = new DateTime(2023, 2, 22);
            _actividades[14].Fecha = new DateTime(2023, 3, 05);
            _actividades[19].Fecha = new DateTime(2023, 5, 30);
            _actividades[24].Fecha = new DateTime(2023, 6, 12);


            Usuario u1 = new Huesped("CI", "78256463", "Roberto", "Bonilla", "325", new DateTime(1964, 10, 27), 2, "rbonilla@mimail.com", "768524121");
            AltaUsuario(u1);
            Usuario u2 = new Operador("Jorge", "Marona", new DateTime(2020, 05, 10), "jormarona@gmail.com", "Holahola123");
            Usuario u3 = new Operador("Marcelo", "Marciano", new DateTime(2015, 02, 25), "marciano@gmail.com", "TestTest265");
            AltaUsuario(u2);
            AltaUsuario(u3);

        }
        #endregion

        #region Listas
        //Listas
        private List<Usuario> _usuarios = new List<Usuario>();
        private List<Actividad> _actividades = new List<Actividad>();
        private List<Proveedor> _proveedores = new List<Proveedor>();

        #endregion

        #region Altas
        public void AltaUsuario(Usuario usu)
        {
            try
            {
                if(usu is Huesped)
                {
                   if(CedulaYaExistente(usu as Huesped))
                    {
                        throw new Exception("Cedula de identidad ya existente");
                    }
                }
                usu.EsValido();
                _usuarios.Add(usu);
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
                act.EsValido();
                _actividades.Add(act);
            }
            catch (Exception e)
            {

                throw e;
            }
        }
        public void AltaProveedor(Proveedor prov)
        {
            try
            {
                prov.EsValido();
                _proveedores.Add(prov);
            }
            catch (Exception e)
            {

                throw e;
            }
        }

        #endregion

        #region GetSet
        
        public List<Usuario> GetUsuarios()
        {
            return _usuarios;
        }
        public List<Actividad> GetActividades()
        {
            return _actividades;
        }
        public List<Proveedor> GetProveedor()
        {
            return _proveedores;
        }
        #endregion

        #region Requerimientos
        //Toma 2 fechas en formatos precisos, y un costo. Retorna las actividades que estén entre ambas fechas, mayores al costo dado.
        public List<Actividad> getActividadesSegunFechayCosto(DateTime fechaini, DateTime fechafin, double costo)
        {
            List<Actividad> ret = new List<Actividad>();

               foreach(Actividad act in _actividades)
            {
                if(act.CostoDolares > costo && act.Fecha > fechaini && act.Fecha < fechafin)
                {
                        ret.Add(act);
                }
            }
            
            ret.Sort();
            return ret;
        }




        //Busca al proveedor por id, y establece el valor que le pasemos por parametro en el objeto encontrado. Retorna booleano para saber si la operación fue exitosa.
        public bool EstablecerValorPromociondeProveedor(int idProv, double valor) {

            foreach (Proveedor pro in _proveedores)
            {
                if (pro.Id.Equals(idProv))
                {
                    pro.Descuento = ((valor * 100) - 100);
                    return true;
                }
            }
            return false;
        }

        public List<Proveedor> GetProveedoresAlfabeticamente()
        {
            _proveedores.Sort();
            return _proveedores;
        }
        //Metodo para comprobar si la combinación cedula y tipoDocumento es válida. Retorna booleano.
        private bool CedulaYaExistente(Huesped huesped)
        {
            bool ret = false;
            foreach(Huesped hues in _usuarios)
            {
                if(hues.TipoDocumento == "CI" && hues.NumeroDocumento == huesped.NumeroDocumento)
                {
                    ret = true;
                }
            }
            return ret;
        }
        // Busca un usuario existente en sistema. Si no lo encuentra retorna null
        public Usuario Login(string email, string password)
        {
            foreach(Usuario usu in _usuarios)
            {
                if(usu.Email.Equals(email) && usu.Contrasenia.Equals(password))
                {
                    return usu;
                }
            }
            return null;
        }

        //Retorna la lista huesped para las vistas
        public List<Huesped> GetHuesped()
        {
            List<Huesped> ret = new List<Huesped>();

            foreach(Usuario u in _usuarios)
            {
             if(u is Huesped)
                {
                    ret.Add(u as Huesped);
                }
            }
            return ret; 
        }

        public List<Actividad> getActividadesSegunFecha(DateTime buscada)
        {
            List<Actividad> ret = new List<Actividad>();
            foreach(Actividad act in _actividades)
            {
                if (act.Fecha.Date.Equals(buscada.Date)){
                    ret.Add(act);
                }
            }
            return ret;
        }

        public Proveedor GetProveedorPorId(int id)
        {
            Proveedor ret = new Proveedor();
            foreach(Proveedor prov in _proveedores)
            {
                if (prov.Id.Equals(id))
                {
                    return ret;
                }
            }
            return null;
        }

        public void EstablecerDescuento(int id, double descuento)
        {
            if(descuento < 0 || descuento > 100)
            {
                throw new Exception("Descuento no válido. Ingrese valores entre el 0 y el 100");
            }
            foreach(Proveedor prov in _proveedores)
            {
                if(prov.Id.Equals (id))
                {
                    prov.Descuento = descuento;
                }
            }
        }



        #endregion
    }
}
