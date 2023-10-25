using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ArtGallery.Migrations
{
    public partial class SeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Artworks",
                columns: new[] { "Id", "Artist", "Description", "Title", "Year" },
                values: new object[,]
                {
                    { 1, "Damien Hirst", "A shark in formaldehyde", "The Physical Impossibility of Death in the Mind of Someone Living", 1991 },
                    { 2, "Takashi Murakami", "Colorful flower artwork", "Flowers", 2010 },
                    { 4, "Richard Serra", "Large-scale steel sculpture", "Tilted Arc", 1981 },
                    { 5, "Mark Rothko", "Abstract expressionist painting", "No. 14", 1960 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Artworks",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Artworks",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Artworks",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Artworks",
                keyColumn: "Id",
                keyValue: 5);
        }
    }
}
