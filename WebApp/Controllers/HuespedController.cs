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
        
    }
}
