using System;
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

        #endregion

        #region Precarga 

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
            Proveedor pro9 = new Proveedor("", "22041120", "Agraciada 2512 Apto. 1", 8);
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


            Actividad ac1 = new ActividadHostal("Campeonato de Pool", "Juego de mesa indoor", new DateTime(2023, 03, 12), 20, 18, 15, 20, "Roberto", "Salon de Juegos", false);
            Actividad ac2 = new ActividadHostal("Campeonato de Ping Pong", "Juego de mesa indoor", new DateTime(2023, 06, 05), 26, 15, 10, 26, "Roberto", "Salon de Juegos", false);
            Actividad ac3 = new ActividadHostal("Campeonato de Tenis", "Partidos de Tenis singles", new DateTime(2023, 09, 16), 12, 18, 25, 12, "Andres", "Canchas de Tenis", true);
            Actividad ac4 = new ActividadHostal("Campeonato de Futbol5", "Partidos de futbol 5 por equipo", new DateTime(2023, 10, 15), 30, 18, 75, 30, "Andres", "Canchas de Futbol", true);
            Actividad ac5 = new ActividadHostal("Campeonato de Ajedrez", "Juego de mesa indoor", new DateTime(2023, 07, 11), 8, 5, 0, 8, "Roberto", "Salon de Juegos", false);
            Actividad ac6 = new ActividadHostal("Campeonato de Pesca", "Activdad Acuatica", new DateTime(2023, 08, 22), 50, 10, 30, 50, "Sebastian", "Lago", true);
            Actividad ac7 = new ActividadHostal("Torneo de Golf", "Competencia mixta a 9 hoyos", new DateTime(2023, 10, 18), 35, 21, 100, 35, "Andres", "Campo de Golf", true);
            Actividad ac8 = new ActividadHostal("Torneo de Poker", "Juego de mesa indoor", new DateTime(2023, 07, 16), 25, 18, 0, 25, "Roberto", "Salon de Juegos", false);
            Actividad ac9 = new ActividadHostal("Cabalgata", "Recorriendo el Lago y los Jardines", new DateTime(2023, 10, 20), 10, 15, 10, 10, "Sebastian", "Perimetro Exterior", true);
            Actividad ac10 = new ActividadHostal("Senderismo", "Descubriendo los Alrededores", new DateTime(2023, 11, 15), 24, 10, 0, 24, "Sebastian", "Cerro y Cascadas", true);
            Actividad ac11 = new ActividadTercerizada("Avatar 2", "Cine al aire libre", new DateTime(2023, 04, 15), 50, 1, 10, 50, false, new DateTime(2023, 04, 04), pro1);
            Actividad ac12 = new ActividadTercerizada("Super Mario Bros", "Cine al aire libre", new DateTime(2023, 04, 09), 50, 1, 10, 50, false, new DateTime(2023, 03, 26), pro1);
            Actividad ac13 = new ActividadTercerizada("Dick Tracy", "Cine al aire libre", new DateTime(2023, 06, 03), 50, 1, 10, 50, false, new DateTime(2023, 05, 28), pro1);
            Actividad ac14 = new ActividadTercerizada("Salto Bungee", "Salto desde el puente del Rio Negro", new DateTime(2023, 05, 29), 15, 21, 30, 5, true, new DateTime(2023, 04, 19), pro4);
            Actividad ac15 = new ActividadTercerizada("Salto Bungee", "Salto desde el puente del Rio Negro", new DateTime(2023, 06, 23), 15, 21, 30, 15, false, new DateTime(2023, 06, 12), pro4);
            Actividad ac16 = new ActividadTercerizada("Salto Bungee", "Salto desde el puente del Rio Negro", new DateTime(2023, 06, 15), 15, 21, 30, 15, false, new DateTime(2023, 05, 15), pro4);
            Actividad ac17 = new ActividadTercerizada("NTVG", "Concierto", new DateTime(2023, 09, 13), 100, 1, 10, 65, true, new DateTime(2023, 08, 29), pro3);
            Actividad ac18 = new ActividadTercerizada("Once Tiros", "Concierto", new DateTime(2023, 10, 25), 100, 1, 10, 50, false, new DateTime(2023, 07, 19), pro3);
            Actividad ac19 = new ActividadTercerizada("Sordromo", "Concierto", new DateTime(2023, 05, 18), 100, 1, 10, 50, false, new DateTime(2023, 04, 06), pro3);
            Actividad ac20 = new ActividadTercerizada("Pica-Pica", "Show musical infantil", new DateTime(2023, 06, 11), 50, 1, 10, 50, false, new DateTime(2023, 04, 09), pro6);
            Actividad ac21 = new ActividadTercerizada("Mago Daniel K", "Show de magia para ninios", new DateTime(2023, 07, 17), 50, 1, 10, 50, false, new DateTime(2023, 05, 26), pro6);
            Actividad ac22 = new ActividadTercerizada("Los Rokilis", "Show musical infantil", new DateTime(2023, 09, 13), 50, 1, 10, 50, true, new DateTime(2023, 06, 15), pro6);
            Actividad ac23 = new ActividadTercerizada("“ensayo y error. el complejo de dios” - tim harford", "Charlas Motivadoras", new DateTime(2023, 08, 21), 35, 18, 0, 35, false, new DateTime(2023, 16, 05), pro10);
            Actividad ac24 = new ActividadTercerizada("“de dónde proceden las buenas ideas” - steven johnson", "Charlas Motivadoras", new DateTime(2023, 07, 20), 35, 18, 0, 35, false, new DateTime(2023, 05, 25), pro10);
            Actividad ac25 = new ActividadTercerizada("“¿cómo enseñar? a través de los errores” - diana laufenberg", "Charlas Motivadoras", new DateTime(2023, 10, 27), 35, 18, 0, 35, false, new DateTime(2023, 08, 12), pro10);
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
            }
        #endregion

        #region Listas
        List<Usuario> _usuarios = new List<Usuario>();
        List<Actividad> _actividades = new List<Actividad>();
        List<Proveedor> _proveedores = new List<Proveedor>();

        #endregion

        #region Altas
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


        #endregion
    }
}
