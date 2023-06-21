using Microsoft.AspNetCore.Mvc;
using Obligatorio1;

namespace WebApp.Controllers
{
    public class UsuarioController : Controller
    {
        Sistema s = Sistema.GetInstancia();
        public IActionResult RegistroHuesped()
        {
            string? tipoUsuario = HttpContext.Session.GetString("LogueadoTipo");

            if (tipoUsuario == null)
            {
                return View();
            }
            else
            {
                return RedirectToAction("Index", "Home");
            }

        }
        [HttpPost]
        public IActionResult RegistroHuesped(Huesped huesped)
        {
            
            try
            {
                
                s.AltaUsuario(huesped);
                ViewBag.msgRegistro = "Se creo exitosamente su usuario";

            }
            catch (Exception e)
            {

                ViewBag.msgRegistro = e.Message;
            }
            return View();
        }


        public IActionResult Details()
        {
            string? tipoUsuario = HttpContext.Session.GetString("LogueadoTipo");
            int? idUsuario = HttpContext.Session.GetInt32("LogueadoId");

            if(tipoUsuario == null)
            {
                return RedirectToAction("Index", "Home");
            }
            else{
                return View(s.GetUsuarioPorId(idUsuario));
            }
            
            
        }
        [HttpPost]
        public IActionResult BuscarAgendaPorFecha(DateTime FechaBuscada)
        {
            List<Agenda> agendasOrdenadas = new List<Agenda>();
            if (FechaBuscada == DateTime.MinValue)
            {
                agendasOrdenadas = s.GetAgendasDelDia();
                agendasOrdenadas.Sort();
                return View("Agenda", agendasOrdenadas);
            }
            List<Agenda> buscadas = new List<Agenda>();
            buscadas = s.getAgendasSegunFecha(FechaBuscada);
            if(buscadas.Count == 0)
            {
                ViewBag.MensajeBusquedaFecha = "No se encontraron resultados";
            }
            return View("Agenda", buscadas);

        }
        [HttpPost]
        public IActionResult BuscarAgendasPorDocumento(string ?tipoDocumento, string? nroDocumento)
        {
            List<Agenda> agendasOrdenadas = new List<Agenda>();
            if (tipoDocumento == null || tipoDocumento.Equals("-1") )
            {
                agendasOrdenadas = s.GetAgendas();
                ViewBag.MensajeBusquedaDocumento = "Ingrese valores válidos";
                agendasOrdenadas.Sort();
                return View("Agenda",agendasOrdenadas);
            }
            agendasOrdenadas = s.GetAgendasPorDocumento(tipoDocumento, nroDocumento);
            if (agendasOrdenadas.Count == 0)
            {
                ViewBag.MensajeBusquedaDocumento = "No se encontraron resultados";
            }
            agendasOrdenadas.Sort();
            return View("Agenda", agendasOrdenadas);
        }
        public IActionResult Agenda()
        {
            string? tipoUsuario = HttpContext.Session.GetString("LogueadoTipo");
            int? idUsuario = HttpContext.Session.GetInt32("LogueadoId");
            if(tipoUsuario == null)
            {
               return RedirectToAction("Index", "Home");
            }
            if (tipoUsuario.Equals("Operador"))
            {
                List<Agenda> agendasOrdenadas = s.GetAgendas();
                agendasOrdenadas.Sort();
                return View(agendasOrdenadas);
            }
            else
            {
                List<Agenda> agendasOrdenadas = s.GetAgendas(idUsuario);
                agendasOrdenadas.Sort();
                if(agendasOrdenadas.Count == 0)
                {
                    ViewBag.MensajeBusqueda = "No tiene agendas";
                }
                return View(agendasOrdenadas);
            }
        }
        public IActionResult ConfirmarAgenda(int id)
        {
            s.ConfirmarAgenda(id);
            return View("Agenda",s.GetAgendas());

        }

    }
}
