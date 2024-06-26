using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace aqrsmedia.RegisterAPI.Migrations
{
    /// <inheritdoc />
    public partial class AddDefaultData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "t_category",
                columns: new[] { "id", "created_date", "inactivated_date", "name" },
                values: new object[] { new Guid("c313fa89-0025-4d9d-bbd9-d83b29ad72df"), new DateTime(2024, 6, 7, 19, 53, 2, 412, DateTimeKind.Local).AddTicks(3104), null, "Category 1" });

            migrationBuilder.InsertData(
                table: "t_genre",
                columns: new[] { "id", "created_date", "inactivated_date", "name" },
                values: new object[] { new Guid("db1d5df5-8176-4032-be18-9b3329dc16e9"), new DateTime(2024, 6, 7, 19, 53, 2, 412, DateTimeKind.Local).AddTicks(3091), null, "Genre 1" });

            migrationBuilder.InsertData(
                table: "t_media",
                columns: new[] { "id", "created_date", "inactivated_date", "name" },
                values: new object[] { new Guid("c427b2e1-deeb-45cd-9b84-1d66f90bcb75"), new DateTime(2024, 6, 7, 19, 53, 2, 412, DateTimeKind.Local).AddTicks(2973), null, "Media 1" });

            migrationBuilder.InsertData(
                table: "t_media_type",
                columns: new[] { "id", "created_date", "inactivated_date", "name" },
                values: new object[] { new Guid("ce6875b7-efcb-4da3-bd0e-7813fbd1c479"), new DateTime(2024, 6, 7, 19, 53, 2, 412, DateTimeKind.Local).AddTicks(3114), null, "MediaType 1" });

            migrationBuilder.InsertData(
                table: "t_participant",
                columns: new[] { "id", "created_date", "inactivated_date", "name" },
                values: new object[,]
                {
                    { new Guid("537f6d12-6d9e-4a82-ae1e-ce734eea6c70"), new DateTime(2024, 6, 7, 19, 53, 2, 412, DateTimeKind.Local).AddTicks(3125), null, "Participant 2" },
                    { new Guid("c0d8deac-b6b9-489b-b6e3-afab399ed3a5"), new DateTime(2024, 6, 7, 19, 53, 2, 412, DateTimeKind.Local).AddTicks(3123), null, "Participant 1" }
                });

            migrationBuilder.InsertData(
                table: "t_rating",
                columns: new[] { "id", "created_date", "inactivated_date", "name" },
                values: new object[] { new Guid("fb923c80-e9f7-4098-b8d6-5ebc2dd32315"), new DateTime(2024, 6, 7, 19, 53, 2, 412, DateTimeKind.Local).AddTicks(3135), null, "Rating 1" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "t_category",
                keyColumn: "id",
                keyValue: new Guid("c313fa89-0025-4d9d-bbd9-d83b29ad72df"));

            migrationBuilder.DeleteData(
                table: "t_genre",
                keyColumn: "id",
                keyValue: new Guid("db1d5df5-8176-4032-be18-9b3329dc16e9"));

            migrationBuilder.DeleteData(
                table: "t_media",
                keyColumn: "id",
                keyValue: new Guid("c427b2e1-deeb-45cd-9b84-1d66f90bcb75"));

            migrationBuilder.DeleteData(
                table: "t_media_type",
                keyColumn: "id",
                keyValue: new Guid("ce6875b7-efcb-4da3-bd0e-7813fbd1c479"));

            migrationBuilder.DeleteData(
                table: "t_participant",
                keyColumn: "id",
                keyValue: new Guid("537f6d12-6d9e-4a82-ae1e-ce734eea6c70"));

            migrationBuilder.DeleteData(
                table: "t_participant",
                keyColumn: "id",
                keyValue: new Guid("c0d8deac-b6b9-489b-b6e3-afab399ed3a5"));

            migrationBuilder.DeleteData(
                table: "t_rating",
                keyColumn: "id",
                keyValue: new Guid("fb923c80-e9f7-4098-b8d6-5ebc2dd32315"));
        }
    }
}
