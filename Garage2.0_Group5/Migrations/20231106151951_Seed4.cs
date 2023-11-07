using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Garage2._0_Group5.Migrations
{
    /// <inheritdoc />
    public partial class Seed4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "ParkedVehicle",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "TimeAtCheckIn", "TimeAtCheckOut" },
                values: new object[] { new DateTime(2023, 11, 6, 15, 19, 51, 590, DateTimeKind.Utc).AddTicks(4314), new DateTime(2023, 11, 6, 15, 19, 51, 590, DateTimeKind.Utc).AddTicks(4314) });

            migrationBuilder.UpdateData(
                table: "ParkedVehicle",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "TimeAtCheckIn", "TimeAtCheckOut" },
                values: new object[] { new DateTime(2023, 11, 6, 15, 19, 51, 590, DateTimeKind.Utc).AddTicks(4319), new DateTime(2023, 11, 6, 15, 19, 51, 590, DateTimeKind.Utc).AddTicks(4319) });

            migrationBuilder.UpdateData(
                table: "ParkedVehicle",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "TimeAtCheckIn", "TimeAtCheckOut", "VehicleType" },
                values: new object[] { new DateTime(2023, 11, 6, 15, 19, 51, 590, DateTimeKind.Utc).AddTicks(4321), new DateTime(2023, 11, 6, 15, 19, 51, 590, DateTimeKind.Utc).AddTicks(4321), 2 });

            migrationBuilder.UpdateData(
                table: "ParkedVehicle",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "TimeAtCheckIn", "TimeAtCheckOut", "VehicleType" },
                values: new object[] { new DateTime(2023, 11, 6, 15, 19, 51, 590, DateTimeKind.Utc).AddTicks(4323), new DateTime(2023, 11, 6, 15, 19, 51, 590, DateTimeKind.Utc).AddTicks(4324), 3 });

            migrationBuilder.UpdateData(
                table: "ParkedVehicle",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "TimeAtCheckIn", "TimeAtCheckOut" },
                values: new object[] { new DateTime(2023, 11, 6, 15, 19, 51, 590, DateTimeKind.Utc).AddTicks(4325), new DateTime(2023, 11, 6, 15, 19, 51, 590, DateTimeKind.Utc).AddTicks(4326) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "ParkedVehicle",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "TimeAtCheckIn", "TimeAtCheckOut" },
                values: new object[] { new DateTime(2023, 11, 6, 15, 12, 11, 227, DateTimeKind.Utc).AddTicks(9863), new DateTime(2023, 11, 6, 15, 12, 11, 227, DateTimeKind.Utc).AddTicks(9863) });

            migrationBuilder.UpdateData(
                table: "ParkedVehicle",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "TimeAtCheckIn", "TimeAtCheckOut" },
                values: new object[] { new DateTime(2023, 11, 6, 15, 12, 11, 227, DateTimeKind.Utc).AddTicks(9867), new DateTime(2023, 11, 6, 15, 12, 11, 227, DateTimeKind.Utc).AddTicks(9867) });

            migrationBuilder.UpdateData(
                table: "ParkedVehicle",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "TimeAtCheckIn", "TimeAtCheckOut", "VehicleType" },
                values: new object[] { new DateTime(2023, 11, 6, 15, 12, 11, 227, DateTimeKind.Utc).AddTicks(9869), new DateTime(2023, 11, 6, 15, 12, 11, 227, DateTimeKind.Utc).AddTicks(9870), 3 });

            migrationBuilder.UpdateData(
                table: "ParkedVehicle",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "TimeAtCheckIn", "TimeAtCheckOut", "VehicleType" },
                values: new object[] { new DateTime(2023, 11, 6, 15, 12, 11, 227, DateTimeKind.Utc).AddTicks(9871), new DateTime(2023, 11, 6, 15, 12, 11, 227, DateTimeKind.Utc).AddTicks(9872), 2 });

            migrationBuilder.UpdateData(
                table: "ParkedVehicle",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "TimeAtCheckIn", "TimeAtCheckOut" },
                values: new object[] { new DateTime(2023, 11, 6, 15, 12, 11, 227, DateTimeKind.Utc).AddTicks(9873), new DateTime(2023, 11, 6, 15, 12, 11, 227, DateTimeKind.Utc).AddTicks(9874) });
        }
    }
}
