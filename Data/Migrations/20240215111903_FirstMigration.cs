using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Migrations
{
    public partial class FirstMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "teams",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    League_Position = table.Column<byte>(type: "INTEGER", nullable: false),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Matches_Played = table.Column<byte>(type: "INTEGER", nullable: false),
                    Points = table.Column<sbyte>(type: "INTEGER", nullable: false),
                    Goal_Diff = table.Column<sbyte>(type: "INTEGER", nullable: false),
                    Wins = table.Column<byte>(type: "INTEGER", nullable: false),
                    Draws = table.Column<byte>(type: "INTEGER", nullable: false),
                    Losts = table.Column<byte>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_teams", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "teams",
                columns: new[] { "Id", "Draws", "Goal_Diff", "League_Position", "Losts", "Matches_Played", "Name", "Points", "Wins" },
                values: new object[] { 1, (byte)6, (sbyte)41, (byte)1, (byte)5, (byte)34, "Genk", (sbyte)75, (byte)23 });

            migrationBuilder.InsertData(
                table: "teams",
                columns: new[] { "Id", "Draws", "Goal_Diff", "League_Position", "Losts", "Matches_Played", "Name", "Points", "Wins" },
                values: new object[] { 2, (byte)6, (sbyte)29, (byte)2, (byte)5, (byte)34, "Union SG", (sbyte)75, (byte)23 });

            migrationBuilder.InsertData(
                table: "teams",
                columns: new[] { "Id", "Draws", "Goal_Diff", "League_Position", "Losts", "Matches_Played", "Name", "Points", "Wins" },
                values: new object[] { 3, (byte)6, (sbyte)33, (byte)3, (byte)6, (byte)34, "Royal Antwerp", (sbyte)72, (byte)22 });

            migrationBuilder.InsertData(
                table: "teams",
                columns: new[] { "Id", "Draws", "Goal_Diff", "League_Position", "Losts", "Matches_Played", "Name", "Points", "Wins" },
                values: new object[] { 4, (byte)11, (sbyte)25, (byte)4, (byte)7, (byte)34, "Club Brugge", (sbyte)59, (byte)16 });

            migrationBuilder.InsertData(
                table: "teams",
                columns: new[] { "Id", "Draws", "Goal_Diff", "League_Position", "Losts", "Matches_Played", "Name", "Points", "Wins" },
                values: new object[] { 5, (byte)8, (sbyte)26, (byte)5, (byte)10, (byte)34, "Gent", (sbyte)56, (byte)16 });

            migrationBuilder.InsertData(
                table: "teams",
                columns: new[] { "Id", "Draws", "Goal_Diff", "League_Position", "Losts", "Matches_Played", "Name", "Points", "Wins" },
                values: new object[] { 6, (byte)7, (sbyte)13, (byte)6, (byte)11, (byte)34, "Standard Liege", (sbyte)55, (byte)16 });

            migrationBuilder.InsertData(
                table: "teams",
                columns: new[] { "Id", "Draws", "Goal_Diff", "League_Position", "Losts", "Matches_Played", "Name", "Points", "Wins" },
                values: new object[] { 7, (byte)9, (sbyte)8, (byte)7, (byte)11, (byte)34, "Wasterlo", (sbyte)51, (byte)14 });

            migrationBuilder.InsertData(
                table: "teams",
                columns: new[] { "Id", "Draws", "Goal_Diff", "League_Position", "Losts", "Matches_Played", "Name", "Points", "Wins" },
                values: new object[] { 8, (byte)11, (sbyte)4, (byte)8, (byte)10, (byte)34, "Cercle Brugge", (sbyte)50, (byte)13 });

            migrationBuilder.InsertData(
                table: "teams",
                columns: new[] { "Id", "Draws", "Goal_Diff", "League_Position", "Losts", "Matches_Played", "Name", "Points", "Wins" },
                values: new object[] { 9, (byte)6, (sbyte)-7, (byte)9, (byte)14, (byte)34, "Royal Charleroi", (sbyte)48, (byte)14 });

            migrationBuilder.InsertData(
                table: "teams",
                columns: new[] { "Id", "Draws", "Goal_Diff", "League_Position", "Losts", "Matches_Played", "Name", "Points", "Wins" },
                values: new object[] { 10, (byte)9, (sbyte)8, (byte)10, (byte)12, (byte)34, "OH Leuven", (sbyte)48, (byte)13 });

            migrationBuilder.InsertData(
                table: "teams",
                columns: new[] { "Id", "Draws", "Goal_Diff", "League_Position", "Losts", "Matches_Played", "Name", "Points", "Wins" },
                values: new object[] { 11, (byte)7, (sbyte)3, (byte)11, (byte)14, (byte)34, "Anderlecht", (sbyte)46, (byte)13 });

            migrationBuilder.InsertData(
                table: "teams",
                columns: new[] { "Id", "Draws", "Goal_Diff", "League_Position", "Losts", "Matches_Played", "Name", "Points", "Wins" },
                values: new object[] { 12, (byte)9, (sbyte)-3, (byte)12, (byte)14, (byte)34, "Sint-Truiden", (sbyte)42, (byte)11 });

            migrationBuilder.InsertData(
                table: "teams",
                columns: new[] { "Id", "Draws", "Goal_Diff", "League_Position", "Losts", "Matches_Played", "Name", "Points", "Wins" },
                values: new object[] { 13, (byte)7, (sbyte)-14, (byte)13, (byte)16, (byte)34, "Mechelen", (sbyte)40, (byte)11 });

            migrationBuilder.InsertData(
                table: "teams",
                columns: new[] { "Id", "Draws", "Goal_Diff", "League_Position", "Losts", "Matches_Played", "Name", "Points", "Wins" },
                values: new object[] { 14, (byte)7, (sbyte)-24, (byte)14, (byte)19, (byte)34, "Kortrijk", (sbyte)31, (byte)8 });

            migrationBuilder.InsertData(
                table: "teams",
                columns: new[] { "Id", "Draws", "Goal_Diff", "League_Position", "Losts", "Matches_Played", "Name", "Points", "Wins" },
                values: new object[] { 15, (byte)7, (sbyte)-35, (byte)15, (byte)20, (byte)34, "Eupen", (sbyte)28, (byte)7 });

            migrationBuilder.InsertData(
                table: "teams",
                columns: new[] { "Id", "Draws", "Goal_Diff", "League_Position", "Losts", "Matches_Played", "Name", "Points", "Wins" },
                values: new object[] { 16, (byte)6, (sbyte)-39, (byte)16, (byte)21, (byte)34, "Oostende", (sbyte)27, (byte)7 });

            migrationBuilder.InsertData(
                table: "teams",
                columns: new[] { "Id", "Draws", "Goal_Diff", "League_Position", "Losts", "Matches_Played", "Name", "Points", "Wins" },
                values: new object[] { 17, (byte)9, (sbyte)-28, (byte)17, (byte)19, (byte)34, "Zulte Waregem", (sbyte)27, (byte)6 });

            migrationBuilder.InsertData(
                table: "teams",
                columns: new[] { "Id", "Draws", "Goal_Diff", "League_Position", "Losts", "Matches_Played", "Name", "Points", "Wins" },
                values: new object[] { 18, (byte)5, (sbyte)-40, (byte)18, (byte)24, (byte)34, "Seraing", (sbyte)20, (byte)5 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "teams");
        }
    }
}
