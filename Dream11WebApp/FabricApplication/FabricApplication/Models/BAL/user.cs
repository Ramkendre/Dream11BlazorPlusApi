using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FabricApplication.Models.BAL
{
    public class User
    {
        public int Id { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Username { get; set; }

        public string Emailaddress { get; set; }

        public int? age { get; set; }

        public List<Contest> Contests { get; set; }
        public int Level { get; set; }
    }
}



