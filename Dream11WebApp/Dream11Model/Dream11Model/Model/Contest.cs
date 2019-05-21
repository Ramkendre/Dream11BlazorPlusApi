using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dream11Model.Model
{
    public class Contest
    {
        public int ContestId { get; set; }
        public decimal EntryFee { get; set; }
        public decimal PrizeAmount { get; set; }
        public int NoOfSpots { get; set; }
        public int NoOfSpotsLeft { get; set; }
        public decimal WinningPercent { get; set; }
        public virtual Match Match { get; set; }
        public virtual ICollection<UserContest> UserContests { get; set; }
        public virtual ICollection<ContestUserTeam> ContestUserTeams { get; set; }
    }
}
