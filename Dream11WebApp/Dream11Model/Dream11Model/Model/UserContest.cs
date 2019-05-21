using System;
using System.Collections.Generic;
using System.Text;

namespace Dream11Model.Model
{
    public class UserContest
    {
        public int UserId { get; set; }
        public int ContestId { get; set; }

        public User User { get; set; }
        public Contest Contest { get; set; }
    }
}
