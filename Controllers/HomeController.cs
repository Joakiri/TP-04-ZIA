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
    public IActionResult actualizacion (){
        Partida.actualizarIntento();
        ViewBag.intentos = Partida.intentos;
        ViewBag.intentosLetra = Partida.intentosLetra;
        return View();
    }
}
