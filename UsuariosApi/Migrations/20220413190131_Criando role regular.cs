using Microsoft.EntityFrameworkCore.Migrations;

namespace UsuariosApi.Migrations
{
    public partial class Criandoroleregular : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 99999,
                column: "ConcurrencyStamp",
                value: "2a217255-3e38-4fac-a609-71a06d95dd56");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { 99997, "8efff2b2-e35e-441d-b8e3-76bb5cc1f2ed", "regular", "REGULAR" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 99999,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1e4dd639-272f-4f4a-b241-122ed86a4dc1", "AQAAAAEAACcQAAAAEKvauZ63WLvFJFri8hBDUoCd3X1Fcr4m2T8XjF8DRlI263BhaggGcjMqGvkgAaAx2w==", "7cf20482-3061-4f8b-83b5-04fb344af9b3" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 99997);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 99999,
                column: "ConcurrencyStamp",
                value: "5d31a467-b1c1-45c6-bbec-fb443c44c2a0");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 99999,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b54bc32b-5dfe-4ed3-8f7e-31d7bc3c75da", "AQAAAAEAACcQAAAAEFO4iFQ5A3f/vEQw0KGKkLJYIxxNI7FnFsgR7y2n8l7/sJHd4m3Bq5qgnYx4Aux0/Q==", "1de38fb6-5f82-4c09-bbe0-b918af5cda86" });
        }
    }
}
