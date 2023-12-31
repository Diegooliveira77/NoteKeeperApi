﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NoteKeeper.Infra.Orm.Migrations
{
  /// <inheritdoc />
  public partial class ConfigInicial : Migration
  {
    /// <inheritdoc />
    protected override void Up(MigrationBuilder migrationBuilder)
    {
      migrationBuilder.CreateTable(
          name: "Categorias",
          columns: table => new
          {
            Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
            Titulo = table.Column<string>(type: "nvarchar(max)", nullable: false)
          },
          constraints: table =>
          {
            table.PrimaryKey("PK_Categorias", x => x.Id);
          });

      migrationBuilder.CreateTable(
          name: "Notas",
          columns: table => new
          {
            Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
            Titulo = table.Column<string>(type: "nvarchar(max)", nullable: false),
            Conteudo = table.Column<string>(type: "nvarchar(max)", nullable: false),
            Tema = table.Column<int>(type: "int", nullable: false),
            Arquivada = table.Column<bool>(type: "bit", nullable: false),
            CategoriaId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
          },
          constraints: table =>
          {
            table.PrimaryKey("PK_Notas", x => x.Id);
            table.ForeignKey(
                      name: "FK_Notas_Categorias_CategoriaId",
                      column: x => x.CategoriaId,
                      principalTable: "Categorias",
                      principalColumn: "Id",
                      onDelete: ReferentialAction.Cascade);
          });

      migrationBuilder.CreateIndex(
          name: "IX_Notas_CategoriaId",
          table: "Notas",
          column: "CategoriaId");
    }

    /// <inheritdoc />
    protected override void Down(MigrationBuilder migrationBuilder)
    {
      migrationBuilder.DropTable(
          name: "Notas");

      migrationBuilder.DropTable(
          name: "Categorias");
    }
  }
}
