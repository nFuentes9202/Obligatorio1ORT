﻿using Microsoft.AspNetCore.Mvc;
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
            if (TempData["mensajeAgendado"] != null)
            {
                ViewBag.Agendado = TempData["mensajeAgendado"].ToString();


            }
            
            return View(s.GetActividadesDelDia());
        }
        [HttpPost]
        public IActionResult BuscarActividadPorFecha(DateTime FechaBuscada)
        {
            List<Actividad> actividadesOrdenadas = new List<Actividad>();
            if(FechaBuscada ==  DateTime.MinValue)
            {
                actividadesOrdenadas = s.GetActividades();
                actividadesOrdenadas.Sort();
                return View("Index",actividadesOrdenadas);
            }
            List<Actividad> buscadas = new List<Actividad>();
            buscadas = s.getActividadesSegunFecha(FechaBuscada);
            if (buscadas.Count == 0)
            {
                ViewBag.MensajeBusqueda = "No se encontraron resultados";
            }
            buscadas.Sort();
            return View("Index",buscadas);

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