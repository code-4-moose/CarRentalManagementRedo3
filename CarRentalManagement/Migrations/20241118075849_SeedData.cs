using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CarRentalManagement.Migrations
{
    /// <inheritdoc />
    public partial class SeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Colour",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2024, 11, 18, 15, 58, 48, 728, DateTimeKind.Local).AddTicks(6519), new DateTime(2024, 11, 18, 15, 58, 48, 728, DateTimeKind.Local).AddTicks(6535), "Black", "System" },
                    { 2, "System", new DateTime(2024, 11, 18, 15, 58, 48, 728, DateTimeKind.Local).AddTicks(6538), new DateTime(2024, 11, 18, 15, 58, 48, 728, DateTimeKind.Local).AddTicks(6539), "Blue", "System" }
                });

            migrationBuilder.InsertData(
                table: "Make",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2024, 11, 18, 15, 58, 48, 728, DateTimeKind.Local).AddTicks(6725), new DateTime(2024, 11, 18, 15, 58, 48, 728, DateTimeKind.Local).AddTicks(6726), "BMW", "System" },
                    { 2, "System", new DateTime(2024, 11, 18, 15, 58, 48, 728, DateTimeKind.Local).AddTicks(6728), new DateTime(2024, 11, 18, 15, 58, 48, 728, DateTimeKind.Local).AddTicks(6728), "Toyota", "System" }
                });

            migrationBuilder.InsertData(
                table: "Model",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2024, 11, 18, 15, 58, 48, 728, DateTimeKind.Local).AddTicks(6815), new DateTime(2024, 11, 18, 15, 58, 48, 728, DateTimeKind.Local).AddTicks(6816), "i4", "System" },
                    { 2, "System", new DateTime(2024, 11, 18, 15, 58, 48, 728, DateTimeKind.Local).AddTicks(6818), new DateTime(2024, 11, 18, 15, 58, 48, 728, DateTimeKind.Local).AddTicks(6818), "X5", "System" },
                    { 3, "System", new DateTime(2024, 11, 18, 15, 58, 48, 728, DateTimeKind.Local).AddTicks(6819), new DateTime(2024, 11, 18, 15, 58, 48, 728, DateTimeKind.Local).AddTicks(6820), "Prius", "System" },
                    { 4, "System", new DateTime(2024, 11, 18, 15, 58, 48, 728, DateTimeKind.Local).AddTicks(6821), new DateTime(2024, 11, 18, 15, 58, 48, 728, DateTimeKind.Local).AddTicks(6821), "C-HRSS", "System" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 4);
        }
    }
}
