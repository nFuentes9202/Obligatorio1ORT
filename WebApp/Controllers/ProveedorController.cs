using Microsoft.AspNetCore.Mvc;
using Obligatorio1;

namespace WebApp.Controllers
{
    public class ProveedorController : Controller
    {   
        Sistema s = Sistema.GetInstancia();
        
        public IActionResult Index()
        {
            return View(s.GetProveedoresAlfabeticamente());
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
