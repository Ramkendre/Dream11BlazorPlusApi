using System;
using System.Collections.Generic;
using System.Text;

namespace Dream11Model.Model
{
    public class ContestUserTeam
    {
        public int UserTeamId { get; set; }
        public UserTeam UserTeam { get; set; }
        public int ContestId { get; set; }
        public Contest Contest{ get; set; }
    }
}
