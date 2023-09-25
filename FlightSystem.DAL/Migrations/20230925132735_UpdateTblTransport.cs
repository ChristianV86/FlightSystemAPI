using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FlightSystem.DAL.Migrations
{
    /// <inheritdoc />
    public partial class UpdateTblTransport : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Flights_Transports_TransportId",
                table: "Flights");

            migrationBuilder.DropIndex(
                name: "IX_Flights_TransportId",
                table: "Flights");

            migrationBuilder.DropColumn(
                name: "TransportId",
                table: "Flights");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "TransportId",
                table: "Flights",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Flights_TransportId",
                table: "Flights",
                column: "TransportId");

            migrationBuilder.AddForeignKey(
                name: "FK_Flights_Transports_TransportId",
                table: "Flights",
                column: "TransportId",
                principalTable: "Transports",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
