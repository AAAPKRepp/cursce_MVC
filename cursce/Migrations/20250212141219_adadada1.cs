using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace cursce.Migrations
{
    /// <inheritdoc />
    public partial class adadada1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CauseOfDeath",
                value: "Передозик");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CauseOfDeath",
                value: "Застрелили за то что пиздл много");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
    }
}
