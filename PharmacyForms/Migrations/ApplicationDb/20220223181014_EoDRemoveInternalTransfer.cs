using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PharmacyForms.Migrations.ApplicationDb
{
    public partial class EoDRemoveInternalTransfer : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "InternalTransfer",
                table: "EndOfDay");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<double>(
                name: "InternalTransfer",
                table: "EndOfDay",
                type: "double",
                nullable: false,
                defaultValue: 0.0);
        }
    }
}
