using Microsoft.EntityFrameworkCore.Migrations;

namespace FbBackend.Migrations
{
    public partial class setup : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "FriendList",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Accept = table.Column<string>(nullable: true),
                    Education = table.Column<string>(nullable: true),
                    Friends_name = table.Column<string>(nullable: true),
                    Friends_url = table.Column<string>(nullable: true),
                    Image_url = table.Column<string>(nullable: true),
                    Mutual_friends = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    Work = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FriendList", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "FriendSuggestion",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Accept = table.Column<string>(nullable: true),
                    Education = table.Column<string>(nullable: true),
                    Friends_name = table.Column<string>(nullable: true),
                    Friends_url = table.Column<string>(nullable: true),
                    Image_url = table.Column<string>(nullable: true),
                    Mutual_friends = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    Work = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FriendSuggestion", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Post",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Become_friend_1 = table.Column<string>(nullable: true),
                    Become_friend_2 = table.Column<string>(nullable: true),
                    Comment = table.Column<string>(nullable: true),
                    Comment_user_dp = table.Column<string>(nullable: true),
                    Comment_user_name = table.Column<string>(nullable: true),
                    Imgsrc = table.Column<string>(nullable: true),
                    Last_seen = table.Column<string>(nullable: true),
                    Mutual_friend_1 = table.Column<string>(nullable: true),
                    Mutual_friend_2 = table.Column<string>(nullable: true),
                    No_of_comments = table.Column<string>(nullable: true),
                    No_of_likes = table.Column<string>(nullable: true),
                    Text = table.Column<string>(nullable: true),
                    Userdp = table.Column<string>(nullable: true),
                    Username = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Post", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ProfileFriend",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Img = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProfileFriend", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ProfilePhoto",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Url = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProfilePhoto", x => x.Id);
                });

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
                name: "FriendList");

            migrationBuilder.DropTable(
                name: "FriendSuggestion");

            migrationBuilder.DropTable(
                name: "Post");

            migrationBuilder.DropTable(
                name: "ProfileFriend");

            migrationBuilder.DropTable(
                name: "ProfilePhoto");

            migrationBuilder.DropTable(
                name: "User");

            migrationBuilder.DropTable(
                name: "Watch");
        }
    }
}
