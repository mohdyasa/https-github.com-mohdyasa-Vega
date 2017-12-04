using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace Vega.Migrations
{
    public partial class seednewModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("Insert into Models (Name, MakeId) Values ('Make1-ModelA',10)");
            migrationBuilder.Sql("Insert into Models (Name, MakeId) Values ('Make1-ModelB',10)");
            migrationBuilder.Sql("Insert into Models (Name, MakeId) Values ('Make1-ModelC',10)");
            migrationBuilder.Sql("Insert into Models (Name, MakeId) Values ('Make2-ModelA',11)");
            migrationBuilder.Sql("Insert into Models (Name, MakeId) Values ('Make2-ModelB',11)");
            migrationBuilder.Sql("Insert into Models (Name, MakeId) Values ('Make2-ModelC',11)");
            migrationBuilder.Sql("Insert into Models (Name, MakeId) Values ('Make3-ModelA',12)");
            migrationBuilder.Sql("Insert into Models (Name, MakeId) Values ('Make3-ModelB',12)");
            migrationBuilder.Sql("Insert into Models (Name, MakeId) Values ('Make3-ModelC',12)");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
