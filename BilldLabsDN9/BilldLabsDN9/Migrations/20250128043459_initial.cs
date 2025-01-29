using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BilldLabsDN9.Migrations
{
    /// <inheritdoc />
    public partial class initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    CategoryId = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    Name = table.Column<string>(type: "longtext", nullable: false, collation: "utf8mb4_general_ci"),
                    Description = table.Column<string>(type: "longtext", nullable: true, collation: "utf8mb4_general_ci"),
                    Enabled = table.Column<bool>(type: "tinyint(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.CategoryId);
                })
                .Annotation("Relational:Collation", "utf8mb4_general_ci");

            migrationBuilder.CreateTable(
                name: "Templates",
                columns: table => new
                {
                    TemplateId = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    AvailableForCategories = table.Column<string>(type: "longtext", nullable: false, collation: "utf8mb4_general_ci"),
                    PostType = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Templates", x => x.TemplateId);
                })
                .Annotation("Relational:Collation", "utf8mb4_general_ci");

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    UserId = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    UserName = table.Column<string>(type: "longtext", nullable: false, collation: "utf8mb4_general_ci"),
                    Email = table.Column<string>(type: "longtext", nullable: true, collation: "utf8mb4_general_ci"),
                    JoinDate = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    SuspendDate = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    LastLoginDate = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    IsAdmin = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    IsContributor = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    PassKeyPublicKey = table.Column<string>(type: "longtext", nullable: true, collation: "utf8mb4_general_ci")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.UserId);
                })
                .Annotation("Relational:Collation", "utf8mb4_general_ci");

            migrationBuilder.CreateTable(
                name: "BasePostDetail",
                columns: table => new
                {
                    PostDetailId = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    Title = table.Column<string>(type: "longtext", nullable: false, collation: "utf8mb4_general_ci"),
                    AuthorId = table.Column<Guid>(type: "char(36)", nullable: true, collation: "ascii_general_ci"),
                    PublishDate = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    LastUpdated = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    UnpublishDate = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    PostType = table.Column<int>(type: "int", nullable: false),
                    Discriminator = table.Column<string>(type: "varchar(21)", maxLength: 21, nullable: false, collation: "utf8mb4_general_ci"),
                    ReviewScore = table.Column<decimal>(type: "decimal(65,30)", nullable: true),
                    Review = table.Column<string>(type: "longtext", nullable: true, collation: "utf8mb4_general_ci"),
                    ComicTitle = table.Column<string>(type: "longtext", nullable: true, collation: "utf8mb4_general_ci"),
                    ComicAuthor = table.Column<string>(type: "longtext", nullable: true, collation: "utf8mb4_general_ci"),
                    ComicArtist = table.Column<string>(type: "longtext", nullable: true, collation: "utf8mb4_general_ci"),
                    CoverArist = table.Column<string>(type: "longtext", nullable: true, collation: "utf8mb4_general_ci"),
                    CoverUrl = table.Column<string>(type: "longtext", nullable: true, collation: "utf8mb4_general_ci"),
                    CoverAltText = table.Column<string>(type: "longtext", nullable: true, collation: "utf8mb4_general_ci"),
                    ReferralUrl = table.Column<string>(type: "longtext", nullable: true, collation: "utf8mb4_general_ci")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BasePostDetail", x => x.PostDetailId);
                    table.ForeignKey(
                        name: "FK_BasePostDetail_Users_AuthorId",
                        column: x => x.AuthorId,
                        principalTable: "Users",
                        principalColumn: "UserId");
                })
                .Annotation("Relational:Collation", "utf8mb4_general_ci");

            migrationBuilder.CreateTable(
                name: "Posts",
                columns: table => new
                {
                    PostId = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    Title = table.Column<string>(type: "longtext", nullable: false, collation: "utf8mb4_general_ci"),
                    PostType = table.Column<int>(type: "int", nullable: false),
                    PostDetiailId = table.Column<Guid>(type: "char(36)", nullable: true, collation: "ascii_general_ci"),
                    PostDetailId = table.Column<Guid>(type: "char(36)", nullable: true, collation: "ascii_general_ci")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Posts", x => x.PostId);
                    table.ForeignKey(
                        name: "FK_Posts_BasePostDetail_PostDetailId",
                        column: x => x.PostDetailId,
                        principalTable: "BasePostDetail",
                        principalColumn: "PostDetailId");
                })
                .Annotation("Relational:Collation", "utf8mb4_general_ci");

            migrationBuilder.CreateIndex(
                name: "IX_BasePostDetail_AuthorId",
                table: "BasePostDetail",
                column: "AuthorId");

            migrationBuilder.CreateIndex(
                name: "IX_Posts_PostDetailId",
                table: "Posts",
                column: "PostDetailId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Posts");

            migrationBuilder.DropTable(
                name: "Templates");

            migrationBuilder.DropTable(
                name: "BasePostDetail");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
