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
        public IActionResult Registro(Huesped huesped)
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
            return View(s.GetHuesped());
        }


    }
}
