using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Superhero003.Repository.Migrations
{
    public partial class navn1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "TeamId",
                table: "Hero",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Team",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    age = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Team", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Hero_TeamId",
                table: "Hero",
                column: "TeamId");

            migrationBuilder.AddForeignKey(
                name: "FK_Hero_Team_TeamId",
                table: "Hero",
                column: "TeamId",
                principalTable: "Team",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Hero_Team_TeamId",
                table: "Hero");

            migrationBuilder.DropTable(
                name: "Team");

            migrationBuilder.DropIndex(
                name: "IX_Hero_TeamId",
                table: "Hero");

            migrationBuilder.DropColumn(
                name: "TeamId",
                table: "Hero");
        }
    }
}
