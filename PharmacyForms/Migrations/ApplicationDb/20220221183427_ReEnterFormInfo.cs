using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PharmacyForms.Migrations.ApplicationDb
{
    public partial class ReEnterFormInfo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "EndOfDay",
                columns: table => new
                {
                    Id = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    EntryDate = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    ModifyDate = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    Email = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Name = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    PharmacyName = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    GroupName = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ApprovedPatientCount = table.Column<double>(type: "double", nullable: false),
                    DeniedPatientCount = table.Column<double>(type: "double", nullable: false),
                    RxCount = table.Column<double>(type: "double", nullable: false),
                    HighCopayCount = table.Column<double>(type: "double", nullable: false),
                    InsuranceErrors = table.Column<double>(type: "double", nullable: false),
                    WrongDOBCount = table.Column<double>(type: "double", nullable: false),
                    NotContractedCount = table.Column<double>(type: "double", nullable: false),
                    WrongLastNameCount = table.Column<double>(type: "double", nullable: false),
                    InsuranceTerminatedCount = table.Column<double>(type: "double", nullable: false),
                    OtherExceptions = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    PatientExceptionCount = table.Column<double>(type: "double", nullable: false),
                    TotalExistingPatients = table.Column<double>(type: "double", nullable: false),
                    TransferredPatientCount = table.Column<double>(type: "double", nullable: false),
                    InsuranceAdjudications = table.Column<double>(type: "double", nullable: false),
                    Cogs = table.Column<double>(type: "double", nullable: false),
                    RxRefills = table.Column<double>(type: "double", nullable: false),
                    RefillAdjudications = table.Column<double>(type: "double", nullable: false),
                    RefillCogs = table.Column<double>(type: "double", nullable: false),
                    AlternativeAdjudications = table.Column<double>(type: "double", nullable: false),
                    AlternativeCogs = table.Column<double>(type: "double", nullable: false),
                    InternalTransfer = table.Column<double>(type: "double", nullable: false),
                    ExistingPatients = table.Column<double>(type: "double", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EndOfDay", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "PatientCounts",
                columns: table => new
                {
                    Id = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    EntryDate = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    ModifyDate = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    PharmacyName = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Email = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Name = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    TimeOfDay = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    PatientCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PatientCounts", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EndOfDay");

            migrationBuilder.DropTable(
                name: "PatientCounts");
        }
    }
}
