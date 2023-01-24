using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace users.Migrations
{
    /// <inheritdoc />
    public partial class UpdateUserTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Users",
                table: "Users");

            migrationBuilder.RenameTable(
                name: "Users",
                newName: "tb_user");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "tb_user",
                newName: "name");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "tb_user",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "BirthDate",
                table: "tb_user",
                newName: "birth_date");

            migrationBuilder.AddPrimaryKey(
                name: "PK_tb_user",
                table: "tb_user",
                column: "id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_tb_user",
                table: "tb_user");

            migrationBuilder.RenameTable(
                name: "tb_user",
                newName: "Users");

            migrationBuilder.RenameColumn(
                name: "name",
                table: "Users",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "Users",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "birth_date",
                table: "Users",
                newName: "BirthDate");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Users",
                table: "Users",
                column: "Id");
        }
    }
}
