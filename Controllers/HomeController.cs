using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Boletim_Aluno_Uninove.Models;

namespace Boletim_Aluno_Uninove.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }
public IActionResult Boletim()
{
    ViewBag.Disciplinas = new List<string>
    {
        "Matemática",
        "Português",
        "História",
        "Geografia",
        "Ciências"
    };

    ViewBag.Notas = new List<double>
    {
        9.5,
        7.0,
        6.0,
        4.5,
        8.0
    };

    return View();
}
    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
