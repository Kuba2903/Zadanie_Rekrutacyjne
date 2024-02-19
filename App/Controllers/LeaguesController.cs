using App.Services;
using Data;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

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
            // Pobierz identyfikator zalogowanego użytkownika
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);

            // Pobierz wszystkie drużyny
            var teams = _service.GetTeams();

            // Pobierz ulubione drużyny użytkownika
            var favoriteTeams = _service.GetFavoriteTeams(userId);

            // Ustaw właściwość IsFavourite na true dla drużyn, które są ulubionymi użytkownika
            foreach (var team in teams)
            {
                team.IsFavourite = favoriteTeams.Any(ft => ft.TeamId == team.Id);
            }

            return View(teams);
        }


        [HttpGet]

        public IActionResult Games(int Id)
        {
            var matches = _service.GetMatchesByTeamId(Id);
            return View(matches);
        }

        [Authorize]
        [HttpGet]
        public IActionResult AddFavourite(int Id)
        {
            // Pobierz identyfikator zalogowanego użytkownika
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);

            // Dodaj drużynę do ulubionych dla danego użytkownika
            _service.AddFavoriteTeam(userId, Id);

            // Przekieruj użytkownika na stronę, na której był przed dodaniem do ulubionych
            return RedirectToAction("Table");
        }


        [Authorize]
        [HttpGet]

        public IActionResult RemoveFavorite(int Id)
        {
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);

            _service.RemoveFavorite(userId, Id);

            return RedirectToAction("Table");
        }
    }
}
