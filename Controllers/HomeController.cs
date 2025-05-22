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
        return View();
    }
    public IActionResult iniciarPartida(){

        Partida.inicializarPartida();
        ViewBag.palabra = Partida.palabra;
        ViewBag.intentosLetra = Partida.intentosLetra;
        ViewBag.intentos = Partida.intentos;
        ViewBag.palabraAMostrar = "--------";
        return View("juego");
    }
    [HttpPost]
    public IActionResult actualizacionChar (char letra){
        string ppalabra = establecerPalabra(letra);
        if(ppalabra == Partida.palabra){return View("Ganaste");}
        ViewBag.intentos = Partida.intentos;
        ViewBag.intentosLetra = Partida.intentosLetra;
        ViewBag.palabraAMostrar = ppalabra;
        return View("juego");
    }
    public string establecerPalabra(char letra){
        string ppalabra = "";
        ppalabra = Partida.actualizarIntentoLetra(letra);
        return ppalabra;
    }
    [HttpPost]
    public IActionResult actualizacionPalabra (string palabra){
        bool acertaste = Partida.arriesgoPalabra(palabra);
        if(acertaste){
            return View("Ganaste");
        }
        else{
            return View("Perdiste");
        }
    }
}
