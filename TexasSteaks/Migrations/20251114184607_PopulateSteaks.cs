using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TexasSteaks.Migrations
{
    /// <inheritdoc />
    public partial class PopulateSteaks : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            /*
            migrationBuilder.Sql("INSERT INTO Steaks(Name, ShortDescription, Description, Price, ImageURL, ThumbnailURL, IsFavorite, InStock, CategoryId) " +
                "VALUES ('Picanha', '')");
            */
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM Steaks");
        }
    }
}
