using App.Models;
using Data;
using Data.Entities;

namespace App.Services
{
    public class EFTeamService : ITeamService
    {
        private AppDbContext _dbContext;

        public EFTeamService(AppDbContext context)
        {
            _dbContext = context;
        }
        public List<TeamModel> GetTeams() => _dbContext.Teams.Select(t => Mapper.EntityToModel(t)).ToList();

        public List<MatchModel> GetMatches() => _dbContext.Matches.Select(m => Mapper.EntityToModel(m)).ToList();

        public List<MatchModel> GetMatchesByTeamId(int Id)
        {
            return _dbContext.Matches
                              .Where(m => m.HomeTeamId == Id || m.AwayTeamId == Id)
                              .Select(m => Mapper.EntityToModel(m))
                              .ToList();
        }

        public void AddFavoriteTeam(string userId, int Id)
        {
            // Sprawdź, czy drużyna nie jest już ulubioną drużyną użytkownika
            var existingFavorite = _dbContext.Favourites
                                             .FirstOrDefault(ft => ft.UserId == userId && ft.TeamId == Id);

            // Jeśli drużyna nie jest jeszcze ulubioną, dodaj ją
            if (existingFavorite == null)
            {
                var favoriteTeam = new FavouriteTeamEntity
                {
                    UserId = userId,
                    TeamId = Id
                };

                _dbContext.Favourites.Add(favoriteTeam);
                _dbContext.SaveChanges();
            }
        }

        public void RemoveFavorite(string userId, int teamId)
        {
            // Sprawdź czy istnieje wpis o ulubionej drużynie dla danego użytkownika i drużyny
            var favoriteTeam = _dbContext.Favourites.FirstOrDefault(ft => ft.UserId == userId && ft.TeamId == teamId);

            // Jeśli istnieje taki wpis, usuń go z bazy danych
            if (favoriteTeam != null)
            {
                _dbContext.Favourites.Remove(favoriteTeam);
                _dbContext.SaveChanges();
            }
        }

        public List<FavouriteTeamEntity> GetFavoriteTeams(string userId) => _dbContext.Favourites.Where(ft => ft.UserId == userId).ToList();

        public List<LeagueModel> GetLeague() => _dbContext.Leagues.Select(m => Mapper.EntityToModel(m)).ToList();
    }
}
