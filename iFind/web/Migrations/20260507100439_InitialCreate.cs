using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace web.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Dogodki_Kategorije_KategorijaId",
                table: "Dogodki");

            migrationBuilder.AlterColumn<int>(
                name: "KategorijaId",
                table: "Dogodki",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Dogodki_Kategorije_KategorijaId",
                table: "Dogodki",
                column: "KategorijaId",
                principalTable: "Kategorije",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Dogodki_Kategorije_KategorijaId",
                table: "Dogodki");

            migrationBuilder.AlterColumn<int>(
                name: "KategorijaId",
                table: "Dogodki",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Dogodki_Kategorije_KategorijaId",
                table: "Dogodki",
                column: "KategorijaId",
                principalTable: "Kategorije",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
