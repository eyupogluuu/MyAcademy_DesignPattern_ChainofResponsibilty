using Microsoft.EntityFrameworkCore.Migrations;

namespace MyAcademy_DesignPattern_ChainofResponsibilty.Migrations
{
    public partial class mig_1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "customerProcesses",
                columns: table => new
                {
                    customerProcessID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(nullable: true),
                    amount = table.Column<decimal>(nullable: false),
                    emplooyeName = table.Column<string>(nullable: true),
                    descreption = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_customerProcesses", x => x.customerProcessID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "customerProcesses");
        }
    }
}
