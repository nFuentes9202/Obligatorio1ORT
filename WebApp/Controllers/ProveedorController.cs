using Microsoft.AspNetCore.Mvc;
using Obligatorio1;

namespace WebApp.Controllers
{
    public class ProveedorController : Controller
    {   
        Sistema s = Sistema.GetInstancia();
        
        public IActionResult Index()
        {
            string? tipoUsuario = HttpContext.Session.GetString("LogueadoTipo");
            if(tipoUsuario == "Operador")
            {
                return View(s.GetProveedoresAlfabeticamente());
            }
            else
            {
                return RedirectToAction("Index", "Home");
            }
            
        }
        [HttpPost]
        public IActionResult EstablecerDescuento(int id,double descuento)
        {
            Proveedor buscado = new Proveedor();
            buscado = s.GetProveedorPorId(id);
            if (buscado != null)
            {
                try
                {
                    s.EstablecerDescuento(id, descuento);
                    ViewBag.mensajeDescuento = "Descuento aplicado satisfactoriamente";
                }
                catch (Exception e)
                {

                    ViewBag.mensajeDescuento = e.Message;
                }
                
                
            }
            return View("Index",s.GetProveedoresAlfabeticamente());
        }
    }
}
