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

    public IActionResult Creditos()
    {
        return View("Creditos");
    }

    public IActionResult Comenzar()
    {
        return View("Habitacion1");
    }

    public IActionResult Habitacion(int sala, string clave)
    {
        if(sala == Escape.GetEstadoJuego())
        {
         if(!Escape.ResolverSala(sala, clave)) ViewBag.Error = "Resultado incorrecto";
         if(Escape.GetEstadoJuego() ==4)return View("Victoria");
        }   
        return View("Habitacion" + Escape.GetEstadoJuego());
    }

}
