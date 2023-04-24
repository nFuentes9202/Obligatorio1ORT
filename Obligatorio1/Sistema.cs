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

        ActividadHostal ac1 = new ActividadHostal("Campeonato de Pool", "Juego de mesa indoor", FechasRandom(), 20, 18, 15, 20, "Roberto", "Salon de Juegos", false);
        ActividadHostal ac2 = new ActividadHostal("Campeonato de Ping Pong", "Juego de mesa indoor", FechasRandom(), 26, 15, 10, 26, "Roberto", "Salon de Juegos", false);
        ActividadHostal ac3 = new ActividadHostal("Campeonato de Tenis", "Partidos de Tenis singles", FechasRandom(), 12, 18, 25, 12, "Andres", "Canchas de Tenis", true);
        ActividadHostal ac4 = new ActividadHostal("Campeonato de Futbol5", "Partidos de futbol 5 por equipo", FechasRandom(), 30, 18, 75, 30, "Andres", "Canchas de Futbol", true);
        ActividadHostal ac5 = new ActividadHostal("Campeonato de Ajedrez", "Juego de mesa indoor", FechasRandom(), 8, 5, 0, 8, "Roberto", "Salon de Juegos", false);
        ActividadHostal ac6 = new ActividadHostal("Campeonato de Pesca", "Activdad Acuatica", FechasRandom(), 50, 10, 30, 50, "Sebastian", "Lago", true);
        ActividadHostal ac7 = new ActividadHostal("Torneo de Golf", "Competencia mixta a 9 hoyos", FechasRandom(), 35, 21, 100, 35, "Andres", "Campo de Golf", true);
        ActividadHostal ac8 = new ActividadHostal("Torneo de Poker", "Juego de mesa indoor", FechasRandom(), 25, 18, 0, 25, "Roberto", "Salon de Juegos", false);
        ActividadHostal ac9 = new ActividadHostal("Cabalgata", "Recorriendo el Lago y los Jardines", FechasRandom(), 10, 15, 10, 10, "Sebastian", "Perimetro Exterior", true);
        ActividadHostal ac10 = new ActividadHostal("Senderismo", "Descubriendo los Alrededores", FechasRandom(), 24, 10, 0, 24, "Sebastian", "Cerro y Cascadas", true);

        AltaProveedor( new Proveedor("DreamWorks S.R.L.","23048549","Suarez 3380 Apto 304", 10) );
        AltaProveedor( new Proveedor("Estela Umpierrez S.A.","33459678","Lima 2456", 7) );
        AltaProveedor( new Proveedor("TravelFun","29152020","Misiones 1140", 9) );
        AltaProveedor( new Proveedor("Rekreation S.A.","29162019","Bacacay 1211", 11) );
        AltaProveedor( new Proveedor("Alonso & Umpierrez","24051920","18 de Julio 1956 Apto 4", 10) );
        AltaProveedor( new Proveedor("Electric Blue","26018945","Cooper 678", 5) );
        AltaProveedor( new Proveedor("Lúdica S.A.","26142967","Dublin 560", 4) );
        AltaProveedor( new Proveedor("Gimenez S.R.L.","29001010","Andes 1190", 7) );
        AltaProveedor( new Proveedor("","22041120","Agraciada 2512 Apto. 1", 8) );
        AltaProveedor( new Proveedor("Norberto Molina","22001189","Paraguay 2100", 9) );

        ActividadTercerizada acter1 = new ActividadTercerizada("Avatar 2","Cine al aire libre", FechasRandom(), 50, 1, 10, 50, false,,"DreamWorks S.R.L.");
        ActividadTercerizada acter2 = new ActividadTercerizada("Super Mario Bros", "Cine al aire libre", FechasRandom(), 50, 1, 10, 50, false,, "DreamWorks S.R.L.");
        ActividadTercerizada acter3 = new ActividadTercerizada("Dick Tracy", "Cine al aire libre", FechasRandom(), 50, 1, 10, 50, false,, "DreamWorks S.R.L.");
        ActividadTercerizada acter4 = new ActividadTercerizada("Salto Bungee", "Salto desde el puente del Rio Negro","24-06-2023", 15, 21, 30, 5, true,"23-04-2022", "Rekreation S.A.");
        ActividadTercerizada acter5 = new ActividadTercerizada("Salto Bungee", "Salto desde el puente del Rio Negro", "21-10-2023", 15, 21, 30, 15, false,, "Rekreation S.A.");
        ActividadTercerizada acter6 = new ActividadTercerizada("Salto Bungee", "Salto desde el puente del Rio Negro", "24-02-2024", 15, 21, 30, 15, false,, "Rekreation S.A.");
        ActividadTercerizada acter7 = new ActividadTercerizada("NTVG", "Concierto", "07-05-2022", 100, 1, 10, 65, true,"02-03-2022","TravelFun");
        ActividadTercerizada acter8 = new ActividadTercerizada("Once Tiros", "Concierto", FechasRandom(), 100, 1, 10, 50, false,,"TravelFun");
        ActividadTercerizada acter9 = new ActividadTercerizada("Sordromo", "Concierto", FechasRandom(), 100, 1, 10, 50, false,, "TravelFun");
        ActividadTercerizada acter10 = new ActividadTercerizada("Pica-Pica", "Show musical infantil", FechasRandom(), 50, 1, 10, 50, false,, "Electric Blue");
        ActividadTercerizada acter11 = new ActividadTercerizada("Mago Daniel K", "Show de magia para ninios", FechasRandom(), 50, 1, 10, 50, false,, "Electric Blue");
        ActividadTercerizada acter12 = new ActividadTercerizada("Los Rokilis", "Show musical infantil", "28-05-2023", 50, 1, 10, 50, true,"15-02-2022", "Electric Blue");
        ActividadTercerizada acter13 = new ActividadTercerizada("“ensayo y error. el complejo de dios” - tim harford", "Charlas Motivadoras", FechasRandom(),35, 18, 0, 35, false,, "Norberto Molina");
        ActividadTercerizada acter14 = new ActividadTercerizada("“de dónde proceden las buenas ideas” - steven johnson", "Charlas Motivadoras", FechasRandom(), 35, 18, 0, 35, false,, "Norberto Molina");
        ActividadTercerizada acter15 = new ActividadTercerizada("“¿cómo enseñar? a través de los errores” - diana laufenberg", "Charlas Motivadoras", FechasRandom(), 35, 18, 0, 35, false,, "Norberto Molina");


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


        public static DateTime FechasRandom()
        {
            Random random = new Random();
            DateTime startDate = DateTime.Today;
            DateTime endDate = new DateTime(2024, 1, 1);
            TimeSpan timeSpan = endDate - startDate;
            TimeSpan newSpan = new TimeSpan(0, random.Next(0, (int)timeSpan.TotalMinutes), 0);
            DateTime newDate = startDate + newSpan;
            return newDate;
        }



    }
}
