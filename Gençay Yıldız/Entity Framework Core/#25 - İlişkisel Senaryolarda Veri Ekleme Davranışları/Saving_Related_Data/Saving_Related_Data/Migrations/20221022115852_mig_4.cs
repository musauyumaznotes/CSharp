using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Saving_Related_Data.Migrations
{
    public partial class mig_4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AuthorBook_Authors_AuthorsId",
                table: "AuthorBook");

            migrationBuilder.DropForeignKey(
                name: "FK_AuthorBook_Books_BooksId",
                table: "AuthorBook");

            migrationBuilder.RenameColumn(
                name: "BooksId",
                table: "AuthorBook",
                newName: "BookId");

            migrationBuilder.RenameColumn(
                name: "AuthorsId",
                table: "AuthorBook",
                newName: "AuthorId");

            migrationBuilder.RenameIndex(
                name: "IX_AuthorBook_BooksId",
                table: "AuthorBook",
                newName: "IX_AuthorBook_BookId");

            migrationBuilder.AddForeignKey(
                name: "FK_AuthorBook_Authors_AuthorId",
                table: "AuthorBook",
                column: "AuthorId",
                principalTable: "Authors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AuthorBook_Books_BookId",
                table: "AuthorBook",
                column: "BookId",
                principalTable: "Books",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AuthorBook_Authors_AuthorId",
                table: "AuthorBook");

            migrationBuilder.DropForeignKey(
                name: "FK_AuthorBook_Books_BookId",
                table: "AuthorBook");

            migrationBuilder.RenameColumn(
                name: "BookId",
                table: "AuthorBook",
                newName: "BooksId");

            migrationBuilder.RenameColumn(
                name: "AuthorId",
                table: "AuthorBook",
                newName: "AuthorsId");

            migrationBuilder.RenameIndex(
                name: "IX_AuthorBook_BookId",
                table: "AuthorBook",
                newName: "IX_AuthorBook_BooksId");

            migrationBuilder.AddForeignKey(
                name: "FK_AuthorBook_Authors_AuthorsId",
                table: "AuthorBook",
                column: "AuthorsId",
                principalTable: "Authors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AuthorBook_Books_BooksId",
                table: "AuthorBook",
                column: "BooksId",
                principalTable: "Books",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
