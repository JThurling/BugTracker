using Microsoft.EntityFrameworkCore.Migrations;

namespace Infrastructure.Data.Migrations
{
    public partial class FixedExtraBugInfo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "24a24804-3120-40e4-9c50-a8fdfa765c9e");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "26a1854a-5018-4357-9945-34929b2ef6d3");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e6e53d7e-d685-4246-bebe-dc101a540944");

            migrationBuilder.DropColumn(
                name: "BugEntityId",
                table: "AspNetUsers");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "1aa88ac1-2954-4fa5-9d0e-5fa075874b15", "75af9280-6bbc-454d-8d7a-f2383f6b23c9", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "d951b215-f6dd-4ab7-be38-4c388ba54814", "43373fb5-365d-49f0-ae1f-2e9d68fb1cf9", "Manager", "Manager" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "69613c57-5155-4b5e-beaa-64c59005e6e7", "3d6e3e16-ed5d-42ae-836e-7e85ac07e966", "Developer", "DEVELOPER" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1aa88ac1-2954-4fa5-9d0e-5fa075874b15");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "69613c57-5155-4b5e-beaa-64c59005e6e7");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d951b215-f6dd-4ab7-be38-4c388ba54814");

            migrationBuilder.AddColumn<int>(
                name: "BugEntityId",
                table: "AspNetUsers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "24a24804-3120-40e4-9c50-a8fdfa765c9e", "920418c0-15f2-47ea-92d1-2c713cd07770", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "26a1854a-5018-4357-9945-34929b2ef6d3", "892ab218-1d8f-4dba-b8af-81b500ab2226", "Manager", "Manager" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "e6e53d7e-d685-4246-bebe-dc101a540944", "db924aa5-775c-4e9e-b381-9cbaca64878a", "Developer", "DEVELOPER" });
        }
    }
}
