using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Garage2._0_Group5.Migrations
{
    /// <inheritdoc />
    public partial class Seed3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "ParkedVehicle",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Color", "TimeAtCheckIn", "TimeAtCheckOut", "VehicleModel" },
                values: new object[] { "", new DateTime(2023, 11, 6, 15, 12, 11, 227, DateTimeKind.Utc).AddTicks(9863), new DateTime(2023, 11, 6, 15, 12, 11, 227, DateTimeKind.Utc).AddTicks(9863), "" });

            migrationBuilder.UpdateData(
                table: "ParkedVehicle",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Color", "TimeAtCheckIn", "TimeAtCheckOut", "VehicleModel" },
                values: new object[] { "", new DateTime(2023, 11, 6, 15, 12, 11, 227, DateTimeKind.Utc).AddTicks(9867), new DateTime(2023, 11, 6, 15, 12, 11, 227, DateTimeKind.Utc).AddTicks(9867), "" });

            migrationBuilder.UpdateData(
                table: "ParkedVehicle",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Color", "TimeAtCheckIn", "TimeAtCheckOut", "VehicleModel" },
                values: new object[] { "", new DateTime(2023, 11, 6, 15, 12, 11, 227, DateTimeKind.Utc).AddTicks(9869), new DateTime(2023, 11, 6, 15, 12, 11, 227, DateTimeKind.Utc).AddTicks(9870), "" });

            migrationBuilder.UpdateData(
                table: "ParkedVehicle",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Color", "TimeAtCheckIn", "TimeAtCheckOut", "VehicleModel" },
                values: new object[] { "", new DateTime(2023, 11, 6, 15, 12, 11, 227, DateTimeKind.Utc).AddTicks(9871), new DateTime(2023, 11, 6, 15, 12, 11, 227, DateTimeKind.Utc).AddTicks(9872), "" });

            migrationBuilder.UpdateData(
                table: "ParkedVehicle",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Color", "TimeAtCheckIn", "TimeAtCheckOut", "VehicleModel" },
                values: new object[] { "", new DateTime(2023, 11, 6, 15, 12, 11, 227, DateTimeKind.Utc).AddTicks(9873), new DateTime(2023, 11, 6, 15, 12, 11, 227, DateTimeKind.Utc).AddTicks(9874), "" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "ParkedVehicle",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Color", "TimeAtCheckIn", "TimeAtCheckOut", "VehicleModel" },
                values: new object[] { null, new DateTime(2023, 11, 6, 14, 52, 31, 142, DateTimeKind.Utc).AddTicks(2052), null, null });

            migrationBuilder.UpdateData(
                table: "ParkedVehicle",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Color", "TimeAtCheckIn", "TimeAtCheckOut", "VehicleModel" },
                values: new object[] { null, new DateTime(2023, 11, 6, 14, 52, 31, 142, DateTimeKind.Utc).AddTicks(2056), null, null });

            migrationBuilder.UpdateData(
                table: "ParkedVehicle",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Color", "TimeAtCheckIn", "TimeAtCheckOut", "VehicleModel" },
                values: new object[] { null, new DateTime(2023, 11, 6, 14, 52, 31, 142, DateTimeKind.Utc).AddTicks(2057), null, null });

            migrationBuilder.UpdateData(
                table: "ParkedVehicle",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Color", "TimeAtCheckIn", "TimeAtCheckOut", "VehicleModel" },
                values: new object[] { null, new DateTime(2023, 11, 6, 14, 52, 31, 142, DateTimeKind.Utc).AddTicks(2058), null, null });

            migrationBuilder.UpdateData(
                table: "ParkedVehicle",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Color", "TimeAtCheckIn", "TimeAtCheckOut", "VehicleModel" },
                values: new object[] { null, new DateTime(2023, 11, 6, 14, 52, 31, 142, DateTimeKind.Utc).AddTicks(2059), null, null });
        }
    }
}
