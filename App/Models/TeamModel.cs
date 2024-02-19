using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace App.Models
{
    public class TeamModel
    {
        [HiddenInput]
        public int Id { get; set; }

        [Display(Name = "Pos")]
        public byte League_Position { get; set; }

        [Required]
        [Display(Name = "Team")]
        public string Name { get; set; }

        [Display(Name = "Pld")]
        public byte Matches_Played { get; set; }

        [Display(Name = "Pts")]
        public sbyte Points { get; set; }

        [Display(Name = "GD")]
        public sbyte Goal_Diff { get; set; }

        [Display(Name = "W")]
        public byte Wins { get; set; }

        [Display(Name = "D")]
        public byte Draws { get; set; }

        [Display(Name = "L")]
        public byte Losts { get; set; }

        public bool IsFavourite { get; set; }
    }
}
