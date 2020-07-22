using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TrackerServer.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Countries",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Countries", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Symptoms",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Fever = table.Column<bool>(nullable: false),
                    Fatigue = table.Column<bool>(nullable: false),
                    AdryCough = table.Column<bool>(nullable: false),
                    LossOfAppetite = table.Column<bool>(nullable: false),
                    ShortnessOfBreath = table.Column<bool>(nullable: false),
                    Mucus = table.Column<bool>(nullable: false),
                    ExtraInfo = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Symptoms", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Addresses",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Street = table.Column<string>(nullable: false),
                    Nr = table.Column<string>(nullable: false),
                    ZipCode = table.Column<string>(nullable: false),
                    City = table.Column<string>(nullable: false),
                    CountryId = table.Column<int>(nullable: true),
                    AddressOfPersonId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Addresses", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Addresses_Countries_CountryId",
                        column: x => x.CountryId,
                        principalTable: "Countries",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Person",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: false),
                    NationalNbr = table.Column<string>(nullable: true),
                    forName = table.Column<string>(nullable: false),
                    CountryId = table.Column<int>(nullable: true),
                    Email = table.Column<string>(nullable: false),
                    BirthDate = table.Column<DateTime>(nullable: false),
                    Job = table.Column<string>(nullable: true),
                    Relation = table.Column<int>(nullable: false),
                    CurrentPersonId = table.Column<int>(nullable: false),
                    PublicEventId = table.Column<int>(nullable: true),
                    PublicEventId1 = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Person", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Person_Countries_CountryId",
                        column: x => x.CountryId,
                        principalTable: "Countries",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Person_Person_CurrentPersonId",
                        column: x => x.CurrentPersonId,
                        principalTable: "Person",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Subjects",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    PersonId = table.Column<int>(nullable: true),
                    CoronatestPositive = table.Column<bool>(nullable: false, defaultValue: true),
                    CoronaTest = table.Column<DateTime>(nullable: false, defaultValue: new DateTime(2020, 7, 21, 19, 43, 32, 135, DateTimeKind.Local).AddTicks(306)),
                    SymtomsId = table.Column<int>(nullable: true),
                    FirstSigns = table.Column<DateTime>(nullable: false, defaultValue: new DateTime(2020, 7, 21, 19, 43, 32, 138, DateTimeKind.Local).AddTicks(1387)),
                    ExtraInformation = table.Column<string>(nullable: false),
                    StatusSubject = table.Column<int>(nullable: false),
                    DossierNr = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Subjects", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Subjects_Person_PersonId",
                        column: x => x.PersonId,
                        principalTable: "Person",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Subjects_Symptoms_SymtomsId",
                        column: x => x.SymtomsId,
                        principalTable: "Symptoms",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PublicEvents",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    NameEvent = table.Column<string>(nullable: false),
                    DateTimeEvent = table.Column<DateTime>(nullable: false),
                    TypeEvent = table.Column<int>(nullable: false),
                    Description = table.Column<string>(nullable: false),
                    Peoples = table.Column<int>(nullable: false),
                    PossibleGroundZeroBySubject = table.Column<bool>(nullable: false),
                    SubjectId = table.Column<int>(nullable: true),
                    SubjectId1 = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PublicEvents", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PublicEvents_Subjects_SubjectId",
                        column: x => x.SubjectId,
                        principalTable: "Subjects",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PublicEvents_Subjects_SubjectId1",
                        column: x => x.SubjectId1,
                        principalTable: "Subjects",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Addresses_AddressOfPersonId",
                table: "Addresses",
                column: "AddressOfPersonId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Addresses_CountryId",
                table: "Addresses",
                column: "CountryId");

            migrationBuilder.CreateIndex(
                name: "IX_Person_CountryId",
                table: "Person",
                column: "CountryId");

            migrationBuilder.CreateIndex(
                name: "IX_Person_CurrentPersonId",
                table: "Person",
                column: "CurrentPersonId");

            migrationBuilder.CreateIndex(
                name: "IX_Person_PublicEventId",
                table: "Person",
                column: "PublicEventId");

            migrationBuilder.CreateIndex(
                name: "IX_Person_PublicEventId1",
                table: "Person",
                column: "PublicEventId1");

            migrationBuilder.CreateIndex(
                name: "IX_PublicEvents_SubjectId",
                table: "PublicEvents",
                column: "SubjectId");

            migrationBuilder.CreateIndex(
                name: "IX_PublicEvents_SubjectId1",
                table: "PublicEvents",
                column: "SubjectId1");

            migrationBuilder.CreateIndex(
                name: "IX_Subjects_PersonId",
                table: "Subjects",
                column: "PersonId");

            migrationBuilder.CreateIndex(
                name: "IX_Subjects_SymtomsId",
                table: "Subjects",
                column: "SymtomsId");

            migrationBuilder.AddForeignKey(
                name: "FK_Addresses_Person_AddressOfPersonId",
                table: "Addresses",
                column: "AddressOfPersonId",
                principalTable: "Person",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Person_PublicEvents_PublicEventId",
                table: "Person",
                column: "PublicEventId",
                principalTable: "PublicEvents",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Person_PublicEvents_PublicEventId1",
                table: "Person",
                column: "PublicEventId1",
                principalTable: "PublicEvents",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Subjects_Person_PersonId",
                table: "Subjects");

            migrationBuilder.DropTable(
                name: "Addresses");

            migrationBuilder.DropTable(
                name: "Person");

            migrationBuilder.DropTable(
                name: "Countries");

            migrationBuilder.DropTable(
                name: "PublicEvents");

            migrationBuilder.DropTable(
                name: "Subjects");

            migrationBuilder.DropTable(
                name: "Symptoms");
        }
    }
}
