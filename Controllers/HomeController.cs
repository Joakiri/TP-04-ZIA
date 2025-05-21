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
        return View("juego");
    }
    public IActionResult actualizacionChar (char letraaa){
        if(!Partida.intentosLetra.Contains(letraaa)){
        string ppalabra = Partida.actualizarIntentoLetra(letraaa);
        ViewBag.intentos = Partida.intentos;
        ViewBag.intentosLetra = Partida.intentosLetra;
        ViewBag.palabraAMostrar = ppalabra;
        }
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
