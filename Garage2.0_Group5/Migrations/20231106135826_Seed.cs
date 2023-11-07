using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Garage2._0_Group5.Migrations
{
    /// <inheritdoc />
    public partial class Seed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "ParkedVehicle",
                columns: new[] { "Id", "Color", "NumberOfWheels", "RegistrationNumber", "TimeAtCheckIn", "TimeAtCheckOut", "VehicleBrand", "VehicleModel", "VehicleType" },
                values: new object[,]
                {
                    { 1, null, 0, "", new DateTime(2023, 11, 6, 13, 58, 25, 988, DateTimeKind.Utc).AddTicks(6773), null, 0, null, 0 },
                    { 2, null, 0, "", new DateTime(2023, 11, 6, 13, 58, 25, 988, DateTimeKind.Utc).AddTicks(6776), null, 1, null, 1 },
                    { 3, null, 0, "", new DateTime(2023, 11, 6, 13, 58, 25, 988, DateTimeKind.Utc).AddTicks(6777), null, 2, null, 3 },
                    { 4, null, 0, "", new DateTime(2023, 11, 6, 13, 58, 25, 988, DateTimeKind.Utc).AddTicks(6778), null, 3, null, 2 },
                    { 5, null, 0, "", new DateTime(2023, 11, 6, 13, 58, 25, 988, DateTimeKind.Utc).AddTicks(6779), null, 4, null, 4 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ParkedVehicle",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "ParkedVehicle",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "ParkedVehicle",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "ParkedVehicle",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "ParkedVehicle",
                keyColumn: "Id",
                keyValue: 5);
        }
    }
}
