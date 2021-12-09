using Microsoft.EntityFrameworkCore.Migrations;

namespace GenericRepositoryExample.DataAccsess.Migrations
{
    public partial class genericrepo2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Branchs_Users_User_Id",
                table: "Branchs");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Branchs",
                table: "Branchs");

            migrationBuilder.RenameTable(
                name: "Branchs",
                newName: "Profiles");

            migrationBuilder.RenameIndex(
                name: "IX_Branchs_User_Id",
                table: "Profiles",
                newName: "IX_Profiles_User_Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Profiles",
                table: "Profiles",
                column: "Profil_Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Profiles_Users_User_Id",
                table: "Profiles",
                column: "User_Id",
                principalTable: "Users",
                principalColumn: "User_id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Profiles_Users_User_Id",
                table: "Profiles");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Profiles",
                table: "Profiles");

            migrationBuilder.RenameTable(
                name: "Profiles",
                newName: "Branchs");

            migrationBuilder.RenameIndex(
                name: "IX_Profiles_User_Id",
                table: "Branchs",
                newName: "IX_Branchs_User_Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Branchs",
                table: "Branchs",
                column: "Profil_Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Branchs_Users_User_Id",
                table: "Branchs",
                column: "User_Id",
                principalTable: "Users",
                principalColumn: "User_id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
