using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FlightSystem.DAL.Migrations
{
    /// <inheritdoc />
    public partial class AddDatabase_andSystemTables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Journeys",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Origin = table.Column<string>(type: "nvarchar(3)", maxLength: 3, nullable: false),
                    Destination = table.Column<string>(type: "nvarchar(3)", maxLength: 3, nullable: false),
                    Price = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Journeys", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Transports",
                columns: table => new
                {
                    FlightNumber = table.Column<string>(type: "nvarchar(4)", maxLength: 4, nullable: false),
                    FlightCarrier = table.Column<string>(type: "nvarchar(2)", maxLength: 2, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Transports", x => x.FlightNumber);
                });

            migrationBuilder.CreateTable(
                name: "Fligths",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Origin = table.Column<string>(type: "nvarchar(3)", maxLength: 3, nullable: false),
                    Destination = table.Column<string>(type: "nvarchar(3)", maxLength: 3, nullable: false),
                    Price = table.Column<double>(type: "float", nullable: false),
                    FlightNumber = table.Column<string>(type: "nvarchar(4)", nullable: false),
                    JourneyId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Fligths", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Fligths_Journeys_JourneyId",
                        column: x => x.JourneyId,
                        principalTable: "Journeys",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Fligths_Transports_FlightNumber",
                        column: x => x.FlightNumber,
                        principalTable: "Transports",
                        principalColumn: "FlightNumber",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "JourneyFlights",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    JourneyId = table.Column<int>(type: "int", nullable: false),
                    FlightId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JourneyFlights", x => x.Id);
                    table.ForeignKey(
                        name: "FK_JourneyFlights_Fligths_FlightId",
                        column: x => x.FlightId,
                        principalTable: "Fligths",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_JourneyFlights_Journeys_JourneyId",
                        column: x => x.JourneyId,
                        principalTable: "Journeys",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Fligths_FlightNumber",
                table: "Fligths",
                column: "FlightNumber");

            migrationBuilder.CreateIndex(
                name: "IX_Fligths_JourneyId",
                table: "Fligths",
                column: "JourneyId");

            migrationBuilder.CreateIndex(
                name: "IX_JourneyFlights_FlightId",
                table: "JourneyFlights",
                column: "FlightId");

            migrationBuilder.CreateIndex(
                name: "IX_JourneyFlights_JourneyId",
                table: "JourneyFlights",
                column: "JourneyId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "JourneyFlights");

            migrationBuilder.DropTable(
                name: "Fligths");

            migrationBuilder.DropTable(
                name: "Journeys");

            migrationBuilder.DropTable(
                name: "Transports");
        }
    }
}
