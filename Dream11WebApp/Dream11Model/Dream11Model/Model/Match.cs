using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dream11Model.Model
{
    public class Match
    {
        public int MatchId { get; set; }
        public string Name { get; set; }
        public string SeriesName { get; set; }
        public string Sport { get; set; }
        public string TImeSlot { get; set; }
        public virtual List<Team> Teams { get; set; }
    }

}
