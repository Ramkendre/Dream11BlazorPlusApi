using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Dream11Model.Migrations
{
    public partial class Dream11 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Matches",
                columns: table => new
                {
                    MatchId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    SeriesName = table.Column<string>(nullable: true),
                    Sport = table.Column<string>(nullable: true),
                    TImeSlot = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Matches", x => x.MatchId);
                });

            migrationBuilder.CreateTable(
                name: "MatchPlayerPerformas",
                columns: table => new
                {
                    MatchPlayerPerformaId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    UserId = table.Column<int>(nullable: false),
                    PlayerId = table.Column<int>(nullable: false),
                    MatchId = table.Column<int>(nullable: false),
                    Strike = table.Column<int>(nullable: false),
                    IsCaughtAndBowled = table.Column<bool>(nullable: false),
                    HasWicketTaken = table.Column<bool>(nullable: false),
                    IsStumped = table.Column<bool>(nullable: false),
                    IsRunOut = table.Column<bool>(nullable: false),
                    IsHalfCentury = table.Column<bool>(nullable: false),
                    IsCentury = table.Column<bool>(nullable: false),
                    IsFourWickets = table.Column<bool>(nullable: false),
                    IsEightWickets = table.Column<bool>(nullable: false),
                    IsMaidenOver = table.Column<bool>(nullable: false),
                    IsDismissalOnDuck = table.Column<bool>(nullable: false),
                    TotalRun = table.Column<int>(nullable: false),
                    TotalWicket = table.Column<int>(nullable: false),
                    Over = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MatchPlayerPerformas", x => x.MatchPlayerPerformaId);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    UserId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Firstname = table.Column<string>(nullable: true),
                    Lastname = table.Column<string>(nullable: true),
                    Username = table.Column<string>(nullable: true),
                    Emailaddress = table.Column<string>(nullable: true),
                    age = table.Column<int>(nullable: true),
                    Level = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.UserId);
                });

            migrationBuilder.CreateTable(
                name: "Contests",
                columns: table => new
                {
                    ContestId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    EntryFee = table.Column<decimal>(nullable: false),
                    PrizeAmount = table.Column<decimal>(nullable: false),
                    NoOfSpots = table.Column<int>(nullable: false),
                    NoOfSpotsLeft = table.Column<int>(nullable: false),
                    WinningPercent = table.Column<decimal>(nullable: false),
                    MatchId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contests", x => x.ContestId);
                    table.ForeignKey(
                        name: "FK_Contests_Matches_MatchId",
                        column: x => x.MatchId,
                        principalTable: "Matches",
                        principalColumn: "MatchId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Teams",
                columns: table => new
                {
                    TeamId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    TeamName = table.Column<string>(nullable: true),
                    MatchId = table.Column<int>(nullable: false),
                    Logo = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Teams", x => x.TeamId);
                    table.ForeignKey(
                        name: "FK_Teams_Matches_MatchId",
                        column: x => x.MatchId,
                        principalTable: "Matches",
                        principalColumn: "MatchId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserTeams",
                columns: table => new
                {
                    UserTeamId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    UserId = table.Column<int>(nullable: true),
                    UserTeamName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserTeams", x => x.UserTeamId);
                    table.ForeignKey(
                        name: "FK_UserTeams_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "UserContests",
                columns: table => new
                {
                    UserId = table.Column<int>(nullable: false),
                    ContestId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserContests", x => new { x.UserId, x.ContestId });
                    table.ForeignKey(
                        name: "FK_UserContests_Contests_ContestId",
                        column: x => x.ContestId,
                        principalTable: "Contests",
                        principalColumn: "ContestId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserContests_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Players",
                columns: table => new
                {
                    PlayerId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    Age = table.Column<int>(nullable: true),
                    Address = table.Column<string>(nullable: true),
                    PlayerRoleName = table.Column<string>(nullable: true),
                    TeamId = table.Column<int>(nullable: true),
                    Image = table.Column<string>(nullable: true),
                    Points = table.Column<decimal>(nullable: false),
                    Credits = table.Column<decimal>(nullable: false),
                    IsSelected = table.Column<bool>(nullable: false),
                    IsCaptain = table.Column<bool>(nullable: false),
                    IsViceCaptain = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Players", x => x.PlayerId);
                    table.ForeignKey(
                        name: "FK_Players_Teams_TeamId",
                        column: x => x.TeamId,
                        principalTable: "Teams",
                        principalColumn: "TeamId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ContestUserTeams",
                columns: table => new
                {
                    UserTeamId = table.Column<int>(nullable: false),
                    ContestId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContestUserTeams", x => new { x.ContestId, x.UserTeamId });
                    table.ForeignKey(
                        name: "FK_ContestUserTeams_Contests_ContestId",
                        column: x => x.ContestId,
                        principalTable: "Contests",
                        principalColumn: "ContestId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ContestUserTeams_UserTeams_UserTeamId",
                        column: x => x.UserTeamId,
                        principalTable: "UserTeams",
                        principalColumn: "UserTeamId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserTeamPlayers",
                columns: table => new
                {
                    PlayerId = table.Column<int>(nullable: false),
                    UserTeamId = table.Column<int>(nullable: false),
                    IsCaptain = table.Column<bool>(nullable: false),
                    IsViceCaptain = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserTeamPlayers", x => new { x.UserTeamId, x.PlayerId });
                    table.ForeignKey(
                        name: "FK_UserTeamPlayers_Players_PlayerId",
                        column: x => x.PlayerId,
                        principalTable: "Players",
                        principalColumn: "PlayerId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserTeamPlayers_UserTeams_UserTeamId",
                        column: x => x.UserTeamId,
                        principalTable: "UserTeams",
                        principalColumn: "UserTeamId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Contests_MatchId",
                table: "Contests",
                column: "MatchId");

            migrationBuilder.CreateIndex(
                name: "IX_ContestUserTeams_UserTeamId",
                table: "ContestUserTeams",
                column: "UserTeamId");

            migrationBuilder.CreateIndex(
                name: "IX_Players_TeamId",
                table: "Players",
                column: "TeamId");

            migrationBuilder.CreateIndex(
                name: "IX_Teams_MatchId",
                table: "Teams",
                column: "MatchId");

            migrationBuilder.CreateIndex(
                name: "IX_UserContests_ContestId",
                table: "UserContests",
                column: "ContestId");

            migrationBuilder.CreateIndex(
                name: "IX_UserTeamPlayers_PlayerId",
                table: "UserTeamPlayers",
                column: "PlayerId");

            migrationBuilder.CreateIndex(
                name: "IX_UserTeams_UserId",
                table: "UserTeams",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ContestUserTeams");

            migrationBuilder.DropTable(
                name: "MatchPlayerPerformas");

            migrationBuilder.DropTable(
                name: "UserContests");

            migrationBuilder.DropTable(
                name: "UserTeamPlayers");

            migrationBuilder.DropTable(
                name: "Contests");

            migrationBuilder.DropTable(
                name: "Players");

            migrationBuilder.DropTable(
                name: "UserTeams");

            migrationBuilder.DropTable(
                name: "Teams");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Matches");
        }
    }
}
