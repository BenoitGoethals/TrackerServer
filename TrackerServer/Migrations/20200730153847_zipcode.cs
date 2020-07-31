using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TrackerServer.Migrations
{
    public partial class zipcode : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ZipCode",
                table: "Addresses");

            migrationBuilder.AlterColumn<DateTime>(
                name: "FirstSigns",
                table: "Subjects",
                nullable: false,
                defaultValue: new DateTime(2020, 7, 30, 17, 38, 46, 978, DateTimeKind.Local).AddTicks(4982),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2020, 7, 22, 12, 36, 33, 398, DateTimeKind.Local).AddTicks(8407));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CoronaTest",
                table: "Subjects",
                nullable: false,
                defaultValue: new DateTime(2020, 7, 30, 17, 38, 46, 974, DateTimeKind.Local).AddTicks(8825),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2020, 7, 22, 12, 36, 33, 395, DateTimeKind.Local).AddTicks(5892));

            migrationBuilder.AddColumn<int>(
                name: "ZipCodeId",
                table: "Addresses",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "ZipCode",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Code = table.Column<string>(nullable: false),
                    City = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ZipCode", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Addresses_ZipCodeId",
                table: "Addresses",
                column: "ZipCodeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Addresses_ZipCode_ZipCodeId",
                table: "Addresses",
                column: "ZipCodeId",
                principalTable: "ZipCode",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Addresses_ZipCode_ZipCodeId",
                table: "Addresses");

            migrationBuilder.DropTable(
                name: "ZipCode");

            migrationBuilder.DropIndex(
                name: "IX_Addresses_ZipCodeId",
                table: "Addresses");

            migrationBuilder.DropColumn(
                name: "ZipCodeId",
                table: "Addresses");

            migrationBuilder.AlterColumn<DateTime>(
                name: "FirstSigns",
                table: "Subjects",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2020, 7, 22, 12, 36, 33, 398, DateTimeKind.Local).AddTicks(8407),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 7, 30, 17, 38, 46, 978, DateTimeKind.Local).AddTicks(4982));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CoronaTest",
                table: "Subjects",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2020, 7, 22, 12, 36, 33, 395, DateTimeKind.Local).AddTicks(5892),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 7, 30, 17, 38, 46, 974, DateTimeKind.Local).AddTicks(8825));

            migrationBuilder.AddColumn<string>(
                name: "ZipCode",
                table: "Addresses",
                type: "longtext CHARACTER SET utf8mb4",
                nullable: false,
                defaultValue: "");
        }
    }
}
