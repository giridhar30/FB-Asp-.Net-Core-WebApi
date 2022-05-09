using Microsoft.EntityFrameworkCore.Migrations;

namespace FbBackend.Migrations
{
    public partial class watch : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Watch",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    no_of_comments = table.Column<string>(nullable: true),
                    no_of_like = table.Column<string>(nullable: true),
                    no_of_views = table.Column<string>(nullable: true),
                    posted_date = table.Column<string>(nullable: true),
                    user_dp = table.Column<string>(nullable: true),
                    username = table.Column<string>(nullable: true),
                    video = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Watch", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Watch");
        }
    }
}
