using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace OplugAbpProject.Migrations
{
    public partial class AddCMSBusiness : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "CategoryName",
                table: "Category",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Author",
                table: "Article",
                maxLength: 50,
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "EndTime",
                table: "Article",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ExtendAttr",
                table: "Article",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FileUrl",
                table: "Article",
                maxLength: 500,
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "Hits",
                table: "Article",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<string>(
                name: "ImageUrl",
                table: "Article",
                maxLength: 500,
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsHot",
                table: "Article",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsRec",
                table: "Article",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsTop",
                table: "Article",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastModificationTime",
                table: "Article",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SubTitle",
                table: "Article",
                maxLength: 50,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Summary",
                table: "Article",
                maxLength: 500,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Tags",
                table: "Article",
                maxLength: 500,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "VideoUrl",
                table: "Article",
                maxLength: 500,
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Businesses",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Title = table.Column<string>(maxLength: 50, nullable: false),
                    SubTitle = table.Column<string>(maxLength: 50, nullable: true),
                    Contents = table.Column<string>(type: "text", nullable: true),
                    CategoryId = table.Column<int>(nullable: false),
                    Tags = table.Column<string>(maxLength: 500, nullable: true),
                    Hits = table.Column<long>(nullable: false),
                    ImageUrl = table.Column<string>(maxLength: 500, nullable: true),
                    FileUrl = table.Column<string>(maxLength: 500, nullable: true),
                    VideoUrl = table.Column<string>(maxLength: 500, nullable: true),
                    longitude = table.Column<decimal>(nullable: false),
                    latitude = table.Column<decimal>(nullable: false),
                    Price = table.Column<decimal>(nullable: false),
                    VendName = table.Column<string>(maxLength: 50, nullable: true),
                    Telphone = table.Column<string>(maxLength: 50, nullable: true),
                    Contactor = table.Column<string>(maxLength: 50, nullable: true),
                    Address = table.Column<string>(maxLength: 500, nullable: true),
                    Summary = table.Column<string>(maxLength: 500, nullable: true),
                    ExtendAttr = table.Column<string>(type: "text", nullable: true),
                    CreatorUserId = table.Column<long>(nullable: true),
                    TenantId = table.Column<int>(nullable: false),
                    CreationTime = table.Column<DateTime>(nullable: false),
                    LastModificationTime = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Businesses", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Comments",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    TenantId = table.Column<int>(nullable: false),
                    CreatorUserId = table.Column<long>(nullable: true),
                    CreationTime = table.Column<DateTime>(nullable: false),
                    Contents = table.Column<string>(type: "text", nullable: true),
                    ForeignId = table.Column<long>(nullable: false),
                    ParentId = table.Column<long>(nullable: false),
                    AgreeCount = table.Column<long>(nullable: false),
                    AgainstCount = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comments", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Members",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CreatorUserId = table.Column<long>(nullable: true),
                    CreationTime = table.Column<DateTime>(nullable: false),
                    TenantId = table.Column<int>(nullable: false),
                    Photo = table.Column<string>(maxLength: 500, nullable: true),
                    Country = table.Column<string>(maxLength: 50, nullable: true),
                    Province = table.Column<string>(maxLength: 50, nullable: true),
                    City = table.Column<string>(maxLength: 50, nullable: true),
                    District = table.Column<string>(maxLength: 50, nullable: true),
                    Address = table.Column<string>(maxLength: 200, nullable: true),
                    QQ = table.Column<string>(maxLength: 50, nullable: true),
                    Phone = table.Column<string>(maxLength: 20, nullable: true),
                    Fax = table.Column<string>(maxLength: 20, nullable: true),
                    Mobile = table.Column<string>(maxLength: 20, nullable: true),
                    Sex = table.Column<string>(maxLength: 8, nullable: true),
                    Birthday = table.Column<DateTime>(nullable: true),
                    QQOpenID = table.Column<string>(maxLength: 20, nullable: true),
                    WXOpenID = table.Column<string>(maxLength: 20, nullable: true),
                    Points = table.Column<long>(nullable: false),
                    IDNum = table.Column<string>(maxLength: 50, nullable: true),
                    Zipcode = table.Column<string>(maxLength: 20, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Members", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Businesses");

            migrationBuilder.DropTable(
                name: "Comments");

            migrationBuilder.DropTable(
                name: "Members");

            migrationBuilder.DropColumn(
                name: "Author",
                table: "Article");

            migrationBuilder.DropColumn(
                name: "EndTime",
                table: "Article");

            migrationBuilder.DropColumn(
                name: "ExtendAttr",
                table: "Article");

            migrationBuilder.DropColumn(
                name: "FileUrl",
                table: "Article");

            migrationBuilder.DropColumn(
                name: "Hits",
                table: "Article");

            migrationBuilder.DropColumn(
                name: "ImageUrl",
                table: "Article");

            migrationBuilder.DropColumn(
                name: "IsHot",
                table: "Article");

            migrationBuilder.DropColumn(
                name: "IsRec",
                table: "Article");

            migrationBuilder.DropColumn(
                name: "IsTop",
                table: "Article");

            migrationBuilder.DropColumn(
                name: "LastModificationTime",
                table: "Article");

            migrationBuilder.DropColumn(
                name: "SubTitle",
                table: "Article");

            migrationBuilder.DropColumn(
                name: "Summary",
                table: "Article");

            migrationBuilder.DropColumn(
                name: "Tags",
                table: "Article");

            migrationBuilder.DropColumn(
                name: "VideoUrl",
                table: "Article");

            migrationBuilder.AlterColumn<string>(
                name: "CategoryName",
                table: "Category",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 50);
        }
    }
}
