using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CryptoServices.Data.Migrations
{
    /// <inheritdoc />
    public partial class updateorderwithstate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CurrentState",
                table: "Orders",
                type: "text",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CurrentState",
                table: "Orders");
        }
    }
}
