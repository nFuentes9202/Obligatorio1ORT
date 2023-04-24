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
        private static Sistema _instance = null;
        private Sistema()
        {
        }


        #region Precarga
        pivate void Precarga() { }

              

        Proveedor pro1 = new Proveedor("DreamWorks S.R.L.","23048549","Suarez 3380 Apto 304", 10);
        Proveedor pro2 = new Proveedor("Estela Umpierrez S.A.","33459678","Lima 2456", 7);
        Proveedor pro3 = new Proveedor("TravelFun","29152020","Misiones 1140", 9);
        Proveedor pro4 = new Proveedor("Rekreation S.A.","29162019","Bacacay 1211", 11);
        Proveedor pro5 = new Proveedor("Alonso & Umpierrez","24051920","18 de Julio 1956 Apto 4", 10);
        Proveedor pro6 = new Proveedor("Electric Blue","26018945","Cooper 678", 5);
        Proveedor pro7 = new Proveedor("Lúdica S.A.","26142967","Dublin 560", 4);
        Proveedor pro8 = new Proveedor("Gimenez S.R.L.","29001010","Andes 1190", 7);
        Proveedor pro9 = new Proveedor("","22041120","Agraciada 2512 Apto. 1", 8);
        Proveedor pro10 = new Proveedor("Norberto Molina","22001189","Paraguay 2100", 9);
        AltaProveedor(pro1);


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
        Actividad ac11 = new ActividadTercerizada("Avatar 2","Cine al aire libre", FechasRandom(), 50, 1, 10, 50, false,,"DreamWorks S.R.L.");
        Actividad ac12 = new ActividadTercerizada("Super Mario Bros", "Cine al aire libre", FechasRandom(), 50, 1, 10, 50, false,, "DreamWorks S.R.L.");
        Actividad ac13 = new ActividadTercerizada("Dick Tracy", "Cine al aire libre", FechasRandom(), 50, 1, 10, 50, false,, "DreamWorks S.R.L.");
        Actividad ac14 = new ActividadTercerizada("Salto Bungee", "Salto desde el puente del Rio Negro","24-06-2023", 15, 21, 30, 5, true,"23-04-2022", "Rekreation S.A.");
        Actividad ac15 = new ActividadTercerizada("Salto Bungee", "Salto desde el puente del Rio Negro", "21-10-2023", 15, 21, 30, 15, false,, "Rekreation S.A.");
        Actividad ac16 = new ActividadTercerizada("Salto Bungee", "Salto desde el puente del Rio Negro", "24-02-2024", 15, 21, 30, 15, false,, "Rekreation S.A.");
        Actividad ac17 = new ActividadTercerizada("NTVG", "Concierto", "07-05-2022", 100, 1, 10, 65, true,"02-03-2022","TravelFun");
        Actividad ac18 = new ActividadTercerizada("Once Tiros", "Concierto", FechasRandom(), 100, 1, 10, 50, false,,"TravelFun");
        Actividad ac19 = new ActividadTercerizada("Sordromo", "Concierto", FechasRandom(), 100, 1, 10, 50, false,, "TravelFun");
        Actividad ac20 = new ActividadTercerizada("Pica-Pica", "Show musical infantil", FechasRandom(), 50, 1, 10, 50, false,, "Electric Blue");
        Actividad ac21 = new ActividadTercerizada("Mago Daniel K", "Show de magia para ninios", FechasRandom(), 50, 1, 10, 50, false,, "Electric Blue");
        Actividad ac22 = new ActividadTercerizada("Los Rokilis", "Show musical infantil", "28-05-2023", 50, 1, 10, 50, true,"15-02-2022", "Electric Blue");
        Actividad ac23 = new ActividadTercerizada("“ensayo y error. el complejo de dios” - tim harford", "Charlas Motivadoras", FechasRandom(),35, 18, 0, 35, false,, "Norberto Molina");
        Actividad ac24 = new ActividadTercerizada("“de dónde proceden las buenas ideas” - steven johnson", "Charlas Motivadoras", FechasRandom(), 35, 18, 0, 35, false,, "Norberto Molina");
        Actividad ac25 = new ActividadTercerizada("“¿cómo enseñar? a través de los errores” - diana laufenberg", "Charlas Motivadoras", FechasRandom(), 35, 18, 0, 35, false,, "Norberto Molina");

        #endregion

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
        public void AltaProveedor(Proveedor x)
        {
            try
            {
                x.EsValido();
                _proveedores.Add(x);
            }
            catch (Exception e)
            {

                throw e;
            }
        }

       

    }
}
