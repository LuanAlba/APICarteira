using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace APICarteira.Migrations
{
    /// <inheritdoc />
    public partial class SegundaMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Transacao_Categoria_CategoriaId",
                table: "Transacao");

            migrationBuilder.DropIndex(
                name: "IX_Transacao_CategoriaId",
                table: "Transacao");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Transacao_CategoriaId",
                table: "Transacao",
                column: "CategoriaId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Transacao_Categoria_CategoriaId",
                table: "Transacao",
                column: "CategoriaId",
                principalTable: "Categoria",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
