using Microsoft.EntityFrameworkCore.Migrations;

namespace Data.Migrations
{
    public partial class addAnotationsfix : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProductProvider_Providers_ProvidersId",
                table: "ProductProvider");

            migrationBuilder.DropColumn(
                name: "ConfirmPassword",
                table: "Providers");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Providers",
                newName: "providerCode");

            migrationBuilder.RenameColumn(
                name: "ProvidersId",
                table: "ProductProvider",
                newName: "ProvidersproviderCode");

            migrationBuilder.RenameIndex(
                name: "IX_ProductProvider_ProvidersId",
                table: "ProductProvider",
                newName: "IX_ProductProvider_ProvidersproviderCode");

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Providers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Products",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductProvider_Providers_ProvidersproviderCode",
                table: "ProductProvider",
                column: "ProvidersproviderCode",
                principalTable: "Providers",
                principalColumn: "providerCode",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProductProvider_Providers_ProvidersproviderCode",
                table: "ProductProvider");

            migrationBuilder.RenameColumn(
                name: "providerCode",
                table: "Providers",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "ProvidersproviderCode",
                table: "ProductProvider",
                newName: "ProvidersId");

            migrationBuilder.RenameIndex(
                name: "IX_ProductProvider_ProvidersproviderCode",
                table: "ProductProvider",
                newName: "IX_ProductProvider_ProvidersId");

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Providers",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<string>(
                name: "ConfirmPassword",
                table: "Providers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Products",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductProvider_Providers_ProvidersId",
                table: "ProductProvider",
                column: "ProvidersId",
                principalTable: "Providers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
