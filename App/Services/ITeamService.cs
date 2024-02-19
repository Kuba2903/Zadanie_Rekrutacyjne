using App.Models;
using Data.Entities;

namespace App.Services
{
    public interface ITeamService
    {
        List<TeamModel> GetTeams();

        List<MatchModel> GetMatches();

        List<MatchModel> GetMatchesByTeamId(int teamId);

        void AddFavoriteTeam(string userId, int Id);

        void RemoveFavorite(string userId, int teamId);

        List<FavouriteTeamEntity> GetFavoriteTeams(string userId);

        List<LeagueModel> GetLeague();
    }
}
