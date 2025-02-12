using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace cursce.Migrations
{
    /// <inheritdoc />
    public partial class adadada : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CauseOfDeath",
                value: "Застрелился на смерть ха-ха");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CauseOfDeath",
                value: "Сердечный приступ");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CauseOfDeath",
                value: "Сердечный приступ");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CauseOfDeath",
                value: "Неизвестно");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CauseOfDeath",
                value: "Неизвестно");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CauseOfDeath",
                value: "Неизвестно");
        }
    }
}
