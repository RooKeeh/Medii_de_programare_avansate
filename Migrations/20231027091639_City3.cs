using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Moldovan_Andrei_Lab1.Migrations
{
    /// <inheritdoc />
    public partial class City3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ID",
                table: "City",
                newName: "CityID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "CityID",
                table: "City",
                newName: "ID");
        }
    }
}
