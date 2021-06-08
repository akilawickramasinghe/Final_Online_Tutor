using Microsoft.EntityFrameworkCore.Migrations;

namespace TheTuter.Migrations
{
    public partial class contact : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0e27a649-dddc-47cb-aade-f2e399af5f49");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1f1765cc-fc57-405b-b5ea-76e1b2d4439b");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "549f81d2-74b3-4ae5-ba66-d697273821d0");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "97829c43-67f6-45f2-8140-d348167c093f");

            migrationBuilder.CreateTable(
                name: "Contacts",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FullName = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    Phone = table.Column<string>(nullable: true),
                    Message = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contacts", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "a308ca2e-ee83-42db-a8fe-0d0171688645", "403f07cd-0bca-4ada-981c-5921ff154456", "Visitor", "VISITOR" },
                    { "b1ccb0b9-695b-46c6-af28-97e705a47d1f", "c9106346-2a04-4516-9472-511971ef7758", "Teacher", "TEACHER" },
                    { "81b8ea13-c376-4f91-a05f-54cc1c810bbd", "01c9cc0f-4606-481f-9ce7-2bad59c3cfeb", "Student", "STUDENT" },
                    { "ad38adac-0dd7-4c7a-841d-632f539d1500", "d65f9bbe-f682-4587-8d70-95f769a4526e", "Administrator", "ADMINISTRATOR" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Contacts");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "81b8ea13-c376-4f91-a05f-54cc1c810bbd");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a308ca2e-ee83-42db-a8fe-0d0171688645");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ad38adac-0dd7-4c7a-841d-632f539d1500");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b1ccb0b9-695b-46c6-af28-97e705a47d1f");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "549f81d2-74b3-4ae5-ba66-d697273821d0", "02199c82-c8ee-414b-a112-72ec4e420a1a", "Visitor", "VISITOR" },
                    { "0e27a649-dddc-47cb-aade-f2e399af5f49", "44a88342-d051-4924-bc74-e49a6c7a1ec7", "Teacher", "TEACHER" },
                    { "97829c43-67f6-45f2-8140-d348167c093f", "70a6229f-6e71-45e0-aa39-6a7534a889d2", "Student", "STUDENT" },
                    { "1f1765cc-fc57-405b-b5ea-76e1b2d4439b", "b9ef77cd-fcb1-411d-be7f-877860c2273a", "Administrator", "ADMINISTRATOR" }
                });
        }
    }
}
