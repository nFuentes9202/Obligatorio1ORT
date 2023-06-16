using Microsoft.AspNetCore.Mvc;
using Obligatorio1;
using System.Diagnostics;
using WebApp.Models;


namespace WebApp.Controllers
{
    public class HomeController : Controller
    {
        Sistema s = Sistema.GetInstancia();


        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View(s.GetActividades());
        }

        public IActionResult Login()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}