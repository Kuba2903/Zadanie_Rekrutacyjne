using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Migrations
{
    public partial class sevenMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_FavouriteTeamEntity",
                table: "FavouriteTeamEntity");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "361f4030-ac72-4201-b612-359ac4054ba2");

            migrationBuilder.RenameTable(
                name: "FavouriteTeamEntity",
                newName: "Favourites");

            migrationBuilder.RenameIndex(
                name: "IX_FavouriteTeamEntity_UserId_TeamId",
                table: "Favourites",
                newName: "IX_Favourites_UserId_TeamId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Favourites",
                table: "Favourites",
                column: "Id");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "d45c99df-a53e-46e4-b3b1-a2dec2cc7347", 0, "932ef0cf-5249-4756-8e66-8ff395062c74", "karolina@wsei.edu.pl", true, false, null, "KAROLINA@WSEI.EDU.PL", "KAROLINA", "AQAAAAEAACcQAAAAEIBw2kbF9YvxV+oT+4QKI5iRIO4xOqLbef0HotILi/7SFWA1ScOsN4pwLU54J0Lkrw==", null, false, "25cbb1f0-d789-49de-8bd7-ab8911ebe541", false, "karolina" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Favourites",
                table: "Favourites");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d45c99df-a53e-46e4-b3b1-a2dec2cc7347");

            migrationBuilder.RenameTable(
                name: "Favourites",
                newName: "FavouriteTeamEntity");

            migrationBuilder.RenameIndex(
                name: "IX_Favourites_UserId_TeamId",
                table: "FavouriteTeamEntity",
                newName: "IX_FavouriteTeamEntity_UserId_TeamId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_FavouriteTeamEntity",
                table: "FavouriteTeamEntity",
                column: "Id");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "361f4030-ac72-4201-b612-359ac4054ba2", 0, "d5ff126b-b232-4aee-987e-0eb5d09f000f", "karolina@wsei.edu.pl", true, false, null, "KAROLINA@WSEI.EDU.PL", "KAROLINA", "AQAAAAEAACcQAAAAEPms42O7rB8ecvAHjG0sEsmJzqdnyd7EK8w2Ea2QMOIucC5Ksgw8hgfcrjWytEEJ3A==", null, false, "793df3a8-ba44-4c47-a183-fc5e1e68ef97", false, "karolina" });
        }
    }
}
