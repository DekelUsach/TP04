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
        ViewBag.Dic = ORTWorld.Paquetes;
        return View();
    }
    public IActionResult SelectPaquete()
    {
        ViewBag.ListaHoteles = ORTWorld.ListaHoteles;
        ViewBag.ListaAviones = ORTWorld.ListaAereos;
        ViewBag.ListaExcursiones = ORTWorld.ListaExcursiones;
        ViewBag.ListaDestinos = ORTWorld.ListaDestinos;
        return View();
    }
    public IActionResult GuardarPaquete (int Destino, int Hotel, int Aereo, int Excursion)
    {
        

        if(Destino >= 1 && Destino<= 10 && Excursion >= 1 && Excursion<= 10 && Hotel >= 1 && Hotel<= 10 && Aereo >= 1 && Aereo<= 10){
            Paquete nuevoPaquete = new Paquete("Hotel "+Hotel.ToString()+".webp","Excu " + Excursion.ToString()+ ".webp", "Avion "+ Aereo.ToString()+ ".webp");
            ORTWorld.IngresarPaquete(Destino.ToString(), nuevoPaquete);
             return RedirectToAction( "Index" );
        }
        else
        {
            ViewBag.MensajeError = "Error, debe ingresar un numero valido";
             ViewBag.ListaHoteles = ORTWorld.ListaHoteles;
            ViewBag.ListaAviones = ORTWorld.ListaAereos;
            ViewBag.ListaExcursiones = ORTWorld.ListaExcursiones;
            ViewBag.ListaDestinos = ORTWorld.ListaDestinos;

            return View("SelectPaquete");
        }
        
   
    }
}
