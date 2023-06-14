using Microsoft.AspNetCore.Mvc;
using Obligatorio1;

namespace WebApp.Controllers
{
    public class AutorizacionController : Controller
    {
        Sistema s = Sistema.GetInstancia();
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Login(string email, string password)
        {
            try
            {
                Usuario logueado = s.Login(email,password);
                if(logueado != null)
                {
                    HttpContext.Session.SetInt32("LogueadoId", logueado.Id);
                    HttpContext.Session.SetString("LogueadoTipo", logueado.GetType().Name);
                    return RedirectToAction("Index", "Home");
                } else
                {
                    ViewBag.MensajeLogin = "Datos incorrectos";
                }
                
                
            }
            catch (Exception)
            {

                throw;
            }
            return View();
        }
        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Index", "Home");
        }
    }
}
