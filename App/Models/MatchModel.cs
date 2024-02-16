using Data.Entities;
using Microsoft.AspNetCore.Mvc;

namespace App.Models
{
    public class MatchModel
    {
        [HiddenInput]
        public int Id { get; set; }

        public DateTime Date { get; set; }

        public int HomeTeamId { get; set; }
        public int AwayTeamId { get; set; }

        public int HomeTeamScore { get; set; }

        public int AwayTeamScore { get; set; }
    }
}
