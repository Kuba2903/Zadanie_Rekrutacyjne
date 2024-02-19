using App.Models;

namespace App.Services
{
    public interface ITeamService
    {
        List<TeamModel> GetTeams();

        List<MatchModel> GetMatches();

        List<MatchModel> GetMatchesByTeamId(int teamId);

        void AddFavoriteTeam(string userId, int teamId);
    }
}
