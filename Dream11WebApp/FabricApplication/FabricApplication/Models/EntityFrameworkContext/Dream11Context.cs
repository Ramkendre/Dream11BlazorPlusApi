using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using FabricApplication.Models.BAL;

namespace FabricApplication.Models.EntityFrameworkContext
{
    public class Dream11Context : DbContext
    {
        public Dream11Context() : base(System.Configuration.ConfigurationManager.ConnectionStrings["Dream11ConnectionString"].ConnectionString)
        {

        }
        public DbSet<Contest> Contests { get; set; }
        public DbSet<Match> Matches { get; set; }
        public DbSet<Player> Players { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<UserTeam> UserTeams { get; set; }


    }
}