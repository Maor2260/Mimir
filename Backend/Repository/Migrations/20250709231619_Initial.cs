using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Repository.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Answers",
                columns: table => new
                {
                    Key = table.Column<Guid>(type: "TEXT", nullable: false),
                    Text = table.Column<string>(type: "TEXT", nullable: false),
                    Comment = table.Column<string>(type: "TEXT", nullable: true),
                    Discriminator = table.Column<string>(type: "TEXT", maxLength: 21, nullable: false),
                    Index = table.Column<uint>(type: "INTEGER", nullable: true),
                    MultipleChoiceQuestionKey = table.Column<Guid>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Answers", x => x.Key);
                });

            migrationBuilder.CreateTable(
                name: "Matches",
                columns: table => new
                {
                    Key = table.Column<Guid>(type: "TEXT", nullable: false),
                    PlayerKey = table.Column<Guid>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Matches", x => x.Key);
                });

            migrationBuilder.CreateTable(
                name: "Players",
                columns: table => new
                {
                    Key = table.Column<Guid>(type: "TEXT", nullable: false),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    MatchKey = table.Column<Guid>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Players", x => x.Key);
                    table.ForeignKey(
                        name: "FK_Players_Matches_MatchKey",
                        column: x => x.MatchKey,
                        principalTable: "Matches",
                        principalColumn: "Key");
                });

            migrationBuilder.CreateTable(
                name: "Questions",
                columns: table => new
                {
                    Key = table.Column<Guid>(type: "TEXT", nullable: false),
                    Index = table.Column<uint>(type: "INTEGER", nullable: true),
                    Difficulty = table.Column<int>(type: "INTEGER", nullable: true),
                    Text = table.Column<string>(type: "TEXT", nullable: false),
                    Discriminator = table.Column<string>(type: "TEXT", maxLength: 34, nullable: false),
                    MatchKey = table.Column<Guid>(type: "TEXT", nullable: true),
                    CorrectAnswerKey = table.Column<Guid>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Questions", x => x.Key);
                    table.ForeignKey(
                        name: "FK_Questions_Answers_CorrectAnswerKey",
                        column: x => x.CorrectAnswerKey,
                        principalTable: "Answers",
                        principalColumn: "Key");
                    table.ForeignKey(
                        name: "FK_Questions_Matches_MatchKey",
                        column: x => x.MatchKey,
                        principalTable: "Matches",
                        principalColumn: "Key");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Answers_MultipleChoiceQuestionKey",
                table: "Answers",
                column: "MultipleChoiceQuestionKey");

            migrationBuilder.CreateIndex(
                name: "IX_Matches_PlayerKey",
                table: "Matches",
                column: "PlayerKey");

            migrationBuilder.CreateIndex(
                name: "IX_Players_MatchKey",
                table: "Players",
                column: "MatchKey");

            migrationBuilder.CreateIndex(
                name: "IX_Questions_CorrectAnswerKey",
                table: "Questions",
                column: "CorrectAnswerKey");

            migrationBuilder.CreateIndex(
                name: "IX_Questions_MatchKey",
                table: "Questions",
                column: "MatchKey");

            migrationBuilder.AddForeignKey(
                name: "FK_Answers_Questions_MultipleChoiceQuestionKey",
                table: "Answers",
                column: "MultipleChoiceQuestionKey",
                principalTable: "Questions",
                principalColumn: "Key");

            migrationBuilder.AddForeignKey(
                name: "FK_Matches_Players_PlayerKey",
                table: "Matches",
                column: "PlayerKey",
                principalTable: "Players",
                principalColumn: "Key",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Answers_Questions_MultipleChoiceQuestionKey",
                table: "Answers");

            migrationBuilder.DropForeignKey(
                name: "FK_Matches_Players_PlayerKey",
                table: "Matches");

            migrationBuilder.DropTable(
                name: "Questions");

            migrationBuilder.DropTable(
                name: "Answers");

            migrationBuilder.DropTable(
                name: "Players");

            migrationBuilder.DropTable(
                name: "Matches");
        }
    }
}
