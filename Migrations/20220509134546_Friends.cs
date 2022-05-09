using Microsoft.EntityFrameworkCore.Migrations;

namespace FbBackend.Migrations
{
    public partial class Friends : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
           
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Friend",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Accept = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Education = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Image_url = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Mutual_friends = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Work = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Friend", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "FriendName",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Friend_id = table.Column<int>(type: "int", nullable: false),
                    Friend_name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    friendId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FriendName", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FriendName_Friend_friendId",
                        column: x => x.friendId,
                        principalTable: "Friend",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "FriendUrl",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Friend_id = table.Column<int>(type: "int", nullable: false),
                    Url = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    friendId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FriendUrl", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FriendUrl_Friend_friendId",
                        column: x => x.friendId,
                        principalTable: "Friend",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_FriendName_friendId",
                table: "FriendName",
                column: "friendId");

            migrationBuilder.CreateIndex(
                name: "IX_FriendUrl_friendId",
                table: "FriendUrl",
                column: "friendId");
        }
    }
}
