using Microsoft.EntityFrameworkCore.Migrations;

namespace BooksSharingOnlineAPI.Migrations.CartModel
{
    public partial class AddingCartandUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CartModels",
                columns: table => new
                {
                    CartId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(100)", nullable: true),
                    BookId = table.Column<string>(type: "nvarchar(100)", nullable: true),
                    Ratings = table.Column<string>(type: "nvarchar(100)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CartModels", x => x.CartId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CartModels");
        }
    }
}
