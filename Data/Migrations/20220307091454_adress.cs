using Microsoft.EntityFrameworkCore.Migrations;

namespace Data.Migrations
{
    public partial class adress : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "StreetAdress",
                table: "Products",
                newName: "MyAdress_streetAdress");

            migrationBuilder.RenameColumn(
                name: "City",
                table: "Products",
                newName: "MyAdress_city");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "MyAdress_streetAdress",
                table: "Products",
                newName: "StreetAdress");

            migrationBuilder.RenameColumn(
                name: "MyAdress_city",
                table: "Products",
                newName: "City");
        }
    }
}
