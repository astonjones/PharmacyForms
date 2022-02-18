using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PharmacyForms.Migrations.ApplicationDb
{
    public partial class ChangeEODReport : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ExistingPatientCount",
                table: "EndOfDay",
                newName: "TotalExistingPatients");

            migrationBuilder.AddColumn<double>(
                name: "ExistingPatients",
                table: "EndOfDay",
                type: "double",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "InternalTransfer",
                table: "EndOfDay",
                type: "double",
                nullable: false,
                defaultValue: 0.0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ExistingPatients",
                table: "EndOfDay");

            migrationBuilder.DropColumn(
                name: "InternalTransfer",
                table: "EndOfDay");

            migrationBuilder.RenameColumn(
                name: "TotalExistingPatients",
                table: "EndOfDay",
                newName: "ExistingPatientCount");
        }
    }
}
