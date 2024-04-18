using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace E_Shop.DAL.Migrations
{
    /// <inheritdoc />
    public partial class Add_audience_field_for_Product : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Audience",
                table: "Products",
                type: "nvarchar(5)",
                maxLength: 5,
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Audience",
                table: "Products");
        }
    }
}
