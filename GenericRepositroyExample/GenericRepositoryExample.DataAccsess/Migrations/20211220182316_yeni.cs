using Microsoft.EntityFrameworkCore.Migrations;

namespace GenericRepositoryExample.DataAccsess.Migrations
{
    public partial class yeni : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Comments",
                columns: table => new
                {
                    Comment_Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    User_Id = table.Column<int>(nullable: false),
                    Rate = table.Column<int>(nullable: false),
                    CommentDetail = table.Column<string>(nullable: true),
                    Title = table.Column<string>(maxLength: 30, nullable: true),
                    Content_Id = table.Column<int>(nullable: false),
                    User_id = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comments", x => x.Comment_Id);
                    table.ForeignKey(
                        name: "FK_Comments_Contents_Content_Id",
                        column: x => x.Content_Id,
                        principalTable: "Contents",
                        principalColumn: "Content_Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Comments_User_User_id",
                        column: x => x.User_id,
                        principalTable: "User",
                        principalColumn: "User_Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Faqs",
                columns: table => new
                {
                    Faq_Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Question = table.Column<string>(nullable: true),
                    Answer = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Faqs", x => x.Faq_Id);
                });

            migrationBuilder.CreateTable(
                name: "Folders",
                columns: table => new
                {
                    Folder_Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Type = table.Column<string>(nullable: true),
                    User_id = table.Column<int>(nullable: false),
                    Content_Id = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Folders", x => x.Folder_Id);
                    table.ForeignKey(
                        name: "FK_Folders_Contents_Content_Id",
                        column: x => x.Content_Id,
                        principalTable: "Contents",
                        principalColumn: "Content_Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Folders_User_User_id",
                        column: x => x.User_id,
                        principalTable: "User",
                        principalColumn: "User_Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Messages",
                columns: table => new
                {
                    Message_Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    Phone = table.Column<int>(nullable: false),
                    Subject = table.Column<string>(nullable: true),
                    Messages = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Messages", x => x.Message_Id);
                });

            migrationBuilder.CreateTable(
                name: "Settings",
                columns: table => new
                {
                    Setting_Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Facebook = table.Column<string>(maxLength: 30, nullable: true),
                    Twitter = table.Column<string>(maxLength: 30, nullable: true),
                    Instagram = table.Column<string>(maxLength: 30, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Settings", x => x.Setting_Id);
                });

            migrationBuilder.CreateTable(
                name: "Suggestions",
                columns: table => new
                {
                    Suggestion_Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Detail = table.Column<string>(maxLength: 50, nullable: true),
                    Title = table.Column<string>(maxLength: 30, nullable: true),
                    User_id = table.Column<int>(nullable: false),
                    Content_Id = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Suggestions", x => x.Suggestion_Id);
                    table.ForeignKey(
                        name: "FK_Suggestions_Contents_Content_Id",
                        column: x => x.Content_Id,
                        principalTable: "Contents",
                        principalColumn: "Content_Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Suggestions_User_User_id",
                        column: x => x.User_id,
                        principalTable: "User",
                        principalColumn: "User_Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Comments_Content_Id",
                table: "Comments",
                column: "Content_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Comments_User_id",
                table: "Comments",
                column: "User_id");

            migrationBuilder.CreateIndex(
                name: "IX_Folders_Content_Id",
                table: "Folders",
                column: "Content_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Folders_User_id",
                table: "Folders",
                column: "User_id");

            migrationBuilder.CreateIndex(
                name: "IX_Suggestions_Content_Id",
                table: "Suggestions",
                column: "Content_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Suggestions_User_id",
                table: "Suggestions",
                column: "User_id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Comments");

            migrationBuilder.DropTable(
                name: "Faqs");

            migrationBuilder.DropTable(
                name: "Folders");

            migrationBuilder.DropTable(
                name: "Messages");

            migrationBuilder.DropTable(
                name: "Settings");

            migrationBuilder.DropTable(
                name: "Suggestions");
        }
    }
}
