using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Entities
{
    [Table("matches")]
    public class MatchEntity
    {
        public int Id { get; set; }

        public DateTime Date { get; set; }

        public TeamEntity HomeTeam { get; set; }

        public TeamEntity AwayTeam { get; set; }

        public int HomeTeamScore { get; set; }

        public int AwayTeamScore { get; set; }

    }
}
