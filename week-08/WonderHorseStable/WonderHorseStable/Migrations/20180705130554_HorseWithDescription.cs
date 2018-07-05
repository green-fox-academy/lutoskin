using Microsoft.EntityFrameworkCore.Migrations;

namespace WonderHorseStable.Migrations
{
    public partial class HorseWithDescription : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Horses",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Description",
                table: "Horses");
        }
    }
}
