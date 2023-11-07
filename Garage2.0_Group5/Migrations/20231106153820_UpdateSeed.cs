using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Garage2._0_Group5.Migrations
{
    /// <inheritdoc />
    public partial class UpdateSeed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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
                columns: new[] { "NumberOfWheels", "TimeAtCheckIn", "TimeAtCheckOut" },
                values: new object[] { 4, new DateTime(2023, 11, 6, 15, 38, 20, 531, DateTimeKind.Utc).AddTicks(62), new DateTime(2023, 11, 6, 15, 38, 20, 531, DateTimeKind.Utc).AddTicks(62) });

            migrationBuilder.UpdateData(
                table: "ParkedVehicle",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "NumberOfWheels", "TimeAtCheckIn", "TimeAtCheckOut" },
                values: new object[] { 3, new DateTime(2023, 11, 6, 15, 38, 20, 531, DateTimeKind.Utc).AddTicks(67), new DateTime(2023, 11, 6, 15, 38, 20, 531, DateTimeKind.Utc).AddTicks(67) });

            migrationBuilder.UpdateData(
                table: "ParkedVehicle",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "NumberOfWheels", "TimeAtCheckIn", "TimeAtCheckOut" },
                values: new object[] { 2, new DateTime(2023, 11, 6, 15, 38, 20, 531, DateTimeKind.Utc).AddTicks(69), new DateTime(2023, 11, 6, 15, 38, 20, 531, DateTimeKind.Utc).AddTicks(70) });

            migrationBuilder.UpdateData(
                table: "ParkedVehicle",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "NumberOfWheels", "TimeAtCheckIn", "TimeAtCheckOut" },
                values: new object[] { 2, new DateTime(2023, 11, 6, 15, 38, 20, 531, DateTimeKind.Utc).AddTicks(72), new DateTime(2023, 11, 6, 15, 38, 20, 531, DateTimeKind.Utc).AddTicks(72) });

            migrationBuilder.UpdateData(
                table: "ParkedVehicle",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "NumberOfWheels", "TimeAtCheckIn", "TimeAtCheckOut" },
                values: new object[] { 1, new DateTime(2023, 11, 6, 15, 38, 20, 531, DateTimeKind.Utc).AddTicks(74), new DateTime(2023, 11, 6, 15, 38, 20, 531, DateTimeKind.Utc).AddTicks(74) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
                columns: new[] { "NumberOfWheels", "TimeAtCheckIn", "TimeAtCheckOut" },
                values: new object[] { null, new DateTime(2023, 11, 6, 15, 19, 51, 590, DateTimeKind.Utc).AddTicks(4314), new DateTime(2023, 11, 6, 15, 19, 51, 590, DateTimeKind.Utc).AddTicks(4314) });

            migrationBuilder.UpdateData(
                table: "ParkedVehicle",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "NumberOfWheels", "TimeAtCheckIn", "TimeAtCheckOut" },
                values: new object[] { null, new DateTime(2023, 11, 6, 15, 19, 51, 590, DateTimeKind.Utc).AddTicks(4319), new DateTime(2023, 11, 6, 15, 19, 51, 590, DateTimeKind.Utc).AddTicks(4319) });

            migrationBuilder.UpdateData(
                table: "ParkedVehicle",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "NumberOfWheels", "TimeAtCheckIn", "TimeAtCheckOut" },
                values: new object[] { null, new DateTime(2023, 11, 6, 15, 19, 51, 590, DateTimeKind.Utc).AddTicks(4321), new DateTime(2023, 11, 6, 15, 19, 51, 590, DateTimeKind.Utc).AddTicks(4321) });

            migrationBuilder.UpdateData(
                table: "ParkedVehicle",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "NumberOfWheels", "TimeAtCheckIn", "TimeAtCheckOut" },
                values: new object[] { null, new DateTime(2023, 11, 6, 15, 19, 51, 590, DateTimeKind.Utc).AddTicks(4323), new DateTime(2023, 11, 6, 15, 19, 51, 590, DateTimeKind.Utc).AddTicks(4324) });

            migrationBuilder.UpdateData(
                table: "ParkedVehicle",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "NumberOfWheels", "TimeAtCheckIn", "TimeAtCheckOut" },
                values: new object[] { null, new DateTime(2023, 11, 6, 15, 19, 51, 590, DateTimeKind.Utc).AddTicks(4325), new DateTime(2023, 11, 6, 15, 19, 51, 590, DateTimeKind.Utc).AddTicks(4326) });
        }
    }
}
