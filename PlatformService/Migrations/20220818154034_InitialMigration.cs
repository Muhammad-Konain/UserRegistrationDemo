using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PlatformService.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    fullName = table.Column<string>(nullable: true),
                    email = table.Column<string>(nullable: true),
                    middleName = table.Column<string>(nullable: true),
                    dateOfBirth = table.Column<DateTime>(nullable: false),
                    phoneNumber = table.Column<string>(nullable: true),
                    address1 = table.Column<string>(nullable: true),
                    address2 = table.Column<string>(nullable: true),
                    hasDualNationality = table.Column<bool>(nullable: false),
                    selfie = table.Column<string>(nullable: true),
                    nationalIdfront = table.Column<string>(nullable: true),
                    nationalIdback = table.Column<string>(nullable: true),
                    profileImage = table.Column<string>(nullable: true),
                    utilityBill = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
