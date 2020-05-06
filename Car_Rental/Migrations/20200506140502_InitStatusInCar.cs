using Microsoft.EntityFrameworkCore.Migrations;

namespace Car_Rental.Migrations
{
    public partial class InitStatusInCar : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Statuss",
                table: "Cars",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Statuss",
                table: "Cars");
        }
    }
}
