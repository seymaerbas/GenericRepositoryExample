using Microsoft.EntityFrameworkCore.Migrations;

namespace GenericRepositoryExample.DataAccsess.Migrations
{
    public partial class model : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Id",
                table: "Profiles");

            migrationBuilder.RenameColumn(
                name: "User_id",
                table: "Users",
                newName: "User_Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "User_Id",
                table: "Users",
                newName: "User_id");

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "Profiles",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
