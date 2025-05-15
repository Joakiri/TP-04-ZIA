using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using TP_04_ZIA.Models;

namespace TP_04_ZIA.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        Partida.inicializarPartida();
        ViewBag.palabra = Partida.palabra;
        return View();
    }
    public IActionResult actualizacionChar (char letraaa){
        Partida.actualizarIntento(letraaa);
        ViewBag.intentos = Partida.intentos;
        ViewBag.intentosLetra = Partida.intentosLetra;
        return View();
    }
    public IActionResult actualizacionPalabra (string intentoPalabra){
        bool acertaste = Partida.arriesgoPalabra(intentoPalabra);
        if(acertaste){
            return View("Ganaste");
        }
        else{
            return View("Perdiste");
        }
    }
}
