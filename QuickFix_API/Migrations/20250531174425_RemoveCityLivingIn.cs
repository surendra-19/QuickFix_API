using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace QuickFix_API.Migrations
{
    /// <inheritdoc />
    public partial class RemoveCityLivingIn : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CityLivingIn",
                table: "Customers");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CityLivingIn",
                table: "Customers",
                type: "varchar(50)",
                nullable: false,
                defaultValue: "");
        }
    }
}
