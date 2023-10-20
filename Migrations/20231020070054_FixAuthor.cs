using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Moldovan_Andrei_Lab1.Migrations
{
    /// <inheritdoc />
    public partial class FixAuthor : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ID",
                table: "Author",
                newName: "AuthorID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "AuthorID",
                table: "Author",
                newName: "ID");
        }
    }
}
