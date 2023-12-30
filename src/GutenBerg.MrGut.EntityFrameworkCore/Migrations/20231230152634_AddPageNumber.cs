using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GutenBerg.MrGut.Migrations
{
    /// <inheritdoc />
    public partial class AddPageNumber : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "PageNumber",
                table: "Page",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PageNumber",
                table: "Page");
        }
    }
}
