using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FinalExam.Dal.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Clients",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                   First_Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                   Last_Name = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                   Adress = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: false),
                   Membership_Card_Number = table.Column<string>(type: "varchar(20)", maxLength: 200, nullable: false),
                    Membership_Card_Validity_Date = table.Column<string>(type: "varchar(20)", maxLength: 200, nullable: false),
                    Rent_Date = table.Column<string>(type: "varchar(20)", maxLength: 200, nullable: false),
                    Return_Date = table.Column<string>(type: "varchar(20)", maxLength: 200, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ID", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Movies",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 200, nullable: false),
                    Director = table.Column<string>(type: "nvarchar(100)", maxLength: 400, nullable: false),
                    Genre = table.Column<DateTime>(type: "varchar(50)", nullable: false),
                    Year = table.Column<DateTime>(type: "int", nullable: false),
                    Rating = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Box_Office_Earning = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("Movies", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Movies_Clients_ClientsId",
                        column: x => x.ClientsID,
                        principalTable: "Clients",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Movies_Clients",
                table: "Movies",
                column: "ClientId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Movies");

            migrationBuilder.DropTable(
                name: "Movies");
        }
    }
}
