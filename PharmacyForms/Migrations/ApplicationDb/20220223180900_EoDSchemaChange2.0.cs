using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PharmacyForms.Migrations.ApplicationDb
{
    public partial class EoDSchemaChange20 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ExistingPatients",
                table: "EndOfDay");

            migrationBuilder.DropColumn(
                name: "TransferredPatientCount",
                table: "EndOfDay");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<double>(
                name: "ExistingPatients",
                table: "EndOfDay",
                type: "double",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "TransferredPatientCount",
                table: "EndOfDay",
                type: "double",
                nullable: false,
                defaultValue: 0.0);
        }
    }
}
