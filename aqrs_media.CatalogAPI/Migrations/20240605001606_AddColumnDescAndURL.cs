using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace aqrsmedia.CatalogAPI.Migrations
{
    /// <inheritdoc />
    public partial class AddColumnDescAndURL : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "description",
                table: "t_catalog",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "media_url",
                table: "t_catalog",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "description",
                table: "t_catalog");

            migrationBuilder.DropColumn(
                name: "media_url",
                table: "t_catalog");
        }
    }
}
