﻿using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using TP10_CZERNUSZKA_KOZIUPA.Models;

namespace TP10_CZERNUSZKA_KOZIUPA.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        ViewBag.Series = BD.ObtenerSeries();
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }
    public Series MostrarSerieAjax(int IdSerie){
        return //FALTA LA FUNCION
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
