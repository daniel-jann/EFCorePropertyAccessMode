using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EFCorePropertyAccessMode.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "MyEntities",
                columns: table => new
                {
                    KeyField1 = table.Column<Guid>(nullable: false),
                    KeyField2 = table.Column<string>(nullable: false),
                    MyOwnedEntity_MyOwnedEntityOwnedEntityTypeField1 = table.Column<decimal>(nullable: true),
                    MyOwnedEntity_MyOwnedEntityOwnedEntityTypeField2 = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MyEntities", x => new { x.KeyField1, x.KeyField2 });
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MyEntities");
        }
    }
}
