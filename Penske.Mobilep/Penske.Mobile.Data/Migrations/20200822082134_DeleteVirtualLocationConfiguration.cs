using Microsoft.EntityFrameworkCore.Migrations;

namespace Penske.Mobilep.Data.Migrations
{
    public partial class DeleteVirtualLocationConfiguration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "VirtualLocationConfiguration");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "VirtualLocationConfiguration",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NAisles = table.Column<int>(type: "int", nullable: false),
                    NColumnLocation = table.Column<int>(type: "int", nullable: false),
                    NRowLocation = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VirtualLocationConfiguration", x => x.ID);
                });
        }
    }
}
