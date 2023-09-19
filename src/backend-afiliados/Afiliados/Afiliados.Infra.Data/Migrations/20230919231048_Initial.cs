using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Afiliados.Infra.Data.Migrations
{
	/// <inheritdoc />
	public partial class Initial : Migration
	{
		/// <inheritdoc />
		protected override void Up(MigrationBuilder migrationBuilder)
		{
			migrationBuilder.CreateTable(
				name: "Producers",
				columns: table => new
				{
					Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
					Name = table.Column<string>(type: "VARCHAR(100)", nullable: false)
				},
				constraints: table =>
				{
					table.PrimaryKey("PK_Producers", x => x.Id);
				});

			migrationBuilder.CreateTable(
				name: "Affiliateds",
				columns: table => new
				{
					Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
					Name = table.Column<string>(type: "VARCHAR(100)", nullable: false),
					ProducerId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
				},
				constraints: table =>
				{
					table.PrimaryKey("PK_Affiliateds", x => x.Id);
					table.ForeignKey(
						name: "FK_Affiliateds_Producers_ProducerId",
						column: x => x.ProducerId,
						principalTable: "Producers",
						principalColumn: "Id",
						onDelete: ReferentialAction.Cascade);
				});

			migrationBuilder.CreateIndex(
				name: "IX_Affiliateds_ProducerId",
				table: "Affiliateds",
				column: "ProducerId");
		}

		/// <inheritdoc />
		protected override void Down(MigrationBuilder migrationBuilder)
		{
			migrationBuilder.DropTable(
				name: "Affiliateds");

			migrationBuilder.DropTable(
				name: "Producers");
		}
	}
}
