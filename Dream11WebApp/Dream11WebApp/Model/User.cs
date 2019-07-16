using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dream11WebApp.Model
{
    public class User
    {
        public int userId { get; set; }
        public string firstname { get; set; }
        public string lastname { get; set; }
        public string username { get; set; }
        public string emailaddress { get; set; }
        public int age { get; set; }
        public int level { get; set; }
        public string password { get; set; }
        public string authToken { get; set; }
        public int balance { get; set; }
    }

    public class UserTeams
    {
        public int matchId { get; set; }
        public int userTeamId { get; set; }
        public int userId { get; set; }
        public User user { get; set; }
        public List<Player2> players { get; set; }
        public string userTeamName { get; set; }
    }
}
