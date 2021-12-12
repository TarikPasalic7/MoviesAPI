using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MoviesAPI.Migrations
{
    public partial class dbchange : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MovieActor_Movie_GenreId",
                table: "MovieActor");

            migrationBuilder.DropForeignKey(
                name: "FK_MovieGenre_Movie_GenreId",
                table: "MovieGenre");

            migrationBuilder.RenameColumn(
                name: "GenreId",
                table: "MovieActor",
                newName: "ActorId");

            migrationBuilder.RenameIndex(
                name: "IX_MovieActor_GenreId",
                table: "MovieActor",
                newName: "IX_MovieActor_ActorId");

            migrationBuilder.RenameColumn(
                name: "Nationallity",
                table: "Director",
                newName: "Nationality");

            migrationBuilder.AlterColumn<string>(
                name: "Plot",
                table: "Movie",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "MovieLength",
                table: "Movie",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_MovieActor_Actor_ActorId",
                table: "MovieActor",
                column: "ActorId",
                principalTable: "Actor",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MovieGenre_Genre_GenreId",
                table: "MovieGenre",
                column: "GenreId",
                principalTable: "Genre",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MovieActor_Actor_ActorId",
                table: "MovieActor");

            migrationBuilder.DropForeignKey(
                name: "FK_MovieGenre_Genre_GenreId",
                table: "MovieGenre");

            migrationBuilder.RenameColumn(
                name: "ActorId",
                table: "MovieActor",
                newName: "GenreId");

            migrationBuilder.RenameIndex(
                name: "IX_MovieActor_ActorId",
                table: "MovieActor",
                newName: "IX_MovieActor_GenreId");

            migrationBuilder.RenameColumn(
                name: "Nationality",
                table: "Director",
                newName: "Nationallity");

            migrationBuilder.AlterColumn<int>(
                name: "Plot",
                table: "Movie",
                type: "int",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "MovieLength",
                table: "Movie",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AddForeignKey(
                name: "FK_MovieActor_Movie_GenreId",
                table: "MovieActor",
                column: "GenreId",
                principalTable: "Movie",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MovieGenre_Movie_GenreId",
                table: "MovieGenre",
                column: "GenreId",
                principalTable: "Movie",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
