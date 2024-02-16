using Data.Entities;

namespace App.Models
{
    public static class Mapper
    {
        public static TeamEntity ModelToEntity(TeamModel model)
        {
            return new TeamEntity()
            {
                Id = model.Id,
                League_Position = model.League_Position,
                Name = model.Name,
                Matches_Played = model.Matches_Played,
                Points = model.Points,
                Goal_Diff = model.Goal_Diff,
                Wins = model.Wins,
                Draws = model.Draws,
                Losts = model.Losts
            };
        }


        public static TeamModel EntityToModel(TeamEntity entity)
        {
            return new TeamModel()
            {
                Id = entity.Id,
                League_Position = entity.League_Position,
                Name = entity.Name,
                Matches_Played = entity.Matches_Played,
                Points = entity.Points,
                Goal_Diff = entity.Goal_Diff,
                Wins = entity.Wins,
                Draws = entity.Draws,
                Losts = entity.Losts
            };
        }


        public static MatchModel EntityToModel(MatchEntity entity)
        {
            return new MatchModel()
            {
                Id = entity.Id,
                Date = entity.Date,
                HomeTeamId = entity.HomeTeamId,
                AwayTeamId = entity.AwayTeamId,
                HomeTeamScore = entity.HomeTeamScore,
                AwayTeamScore = entity.AwayTeamScore
            };
        }

        public static MatchEntity ModelToEntity(MatchModel model)
        {
            return new MatchEntity()
            {
                Id = model.Id,
                Date = model.Date,
                HomeTeamId = model.HomeTeamId,
                AwayTeamId = model.AwayTeamId,
                HomeTeamScore = model.HomeTeamScore,
                AwayTeamScore = model.AwayTeamScore
            };
        }
    }
}
