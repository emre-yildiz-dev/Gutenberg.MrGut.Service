using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GutenBerg.MrGut.Migrations
{
    /// <inheritdoc />
    public partial class AddMemoizedPageNumber : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "MemoizedPageNumber",
                table: "UserBookMappings",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MemoizedPageNumber",
                table: "UserBookMappings");
        }
    }
}
