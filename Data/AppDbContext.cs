using Data.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<TeamEntity> Teams { get; set; }

        private string DbPath { get; set; }
        public AppDbContext()
        {
            var folder = Environment.SpecialFolder.LocalApplicationData;
            var path = Environment.GetFolderPath(folder);
            DbPath = System.IO.Path.Join(path, "leagues.db");
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options) =>
            options.UseSqlite($"Data Source={DbPath}");


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);


            modelBuilder.Entity<TeamEntity>().HasData(
                new TeamEntity()
                {
                    Id = 1,
                    League_Position = 1,
                    Name = "Genk",
                    Matches_Played = 34,
                    Points = 75,
                    Goal_Diff = 41,
                    Wins = 23,
                    Draws = 6,
                    Losts = 5
                },
                new TeamEntity()
                {
                    Id = 2,
                    League_Position = 2,
                    Name = "Union SG",
                    Matches_Played = 34,
                    Points = 75,
                    Goal_Diff = 29,
                    Wins = 23,
                    Draws = 6,
                    Losts = 5
                },
                new TeamEntity()
                {
                    Id = 3,
                    League_Position = 3,
                    Name = "Royal Antwerp",
                    Matches_Played = 34,
                    Points = 72,
                    Goal_Diff = 33,
                    Wins = 22,
                    Draws = 6,
                    Losts = 6
                },
                new TeamEntity()
                {
                    Id = 4,
                    League_Position = 4,
                    Name = "Club Brugge",
                    Matches_Played = 34,
                    Points = 59,
                    Goal_Diff = 25,
                    Wins = 16,
                    Draws = 11,
                    Losts = 7
                },
                new TeamEntity()
                {
                    Id = 5,
                    League_Position = 5,
                    Name = "Gent",
                    Matches_Played = 34,
                    Points = 56,
                    Goal_Diff = 26,
                    Wins = 16,
                    Draws = 8,
                    Losts = 10
                },
                new TeamEntity()
                {
                    Id = 6,
                    League_Position = 6,
                    Name = "Standard Liege",
                    Matches_Played = 34,
                    Points = 55,
                    Goal_Diff = 13,
                    Wins = 16,
                    Draws = 7,
                    Losts = 11
                },
                new TeamEntity()
                {
                    Id = 7,
                    League_Position = 7,
                    Name = "Wasterlo",
                    Matches_Played = 34,
                    Points = 51,
                    Goal_Diff = 8,
                    Wins = 14,
                    Draws = 9,
                    Losts = 11
                },
                new TeamEntity()
                {
                    Id = 8,
                    League_Position = 8,
                    Name = "Cercle Brugge",
                    Matches_Played = 34,
                    Points = 50,
                    Goal_Diff = 4,
                    Wins = 13,
                    Draws = 11,
                    Losts = 10
                },
                new TeamEntity()
                {
                    Id = 9,
                    League_Position = 9,
                    Name = "Royal Charleroi",
                    Matches_Played = 34,
                    Points = 48,
                    Goal_Diff = -7,
                    Wins = 14,
                    Draws = 6,
                    Losts = 14
                },
                new TeamEntity()
                {
                    Id = 10,
                    League_Position = 10,
                    Name = "OH Leuven",
                    Matches_Played = 34,
                    Points = 48,
                    Goal_Diff = 8,
                    Wins = 13,
                    Draws = 9,
                    Losts = 12
                },
                new TeamEntity()
                {
                    Id = 11,
                    League_Position = 11,
                    Name = "Anderlecht",
                    Matches_Played = 34,
                    Points = 46,
                    Goal_Diff = 3,
                    Wins = 13,
                    Draws = 7,
                    Losts = 14
                },
                new TeamEntity()
                {
                    Id = 12,
                    League_Position = 12,
                    Name = "Sint-Truiden",
                    Matches_Played = 34,
                    Points = 42,
                    Goal_Diff = -3,
                    Wins = 11,
                    Draws = 9,
                    Losts = 14
                },
                new TeamEntity()
                {
                    Id = 13,
                    League_Position = 13,
                    Name = "Mechelen",
                    Matches_Played = 34,
                    Points = 40,
                    Goal_Diff = -14,
                    Wins = 11,
                    Draws = 7,
                    Losts = 16
                },
                new TeamEntity()
                {
                    Id = 14,
                    League_Position = 14,
                    Name = "Kortrijk",
                    Matches_Played = 34,
                    Points = 31,
                    Goal_Diff = -24,
                    Wins = 8,
                    Draws = 7,
                    Losts = 19
                },
                new TeamEntity()
                {
                    Id = 15,
                    League_Position = 15,
                    Name = "Eupen",
                    Matches_Played = 34,
                    Points = 28,
                    Goal_Diff = -35,
                    Wins = 7,
                    Draws = 7,
                    Losts = 20
                },
                new TeamEntity()
                {
                    Id = 16,
                    League_Position = 16,
                    Name = "Oostende",
                    Matches_Played = 34,
                    Points = 27,
                    Goal_Diff = -39,
                    Wins = 7,
                    Draws = 6,
                    Losts = 21
                },
                new TeamEntity()
                {
                    Id = 17,
                    League_Position = 17,
                    Name = "Zulte Waregem",
                    Matches_Played = 34,
                    Points = 27,
                    Goal_Diff = -28,
                    Wins = 6,
                    Draws = 9,
                    Losts = 19
                },
                new TeamEntity()
                {
                    Id = 18,
                    League_Position = 18,
                    Name = "Seraing",
                    Matches_Played = 34,
                    Points = 20,
                    Goal_Diff = -40,
                    Wins = 5,
                    Draws = 5,
                    Losts = 24
                }
                
                );
        }
    }
}
