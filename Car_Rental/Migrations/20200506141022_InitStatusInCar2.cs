using Microsoft.EntityFrameworkCore.Migrations;

namespace Car_Rental.Migrations
{
    public partial class InitStatusInCar2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Status",
                table: "RentalViews",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Status",
                table: "RentalViews");
        }
    }
}
