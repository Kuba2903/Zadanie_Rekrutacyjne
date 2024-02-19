using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Migrations
{
    public partial class SixthMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "405ace28-224c-497c-8a0d-7d2240f6c8ee");

            migrationBuilder.CreateTable(
                name: "FavouriteTeamEntity",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    UserId = table.Column<string>(type: "TEXT", nullable: false),
                    TeamId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FavouriteTeamEntity", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "361f4030-ac72-4201-b612-359ac4054ba2", 0, "d5ff126b-b232-4aee-987e-0eb5d09f000f", "karolina@wsei.edu.pl", true, false, null, "KAROLINA@WSEI.EDU.PL", "KAROLINA", "AQAAAAEAACcQAAAAEPms42O7rB8ecvAHjG0sEsmJzqdnyd7EK8w2Ea2QMOIucC5Ksgw8hgfcrjWytEEJ3A==", null, false, "793df3a8-ba44-4c47-a183-fc5e1e68ef97", false, "karolina" });

            migrationBuilder.CreateIndex(
                name: "IX_FavouriteTeamEntity_UserId_TeamId",
                table: "FavouriteTeamEntity",
                columns: new[] { "UserId", "TeamId" },
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FavouriteTeamEntity");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "361f4030-ac72-4201-b612-359ac4054ba2");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "405ace28-224c-497c-8a0d-7d2240f6c8ee", 0, "e6463953-add5-41f1-95a1-a116d8a496ad", "karolina@wsei.edu.pl", true, false, null, "KAROLINA@WSEI.EDU.PL", "KAROLINA", "AQAAAAEAACcQAAAAEGAe8hSJnXhTeEse0urE5keozOCyBH6Ocvd4e5TzlRCZ6iJrPtNna0ufvfk+Xhezwg==", null, false, "5e07369f-7559-4424-bd35-cf2f5906e9d3", false, "karolina" });
        }
    }
}
