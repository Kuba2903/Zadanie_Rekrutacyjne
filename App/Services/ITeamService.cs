using App.Models;

namespace App.Services
{
    public interface ITeamService
    {
        List<TeamModel> GetTeams();

        List<MatchModel> GetMatches();
    }
}
