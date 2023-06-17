using Microsoft.AspNetCore.Mvc;
using Obligatorio1;

namespace WebApp.Controllers
{
    public class AgendaController : Controller
    {
        Sistema s = Sistema.GetInstancia();
        public IActionResult Index()
        {
            return View();
        }
    }
}
