using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PracticeTutorial1.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    Price = table.Column<decimal>(nullable: false),
                    Date = table.Column<DateTime>(nullable: false),
                    Batch = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UserLogins",
                columns: table => new
                {
                    ID = table.Column<string>(nullable: false),
                    User = table.Column<string>(nullable: true),
                    Password = table.Column<string>(nullable: true),
                    Vip = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserLogins", x => x.ID);
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Batch", "Date", "Name", "Price" },
                values: new object[,]
                {
                    { 1, "23713", new DateTime(2021, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Skin 18+", 492000m },
                    { 2, "LP9872", new DateTime(2021, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Pro Sunwhite", 1350000m },
                    { 3, "46723", new DateTime(2021, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Manuka Gel 50ml", 700000m }
                });

            migrationBuilder.InsertData(
                table: "UserLogins",
                columns: new[] { "ID", "Password", "User", "Vip" },
                values: new object[,]
                {
                    { "1", "123456", "haovippro", null },
                    { "2", "123456", "langtucodon", null }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "UserLogins");
        }
    }
}
