using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Garage2._0_Group5.Migrations
{
    /// <inheritdoc />
    public partial class Seed2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "NumberOfWheels",
                table: "ParkedVehicle",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.UpdateData(
                table: "ParkedVehicle",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "NumberOfWheels", "TimeAtCheckIn" },
                values: new object[] { null, new DateTime(2023, 11, 6, 14, 52, 31, 142, DateTimeKind.Utc).AddTicks(2052) });

            migrationBuilder.UpdateData(
                table: "ParkedVehicle",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "NumberOfWheels", "TimeAtCheckIn" },
                values: new object[] { null, new DateTime(2023, 11, 6, 14, 52, 31, 142, DateTimeKind.Utc).AddTicks(2056) });

            migrationBuilder.UpdateData(
                table: "ParkedVehicle",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "NumberOfWheels", "TimeAtCheckIn" },
                values: new object[] { null, new DateTime(2023, 11, 6, 14, 52, 31, 142, DateTimeKind.Utc).AddTicks(2057) });

            migrationBuilder.UpdateData(
                table: "ParkedVehicle",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "NumberOfWheels", "TimeAtCheckIn" },
                values: new object[] { null, new DateTime(2023, 11, 6, 14, 52, 31, 142, DateTimeKind.Utc).AddTicks(2058) });

            migrationBuilder.UpdateData(
                table: "ParkedVehicle",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "NumberOfWheels", "TimeAtCheckIn" },
                values: new object[] { null, new DateTime(2023, 11, 6, 14, 52, 31, 142, DateTimeKind.Utc).AddTicks(2059) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "NumberOfWheels",
                table: "ParkedVehicle",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "ParkedVehicle",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "NumberOfWheels", "TimeAtCheckIn" },
                values: new object[] { 0, new DateTime(2023, 11, 6, 13, 58, 25, 988, DateTimeKind.Utc).AddTicks(6773) });

            migrationBuilder.UpdateData(
                table: "ParkedVehicle",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "NumberOfWheels", "TimeAtCheckIn" },
                values: new object[] { 0, new DateTime(2023, 11, 6, 13, 58, 25, 988, DateTimeKind.Utc).AddTicks(6776) });

            migrationBuilder.UpdateData(
                table: "ParkedVehicle",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "NumberOfWheels", "TimeAtCheckIn" },
                values: new object[] { 0, new DateTime(2023, 11, 6, 13, 58, 25, 988, DateTimeKind.Utc).AddTicks(6777) });

            migrationBuilder.UpdateData(
                table: "ParkedVehicle",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "NumberOfWheels", "TimeAtCheckIn" },
                values: new object[] { 0, new DateTime(2023, 11, 6, 13, 58, 25, 988, DateTimeKind.Utc).AddTicks(6778) });

            migrationBuilder.UpdateData(
                table: "ParkedVehicle",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "NumberOfWheels", "TimeAtCheckIn" },
                values: new object[] { 0, new DateTime(2023, 11, 6, 13, 58, 25, 988, DateTimeKind.Utc).AddTicks(6779) });
        }
    }
}
