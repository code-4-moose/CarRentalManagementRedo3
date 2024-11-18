using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CarRentalManagement.Migrations
{
    /// <inheritdoc />
    public partial class SeedUserRole : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "ad2bcf0c-20db-474f-8407-5a6b159518ba", null, "Administrator", "ADMINISTRATOR" },
                    { "bd2bcf0c-20db-474f-8407-5a6b159518bb", null, "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "3781efa7-66dc-47f0-860f-e506d04102e4", 0, "fbfd0279-3345-46a3-b896-fe4ec47a7a31", "admin@localhost.com", true, "Admin", "User", false, null, "ADMIN@LOCALHOST.COM", "ADMIN@LOCALHOST.COM", "AQAAAAIAAYagAAAAEBA0p7jQSMGXcnRAwrP5ciEVDNtwG58ojek92OFJ9nd6Qv6hSLkjf6mGwFx+4ELlLw==", null, false, "7d8ade21-e4b7-484d-a747-1cf99d2f7a45", false, "admin@localhost.com" });

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 18, 16, 44, 11, 711, DateTimeKind.Local).AddTicks(3282), new DateTime(2024, 11, 18, 16, 44, 11, 711, DateTimeKind.Local).AddTicks(3298) });

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 18, 16, 44, 11, 711, DateTimeKind.Local).AddTicks(3302), new DateTime(2024, 11, 18, 16, 44, 11, 711, DateTimeKind.Local).AddTicks(3304) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 18, 16, 44, 11, 711, DateTimeKind.Local).AddTicks(3727), new DateTime(2024, 11, 18, 16, 44, 11, 711, DateTimeKind.Local).AddTicks(3729) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 18, 16, 44, 11, 711, DateTimeKind.Local).AddTicks(3732), new DateTime(2024, 11, 18, 16, 44, 11, 711, DateTimeKind.Local).AddTicks(3733) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 18, 16, 44, 11, 711, DateTimeKind.Local).AddTicks(3916), new DateTime(2024, 11, 18, 16, 44, 11, 711, DateTimeKind.Local).AddTicks(3917) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 18, 16, 44, 11, 711, DateTimeKind.Local).AddTicks(3920), new DateTime(2024, 11, 18, 16, 44, 11, 711, DateTimeKind.Local).AddTicks(3922) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 18, 16, 44, 11, 711, DateTimeKind.Local).AddTicks(3924), new DateTime(2024, 11, 18, 16, 44, 11, 711, DateTimeKind.Local).AddTicks(3926) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 18, 16, 44, 11, 711, DateTimeKind.Local).AddTicks(3928), new DateTime(2024, 11, 18, 16, 44, 11, 711, DateTimeKind.Local).AddTicks(3929) });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "ad2bcf0c-20db-474f-8407-5a6b159518ba", "3781efa7-66dc-47f0-860f-e506d04102e4" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bd2bcf0c-20db-474f-8407-5a6b159518bb");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "ad2bcf0c-20db-474f-8407-5a6b159518ba", "3781efa7-66dc-47f0-860f-e506d04102e4" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ad2bcf0c-20db-474f-8407-5a6b159518ba");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4");

            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "AspNetUsers");

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 18, 16, 27, 47, 351, DateTimeKind.Local).AddTicks(4340), new DateTime(2024, 11, 18, 16, 27, 47, 351, DateTimeKind.Local).AddTicks(4352) });

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 18, 16, 27, 47, 351, DateTimeKind.Local).AddTicks(4354), new DateTime(2024, 11, 18, 16, 27, 47, 351, DateTimeKind.Local).AddTicks(4355) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 18, 16, 27, 47, 351, DateTimeKind.Local).AddTicks(4575), new DateTime(2024, 11, 18, 16, 27, 47, 351, DateTimeKind.Local).AddTicks(4576) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 18, 16, 27, 47, 351, DateTimeKind.Local).AddTicks(4578), new DateTime(2024, 11, 18, 16, 27, 47, 351, DateTimeKind.Local).AddTicks(4579) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 18, 16, 27, 47, 351, DateTimeKind.Local).AddTicks(4690), new DateTime(2024, 11, 18, 16, 27, 47, 351, DateTimeKind.Local).AddTicks(4691) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 18, 16, 27, 47, 351, DateTimeKind.Local).AddTicks(4693), new DateTime(2024, 11, 18, 16, 27, 47, 351, DateTimeKind.Local).AddTicks(4693) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 18, 16, 27, 47, 351, DateTimeKind.Local).AddTicks(4694), new DateTime(2024, 11, 18, 16, 27, 47, 351, DateTimeKind.Local).AddTicks(4695) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 18, 16, 27, 47, 351, DateTimeKind.Local).AddTicks(4696), new DateTime(2024, 11, 18, 16, 27, 47, 351, DateTimeKind.Local).AddTicks(4697) });
        }
    }
}
