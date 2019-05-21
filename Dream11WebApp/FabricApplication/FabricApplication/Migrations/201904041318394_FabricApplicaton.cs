namespace FabricApplication.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FabricApplicaton : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Contests",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        EntryFee = c.String(),
                        PrizeAmount = c.String(),
                        NoOfSpots = c.String(),
                        NoOfSpotsLeft = c.String(),
                        WinningPercent = c.String(),
                        MatchesId = c.Int(nullable: false),
                        User_Id = c.Int(),
                        UserTeam_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Users", t => t.User_Id)
                .ForeignKey("dbo.UserTeams", t => t.UserTeam_Id)
                .Index(t => t.User_Id)
                .Index(t => t.UserTeam_Id);
            
            CreateTable(
                "dbo.Matches",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        SeriesName = c.String(),
                        TImeSlot = c.String(),
                        Location = c.String(),
                        Date = c.DateTime(),
                        TeamName = c.String(),
                        UserId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Players",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FirstName = c.String(),
                        LastName = c.String(),
                        Age = c.Int(),
                        Address = c.String(),
                        PlayerRoleName = c.String(),
                        UserTeam_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.UserTeams", t => t.UserTeam_Id)
                .Index(t => t.UserTeam_Id);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Firstname = c.String(),
                        Lastname = c.String(),
                        Username = c.String(),
                        Emailaddress = c.String(),
                        age = c.Int(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.UserTeams",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserTeamName = c.String(),
                        User_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Users", t => t.User_Id)
                .Index(t => t.User_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.UserTeams", "User_Id", "dbo.Users");
            DropForeignKey("dbo.Players", "UserTeam_Id", "dbo.UserTeams");
            DropForeignKey("dbo.Contests", "UserTeam_Id", "dbo.UserTeams");
            DropForeignKey("dbo.Contests", "User_Id", "dbo.Users");
            DropIndex("dbo.UserTeams", new[] { "User_Id" });
            DropIndex("dbo.Players", new[] { "UserTeam_Id" });
            DropIndex("dbo.Contests", new[] { "UserTeam_Id" });
            DropIndex("dbo.Contests", new[] { "User_Id" });
            DropTable("dbo.UserTeams");
            DropTable("dbo.Users");
            DropTable("dbo.Players");
            DropTable("dbo.Matches");
            DropTable("dbo.Contests");
        }
    }
}
