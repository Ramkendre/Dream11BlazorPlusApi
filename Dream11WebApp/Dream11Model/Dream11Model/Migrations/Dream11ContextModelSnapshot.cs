﻿// <auto-generated />
using System;
using Dream11Model.EntityFrameworkContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Dream11Model.Migrations
{
    [DbContext(typeof(Dream11Context))]
    partial class Dream11ContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.2-rtm-30932")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Dream11Model.Model.Contest", b =>
                {
                    b.Property<int>("ContestId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<decimal>("EntryFee");

                    b.Property<int?>("MatchId");

                    b.Property<int>("NoOfSpots");

                    b.Property<int>("NoOfSpotsLeft");

                    b.Property<decimal>("PrizeAmount");

                    b.Property<decimal>("WinningPercent");

                    b.HasKey("ContestId");

                    b.HasIndex("MatchId");

                    b.ToTable("Contests");
                });

            modelBuilder.Entity("Dream11Model.Model.ContestUserTeam", b =>
                {
                    b.Property<int>("ContestId");

                    b.Property<int>("UserTeamId");

                    b.HasKey("ContestId", "UserTeamId");

                    b.HasIndex("UserTeamId");

                    b.ToTable("ContestUserTeams");
                });

            modelBuilder.Entity("Dream11Model.Model.Match", b =>
                {
                    b.Property<int>("MatchId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name");

                    b.Property<string>("SeriesName");

                    b.Property<string>("Sport");

                    b.Property<string>("TImeSlot");

                    b.HasKey("MatchId");

                    b.ToTable("Matches");
                });

            modelBuilder.Entity("Dream11Model.Model.MatchPlayerPerforma", b =>
                {
                    b.Property<int>("MatchPlayerPerformaId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("HasWicketTaken");

                    b.Property<bool>("IsCaughtAndBowled");

                    b.Property<bool>("IsCentury");

                    b.Property<bool>("IsDismissalOnDuck");

                    b.Property<bool>("IsEightWickets");

                    b.Property<bool>("IsFourWickets");

                    b.Property<bool>("IsHalfCentury");

                    b.Property<bool>("IsMaidenOver");

                    b.Property<bool>("IsRunOut");

                    b.Property<bool>("IsStumped");

                    b.Property<int>("MatchId");

                    b.Property<decimal>("Over");

                    b.Property<int>("PlayerId");

                    b.Property<int>("Strike");

                    b.Property<int>("TotalRun");

                    b.Property<int>("TotalWicket");

                    b.Property<int>("UserId");

                    b.HasKey("MatchPlayerPerformaId");

                    b.ToTable("MatchPlayerPerformas");
                });

            modelBuilder.Entity("Dream11Model.Model.Player", b =>
                {
                    b.Property<int>("PlayerId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address");

                    b.Property<int?>("Age");

                    b.Property<decimal>("Credits");

                    b.Property<string>("FirstName");

                    b.Property<string>("Image");

                    b.Property<bool>("IsCaptain");

                    b.Property<bool>("IsSelected");

                    b.Property<bool>("IsViceCaptain");

                    b.Property<string>("LastName");

                    b.Property<string>("PlayerRoleName");

                    b.Property<decimal>("Points");

                    b.Property<int?>("TeamId");

                    b.HasKey("PlayerId");

                    b.HasIndex("TeamId");

                    b.ToTable("Players");
                });

            modelBuilder.Entity("Dream11Model.Model.Team", b =>
                {
                    b.Property<int>("TeamId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Logo");

                    b.Property<int>("MatchId");

                    b.Property<string>("TeamName");

                    b.HasKey("TeamId");

                    b.HasIndex("MatchId");

                    b.ToTable("Teams");
                });

            modelBuilder.Entity("Dream11Model.Model.User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Emailaddress");

                    b.Property<string>("Firstname");

                    b.Property<string>("Lastname");

                    b.Property<int>("Level");

                    b.Property<string>("Username");

                    b.Property<int?>("age");

                    b.HasKey("UserId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("Dream11Model.Model.UserContest", b =>
                {
                    b.Property<int>("UserId");

                    b.Property<int>("ContestId");

                    b.HasKey("UserId", "ContestId");

                    b.HasIndex("ContestId");

                    b.ToTable("UserContests");
                });

            modelBuilder.Entity("Dream11Model.Model.UserTeam", b =>
                {
                    b.Property<int>("UserTeamId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("UserId");

                    b.Property<string>("UserTeamName");

                    b.HasKey("UserTeamId");

                    b.HasIndex("UserId");

                    b.ToTable("UserTeams");
                });

            modelBuilder.Entity("Dream11Model.Model.UserTeamPlayers", b =>
                {
                    b.Property<int>("UserTeamId");

                    b.Property<int>("PlayerId");

                    b.Property<bool>("IsCaptain");

                    b.Property<bool>("IsViceCaptain");

                    b.HasKey("UserTeamId", "PlayerId");

                    b.HasIndex("PlayerId");

                    b.ToTable("UserTeamPlayers");
                });

            modelBuilder.Entity("Dream11Model.Model.Contest", b =>
                {
                    b.HasOne("Dream11Model.Model.Match", "Match")
                        .WithMany()
                        .HasForeignKey("MatchId");
                });

            modelBuilder.Entity("Dream11Model.Model.ContestUserTeam", b =>
                {
                    b.HasOne("Dream11Model.Model.Contest", "Contest")
                        .WithMany("ContestUserTeams")
                        .HasForeignKey("ContestId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Dream11Model.Model.UserTeam", "UserTeam")
                        .WithMany("ContestUserTeams")
                        .HasForeignKey("UserTeamId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Dream11Model.Model.Player", b =>
                {
                    b.HasOne("Dream11Model.Model.Team", "Team")
                        .WithMany("Players")
                        .HasForeignKey("TeamId");
                });

            modelBuilder.Entity("Dream11Model.Model.Team", b =>
                {
                    b.HasOne("Dream11Model.Model.Match", "Match")
                        .WithMany("Teams")
                        .HasForeignKey("MatchId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Dream11Model.Model.UserContest", b =>
                {
                    b.HasOne("Dream11Model.Model.Contest", "Contest")
                        .WithMany("UserContests")
                        .HasForeignKey("ContestId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Dream11Model.Model.User", "User")
                        .WithMany("UserContests")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Dream11Model.Model.UserTeam", b =>
                {
                    b.HasOne("Dream11Model.Model.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("Dream11Model.Model.UserTeamPlayers", b =>
                {
                    b.HasOne("Dream11Model.Model.Player", "Player")
                        .WithMany("UserTeams")
                        .HasForeignKey("PlayerId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Dream11Model.Model.UserTeam", "UserTeam")
                        .WithMany("Players")
                        .HasForeignKey("UserTeamId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
