using App.Services;
using Data;
using Microsoft.AspNetCore.Mvc;

namespace App.Controllers
{
    public class LeaguesController : Controller
    {
        private readonly ITeamService _service;

        public LeaguesController(ITeamService service)
        {
            this._service = service;
        }
        [HttpGet]
        public IActionResult Table()
        {
            return View(_service.GetTeams());
        }
    }
}
