using Microsoft.EntityFrameworkCore.Migrations;

namespace IDS.API.Migrations
{
    public partial class identity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<long>(
                name: "CreatedTime",
                schema: "idsapp",
                table: "Identity",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<string>(
                name: "Creator",
                schema: "idsapp",
                table: "Identity",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "ModifiedTime",
                schema: "idsapp",
                table: "Identity",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<string>(
                name: "Modifier",
                schema: "idsapp",
                table: "Identity",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreatedTime",
                schema: "idsapp",
                table: "Identity");

            migrationBuilder.DropColumn(
                name: "Creator",
                schema: "idsapp",
                table: "Identity");

            migrationBuilder.DropColumn(
                name: "ModifiedTime",
                schema: "idsapp",
                table: "Identity");

            migrationBuilder.DropColumn(
                name: "Modifier",
                schema: "idsapp",
                table: "Identity");
        }
    }
}
