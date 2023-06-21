using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Threading.Tasks.Dataflow;

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


            Actividad ac1 = new ActividadHostal("Campeonato de Pool", "Juego de mesa indoor", DateTime.Now.AddMinutes(10), 20, 18, 15, 2, "Roberto", "Salon de Juegos", false);
            Actividad ac2 = new ActividadHostal("Campeonato de Ping Pong", "Juego de mesa indoor", DateTime.Now.AddDays(32), 26, 15, 10, 13, "Roberto", "Salon de Juegos", false);
            Actividad ac3 = new ActividadHostal("Campeonato de Tenis", "Partidos de Tenis singles", DateTime.Now.AddDays(100), 12, 18, 25, 12, "Andres", "Canchas de Tenis", true);
            Actividad ac4 = new ActividadHostal("Campeonato de Futbol 5", "Partidos de futbol 5 por equipo", DateTime.Now.AddDays(5), 30, 18, 75, 5, "Andres", "Canchas de Futbol", true);
            Actividad ac5 = new ActividadHostal("Campeonato de Ajedrez", "Juego de mesa indoor", DateTime.Now.AddDays(54), 8, 5, 0, 0, "Roberto", "Salon de Juegos", false);
            Actividad ac6 = new ActividadHostal("Campeonato de Pesca", "Actividad Acuatica", DateTime.Now.AddMinutes(10), 50, 10, 30, 50, "Sebastian", "Lago", true);
            Actividad ac7 = new ActividadHostal("Torneo de Golf", "Competencia mixta a 9 hoyos", DateTime.Now.AddDays(2), 35, 21, 100, 35, "Andres", "Campo de Golf", true);
            Actividad ac8 = new ActividadHostal("Torneo de Poker", "Juego de mesa indoor", DateTime.Now.AddDays(45), 25, 18, 0, 25, "Roberto", "Salon de Juegos", false);
            Actividad ac9 = new ActividadHostal("Cabalgata", "Recorriendo el Lago y los Jardines", DateTime.Now.AddDays(23), 10, 15, 10, 10, "Sebastian", "Perimetro Exterior", true);
            Actividad ac10 = new ActividadHostal("Senderismo", "Descubriendo los Alrededores", DateTime.Now.AddDays(15), 24, 10, 0, 24, "Sebastian", "Cerro y Cascadas", true);
            Actividad ac11 = new ActividadTercerizada("Avatar 2", "Cine al aire libre", DateTime.Now.AddDays(5), 50, 1, 10, 50, false, new DateTime(2023, 04, 04), pro1);
            Actividad ac12 = new ActividadTercerizada("Super Mario Bros", "Cine al aire libre", DateTime.Now.AddDays(9), 50, 1, 10, 50, false, new DateTime(2023, 03, 26), pro1);
            Actividad ac13 = new ActividadTercerizada("Dick Tracy", "Cine al aire libre", DateTime.Now.AddMinutes(10), 50, 1, 10, 50, false, new DateTime(2023, 05, 28), pro1);
            Actividad ac14 = new ActividadTercerizada("Salto Bungee", "Salto desde el puente del Rio Negro", DateTime.Now.AddDays(5), 15, 21, 30, 5, true, new DateTime(2023, 04, 19), pro4);
            Actividad ac15 = new ActividadTercerizada("Salto Bungee", "Salto desde el puente del Rio Negro", DateTime.Now.AddDays(5), 15, 21, 30, 15, false, new DateTime(2023, 06, 12), pro4);
            Actividad ac16 = new ActividadTercerizada("Salto Bungee", "Salto desde el puente del Rio Negro", DateTime.Now.AddDays(5), 15, 21, 30, 15, false, new DateTime(2023, 05, 15), pro4);
            Actividad ac17 = new ActividadTercerizada("NTVG", "Concierto", DateTime.Now.AddDays(10), 100, 1, 10, 65, true, new DateTime(2023, 08, 29), pro3);
            Actividad ac18 = new ActividadTercerizada("Once Tiros", "Concierto", DateTime.Now.AddDays(11), 100, 1, 10, 50, false, new DateTime(2023, 07, 19), pro3);
            Actividad ac19 = new ActividadTercerizada("Sordromo", "Concierto", DateTime.Now.AddMinutes(10), 100, 1, 10, 50, false, new DateTime(2023, 04, 06), pro3);
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


            Usuario u1 = new Huesped("CI", "60242466", "Roberto", "Bonilla", "325", new DateTime(1964, 10, 27), 2, "rbonilla@mimail.com", "768524121");
            AltaUsuario(u1);
            Usuario u2 = new Operador("Jorge", "Marona", new DateTime(2020, 05, 10), "jormarona@gmail.com", "Holahola123");
            Usuario u3 = new Operador("Marcelo", "Marciano", new DateTime(2015, 02, 25), "marciano@gmail.com", "TestTest265");
            AltaUsuario(u2);
            AltaUsuario(u3);

            AgendarActividad(ac1.Id, u1.Id);
            AgendarActividad(ac2.Id, u1.Id);
            AgendarActividad(ac3.Id, u1.Id);
            AgendarActividad(ac4.Id, u1.Id);
            AgendarActividad(ac6.Id, u1.Id);
            AgendarActividad(ac24.Id, u1.Id);
            /*
            Agenda ag1 = new Agenda(false, u1 as Huesped, ac1);
            Agenda ag2 = new Agenda(false, u1 as Huesped, ac2);
            Agenda ag3 = new Agenda(false, u1 as Huesped, ac3);
            Agenda ag4 = new Agenda(false, u1 as Huesped, ac4);
            Agenda ag5 = new Agenda(false, u1 as Huesped, ac5);
            Agenda ag24 = new Agenda(false, u1 as Huesped, ac24);
            AltaAgenda(ag1);
            AltaAgenda(ag2);
            AltaAgenda(ag3);
            AltaAgenda(ag4);
            AltaAgenda(ag5);
            AltaAgenda(ag24);
            */
            

        }
        #endregion

        #region Listas
        //Listas
        private List<Usuario> _usuarios = new List<Usuario>();
        private List<Actividad> _actividades = new List<Actividad>();
        private List<Proveedor> _proveedores = new List<Proveedor>();
        private List<Agenda> _agendas = new List<Agenda>();

        #endregion

        #region Altas
        public void AltaUsuario(Usuario usu)
        {
            try
            {
                if(usu is Huesped hue)
                {
                    
                    if (CedulaYaExistente(hue))
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

        public void AltaAgenda(Agenda agenda)
        {
            
            _agendas.Add(agenda);
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

        public Usuario GetHuespedPorId(int? idHuesped)
        {
  
            foreach (Usuario u in _usuarios)
            {
                if (u.Id.Equals(idHuesped))
                {
                    return u;
                }
            }
            return null;
        }
        public bool CedulaYaExistente(Huesped huesped)
        {
            bool ret = false;
            foreach (Huesped hues in _usuarios.OfType<Huesped>())
            {
                if (hues.TipoDocumento == "CI" && hues.NumeroDocumento == huesped.NumeroDocumento)
                {
                    ret = true;
                    break; // Puedes agregar un break aquí si deseas detener la iteración una vez que encuentres una coincidencia
                }
            }
            return ret;
        }
        public Actividad GetActividadPorId(int idAct)
        {

            foreach (Actividad act in _actividades)
            {
                if (act.Id.Equals(idAct))
                {
                    return act;
                }
            }
            return null;
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

        //Retorna la lista de Agendas
        public List<Agenda> GetAgendas()
        {
            return _agendas;
        }

        // valida la edad y disponibilidad para saber si puede agendarse
        //TODO Refactorizar en un EsValido con excepciones
        public static bool Cumple(Actividad act, Huesped hue)
        {
            bool ret = false;

            int edad = DateTime.Now.Year - hue.FechaNacimiento.Year;

            if (edad >= act.EdadMinima && act.LugaresDisponibles > 0)
            {
                ret = true;
            }
            if(act.Fecha.Date < DateTime.Now.Date)
            {
                ret = false;
            }
            return ret;
        }


        private bool UsuarioYaAgendado(Actividad act, Huesped hues)
        {
            bool ret = false;

            foreach(Agenda age in _agendas)
            {
                if(age.Actividad.Equals(act) && age.Huesped.Equals(hues))
                {
                    ret = true;
                }
            }
            return ret;
        }

        public void AgendarActividad(int IdActividad, int? idHuesped)
        {
            Usuario hues = GetHuespedPorId(idHuesped);
            Actividad act = GetActividadPorId(IdActividad);

            if(act == null)
            {
                throw new Exception("Actividad nula");
            }
            if(UsuarioYaAgendado(act, hues as Huesped))
            {
                throw new Exception("Ya estás agendado a esta actividad");
            }
            if(!Cumple(act, hues as Huesped))
            {
                throw new Exception("No cumplís con los requisitos para agendarte");
            }
            double precio = FijarPrecioFinal(hues as Huesped, act);
            Agenda nueva = new Agenda(false, hues as Huesped, act);
            nueva.PrecioFinal = precio;
            act.LugaresDisponibles--;
            AltaAgenda(nueva);
           


        }

        public List<Actividad> GetActividadesDelDia()
        {
            List<Actividad> ret = new List<Actividad>();
            foreach(Actividad act in _actividades)
            {
                if (act.Fecha.Date.Equals(DateTime.Now.Date))
                {
                    ret.Add(act);
                }
            }
            ret.Sort();
            return ret;
        }

        public Usuario GetUsuarioPorId(int? id)
        {
            foreach (Usuario usu in _usuarios)
            {
                if (usu.Id.Equals(id))
                {
                    return usu;
                }
            }
            return null;
        }

        public List<Agenda> GetAgendasDelDia()
        {
            List<Agenda> ret = new List<Agenda>();
            foreach(Agenda ag in _agendas)
            {
                if(ag.Actividad.Fecha.Date.Equals(DateTime.Now.Date))
                {
                    ret.Add(ag);
                }
            }
            return ret;
        }

        public List<Agenda> GetAgendas(int? idUsuario)
        {
            List<Agenda> ret = new List<Agenda>();
            foreach(Agenda ag in _agendas)
            {
                if (ag.Huesped.Id.Equals(idUsuario) && ag.Actividad.Fecha >= DateTime.Now.Date)
                {
                    ret.Add(ag);
                }
            }
            return ret;
        }

        public void ConfirmarAgenda(int id)
        {
            foreach(Agenda ag in _agendas)
            {
                if (ag.Id.Equals(id))
                {
                    ag.Estado = true;
                }
            }
        }

        public List<Agenda> getAgendasSegunFecha(DateTime fechaBuscada)
        {
            List<Agenda> ret = new List<Agenda>();
            foreach (Agenda ag in _agendas)
            {
                if (ag.Actividad.Fecha.Date.Equals(fechaBuscada.Date))
                {
                    ret.Add(ag);
                }
            }
            return ret;
        }

        public List<Agenda> GetAgendasPorDocumento(string? tipoDocumento, string? nroDocumento)
        {
            List<Agenda> ret = new List<Agenda>();
            foreach(Agenda ag in _agendas)
            {
                if(ag.Huesped.TipoDocumento.Equals(tipoDocumento) && ag.Huesped.NumeroDocumento.Equals(nroDocumento))
                {
                    ret.Add(ag);
                }
            }
            return ret;
        }


        


        public double NiveldeFidelidad(double costo, int nivel)
        {
            {
                double precioFinal = 0;
                switch (nivel)
                {
                    case 1:
                        precioFinal = costo;
                        break;
                    case 2:
                        precioFinal = (costo * 0.9);
                        break;
                    case 3:
                        precioFinal = (costo * 0.85);
                        break;
                    case 4:
                        precioFinal = (costo * 0.8);
                        break;
                    default:
                        Console.WriteLine("Nivel no válido. El precio final no puede ser calculado.");
                        break;
                }
                return precioFinal;
            }
        }


        public double FijarPrecioFinal(Huesped hue, Actividad act)
        {
            double precioFinal = 0;

            if (act.GetTipo().Equals("HOSTAL"))
            {
                precioFinal = NiveldeFidelidad(act.CostoDolares, hue.NivelFidelizacion);
            }
            else if (act.GetTipo().Equals("TERCERIZADA"))
            {
                ActividadTercerizada actividadTercerizada = act as ActividadTercerizada;
                if (actividadTercerizada != null && actividadTercerizada.EstaConfirmada)
                {
                    precioFinal = act.CostoDolares * actividadTercerizada.Proveedor.Descuento;
                }
                else
                {
                    precioFinal = -1;
                }

            }

            return precioFinal;
        }

        #endregion
    }
}
