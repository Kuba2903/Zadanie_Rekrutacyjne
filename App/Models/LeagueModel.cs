using Microsoft.AspNetCore.Mvc;

namespace App.Models
{
    public class LeagueModel
    {
        [HiddenInput]
        public int Id { get; set; }

        public string Country { get; set; }
        public string Name { get; set; }
    }
}
