using Dream11Model.EntityFrameworkContext;
using Dream11Model.Model;
using System;
using System.Collections.Generic;

namespace Dream11ModelTest
{
    class Program
    {
        static void Main(string[] args)
        {
            
            //User user = new User
            //{
            //    Firstname = "Tanvi",
            //    Lastname = "Kansara",
            //    Emailaddress = "tanvi.kansara@synerzip.com",
            //    age = 27,
            //    Level = 0,
            //    Username = "Tani"
            //};
            //Team team1 = new Team
            //{

            //    Logo = "https://logosvector.net/wp-content/uploads/2014/01/chennai-super-kings-vector-logo.png",
            //    Players = new List<Player>
            //            {
            //                new Player{
            //                    FirstName ="MS",
            //                    LastName ="Dhoni",
            //                    Age=37,
            //                    Address =string.Empty,
            //                    Credits =12,
            //                    Image ="http://p.imgci.com/db/PICTURES/CMS/263700/263705.20.jpg",
            //                    IsSelected =true,
            //                    PlayerRoleName ="Wicketkeeper batsman",
            //                    Points =12,
            //                    IsCaptain=true,
            //                    IsViceCaptain=false
            //                },
            //                  new Player{
            //                    FirstName ="Sam",
            //                    LastName ="Billings",
            //                    Age=27,
            //                    Address =string.Empty,
            //                    Credits =8,
            //                    Image ="http://p.imgci.com/db/PICTURES/CMS/215100/215141.icon.jpg",
            //                    IsSelected =false,
            //                    PlayerRoleName ="batsman",
            //                    Points =8,
            //                    IsCaptain=false,
            //                    IsViceCaptain=false
            //                },
            //                   new Player{
            //                    FirstName ="Dwayne",
            //                    LastName ="Bravo",
            //                    Age=35,
            //                    Address =string.Empty,
            //                    Credits =11.5M,
            //                    Image ="http://p.imgci.com/db/PICTURES/CMS/238300/238345.icon.jpg",
            //                    IsSelected =true,
            //                    PlayerRoleName ="Allrounder",
            //                    Points =11.5M,
            //                    IsCaptain=false,
            //                    IsViceCaptain=false
            //                },
            //                    new Player{
            //                    FirstName ="Faf",
            //                    LastName ="du Plessis",
            //                    Age=34,
            //                    Address =string.Empty,
            //                    Credits =9,
            //                    Image ="http://p.imgci.com/db/PICTURES/CMS/263700/263773.icon.jpg",
            //                    IsSelected =true,
            //                    PlayerRoleName ="Middle-order batsman",
            //                    Points =9,
            //                    IsCaptain=false,
            //                    IsViceCaptain=false
            //                },
            //                     new Player{
            //                    FirstName ="Harbhajan",
            //                    LastName ="Singh",
            //                    Age=38,
            //                    Address =string.Empty,
            //                    Credits =8,
            //                    Image ="http://p.imgci.com/db/PICTURES/CMS/128400/128477.icon.jpg",
            //                    IsSelected =true,
            //                    PlayerRoleName ="Bowler",
            //                    Points =8,
            //                    IsCaptain=false,
            //                    IsViceCaptain=false
            //                },
            //                      new Player{
            //                    FirstName ="Ravindra",
            //                    LastName ="Jadeja",
            //                    Age=29,
            //                    Address =string.Empty,
            //                    Credits =10,
            //                    Image ="http://p.imgci.com/db/PICTURES/CMS/263700/263701.icon.jpg",
            //                    IsSelected =true,
            //                    PlayerRoleName ="Allrounder",
            //                    Points =10,
            //                    IsCaptain=false,
            //                    IsViceCaptain=false
            //                },
            //                       new Player{
            //                    FirstName ="Imran",
            //                    LastName ="Tahir",
            //                    Age=39,
            //                    Address =string.Empty,
            //                    Credits =10,
            //                    Image ="http://p.imgci.com/db/PICTURES/CMS/263700/263772.icon.jpg",
            //                    IsSelected =true,
            //                    PlayerRoleName ="Bowler",
            //                    Points =10,
            //                    IsCaptain=false,
            //                    IsViceCaptain=false
            //                },
            //                        new Player{
            //                    FirstName ="Scott",
            //                    LastName ="Kuggeleijn",
            //                    Age=26,
            //                    Address =string.Empty,
            //                    Credits =9,
            //                    Image ="http://p.imgci.com/db/PICTURES/CMS/168500/168567.icon.jpg",
            //                    IsSelected =true,
            //                    PlayerRoleName ="Bowling allrounder",
            //                    Points =9,
            //                    IsCaptain=false,
            //                    IsViceCaptain=false
            //                },
            //                         new Player{
            //                    FirstName ="Kedar",
            //                    LastName ="Jadhav",
            //                    Age=33,
            //                    Address =string.Empty,
            //                    Credits =10,
            //                    Image ="http://p.imgci.com/db/PICTURES/CMS/263700/263706.icon.jpg",
            //                    IsSelected =true,
            //                    PlayerRoleName ="Batting allrounder",
            //                    Points =10,
            //                    IsCaptain=false,
            //                    IsViceCaptain=false
            //                },
            //                          new Player{
            //                    FirstName ="Mohit",
            //                    LastName ="Sharma",
            //                    Age=30,
            //                    Address =string.Empty,
            //                    Credits =8,
            //                    Image ="http://p.imgci.com/db/PICTURES/CMS/181500/181575.icon.jpg",
            //                    IsSelected =true,
            //                    PlayerRoleName ="Bowler",
            //                    Points =8,
            //                    IsCaptain=false,
            //                    IsViceCaptain=false
            //                },
            //                           new Player{
            //                    FirstName ="Ambati",
            //                    LastName ="Rayudu",
            //                    Age=33,
            //                    Address =string.Empty,
            //                    Credits =8.5M,
            //                    Image ="http://p.imgci.com/db/PICTURES/CMS/205300/205371.icon.jpg",
            //                    IsSelected =true,
            //                    PlayerRoleName ="Middle-order batsman",
            //                    Points =8.5M,
            //                    IsCaptain=false,
            //                    IsViceCaptain=false
            //                },
            //                            new Player{
            //                    FirstName ="Suresh",
            //                    LastName ="Raina",
            //                    Age=31,
            //                    Address =string.Empty,
            //                    Credits =10,
            //                    Image ="http://p.imgci.com/db/PICTURES/CMS/202700/202703.icon.jpg",
            //                    IsSelected =true,
            //                    PlayerRoleName ="Middle-order batsman",
            //                    Points =10,
            //                    IsCaptain=false,
            //                    IsViceCaptain=false
            //                },
            //                new Player{
            //                    FirstName ="Shardul",
            //                    LastName ="Thakur",
            //                    Age=27,
            //                    Address =string.Empty,
            //                    Credits =10,
            //                    Image ="http://p.imgci.com/db/PICTURES/CMS/153500/153525.icon.jpg",
            //                    IsSelected =false,
            //                    PlayerRoleName ="Bowler",
            //                    Points =10,
            //                    IsCaptain=false,
            //                    IsViceCaptain=false
            //                }
            //            },
            //    TeamName = "CSK"
            //};
            //Team team2 = new Team
            //{

            //    Logo = "https://www.kreedon.com/wp-content/uploads/2019/03/sunrisers_hyderabad11.jpg",
            //    Players = new List<Player>
            //            {
            //                new Player{
            //                    FirstName ="Kane",
            //                    LastName ="Williamson",
            //                    Age=28,
            //                    Address =string.Empty,
            //                    Credits =12,
            //                    Image ="http://p.imgci.com/db/PICTURES/CMS/263400/263495.icon.jpg",
            //                    IsSelected =true,
            //                    PlayerRoleName ="Top-order batsman",
            //                    Points =12,
            //                    IsCaptain=true,
            //                    IsViceCaptain=false
            //                },
            //                  new Player{
            //                    FirstName ="Wriddhiman",
            //                    LastName ="Saha",
            //                    Age=34,
            //                    Address =string.Empty,
            //                    Credits =10,
            //                    Image ="http://p.imgci.com/db/PICTURES/CMS/141700/141725.icon.jpg",
            //                    IsSelected =true,
            //                    PlayerRoleName ="Wicketkeeper batsman",
            //                    Points =10,
            //                    IsCaptain=false,
            //                    IsViceCaptain=false
            //                },
            //                   new Player{
            //                    FirstName ="Deepak",
            //                    LastName ="Hooda",
            //                    Age=23,
            //                    Address =string.Empty,
            //                    Credits =11.5M,
            //                    Image ="http://p.imgci.com/db/PICTURES/CMS/179400/179475.icon.jpg",
            //                    IsSelected =true,
            //                    PlayerRoleName ="Allrounder",
            //                    Points =11.5M,
            //                    IsCaptain=false,
            //                    IsViceCaptain=false
            //                },
            //                    new Player{
            //                    FirstName ="Vijay",
            //                    LastName ="Shankar",
            //                    Age=27,
            //                    Address =string.Empty,
            //                    Credits =9,
            //                    Image ="http://p.imgci.com/db/PICTURES/CMS/183800/183831.icon.jpg",
            //                    IsSelected =true,
            //                    PlayerRoleName ="Allrounder",
            //                    Points =9,
            //                    IsCaptain=false,
            //                    IsViceCaptain=false
            //                },
            //                     new Player{
            //                    FirstName ="Bhuvneshwar",
            //                    LastName ="Kumar",
            //                    Age=28,
            //                    Address =string.Empty,
            //                    Credits =10.5M,
            //                    Image ="http://p.imgci.com/db/PICTURES/CMS/282600/282627.icon.jpg",
            //                    IsSelected =true,
            //                    PlayerRoleName ="Bowler",
            //                    Points =10.5M,
            //                    IsCaptain=false,
            //                    IsViceCaptain=false
            //                },
            //                      new Player{
            //                    FirstName ="Shakib",
            //                    LastName ="Al Hasan",
            //                    Age=31,
            //                    Address =string.Empty,
            //                    Credits =10,
            //                    Image ="http://p.imgci.com/db/PICTURES/CMS/263500/263584.icon.jpg",
            //                    IsSelected =true,
            //                    PlayerRoleName ="Allrounder",
            //                    Points =10,
            //                    IsCaptain=false,
            //                    IsViceCaptain=false
            //                },
            //                       new Player{
            //                    FirstName ="Rashid",
            //                    LastName ="Khan",
            //                    Age=20,
            //                    Address =string.Empty,
            //                    Credits =10,
            //                    Image ="http://p.imgci.com/db/PICTURES/CMS/235900/235933.icon.jpg",
            //                    IsSelected =true,
            //                    PlayerRoleName ="Bowler",
            //                    Points =10,
            //                    IsCaptain=false,
            //                    IsViceCaptain=false
            //                },
            //                        new Player{
            //                    FirstName ="David",
            //                    LastName ="Warner",
            //                    Age=32,
            //                    Address =string.Empty,
            //                    Credits =10,
            //                    Image ="http://p.imgci.com/db/PICTURES/CMS/263500/263541.icon.jpg",
            //                    IsSelected =true,
            //                    PlayerRoleName ="Opening batsman",
            //                    Points =10,
            //                    IsCaptain=false,
            //                    IsViceCaptain=false
            //                },
            //                         new Player{
            //                    FirstName ="Mohammad",
            //                    LastName ="Nabi",
            //                    Age=33,
            //                    Address =string.Empty,
            //                    Credits =10,
            //                    Image ="http://p.imgci.com/db/PICTURES/CMS/150100/150122.1.jpg",
            //                    IsSelected =true,
            //                    PlayerRoleName ="Allrounder",
            //                    Points =10,
            //                    IsCaptain=false,
            //                    IsViceCaptain=false
            //                },
            //                          new Player{
            //                    FirstName ="Jonny",
            //                    LastName ="Bairstow",
            //                    Age=29,
            //                    Address =string.Empty,
            //                    Credits =8,
            //                    Image ="http://p.imgci.com/db/PICTURES/CMS/243000/243029.icon.jpg",
            //                    IsSelected =true,
            //                    PlayerRoleName ="Middle-order batsman",
            //                    Points =8,
            //                    IsCaptain=false,
            //                    IsViceCaptain=false
            //                },
            //                           new Player{
            //                    FirstName ="Abhishek",
            //                    LastName ="Sharma",
            //                    Age=18,
            //                    Address =string.Empty,
            //                    Credits =7.5M,
            //                    Image ="http://p.imgci.com/db/PICTURES/CMS/205300/205371.icon.jpg",
            //                    IsSelected =true,
            //                    PlayerRoleName ="Bowler",
            //                    Points =7.5M,
            //                    IsCaptain=false,
            //                    IsViceCaptain=false
            //                },

            //            }
            //              ,
            //    TeamName = "SRH"
            //};
            //Contest contest = new Contest
            //{
             
            //    EntryFee = 0,
            //    NoOfSpots = 100,
            //    NoOfSpotsLeft=99,
            //    PrizeAmount=0,
            //    WinningPercent=23,
            //   Match  = new Match
            //   {
            //       Name = "SRH vs CSK",
            //       SeriesName = "IPL",
            //       Sport = "Cricket",
            //       Teams = new System.Collections.Generic.List<Team>
            //    {
            //           team1
            //          ,team2
                    
            //    },
            //       TImeSlot = DateTime.Now.AddDays(1).ToShortTimeString()
            //   }

            //};

            MatchPlayerPerforma matchPlayerPerforma = new MatchPlayerPerforma
            {
                UserId=1,
                PlayerId = 8,
                MatchId = 1,
              IsRunOut=true

            };
            MatchPlayerPerforma matchPlayerPerforma1 = new MatchPlayerPerforma
            {
                UserId = 1,
                PlayerId = 2,
                MatchId = 1,
                Strike = 0,
                IsStumped=true

            };
            MatchPlayerPerforma matchPlayerPerforma2 = new MatchPlayerPerforma
            {
                UserId = 1,
                PlayerId = 3,
                MatchId = 1,
                IsCaughtAndBowled=true,
                HasWicketTaken=true

            };
            MatchPlayerPerforma matchPlayerPerforma3 = new MatchPlayerPerforma
            {
                UserId = 1,
                PlayerId = 4,
                MatchId = 1,
                Strike = 6,
                IsHalfCentury=true

            };
            MatchPlayerPerforma matchPlayerPerforma4 = new MatchPlayerPerforma
            {
                UserId = 1,
                PlayerId = 5,
                MatchId = 1,
             IsMaidenOver=true,
             IsFourWickets=true,
             HasWicketTaken=true

            };
            MatchPlayerPerforma matchPlayerPerforma5 = new MatchPlayerPerforma
            {
                UserId = 1,
                PlayerId = 6,
                MatchId = 1,
                IsRunOut=true

            };
            MatchPlayerPerforma matchPlayerPerforma6 = new MatchPlayerPerforma
            {
                UserId = 1,
                PlayerId = 7,
                MatchId = 1,
                Strike = 0,
                IsDismissalOnDuck=true

            };
            // UserContest userContest = new UserContest { User = user, Contest = contest };
            using (var ctx = new Dream11Context())
            {
                //ctx.Add<User>(user);
                //ctx.Add<Contest>(contest);
                //ctx.Add<UserContest>(userContest);
                ctx.Add<MatchPlayerPerforma>(matchPlayerPerforma);
                ctx.Add<MatchPlayerPerforma>(matchPlayerPerforma1);
                ctx.Add<MatchPlayerPerforma>(matchPlayerPerforma2);
                ctx.Add<MatchPlayerPerforma>(matchPlayerPerforma3);
                ctx.Add<MatchPlayerPerforma>(matchPlayerPerforma4);
                ctx.Add<MatchPlayerPerforma>(matchPlayerPerforma5);
                ctx.Add<MatchPlayerPerforma>(matchPlayerPerforma6);

                ctx.SaveChanges();
            }
           
        }

    }
}
