using Microsoft.AspNetCore.Mvc;
using Obligatorio1;

namespace WebApp.Controllers
{
    public class ActividadController : Controller
    {
        Sistema s = Sistema.GetInstancia();

        public IActionResult Index()
        {
            return View(s.GetActividades());
        }
    }
}
