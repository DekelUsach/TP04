using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using TP04.Models;

namespace TP04.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

     public IActionResult Index()
    {
        /*Paquete manolo = new Paquete();
        ORTWorld jfeoifje = new ORTWorld();
        jfeoifje.IngresarPaquete("destino",manolo);
        ViewBag.uoewieu = jfeoifje.Paquetes();*/
        return View();
    }
    public IActionResult SelectPaquete()
    {
        
        return View();
    }
    public IActionResult GuardarPaquete (int Destino, int Hotel, int Aereo, int Excursion)
    {
        if(Destino >= 1 && Destino<= 10 && Excursion >= 1 && Excursion<= 10 && Hotel >= 1 && Hotel<= 10 && Aereo >= 1 && Aereo<= 10){
            ViewBag.MensajeError = "Error, debe ingresar un numero valido";
        }
        Paquete nuevoPaquete = new Paquete(Hotel.ToString(), Excursion.ToString(), Aereo.ToString());
        ORTWorld.IngresarPaquete(Destino.ToString(), nuevoPaquete);
        ViewBag.Dic = ORTWorld.Paquetes;
        return  View();
    }
}
