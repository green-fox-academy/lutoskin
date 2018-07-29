using Microsoft.EntityFrameworkCore.Migrations;

namespace MatrixChecker.Migrations
{
    public partial class NumbersString : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "MatrixNumbers",
                table: "Matrices",
                nullable: true,
                oldClrType: typeof(long));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<long>(
                name: "MatrixNumbers",
                table: "Matrices",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);
        }
    }
}
