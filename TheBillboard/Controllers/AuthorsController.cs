using Microsoft.AspNetCore.Mvc;

namespace TheBillboard.Controllers
{
    public class AuthorsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
