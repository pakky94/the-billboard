using Microsoft.AspNetCore.Mvc;

namespace TheBillboard.Controllers;

public class MessagesController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
}