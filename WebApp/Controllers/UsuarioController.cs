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
            if (FechaBuscada == DateTime.MinValue)
            {
                return View("Agenda", s.GetAgendasDelDia());
            }
            List<Agenda> buscadas = new List<Agenda>();
            buscadas = s.getAgendasSegunFecha(FechaBuscada);
            return View("Agenda", buscadas);

        }
        [HttpPost]
        public IActionResult BuscarAgendasPorDocumento(string ?tipoDocumento, string? nroDocumento)
        {
            if (tipoDocumento == null || tipoDocumento.Equals("-1") )
            {
                return View("Agenda",s.GetAgendas());
            }

            return View("Agenda", s.GetAgendasPorDocumento(tipoDocumento, nroDocumento));
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
                return View(s.GetAgendas());
            }
            else
            {
               return View(s.GetAgendas(idUsuario));
            }
        }
        public IActionResult ConfirmarAgenda(int id)
        {
            s.ConfirmarAgenda(id);
            return View("Agenda",s.GetAgendas());

        }

    }
}
