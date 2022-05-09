using Microsoft.EntityFrameworkCore.Migrations;

namespace FbBackend.Migrations
{
    public partial class users : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.CreateTable(
            //    name: "Post",
            //    columns: table => new
            //    {
            //        Id = table.Column<int>(nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        Become_friend_1 = table.Column<string>(nullable: true),
            //        Become_friend_2 = table.Column<string>(nullable: true),
            //        Comment = table.Column<string>(nullable: true),
            //        Comment_user_dp = table.Column<string>(nullable: true),
            //        Comment_user_name = table.Column<string>(nullable: true),
            //        Imgsrc = table.Column<string>(nullable: true),
            //        Last_seen = table.Column<string>(nullable: true),
            //        Mutual_friend_1 = table.Column<string>(nullable: true),
            //        Mutual_friend_2 = table.Column<string>(nullable: true),
            //        No_of_comments = table.Column<string>(nullable: true),
            //        No_of_likes = table.Column<string>(nullable: true),
            //        Text = table.Column<string>(nullable: true),
            //        Userdp = table.Column<string>(nullable: true),
            //        Username = table.Column<string>(nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_Post", x => x.Id);
            //    });

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    ProfileImg = table.Column<string>(nullable: true),
                    Active = table.Column<bool>(nullable: false),
                    Mutual = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Post");

            migrationBuilder.DropTable(
                name: "User");
        }
    }
}
