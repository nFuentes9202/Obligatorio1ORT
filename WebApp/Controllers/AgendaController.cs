using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Hosting;
using Obligatorio1;

namespace WebApp.Controllers
{
    public class AgendaController : Controller
    {
        Sistema s = Sistema.GetInstancia();
        public IActionResult Index()
        {
            return View(s.GetAgendas()) ;
        }

        public IActionResult Agendar(int id)
        {

            int? lid = HttpContext.Session.GetInt32("LogueadoId");
            string? tipoUsuario = HttpContext.Session.GetString("LogueadoTipo");


            if (lid == null || tipoUsuario.Equals("Operador"))
            {
                return RedirectToAction("Index", "Home");
            }

            try
            {
                s.AgendarActividad(id, lid);
                


                TempData["mensajeAgendado"] = "Agendado Correctamente.";

                
            }
            catch (Exception e)
            {

                TempData["mensajeAgendado"] = e.Message;
            }

            return RedirectToAction("Index", "Home");
        }


    }



}

