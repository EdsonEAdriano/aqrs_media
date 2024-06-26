using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace aqrsmedia.RegisterAPI.Migrations
{
    /// <inheritdoc />
    public partial class FixColumnsName : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Name",
                table: "t_rating",
                newName: "name");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "t_rating",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "t_participant",
                newName: "name");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "t_participant",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "t_media_type",
                newName: "name");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "t_media_type",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "t_media",
                newName: "name");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "t_media",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "t_genre",
                newName: "name");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "t_genre",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "t_category",
                newName: "name");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "t_category",
                newName: "id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "name",
                table: "t_rating",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "t_rating",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "name",
                table: "t_participant",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "t_participant",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "name",
                table: "t_media_type",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "t_media_type",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "name",
                table: "t_media",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "t_media",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "name",
                table: "t_genre",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "t_genre",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "name",
                table: "t_category",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "t_category",
                newName: "Id");
        }
    }
}
