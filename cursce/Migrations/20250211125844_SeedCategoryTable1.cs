using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace cursce.Migrations
{
    /// <inheritdoc />
    public partial class SeedCategoryTable1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "DisplayOrder",
                table: "Categories",
                newName: "Year");

            migrationBuilder.AddColumn<string>(
                name: "CauseOfDeath",
                table: "Categories",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Surname",
                table: "Categories",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CauseOfDeath", "Name", "Surname", "Year" },
                values: new object[] { "Неизвестно", "Курт", "Кобейн", 2025 });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CauseOfDeath", "Name", "Surname", "Year" },
                values: new object[] { "Неизвестно", "Хит", "Леджер", 2025 });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CauseOfDeath", "Name", "Surname", "Year" },
                values: new object[] { "Неизвестно", "Джон", "Кенеди", 2025 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CauseOfDeath",
                table: "Categories");

            migrationBuilder.DropColumn(
                name: "Surname",
                table: "Categories");

            migrationBuilder.RenameColumn(
                name: "Year",
                table: "Categories",
                newName: "DisplayOrder");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DisplayOrder", "Name" },
                values: new object[] { 1, "Action" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DisplayOrder", "Name" },
                values: new object[] { 2, "SciFi" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DisplayOrder", "Name" },
                values: new object[] { 3, "History" });
        }
    }
}
