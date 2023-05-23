using Microsoft.AspNetCore.Mvc;

namespace TP5.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Tutorial()
    {
        return View("Tutorial");
    }

    public IActionResult Comenzar()
    {
        return View("Habitacion1");
    }

    public IActionResult Habitacion(int sala, string clave)
    {
        if(sala == Escape.GetEstadoJuego())
        {
         if(!Escape.ResolverSala(sala, clave)) ViewBag.Error = "Resultado mal" ;
        }   
        return View("Habitacion" + Escape.GetEstadoJuego());
    }

}
