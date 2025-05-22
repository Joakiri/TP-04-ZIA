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
        string ppalabra = "";
        if(!Partida.intentosLetra.Contains(letra)){
        ppalabra = Partida.actualizarIntentoLetra(letra);
        ViewBag.intentos = Partida.intentos;
        ViewBag.intentosLetra = Partida.intentosLetra;
        ViewBag.palabraAMostrar = ppalabra;
        }
        if(ppalabra == Partida.palabra){
            return View("Ganaste");
        }
        else{
            return View("juego");
        }
        
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
