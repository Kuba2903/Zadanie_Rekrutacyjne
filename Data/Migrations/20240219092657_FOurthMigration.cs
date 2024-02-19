using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Migrations
{
    public partial class FOurthMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "matches",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AwayTeamId", "HomeTeamId" },
                values: new object[] { 18, 1 });

            migrationBuilder.InsertData(
                table: "matches",
                columns: new[] { "Id", "AwayTeamId", "AwayTeamScore", "Date", "HomeTeamId", "HomeTeamScore" },
                values: new object[] { 2, 17, 0, new DateTime(2023, 2, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 3 });

            migrationBuilder.InsertData(
                table: "matches",
                columns: new[] { "Id", "AwayTeamId", "AwayTeamScore", "Date", "HomeTeamId", "HomeTeamScore" },
                values: new object[] { 3, 16, 3, new DateTime(2023, 2, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 4 });

            migrationBuilder.InsertData(
                table: "matches",
                columns: new[] { "Id", "AwayTeamId", "AwayTeamScore", "Date", "HomeTeamId", "HomeTeamScore" },
                values: new object[] { 4, 15, 2, new DateTime(2023, 2, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, 1 });

            migrationBuilder.InsertData(
                table: "matches",
                columns: new[] { "Id", "AwayTeamId", "AwayTeamScore", "Date", "HomeTeamId", "HomeTeamScore" },
                values: new object[] { 5, 14, 1, new DateTime(2023, 2, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, 1 });

            migrationBuilder.InsertData(
                table: "matches",
                columns: new[] { "Id", "AwayTeamId", "AwayTeamScore", "Date", "HomeTeamId", "HomeTeamScore" },
                values: new object[] { 6, 13, 3, new DateTime(2023, 2, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, 2 });

            migrationBuilder.InsertData(
                table: "matches",
                columns: new[] { "Id", "AwayTeamId", "AwayTeamScore", "Date", "HomeTeamId", "HomeTeamScore" },
                values: new object[] { 7, 12, 1, new DateTime(2023, 2, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 7, 2 });

            migrationBuilder.InsertData(
                table: "matches",
                columns: new[] { "Id", "AwayTeamId", "AwayTeamScore", "Date", "HomeTeamId", "HomeTeamScore" },
                values: new object[] { 8, 11, 2, new DateTime(2023, 2, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 8, 2 });

            migrationBuilder.InsertData(
                table: "matches",
                columns: new[] { "Id", "AwayTeamId", "AwayTeamScore", "Date", "HomeTeamId", "HomeTeamScore" },
                values: new object[] { 9, 10, 1, new DateTime(2023, 2, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 9, 4 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "matches",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "matches",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "matches",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "matches",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "matches",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "matches",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "matches",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "matches",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.UpdateData(
                table: "matches",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AwayTeamId", "HomeTeamId" },
                values: new object[] { 4, 11 });
        }
    }
}
