using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Entities
{
    [Table("teams")]
    public class TeamEntity
    {
        public int Id { get; set; }

        public byte League_Position { get; set; }

        [Required]
        public string Name { get; set; }
        
        public byte Matches_Played { get; set; }

        public sbyte Points { get; set; }

        public sbyte Goal_Diff { get; set; }

        public byte Wins { get; set; }

        public byte Draws { get; set; }

        public byte Losts { get; set; }


        public ISet<MatchEntity> Matches { get; set; }
    }
}
