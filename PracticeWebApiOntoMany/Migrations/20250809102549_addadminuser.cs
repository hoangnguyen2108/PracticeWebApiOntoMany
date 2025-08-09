using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace PracticeWebApiOntoMany.Migrations
{
    /// <inheritdoc />
    public partial class addadminuser : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1647167c-9337-4d2a-a413-f8a35d280f23");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d766ed80-55e7-43eb-92b4-673916798916");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "1b1bb66e-6aa2-4728-8b5b-4e6de4fd899b", null, "Admin", "ADMIN" },
                    { "86da011b-0608-4f9c-a5ad-6aed52b11315", null, "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "69321195-8b73-4f1a-919b-e7deee4b3909", 0, "51f9ee93-271a-4614-a7a0-cd3fff5ff4b0", "user1adin@gmail.com", true, "Jay", "Van", false, null, "USER1admin@GMAIL.COM", "USER1admin@GMAIL.COM", "AQAAAAIAAYagAAAAEJcSJbj2SFNjl5+8XCTn70gu7prxC7/vJHy9TeHof5G9uSQIaPV+XSFJncsvoMbZzw==", null, false, "d093db36-a76c-433c-b3a4-299006ef39fe", false, "user1adin@gmail.com" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1b1bb66e-6aa2-4728-8b5b-4e6de4fd899b");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "86da011b-0608-4f9c-a5ad-6aed52b11315");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "69321195-8b73-4f1a-919b-e7deee4b3909");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "1647167c-9337-4d2a-a413-f8a35d280f23", null, "Admin", "ADMIN" },
                    { "d766ed80-55e7-43eb-92b4-673916798916", null, "User", "USER" }
                });
        }
    }
}
