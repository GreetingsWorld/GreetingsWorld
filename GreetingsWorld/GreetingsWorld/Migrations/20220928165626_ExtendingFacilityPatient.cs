using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GreetingsWorld.Migrations
{
    public partial class ExtendingFacilityPatient : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "facilityName",
                table: "Facility_Patient",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "facilityState",
                table: "Facility_Patient",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "facilityName",
                table: "Facility_Patient");

            migrationBuilder.DropColumn(
                name: "facilityState",
                table: "Facility_Patient");
        }
    }
}
