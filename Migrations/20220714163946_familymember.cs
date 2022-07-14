using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GrocerAPI.Migrations
{
    public partial class familymember : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "FamilyName",
                table: "FamilyMembers",
                newName: "MemberName");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "MemberName",
                table: "FamilyMembers",
                newName: "FamilyName");
        }
    }
}
