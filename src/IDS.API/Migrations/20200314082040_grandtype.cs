using Microsoft.EntityFrameworkCore.Migrations;

namespace IDS.API.Migrations
{
    public partial class grandtype : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Type",
                schema: "idsapp",
                table: "IdentityGrant",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Type",
                schema: "idsapp",
                table: "IdentityGrant");
        }
    }
}
