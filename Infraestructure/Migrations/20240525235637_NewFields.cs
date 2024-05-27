using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infraestructure.Migrations
{
    /// <inheritdoc />
    public partial class NewFields : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "PostDate",
                table: "Gotcha",
                newName: "CreationDate");

            migrationBuilder.RenameColumn(
                name: "Description",
                table: "Gotcha",
                newName: "Content");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "CreationDate",
                table: "Gotcha",
                newName: "PostDate");

            migrationBuilder.RenameColumn(
                name: "Content",
                table: "Gotcha",
                newName: "Description");
        }
    }
}
