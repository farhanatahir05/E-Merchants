using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IMS.Plugins.EFCore.Migrations
{
    public partial class AddedIsCheckedOutProp : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsCheckedOut",
                table: "Wishlists",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsCheckedOut",
                table: "Wishlists");
        }
    }
}
