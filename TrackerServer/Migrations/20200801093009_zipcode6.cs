using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TrackerServer.Migrations
{
    public partial class zipcode6 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Addresses_ZipCode_ZipCodeId",
                table: "Addresses");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ZipCode",
                table: "ZipCode");

            migrationBuilder.RenameTable(
                name: "ZipCode",
                newName: "ZipCodes");

            migrationBuilder.AlterColumn<DateTime>(
                name: "FirstSigns",
                table: "Subjects",
                nullable: false,
                defaultValue: new DateTime(2020, 8, 1, 11, 30, 9, 244, DateTimeKind.Local).AddTicks(8983),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2020, 7, 30, 18, 3, 47, 986, DateTimeKind.Local).AddTicks(5337));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CoronaTest",
                table: "Subjects",
                nullable: false,
                defaultValue: new DateTime(2020, 8, 1, 11, 30, 9, 241, DateTimeKind.Local).AddTicks(6521),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2020, 7, 30, 18, 3, 47, 983, DateTimeKind.Local).AddTicks(3109));

            migrationBuilder.AddPrimaryKey(
                name: "PK_ZipCodes",
                table: "ZipCodes",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Addresses_ZipCodes_ZipCodeId",
                table: "Addresses",
                column: "ZipCodeId",
                principalTable: "ZipCodes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Addresses_ZipCodes_ZipCodeId",
                table: "Addresses");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ZipCodes",
                table: "ZipCodes");

            migrationBuilder.RenameTable(
                name: "ZipCodes",
                newName: "ZipCode");

            migrationBuilder.AlterColumn<DateTime>(
                name: "FirstSigns",
                table: "Subjects",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2020, 7, 30, 18, 3, 47, 986, DateTimeKind.Local).AddTicks(5337),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 8, 1, 11, 30, 9, 244, DateTimeKind.Local).AddTicks(8983));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CoronaTest",
                table: "Subjects",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2020, 7, 30, 18, 3, 47, 983, DateTimeKind.Local).AddTicks(3109),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 8, 1, 11, 30, 9, 241, DateTimeKind.Local).AddTicks(6521));

            migrationBuilder.AddPrimaryKey(
                name: "PK_ZipCode",
                table: "ZipCode",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Addresses_ZipCode_ZipCodeId",
                table: "Addresses",
                column: "ZipCodeId",
                principalTable: "ZipCode",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
