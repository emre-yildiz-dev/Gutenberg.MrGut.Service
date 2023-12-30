using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GutenBerg.MrGut.Migrations
{
    /// <inheritdoc />
    public partial class AddGutenbergIdToPage : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "GutenbergId",
                table: "Page",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "GutenbergId",
                table: "Page");
        }
    }
}
