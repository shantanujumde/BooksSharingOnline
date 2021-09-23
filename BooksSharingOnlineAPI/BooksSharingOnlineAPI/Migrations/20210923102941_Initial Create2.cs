using Microsoft.EntityFrameworkCore.Migrations;

namespace BooksSharingOnlineAPI.Migrations
{
    public partial class InitialCreate2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "BookUrl",
                table: "BookModels",
                type: "nvarchar(1000)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FrontPageUrl",
                table: "BookModels",
                type: "nvarchar(1000)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Price",
                table: "BookModels",
                type: "nvarchar(100)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BookUrl",
                table: "BookModels");

            migrationBuilder.DropColumn(
                name: "FrontPageUrl",
                table: "BookModels");

            migrationBuilder.DropColumn(
                name: "Price",
                table: "BookModels");
        }
    }
}
