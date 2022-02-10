using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PharmacyForms.Data.Migrations
{
    public partial class ChangePatientCountId : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Id",
                table: "PatientCounts",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "float");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<double>(
                name: "Id",
                table: "PatientCounts",
                type: "float",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");
        }
    }
}
