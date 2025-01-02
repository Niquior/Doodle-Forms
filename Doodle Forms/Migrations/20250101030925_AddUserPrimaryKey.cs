using Microsoft.EntityFrameworkCore.Migrations;
using MySql.EntityFrameworkCore.Metadata;

#nullable disable

namespace Doodle_Forms.Migrations
{
    /// <inheritdoc />
    public partial class AddUserPrimaryKey : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Forms",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Forms", x => x.Id);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Templates",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Title = table.Column<string>(type: "longtext", nullable: false),
                    Description = table.Column<string>(type: "longtext", nullable: false),
                    ImageUrl = table.Column<string>(type: "longtext", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    TopicId = table.Column<int>(type: "int", nullable: false),
                    SingleStringQuestion1State = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    SingleStringQuestion1 = table.Column<string>(type: "longtext", nullable: false),
                    SingleStringQuestion2State = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    SingleStringQuestion2 = table.Column<string>(type: "longtext", nullable: false),
                    SingleStringQuestion3State = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    SingleStringQuestion3 = table.Column<string>(type: "longtext", nullable: false),
                    SingleStringQuestion4State = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    SingleStringQuestion4 = table.Column<string>(type: "longtext", nullable: false),
                    MultipleStringsQuestion1State = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    MultipleStringsQuestion1 = table.Column<string>(type: "longtext", nullable: false),
                    MultipleStringsQuestion2State = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    MultipleStringsQuestion2 = table.Column<string>(type: "longtext", nullable: false),
                    MultipleStringsQuestion3State = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    MultipleStringsQuestion3 = table.Column<string>(type: "longtext", nullable: false),
                    MultipleStringsQuestion4State = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    MultipleStringsQuestion4 = table.Column<string>(type: "longtext", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Templates", x => x.Id);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "longtext", nullable: false),
                    PasswordHash = table.Column<string>(type: "longtext", nullable: false),
                    Role = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                })
                .Annotation("MySQL:Charset", "utf8mb4");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Forms");

            migrationBuilder.DropTable(
                name: "Templates");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
