using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace aqrsmedia.CatalogAPI.Migrations
{
    /// <inheritdoc />
    public partial class FixColumnsName : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Id",
                table: "t_catalog",
                newName: "id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "id",
                table: "t_catalog",
                newName: "Id");
        }
    }
}
