using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GutenBerg.MrGut.Migrations
{
    /// <inheritdoc />
    public partial class AddGutenbergId : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pages_Book_BookId",
                table: "Pages");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Pages",
                table: "Pages");

            migrationBuilder.RenameTable(
                name: "Pages",
                newName: "Page");

            migrationBuilder.RenameIndex(
                name: "IX_Pages_BookId",
                table: "Page",
                newName: "IX_Page_BookId");

            migrationBuilder.AddColumn<int>(
                name: "GutenbergId",
                table: "Book",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Page",
                table: "Page",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Page_Book_BookId",
                table: "Page",
                column: "BookId",
                principalTable: "Book",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Page_Book_BookId",
                table: "Page");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Page",
                table: "Page");

            migrationBuilder.DropColumn(
                name: "GutenbergId",
                table: "Book");

            migrationBuilder.RenameTable(
                name: "Page",
                newName: "Pages");

            migrationBuilder.RenameIndex(
                name: "IX_Page_BookId",
                table: "Pages",
                newName: "IX_Pages_BookId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Pages",
                table: "Pages",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Pages_Book_BookId",
                table: "Pages",
                column: "BookId",
                principalTable: "Book",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
