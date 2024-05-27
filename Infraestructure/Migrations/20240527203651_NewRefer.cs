using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Infraestructure.Migrations
{
    /// <inheritdoc />
    public partial class NewRefer : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.InsertData(
                table: "Gotcha",
                columns: new[] { "Id", "Content", "CreationDate", "RepostQnt", "UserId" },
                values: new object[,]
                {
                    { new Guid("1fb63c07-c689-4096-871b-a7940f9e3d7a"), "Another interesting gotcha!", new DateTime(2024, 5, 25, 17, 36, 51, 76, DateTimeKind.Local).AddTicks(3408), 0, new Guid("6cdf691d-db36-4f9d-b567-2173d8431354") },
                    { new Guid("2a69ff19-f466-4c9b-8a2c-b8f5080b6208"), "This is the first gotcha content.", new DateTime(2024, 5, 27, 12, 36, 51, 76, DateTimeKind.Local).AddTicks(3440), 0, new Guid("0e3ee3ef-a250-436b-bae6-754e2685b18c") },
                    { new Guid("2bc444d1-4a52-4fbf-8208-3e1b9785ed05"), "Last but not least, this gotcha!", new DateTime(2023, 5, 27, 17, 36, 51, 76, DateTimeKind.Local).AddTicks(3418), 0, new Guid("6cdf691d-db36-4f9d-b567-2173d8431354") },
                    { new Guid("32816f48-9944-4a86-b991-a5b529454e2e"), "Yet another gotcha post for you.", new DateTime(2024, 4, 27, 17, 36, 51, 76, DateTimeKind.Local).AddTicks(3455), 0, new Guid("b09a4ec4-0cea-45fb-b992-a94208837d29") },
                    { new Guid("38cf2ad4-30ac-46e2-9240-ca3e82250002"), "Last but not least, this gotcha!", new DateTime(2023, 5, 27, 17, 36, 51, 76, DateTimeKind.Local).AddTicks(3433), 0, new Guid("fba74d07-310a-4e3a-b689-bb129fbe566f") },
                    { new Guid("3b0303f0-ff85-4dd2-bd16-6cccea758914"), "Another interesting gotcha!", new DateTime(2024, 5, 25, 17, 36, 51, 76, DateTimeKind.Local).AddTicks(3438), 0, new Guid("0e3ee3ef-a250-436b-bae6-754e2685b18c") },
                    { new Guid("3f309c24-fa8c-4a73-9cd5-67348ce43bc1"), "Yet another gotcha post for you.", new DateTime(2024, 4, 27, 17, 36, 51, 76, DateTimeKind.Local).AddTicks(3442), 0, new Guid("0e3ee3ef-a250-436b-bae6-754e2685b18c") },
                    { new Guid("45a65064-ca61-4134-b1eb-790cffe074d0"), "This is the first gotcha content.", new DateTime(2024, 5, 27, 12, 36, 51, 76, DateTimeKind.Local).AddTicks(3447), 0, new Guid("b09a4ec4-0cea-45fb-b992-a94208837d29") },
                    { new Guid("518e3e45-fbc3-4c0d-9a6c-8a9dc8c4ac1c"), "Another interesting gotcha!", new DateTime(2024, 5, 25, 17, 36, 51, 76, DateTimeKind.Local).AddTicks(3427), 0, new Guid("fba74d07-310a-4e3a-b689-bb129fbe566f") },
                    { new Guid("52098a53-8925-42f0-be7d-95c40c7599fb"), "Last but not least, this gotcha!", new DateTime(2023, 5, 27, 17, 36, 51, 76, DateTimeKind.Local).AddTicks(3445), 0, new Guid("0e3ee3ef-a250-436b-bae6-754e2685b18c") },
                    { new Guid("638c2a44-f6e4-41ef-8136-4dbecbfd4472"), "This is the first gotcha content.", new DateTime(2024, 5, 27, 12, 36, 51, 76, DateTimeKind.Local).AddTicks(3437), 0, new Guid("0e3ee3ef-a250-436b-bae6-754e2685b18c") },
                    { new Guid("73a9a8db-cd15-476b-af61-854c35bbbf92"), "This is the first gotcha content.", new DateTime(2024, 5, 27, 12, 36, 51, 76, DateTimeKind.Local).AddTicks(3428), 0, new Guid("fba74d07-310a-4e3a-b689-bb129fbe566f") },
                    { new Guid("8d08cf02-f060-410d-8ad6-9b9e4e75b6ff"), "This is the first gotcha content.", new DateTime(2024, 5, 27, 12, 36, 51, 76, DateTimeKind.Local).AddTicks(3451), 0, new Guid("b09a4ec4-0cea-45fb-b992-a94208837d29") },
                    { new Guid("961f45f0-f5f9-4915-b32e-f6778862985d"), "This is the first gotcha content.", new DateTime(2024, 5, 27, 12, 36, 51, 76, DateTimeKind.Local).AddTicks(3413), 0, new Guid("6cdf691d-db36-4f9d-b567-2173d8431354") },
                    { new Guid("976e0afd-beb4-4ccc-8952-e9b068ebffb1"), "Yet another gotcha post for you.", new DateTime(2024, 4, 27, 17, 36, 51, 76, DateTimeKind.Local).AddTicks(3430), 0, new Guid("fba74d07-310a-4e3a-b689-bb129fbe566f") },
                    { new Guid("98687f30-e119-4463-a306-e7e2fe9df544"), "This is the first gotcha content.", new DateTime(2024, 5, 27, 12, 36, 51, 76, DateTimeKind.Local).AddTicks(3403), 0, new Guid("6cdf691d-db36-4f9d-b567-2173d8431354") },
                    { new Guid("9dc2afad-c7c5-43c9-b9ed-ae0fe6aee3c2"), "This is the first gotcha content.", new DateTime(2024, 5, 27, 12, 36, 51, 76, DateTimeKind.Local).AddTicks(3423), 0, new Guid("fba74d07-310a-4e3a-b689-bb129fbe566f") },
                    { new Guid("b703c185-b4ee-4f6c-b738-9b4f359cb849"), "Last but not least, this gotcha!", new DateTime(2023, 5, 27, 17, 36, 51, 76, DateTimeKind.Local).AddTicks(3456), 0, new Guid("b09a4ec4-0cea-45fb-b992-a94208837d29") },
                    { new Guid("b8bf6c5f-c110-459e-a80c-54325897efc7"), "Another interesting gotcha!", new DateTime(2024, 5, 25, 17, 36, 51, 76, DateTimeKind.Local).AddTicks(3449), 0, new Guid("b09a4ec4-0cea-45fb-b992-a94208837d29") },
                    { new Guid("fd1537ba-61ee-42c2-9284-d2012b844750"), "Yet another gotcha post for you.", new DateTime(2024, 4, 27, 17, 36, 51, 76, DateTimeKind.Local).AddTicks(3415), 0, new Guid("6cdf691d-db36-4f9d-b567-2173d8431354") }
                });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("0e3ee3ef-a250-436b-bae6-754e2685b18c"),
                columns: new[] { "CreationDate", "LastAccessDate" },
                values: new object[] { new DateTime(2023, 11, 27, 17, 36, 51, 76, DateTimeKind.Local).AddTicks(3334), new DateTime(2024, 4, 27, 17, 36, 51, 76, DateTimeKind.Local).AddTicks(3337) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("6cdf691d-db36-4f9d-b567-2173d8431354"),
                columns: new[] { "CreationDate", "LastAccessDate" },
                values: new object[] { new DateTime(2022, 5, 27, 17, 36, 51, 76, DateTimeKind.Local).AddTicks(3301), new DateTime(2024, 5, 27, 17, 36, 51, 76, DateTimeKind.Local).AddTicks(3318) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("b09a4ec4-0cea-45fb-b992-a94208837d29"),
                columns: new[] { "CreationDate", "LastAccessDate" },
                values: new object[] { new DateTime(2021, 5, 27, 17, 36, 51, 76, DateTimeKind.Local).AddTicks(3340), new DateTime(2024, 5, 27, 12, 36, 51, 76, DateTimeKind.Local).AddTicks(3342) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("fba74d07-310a-4e3a-b689-bb129fbe566f"),
                columns: new[] { "CreationDate", "LastAccessDate" },
                values: new object[] { new DateTime(2023, 5, 27, 17, 36, 51, 76, DateTimeKind.Local).AddTicks(3327), new DateTime(2024, 5, 26, 17, 36, 51, 76, DateTimeKind.Local).AddTicks(3328) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Gotcha",
                keyColumn: "Id",
                keyValue: new Guid("1fb63c07-c689-4096-871b-a7940f9e3d7a"));

            migrationBuilder.DeleteData(
                table: "Gotcha",
                keyColumn: "Id",
                keyValue: new Guid("2a69ff19-f466-4c9b-8a2c-b8f5080b6208"));

            migrationBuilder.DeleteData(
                table: "Gotcha",
                keyColumn: "Id",
                keyValue: new Guid("2bc444d1-4a52-4fbf-8208-3e1b9785ed05"));

            migrationBuilder.DeleteData(
                table: "Gotcha",
                keyColumn: "Id",
                keyValue: new Guid("32816f48-9944-4a86-b991-a5b529454e2e"));

            migrationBuilder.DeleteData(
                table: "Gotcha",
                keyColumn: "Id",
                keyValue: new Guid("38cf2ad4-30ac-46e2-9240-ca3e82250002"));

            migrationBuilder.DeleteData(
                table: "Gotcha",
                keyColumn: "Id",
                keyValue: new Guid("3b0303f0-ff85-4dd2-bd16-6cccea758914"));

            migrationBuilder.DeleteData(
                table: "Gotcha",
                keyColumn: "Id",
                keyValue: new Guid("3f309c24-fa8c-4a73-9cd5-67348ce43bc1"));

            migrationBuilder.DeleteData(
                table: "Gotcha",
                keyColumn: "Id",
                keyValue: new Guid("45a65064-ca61-4134-b1eb-790cffe074d0"));

            migrationBuilder.DeleteData(
                table: "Gotcha",
                keyColumn: "Id",
                keyValue: new Guid("518e3e45-fbc3-4c0d-9a6c-8a9dc8c4ac1c"));

            migrationBuilder.DeleteData(
                table: "Gotcha",
                keyColumn: "Id",
                keyValue: new Guid("52098a53-8925-42f0-be7d-95c40c7599fb"));

            migrationBuilder.DeleteData(
                table: "Gotcha",
                keyColumn: "Id",
                keyValue: new Guid("638c2a44-f6e4-41ef-8136-4dbecbfd4472"));

            migrationBuilder.DeleteData(
                table: "Gotcha",
                keyColumn: "Id",
                keyValue: new Guid("73a9a8db-cd15-476b-af61-854c35bbbf92"));

            migrationBuilder.DeleteData(
                table: "Gotcha",
                keyColumn: "Id",
                keyValue: new Guid("8d08cf02-f060-410d-8ad6-9b9e4e75b6ff"));

            migrationBuilder.DeleteData(
                table: "Gotcha",
                keyColumn: "Id",
                keyValue: new Guid("961f45f0-f5f9-4915-b32e-f6778862985d"));

            migrationBuilder.DeleteData(
                table: "Gotcha",
                keyColumn: "Id",
                keyValue: new Guid("976e0afd-beb4-4ccc-8952-e9b068ebffb1"));

            migrationBuilder.DeleteData(
                table: "Gotcha",
                keyColumn: "Id",
                keyValue: new Guid("98687f30-e119-4463-a306-e7e2fe9df544"));

            migrationBuilder.DeleteData(
                table: "Gotcha",
                keyColumn: "Id",
                keyValue: new Guid("9dc2afad-c7c5-43c9-b9ed-ae0fe6aee3c2"));

            migrationBuilder.DeleteData(
                table: "Gotcha",
                keyColumn: "Id",
                keyValue: new Guid("b703c185-b4ee-4f6c-b738-9b4f359cb849"));

            migrationBuilder.DeleteData(
                table: "Gotcha",
                keyColumn: "Id",
                keyValue: new Guid("b8bf6c5f-c110-459e-a80c-54325897efc7"));

            migrationBuilder.DeleteData(
                table: "Gotcha",
                keyColumn: "Id",
                keyValue: new Guid("fd1537ba-61ee-42c2-9284-d2012b844750"));

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

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("0e3ee3ef-a250-436b-bae6-754e2685b18c"),
                columns: new[] { "CreationDate", "LastAccessDate" },
                values: new object[] { new DateTime(2023, 11, 27, 15, 54, 21, 716, DateTimeKind.Local).AddTicks(1951), new DateTime(2024, 4, 27, 15, 54, 21, 716, DateTimeKind.Local).AddTicks(1955) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("6cdf691d-db36-4f9d-b567-2173d8431354"),
                columns: new[] { "CreationDate", "LastAccessDate" },
                values: new object[] { new DateTime(2022, 5, 27, 15, 54, 21, 716, DateTimeKind.Local).AddTicks(1900), new DateTime(2024, 5, 27, 15, 54, 21, 716, DateTimeKind.Local).AddTicks(1925) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("b09a4ec4-0cea-45fb-b992-a94208837d29"),
                columns: new[] { "CreationDate", "LastAccessDate" },
                values: new object[] { new DateTime(2021, 5, 27, 15, 54, 21, 716, DateTimeKind.Local).AddTicks(1965), new DateTime(2024, 5, 27, 10, 54, 21, 716, DateTimeKind.Local).AddTicks(1966) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("fba74d07-310a-4e3a-b689-bb129fbe566f"),
                columns: new[] { "CreationDate", "LastAccessDate" },
                values: new object[] { new DateTime(2023, 5, 27, 15, 54, 21, 716, DateTimeKind.Local).AddTicks(1940), new DateTime(2024, 5, 26, 15, 54, 21, 716, DateTimeKind.Local).AddTicks(1941) });
        }
    }
}
