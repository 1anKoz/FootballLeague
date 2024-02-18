using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FootballLeague.Migrations
{
    /// <inheritdoc />
    public partial class updateModels : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Queues_Leagues_LeagueId",
                table: "Queues");

            migrationBuilder.AlterColumn<int>(
                name: "LeagueId",
                table: "Queues",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Queue",
                table: "Queues",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Match",
                table: "Matches",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddForeignKey(
                name: "FK_Queues_Leagues_LeagueId",
                table: "Queues",
                column: "LeagueId",
                principalTable: "Leagues",
                principalColumn: "LeagueId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Queues_Leagues_LeagueId",
                table: "Queues");

            migrationBuilder.DropColumn(
                name: "Queue",
                table: "Queues");

            migrationBuilder.DropColumn(
                name: "Match",
                table: "Matches");

            migrationBuilder.AlterColumn<int>(
                name: "LeagueId",
                table: "Queues",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Queues_Leagues_LeagueId",
                table: "Queues",
                column: "LeagueId",
                principalTable: "Leagues",
                principalColumn: "LeagueId");
        }
    }
}
