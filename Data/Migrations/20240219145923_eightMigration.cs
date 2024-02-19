using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Migrations
{
    public partial class eightMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d45c99df-a53e-46e4-b3b1-a2dec2cc7347");

            migrationBuilder.CreateTable(
                name: "Leagues",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Country = table.Column<string>(type: "TEXT", nullable: false),
                    Name = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Leagues", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "f6bab921-fca0-4a83-ad30-20cd55652a98", 0, "64682f60-f3ea-41b8-b8fa-2af4665919d1", "karolina@wsei.edu.pl", true, false, null, "KAROLINA@WSEI.EDU.PL", "KAROLINA", "AQAAAAEAACcQAAAAENta+4jiK8t20cxtOABG+Wzqvo7jUq7HHFWeO5Npa/2Suwbesn8BUpgMQxO5hu9r0Q==", null, false, "2c01493a-1792-4f90-91cb-86fc82353628", false, "karolina" });

            migrationBuilder.InsertData(
                table: "Leagues",
                columns: new[] { "Id", "Country", "Name" },
                values: new object[] { 1, "Belgium", "Jupiler Pro League" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Leagues");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f6bab921-fca0-4a83-ad30-20cd55652a98");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "d45c99df-a53e-46e4-b3b1-a2dec2cc7347", 0, "932ef0cf-5249-4756-8e66-8ff395062c74", "karolina@wsei.edu.pl", true, false, null, "KAROLINA@WSEI.EDU.PL", "KAROLINA", "AQAAAAEAACcQAAAAEIBw2kbF9YvxV+oT+4QKI5iRIO4xOqLbef0HotILi/7SFWA1ScOsN4pwLU54J0Lkrw==", null, false, "25cbb1f0-d789-49de-8bd7-ab8911ebe541", false, "karolina" });
        }
    }
}
