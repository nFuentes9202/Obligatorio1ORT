using Microsoft.AspNetCore.Mvc;

namespace WebApp.Controllers
{
    public class AgendaController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
