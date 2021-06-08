using Microsoft.EntityFrameworkCore.Migrations;

namespace TheTuter.Migrations
{
    public partial class newfinal : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "29eb2226-64d6-4b31-a1c9-f76c463ac70d");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7df07ffc-3937-4645-af73-cef41e8f6b2e");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "aa3f16d1-56b6-4b8a-b4b7-f765e42176b7");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ed213659-2bbe-4f6e-9b15-0972de8deef2");

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

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "29eb2226-64d6-4b31-a1c9-f76c463ac70d", "23ed5694-b3fe-4f5b-8f4a-f5fc0921f5f3", "Visitor", "VISITOR" },
                    { "aa3f16d1-56b6-4b8a-b4b7-f765e42176b7", "2235e5d5-0648-49e4-901f-bcf9d3eb865d", "Teacher", "TEACHER" },
                    { "7df07ffc-3937-4645-af73-cef41e8f6b2e", "ce533b97-78c4-44b9-961b-f6ef495128a6", "Student", "STUDENT" },
                    { "ed213659-2bbe-4f6e-9b15-0972de8deef2", "6e7a22cd-8d00-4517-b573-4996c746122b", "Administrator", "ADMINISTRATOR" }
                });
        }
    }
}
