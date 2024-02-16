using App.Models;
using Data;

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
    }
}
