using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dream11Model.Model
{
    public class User
    {
        public int UserId { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Username { get; set; }
        public string Emailaddress { get; set; }
        public int? age { get; set; }
        public virtual List<UserContest> UserContests { get; set; }
        public int Level { get; set; }
    }
}
