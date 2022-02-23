using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PharmacyForms.Migrations.ApplicationDb
{
    public partial class NewChangetoEODModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<double>(
                name: "AlternativeRefillPatients",
                table: "EndOfDay",
                type: "double",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "ExistingPatientAdjudications",
                table: "EndOfDay",
                type: "double",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "TransferredInAdjudications",
                table: "EndOfDay",
                type: "double",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "TransferredInPatientCount",
                table: "EndOfDay",
                type: "double",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "TransferredOutPatientCount",
                table: "EndOfDay",
                type: "double",
                nullable: false,
                defaultValue: 0.0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AlternativeRefillPatients",
                table: "EndOfDay");

            migrationBuilder.DropColumn(
                name: "ExistingPatientAdjudications",
                table: "EndOfDay");

            migrationBuilder.DropColumn(
                name: "TransferredInAdjudications",
                table: "EndOfDay");

            migrationBuilder.DropColumn(
                name: "TransferredInPatientCount",
                table: "EndOfDay");

            migrationBuilder.DropColumn(
                name: "TransferredOutPatientCount",
                table: "EndOfDay");
        }
    }
}
