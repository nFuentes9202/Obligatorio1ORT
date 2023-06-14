using Microsoft.AspNetCore.Mvc;
using Obligatorio1;

namespace WebApp.Controllers
{
    public class HuespedController : Controller
    {
        Sistema s = Sistema.GetInstancia();
        public IActionResult Registro()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Registro(Usuario usu)
        {
            try
            {
                s.AltaUsuario(usu);
                ViewBag.msgRegistro = "Se creo exitosamente su usuario";
            }
            catch (Exception e)
            {

                ViewBag.msgRegistro = e.Message;
            }
            return View();
        }
        
    }
}
