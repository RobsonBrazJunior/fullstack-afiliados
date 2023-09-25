using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Afiliados.Infra.Data.Migrations
{
	/// <inheritdoc />
	public partial class CreateTableSales : Migration
	{
		/// <inheritdoc />
		protected override void Up(MigrationBuilder migrationBuilder)
		{
			migrationBuilder.CreateTable(
				name: "Sales",
				columns: table => new
				{
					Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
					Type = table.Column<byte>(type: "tinyint", nullable: false),
					Date = table.Column<DateTime>(type: "datetime2", nullable: false),
					Product = table.Column<string>(type: "VARCHAR(30)", nullable: false),
					Value = table.Column<int>(type: "int", nullable: false),
					Seller = table.Column<string>(type: "VARCHAR(20)", nullable: false)
				},
				constraints: table =>
				{
					table.PrimaryKey("PK_Sales", x => x.Id);
				});
		}

		/// <inheritdoc />
		protected override void Down(MigrationBuilder migrationBuilder)
		{
			migrationBuilder.DropTable(
				name: "Sales");
		}
	}
}
