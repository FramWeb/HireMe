using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HireMeApi.Data.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "IotDevices",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Description = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IotDevices", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "IotDevices",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[] { new Guid("0241c522-260c-4342-a99e-d4b375f9c2ee"), null, "Device 10" });

            migrationBuilder.InsertData(
                table: "IotDevices",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[] { new Guid("03ed13c4-9e7c-4b74-9d8b-b88c63b8feb6"), null, "Device 6" });

            migrationBuilder.InsertData(
                table: "IotDevices",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[] { new Guid("1118aff0-b4be-40bc-a1c5-03cf037927a8"), null, "Device 9" });

            migrationBuilder.InsertData(
                table: "IotDevices",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[] { new Guid("22147ae1-60ec-4bcb-a601-bc133d5a8c8c"), null, "Device 8" });

            migrationBuilder.InsertData(
                table: "IotDevices",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[] { new Guid("34357646-4c66-4f48-b9ef-55a112d2564a"), null, "Device 5" });

            migrationBuilder.InsertData(
                table: "IotDevices",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[] { new Guid("4c1c23cd-cf06-4d5f-9491-a1733651ea7a"), null, "Device 7" });

            migrationBuilder.InsertData(
                table: "IotDevices",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[] { new Guid("716b049d-ea56-4be9-beb4-872e92309e08"), null, "Device 1" });

            migrationBuilder.InsertData(
                table: "IotDevices",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[] { new Guid("740ed1aa-24d6-47f7-89f4-918833c93d94"), null, "Device 2" });

            migrationBuilder.InsertData(
                table: "IotDevices",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[] { new Guid("8d824a3a-5c14-4d0e-9f6d-8e2f3f8eac44"), null, "Device 3" });

            migrationBuilder.InsertData(
                table: "IotDevices",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[] { new Guid("997bfeb4-fc99-4cae-9b5a-5fd194ebd302"), null, "Device 4" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "IotDevices");
        }
    }
}
