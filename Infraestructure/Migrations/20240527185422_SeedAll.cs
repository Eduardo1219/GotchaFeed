using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Infraestructure.Migrations
{
    /// <inheritdoc />
    public partial class SeedAll : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Gotcha",
                columns: new[] { "Id", "Content", "CreationDate", "RepostQnt", "UserId" },
                values: new object[,]
                {
                    { new Guid("2043a6e8-8fee-455f-b051-a91302e83199"), "Another interesting gotcha!", new DateTime(2024, 5, 25, 15, 54, 21, 716, DateTimeKind.Local).AddTicks(2127), 20, new Guid("b09a4ec4-0cea-45fb-b992-a94208837d29") },
                    { new Guid("2868e482-3269-4e3e-87de-182f2ccf9549"), "Yet another gotcha post for you.", new DateTime(2024, 4, 27, 15, 54, 21, 716, DateTimeKind.Local).AddTicks(2133), 15, new Guid("b09a4ec4-0cea-45fb-b992-a94208837d29") },
                    { new Guid("58039889-aad1-46c2-9629-2712dfb7a06f"), "Last but not least, this gotcha!", new DateTime(2023, 5, 27, 15, 54, 21, 716, DateTimeKind.Local).AddTicks(2112), 25, new Guid("fba74d07-310a-4e3a-b689-bb129fbe566f") },
                    { new Guid("66e74488-264e-441c-8fbc-89ff91add7fb"), "Another interesting gotcha!", new DateTime(2024, 5, 25, 15, 54, 21, 716, DateTimeKind.Local).AddTicks(2116), 20, new Guid("0e3ee3ef-a250-436b-bae6-754e2685b18c") },
                    { new Guid("691d3a33-66ec-45e7-8c11-85cc28be380b"), "Last but not least, this gotcha!", new DateTime(2023, 5, 27, 15, 54, 21, 716, DateTimeKind.Local).AddTicks(2094), 25, new Guid("6cdf691d-db36-4f9d-b567-2173d8431354") },
                    { new Guid("73f80851-4179-4d57-ab10-411a343cb47c"), "Yet another gotcha post for you.", new DateTime(2024, 4, 27, 15, 54, 21, 716, DateTimeKind.Local).AddTicks(2108), 15, new Guid("fba74d07-310a-4e3a-b689-bb129fbe566f") },
                    { new Guid("8e9b1587-08dd-46f5-b1e6-37acf2af36b9"), "Last but not least, this gotcha!", new DateTime(2023, 5, 27, 15, 54, 21, 716, DateTimeKind.Local).AddTicks(2135), 25, new Guid("b09a4ec4-0cea-45fb-b992-a94208837d29") },
                    { new Guid("941ee39a-1fb6-4740-adeb-06b4674353b7"), "This is the first gotcha content.", new DateTime(2024, 5, 27, 10, 54, 21, 716, DateTimeKind.Local).AddTicks(2106), 10, new Guid("fba74d07-310a-4e3a-b689-bb129fbe566f") },
                    { new Guid("af6b344a-bf4c-44eb-94b7-754a2b4ed71a"), "Another interesting gotcha!", new DateTime(2024, 5, 25, 15, 54, 21, 716, DateTimeKind.Local).AddTicks(2085), 20, new Guid("6cdf691d-db36-4f9d-b567-2173d8431354") },
                    { new Guid("b8e06c8e-8b3b-4b44-89fe-a65dbcff4a59"), "Last but not least, this gotcha!", new DateTime(2023, 5, 27, 15, 54, 21, 716, DateTimeKind.Local).AddTicks(2123), 25, new Guid("0e3ee3ef-a250-436b-bae6-754e2685b18c") },
                    { new Guid("bd380514-1bef-41a6-84c5-d60a59a934b3"), "This is the first gotcha content.", new DateTime(2024, 5, 27, 10, 54, 21, 716, DateTimeKind.Local).AddTicks(2118), 10, new Guid("0e3ee3ef-a250-436b-bae6-754e2685b18c") },
                    { new Guid("c4f092b8-e38d-498e-9ebb-bd1132fbb5a0"), "This is the first gotcha content.", new DateTime(2024, 5, 27, 10, 54, 21, 716, DateTimeKind.Local).AddTicks(2125), 10, new Guid("b09a4ec4-0cea-45fb-b992-a94208837d29") },
                    { new Guid("d266314f-31c4-4421-8623-17468424fea2"), "This is the first gotcha content.", new DateTime(2024, 5, 27, 10, 54, 21, 716, DateTimeKind.Local).AddTicks(2077), 10, new Guid("6cdf691d-db36-4f9d-b567-2173d8431354") },
                    { new Guid("d436694b-2fc8-495e-9f23-1eeba70f6d70"), "This is the first gotcha content.", new DateTime(2024, 5, 27, 10, 54, 21, 716, DateTimeKind.Local).AddTicks(2088), 10, new Guid("6cdf691d-db36-4f9d-b567-2173d8431354") },
                    { new Guid("e91861f2-4f1b-4759-8cd2-67fdb15049fb"), "Yet another gotcha post for you.", new DateTime(2024, 4, 27, 15, 54, 21, 716, DateTimeKind.Local).AddTicks(2091), 15, new Guid("6cdf691d-db36-4f9d-b567-2173d8431354") },
                    { new Guid("f12b1436-deb1-4d48-8a9b-7e3baafbb000"), "Another interesting gotcha!", new DateTime(2024, 5, 25, 15, 54, 21, 716, DateTimeKind.Local).AddTicks(2104), 20, new Guid("fba74d07-310a-4e3a-b689-bb129fbe566f") },
                    { new Guid("f3ef7ea9-ad0e-4d5f-a417-da4b4a4edcec"), "This is the first gotcha content.", new DateTime(2024, 5, 27, 10, 54, 21, 716, DateTimeKind.Local).AddTicks(2103), 10, new Guid("fba74d07-310a-4e3a-b689-bb129fbe566f") },
                    { new Guid("f7ddac1c-7308-4e24-8af5-5f60c7a212ab"), "This is the first gotcha content.", new DateTime(2024, 5, 27, 10, 54, 21, 716, DateTimeKind.Local).AddTicks(2114), 10, new Guid("0e3ee3ef-a250-436b-bae6-754e2685b18c") },
                    { new Guid("fd9f73d1-02e8-4821-9bbb-4fba31df02e3"), "This is the first gotcha content.", new DateTime(2024, 5, 27, 10, 54, 21, 716, DateTimeKind.Local).AddTicks(2131), 10, new Guid("b09a4ec4-0cea-45fb-b992-a94208837d29") },
                    { new Guid("ff23f696-7d00-49a9-b862-2a8b9ccb8fa6"), "Yet another gotcha post for you.", new DateTime(2024, 4, 27, 15, 54, 21, 716, DateTimeKind.Local).AddTicks(2121), 15, new Guid("0e3ee3ef-a250-436b-bae6-754e2685b18c") }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Active", "BirthDate", "CreationDate", "Email", "ImgBase64", "LastAccessDate", "LastName", "Name", "Nickname", "PostsDay" },
                values: new object[,]
                {
                    { new Guid("0e3ee3ef-a250-436b-bae6-754e2685b18c"), true, new DateTime(1992, 8, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 11, 27, 15, 54, 21, 716, DateTimeKind.Local).AddTicks(1951), "alice.johnson@example.com", "0e3ee3ef-a250-436b-bae6-754e2685b18c.jpg", new DateTime(2024, 4, 27, 15, 54, 21, 716, DateTimeKind.Local).AddTicks(1955), "Johnson", "Alice", "aliceJ", 0 },
                    { new Guid("6cdf691d-db36-4f9d-b567-2173d8431354"), true, new DateTime(1990, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 5, 27, 15, 54, 21, 716, DateTimeKind.Local).AddTicks(1900), "john.doe@example.com", "6cdf691d-db36-4f9d-b567-2173d8431354.jpg", new DateTime(2024, 5, 27, 15, 54, 21, 716, DateTimeKind.Local).AddTicks(1925), "Doe", "John", "johnny", 0 },
                    { new Guid("b09a4ec4-0cea-45fb-b992-a94208837d29"), true, new DateTime(1988, 12, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 5, 27, 15, 54, 21, 716, DateTimeKind.Local).AddTicks(1965), "bob.brown@example.com", "b09a4ec4-0cea-45fb-b992-a94208837d29.jpg", new DateTime(2024, 5, 27, 10, 54, 21, 716, DateTimeKind.Local).AddTicks(1966), "Brown", "Bob", "bobby", 0 },
                    { new Guid("fba74d07-310a-4e3a-b689-bb129fbe566f"), true, new DateTime(1985, 3, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 5, 27, 15, 54, 21, 716, DateTimeKind.Local).AddTicks(1940), "jane.smith@example.com", "fba74d07-310a-4e3a-b689-bb129fbe566f.jpg", new DateTime(2024, 5, 26, 15, 54, 21, 716, DateTimeKind.Local).AddTicks(1941), "Smith", "Jane", "janeS", 0 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Gotcha",
                keyColumn: "Id",
                keyValue: new Guid("2043a6e8-8fee-455f-b051-a91302e83199"));

            migrationBuilder.DeleteData(
                table: "Gotcha",
                keyColumn: "Id",
                keyValue: new Guid("2868e482-3269-4e3e-87de-182f2ccf9549"));

            migrationBuilder.DeleteData(
                table: "Gotcha",
                keyColumn: "Id",
                keyValue: new Guid("58039889-aad1-46c2-9629-2712dfb7a06f"));

            migrationBuilder.DeleteData(
                table: "Gotcha",
                keyColumn: "Id",
                keyValue: new Guid("66e74488-264e-441c-8fbc-89ff91add7fb"));

            migrationBuilder.DeleteData(
                table: "Gotcha",
                keyColumn: "Id",
                keyValue: new Guid("691d3a33-66ec-45e7-8c11-85cc28be380b"));

            migrationBuilder.DeleteData(
                table: "Gotcha",
                keyColumn: "Id",
                keyValue: new Guid("73f80851-4179-4d57-ab10-411a343cb47c"));

            migrationBuilder.DeleteData(
                table: "Gotcha",
                keyColumn: "Id",
                keyValue: new Guid("8e9b1587-08dd-46f5-b1e6-37acf2af36b9"));

            migrationBuilder.DeleteData(
                table: "Gotcha",
                keyColumn: "Id",
                keyValue: new Guid("941ee39a-1fb6-4740-adeb-06b4674353b7"));

            migrationBuilder.DeleteData(
                table: "Gotcha",
                keyColumn: "Id",
                keyValue: new Guid("af6b344a-bf4c-44eb-94b7-754a2b4ed71a"));

            migrationBuilder.DeleteData(
                table: "Gotcha",
                keyColumn: "Id",
                keyValue: new Guid("b8e06c8e-8b3b-4b44-89fe-a65dbcff4a59"));

            migrationBuilder.DeleteData(
                table: "Gotcha",
                keyColumn: "Id",
                keyValue: new Guid("bd380514-1bef-41a6-84c5-d60a59a934b3"));

            migrationBuilder.DeleteData(
                table: "Gotcha",
                keyColumn: "Id",
                keyValue: new Guid("c4f092b8-e38d-498e-9ebb-bd1132fbb5a0"));

            migrationBuilder.DeleteData(
                table: "Gotcha",
                keyColumn: "Id",
                keyValue: new Guid("d266314f-31c4-4421-8623-17468424fea2"));

            migrationBuilder.DeleteData(
                table: "Gotcha",
                keyColumn: "Id",
                keyValue: new Guid("d436694b-2fc8-495e-9f23-1eeba70f6d70"));

            migrationBuilder.DeleteData(
                table: "Gotcha",
                keyColumn: "Id",
                keyValue: new Guid("e91861f2-4f1b-4759-8cd2-67fdb15049fb"));

            migrationBuilder.DeleteData(
                table: "Gotcha",
                keyColumn: "Id",
                keyValue: new Guid("f12b1436-deb1-4d48-8a9b-7e3baafbb000"));

            migrationBuilder.DeleteData(
                table: "Gotcha",
                keyColumn: "Id",
                keyValue: new Guid("f3ef7ea9-ad0e-4d5f-a417-da4b4a4edcec"));

            migrationBuilder.DeleteData(
                table: "Gotcha",
                keyColumn: "Id",
                keyValue: new Guid("f7ddac1c-7308-4e24-8af5-5f60c7a212ab"));

            migrationBuilder.DeleteData(
                table: "Gotcha",
                keyColumn: "Id",
                keyValue: new Guid("fd9f73d1-02e8-4821-9bbb-4fba31df02e3"));

            migrationBuilder.DeleteData(
                table: "Gotcha",
                keyColumn: "Id",
                keyValue: new Guid("ff23f696-7d00-49a9-b862-2a8b9ccb8fa6"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("0e3ee3ef-a250-436b-bae6-754e2685b18c"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("6cdf691d-db36-4f9d-b567-2173d8431354"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("b09a4ec4-0cea-45fb-b992-a94208837d29"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("fba74d07-310a-4e3a-b689-bb129fbe566f"));
        }
    }
}
