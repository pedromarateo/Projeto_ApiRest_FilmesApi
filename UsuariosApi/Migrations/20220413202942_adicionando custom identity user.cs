using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace UsuariosApi.Migrations
{
    public partial class adicionandocustomidentityuser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "DataNascimento",
                table: "AspNetUsers",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 99997,
                column: "ConcurrencyStamp",
                value: "7e66105d-bf6b-42d4-a5ed-e2987ffd3e7b");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 99999,
                column: "ConcurrencyStamp",
                value: "52bce63e-2997-411b-8c6b-b325fa5feb72");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 99999,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "fd125e3f-e0f6-4b3c-ac0d-099a0460e34a", "AQAAAAEAACcQAAAAEA5UXXmAy6m99+lv96fT/gvHSMDaNQ/snaw2hgmL5rHfvA3PGDRgsyJ3gbQ7EHpGTQ==", "1ddff0cd-70e0-4057-a658-ed2eda2c7d28" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DataNascimento",
                table: "AspNetUsers");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 99997,
                column: "ConcurrencyStamp",
                value: "8efff2b2-e35e-441d-b8e3-76bb5cc1f2ed");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 99999,
                column: "ConcurrencyStamp",
                value: "2a217255-3e38-4fac-a609-71a06d95dd56");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 99999,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1e4dd639-272f-4f4a-b241-122ed86a4dc1", "AQAAAAEAACcQAAAAEKvauZ63WLvFJFri8hBDUoCd3X1Fcr4m2T8XjF8DRlI263BhaggGcjMqGvkgAaAx2w==", "7cf20482-3061-4f8b-83b5-04fb344af9b3" });
        }
    }
}
