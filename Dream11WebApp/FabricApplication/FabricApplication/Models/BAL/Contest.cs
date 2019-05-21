using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FabricApplication.Models.BAL
{
    public class Contest
    {
        public string Id { get; set; }
        public string EntryFee { get; set; }
        public string PrizeAmount { get; set; }
        public string NoOfSpots { get; set; }
        public string NoOfSpotsLeft { get; set; }
        public string WinningPercent { get; set; }
        public Match Match { get; set; }
        List<User> Users { get; set; }
        List<UserTeam> UserTeams { get; set; }
    }
}