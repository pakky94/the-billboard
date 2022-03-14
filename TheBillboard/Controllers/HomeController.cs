using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using TheBillboard.Abstract;
using TheBillboard.Gatweways;
using TheBillboard.Models;

namespace TheBillboard.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private readonly IGateway _gateway;
    
    public HomeController(IGateway gateway, ILogger<HomeController> logger)
    {
        _logger = logger;
        _gateway = gateway;
    }

    public IActionResult Index()
    {
        return View();
    }
    
    public IActionResult List()
    {
        return View("MyList", _gateway.GetStudents());
    }

    public IActionResult About()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel {RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier});
    }
}