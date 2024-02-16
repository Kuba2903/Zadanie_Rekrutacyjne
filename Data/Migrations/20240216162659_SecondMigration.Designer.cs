﻿// <auto-generated />
using System;
using Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Data.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20240216162659_SecondMigration")]
    partial class SecondMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.0");

            modelBuilder.Entity("Data.Entities.MatchEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("AwayTeamId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("AwayTeamScore")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("Date")
                        .HasColumnType("TEXT");

                    b.Property<int>("HomeTeamId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("HomeTeamScore")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("AwayTeamId");

                    b.HasIndex("HomeTeamId");

                    b.ToTable("matches");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            AwayTeamId = 4,
                            AwayTeamScore = 1,
                            Date = new DateTime(2023, 2, 16, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            HomeTeamId = 11,
                            HomeTeamScore = 2
                        });
                });

            modelBuilder.Entity("Data.Entities.TeamEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<byte>("Draws")
                        .HasColumnType("INTEGER");

                    b.Property<sbyte>("Goal_Diff")
                        .HasColumnType("INTEGER");

                    b.Property<byte>("League_Position")
                        .HasColumnType("INTEGER");

                    b.Property<byte>("Losts")
                        .HasColumnType("INTEGER");

                    b.Property<byte>("Matches_Played")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<sbyte>("Points")
                        .HasColumnType("INTEGER");

                    b.Property<byte>("Wins")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("teams");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Draws = (byte)6,
                            Goal_Diff = (sbyte)41,
                            League_Position = (byte)1,
                            Losts = (byte)5,
                            Matches_Played = (byte)34,
                            Name = "Genk",
                            Points = (sbyte)75,
                            Wins = (byte)23
                        },
                        new
                        {
                            Id = 2,
                            Draws = (byte)6,
                            Goal_Diff = (sbyte)29,
                            League_Position = (byte)2,
                            Losts = (byte)5,
                            Matches_Played = (byte)34,
                            Name = "Union SG",
                            Points = (sbyte)75,
                            Wins = (byte)23
                        },
                        new
                        {
                            Id = 3,
                            Draws = (byte)6,
                            Goal_Diff = (sbyte)33,
                            League_Position = (byte)3,
                            Losts = (byte)6,
                            Matches_Played = (byte)34,
                            Name = "Royal Antwerp",
                            Points = (sbyte)72,
                            Wins = (byte)22
                        },
                        new
                        {
                            Id = 4,
                            Draws = (byte)11,
                            Goal_Diff = (sbyte)25,
                            League_Position = (byte)4,
                            Losts = (byte)7,
                            Matches_Played = (byte)34,
                            Name = "Club Brugge",
                            Points = (sbyte)59,
                            Wins = (byte)16
                        },
                        new
                        {
                            Id = 5,
                            Draws = (byte)8,
                            Goal_Diff = (sbyte)26,
                            League_Position = (byte)5,
                            Losts = (byte)10,
                            Matches_Played = (byte)34,
                            Name = "Gent",
                            Points = (sbyte)56,
                            Wins = (byte)16
                        },
                        new
                        {
                            Id = 6,
                            Draws = (byte)7,
                            Goal_Diff = (sbyte)13,
                            League_Position = (byte)6,
                            Losts = (byte)11,
                            Matches_Played = (byte)34,
                            Name = "Standard Liege",
                            Points = (sbyte)55,
                            Wins = (byte)16
                        },
                        new
                        {
                            Id = 7,
                            Draws = (byte)9,
                            Goal_Diff = (sbyte)8,
                            League_Position = (byte)7,
                            Losts = (byte)11,
                            Matches_Played = (byte)34,
                            Name = "Wasterlo",
                            Points = (sbyte)51,
                            Wins = (byte)14
                        },
                        new
                        {
                            Id = 8,
                            Draws = (byte)11,
                            Goal_Diff = (sbyte)4,
                            League_Position = (byte)8,
                            Losts = (byte)10,
                            Matches_Played = (byte)34,
                            Name = "Cercle Brugge",
                            Points = (sbyte)50,
                            Wins = (byte)13
                        },
                        new
                        {
                            Id = 9,
                            Draws = (byte)6,
                            Goal_Diff = (sbyte)-7,
                            League_Position = (byte)9,
                            Losts = (byte)14,
                            Matches_Played = (byte)34,
                            Name = "Royal Charleroi",
                            Points = (sbyte)48,
                            Wins = (byte)14
                        },
                        new
                        {
                            Id = 10,
                            Draws = (byte)9,
                            Goal_Diff = (sbyte)8,
                            League_Position = (byte)10,
                            Losts = (byte)12,
                            Matches_Played = (byte)34,
                            Name = "OH Leuven",
                            Points = (sbyte)48,
                            Wins = (byte)13
                        },
                        new
                        {
                            Id = 11,
                            Draws = (byte)7,
                            Goal_Diff = (sbyte)3,
                            League_Position = (byte)11,
                            Losts = (byte)14,
                            Matches_Played = (byte)34,
                            Name = "Anderlecht",
                            Points = (sbyte)46,
                            Wins = (byte)13
                        },
                        new
                        {
                            Id = 12,
                            Draws = (byte)9,
                            Goal_Diff = (sbyte)-3,
                            League_Position = (byte)12,
                            Losts = (byte)14,
                            Matches_Played = (byte)34,
                            Name = "Sint-Truiden",
                            Points = (sbyte)42,
                            Wins = (byte)11
                        },
                        new
                        {
                            Id = 13,
                            Draws = (byte)7,
                            Goal_Diff = (sbyte)-14,
                            League_Position = (byte)13,
                            Losts = (byte)16,
                            Matches_Played = (byte)34,
                            Name = "Mechelen",
                            Points = (sbyte)40,
                            Wins = (byte)11
                        },
                        new
                        {
                            Id = 14,
                            Draws = (byte)7,
                            Goal_Diff = (sbyte)-24,
                            League_Position = (byte)14,
                            Losts = (byte)19,
                            Matches_Played = (byte)34,
                            Name = "Kortrijk",
                            Points = (sbyte)31,
                            Wins = (byte)8
                        },
                        new
                        {
                            Id = 15,
                            Draws = (byte)7,
                            Goal_Diff = (sbyte)-35,
                            League_Position = (byte)15,
                            Losts = (byte)20,
                            Matches_Played = (byte)34,
                            Name = "Eupen",
                            Points = (sbyte)28,
                            Wins = (byte)7
                        },
                        new
                        {
                            Id = 16,
                            Draws = (byte)6,
                            Goal_Diff = (sbyte)-39,
                            League_Position = (byte)16,
                            Losts = (byte)21,
                            Matches_Played = (byte)34,
                            Name = "Oostende",
                            Points = (sbyte)27,
                            Wins = (byte)7
                        },
                        new
                        {
                            Id = 17,
                            Draws = (byte)9,
                            Goal_Diff = (sbyte)-28,
                            League_Position = (byte)17,
                            Losts = (byte)19,
                            Matches_Played = (byte)34,
                            Name = "Zulte Waregem",
                            Points = (sbyte)27,
                            Wins = (byte)6
                        },
                        new
                        {
                            Id = 18,
                            Draws = (byte)5,
                            Goal_Diff = (sbyte)-40,
                            League_Position = (byte)18,
                            Losts = (byte)24,
                            Matches_Played = (byte)34,
                            Name = "Seraing",
                            Points = (sbyte)20,
                            Wins = (byte)5
                        });
                });

            modelBuilder.Entity("Data.Entities.MatchEntity", b =>
                {
                    b.HasOne("Data.Entities.TeamEntity", "AwayTeam")
                        .WithMany("AwayMatches")
                        .HasForeignKey("AwayTeamId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Data.Entities.TeamEntity", "HomeTeam")
                        .WithMany("HomeMatches")
                        .HasForeignKey("HomeTeamId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("AwayTeam");

                    b.Navigation("HomeTeam");
                });

            modelBuilder.Entity("Data.Entities.TeamEntity", b =>
                {
                    b.Navigation("AwayMatches");

                    b.Navigation("HomeMatches");
                });
#pragma warning restore 612, 618
        }
    }
}
