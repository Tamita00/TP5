using Microsoft.AspNetCore.Mvc;

namespace TP5.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        return View("Index");
    }

    public IActionResult Tutorial()
    {
        return View("Tutorial");
    }

    public IActionResult Comenzar()
    {
        return View("Tutorial");
    }
}
