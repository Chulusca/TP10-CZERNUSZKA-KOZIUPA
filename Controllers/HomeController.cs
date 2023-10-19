using System.Diagnostics;
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
    public List<string> MostrarInfoAjax(int IdSerie){
        List<Actores> listaactores = BD.ObtenerActores(IdSerie);
        List<Temporadas> listatemporadas = BD.ObtenerTemporadas(IdSerie);
        List<string> info = new List<string>();
        info.Add("la cantidad de actores de la serie es de "+(listaactores.Count) +" y la cantidad de temporadas es de "+(listatemporadas.Count));
        return info;
    }
    public List<Temporadas> MostrarTemporadasAjax(int IdSerie){
        return BD.ObtenerTemporadas(IdSerie);
    }
    public List<Actores> MostrarActoresAjax(int IdSerie){
        return BD.ObtenerActores(IdSerie);
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
