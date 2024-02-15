using Microsoft.AspNetCore.Mvc;

namespace App.Controllers
{
    public class LeaguesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
