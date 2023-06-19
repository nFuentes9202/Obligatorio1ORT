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
                return View(s.GetAgendasDelDia());
            }
            else
            {
               return View(s.GetAgendas(idUsuario));
            }
        }
        public IActionResult ConfirmarAgenda(int id)
        {
            s.ConfirmarAgenda(id);
            return View("Agenda",s.GetAgendasDelDia());

        }

    }
}
