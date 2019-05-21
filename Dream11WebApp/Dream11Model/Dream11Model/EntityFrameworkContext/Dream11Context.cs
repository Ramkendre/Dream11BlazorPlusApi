using Dream11Model.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dream11Model.EntityFrameworkContext
{
    public class Dream11Context : DbContext
    { 
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=IDTP376;Initial Catalog=Dream11;user id=sa;password=synerzip;multipleactiveresultsets=True;application name=Dream11");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ContestUserTeam>()
                   .HasKey(c => new { c.ContestId, c.UserTeamId });
            //modelBuilder.Entity<ContestUserTeam>()
            //    .HasOne(cut => cut.Contest)
            //    .WithMany(c => c.ContestUserTeams)
            //    .HasForeignKey(cut => cut.ContestId);
            //modelBuilder.Entity<ContestUserTeam>()
            //.HasOne(cut => cut.UserTeam)
            //.WithMany(t => t.ContestUserTeams)
            //.HasForeignKey(cut => cut.UserTeamId);

            modelBuilder.Entity<UserContest>()
                .HasKey(u => new { u.UserId, u.ContestId });
            //modelBuilder.Entity<UserContest>()
            // .HasOne(uc => uc.User)
            // .WithMany(u => u.UserContests)
            // .HasForeignKey(uc => uc.UserId);
            //modelBuilder.Entity<UserContest>()
            //.HasOne(uc => uc.Contest)
            //.WithMany(c => c.UserContests)
            //.HasForeignKey(uc => uc.ContestId);
            modelBuilder.Entity<UserTeamPlayers>()
               .HasKey(u => new { u.UserTeamId, u.PlayerId });

        }

        public DbSet<Contest> Contests { get; set; }
        public DbSet<Match> Matches { get; set; }
        public DbSet<Player> Players { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<UserTeam> UserTeams { get; set; }
        public DbSet<UserContest> UserContests { get; set; }
        public DbSet<UserTeamPlayers> UserTeamPlayers { get; set; }
       // public DbSet<MatchPlayerPerforma> MatchPlayerPerformas { get; set; }
        public DbSet<ContestUserTeam> ContestUserTeams { get; set; }
        public DbSet<Team> Teams { get; set; }

    }
}
