using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Pisheyar.Infrastructure.Migrations
{
    public partial class AddSuggestedAndIsInSliderPropertiesToPostTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsInSlider",
                table: "Post",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsSuggested",
                table: "Post",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "Admin",
                keyColumn: "AdminID",
                keyValue: 1,
                columns: new[] { "AdminGUID", "ModifiedDate" },
                values: new object[] { new Guid("6a617f84-e634-4199-a27f-f696edf05a49"), new DateTime(2020, 6, 8, 18, 21, 58, 275, DateTimeKind.Local).AddTicks(2680) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "CategoryID",
                keyValue: 1,
                columns: new[] { "CategoryGUID", "IsActive", "ModifiedDate" },
                values: new object[] { new Guid("c265fd02-0194-4d38-83e8-a93bc3698fcc"), true, new DateTime(2020, 6, 8, 18, 21, 58, 279, DateTimeKind.Local).AddTicks(6247) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "CategoryID",
                keyValue: 2,
                columns: new[] { "CategoryGUID", "IsActive", "ModifiedDate" },
                values: new object[] { new Guid("dec37f17-0ab2-4208-8ba7-11cc1120369b"), true, new DateTime(2020, 6, 8, 18, 21, 58, 279, DateTimeKind.Local).AddTicks(7779) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "CategoryID",
                keyValue: 3,
                columns: new[] { "CategoryGUID", "IsActive", "ModifiedDate" },
                values: new object[] { new Guid("0e9728b1-1a44-4c22-825a-c6453a7a3e0b"), true, new DateTime(2020, 6, 8, 18, 21, 58, 279, DateTimeKind.Local).AddTicks(7831) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "CategoryID",
                keyValue: 4,
                columns: new[] { "CategoryGUID", "IsActive", "ModifiedDate" },
                values: new object[] { new Guid("90bd9f83-5df2-456e-b0f4-aa025b7d6832"), true, new DateTime(2020, 6, 8, 18, 21, 58, 279, DateTimeKind.Local).AddTicks(7894) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "CategoryID",
                keyValue: 5,
                columns: new[] { "CategoryGUID", "IsActive", "ModifiedDate" },
                values: new object[] { new Guid("77120262-bd3e-4a7a-9604-65dc86123b6a"), true, new DateTime(2020, 6, 8, 18, 21, 58, 279, DateTimeKind.Local).AddTicks(7903) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "CategoryID",
                keyValue: 6,
                columns: new[] { "CategoryGUID", "IsActive", "ModifiedDate" },
                values: new object[] { new Guid("66eccd82-d1a9-4d32-9469-2840ac0e04d2"), true, new DateTime(2020, 6, 8, 18, 21, 58, 279, DateTimeKind.Local).AddTicks(7920) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "CategoryID",
                keyValue: 7,
                columns: new[] { "CategoryGUID", "IsActive", "ModifiedDate" },
                values: new object[] { new Guid("dd248122-cafd-4f15-983e-a6f001b32d40"), true, new DateTime(2020, 6, 8, 18, 21, 58, 279, DateTimeKind.Local).AddTicks(7928) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "CategoryID",
                keyValue: 8,
                columns: new[] { "CategoryGUID", "IsActive", "ModifiedDate" },
                values: new object[] { new Guid("a50794b5-f695-4491-a198-f01fae449177"), true, new DateTime(2020, 6, 8, 18, 21, 58, 279, DateTimeKind.Local).AddTicks(7937) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "CategoryID",
                keyValue: 9,
                columns: new[] { "CategoryGUID", "IsActive", "ModifiedDate" },
                values: new object[] { new Guid("2396a9da-69f9-47cc-919a-1e088c775895"), true, new DateTime(2020, 6, 8, 18, 21, 58, 279, DateTimeKind.Local).AddTicks(7944) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "CategoryID",
                keyValue: 10,
                columns: new[] { "CategoryGUID", "IsActive", "ModifiedDate" },
                values: new object[] { new Guid("b0e9bd69-7ea7-497a-876f-80a74d72970d"), true, new DateTime(2020, 6, 8, 18, 21, 58, 279, DateTimeKind.Local).AddTicks(7952) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "CategoryID",
                keyValue: 11,
                columns: new[] { "CategoryGUID", "IsActive", "ModifiedDate" },
                values: new object[] { new Guid("a8aff1c6-6ab9-4a37-8c92-120dfb98c6c1"), true, new DateTime(2020, 6, 8, 18, 21, 58, 279, DateTimeKind.Local).AddTicks(7960) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "CategoryID",
                keyValue: 12,
                columns: new[] { "CategoryGUID", "IsActive", "ModifiedDate" },
                values: new object[] { new Guid("edc64063-a96d-464f-be21-efeaf6b48ff4"), true, new DateTime(2020, 6, 8, 18, 21, 58, 279, DateTimeKind.Local).AddTicks(7968) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "CategoryID",
                keyValue: 13,
                columns: new[] { "CategoryGUID", "IsActive", "ModifiedDate" },
                values: new object[] { new Guid("ff1f90d2-32f7-4c2b-ae6a-9ad86289c238"), true, new DateTime(2020, 6, 8, 18, 21, 58, 279, DateTimeKind.Local).AddTicks(7975) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "CategoryID",
                keyValue: 14,
                columns: new[] { "CategoryGUID", "IsActive", "ModifiedDate" },
                values: new object[] { new Guid("517a72b4-dbe9-45e8-b625-009f1ba57253"), true, new DateTime(2020, 6, 8, 18, 21, 58, 279, DateTimeKind.Local).AddTicks(7985) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "CategoryID",
                keyValue: 15,
                columns: new[] { "CategoryGUID", "IsActive", "ModifiedDate" },
                values: new object[] { new Guid("1ee67e0b-faa8-4808-8f9a-810051fd15e7"), true, new DateTime(2020, 6, 8, 18, 21, 58, 279, DateTimeKind.Local).AddTicks(7993) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "CategoryID",
                keyValue: 16,
                columns: new[] { "CategoryGUID", "IsActive", "ModifiedDate" },
                values: new object[] { new Guid("784e6198-0dc1-434f-8773-378f7a0e9ba5"), true, new DateTime(2020, 6, 8, 18, 21, 58, 279, DateTimeKind.Local).AddTicks(8000) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "CategoryID",
                keyValue: 17,
                columns: new[] { "CategoryGUID", "IsActive", "ModifiedDate" },
                values: new object[] { new Guid("5955a06d-a011-4f65-ac00-fb07276c6645"), true, new DateTime(2020, 6, 8, 18, 21, 58, 279, DateTimeKind.Local).AddTicks(8008) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "CategoryID",
                keyValue: 18,
                columns: new[] { "CategoryGUID", "IsActive", "ModifiedDate" },
                values: new object[] { new Guid("a5f03e62-ca63-4ab4-bbf3-27620e65ec64"), true, new DateTime(2020, 6, 8, 18, 21, 58, 279, DateTimeKind.Local).AddTicks(8015) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "CategoryID",
                keyValue: 19,
                columns: new[] { "CategoryGUID", "IsActive", "ModifiedDate" },
                values: new object[] { new Guid("32f4502f-3660-4a24-a9c7-4aed0fff0be8"), true, new DateTime(2020, 6, 8, 18, 21, 58, 279, DateTimeKind.Local).AddTicks(8022) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "CategoryID",
                keyValue: 20,
                columns: new[] { "CategoryGUID", "IsActive", "ModifiedDate" },
                values: new object[] { new Guid("6fe14ae9-63fc-44cd-bc33-7ed1abc6fc83"), true, new DateTime(2020, 6, 8, 18, 21, 58, 279, DateTimeKind.Local).AddTicks(8071) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "CategoryID",
                keyValue: 21,
                columns: new[] { "CategoryGUID", "IsActive", "ModifiedDate" },
                values: new object[] { new Guid("22386393-9da2-4230-8195-9031eb5d2641"), true, new DateTime(2020, 6, 8, 18, 21, 58, 279, DateTimeKind.Local).AddTicks(8080) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "CategoryID",
                keyValue: 22,
                columns: new[] { "CategoryGUID", "IsActive", "ModifiedDate" },
                values: new object[] { new Guid("57f02758-4539-4e8f-8927-b5750f8d1964"), true, new DateTime(2020, 6, 8, 18, 21, 58, 279, DateTimeKind.Local).AddTicks(8090) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "CategoryID",
                keyValue: 23,
                columns: new[] { "CategoryGUID", "IsActive", "ModifiedDate" },
                values: new object[] { new Guid("99ac5478-c2fb-44b7-a3f7-e24ee618fd53"), true, new DateTime(2020, 6, 8, 18, 21, 58, 279, DateTimeKind.Local).AddTicks(8099) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "CategoryID",
                keyValue: 24,
                columns: new[] { "CategoryGUID", "IsActive", "ModifiedDate" },
                values: new object[] { new Guid("ef959ebf-1b34-4ff9-a11c-01a9af4c28cf"), true, new DateTime(2020, 6, 8, 18, 21, 58, 279, DateTimeKind.Local).AddTicks(8106) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "CategoryID",
                keyValue: 25,
                columns: new[] { "CategoryGUID", "IsActive", "ModifiedDate" },
                values: new object[] { new Guid("7074a922-58ae-405a-a0d1-1be31cbce683"), true, new DateTime(2020, 6, 8, 18, 21, 58, 279, DateTimeKind.Local).AddTicks(8113) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "CategoryID",
                keyValue: 26,
                columns: new[] { "CategoryGUID", "IsActive", "ModifiedDate" },
                values: new object[] { new Guid("d281f91a-3e8a-4ab4-bb18-88a518e6d17a"), true, new DateTime(2020, 6, 8, 18, 21, 58, 279, DateTimeKind.Local).AddTicks(8120) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "CategoryID",
                keyValue: 27,
                columns: new[] { "CategoryGUID", "IsActive", "ModifiedDate" },
                values: new object[] { new Guid("19d2cf56-3baf-44d6-8be9-8c2cb936ad9b"), true, new DateTime(2020, 6, 8, 18, 21, 58, 279, DateTimeKind.Local).AddTicks(8128) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "CategoryID",
                keyValue: 28,
                columns: new[] { "CategoryGUID", "IsActive", "ModifiedDate" },
                values: new object[] { new Guid("35364c57-c5e0-4351-8a03-134e6e41a4fa"), true, new DateTime(2020, 6, 8, 18, 21, 58, 279, DateTimeKind.Local).AddTicks(8135) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "CategoryID",
                keyValue: 29,
                columns: new[] { "CategoryGUID", "IsActive", "ModifiedDate" },
                values: new object[] { new Guid("4cab7cc3-92d9-4311-aba1-36a222bf50a4"), true, new DateTime(2020, 6, 8, 18, 21, 58, 279, DateTimeKind.Local).AddTicks(8143) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "CategoryID",
                keyValue: 30,
                columns: new[] { "CategoryGUID", "IsActive", "ModifiedDate" },
                values: new object[] { new Guid("dbe60ba9-ce9e-462d-beff-768ba7ce30f1"), true, new DateTime(2020, 6, 8, 18, 21, 58, 279, DateTimeKind.Local).AddTicks(8153) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "CategoryID",
                keyValue: 31,
                columns: new[] { "CategoryGUID", "IsActive", "ModifiedDate" },
                values: new object[] { new Guid("b075d77a-c1a8-43d6-b0ae-90c7b4a00e0e"), true, new DateTime(2020, 6, 8, 18, 21, 58, 279, DateTimeKind.Local).AddTicks(8160) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "CategoryID",
                keyValue: 32,
                columns: new[] { "CategoryGUID", "IsActive", "ModifiedDate" },
                values: new object[] { new Guid("b727db27-5a44-4910-80b3-b4beef834f2c"), true, new DateTime(2020, 6, 8, 18, 21, 58, 279, DateTimeKind.Local).AddTicks(8167) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "CategoryID",
                keyValue: 33,
                columns: new[] { "CategoryGUID", "IsActive", "ModifiedDate" },
                values: new object[] { new Guid("b305e5ad-53ca-4aa6-be3c-69cf9a7773aa"), true, new DateTime(2020, 6, 8, 18, 21, 58, 279, DateTimeKind.Local).AddTicks(8175) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "CategoryID",
                keyValue: 34,
                columns: new[] { "CategoryGUID", "IsActive", "ModifiedDate" },
                values: new object[] { new Guid("aba931da-9046-45a5-ad33-f30d03bb036a"), true, new DateTime(2020, 6, 8, 18, 21, 58, 279, DateTimeKind.Local).AddTicks(8182) });

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1,
                column: "CityGUID",
                value: new Guid("fa8d9b24-ac10-4ef7-8afa-47ef79f35f42"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 2,
                column: "CityGUID",
                value: new Guid("7ee6c487-bddd-4153-b483-007271687f7c"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 3,
                column: "CityGUID",
                value: new Guid("cfc10624-4cab-455e-8827-d1873a1d0b33"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 4,
                column: "CityGUID",
                value: new Guid("21510dfa-4092-47a0-b1b7-ae3cbf589c55"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 5,
                column: "CityGUID",
                value: new Guid("bf34dc00-9aa0-4f6e-8147-d0aed75bbfe3"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 6,
                column: "CityGUID",
                value: new Guid("7a8236b5-9dfb-4aea-b03f-af4bae60180b"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 7,
                column: "CityGUID",
                value: new Guid("2a4d33a1-0aa5-43d5-95d8-1153c4fead51"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 8,
                column: "CityGUID",
                value: new Guid("751ae903-afc7-4371-ada6-c657555d624d"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 9,
                column: "CityGUID",
                value: new Guid("0e1cb80e-a7a9-43b5-98da-c89a18584f3c"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 10,
                column: "CityGUID",
                value: new Guid("13f1129e-2084-41bc-b2fb-37ea2149f768"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 11,
                column: "CityGUID",
                value: new Guid("5051aafb-e92e-4fd7-b803-099fd6909e7c"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 12,
                column: "CityGUID",
                value: new Guid("2acc03f3-2774-4024-adf1-650ce61b118f"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 13,
                column: "CityGUID",
                value: new Guid("781b9984-a532-41fb-bdbc-19d61caa30ea"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 14,
                column: "CityGUID",
                value: new Guid("18297b25-1947-4587-86c8-114d7a9e9ff1"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 15,
                column: "CityGUID",
                value: new Guid("a6c05866-858b-43a1-90d2-b7cf623473e8"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 16,
                column: "CityGUID",
                value: new Guid("368e5fb5-4c48-45c0-82ea-cf8e6d96e09b"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 17,
                column: "CityGUID",
                value: new Guid("217357dd-9133-48ee-a192-495eb91efff9"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 18,
                column: "CityGUID",
                value: new Guid("4d42d914-cfe1-4879-b66c-467f6b1ab0e3"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 19,
                column: "CityGUID",
                value: new Guid("ac1d0768-e32a-41cc-acfa-0b8ef55f633c"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 20,
                column: "CityGUID",
                value: new Guid("61ab5264-f592-4c74-ae42-50f1de065a02"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 21,
                column: "CityGUID",
                value: new Guid("1d33ece1-4730-4a2c-86c2-4a0e7f24ba56"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 22,
                column: "CityGUID",
                value: new Guid("aeb62ba1-2bc5-4818-ba28-c451369e8be0"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 23,
                column: "CityGUID",
                value: new Guid("335d8883-89db-4c5a-984e-3260ac8b5587"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 24,
                column: "CityGUID",
                value: new Guid("be906752-c1eb-4b89-b2a9-a8e7f4dde003"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 25,
                column: "CityGUID",
                value: new Guid("80d5e963-35c5-4aaa-9413-cab62cff99e6"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 26,
                column: "CityGUID",
                value: new Guid("e2fc4c44-0b4d-4b56-a8d7-69773f88f6a2"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 27,
                column: "CityGUID",
                value: new Guid("d9490072-a202-4183-960f-05fbc588a5b6"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 28,
                column: "CityGUID",
                value: new Guid("d1c3aef4-d36d-4da6-ae3c-8ff49600c0a3"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 29,
                column: "CityGUID",
                value: new Guid("2d0879c6-325d-4eac-ab07-b59313cb4500"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 30,
                column: "CityGUID",
                value: new Guid("67b89b58-efa5-4b6b-80d1-7fe8ee93894a"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 31,
                column: "CityGUID",
                value: new Guid("bc50928b-d335-4385-b175-0e353c83d854"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 32,
                column: "CityGUID",
                value: new Guid("640418e3-f8d1-4851-97f8-757a591f9c42"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 33,
                column: "CityGUID",
                value: new Guid("ba4a10e6-cc87-498d-ae7a-f583d9d8d8ee"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 34,
                column: "CityGUID",
                value: new Guid("8dc9e0fa-3770-4c05-b4d1-61f67758b0c8"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 35,
                column: "CityGUID",
                value: new Guid("60e0dea6-6052-48eb-8def-4d3c439472db"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 36,
                column: "CityGUID",
                value: new Guid("43e4d693-7a00-4c28-a153-0ff3277c6719"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 37,
                column: "CityGUID",
                value: new Guid("a0faa26b-3ed7-4d4a-94bd-4d39a0ad9de4"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 38,
                column: "CityGUID",
                value: new Guid("c1401964-86df-4c6e-8483-065c0e339f71"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 39,
                column: "CityGUID",
                value: new Guid("edcc2a96-676b-49d1-bf15-9d8d62876b63"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 40,
                column: "CityGUID",
                value: new Guid("4f9d50a1-56d6-458d-896e-a53459d36a3f"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 41,
                column: "CityGUID",
                value: new Guid("07e800e0-19e8-466a-9be3-f6907f225057"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 42,
                column: "CityGUID",
                value: new Guid("c2367dd1-970a-4e3a-adde-90ac5950fd21"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 43,
                column: "CityGUID",
                value: new Guid("834d3b62-0b43-4309-9d52-4beb3a3ddf25"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 44,
                column: "CityGUID",
                value: new Guid("95a7438f-308b-40bc-be46-5460e2f33529"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 45,
                column: "CityGUID",
                value: new Guid("0c7bd57f-9310-4443-b366-9ef88940bc3b"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 46,
                column: "CityGUID",
                value: new Guid("0f8c677b-8040-4521-87a4-a7c4111cf840"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 47,
                column: "CityGUID",
                value: new Guid("10d08148-d09a-48ac-b394-71f6511a2867"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 48,
                column: "CityGUID",
                value: new Guid("cc7dbda8-f68d-41dd-bf65-241166f7801d"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 49,
                column: "CityGUID",
                value: new Guid("d5a14ae4-c183-48d6-acad-dbe754877e8d"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 50,
                column: "CityGUID",
                value: new Guid("4e77c29d-67df-41b7-87a1-b6747aa73b02"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 51,
                column: "CityGUID",
                value: new Guid("8a00332e-3d75-4053-98b0-98cf2ae9ff2f"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 52,
                column: "CityGUID",
                value: new Guid("ee0b96b7-285e-40dd-abd3-feb043b3439c"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 53,
                column: "CityGUID",
                value: new Guid("df74e878-c178-4d6b-b26a-c581b506eb13"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 54,
                column: "CityGUID",
                value: new Guid("3b0cea2c-6500-48b7-9901-3df7b40ed898"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 55,
                column: "CityGUID",
                value: new Guid("3e64153b-af49-4320-924a-3dac890c7943"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 56,
                column: "CityGUID",
                value: new Guid("915d3f3c-cd6c-46ae-a5c2-3aba43100b20"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 57,
                column: "CityGUID",
                value: new Guid("8cb623ac-76d6-438f-85da-995538b23074"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 58,
                column: "CityGUID",
                value: new Guid("e1239507-185e-4e5a-86ec-f385590074be"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 59,
                column: "CityGUID",
                value: new Guid("ff484e6f-b1b1-4319-9ee3-f43dbb7723c4"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 60,
                column: "CityGUID",
                value: new Guid("d56a781e-61a7-4604-a81b-e4570d919d25"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 61,
                column: "CityGUID",
                value: new Guid("23aa7a54-710c-49ff-9930-fbf57f99192d"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 62,
                column: "CityGUID",
                value: new Guid("2272a132-52e2-491f-8fa4-e1c2c3dcab29"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 63,
                column: "CityGUID",
                value: new Guid("cd3300f1-7a75-46c5-8fa3-1c5327c22eb7"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 64,
                column: "CityGUID",
                value: new Guid("af32ab29-f035-42d6-8d6c-451c1270aaa8"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 65,
                column: "CityGUID",
                value: new Guid("e52b4b56-a1f7-41ec-abec-4cc6cc12ae82"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 66,
                column: "CityGUID",
                value: new Guid("f94c8bb5-a531-41dd-a1b7-47552c740039"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 67,
                column: "CityGUID",
                value: new Guid("cb3fa439-4ec8-43e1-a469-e8f8ce4451b6"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 68,
                column: "CityGUID",
                value: new Guid("d8af74c0-4ab7-4060-bee1-0ad7d330a585"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 69,
                column: "CityGUID",
                value: new Guid("26e8fdd2-abc9-4c0d-bcff-e831dc782d32"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 70,
                column: "CityGUID",
                value: new Guid("e6519653-d4ce-4062-bac2-c3e22a610411"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 71,
                column: "CityGUID",
                value: new Guid("8c7ebfa6-31a3-4051-a127-74bf0f7a8572"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 72,
                column: "CityGUID",
                value: new Guid("a9721a33-598c-4104-a7e0-727a87353089"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 73,
                column: "CityGUID",
                value: new Guid("c1e0a3d9-1031-4b1b-b084-50598a5fb430"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 74,
                column: "CityGUID",
                value: new Guid("270fb27c-2173-4ef7-b1e6-21bd3b564b31"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 75,
                column: "CityGUID",
                value: new Guid("71b0ab20-adc8-43b5-b57d-f5a40a7dfceb"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 76,
                column: "CityGUID",
                value: new Guid("e3a2d923-688d-4c57-8da9-727a3931dcfb"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 77,
                column: "CityGUID",
                value: new Guid("f3276454-70a6-4582-9b43-97743fbcc14b"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 78,
                column: "CityGUID",
                value: new Guid("a749f96d-d549-465a-a253-63bab25c3b08"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 79,
                column: "CityGUID",
                value: new Guid("79396b5a-4d99-4204-8edb-185b0ec204c9"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 80,
                column: "CityGUID",
                value: new Guid("dbb90f0e-f90e-4163-b7f1-7d2d8f1dccd4"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 81,
                column: "CityGUID",
                value: new Guid("7531d889-2263-433b-9c36-a2f0efd717cf"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 82,
                column: "CityGUID",
                value: new Guid("c50f4599-2162-4289-922a-165603da4719"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 83,
                column: "CityGUID",
                value: new Guid("c02246f2-6a84-421b-a0d8-33649bdf822e"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 84,
                column: "CityGUID",
                value: new Guid("29461ab7-258c-4152-bd97-0a4c7c16abd4"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 85,
                column: "CityGUID",
                value: new Guid("f905b430-fac5-49a3-a07a-84136ac53e0a"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 86,
                column: "CityGUID",
                value: new Guid("fbf2b20b-679f-4543-bf7f-51db8d432a4d"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 87,
                column: "CityGUID",
                value: new Guid("0adbb4bd-1d0e-4104-a06c-e02f4676265c"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 88,
                column: "CityGUID",
                value: new Guid("de996261-480c-4d0f-a605-d3fe0000009d"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 89,
                column: "CityGUID",
                value: new Guid("04ee49e3-d144-4069-8e58-1b8a4d9170c8"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 90,
                column: "CityGUID",
                value: new Guid("ed8e062a-246f-499a-9437-13990233ca3f"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 91,
                column: "CityGUID",
                value: new Guid("668baef6-5604-49fc-8f13-be711502ef88"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 92,
                column: "CityGUID",
                value: new Guid("9fded22b-288c-4ada-a7a7-28c6fbd22c54"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 93,
                column: "CityGUID",
                value: new Guid("84ff7762-59b9-40c0-a6ac-17697f014d30"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 94,
                column: "CityGUID",
                value: new Guid("2b17eae7-91a2-4969-b8d1-7b8753214a1e"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 95,
                column: "CityGUID",
                value: new Guid("e6eecb1c-4180-4a8a-9ea6-bc4359716dd3"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 96,
                column: "CityGUID",
                value: new Guid("88532596-455b-415e-ad1f-53ce09ca881d"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 97,
                column: "CityGUID",
                value: new Guid("71ae66e2-d7dc-4a3e-bfd5-c70c8f1b94d0"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 98,
                column: "CityGUID",
                value: new Guid("181a1399-932b-46d4-9947-5a13ef8dced8"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 99,
                column: "CityGUID",
                value: new Guid("f6efbaa4-ee6c-4156-ac4c-16839fbfec2c"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 100,
                column: "CityGUID",
                value: new Guid("f493dc34-2161-4c5e-83fa-0d60991b96d0"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 101,
                column: "CityGUID",
                value: new Guid("c00b30d3-d23d-4abd-9e05-1f2098198aa6"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 102,
                column: "CityGUID",
                value: new Guid("bbabce70-6345-466a-b093-5cae4631b79a"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 103,
                column: "CityGUID",
                value: new Guid("82d4bdee-249a-4948-b92f-0263cf6dc2d8"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 104,
                column: "CityGUID",
                value: new Guid("173bf249-919c-458e-b602-5feaafcafaae"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 105,
                column: "CityGUID",
                value: new Guid("23723cbc-a81e-4933-8c7a-c123bd65653f"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 106,
                column: "CityGUID",
                value: new Guid("f1af29d6-e62e-4ed3-82df-93a4832e3358"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 107,
                column: "CityGUID",
                value: new Guid("3cc0611e-31f3-405b-9e1b-8d4137744267"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 108,
                column: "CityGUID",
                value: new Guid("b9254042-fd50-4842-8b80-585f78700c56"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 109,
                column: "CityGUID",
                value: new Guid("69131e6d-ca45-4da5-9e03-4f8d843cc3d4"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 110,
                column: "CityGUID",
                value: new Guid("a7f12f89-a660-4ad4-9e47-8664f860f511"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 111,
                column: "CityGUID",
                value: new Guid("7f496a9b-cd71-4547-b91e-515192102401"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 112,
                column: "CityGUID",
                value: new Guid("623b25ff-cf43-4eba-be28-e27d1d9758ba"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 113,
                column: "CityGUID",
                value: new Guid("123d1e45-381a-43da-94d3-c01a10436548"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 114,
                column: "CityGUID",
                value: new Guid("412b857f-dcb9-45b5-aad8-2cb43192757e"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 115,
                column: "CityGUID",
                value: new Guid("4491832c-65e9-42bf-9eee-ea2bee5190ae"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 116,
                column: "CityGUID",
                value: new Guid("897434cd-1775-414f-9384-a42fcc24603d"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 117,
                column: "CityGUID",
                value: new Guid("d32c8c8c-ae73-403a-9c5a-f31741f1721a"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 118,
                column: "CityGUID",
                value: new Guid("97c29bd1-3dcd-4302-ae8e-3f5adcb285a9"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 119,
                column: "CityGUID",
                value: new Guid("630b210b-2fbd-4467-923c-10efd2898540"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 120,
                column: "CityGUID",
                value: new Guid("05371f6f-49f0-46e0-afcc-e5ae62e614b8"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 121,
                column: "CityGUID",
                value: new Guid("a1ea018b-6233-4f55-b2da-ccd433fbe484"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 122,
                column: "CityGUID",
                value: new Guid("a3c70a28-ed85-4fe4-9709-8cd5e254dceb"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 123,
                column: "CityGUID",
                value: new Guid("1f8f4a02-7687-4992-999b-9463751e0758"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 124,
                column: "CityGUID",
                value: new Guid("fcd7404c-5c22-41be-aebd-24ab31bdb730"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 125,
                column: "CityGUID",
                value: new Guid("d218d883-0a7e-44e4-b845-615942c99dfb"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 126,
                column: "CityGUID",
                value: new Guid("5b841099-54ae-4d24-95cb-9517714ee9a2"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 127,
                column: "CityGUID",
                value: new Guid("0255d1b2-519d-4300-acc9-7a746bfb5541"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 128,
                column: "CityGUID",
                value: new Guid("55db1e46-ed43-4030-95df-a39b0d868c7b"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 129,
                column: "CityGUID",
                value: new Guid("82868513-f69e-4c01-bc88-a312aa128294"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 130,
                column: "CityGUID",
                value: new Guid("c5143be8-09de-4d73-8f9b-477e110869c9"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 131,
                column: "CityGUID",
                value: new Guid("1338a699-b467-4679-9a5a-552e3af3f385"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 132,
                column: "CityGUID",
                value: new Guid("33daea34-5e3b-4540-a29b-ef8b9b920771"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 133,
                column: "CityGUID",
                value: new Guid("e81ee0d2-fbb3-4e1e-a36a-5a0ab596f4fa"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 134,
                column: "CityGUID",
                value: new Guid("ec22f05b-2081-4a20-8b70-a51d84c4ec46"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 135,
                column: "CityGUID",
                value: new Guid("9f81be58-6066-4ad8-88c9-7ea953ec1b4c"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 136,
                column: "CityGUID",
                value: new Guid("0b5cb041-20c2-47f4-b3b3-344823973cd3"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 137,
                column: "CityGUID",
                value: new Guid("0700eb10-5418-4c2b-a191-7334c9678898"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 138,
                column: "CityGUID",
                value: new Guid("37d0bffc-4098-4482-88df-f2ab473a703f"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 139,
                column: "CityGUID",
                value: new Guid("bf73ef85-a47f-4018-a70d-21a60d6a1e2e"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 140,
                column: "CityGUID",
                value: new Guid("311e2685-34c4-43d9-bf38-4546dcef5789"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 141,
                column: "CityGUID",
                value: new Guid("15532a15-1514-425c-ad70-d2e42154858c"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 142,
                column: "CityGUID",
                value: new Guid("7be7557d-a9c7-4537-ba76-6a7d08709a41"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 143,
                column: "CityGUID",
                value: new Guid("56d08868-6882-4224-bff4-641cc4733bc2"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 144,
                column: "CityGUID",
                value: new Guid("057c7657-be87-4430-bce4-ef544e9de600"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 145,
                column: "CityGUID",
                value: new Guid("9f7889bd-87f2-4759-9746-9207437b1897"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 146,
                column: "CityGUID",
                value: new Guid("e086b2c6-ab4d-431e-93fe-4290b8cc3581"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 147,
                column: "CityGUID",
                value: new Guid("ea60f884-8fdf-4499-ba27-f65db2c9a5b2"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 148,
                column: "CityGUID",
                value: new Guid("9e3f1cd0-2509-4e27-b824-eb03ff7e5455"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 149,
                column: "CityGUID",
                value: new Guid("dab35e82-08e7-4ab9-b765-97f6cb4d1d4f"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 150,
                column: "CityGUID",
                value: new Guid("e7a88c78-e36e-4ac6-a846-8de5d76bd20c"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 151,
                column: "CityGUID",
                value: new Guid("1cb068cf-6632-45a2-b949-ccac0a03e5a5"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 152,
                column: "CityGUID",
                value: new Guid("d392bdef-9c02-458a-82c6-37d4628988f9"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 153,
                column: "CityGUID",
                value: new Guid("472ba917-5998-457f-b294-0e5444bc1ffb"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 154,
                column: "CityGUID",
                value: new Guid("e453d45b-d6d5-481c-8da0-1131138bf49c"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 155,
                column: "CityGUID",
                value: new Guid("d360b22d-71dd-44b1-a992-8bf2eb14e044"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 156,
                column: "CityGUID",
                value: new Guid("9cd9fa18-3fb7-4e80-a95d-365f67f34a63"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 157,
                column: "CityGUID",
                value: new Guid("ab235339-21e5-4230-ab95-5abd8360ccf3"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 158,
                column: "CityGUID",
                value: new Guid("891ff167-3388-422e-a7a5-7fdb1de56f69"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 159,
                column: "CityGUID",
                value: new Guid("9a2e3e47-f68e-4532-a944-11e62b16060b"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 160,
                column: "CityGUID",
                value: new Guid("c508120d-cc3c-4c6a-bf9f-fa53143fd249"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 161,
                column: "CityGUID",
                value: new Guid("bfb549dd-45cc-42ae-8f73-530f861af3d4"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 162,
                column: "CityGUID",
                value: new Guid("0772721d-30b0-4dd2-b241-55f0dfd402e9"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 163,
                column: "CityGUID",
                value: new Guid("407a1fb7-4772-449a-b12f-4c248b55406c"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 164,
                column: "CityGUID",
                value: new Guid("fc274e91-db78-488b-80e2-a13c4a175233"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 165,
                column: "CityGUID",
                value: new Guid("5300774a-c029-4916-9661-c22eccf07309"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 166,
                column: "CityGUID",
                value: new Guid("d76c4758-d1ae-44e4-9c8f-0e9a2fbfe077"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 167,
                column: "CityGUID",
                value: new Guid("4584647e-b3c2-4544-be05-d21f819a1825"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 168,
                column: "CityGUID",
                value: new Guid("5a0d0a5d-ee22-4c8b-83e1-5a69daa0ffaa"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 169,
                column: "CityGUID",
                value: new Guid("83d18e17-2b1a-4cc3-9d25-57ac5a4e8c1f"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 170,
                column: "CityGUID",
                value: new Guid("f9b6b4c9-de45-4a7a-932f-5813bc3e053c"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 171,
                column: "CityGUID",
                value: new Guid("abbf13e0-aacf-41e5-84ed-324e5a217d77"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 172,
                column: "CityGUID",
                value: new Guid("b4bb737a-28c4-4b08-a1d9-3492a5b96728"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 173,
                column: "CityGUID",
                value: new Guid("4356229a-6d52-4ec2-b4d0-5c9f3099f617"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 174,
                column: "CityGUID",
                value: new Guid("895479cd-09b6-442e-b860-f4e7cad32c6e"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 175,
                column: "CityGUID",
                value: new Guid("a2e5582d-2c57-42f7-a935-42d054db4949"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 176,
                column: "CityGUID",
                value: new Guid("45707767-0388-4a06-8878-7a169bd00832"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 177,
                column: "CityGUID",
                value: new Guid("7abc44bf-2336-43ae-9dd5-d32782f60fbe"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 178,
                column: "CityGUID",
                value: new Guid("fc561dab-315f-4c47-8e97-660aad749324"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 179,
                column: "CityGUID",
                value: new Guid("3c62fc98-9cce-4c3b-a687-1ed79742c407"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 180,
                column: "CityGUID",
                value: new Guid("a14c4250-7f40-484b-973a-a59784b5dd67"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 181,
                column: "CityGUID",
                value: new Guid("0669a541-8e5d-4861-a3a6-a4175a82e19d"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 182,
                column: "CityGUID",
                value: new Guid("5af36c0b-d9fb-4d54-b515-4e3d603cf33f"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 183,
                column: "CityGUID",
                value: new Guid("24dd4a50-1d45-4e12-a174-e05a4bcc1351"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 184,
                column: "CityGUID",
                value: new Guid("d5b4d762-6760-4ba7-8be0-8165b9b4fb63"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 185,
                column: "CityGUID",
                value: new Guid("935f4c22-4368-463b-9a96-c123fe4ec286"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 186,
                column: "CityGUID",
                value: new Guid("528e0d7b-3866-4fe6-b11b-d1124e5bf100"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 187,
                column: "CityGUID",
                value: new Guid("7901f6c2-91b9-4a8b-a2cb-4885e4bf00a6"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 188,
                column: "CityGUID",
                value: new Guid("48b4c9ff-1570-4102-bfa1-b1e3732dffaf"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 189,
                column: "CityGUID",
                value: new Guid("bc5fd607-aa70-45b8-ac8d-c7cd224ee0b0"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 190,
                column: "CityGUID",
                value: new Guid("8381cc68-e560-437e-8c1c-ee3e5f80b4d3"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 191,
                column: "CityGUID",
                value: new Guid("1f2be659-2ff5-4ce9-bc72-5de92fcf5453"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 192,
                column: "CityGUID",
                value: new Guid("efbf1453-13ab-4519-88ba-cf467e65708c"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 193,
                column: "CityGUID",
                value: new Guid("7a1732bf-8f77-48ae-a2fd-09623bbf7ff9"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 194,
                column: "CityGUID",
                value: new Guid("20229ae3-d146-4e9c-a771-9098ab51c7ed"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 195,
                column: "CityGUID",
                value: new Guid("3212b5f8-0f39-44e1-9dc5-57c954d3d23a"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 196,
                column: "CityGUID",
                value: new Guid("41253d65-b52d-468d-9c24-599f4b3114e3"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 197,
                column: "CityGUID",
                value: new Guid("1a34a608-7bc4-4eb6-ba3b-51e946b13214"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 198,
                column: "CityGUID",
                value: new Guid("72d65c9b-e859-4df5-b5b9-dd03a2aaefee"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 199,
                column: "CityGUID",
                value: new Guid("b77f2002-369e-4c86-bed4-6258ff119505"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 200,
                column: "CityGUID",
                value: new Guid("7574e2ad-7ae7-4396-82d6-3fab4512e380"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 201,
                column: "CityGUID",
                value: new Guid("051e49a9-b790-4e35-9b59-017d22b25a53"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 202,
                column: "CityGUID",
                value: new Guid("1e0e4b28-e02c-4ad6-b761-102899066fcf"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 203,
                column: "CityGUID",
                value: new Guid("0b8959ea-90e7-4c06-9c3c-92541aa4eb9f"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 204,
                column: "CityGUID",
                value: new Guid("77caa7e9-870b-4b84-b9ec-7dbae18fbaee"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 205,
                column: "CityGUID",
                value: new Guid("aeb758ac-bb51-411e-b3be-305e92ec6479"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 206,
                column: "CityGUID",
                value: new Guid("8ea5ab61-b478-4458-b72a-9a2fc4a97fa7"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 207,
                column: "CityGUID",
                value: new Guid("65f72fd1-8ae3-41bb-8f89-5807afb490ae"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 208,
                column: "CityGUID",
                value: new Guid("77bedd1c-9e28-4000-80a9-157ee240efb7"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 209,
                column: "CityGUID",
                value: new Guid("5db522b3-3f60-4db9-a570-72fa60f5d637"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 210,
                column: "CityGUID",
                value: new Guid("9a407816-ac95-4934-9fbd-88c1b0ceb2b0"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 211,
                column: "CityGUID",
                value: new Guid("7bd97d98-405d-4328-9137-b4aaef702d21"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 212,
                column: "CityGUID",
                value: new Guid("781f3ba9-9e29-4e5c-b643-19eabc3fd265"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 213,
                column: "CityGUID",
                value: new Guid("2af940d2-8a17-4238-ba11-a87149155637"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 214,
                column: "CityGUID",
                value: new Guid("de34ca05-8f5d-40aa-a785-c3db02e28a70"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 215,
                column: "CityGUID",
                value: new Guid("fe70af1a-a784-4c7f-b47d-a5983edb4857"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 216,
                column: "CityGUID",
                value: new Guid("c5382cb9-0e21-444f-8da2-1885d563b3f1"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 217,
                column: "CityGUID",
                value: new Guid("fcdb84c8-fe77-4064-864c-ea92319462a4"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 218,
                column: "CityGUID",
                value: new Guid("1e841f0d-7531-4fb0-8064-0268b61113c3"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 219,
                column: "CityGUID",
                value: new Guid("eab1375c-664f-461f-9f0e-d3b4e0d6a7aa"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 220,
                column: "CityGUID",
                value: new Guid("8eb94c6d-24ea-4ad7-900c-d4fc31d664a6"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 221,
                column: "CityGUID",
                value: new Guid("029d1bcf-3532-4082-ad54-f477cb8ede1f"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 222,
                column: "CityGUID",
                value: new Guid("33537bd1-224e-4ddb-9fc5-9c5cee21efb0"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 223,
                column: "CityGUID",
                value: new Guid("ee5b0e65-4cf9-4d03-b4dd-09d04bf2cff1"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 224,
                column: "CityGUID",
                value: new Guid("9d747e2d-a48f-40fb-9ce0-832eeab48026"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 225,
                column: "CityGUID",
                value: new Guid("ed1a95a4-a133-4033-ada3-618d6d5f2c31"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 226,
                column: "CityGUID",
                value: new Guid("23782d13-4dec-49a6-b6a3-4285f07d7276"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 227,
                column: "CityGUID",
                value: new Guid("47e1bd85-f17f-4e09-9b08-52a0b7f260a9"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 228,
                column: "CityGUID",
                value: new Guid("03cd4a57-efa9-476b-90d0-223f39d1c450"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 229,
                column: "CityGUID",
                value: new Guid("87fa408f-cd43-44ed-8e39-8343868a42b8"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 230,
                column: "CityGUID",
                value: new Guid("b394f745-c68e-4b46-bb30-bca29c5cdd1c"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 231,
                column: "CityGUID",
                value: new Guid("05a25bc3-6e8d-4c78-a4b6-743df76d1a6c"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 232,
                column: "CityGUID",
                value: new Guid("d039aaae-bcdb-45c7-adcd-1cb3413869aa"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 233,
                column: "CityGUID",
                value: new Guid("f4188dcd-1afa-40e9-b8d2-f4b1e98de611"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 234,
                column: "CityGUID",
                value: new Guid("444b8879-44c6-43c0-ad9e-8135bb66f07d"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 235,
                column: "CityGUID",
                value: new Guid("002417c3-13d7-4220-9c36-8f6f42e0e7a0"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 236,
                column: "CityGUID",
                value: new Guid("bed4f88b-fcd5-4586-a4d4-5797541521ef"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 237,
                column: "CityGUID",
                value: new Guid("1f61ad70-a425-4894-ab9c-d881b153b6ba"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 238,
                column: "CityGUID",
                value: new Guid("91cc0db6-c85f-441b-9d81-9380f1189b92"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 239,
                column: "CityGUID",
                value: new Guid("2f24c796-6d84-4428-a992-934909d4166a"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 240,
                column: "CityGUID",
                value: new Guid("09553e9a-2078-432b-bfc9-5fb77103ae26"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 241,
                column: "CityGUID",
                value: new Guid("250a9d53-a2fc-4b7e-aa8e-3a1e97ccd45a"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 242,
                column: "CityGUID",
                value: new Guid("0fbf5c89-3e4f-4ec2-b0c8-a7e91928b2ca"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 243,
                column: "CityGUID",
                value: new Guid("50a77502-9a5d-48bb-a585-bc4574ed8460"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 244,
                column: "CityGUID",
                value: new Guid("6efe4e94-f2f3-4f61-9caa-86bd83996ed6"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 245,
                column: "CityGUID",
                value: new Guid("3b7c46ec-5d2b-416d-b008-0b8b6ea212fe"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 246,
                column: "CityGUID",
                value: new Guid("58bb74c3-09bc-46e8-b674-2f68a59cf59b"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 247,
                column: "CityGUID",
                value: new Guid("a31878dd-a431-4805-9b64-45229bfe4c61"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 248,
                column: "CityGUID",
                value: new Guid("bada909f-bf47-40fa-a734-c09fc74f968a"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 249,
                column: "CityGUID",
                value: new Guid("1ec51f56-1e48-4b8b-bffb-10035a4fd0c2"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 250,
                column: "CityGUID",
                value: new Guid("a882ea93-8e4d-4c3d-a34d-d675c98a491c"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 251,
                column: "CityGUID",
                value: new Guid("3dd3ff2b-a930-414c-bd06-a392dd59c8e8"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 252,
                column: "CityGUID",
                value: new Guid("70469e66-ac50-4f72-a1d0-2a80b760a5ac"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 253,
                column: "CityGUID",
                value: new Guid("2a6d23a5-13b7-49cf-9e89-b457280ba658"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 254,
                column: "CityGUID",
                value: new Guid("e68ab919-a40f-44cb-ba2c-4965c8b77b59"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 255,
                column: "CityGUID",
                value: new Guid("26100081-0d07-4332-acfa-b3b3d9def49c"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 256,
                column: "CityGUID",
                value: new Guid("e4e3f4e3-f38d-4421-9d7a-02c3c7908fc8"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 257,
                column: "CityGUID",
                value: new Guid("71457542-ca49-4860-a87a-5f88994b92bd"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 258,
                column: "CityGUID",
                value: new Guid("7432e711-11eb-4613-a1a9-5ccdf28c654f"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 259,
                column: "CityGUID",
                value: new Guid("7d50ccdc-42f8-40ae-8b9f-fee663631f01"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 260,
                column: "CityGUID",
                value: new Guid("04d5dece-39fa-47f3-b15b-7e551735a65d"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 261,
                column: "CityGUID",
                value: new Guid("2f929240-7c15-48a2-916a-4149a950cd92"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 262,
                column: "CityGUID",
                value: new Guid("197accae-5234-4e01-89bb-bef9e590f284"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 263,
                column: "CityGUID",
                value: new Guid("95d16f37-2577-4106-b75b-13e61cf4879c"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 264,
                column: "CityGUID",
                value: new Guid("486d6c23-e743-492d-9413-c70d02f52bce"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 265,
                column: "CityGUID",
                value: new Guid("fce6036f-faff-44df-bee8-97a8c6a61899"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 266,
                column: "CityGUID",
                value: new Guid("c1e1131e-c37f-452b-9e80-12fbe8ef8440"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 267,
                column: "CityGUID",
                value: new Guid("0a7fc90d-c146-4dfa-af12-ca58bd51c49c"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 268,
                column: "CityGUID",
                value: new Guid("247395f9-ec33-4fd4-85ac-00dab778cbce"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 269,
                column: "CityGUID",
                value: new Guid("286fbf5d-e93a-4099-b68c-f4da35a1fa41"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 270,
                column: "CityGUID",
                value: new Guid("bbb45f26-7967-4a70-a1e0-a47a96255983"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 271,
                column: "CityGUID",
                value: new Guid("03179a0c-68b1-44f4-928c-540f48acc3c2"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 272,
                column: "CityGUID",
                value: new Guid("686812b7-9e0a-4801-8956-e9f654cfd655"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 273,
                column: "CityGUID",
                value: new Guid("21747062-129d-4dd5-beb1-53a8eb7caeef"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 274,
                column: "CityGUID",
                value: new Guid("ecc26253-4199-4e0d-93f6-3bb960329e68"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 275,
                column: "CityGUID",
                value: new Guid("3c5ec50e-824c-436a-a00e-81ec47db9c22"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 276,
                column: "CityGUID",
                value: new Guid("1a7a15f1-1f75-4997-b663-b94315bfd744"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 277,
                column: "CityGUID",
                value: new Guid("e075a535-4cfd-492a-aecf-3e19454539f7"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 278,
                column: "CityGUID",
                value: new Guid("d39b0c79-a80b-4236-97c4-3474fcb90781"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 279,
                column: "CityGUID",
                value: new Guid("dc2463c9-fb7d-42c3-8b83-6cd8f4d35a0b"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 280,
                column: "CityGUID",
                value: new Guid("3fcc765c-3d1a-4d92-8d70-401bc876abec"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 281,
                column: "CityGUID",
                value: new Guid("4d4b5b2d-7c51-477f-8e62-2bcb87974d82"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 282,
                column: "CityGUID",
                value: new Guid("e1934d18-27b3-454f-bfb5-006b1807b77c"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 283,
                column: "CityGUID",
                value: new Guid("3065b6f5-8f4b-44ce-aa51-ec590ce64f34"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 284,
                column: "CityGUID",
                value: new Guid("73e863b8-7dea-4627-97ea-4fd1f99fd913"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 285,
                column: "CityGUID",
                value: new Guid("dfcddbb5-6792-4edd-b388-4d739d518b1b"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 286,
                column: "CityGUID",
                value: new Guid("3dcf3197-8e3d-4fe1-a45a-d3870ae26558"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 287,
                column: "CityGUID",
                value: new Guid("68d2a431-bd19-45a5-a611-1a52cd36c160"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 288,
                column: "CityGUID",
                value: new Guid("b438669c-8f63-46ef-942b-2278621350cf"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 289,
                column: "CityGUID",
                value: new Guid("2a431284-bed0-4641-95a7-1bd093b8aeb6"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 290,
                column: "CityGUID",
                value: new Guid("e8c62045-ff65-4e89-831b-7159826f1739"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 291,
                column: "CityGUID",
                value: new Guid("22e5656a-238b-467f-aeef-96b0d67e2dfe"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 292,
                column: "CityGUID",
                value: new Guid("d1f44189-74f3-46ab-88c1-f348fc21c531"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 293,
                column: "CityGUID",
                value: new Guid("9266ea6a-7887-4803-8e1e-b372225a0d1f"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 294,
                column: "CityGUID",
                value: new Guid("1b324a87-3b1f-40b2-8dca-978b319d0739"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 295,
                column: "CityGUID",
                value: new Guid("38e19fc7-3b47-4a2f-9c33-1dfc55f7c04e"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 296,
                column: "CityGUID",
                value: new Guid("2f9a3cf5-db6c-417d-a286-9283d4e6657f"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 297,
                column: "CityGUID",
                value: new Guid("e96c107b-57a6-4515-9400-d190f9a99395"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 298,
                column: "CityGUID",
                value: new Guid("2387a354-9f1e-4ef7-95c6-973d02c8e662"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 299,
                column: "CityGUID",
                value: new Guid("10c726e3-ace5-43e1-8e64-60bb9691e23b"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 300,
                column: "CityGUID",
                value: new Guid("56445671-8a29-463d-be99-0c8b52d21196"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 301,
                column: "CityGUID",
                value: new Guid("7409ac41-2291-4629-a1bc-0e7519a1ed5e"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 302,
                column: "CityGUID",
                value: new Guid("440af009-f072-46a4-9c2c-6f7878c1aebd"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 303,
                column: "CityGUID",
                value: new Guid("edea9984-5d20-41ba-bfbd-e0cfb433633b"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 304,
                column: "CityGUID",
                value: new Guid("a32e23cc-52b3-4a8d-8892-4b713317071d"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 305,
                column: "CityGUID",
                value: new Guid("e670b893-8749-4ede-be81-c5ab4b0913fa"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 306,
                column: "CityGUID",
                value: new Guid("e65f5b42-43ca-42d0-8b1e-d01e18184947"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 307,
                column: "CityGUID",
                value: new Guid("354bdd3b-0ef1-4720-8706-bb65ae8123c9"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 308,
                column: "CityGUID",
                value: new Guid("017d491e-670c-443a-8c04-35a3ab38a816"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 309,
                column: "CityGUID",
                value: new Guid("cbfa5230-1760-4d1d-b7ba-f3adcc6c9eef"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 310,
                column: "CityGUID",
                value: new Guid("7f35c528-6f7f-4f1a-a9bb-af616117d57b"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 311,
                column: "CityGUID",
                value: new Guid("14b92b46-4551-47cd-8d4f-e12534006d12"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 312,
                column: "CityGUID",
                value: new Guid("efa15fa6-b8dd-4531-b2ff-820437251145"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 313,
                column: "CityGUID",
                value: new Guid("314c7188-f7a1-42c5-947f-4ab5b8292ea1"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 314,
                column: "CityGUID",
                value: new Guid("8a09b344-069e-4843-b6a2-44eebc855e38"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 315,
                column: "CityGUID",
                value: new Guid("3f0239d5-27f7-4029-ae12-b82599103b02"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 316,
                column: "CityGUID",
                value: new Guid("d23eb722-ca4d-4f84-9c90-df55dfd8b220"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 317,
                column: "CityGUID",
                value: new Guid("14d2e8b1-cae0-46d7-82d1-b77cac0ba290"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 318,
                column: "CityGUID",
                value: new Guid("3cb13fad-5419-40c4-bdde-d66ef8c13a8b"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 319,
                column: "CityGUID",
                value: new Guid("096c8b8f-7eb2-4246-991c-6a62fdd5bb9a"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 320,
                column: "CityGUID",
                value: new Guid("e3e04e02-9de5-44ee-97f2-6b29f7591586"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 321,
                column: "CityGUID",
                value: new Guid("72ddb226-3470-4690-a80f-b4a8de652ad8"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 322,
                column: "CityGUID",
                value: new Guid("9e512b40-1576-4263-9ffe-9464166a2b6b"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 323,
                column: "CityGUID",
                value: new Guid("1e86aeec-ecc4-460b-9130-fe1f527341de"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 324,
                column: "CityGUID",
                value: new Guid("a6a76983-b092-43c5-8137-ac21c4077bb6"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 325,
                column: "CityGUID",
                value: new Guid("57a38156-cdd5-4905-91f7-55135c0fbf79"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 326,
                column: "CityGUID",
                value: new Guid("6debe2b3-d7d5-4a98-a8cd-3ecf28f7843e"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 327,
                column: "CityGUID",
                value: new Guid("6159e53d-87bf-43a6-8ed9-574751809789"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 328,
                column: "CityGUID",
                value: new Guid("0aabc204-c795-4199-a994-a5cb41a15b2e"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 329,
                column: "CityGUID",
                value: new Guid("54ef8bce-9d1a-4d6c-a3f5-2fa00008d1a3"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 330,
                column: "CityGUID",
                value: new Guid("e78bd772-ff31-4bf8-af52-e1dbf93fc818"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 331,
                column: "CityGUID",
                value: new Guid("536ae7b4-f53f-4500-8fb4-8bf1af0d0c57"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 332,
                column: "CityGUID",
                value: new Guid("a072178a-203f-4dd9-af87-1c0def6c84a4"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 333,
                column: "CityGUID",
                value: new Guid("68a51f5a-31ca-4f4a-ac7f-385f34a54283"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 334,
                column: "CityGUID",
                value: new Guid("9cd55e9b-1236-4bc4-a963-4833e333a375"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 335,
                column: "CityGUID",
                value: new Guid("8551fb22-5057-4052-ae19-ac1449f4f8a3"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 336,
                column: "CityGUID",
                value: new Guid("f3e650d3-b58f-4613-8aed-c205ca7230e6"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 337,
                column: "CityGUID",
                value: new Guid("c5835364-9428-4046-8989-9ef490f24133"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 338,
                column: "CityGUID",
                value: new Guid("801eb925-8185-4d18-bd1e-610e2ebc5682"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 339,
                column: "CityGUID",
                value: new Guid("4892e760-edfb-4a58-9b43-62974feaee73"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 340,
                column: "CityGUID",
                value: new Guid("ad5eb18e-fab4-42b0-99ce-2f8316309c41"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 341,
                column: "CityGUID",
                value: new Guid("8e4032e8-98ba-44e6-9f56-e829ec3fabac"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 342,
                column: "CityGUID",
                value: new Guid("2cc44308-bcd1-4c45-a64c-aceceedf0383"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 343,
                column: "CityGUID",
                value: new Guid("5756c37e-ed8b-47f7-9577-ee34af70f189"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 344,
                column: "CityGUID",
                value: new Guid("a365155d-ea63-4ec9-9c00-e93a23d56065"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 345,
                column: "CityGUID",
                value: new Guid("3dc873a3-c1cc-4557-95ea-f83f804d3eb6"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 346,
                column: "CityGUID",
                value: new Guid("12efcce4-6532-4c32-bd11-fd0ea0cec007"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 347,
                column: "CityGUID",
                value: new Guid("2f79e8ea-048e-4bad-9ffa-923deec82123"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 348,
                column: "CityGUID",
                value: new Guid("895db09e-b61c-4607-a18f-ec92bd3e6a7e"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 349,
                column: "CityGUID",
                value: new Guid("5320e10b-eb48-4c28-ab99-839f989d19bc"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 350,
                column: "CityGUID",
                value: new Guid("8593f1fc-1160-4e20-8e25-e5bbbc164b84"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 351,
                column: "CityGUID",
                value: new Guid("60ee7c1c-24d6-4630-8eb9-7558165a5a26"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 352,
                column: "CityGUID",
                value: new Guid("5af4e338-173e-41f0-b3ac-37c2ce3d271b"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 353,
                column: "CityGUID",
                value: new Guid("22e62a67-b522-41bd-a30a-c7b6e5dfd0ca"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 354,
                column: "CityGUID",
                value: new Guid("6af2dfba-968c-4b70-9807-55425b492dd9"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 355,
                column: "CityGUID",
                value: new Guid("e6edd88f-1451-44f2-80e6-ae64a4792101"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 356,
                column: "CityGUID",
                value: new Guid("2b442581-7d30-4997-9d21-bcd7c0ca2350"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 357,
                column: "CityGUID",
                value: new Guid("c68e4899-a791-46b5-ba94-c0a8c4c33392"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 358,
                column: "CityGUID",
                value: new Guid("1f702d53-9266-4b62-bd8d-77aac6e97463"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 359,
                column: "CityGUID",
                value: new Guid("4fd7d252-96b8-4eed-a405-e8d7e4b22342"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 360,
                column: "CityGUID",
                value: new Guid("960b7d30-367b-4a84-9ba5-ccf8caef2c9e"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 361,
                column: "CityGUID",
                value: new Guid("a8e89776-826c-4718-bcf6-d629072d0fd9"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 362,
                column: "CityGUID",
                value: new Guid("0d39403d-7e40-4b56-834a-93c338a2d67b"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 363,
                column: "CityGUID",
                value: new Guid("847015bc-4d6e-4f87-93f0-29d8b38b607b"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 364,
                column: "CityGUID",
                value: new Guid("9a47a4b4-805f-4c90-88f5-3682a6e7e845"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 365,
                column: "CityGUID",
                value: new Guid("dcce45eb-cd4d-4278-92bf-bca4522110e5"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 366,
                column: "CityGUID",
                value: new Guid("118911a2-79aa-4587-87dc-504caa40c89d"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 367,
                column: "CityGUID",
                value: new Guid("9a68cf7e-a977-43f9-8c68-ef9fcde2f009"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 368,
                column: "CityGUID",
                value: new Guid("d7492fba-86c7-4f3c-bf3a-88af809adc21"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 369,
                column: "CityGUID",
                value: new Guid("327c69a7-b2b0-4d86-ac6d-1e4af7c22f1e"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 370,
                column: "CityGUID",
                value: new Guid("117f7c4a-8398-4936-ac68-82361c62f2af"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 371,
                column: "CityGUID",
                value: new Guid("b2e346ca-f8ab-4a87-8393-ed4bad0667a4"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 372,
                column: "CityGUID",
                value: new Guid("be344069-fb02-49ff-beda-9270f6e4a890"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 373,
                column: "CityGUID",
                value: new Guid("bc0f25fc-970b-4a38-8556-d4b946d5c214"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 374,
                column: "CityGUID",
                value: new Guid("1dcaf2b3-ebc3-4c57-8cf4-935a35820a89"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 375,
                column: "CityGUID",
                value: new Guid("225dd8a4-34cd-430c-adf6-692334a04350"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 376,
                column: "CityGUID",
                value: new Guid("85361976-134d-46ad-bc59-e3b64303e4b0"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 377,
                column: "CityGUID",
                value: new Guid("f4ab02ec-5ed8-41d9-b06d-8ca98698f287"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 378,
                column: "CityGUID",
                value: new Guid("d00bb14c-37c3-4ab6-bbff-7140075fa8fe"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 379,
                column: "CityGUID",
                value: new Guid("0e4984e8-cc8e-4966-85d0-80ed2f9a99ee"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 380,
                column: "CityGUID",
                value: new Guid("94988c67-025a-43ee-a13c-6d127e4f0642"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 381,
                column: "CityGUID",
                value: new Guid("c80e3b18-237e-4094-8eb1-67f534888b4a"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 382,
                column: "CityGUID",
                value: new Guid("e5284cf4-9e8a-425c-bab3-6cb935ad9532"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 383,
                column: "CityGUID",
                value: new Guid("a42e6ad9-b576-49c0-af8b-2be25eee3564"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 384,
                column: "CityGUID",
                value: new Guid("7ab27df4-028d-4015-af52-19fdd9c9bb6c"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 385,
                column: "CityGUID",
                value: new Guid("69167914-bc2f-40a2-881a-da8a236685d6"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 386,
                column: "CityGUID",
                value: new Guid("02630a37-89b4-48e6-a6d7-7bd76b006be6"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 387,
                column: "CityGUID",
                value: new Guid("6ecde9fb-568f-440b-8155-136a3e05c149"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 388,
                column: "CityGUID",
                value: new Guid("9f592433-9d0a-455d-a5e9-66a7ecf7739e"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 389,
                column: "CityGUID",
                value: new Guid("c92b8ba8-ad05-4227-a422-1dd6ea4616f3"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 390,
                column: "CityGUID",
                value: new Guid("e53c9fee-483c-4d77-b1dc-18bfc77be92c"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 391,
                column: "CityGUID",
                value: new Guid("d2e3ec64-809a-456c-8f48-b7c7880d451a"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 392,
                column: "CityGUID",
                value: new Guid("b2cc6fee-baeb-4e3d-8493-b43a738af6e2"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 393,
                column: "CityGUID",
                value: new Guid("2b6040ed-7e4e-439e-ae26-9ae21d18c64f"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 394,
                column: "CityGUID",
                value: new Guid("83d73627-26d5-4baf-b1ac-d4751fb1e6fb"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 395,
                column: "CityGUID",
                value: new Guid("3a4020f9-6bfc-4475-be99-981b0ed92eac"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 396,
                column: "CityGUID",
                value: new Guid("494fbe4c-cf3d-4a0e-9822-55468d9e807d"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 397,
                column: "CityGUID",
                value: new Guid("6d636c5f-656b-4288-9bdd-062f68585162"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 398,
                column: "CityGUID",
                value: new Guid("528d2dfc-3ae2-4c53-a4cd-fe2e765406c3"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 399,
                column: "CityGUID",
                value: new Guid("c369770c-9c8c-40f9-9aac-dd950c9187f6"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 400,
                column: "CityGUID",
                value: new Guid("dc552388-9332-408e-941a-b03992b14dec"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 401,
                column: "CityGUID",
                value: new Guid("772d5995-b11c-40f6-93c7-d7e223041bb3"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 402,
                column: "CityGUID",
                value: new Guid("aeba66b9-965c-42ac-9b4e-2755e24a9e37"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 403,
                column: "CityGUID",
                value: new Guid("bd04d6ad-0a7f-4e50-9583-c82964cdf5c4"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 404,
                column: "CityGUID",
                value: new Guid("38d3371c-37ef-44fb-a626-3122b1140dda"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 405,
                column: "CityGUID",
                value: new Guid("cb80b3d8-f9f4-4b84-b390-bc8b70a1be81"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 406,
                column: "CityGUID",
                value: new Guid("7b4d05bf-4583-4eca-a063-412dbac2f0be"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 407,
                column: "CityGUID",
                value: new Guid("28c0650c-ea3d-45ef-bef5-7764e11e852d"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 408,
                column: "CityGUID",
                value: new Guid("5ef87eea-ee08-47ae-b767-22c248d68917"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 409,
                column: "CityGUID",
                value: new Guid("ddf09478-ed82-4994-8e97-882560fe03ba"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 410,
                column: "CityGUID",
                value: new Guid("ef5f4cc7-2a0a-4aed-a67e-088cf11628c8"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 411,
                column: "CityGUID",
                value: new Guid("2f113318-7338-41ac-a97c-50f4bb129ed7"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 412,
                column: "CityGUID",
                value: new Guid("56276a0b-eccc-4e08-ba55-2a5c2c4d0912"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 413,
                column: "CityGUID",
                value: new Guid("2546ab8f-b61c-414c-867f-7d66ca50fdd3"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 414,
                column: "CityGUID",
                value: new Guid("b3dbe898-0fef-4b57-8e52-a2076bc50f80"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 415,
                column: "CityGUID",
                value: new Guid("91941da2-ab07-4181-b3a9-80b1b548e763"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 416,
                column: "CityGUID",
                value: new Guid("0387f75b-4c60-41f2-bc40-158513c8fbaf"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 417,
                column: "CityGUID",
                value: new Guid("d2a126f5-2191-4e56-919b-14263f80292c"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 418,
                column: "CityGUID",
                value: new Guid("f6b7f2c4-bfa7-4ed2-83ca-ec1a0d98f04d"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 419,
                column: "CityGUID",
                value: new Guid("cd19f4e2-caaf-425f-a87d-5fd42eeb9e3d"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 420,
                column: "CityGUID",
                value: new Guid("ca147fd9-b90f-40d2-ab7c-2f6bdd3a6f90"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 421,
                column: "CityGUID",
                value: new Guid("739eafb0-578c-4f38-a182-8595aee91072"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 422,
                column: "CityGUID",
                value: new Guid("297ab202-a1ea-41ed-a1d0-280613ad4e40"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 423,
                column: "CityGUID",
                value: new Guid("45f2dccf-6cd4-4134-adc1-ca30d2253884"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 424,
                column: "CityGUID",
                value: new Guid("82aabc42-237f-4e52-87bc-affb8c842d9a"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 425,
                column: "CityGUID",
                value: new Guid("4d81b069-9b1b-4693-befb-db2f2e1c79d4"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 426,
                column: "CityGUID",
                value: new Guid("0b61f218-1815-4af5-9049-e703374fc4df"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 427,
                column: "CityGUID",
                value: new Guid("32a750a3-33cb-4525-b405-995374911556"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 428,
                column: "CityGUID",
                value: new Guid("ce0c80f4-36fb-4650-a1cc-e6c92bda4edc"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 429,
                column: "CityGUID",
                value: new Guid("9f1181a7-d5c5-4525-82c6-bee76a277701"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 430,
                column: "CityGUID",
                value: new Guid("7b325138-f186-460d-b301-f4c91576cdfd"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 431,
                column: "CityGUID",
                value: new Guid("fb7028cd-e8b5-49ad-a195-af83d4d06cfa"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 432,
                column: "CityGUID",
                value: new Guid("b0cdf37a-19f4-4af8-b95d-55baf4247432"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 433,
                column: "CityGUID",
                value: new Guid("e00f9242-45b6-4af4-a854-eb2b9d873130"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 434,
                column: "CityGUID",
                value: new Guid("9a38ea9b-2c43-4284-aac6-02b77d431e35"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 435,
                column: "CityGUID",
                value: new Guid("ef0d6df2-19a1-41e5-815b-32c5723dc535"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 436,
                column: "CityGUID",
                value: new Guid("9072cdea-3d21-40ce-ba4b-38409c2b4ea8"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 437,
                column: "CityGUID",
                value: new Guid("61945c7c-bcb7-4b4b-9307-6b4fe0529c31"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 438,
                column: "CityGUID",
                value: new Guid("bc861087-6896-4a1a-b3d8-a337c13bb21f"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 439,
                column: "CityGUID",
                value: new Guid("29ee2969-7bc6-469e-9b81-b9b0c422e92e"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 440,
                column: "CityGUID",
                value: new Guid("b4e38a06-f157-4179-8212-762233580da2"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 441,
                column: "CityGUID",
                value: new Guid("bd6c54e5-6284-4b02-885a-ac508041e2b3"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 442,
                column: "CityGUID",
                value: new Guid("67aa6b7e-fd40-49fb-8f55-685a7b611252"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 443,
                column: "CityGUID",
                value: new Guid("ab4be8a1-96f6-4279-9f8b-f332c971ec2e"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 444,
                column: "CityGUID",
                value: new Guid("347d3aff-0688-413d-8836-3cf819473248"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 445,
                column: "CityGUID",
                value: new Guid("c222d456-9c2d-4d38-b07f-404358c520c2"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 446,
                column: "CityGUID",
                value: new Guid("bb0de984-49b3-45a2-ac92-d95ab76c7348"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 447,
                column: "CityGUID",
                value: new Guid("47437712-c46f-4f93-8296-2aa46332e619"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 448,
                column: "CityGUID",
                value: new Guid("1c3cf732-535a-439f-965b-48fcaff89338"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 449,
                column: "CityGUID",
                value: new Guid("3b8fddd7-f3bf-47c1-8acc-4ec9703c163b"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 450,
                column: "CityGUID",
                value: new Guid("5cffbb74-9e85-441d-9aee-f6eb6d7bc748"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 451,
                column: "CityGUID",
                value: new Guid("ace3a36e-bb57-4871-9a0c-abc0d1451435"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 452,
                column: "CityGUID",
                value: new Guid("92fc11d6-56cb-45e0-b454-e7ceb9002394"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 453,
                column: "CityGUID",
                value: new Guid("2fa06b13-5eee-430a-a902-ee188c9131a6"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 454,
                column: "CityGUID",
                value: new Guid("ec6a6249-1607-4d96-9c39-9eb5dc3f9013"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 455,
                column: "CityGUID",
                value: new Guid("2c106d28-a2c5-4baf-8d6d-61e96c66bbd5"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 456,
                column: "CityGUID",
                value: new Guid("db0a9b89-77f8-4e05-980b-3633737d2f11"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 457,
                column: "CityGUID",
                value: new Guid("4099d315-d364-484a-ab06-cf72d902d98d"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 458,
                column: "CityGUID",
                value: new Guid("0fcfe159-e20f-4f5b-84f9-b3f8f44be3e3"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 459,
                column: "CityGUID",
                value: new Guid("afe02df7-585c-402c-afb7-926558288411"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 460,
                column: "CityGUID",
                value: new Guid("d23b4194-cc2d-4721-8866-92e2deec72f9"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 461,
                column: "CityGUID",
                value: new Guid("99900f46-54be-4bf4-a130-fcd7c5cdc55b"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 462,
                column: "CityGUID",
                value: new Guid("f85c54c5-f506-491d-91df-58c77adcf277"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 463,
                column: "CityGUID",
                value: new Guid("f0b3a48a-7ab3-4b95-ad50-b01426b4f6b8"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 464,
                column: "CityGUID",
                value: new Guid("c9c35bc5-3137-45a5-be0f-20f15fbe602b"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 465,
                column: "CityGUID",
                value: new Guid("88107da1-5404-402e-841c-a737c8b209cb"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 466,
                column: "CityGUID",
                value: new Guid("880d1517-d577-4a92-a4be-14268841b338"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 467,
                column: "CityGUID",
                value: new Guid("d59a5e90-5255-48b7-8752-ed1680c56f61"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 468,
                column: "CityGUID",
                value: new Guid("6551ef6b-8e35-4508-a6cd-d9c42b91104a"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 469,
                column: "CityGUID",
                value: new Guid("343c48c2-c957-42e9-88cb-849890af8b32"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 470,
                column: "CityGUID",
                value: new Guid("55a40ca1-2e0a-486d-ae95-b0cb52853f21"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 471,
                column: "CityGUID",
                value: new Guid("2ba3ede7-7284-462e-b9c3-3fa0f2ae08d6"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 472,
                column: "CityGUID",
                value: new Guid("f3dd7544-6076-4d2a-bb37-030283b94b46"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 473,
                column: "CityGUID",
                value: new Guid("5237aef2-81ea-4abd-b235-4d44c376c388"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 474,
                column: "CityGUID",
                value: new Guid("223e9ca9-373e-4f5c-b838-64c429f8a606"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 475,
                column: "CityGUID",
                value: new Guid("b6539dea-63a6-456c-b546-ef3c4eb22efa"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 476,
                column: "CityGUID",
                value: new Guid("0d8b0845-9e2b-4a39-b701-389a67ce331c"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 477,
                column: "CityGUID",
                value: new Guid("aaafb147-d576-4939-bf12-58015f19c99a"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 478,
                column: "CityGUID",
                value: new Guid("e0464198-a344-45ae-812d-c039cfcc5cd1"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 479,
                column: "CityGUID",
                value: new Guid("081f3c68-e970-40a4-a259-f570ba72402e"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 480,
                column: "CityGUID",
                value: new Guid("3f4e0915-a106-402b-8e07-a42dae000e17"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 481,
                column: "CityGUID",
                value: new Guid("02192174-32c2-4f9c-811f-28843def7ad4"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 482,
                column: "CityGUID",
                value: new Guid("bc3ce504-9108-45fc-b7b1-8cf3d574dad6"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 483,
                column: "CityGUID",
                value: new Guid("41b24090-d4ea-41b8-ba06-e19b592fb37d"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 484,
                column: "CityGUID",
                value: new Guid("08538eea-d4ed-4718-880e-631f66a5b9ed"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 485,
                column: "CityGUID",
                value: new Guid("eebb8e5d-4d85-44f7-abdf-d2bb798c2563"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 486,
                column: "CityGUID",
                value: new Guid("8daf2748-e0fd-43f6-b08f-f3b70efb004f"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 487,
                column: "CityGUID",
                value: new Guid("dbb48c3e-d1bc-4a27-9a44-261dc10d59e1"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 488,
                column: "CityGUID",
                value: new Guid("ce05e72b-606b-4477-acdb-ccd9e6f4c0cd"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 489,
                column: "CityGUID",
                value: new Guid("0380329a-3c28-41c8-a253-33cbc2ce0acc"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 490,
                column: "CityGUID",
                value: new Guid("10e20420-a7fd-43d2-905c-340aaba5596f"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 491,
                column: "CityGUID",
                value: new Guid("1800fe57-6985-4dda-90a5-736d1fc63f1a"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 492,
                column: "CityGUID",
                value: new Guid("a6e18fe5-7162-41bf-8912-e36d3112b736"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 493,
                column: "CityGUID",
                value: new Guid("95e58787-e5ec-4342-8e4e-5e5b1eb1020c"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 494,
                column: "CityGUID",
                value: new Guid("09708db5-c83f-4fb8-9fa9-a856c4d6a485"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 495,
                column: "CityGUID",
                value: new Guid("3cbc34f1-4994-455b-8ea8-946af22cd84a"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 496,
                column: "CityGUID",
                value: new Guid("f5ce5ddb-cb23-401d-808f-374e220fadbb"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 497,
                column: "CityGUID",
                value: new Guid("92feee15-6c7a-4ace-91c8-661ccf3cceca"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 498,
                column: "CityGUID",
                value: new Guid("f2a27217-7906-4de4-92ab-d27219d59649"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 499,
                column: "CityGUID",
                value: new Guid("38efa806-1831-4440-9da2-9b52361c7796"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 500,
                column: "CityGUID",
                value: new Guid("d0be6352-95aa-40b6-9196-2375a1751aaa"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 501,
                column: "CityGUID",
                value: new Guid("f654045c-1ef3-4c72-8c56-6cfc736b1c60"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 502,
                column: "CityGUID",
                value: new Guid("9c1ef643-306a-4339-9206-00fcf42e27a6"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 503,
                column: "CityGUID",
                value: new Guid("3b45ce79-3581-4027-b641-5f37bd0aa4f2"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 504,
                column: "CityGUID",
                value: new Guid("a0601b54-f762-4818-83d0-6b522e8053bd"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 505,
                column: "CityGUID",
                value: new Guid("e2299f3c-b97d-4404-a30a-dd3a2e3f90cb"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 506,
                column: "CityGUID",
                value: new Guid("285ed393-872c-41e2-aed3-be97561b9e21"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 507,
                column: "CityGUID",
                value: new Guid("9a57f348-e64a-4161-b376-906181453e9e"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 508,
                column: "CityGUID",
                value: new Guid("9f4f0409-5bc9-42a3-8de2-510cbf3ee208"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 509,
                column: "CityGUID",
                value: new Guid("7c4ea88c-a9b9-47ba-a391-aa92e99ab097"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 510,
                column: "CityGUID",
                value: new Guid("15a963cb-60ac-4ae8-bc5a-cf39f4b213bb"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 511,
                column: "CityGUID",
                value: new Guid("aeaee8a0-bd2f-4c74-957c-fd59b8d4c21c"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 512,
                column: "CityGUID",
                value: new Guid("717996cb-baa1-4221-a057-615590941ad0"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 513,
                column: "CityGUID",
                value: new Guid("5a2d4cad-8eeb-47c0-9ef7-4ba43334a606"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 514,
                column: "CityGUID",
                value: new Guid("fc3ff910-ea4f-4a02-b973-499829a2d5db"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 515,
                column: "CityGUID",
                value: new Guid("bd526428-a400-483a-aeca-5bb8d0c2394a"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 516,
                column: "CityGUID",
                value: new Guid("d69a9829-8cdb-46c9-81f5-93c136c93f8c"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 517,
                column: "CityGUID",
                value: new Guid("2db80853-10ee-4fc9-8b4d-b60f066c9042"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 518,
                column: "CityGUID",
                value: new Guid("5b0e6a4d-1844-4ea1-96ab-c720ae06699f"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 519,
                column: "CityGUID",
                value: new Guid("114d2b9c-bdae-4432-9e92-5a7062123e9f"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 520,
                column: "CityGUID",
                value: new Guid("600246c5-0c10-461f-bd1e-f9259b7f98c0"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 521,
                column: "CityGUID",
                value: new Guid("cfd64169-6b95-4467-85cb-dcb814e50c3d"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 522,
                column: "CityGUID",
                value: new Guid("dabdaf44-0675-4de1-aa79-50d3f4aa6ccf"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 523,
                column: "CityGUID",
                value: new Guid("20e2d24a-5430-494a-b0b9-38254f258011"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 524,
                column: "CityGUID",
                value: new Guid("da714534-a0ec-4110-a3a5-ea1da6b95a19"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 525,
                column: "CityGUID",
                value: new Guid("6c861a11-293d-45a6-9016-e8f9238b22a9"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 526,
                column: "CityGUID",
                value: new Guid("63fbcf87-f22e-4a82-a293-0373d15060fd"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 527,
                column: "CityGUID",
                value: new Guid("db8eeb86-dc4c-4f34-b9d1-7a42324b1e10"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 528,
                column: "CityGUID",
                value: new Guid("0201e9e2-b294-4ced-a123-0cccde8767c9"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 529,
                column: "CityGUID",
                value: new Guid("48c104df-8554-4d53-9c15-71b2d051caaf"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 530,
                column: "CityGUID",
                value: new Guid("2ecb0c20-b577-406d-948a-c8e91353bb0a"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 531,
                column: "CityGUID",
                value: new Guid("1925cbce-bd6a-4617-8a02-15a5a51c68de"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 532,
                column: "CityGUID",
                value: new Guid("bfc05a39-d6f0-4137-bf9f-84e2436e1acf"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 533,
                column: "CityGUID",
                value: new Guid("7426c443-3f44-455b-872f-596f31be4b1c"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 534,
                column: "CityGUID",
                value: new Guid("b267a9ee-496c-48f5-9717-ecfea72372d5"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 535,
                column: "CityGUID",
                value: new Guid("8ba3ded3-2432-44a7-be62-99ad054e5bb4"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 536,
                column: "CityGUID",
                value: new Guid("e2802a7e-57cc-4aba-ae68-04ddc4f7f08f"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 537,
                column: "CityGUID",
                value: new Guid("3ab689f0-1354-4338-869e-bbb5cd1557a6"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 538,
                column: "CityGUID",
                value: new Guid("d3f1b322-0a7e-4241-aa1c-5bc7b553059b"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 539,
                column: "CityGUID",
                value: new Guid("34100380-cc70-4172-a960-82601fd0dcc4"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 540,
                column: "CityGUID",
                value: new Guid("994f5eab-44ba-4f6d-b723-bb94fda11faf"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 541,
                column: "CityGUID",
                value: new Guid("d6448eb2-63b0-4165-b961-f3e884a4a17a"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 542,
                column: "CityGUID",
                value: new Guid("d021150d-9573-40ce-92ab-2b8f9236c831"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 543,
                column: "CityGUID",
                value: new Guid("11126745-70f0-4989-bcbf-4cc4948fca8b"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 544,
                column: "CityGUID",
                value: new Guid("e210f08f-d520-40f4-8926-b4674e47eeaf"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 545,
                column: "CityGUID",
                value: new Guid("eb16c6b5-d730-4cdc-9979-dac1ee5acb30"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 546,
                column: "CityGUID",
                value: new Guid("38f30180-eb9f-4496-bb75-77cefba12d15"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 547,
                column: "CityGUID",
                value: new Guid("63d54a99-ed4a-4961-8eba-ca71c7282d73"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 548,
                column: "CityGUID",
                value: new Guid("4dca7432-565a-4612-bca0-f08b250ce3eb"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 549,
                column: "CityGUID",
                value: new Guid("f06e004f-773c-4c30-ad22-8f2ea7ed2985"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 550,
                column: "CityGUID",
                value: new Guid("fba007fe-cfd4-4e21-800d-eeb961b44faa"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 551,
                column: "CityGUID",
                value: new Guid("1d655ca4-a04c-4ac1-9792-421b464f9226"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 552,
                column: "CityGUID",
                value: new Guid("27ef0af2-aacb-44b6-8f3e-96a4ab16c8cd"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 553,
                column: "CityGUID",
                value: new Guid("3c6b0fd7-cbe4-49b7-a14a-0d6e2b5bfa3b"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 554,
                column: "CityGUID",
                value: new Guid("dd42a9c4-5c6b-427f-a93c-ad611959245c"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 555,
                column: "CityGUID",
                value: new Guid("d98b8120-7e1c-4cb3-b4d8-c8ddd9ee9459"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 556,
                column: "CityGUID",
                value: new Guid("0dc10577-7a34-4f1e-b465-79d5954ae633"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 557,
                column: "CityGUID",
                value: new Guid("7cf96507-28e2-46c0-89cd-a91b5fee6ce8"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 558,
                column: "CityGUID",
                value: new Guid("382ea12d-f26a-43ee-99d1-ee2c5a4f7825"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 559,
                column: "CityGUID",
                value: new Guid("5818e0ad-1d53-4012-9a4f-15a9bd3de9ba"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 560,
                column: "CityGUID",
                value: new Guid("1a3628d8-2504-4ae2-9486-d24ac8c0b6f4"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 561,
                column: "CityGUID",
                value: new Guid("0d6ea5b6-e9d1-4751-a4df-46326ce38e6c"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 562,
                column: "CityGUID",
                value: new Guid("19dccc67-1acc-4ac9-b5ba-8cafb047094c"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 563,
                column: "CityGUID",
                value: new Guid("1bb3e758-7975-4af0-98a2-1b3749a4a30a"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 564,
                column: "CityGUID",
                value: new Guid("caa2242d-e08f-4672-9fe2-ec78ea1f1ba9"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 565,
                column: "CityGUID",
                value: new Guid("977b08f4-1f3e-4967-a3a7-a4b24c77bb53"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 566,
                column: "CityGUID",
                value: new Guid("cd0a0ef0-3a0e-4eb7-a3e7-ff06004454cb"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 567,
                column: "CityGUID",
                value: new Guid("34641085-fd3d-48b1-bce0-285916172364"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 568,
                column: "CityGUID",
                value: new Guid("cea45ffd-2654-474a-bfc9-fcfef9cfddbe"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 569,
                column: "CityGUID",
                value: new Guid("709f00ba-af2f-496f-b757-d9884dbecb21"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 570,
                column: "CityGUID",
                value: new Guid("39c589c9-3ad0-42e9-9476-a3413504360c"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 571,
                column: "CityGUID",
                value: new Guid("20dd846b-ab82-4393-9970-e97e1314bd1a"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 572,
                column: "CityGUID",
                value: new Guid("11f1a7ef-b259-4cd2-8979-38a8bef71376"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 573,
                column: "CityGUID",
                value: new Guid("eb9ddc8f-90ba-42f4-a78f-7205a393ea4f"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 574,
                column: "CityGUID",
                value: new Guid("b61cc80c-b909-48c5-b327-a1e997787438"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 575,
                column: "CityGUID",
                value: new Guid("e60b55b9-8449-431d-9ead-1647e3567f3b"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 576,
                column: "CityGUID",
                value: new Guid("895bd92e-e132-41d1-aa6c-735521cf5a71"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 577,
                column: "CityGUID",
                value: new Guid("20d8879f-3a54-47bd-bc7c-9a8dba169ba4"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 578,
                column: "CityGUID",
                value: new Guid("7dc8d77d-6bd0-47d5-8885-3acd6b9736f5"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 579,
                column: "CityGUID",
                value: new Guid("47ba1f66-f9f5-4d6f-a220-8a6c6c2e2f64"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 580,
                column: "CityGUID",
                value: new Guid("b971855d-f134-4373-ba2c-360d15393fd2"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 581,
                column: "CityGUID",
                value: new Guid("41bdbafb-d9dc-4f41-9796-086da61d8823"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 582,
                column: "CityGUID",
                value: new Guid("d648ea97-f6f2-43d0-aa97-05767c92d227"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 583,
                column: "CityGUID",
                value: new Guid("0a6e8829-0673-41cc-bdf2-1e5f3bdc613a"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 584,
                column: "CityGUID",
                value: new Guid("886a8c6c-a24f-404b-ad38-a54a0c28e5a7"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 585,
                column: "CityGUID",
                value: new Guid("0ce1c3f7-26bc-44ac-9077-4e2a0f787eab"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 586,
                column: "CityGUID",
                value: new Guid("81221048-ae75-4e8e-90cf-dedae599a8f6"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 587,
                column: "CityGUID",
                value: new Guid("f5600983-bc3f-42ce-a4c4-41ba81769ec2"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 588,
                column: "CityGUID",
                value: new Guid("56c01585-f84e-4727-a79b-7e41ecd2b2ba"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 589,
                column: "CityGUID",
                value: new Guid("cc442a7e-807b-4a1e-80a3-e1d7f4b82a5b"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 590,
                column: "CityGUID",
                value: new Guid("826821c1-73dc-4502-b5bc-a61538fd2d31"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 591,
                column: "CityGUID",
                value: new Guid("291076d8-aacb-4791-99aa-8f87fb69987e"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 592,
                column: "CityGUID",
                value: new Guid("b33c34aa-233f-4b70-913d-5dd50994f349"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 593,
                column: "CityGUID",
                value: new Guid("fbce4f82-6068-48a5-bb28-a2cdaedf6969"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 594,
                column: "CityGUID",
                value: new Guid("56acccfc-0245-4362-9e3a-6c3e01fabb2d"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 595,
                column: "CityGUID",
                value: new Guid("ec2adef7-15c1-4167-aa98-c7c778b89b0f"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 596,
                column: "CityGUID",
                value: new Guid("76c0ce3e-2548-4028-902d-1c5582a4adf7"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 597,
                column: "CityGUID",
                value: new Guid("1558a27e-1ef5-439a-96e8-783dfc7531de"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 598,
                column: "CityGUID",
                value: new Guid("5d8f9d0d-bbdb-40ce-8ad2-4e35d796553a"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 599,
                column: "CityGUID",
                value: new Guid("7edeca71-a52a-4bf2-b7c0-830548baacb7"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 600,
                column: "CityGUID",
                value: new Guid("aefbe643-f1be-4603-99fa-f1a3bd2eec50"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 601,
                column: "CityGUID",
                value: new Guid("fba2c3b3-efc1-4c99-9b62-9430a91ed0ad"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 602,
                column: "CityGUID",
                value: new Guid("c8b20a9a-d43b-4fcb-9684-ceb90d53e2ea"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 603,
                column: "CityGUID",
                value: new Guid("c6906044-7e5d-49b1-9c4a-24c2343b1953"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 604,
                column: "CityGUID",
                value: new Guid("164252c0-3d14-4437-b8ba-530f9ad7320e"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 605,
                column: "CityGUID",
                value: new Guid("4c5b6d95-8617-4e7c-9816-fcefbb11f014"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 606,
                column: "CityGUID",
                value: new Guid("edcbc0ef-142e-433d-8b21-da3e6b4aefa9"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 607,
                column: "CityGUID",
                value: new Guid("5a520d30-755c-4108-a3d3-54e938b28a36"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 608,
                column: "CityGUID",
                value: new Guid("af5bda2f-bb06-4877-8136-a78204043988"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 609,
                column: "CityGUID",
                value: new Guid("3dea57a3-5d0e-4851-818f-99f5bb9745fb"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 610,
                column: "CityGUID",
                value: new Guid("568cb8eb-c453-4c44-9a6b-ee4c5dbe52fa"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 611,
                column: "CityGUID",
                value: new Guid("cca76bc5-94d4-426b-aa90-747f5c9dba66"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 612,
                column: "CityGUID",
                value: new Guid("332ae9e1-58e6-4d81-9b5d-3fa1777624c4"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 613,
                column: "CityGUID",
                value: new Guid("070a32be-e7b1-4646-a624-b567aebc68df"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 614,
                column: "CityGUID",
                value: new Guid("bbec412c-5ee1-4703-b591-8508b5009457"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 615,
                column: "CityGUID",
                value: new Guid("9f09da9b-5120-4b24-a877-eee3a1485901"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 616,
                column: "CityGUID",
                value: new Guid("27c40368-305f-4935-9339-19da2747ae3c"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 617,
                column: "CityGUID",
                value: new Guid("d6d1f74f-52b4-41a3-933b-2fbfea58335e"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 618,
                column: "CityGUID",
                value: new Guid("c396375d-d244-4d9c-bc23-4532710249c7"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 619,
                column: "CityGUID",
                value: new Guid("3cca8158-f3eb-4484-9212-f7074f713479"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 620,
                column: "CityGUID",
                value: new Guid("aef3edfe-03c3-4b68-b1b2-e4e205ce321d"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 621,
                column: "CityGUID",
                value: new Guid("f307fc79-27de-4618-8866-34f2efd29728"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 622,
                column: "CityGUID",
                value: new Guid("ca2049a3-f3ae-4b8f-a5d9-ddc256db6985"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 623,
                column: "CityGUID",
                value: new Guid("31804e59-03dd-4411-b3c5-216bb790b389"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 624,
                column: "CityGUID",
                value: new Guid("e05a8413-c22e-421b-80ea-5fbddb4a99cb"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 625,
                column: "CityGUID",
                value: new Guid("6ba9589c-df43-4b28-bb49-eb38c40b4121"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 626,
                column: "CityGUID",
                value: new Guid("31603c78-cd3c-40be-9457-5548308d73b7"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 627,
                column: "CityGUID",
                value: new Guid("5c78e99d-4ad4-46ff-9926-d8c79479ceb7"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 628,
                column: "CityGUID",
                value: new Guid("79c56956-908a-4113-9129-5d3140c205d3"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 629,
                column: "CityGUID",
                value: new Guid("b9d24b59-8ff8-4285-a508-a0761e33b731"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 630,
                column: "CityGUID",
                value: new Guid("fff51ad5-2b08-41a3-ab5c-2b2612c65a05"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 631,
                column: "CityGUID",
                value: new Guid("e3929e7d-dd68-47b4-98e1-32022be13c09"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 632,
                column: "CityGUID",
                value: new Guid("fc91b5c2-5d9a-43b7-a59f-ab1e113a86d3"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 633,
                column: "CityGUID",
                value: new Guid("fd157397-c2e9-48ab-aab8-c4cd34639d10"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 634,
                column: "CityGUID",
                value: new Guid("efb6aadc-0a5e-4e9e-af13-8d6a9d72dc7d"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 635,
                column: "CityGUID",
                value: new Guid("c19fc1d9-a00a-456b-b023-3d138218ba80"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 636,
                column: "CityGUID",
                value: new Guid("5c4b1173-720d-4ce9-af29-bade7341c03d"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 637,
                column: "CityGUID",
                value: new Guid("72f8ca91-0353-4ae5-ba0a-602513be8049"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 638,
                column: "CityGUID",
                value: new Guid("eab47cc8-04c6-47a1-bac6-d13f18282386"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 639,
                column: "CityGUID",
                value: new Guid("c90281a9-6478-4e79-a76c-3b1e84c92bd6"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 640,
                column: "CityGUID",
                value: new Guid("791e8aa9-cf65-484b-9288-9bb3b4feb5e5"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 641,
                column: "CityGUID",
                value: new Guid("d30d7a69-c99d-4f6b-ac18-ea2b27ba3a28"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 642,
                column: "CityGUID",
                value: new Guid("69583c58-5d31-4ffb-af78-09e3b9e2e75b"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 643,
                column: "CityGUID",
                value: new Guid("6f0fd9cd-43db-4ca8-8123-da9d50c3948e"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 644,
                column: "CityGUID",
                value: new Guid("1bfe70de-94b3-4f3b-ad31-eb09cc7144bb"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 645,
                column: "CityGUID",
                value: new Guid("50420603-bca7-43b3-9f62-a4440bc6ac1f"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 646,
                column: "CityGUID",
                value: new Guid("e6878848-2e31-446a-8a6a-d0fae45dbc18"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 647,
                column: "CityGUID",
                value: new Guid("3a17f207-7bfe-4c94-8931-091136658ebf"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 648,
                column: "CityGUID",
                value: new Guid("a624997d-33d4-4809-8f88-e7e875f05688"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 649,
                column: "CityGUID",
                value: new Guid("8c5fa06e-3265-4b5f-825c-4a34c00a2fef"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 650,
                column: "CityGUID",
                value: new Guid("e2d2982d-c137-418a-9e0d-d6ed714d0a6b"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 651,
                column: "CityGUID",
                value: new Guid("9361f92a-6a71-4146-abd5-68be067be8aa"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 652,
                column: "CityGUID",
                value: new Guid("5faf47c8-95cc-4efe-8ea0-30e800d3ba1b"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 653,
                column: "CityGUID",
                value: new Guid("11208130-58a4-480d-93d5-9cd1c307891c"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 654,
                column: "CityGUID",
                value: new Guid("3fed421c-be4c-4593-b7be-c88f68f5a8dc"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 655,
                column: "CityGUID",
                value: new Guid("ec1d4be1-2960-47f7-8130-34e789f6ca22"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 656,
                column: "CityGUID",
                value: new Guid("184fc24a-90b3-4035-85b6-7c6c3fdb5be1"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 657,
                column: "CityGUID",
                value: new Guid("e8b7f02a-a938-4728-b6e5-19be2ac22a36"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 658,
                column: "CityGUID",
                value: new Guid("d8d380e6-1423-4067-9487-e0b2e68cbb64"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 659,
                column: "CityGUID",
                value: new Guid("422a0f4d-ccae-455d-98de-0332e21a7a0c"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 660,
                column: "CityGUID",
                value: new Guid("e645e271-0572-4e00-b496-2c6357694f93"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 661,
                column: "CityGUID",
                value: new Guid("6cc61c5d-def9-4542-9a8a-edf0b5832e9b"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 662,
                column: "CityGUID",
                value: new Guid("ca5b7ccc-b610-4254-a581-bc0c1ed527b0"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 663,
                column: "CityGUID",
                value: new Guid("60e5aa80-2622-4a41-aeba-7cfaa49640a9"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 664,
                column: "CityGUID",
                value: new Guid("963f150c-3ab1-45f1-8383-cbdd2f09137a"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 665,
                column: "CityGUID",
                value: new Guid("94237527-49cc-40b3-9480-493844551000"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 666,
                column: "CityGUID",
                value: new Guid("6f1ef1ed-9c9e-44ab-b7d8-13660192dc53"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 667,
                column: "CityGUID",
                value: new Guid("ea14f2a0-2c91-4b09-ac12-06f096b376db"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 668,
                column: "CityGUID",
                value: new Guid("f6514fb7-10dc-40c7-9955-b724e2713857"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 669,
                column: "CityGUID",
                value: new Guid("8b6a33ba-740e-41bb-a8fe-67c52c792d64"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 670,
                column: "CityGUID",
                value: new Guid("00796c1f-0dd4-486e-bfc8-fa8806fe69d2"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 671,
                column: "CityGUID",
                value: new Guid("d7c1fda9-85ee-4226-8e49-0baa71faa339"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 672,
                column: "CityGUID",
                value: new Guid("1f612921-2e1f-4c97-84f5-1d8e8edf8f62"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 673,
                column: "CityGUID",
                value: new Guid("82fe52b2-4bbd-4c59-8dd0-3ee67dae06da"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 674,
                column: "CityGUID",
                value: new Guid("ef00270d-3a39-4e0f-b289-12ae5db591b8"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 675,
                column: "CityGUID",
                value: new Guid("b1ea7415-557a-49c2-ad31-d18c6e478356"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 676,
                column: "CityGUID",
                value: new Guid("975b9e85-e68e-4615-b320-446afb06ea8d"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 677,
                column: "CityGUID",
                value: new Guid("142c8ea0-5491-4e8a-814a-0faf67a1b068"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 678,
                column: "CityGUID",
                value: new Guid("5f986aa1-1800-4d04-98c1-1b3c5f6d0a1a"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 679,
                column: "CityGUID",
                value: new Guid("dfa0f3e0-feca-482e-a5fe-1cc4f8c4a58f"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 680,
                column: "CityGUID",
                value: new Guid("3a49a2fa-e9aa-4e24-9ad0-1e1be12cac9c"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 681,
                column: "CityGUID",
                value: new Guid("8d6f0496-d7a3-42b2-91e3-c57131fe333b"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 682,
                column: "CityGUID",
                value: new Guid("a9c061d3-cb12-4ff5-8b07-1647dffd10ea"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 683,
                column: "CityGUID",
                value: new Guid("f031e363-7c0c-4f4a-86f5-8a1769d13465"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 684,
                column: "CityGUID",
                value: new Guid("60791198-a7f3-43a5-844a-279a5a39ae0f"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 685,
                column: "CityGUID",
                value: new Guid("72aab137-9e9e-4689-a52e-069e7285e5b4"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 686,
                column: "CityGUID",
                value: new Guid("95b912b4-5ccd-4f3f-b0ad-3ac4cfc7b901"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 687,
                column: "CityGUID",
                value: new Guid("796352ca-dad2-4acc-a4f6-40eeb9d7934a"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 688,
                column: "CityGUID",
                value: new Guid("8a48f538-b747-4620-8cbc-0ef3d493702b"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 689,
                column: "CityGUID",
                value: new Guid("6c8881cb-1f4a-4404-ab54-dcefe5170df5"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 690,
                column: "CityGUID",
                value: new Guid("c1c2994e-16ec-4e12-9ac6-434852048df5"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 691,
                column: "CityGUID",
                value: new Guid("69597bce-e8a7-4221-ad47-7cc4d7003313"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 692,
                column: "CityGUID",
                value: new Guid("9f7688eb-25fb-4a04-9b3d-0a10fa8ac213"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 693,
                column: "CityGUID",
                value: new Guid("30c0b6a4-e4aa-4b83-acbe-f96605ee1935"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 694,
                column: "CityGUID",
                value: new Guid("87975e8e-3f60-4c62-b590-7d765e22724b"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 695,
                column: "CityGUID",
                value: new Guid("1f43802d-286a-4014-9805-f90e50aec9eb"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 696,
                column: "CityGUID",
                value: new Guid("fe363fe4-4ae4-4493-82ed-34b82b2d703f"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 697,
                column: "CityGUID",
                value: new Guid("fcf1ade3-bc13-405e-ae16-4748d056459d"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 698,
                column: "CityGUID",
                value: new Guid("ab4b4a6c-271a-4452-8146-9bfa5fca8a42"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 699,
                column: "CityGUID",
                value: new Guid("112dc683-a7e6-4d16-b624-19b2c8d439c0"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 700,
                column: "CityGUID",
                value: new Guid("6348d7ba-ad0a-4254-a68f-cdbe4903efe7"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 701,
                column: "CityGUID",
                value: new Guid("1e9e683a-42d9-4972-9499-85e603eb595e"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 702,
                column: "CityGUID",
                value: new Guid("a902f6e9-9fff-4841-bd2c-9a70f877f776"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 703,
                column: "CityGUID",
                value: new Guid("96582992-3a30-4fbe-8243-b6cee825086e"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 704,
                column: "CityGUID",
                value: new Guid("234c89e9-70f3-490c-a463-8050d50163b0"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 705,
                column: "CityGUID",
                value: new Guid("6d9546b8-43dc-40ed-95b4-ebf6b9a52f36"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 706,
                column: "CityGUID",
                value: new Guid("4cdd5e17-2f07-44b5-a18d-4e9865dfdfda"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 707,
                column: "CityGUID",
                value: new Guid("e8133fc4-f605-4255-b71a-9879ede96340"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 708,
                column: "CityGUID",
                value: new Guid("85fec99c-ffbf-4f3f-9234-84475c0c26a2"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 709,
                column: "CityGUID",
                value: new Guid("799e166c-2189-4325-b5c5-510d63af6fe3"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 710,
                column: "CityGUID",
                value: new Guid("51607076-8565-4bd4-9c8e-217651855ed1"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 711,
                column: "CityGUID",
                value: new Guid("d342ec95-c3d6-4ac0-8e8d-0e3bb243525f"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 712,
                column: "CityGUID",
                value: new Guid("e3b75329-12be-4892-bb1b-ed62f54ce94d"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 713,
                column: "CityGUID",
                value: new Guid("bf6044e2-049d-4a70-a1ac-5b8732ffcb50"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 714,
                column: "CityGUID",
                value: new Guid("5e36a563-df2a-4fba-bee7-6eae218ab7c2"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 715,
                column: "CityGUID",
                value: new Guid("8c0eeee1-9bfe-4db6-8633-8f923872e7a0"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 716,
                column: "CityGUID",
                value: new Guid("ddff4c96-6ede-4ec7-8be2-8c99839b2a6d"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 717,
                column: "CityGUID",
                value: new Guid("13478613-b024-455c-95bb-90e73f47af30"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 718,
                column: "CityGUID",
                value: new Guid("b9440608-5043-436b-ac40-64171b4ce346"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 719,
                column: "CityGUID",
                value: new Guid("02b1dc60-5577-40b1-999c-6a3f8b46b584"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 720,
                column: "CityGUID",
                value: new Guid("2b3aceb4-b576-4331-a8eb-c90a84f35814"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 721,
                column: "CityGUID",
                value: new Guid("485132ac-2937-4acd-85d9-b13105e7c188"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 722,
                column: "CityGUID",
                value: new Guid("fc1847b8-9edb-44ac-82ec-cee010ace43c"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 723,
                column: "CityGUID",
                value: new Guid("66628604-f7e8-4ae4-bc0c-499c70dabaf5"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 724,
                column: "CityGUID",
                value: new Guid("fe4cd482-4cf9-4bc8-bb8e-06c58fe70b75"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 725,
                column: "CityGUID",
                value: new Guid("309ff8ca-41d0-4d3b-89d2-3260583a5f8f"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 726,
                column: "CityGUID",
                value: new Guid("609277e4-d657-462b-afce-7d9f188e8d27"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 727,
                column: "CityGUID",
                value: new Guid("a94105ba-9e68-49b8-9ed6-d64eb00815b6"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 728,
                column: "CityGUID",
                value: new Guid("838825be-ec40-4bb2-a15d-51c266dd70ec"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 729,
                column: "CityGUID",
                value: new Guid("a55354af-fe86-4b0d-8b5a-7aa38a9c9652"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 730,
                column: "CityGUID",
                value: new Guid("6623af66-c3a7-4a0e-b142-79be3b70e92e"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 731,
                column: "CityGUID",
                value: new Guid("0473f208-5348-40d6-ac46-a006a74c27e1"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 732,
                column: "CityGUID",
                value: new Guid("c24e4ce1-263a-418d-ac03-4726ec2fcb9a"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 733,
                column: "CityGUID",
                value: new Guid("7ac4887b-d5de-46de-b800-9cb43e2e91a4"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 734,
                column: "CityGUID",
                value: new Guid("ba2a0be9-26ed-4654-813b-92b33b1a7b9d"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 735,
                column: "CityGUID",
                value: new Guid("6c43d6ce-0f67-485e-98c2-1bbec9b7aa57"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 736,
                column: "CityGUID",
                value: new Guid("1156c61e-7056-4dd9-9b86-246e81a6cf63"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 737,
                column: "CityGUID",
                value: new Guid("66f05261-1f3d-46d6-bb58-a7216be8ade2"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 738,
                column: "CityGUID",
                value: new Guid("ffeb3eb7-e47d-4a7e-b71c-c43639cf4da0"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 739,
                column: "CityGUID",
                value: new Guid("20476dda-533d-4deb-a5b5-2b1113ab7f84"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 740,
                column: "CityGUID",
                value: new Guid("f06beac6-7c26-4cff-9e15-aa248b361fbe"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 741,
                column: "CityGUID",
                value: new Guid("b89fa4a8-ab05-4ba6-8fb3-3110212eea5b"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 742,
                column: "CityGUID",
                value: new Guid("755160c1-e037-452e-b320-d805726f944a"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 743,
                column: "CityGUID",
                value: new Guid("e660db96-a5eb-4905-997e-72eb7d1a62dc"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 744,
                column: "CityGUID",
                value: new Guid("41f69d8e-2f34-4977-afcc-5e974f4e2920"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 745,
                column: "CityGUID",
                value: new Guid("cb97accb-acd3-4be2-9ae3-07231563ebec"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 746,
                column: "CityGUID",
                value: new Guid("70145737-540c-4f66-b441-de8bf0abc8a5"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 747,
                column: "CityGUID",
                value: new Guid("faf59686-7d74-444c-90b8-cf7f1455aa58"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 748,
                column: "CityGUID",
                value: new Guid("65937795-733f-46c3-ab76-3700c448116b"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 749,
                column: "CityGUID",
                value: new Guid("41941966-bd30-4680-9021-0db7e0152149"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 750,
                column: "CityGUID",
                value: new Guid("68bf2fe9-d4c0-4ee8-9651-16c37056cf05"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 751,
                column: "CityGUID",
                value: new Guid("9ebaf10f-f9c5-44a8-a759-5f2229c2ec73"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 752,
                column: "CityGUID",
                value: new Guid("798c5a89-576e-4e1e-9421-5c74aedf6047"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 753,
                column: "CityGUID",
                value: new Guid("eba1ed4b-912c-42d6-a11e-ec7cee08d47b"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 754,
                column: "CityGUID",
                value: new Guid("0c9ecfa9-226a-497d-a9e5-22a50d90e6db"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 755,
                column: "CityGUID",
                value: new Guid("6842f43d-e219-44e8-827c-3232ff5ebc39"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 756,
                column: "CityGUID",
                value: new Guid("eb899f0c-9ed3-4443-8f8c-a23937ab4776"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 757,
                column: "CityGUID",
                value: new Guid("f30678f8-b716-4830-a2e0-acacb32675f2"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 758,
                column: "CityGUID",
                value: new Guid("3e0d7b49-21a1-4435-8ec7-dea3578c2549"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 759,
                column: "CityGUID",
                value: new Guid("f7cf850f-ffb0-4266-9e76-4723e837bf5c"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 760,
                column: "CityGUID",
                value: new Guid("86a5047e-a95f-43f7-a2b8-99f985c096a2"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 761,
                column: "CityGUID",
                value: new Guid("f98c7335-f0da-402d-add1-59a58916b2fa"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 762,
                column: "CityGUID",
                value: new Guid("fe7770f5-6a26-4b4f-98dc-d28f1f68d806"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 763,
                column: "CityGUID",
                value: new Guid("496480f9-c9a4-49f1-82d5-9a520d6d4d8a"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 764,
                column: "CityGUID",
                value: new Guid("b878931f-37f3-4c5f-a4bf-1c69cf8c8b40"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 765,
                column: "CityGUID",
                value: new Guid("c044c41c-05b9-4cfd-8ea6-9124ca8b2331"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 766,
                column: "CityGUID",
                value: new Guid("a39e37cf-70a6-477d-b78e-84bfc45f378a"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 767,
                column: "CityGUID",
                value: new Guid("0327e865-c7a1-4504-8d9d-4cd2dec15aed"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 768,
                column: "CityGUID",
                value: new Guid("c51e0ccc-a95d-470b-9b22-70fc88dd0a1f"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 769,
                column: "CityGUID",
                value: new Guid("bda7617f-4d2a-4fa7-b4b2-fdbb2c95a2fd"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 770,
                column: "CityGUID",
                value: new Guid("a9224bba-77ea-4671-a402-1ff056c73ff9"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 771,
                column: "CityGUID",
                value: new Guid("f240e502-e40b-47bd-af4b-f12000502120"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 772,
                column: "CityGUID",
                value: new Guid("03b5bec7-a815-4f16-985c-653a5b0c60d6"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 773,
                column: "CityGUID",
                value: new Guid("2b911576-75ad-438d-9616-1a8e02903387"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 774,
                column: "CityGUID",
                value: new Guid("987610c7-dfd0-418a-87e5-295176b49aaa"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 775,
                column: "CityGUID",
                value: new Guid("56feaa98-9e7c-45c5-ac95-81472a90d243"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 776,
                column: "CityGUID",
                value: new Guid("84252f63-b5f6-437a-a0ed-c846288e784d"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 777,
                column: "CityGUID",
                value: new Guid("fbf5e0ed-9f08-4f28-be9a-7c6d956d0e39"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 778,
                column: "CityGUID",
                value: new Guid("35fd32bf-e3cf-4090-b238-7004a9ec0c8d"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 779,
                column: "CityGUID",
                value: new Guid("a7747f29-a382-4278-9561-d15d16f0f986"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 780,
                column: "CityGUID",
                value: new Guid("8bd1c960-1c15-45ae-b5e6-ca8f5a5ca386"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 781,
                column: "CityGUID",
                value: new Guid("6f0ab50a-da53-499b-9cc9-a1c3e4209fdb"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 782,
                column: "CityGUID",
                value: new Guid("0b430615-4fa9-4daa-80d0-6c9b008a7117"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 783,
                column: "CityGUID",
                value: new Guid("b208975f-6bc5-49c4-8823-27b217ad33c1"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 784,
                column: "CityGUID",
                value: new Guid("141ca398-fb4a-4333-bab8-ad1892c32ffd"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 785,
                column: "CityGUID",
                value: new Guid("50138c27-3544-4f13-a8f8-f0270bde7979"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 786,
                column: "CityGUID",
                value: new Guid("afe45e4c-9b28-4bc9-947f-e2122190943f"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 787,
                column: "CityGUID",
                value: new Guid("24102e70-74c0-4c77-873a-136d9f20d068"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 788,
                column: "CityGUID",
                value: new Guid("e9181f96-59eb-4e19-8c06-6e2dec7aeb92"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 789,
                column: "CityGUID",
                value: new Guid("ff7227a6-765e-4608-8daf-1dc7621b7cce"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 790,
                column: "CityGUID",
                value: new Guid("4a866a68-bfbd-4bd5-b2c4-06fc3fd2e79f"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 791,
                column: "CityGUID",
                value: new Guid("edfd959d-1fdc-482a-8760-6eb05570ee55"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 792,
                column: "CityGUID",
                value: new Guid("b2f97c59-8a06-4211-8877-3272ff746b05"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 793,
                column: "CityGUID",
                value: new Guid("5cb51a02-9ac6-4b57-8123-4f40fb62675a"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 794,
                column: "CityGUID",
                value: new Guid("8f35c66b-99c1-4de1-9aef-229d1314b52c"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 795,
                column: "CityGUID",
                value: new Guid("253a6410-d83f-4035-aa2e-3b97a63c3086"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 796,
                column: "CityGUID",
                value: new Guid("e8635c9a-25fc-4acf-a3dc-d98ad7d2a232"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 797,
                column: "CityGUID",
                value: new Guid("89b25deb-9147-49cf-a282-b26e4d6b632b"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 798,
                column: "CityGUID",
                value: new Guid("13e2ae0e-cc2c-4a01-9cfe-dfa72d39868b"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 799,
                column: "CityGUID",
                value: new Guid("539f3fe2-bb49-4158-854d-e2d1f8279dfe"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 800,
                column: "CityGUID",
                value: new Guid("1c8664fc-b43c-4e2b-bf03-5c8136f9575b"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 801,
                column: "CityGUID",
                value: new Guid("44bd3a52-92dc-429c-8983-023ff742afb9"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 802,
                column: "CityGUID",
                value: new Guid("efd94d0c-778c-4f71-bdbd-6e7816e9af08"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 803,
                column: "CityGUID",
                value: new Guid("682efc9e-4ebb-4cf9-aa93-5fd266b6771d"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 804,
                column: "CityGUID",
                value: new Guid("386da61b-ebdb-4d35-8dbf-079e78a78a17"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 805,
                column: "CityGUID",
                value: new Guid("c98bbd30-ffe2-436f-9caf-794058ae5162"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 806,
                column: "CityGUID",
                value: new Guid("c6ea450a-9634-4d9d-ba61-b62d6b6fad22"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 807,
                column: "CityGUID",
                value: new Guid("4f57139e-8ff8-427f-a5ba-b6e76efecafe"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 808,
                column: "CityGUID",
                value: new Guid("579b775a-981d-4128-8ca3-d968b1751f9c"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 809,
                column: "CityGUID",
                value: new Guid("035e5593-abfe-49d6-ae3a-8f3f0f87321b"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 810,
                column: "CityGUID",
                value: new Guid("3a175b2c-e0d5-4d15-b42e-6c71dce13e60"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 811,
                column: "CityGUID",
                value: new Guid("caa5aa12-10af-47db-a763-fec614bb2de7"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 812,
                column: "CityGUID",
                value: new Guid("21b351ad-f17a-4836-aa23-e7c4972036bd"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 813,
                column: "CityGUID",
                value: new Guid("1b9fbbd6-f347-4435-8a4e-d11e86139b46"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 814,
                column: "CityGUID",
                value: new Guid("32f765e9-1bae-4c00-b016-a0e15dbd7f35"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 815,
                column: "CityGUID",
                value: new Guid("e6696705-3c87-4166-85d9-7f8ce2aa6b99"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 816,
                column: "CityGUID",
                value: new Guid("e3d302b0-4ad6-44ec-a39e-d363e1c8dea4"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 817,
                column: "CityGUID",
                value: new Guid("46d7a998-3ff8-415b-bec3-5aad02d3438e"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 818,
                column: "CityGUID",
                value: new Guid("6ebceb53-ae5e-4ff7-a7ed-73738d6f1a63"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 819,
                column: "CityGUID",
                value: new Guid("18a45b94-b81f-46b6-9a01-c455544434b8"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 820,
                column: "CityGUID",
                value: new Guid("20175686-29c9-4a50-963f-e1c7ff49a4a5"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 821,
                column: "CityGUID",
                value: new Guid("061fb201-ae6c-4d4b-b856-4d7b19b03b21"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 822,
                column: "CityGUID",
                value: new Guid("1a70554a-2002-4b97-932d-2a5cc499c0ef"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 823,
                column: "CityGUID",
                value: new Guid("34fb3e94-a063-44a8-92a0-8cf56fb3d636"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 824,
                column: "CityGUID",
                value: new Guid("9575ca9b-2d63-4adb-8f2b-3ae6301bb00b"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 825,
                column: "CityGUID",
                value: new Guid("e72c8390-1547-414c-a39b-117b430b8e4e"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 826,
                column: "CityGUID",
                value: new Guid("2db375e1-9d87-445f-97a9-7bb976c3b259"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 827,
                column: "CityGUID",
                value: new Guid("01377a04-2fa1-4309-9dd4-d267463bf02b"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 828,
                column: "CityGUID",
                value: new Guid("88634011-16d9-4593-bc4d-e9af6f3f242a"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 829,
                column: "CityGUID",
                value: new Guid("859a2093-e8dd-47e6-93f4-92749c2df124"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 830,
                column: "CityGUID",
                value: new Guid("25fc4279-bb54-4d23-b172-8b029aac3304"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 831,
                column: "CityGUID",
                value: new Guid("48b3fa85-f2f8-4c91-bc33-67a6c3f623d0"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 832,
                column: "CityGUID",
                value: new Guid("5c1ed9a2-59a5-4be6-8851-75471e48565c"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 833,
                column: "CityGUID",
                value: new Guid("9907c389-c587-4a22-a64f-72ed004c7565"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 834,
                column: "CityGUID",
                value: new Guid("a8541916-2127-4cf3-85c3-b6bacd12416f"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 835,
                column: "CityGUID",
                value: new Guid("430d9d25-368b-45e5-abfe-85f171854f69"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 836,
                column: "CityGUID",
                value: new Guid("7eadf501-5feb-4e78-817a-af09c3d167a3"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 837,
                column: "CityGUID",
                value: new Guid("eecbffa4-5f96-4bc0-8c8b-df73ffaf7137"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 838,
                column: "CityGUID",
                value: new Guid("8049b7de-3af5-447f-912a-6de6c122271c"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 839,
                column: "CityGUID",
                value: new Guid("7108f27b-07c3-4678-bfcb-d28b4e90c7bf"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 840,
                column: "CityGUID",
                value: new Guid("f01f6ac3-5ae0-484b-8ad1-2ade2592eb7f"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 841,
                column: "CityGUID",
                value: new Guid("6a169a85-7712-4b73-b922-a0eb92e71961"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 842,
                column: "CityGUID",
                value: new Guid("c173e68d-9e74-4cee-bda2-5a7dcfa68799"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 843,
                column: "CityGUID",
                value: new Guid("58b6c933-ef17-4757-ac2f-5985f9c48230"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 844,
                column: "CityGUID",
                value: new Guid("891ce30c-48da-49e8-9bbf-9d80d433432f"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 845,
                column: "CityGUID",
                value: new Guid("6564c891-af3e-4b04-9553-bc052e581b0b"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 846,
                column: "CityGUID",
                value: new Guid("44781a70-2fa0-4b14-85e6-0696b2f746ba"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 847,
                column: "CityGUID",
                value: new Guid("1d4257f4-7842-44ad-884c-9947f7ede685"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 848,
                column: "CityGUID",
                value: new Guid("93d4110e-3240-4df7-897c-dcf2b2840de3"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 849,
                column: "CityGUID",
                value: new Guid("eacf1f8d-d0d1-4fdc-9443-fe2aaaa4b364"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 850,
                column: "CityGUID",
                value: new Guid("d92eddab-4561-44fa-aff3-4df78862aa27"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 851,
                column: "CityGUID",
                value: new Guid("61ff8db2-03a4-43c2-bbe8-6016be656bc3"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 852,
                column: "CityGUID",
                value: new Guid("901a2300-7cc1-4d8c-a08b-79f9579c068f"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 853,
                column: "CityGUID",
                value: new Guid("e869dd41-46e7-45b5-960b-c822f5118463"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 854,
                column: "CityGUID",
                value: new Guid("dab09177-e04a-4afc-b05a-1b5e1cd9b375"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 855,
                column: "CityGUID",
                value: new Guid("90727a89-8669-454f-9a02-2731217970e2"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 856,
                column: "CityGUID",
                value: new Guid("0fa8e4a4-6eb8-4f46-9750-1829f10ebfb4"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 857,
                column: "CityGUID",
                value: new Guid("8d2d42d7-9b81-42bc-a41b-c6e2b7c57bf8"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 858,
                column: "CityGUID",
                value: new Guid("bdcccea0-ae46-4f5e-a02b-0bd0cbb0a06d"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 859,
                column: "CityGUID",
                value: new Guid("677fcf01-97e1-47ea-9541-e62311d1a970"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 860,
                column: "CityGUID",
                value: new Guid("362f85b3-a61e-4ca8-a6e6-955a8c95b281"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 861,
                column: "CityGUID",
                value: new Guid("ccb4228d-db50-4b88-be67-3527ad38bc37"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 862,
                column: "CityGUID",
                value: new Guid("f276185e-97a2-4008-99fc-8f670c1c59a9"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 863,
                column: "CityGUID",
                value: new Guid("a2d25b8d-47b9-4136-823c-6d810af7cdd1"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 864,
                column: "CityGUID",
                value: new Guid("7a054140-d05b-463e-aeae-aa2651123eb2"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 865,
                column: "CityGUID",
                value: new Guid("42ffc608-5e93-4ffe-919f-6e3ab58f4771"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 866,
                column: "CityGUID",
                value: new Guid("60863c5c-e919-4edf-b661-39bd76a3d16a"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 867,
                column: "CityGUID",
                value: new Guid("d8fb97b7-7725-4748-a045-d2d44eeb57e8"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 868,
                column: "CityGUID",
                value: new Guid("d77bf4c8-7098-47d7-9187-4a356b6f6a90"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 869,
                column: "CityGUID",
                value: new Guid("6b30af8e-1c45-48da-825f-21c67cb18ec2"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 870,
                column: "CityGUID",
                value: new Guid("b17f0bae-3c7a-44ce-8b37-27c2d20e98f5"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 871,
                column: "CityGUID",
                value: new Guid("78c64a1b-c301-4d9c-a934-66e0dbe596ab"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 872,
                column: "CityGUID",
                value: new Guid("42396188-dd2a-4eb8-ba76-6edfb0fc3b28"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 873,
                column: "CityGUID",
                value: new Guid("ef9e2e8c-d22a-4afe-a6ff-8a200da3ed7d"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 874,
                column: "CityGUID",
                value: new Guid("c6ca6b22-dfb3-4e9f-b956-8181dd3ef319"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 875,
                column: "CityGUID",
                value: new Guid("a9365993-2aa5-4b37-9791-6d7db3cf2407"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 876,
                column: "CityGUID",
                value: new Guid("7818f5e2-7c0c-452a-a846-bf1e0fa194b6"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 877,
                column: "CityGUID",
                value: new Guid("fdf1745d-5d5f-4711-9752-afcb43955930"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 878,
                column: "CityGUID",
                value: new Guid("7ad47de8-54ac-4dbb-a582-eef3c460e904"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 879,
                column: "CityGUID",
                value: new Guid("514560f0-9aeb-4d96-a553-ad05699a31ee"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 880,
                column: "CityGUID",
                value: new Guid("92384017-27a4-40c8-bf3f-02ae15a64b5c"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 881,
                column: "CityGUID",
                value: new Guid("3b093bf0-a60f-45a6-b24d-c194614600ad"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 882,
                column: "CityGUID",
                value: new Guid("27ef2e27-14c0-49ff-a970-15dbd129dc3b"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 883,
                column: "CityGUID",
                value: new Guid("aaf50b07-37c8-4a2a-abbf-fa58e90e4998"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 884,
                column: "CityGUID",
                value: new Guid("61d91c7f-b8d9-4855-abd9-c4838f4adda4"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 885,
                column: "CityGUID",
                value: new Guid("a174db79-3a0d-4e60-b3ca-6518431bd348"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 886,
                column: "CityGUID",
                value: new Guid("9aaf8984-9bd7-4bf7-a32c-b54554b329e1"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 887,
                column: "CityGUID",
                value: new Guid("1cd80236-ef1c-49a9-bc21-dfff258ccbce"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 888,
                column: "CityGUID",
                value: new Guid("b992ff33-c5bc-4488-9c0a-ac923d19ad7c"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 889,
                column: "CityGUID",
                value: new Guid("18733e07-843f-482b-9632-ddb0ce6b1e12"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 890,
                column: "CityGUID",
                value: new Guid("07ab4a35-6b2b-4d4e-bced-f0f14691a34c"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 891,
                column: "CityGUID",
                value: new Guid("d0c63796-7e89-4311-a930-1b2a7a665a1d"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 892,
                column: "CityGUID",
                value: new Guid("6ae773c6-c0a8-4b64-aa94-eaee80c76ef1"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 893,
                column: "CityGUID",
                value: new Guid("a491c37c-8c83-406f-bcc0-f6f7b1143760"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 894,
                column: "CityGUID",
                value: new Guid("b3eb6fbe-882b-446d-aa16-6c7a4f01cd24"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 895,
                column: "CityGUID",
                value: new Guid("1e7c8fe4-3480-447f-953f-f3ea56a07cb0"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 896,
                column: "CityGUID",
                value: new Guid("1c42a818-bb90-411f-91a0-38ff0daa19b3"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 897,
                column: "CityGUID",
                value: new Guid("4bdfc882-bc1a-4de2-b907-53c0ea665c66"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 898,
                column: "CityGUID",
                value: new Guid("403de804-4a3c-415c-8508-0513a9ddd62f"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 899,
                column: "CityGUID",
                value: new Guid("07a3e23e-397c-48bb-aac9-3dd55c4dcf4f"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 900,
                column: "CityGUID",
                value: new Guid("141ab1df-c641-4031-9c14-af39ab82fd41"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 901,
                column: "CityGUID",
                value: new Guid("27067571-8a96-44cf-9a53-b706881d4a44"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 902,
                column: "CityGUID",
                value: new Guid("927d2a53-6bd6-4d6f-bde7-67042eca9935"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 903,
                column: "CityGUID",
                value: new Guid("a0ee8aaa-5518-45a9-9d48-fd159bb65d83"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 904,
                column: "CityGUID",
                value: new Guid("56fb0035-5c95-4bf4-b337-8e10ef8d41c8"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 905,
                column: "CityGUID",
                value: new Guid("a0ce3600-7b05-4e96-9656-bce26aaec492"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 906,
                column: "CityGUID",
                value: new Guid("8573de7f-56af-4360-8046-2e909755931d"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 907,
                column: "CityGUID",
                value: new Guid("c97b6e4f-ff00-4d4e-bb42-d3d9c0ff270c"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 908,
                column: "CityGUID",
                value: new Guid("b5d24ba2-54f2-44a0-a55e-2283d526d008"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 909,
                column: "CityGUID",
                value: new Guid("3bcbd598-856f-4a39-9860-b889bcbafbfc"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 910,
                column: "CityGUID",
                value: new Guid("515bb804-d7c7-4cf1-acd1-72e80a45bd99"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 911,
                column: "CityGUID",
                value: new Guid("deff0830-c617-48c2-ac8b-422de0f926b0"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 912,
                column: "CityGUID",
                value: new Guid("0a888a94-4dba-4e7f-8659-c1b945fa1d65"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 913,
                column: "CityGUID",
                value: new Guid("9cc3fc72-3d37-4f6b-a0cd-7caa7273151e"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 914,
                column: "CityGUID",
                value: new Guid("5ff86d3b-00de-4238-bf32-09a4650f0bcc"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 915,
                column: "CityGUID",
                value: new Guid("c2f65719-d48b-4f32-84c5-b54ed59785c9"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 916,
                column: "CityGUID",
                value: new Guid("d3a7d7b1-887b-407d-8598-c26854110789"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 917,
                column: "CityGUID",
                value: new Guid("707353af-d266-4fc4-adac-1307178c67d6"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 918,
                column: "CityGUID",
                value: new Guid("3cb8a582-7b98-4831-8060-407fe3b9e40b"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 919,
                column: "CityGUID",
                value: new Guid("2f414512-b864-4531-a7b2-3624f921d0fb"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 920,
                column: "CityGUID",
                value: new Guid("90f95217-39c6-47d9-9dc1-55626c628745"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 921,
                column: "CityGUID",
                value: new Guid("c5d7f5e6-9265-4915-bc46-87609823c659"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 922,
                column: "CityGUID",
                value: new Guid("812ef4a8-dd48-4d2e-b343-1fddb7fd21cc"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 923,
                column: "CityGUID",
                value: new Guid("193c5b92-9648-4500-a45d-ce85c2a07fca"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 924,
                column: "CityGUID",
                value: new Guid("83bf445d-ecb0-4e8b-9a2a-dd5456d219bd"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 925,
                column: "CityGUID",
                value: new Guid("25b1392f-5293-4800-90b1-6e7b20ab90f8"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 926,
                column: "CityGUID",
                value: new Guid("9010f070-d973-4171-961c-cc1eda9b0173"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 927,
                column: "CityGUID",
                value: new Guid("832407df-63db-4dfe-bfc3-283e44505c03"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 928,
                column: "CityGUID",
                value: new Guid("6ba85bce-db0c-4e7c-8a09-0c06b438371b"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 929,
                column: "CityGUID",
                value: new Guid("2934665d-f7a5-41d5-82a7-370853fea1dc"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 930,
                column: "CityGUID",
                value: new Guid("929ff3e3-cda6-40cb-8e4b-eb77c2f4c5f7"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 931,
                column: "CityGUID",
                value: new Guid("8440e116-ba57-4de2-a432-72bfaaf7c437"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 932,
                column: "CityGUID",
                value: new Guid("70ec7ecf-f2fa-4038-b1c6-05fd55da34e3"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 933,
                column: "CityGUID",
                value: new Guid("50af2984-b0c2-4d6b-8316-f6ae6fba8240"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 934,
                column: "CityGUID",
                value: new Guid("e33f7e26-ad74-4307-bc65-c4f91228af0d"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 935,
                column: "CityGUID",
                value: new Guid("9116e51c-c692-4241-967e-30bd97382d29"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 936,
                column: "CityGUID",
                value: new Guid("c2ca7b22-ef9f-4039-8fba-e8b88942dfaf"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 937,
                column: "CityGUID",
                value: new Guid("fea47264-8271-4e58-a81f-70729a33b201"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 938,
                column: "CityGUID",
                value: new Guid("57370c6b-2194-4928-8d85-40c314b404ca"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 939,
                column: "CityGUID",
                value: new Guid("7dd24432-64ac-472f-b398-dd44ed31828f"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 940,
                column: "CityGUID",
                value: new Guid("d8831042-f4cf-4047-87ed-bc0436e65a8f"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 941,
                column: "CityGUID",
                value: new Guid("98982c19-8484-4409-8da6-48cd74b84b21"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 942,
                column: "CityGUID",
                value: new Guid("f8e92278-2b09-48d0-b3f9-7a938e4257c1"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 943,
                column: "CityGUID",
                value: new Guid("f2711509-b0ef-4c25-9d1b-02e56c2be898"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 944,
                column: "CityGUID",
                value: new Guid("1c817b40-bbfb-4249-acbf-dd28330c0cb1"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 945,
                column: "CityGUID",
                value: new Guid("555ca00e-1eb9-4274-bcba-10807e2f6bd1"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 946,
                column: "CityGUID",
                value: new Guid("da456513-3caf-4261-b996-5256c99248de"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 947,
                column: "CityGUID",
                value: new Guid("b4bb5757-0464-4081-856c-0229094ebb17"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 948,
                column: "CityGUID",
                value: new Guid("bb36d5fd-65d3-443f-9638-939459ee6673"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 949,
                column: "CityGUID",
                value: new Guid("c8bc5067-eda4-4ea3-ae6a-816090cb6a2a"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 950,
                column: "CityGUID",
                value: new Guid("580b1196-e3a7-41b9-8378-295088d17530"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 951,
                column: "CityGUID",
                value: new Guid("fd8e8741-f551-4df5-873f-6ff823420c79"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 952,
                column: "CityGUID",
                value: new Guid("3aa976de-3ea2-4336-a922-92f065da3ae1"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 953,
                column: "CityGUID",
                value: new Guid("004f5145-28ed-4be5-8171-aa2eca953237"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 954,
                column: "CityGUID",
                value: new Guid("8e49ca87-ad4f-4fd1-a2d2-dab8fadd3d5b"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 955,
                column: "CityGUID",
                value: new Guid("61b21849-d024-4f7f-af10-41e1a0e5c4fe"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 956,
                column: "CityGUID",
                value: new Guid("40f8177e-3200-4d68-aef8-7df358a4370f"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 957,
                column: "CityGUID",
                value: new Guid("74347925-3cb6-4b22-b9a9-185d10de0619"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 958,
                column: "CityGUID",
                value: new Guid("a403f1ad-74f7-4cb2-8ba3-e24cec819302"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 959,
                column: "CityGUID",
                value: new Guid("487ef6fe-713b-4ef7-a3d1-7955333d435e"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 960,
                column: "CityGUID",
                value: new Guid("0a024d3d-d88a-47b4-9cfe-77d4f8ecf52c"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 961,
                column: "CityGUID",
                value: new Guid("78b4bb9d-2327-418d-93e5-1e98f4929c40"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 962,
                column: "CityGUID",
                value: new Guid("01e9e8da-aec1-4ed4-b744-068956e50190"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 963,
                column: "CityGUID",
                value: new Guid("178e0e22-e0e6-423e-86df-90b7c405467b"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 964,
                column: "CityGUID",
                value: new Guid("72f7557f-dcaf-4993-ab93-f84daac285d1"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 965,
                column: "CityGUID",
                value: new Guid("07473966-672d-477d-b045-3fb1c6eed9db"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 966,
                column: "CityGUID",
                value: new Guid("cfbbb049-ed02-4313-a3ec-e0193ee1778f"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 967,
                column: "CityGUID",
                value: new Guid("e5d946c5-a666-4422-8951-2de5b07b0708"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 968,
                column: "CityGUID",
                value: new Guid("9c3a0d6c-008e-4714-8353-21302d8791be"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 969,
                column: "CityGUID",
                value: new Guid("b6e242b9-7fbb-4019-a5b5-8ff6c92a5a93"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 970,
                column: "CityGUID",
                value: new Guid("33ca2a61-8a65-4c54-9340-4fdde4a0f5e9"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 971,
                column: "CityGUID",
                value: new Guid("5805b929-acc0-4a23-9d0f-2bd21ebfa76e"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 972,
                column: "CityGUID",
                value: new Guid("70845466-705c-4158-b747-f5fd929c4197"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 973,
                column: "CityGUID",
                value: new Guid("64cdc374-7408-4d4a-99d1-949e1909c68b"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 974,
                column: "CityGUID",
                value: new Guid("47d8a92b-8edb-4b8c-b068-7dc432ad3240"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 975,
                column: "CityGUID",
                value: new Guid("72296e0c-fbd2-4ab7-b9df-0515a8cb8eb7"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 976,
                column: "CityGUID",
                value: new Guid("8dfb1d81-6b1e-4f07-9f82-a2ad62e051d8"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 977,
                column: "CityGUID",
                value: new Guid("9bea9004-657f-4b7c-9e66-07b9d75f604f"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 978,
                column: "CityGUID",
                value: new Guid("1a326b9f-bc51-4201-a54b-20b170b585f2"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 979,
                column: "CityGUID",
                value: new Guid("b0a70cbf-c4d5-4ef6-b8be-7bea8b5f87e0"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 980,
                column: "CityGUID",
                value: new Guid("7fa53665-19c9-4539-a06e-241781065ae0"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 981,
                column: "CityGUID",
                value: new Guid("27d72c96-ce60-4ed2-a7ab-a76e50b7b1e3"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 982,
                column: "CityGUID",
                value: new Guid("59572cb0-9681-412b-9914-9f459925d1af"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 983,
                column: "CityGUID",
                value: new Guid("59bbd07a-9dd7-466c-9691-0a72e1ca4a46"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 984,
                column: "CityGUID",
                value: new Guid("9c624cfe-9044-4722-97ea-7a1c05208fcb"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 985,
                column: "CityGUID",
                value: new Guid("82e4aeb7-e441-4937-8f67-7474b84ec64d"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 986,
                column: "CityGUID",
                value: new Guid("3c9da46e-f1f9-4894-8c96-e66b97b76f13"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 987,
                column: "CityGUID",
                value: new Guid("c701dc0b-2892-405f-b005-b652c1ad7acd"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 988,
                column: "CityGUID",
                value: new Guid("82a371ec-5ca7-4249-b3c3-2d284c4c6541"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 989,
                column: "CityGUID",
                value: new Guid("a9727b22-e4fd-4e38-976e-42f4b7424449"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 990,
                column: "CityGUID",
                value: new Guid("afe6b030-1e6b-46d7-ae74-0a88ea5f2e11"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 991,
                column: "CityGUID",
                value: new Guid("9d94b965-9bb0-4e87-a029-0f1e9c40e9db"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 992,
                column: "CityGUID",
                value: new Guid("bbe46604-aec1-4299-a382-ed28d51ae03c"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 993,
                column: "CityGUID",
                value: new Guid("a6408225-7670-439a-b966-bc72cc6826ef"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 994,
                column: "CityGUID",
                value: new Guid("aa895164-48f6-4109-947b-4917e5eac72a"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 995,
                column: "CityGUID",
                value: new Guid("49daacd0-58ae-4d16-8254-2af4a91037a5"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 996,
                column: "CityGUID",
                value: new Guid("3617a51c-5c81-4fbb-8a59-40d64325dd81"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 997,
                column: "CityGUID",
                value: new Guid("37ab5e4c-6ad5-4581-ad6b-bf926cc099d9"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 998,
                column: "CityGUID",
                value: new Guid("cd10b590-562c-4802-b40b-7adba8177deb"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 999,
                column: "CityGUID",
                value: new Guid("280e31db-9ccb-4174-a572-1b110f0ad6e0"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1000,
                column: "CityGUID",
                value: new Guid("520ddae6-b877-40d8-b380-01dc1910663f"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1001,
                column: "CityGUID",
                value: new Guid("f7e6b39c-aa3b-4c52-bf60-a69c0a94ab02"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1002,
                column: "CityGUID",
                value: new Guid("48691d68-afe3-4f79-ad34-0f5aceaf665d"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1003,
                column: "CityGUID",
                value: new Guid("f86dc7a8-c00b-4fbe-95d2-1ca482c6796d"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1004,
                column: "CityGUID",
                value: new Guid("02e77072-3659-4ba8-ac91-5772dfe43c91"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1005,
                column: "CityGUID",
                value: new Guid("7b4f0f60-a72d-43e0-aaf6-d55673c90b12"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1006,
                column: "CityGUID",
                value: new Guid("20f00106-c283-4b8c-9e3e-0ec420888874"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1007,
                column: "CityGUID",
                value: new Guid("e98050a4-c411-4600-b497-b90935876d92"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1008,
                column: "CityGUID",
                value: new Guid("e94cac6e-ac40-435f-ba4c-30b839d94821"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1009,
                column: "CityGUID",
                value: new Guid("cb41b306-0ba6-4a28-9475-19cbe77f5093"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1010,
                column: "CityGUID",
                value: new Guid("6f0be4c1-bab5-4e76-b7ea-5066544173fc"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1011,
                column: "CityGUID",
                value: new Guid("62f8abde-98eb-49f6-a0de-bcb5c059aa02"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1012,
                column: "CityGUID",
                value: new Guid("1cea0f85-f223-42b4-afd6-9b45d7003db8"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1013,
                column: "CityGUID",
                value: new Guid("24f52748-ed96-4656-8e1e-15bb7f625ba6"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1014,
                column: "CityGUID",
                value: new Guid("95b378fe-9baa-4476-a2fb-0a95b27cf1c2"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1015,
                column: "CityGUID",
                value: new Guid("24d1b1aa-ac17-40e2-9618-bd3b0e965e63"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1016,
                column: "CityGUID",
                value: new Guid("873efbdb-4f6a-4850-b0a4-f61db1d4ff86"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1017,
                column: "CityGUID",
                value: new Guid("1c2c7acb-61a0-4e29-84c5-ac6b6e275725"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1018,
                column: "CityGUID",
                value: new Guid("564f1b4a-c3b8-4347-95d0-8a8d5471b888"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1019,
                column: "CityGUID",
                value: new Guid("24eaf38c-4e0a-40f7-a86e-8bf062b3f6b0"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1020,
                column: "CityGUID",
                value: new Guid("cfabcec7-d303-4b10-8588-c4640a0ac262"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1021,
                column: "CityGUID",
                value: new Guid("07d0abce-e5c8-469a-8f9a-9a63610391e9"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1022,
                column: "CityGUID",
                value: new Guid("d9c0243d-634a-44e6-b634-4641c717f087"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1023,
                column: "CityGUID",
                value: new Guid("3d5e163e-67ba-4eaf-b67a-25a0c4c319f2"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1024,
                column: "CityGUID",
                value: new Guid("722a02b0-0f00-4862-94c3-fd55f8979ba4"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1025,
                column: "CityGUID",
                value: new Guid("ea5ceaf0-f6c0-4d60-a9a7-e8330f8cbfd5"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1026,
                column: "CityGUID",
                value: new Guid("79218a48-c1fd-44ad-8305-86fe7ab33c90"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1027,
                column: "CityGUID",
                value: new Guid("32f25363-4e98-45df-9fa5-d054cd76d9a1"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1028,
                column: "CityGUID",
                value: new Guid("b4d38ff3-d3f4-449f-9b4c-6f3c801737ab"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1029,
                column: "CityGUID",
                value: new Guid("96db63f9-b11b-4ed1-a1f5-0fd5b7ed5dcf"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1030,
                column: "CityGUID",
                value: new Guid("0482f122-c9b5-4c9b-84b0-dad3af5f408c"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1031,
                column: "CityGUID",
                value: new Guid("692ba990-a5ab-40c2-8f0a-ff2339d37fc6"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1032,
                column: "CityGUID",
                value: new Guid("9caeae04-c67f-413d-a1f5-72a5aea5ec72"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1033,
                column: "CityGUID",
                value: new Guid("74f4ccd5-238c-4b9f-932c-58f661214789"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1034,
                column: "CityGUID",
                value: new Guid("e40d1c69-bba4-45b3-a9f6-049e499e3ee1"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1035,
                column: "CityGUID",
                value: new Guid("0790704d-b448-4844-b9ba-e22d4e83ff5c"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1036,
                column: "CityGUID",
                value: new Guid("1cb9ec00-73c0-4e54-8443-837d55abff3c"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1037,
                column: "CityGUID",
                value: new Guid("753849b5-9b36-4030-8303-0708cb724e67"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1038,
                column: "CityGUID",
                value: new Guid("9ffc752c-8ebc-4e72-8995-174fe2bc26e0"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1039,
                column: "CityGUID",
                value: new Guid("62b1ad1e-b4c0-40b5-a4c9-3915a255e659"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1040,
                column: "CityGUID",
                value: new Guid("137a1083-5c26-4a0b-9d82-40c2d8d9a845"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1041,
                column: "CityGUID",
                value: new Guid("422c078b-9e76-417f-8cb4-88dd9366b50a"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1042,
                column: "CityGUID",
                value: new Guid("ead116e9-4b9e-4789-b8fd-1bee8bfdc085"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1043,
                column: "CityGUID",
                value: new Guid("0628bcf2-62b0-4147-9fa6-45c62989cfa4"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1044,
                column: "CityGUID",
                value: new Guid("f5413184-40ec-4d5a-bf3f-900f3666df0a"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1045,
                column: "CityGUID",
                value: new Guid("75507a2a-8c67-4ce8-ba30-26955621a529"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1046,
                column: "CityGUID",
                value: new Guid("fa807447-8aef-4aa0-ae0e-70d28603d844"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1047,
                column: "CityGUID",
                value: new Guid("d1a28553-10b9-4a11-bcc0-18ee570c47c5"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1048,
                column: "CityGUID",
                value: new Guid("30ece53c-ec01-49b9-9949-e97b932f3cf1"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1049,
                column: "CityGUID",
                value: new Guid("16a9e6fc-3cbd-4c36-aeb5-6ee1c730e8ed"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1050,
                column: "CityGUID",
                value: new Guid("4edd6aa7-c5b8-40a9-a201-eb562e673203"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1051,
                column: "CityGUID",
                value: new Guid("e8598b5b-6d70-41ba-aa1f-d98702eb8564"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1052,
                column: "CityGUID",
                value: new Guid("a9a57981-4eca-4c09-b51c-6baf7ce5620e"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1053,
                column: "CityGUID",
                value: new Guid("e7e2301f-72a1-4da4-baa9-189c8cbe2929"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1054,
                column: "CityGUID",
                value: new Guid("af1f18f8-57f0-4306-bb17-107bfa5cdbc4"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1055,
                column: "CityGUID",
                value: new Guid("389aa247-1dcf-4934-a68f-f36f6bd373de"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1056,
                column: "CityGUID",
                value: new Guid("8cd6c957-3433-455b-97b8-3d84b92020db"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1057,
                column: "CityGUID",
                value: new Guid("3709680d-4bee-4dcd-9fcd-320c9238ae52"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1058,
                column: "CityGUID",
                value: new Guid("2c82bb8b-af31-448e-bd37-adcab5eeeb25"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1059,
                column: "CityGUID",
                value: new Guid("6c5dc171-5eee-4a34-9098-4e518b6509c5"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1060,
                column: "CityGUID",
                value: new Guid("06da7e6e-3d86-415f-950a-c93cef1639dc"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1061,
                column: "CityGUID",
                value: new Guid("3d7c843f-a777-44bd-8cc3-9e1ec8a652dc"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1062,
                column: "CityGUID",
                value: new Guid("c5b43d8d-28a2-4bf2-8959-2866fb7e922e"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1063,
                column: "CityGUID",
                value: new Guid("cd39e3dd-4c43-456a-b3ca-1e10449aca62"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1064,
                column: "CityGUID",
                value: new Guid("16e03f23-984d-469c-91c2-5fbddae0194a"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1065,
                column: "CityGUID",
                value: new Guid("c78517ae-d49a-40d7-b7ea-0c7a77c854c7"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1066,
                column: "CityGUID",
                value: new Guid("fcc8e5a6-191f-4d23-83c1-4c55033fa0bd"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1067,
                column: "CityGUID",
                value: new Guid("fdf1533e-d307-4795-aedd-7034d2aa0731"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1068,
                column: "CityGUID",
                value: new Guid("c364107c-e4c1-44ad-86e0-e91df924f15f"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1069,
                column: "CityGUID",
                value: new Guid("b61ad2db-abd2-4fa8-9f6f-0b274d39a123"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1070,
                column: "CityGUID",
                value: new Guid("b5d65501-cc21-4236-9572-858dfdcf1c39"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1071,
                column: "CityGUID",
                value: new Guid("9f89d8d3-e9b8-42f8-98e4-ad9c637654b6"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1072,
                column: "CityGUID",
                value: new Guid("d9bab1be-0bc9-492b-a78f-446bf95a2cb3"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1073,
                column: "CityGUID",
                value: new Guid("8a83bb07-4690-4634-8486-26105d746271"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1074,
                column: "CityGUID",
                value: new Guid("0a7b54d6-679f-4f34-9c48-85bd285d3114"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1075,
                column: "CityGUID",
                value: new Guid("d34663c8-fb73-4c1c-ae56-e70345c31278"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1076,
                column: "CityGUID",
                value: new Guid("167d4551-a377-4141-bef5-4a24c532cc21"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1077,
                column: "CityGUID",
                value: new Guid("985a7da3-76a0-48ed-83cb-e229920e4c22"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1078,
                column: "CityGUID",
                value: new Guid("d6b1a9d3-1609-49b8-b018-c7597a2c4af6"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1079,
                column: "CityGUID",
                value: new Guid("e73512a6-4b5f-4a47-8c03-99dfadd87aed"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1080,
                column: "CityGUID",
                value: new Guid("a4db6f2d-9d33-47d3-be72-75ed165a6e23"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1081,
                column: "CityGUID",
                value: new Guid("767b6df3-2a23-4d54-9aad-6ed72eabf5ce"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1082,
                column: "CityGUID",
                value: new Guid("c5ffaf29-6446-4569-ad2e-03dd2d911dbe"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1083,
                column: "CityGUID",
                value: new Guid("18382f33-7119-469c-a092-76ac7553f530"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1084,
                column: "CityGUID",
                value: new Guid("bdd91042-1dcc-4a4b-ad27-f067e3395b3d"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1085,
                column: "CityGUID",
                value: new Guid("b60d6f74-3b5d-4835-8c4d-a2098b9bcf5c"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1086,
                column: "CityGUID",
                value: new Guid("e1cc7116-9ae6-4380-9dba-f024197ad4bd"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1087,
                column: "CityGUID",
                value: new Guid("22950bc2-194b-48fb-bc88-38fa2c83ae5c"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1088,
                column: "CityGUID",
                value: new Guid("b68dae9c-242f-4443-b2bd-8dbb27912536"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1089,
                column: "CityGUID",
                value: new Guid("b59f1d56-ee9b-46bd-80b2-b7d8c549dd42"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1090,
                column: "CityGUID",
                value: new Guid("889623a3-0e3d-4f8b-94c5-23189c1fb368"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1091,
                column: "CityGUID",
                value: new Guid("97ac3f05-72e8-4522-bc4e-12f46b0cf0a1"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1092,
                column: "CityGUID",
                value: new Guid("87ca7dce-40d9-43d8-b792-2d5af95451d3"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1093,
                column: "CityGUID",
                value: new Guid("c846b42c-e4a2-472f-8085-3a71bd3d66bf"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1094,
                column: "CityGUID",
                value: new Guid("b27ea543-98f1-4043-baf4-5f48643c326f"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1095,
                column: "CityGUID",
                value: new Guid("fb03b260-d130-4c1e-bdb4-0e811f05d641"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1096,
                column: "CityGUID",
                value: new Guid("3673c038-f6c3-48ea-983e-e39fa0051985"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1097,
                column: "CityGUID",
                value: new Guid("20b4c767-6970-4e7c-a2bd-26b206ed56e2"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1098,
                column: "CityGUID",
                value: new Guid("1768b16c-dd2f-4dd5-99a4-8d2bb24cf441"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1099,
                column: "CityGUID",
                value: new Guid("98da5d6d-f75d-4448-a3c7-1b05ba39b8cd"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1100,
                column: "CityGUID",
                value: new Guid("20dcef5e-49a5-40d4-9b2a-144e7a0fdafe"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1101,
                column: "CityGUID",
                value: new Guid("13c7987e-5e91-48d9-9e07-2940bbca81ac"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1102,
                column: "CityGUID",
                value: new Guid("b18ce10e-342e-4bf5-a3bf-cbabd3780d7d"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1103,
                column: "CityGUID",
                value: new Guid("8dc4d422-7883-4333-be30-40c306e955a8"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1104,
                column: "CityGUID",
                value: new Guid("d1ceb155-4b9e-4152-8bd2-d14f0d760df2"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1105,
                column: "CityGUID",
                value: new Guid("1d1d8418-f012-4356-b6d7-49adf05648dc"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1106,
                column: "CityGUID",
                value: new Guid("86f9be81-e840-4c77-9c6a-42e9f99d451b"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1107,
                column: "CityGUID",
                value: new Guid("bba625dd-8e9b-4bcd-a28a-c94938555163"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1108,
                column: "CityGUID",
                value: new Guid("7413c52f-779e-49d7-866f-23f104abb030"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1109,
                column: "CityGUID",
                value: new Guid("62d1d411-d8c2-4323-a375-37355e8ba85f"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1110,
                column: "CityGUID",
                value: new Guid("8150e2e1-06f2-47a0-b0bb-c47bb32a5d1e"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1111,
                column: "CityGUID",
                value: new Guid("44c61bcf-4ba7-4907-975d-d127ba6bec75"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1112,
                column: "CityGUID",
                value: new Guid("652d4c17-40a4-4dcd-938e-929fe69cdb6e"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1113,
                column: "CityGUID",
                value: new Guid("ed8091e5-967f-4652-8686-7144cd5ba813"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1114,
                column: "CityGUID",
                value: new Guid("58f904cc-bed5-45e5-ad6b-9f6ac1f446a1"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1115,
                column: "CityGUID",
                value: new Guid("3bbf936e-a3e0-4fa1-896a-6d43bf606cf6"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1116,
                column: "CityGUID",
                value: new Guid("ec612739-b9f2-4df0-ba37-3d522c65640f"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1117,
                column: "CityGUID",
                value: new Guid("e768789a-7d40-46a5-a9f0-8d94275e33ea"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1118,
                column: "CityGUID",
                value: new Guid("ff284c05-096f-42d3-90d1-8f25920bd85b"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1119,
                column: "CityGUID",
                value: new Guid("b76b9d60-5f7b-4b36-96a7-582db2e90870"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1120,
                column: "CityGUID",
                value: new Guid("963621cc-099b-4c02-bc1b-7cc9325f5d7c"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1121,
                column: "CityGUID",
                value: new Guid("a31e2d2a-e04e-47c9-b35a-7902fd344c61"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1122,
                column: "CityGUID",
                value: new Guid("41fef75c-797f-44d4-92ed-d68e9d5b0db1"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1123,
                column: "CityGUID",
                value: new Guid("ff687b7f-74be-4834-849b-11477b592c23"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1124,
                column: "CityGUID",
                value: new Guid("a130d414-0e9e-41ad-88cc-3d4094d444fc"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1125,
                column: "CityGUID",
                value: new Guid("2bd2b7ae-f0d3-4e4f-a493-f52d224bc970"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1126,
                column: "CityGUID",
                value: new Guid("74e99688-b472-4375-88fe-49f0ca65726e"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1127,
                column: "CityGUID",
                value: new Guid("0dcc7729-4ce2-4bea-a52e-e3c085e3bf24"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1128,
                column: "CityGUID",
                value: new Guid("7ed7953e-2ab8-4774-a9a9-1db90148ed25"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1129,
                column: "CityGUID",
                value: new Guid("c386b670-89f0-440a-a045-c0cb4fcefc26"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1130,
                column: "CityGUID",
                value: new Guid("a4caec5c-f4cb-4ef4-be44-8dee3ea7fc3a"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1131,
                column: "CityGUID",
                value: new Guid("8de72db6-5ea5-4760-a720-d6b787b3dbfe"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1132,
                column: "CityGUID",
                value: new Guid("001068c2-2189-4912-8748-37088c0a6a5e"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1133,
                column: "CityGUID",
                value: new Guid("29126c3c-b808-405a-86c8-0ad81e979357"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1134,
                column: "CityGUID",
                value: new Guid("d7e1fee6-1214-4caa-aede-bc3e9d2c75eb"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1135,
                column: "CityGUID",
                value: new Guid("098511e8-7a4d-48e8-b1ac-751e497dfffe"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1136,
                column: "CityGUID",
                value: new Guid("79b4c1ae-2e5d-419c-8b4d-500ed89ef1b1"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1137,
                column: "CityGUID",
                value: new Guid("1d982569-2eda-4bde-8b32-95e4a7589f88"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1138,
                column: "CityGUID",
                value: new Guid("ee999b19-0b83-4ad6-a65d-51023cf9573a"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1139,
                column: "CityGUID",
                value: new Guid("0adc503b-7b84-4d6a-94ea-9edb4aee38a7"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1140,
                column: "CityGUID",
                value: new Guid("61c62a9f-a655-4f88-a8bd-9b9089f045ed"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1141,
                column: "CityGUID",
                value: new Guid("5b9ecc37-01ce-4a54-b52e-f8b2cf95c936"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1142,
                column: "CityGUID",
                value: new Guid("656afeef-38fe-43fc-a228-05acb8f338b7"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1143,
                column: "CityGUID",
                value: new Guid("973cfb71-ddbf-4a5d-9331-a49e95f15300"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1144,
                column: "CityGUID",
                value: new Guid("4fda0d08-87e5-4c95-b829-7e291f469c3e"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1145,
                column: "CityGUID",
                value: new Guid("a1924517-412a-4174-a80f-fc53e6febc86"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1146,
                column: "CityGUID",
                value: new Guid("4516a35a-8379-4c40-9865-aace473592ce"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1147,
                column: "CityGUID",
                value: new Guid("05f08883-60af-42eb-8583-a6f934cffa40"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1148,
                column: "CityGUID",
                value: new Guid("a4d748d9-ee2b-4594-8a1f-e2d2683caf1a"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1149,
                column: "CityGUID",
                value: new Guid("6ba9902b-eef6-4c8b-8f43-2e244061c7b9"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1150,
                column: "CityGUID",
                value: new Guid("697b35b1-4381-4849-bd1e-a6d8e8ec21d9"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1151,
                column: "CityGUID",
                value: new Guid("693e5f5a-acde-4e7e-aef6-e782ba5d077d"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1152,
                column: "CityGUID",
                value: new Guid("ba438a95-1ba2-404d-8106-84c394c611c8"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1153,
                column: "CityGUID",
                value: new Guid("a98e5994-f320-4ce3-8b7d-2284d23b8fe0"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1154,
                column: "CityGUID",
                value: new Guid("957353bc-6c5f-4b7b-bcb7-c881a63722a5"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1155,
                column: "CityGUID",
                value: new Guid("9451d5c6-8120-4f82-9370-bf2631d15744"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1156,
                column: "CityGUID",
                value: new Guid("fad11952-5f64-430d-a82c-22387d422140"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1157,
                column: "CityGUID",
                value: new Guid("2fff6f04-fce7-4189-b741-8ad9212d7ebc"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1158,
                column: "CityGUID",
                value: new Guid("294ea98a-9df3-44f2-b00c-bc440ca0c5cd"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1159,
                column: "CityGUID",
                value: new Guid("020fba34-9758-4223-9557-4b236e762b17"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1160,
                column: "CityGUID",
                value: new Guid("93ca88d7-f830-468c-be27-063c4b09323d"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1161,
                column: "CityGUID",
                value: new Guid("18bbbdcd-2142-4723-8e26-305d7aa91660"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1162,
                column: "CityGUID",
                value: new Guid("30919e4f-0bec-4165-ae30-457918812c03"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1163,
                column: "CityGUID",
                value: new Guid("8a7fcf6c-7702-4492-bb9c-24321842d4c3"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1164,
                column: "CityGUID",
                value: new Guid("41560ac8-1063-4409-9eab-9833b0af4223"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1165,
                column: "CityGUID",
                value: new Guid("a964a2da-178d-405e-a475-236bcdccd31e"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1166,
                column: "CityGUID",
                value: new Guid("dc43756a-2221-47fc-967f-f87ba42c78ef"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1167,
                column: "CityGUID",
                value: new Guid("ca9fbb86-40c7-4071-9b0e-bcafe6332d52"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1168,
                column: "CityGUID",
                value: new Guid("21597939-aa41-4dc3-aa1e-51e6fa391dc4"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1169,
                column: "CityGUID",
                value: new Guid("d22d027f-5630-4a5d-b22e-7a3446ec5b43"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1170,
                column: "CityGUID",
                value: new Guid("c1266949-5c1f-4195-b4a2-80a9d2b729c6"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1171,
                column: "CityGUID",
                value: new Guid("71a3ddf7-3d1f-4d5f-8a13-3a250aa0fc86"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1172,
                column: "CityGUID",
                value: new Guid("65d54cfa-24ac-40eb-8a0a-a6d532cdecb2"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1173,
                column: "CityGUID",
                value: new Guid("f76171de-1111-4d47-8298-a1fdca0036b6"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1174,
                column: "CityGUID",
                value: new Guid("c52a90a1-88d8-497b-9936-bcd940851d09"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1175,
                column: "CityGUID",
                value: new Guid("47ddacbf-291b-4c87-9469-b3a606a5dd73"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1176,
                column: "CityGUID",
                value: new Guid("1ce31128-bf31-46a5-8dbe-3a678e716e9d"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1177,
                column: "CityGUID",
                value: new Guid("7750538c-7615-42ab-8211-b3971c90e55f"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1178,
                column: "CityGUID",
                value: new Guid("bb8dd19d-25a5-4fb5-a7a3-5b2bac3d01db"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1179,
                column: "CityGUID",
                value: new Guid("34780c4b-0441-4220-9e82-f185fd9c24ae"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1180,
                column: "CityGUID",
                value: new Guid("29162574-dd5d-4cd0-a356-aad849bcf969"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1181,
                column: "CityGUID",
                value: new Guid("2ba59195-8e1f-43c5-853d-d6e64ac2c885"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1182,
                column: "CityGUID",
                value: new Guid("af464e83-9b3d-4825-9771-02ae4c70f04e"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1183,
                column: "CityGUID",
                value: new Guid("cb00be63-bfb8-478f-9787-6a5f3b31f044"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1184,
                column: "CityGUID",
                value: new Guid("bd79bf48-4786-4764-ba8b-ed31417ac80c"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1185,
                column: "CityGUID",
                value: new Guid("9bde141e-5b77-4ed2-92f7-61548784a0f9"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1186,
                column: "CityGUID",
                value: new Guid("62e29517-04ba-405d-a907-63cbaf2c3687"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1187,
                column: "CityGUID",
                value: new Guid("b2cebdf4-bc6c-4c83-8592-288c52c0ef57"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1188,
                column: "CityGUID",
                value: new Guid("27b5ca94-3225-4d69-b069-e9be11dafc45"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1189,
                column: "CityGUID",
                value: new Guid("a144d07f-bdc4-4fef-8b59-7795bd0d1bf9"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1190,
                column: "CityGUID",
                value: new Guid("703447c2-656f-40ba-b48a-12135db718b7"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1191,
                column: "CityGUID",
                value: new Guid("adfcaf3d-995f-4fdc-b7ac-e01e543c4c25"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1192,
                column: "CityGUID",
                value: new Guid("bd257b7c-e224-4fd2-a2dc-3ac3703fb47a"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1193,
                column: "CityGUID",
                value: new Guid("2f5e7a3a-0868-4325-a8af-a691b538c9ae"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1194,
                column: "CityGUID",
                value: new Guid("11a1a41b-2fc5-4a34-be8e-588d27eb3669"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1195,
                column: "CityGUID",
                value: new Guid("107ad0f2-54da-4fc9-86c2-ec201a4fd020"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1196,
                column: "CityGUID",
                value: new Guid("20683e2f-ad39-42cf-b87a-9325ba66fcbd"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1197,
                column: "CityGUID",
                value: new Guid("ff2a4bc5-f924-40de-b417-272fcf0b4f53"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1198,
                column: "CityGUID",
                value: new Guid("f8f7c050-df7c-4747-bb77-d4ee3c2b57da"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1199,
                column: "CityGUID",
                value: new Guid("59880ceb-d923-474e-96f6-b8330b439c5b"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1200,
                column: "CityGUID",
                value: new Guid("1eb61744-1f6b-4a85-ad79-921be127340b"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1201,
                column: "CityGUID",
                value: new Guid("c9375f52-9a76-47c5-bf39-141d1d741dd5"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1202,
                column: "CityGUID",
                value: new Guid("987f2ee0-37f4-40ae-b2ab-d91f9d664b9d"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1203,
                column: "CityGUID",
                value: new Guid("eccb8d7c-a171-46a2-92fd-eb3b7bc96d94"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1204,
                column: "CityGUID",
                value: new Guid("c11a2281-bd30-4518-b778-37aebd2c0a1b"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1205,
                column: "CityGUID",
                value: new Guid("624d1b9e-2d04-459f-8bdd-2cf559372c58"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1206,
                column: "CityGUID",
                value: new Guid("4621cb81-e2dd-4ba6-a36c-b9548e4e952a"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1207,
                column: "CityGUID",
                value: new Guid("908e1a25-08c4-409b-845d-2584b4f41580"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1208,
                column: "CityGUID",
                value: new Guid("736c6796-2475-4a60-a6a0-d96b5b7b8a46"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1209,
                column: "CityGUID",
                value: new Guid("8a0ac465-65c0-48a5-8488-040a7881cb70"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1210,
                column: "CityGUID",
                value: new Guid("f31b5b52-0654-413b-884b-19f070faa4bc"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1211,
                column: "CityGUID",
                value: new Guid("a30230d3-45d4-462e-97c5-a6ff7a49ddb3"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1212,
                column: "CityGUID",
                value: new Guid("6c33e356-776e-46cc-bb87-478e3be5589e"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1213,
                column: "CityGUID",
                value: new Guid("e4ae1ee4-acb8-4ab1-8a94-80a382a24e43"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1214,
                column: "CityGUID",
                value: new Guid("ce516159-4ccc-41a0-93ce-8983a785b8ed"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1215,
                column: "CityGUID",
                value: new Guid("a7e935d7-5eb6-4dc9-8b9b-939f905be9a1"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1216,
                column: "CityGUID",
                value: new Guid("c4bb0878-f18f-4a19-9e9c-be9570398848"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1217,
                column: "CityGUID",
                value: new Guid("280f4050-d9ea-4aef-b7fc-cace230540cd"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1218,
                column: "CityGUID",
                value: new Guid("94ab5987-d993-486a-a682-163741817392"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1219,
                column: "CityGUID",
                value: new Guid("e7d48bb0-abbe-4991-9498-fab0206afbfa"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1220,
                column: "CityGUID",
                value: new Guid("a1ae2909-57c1-4a65-abc2-7a4bf8348777"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1221,
                column: "CityGUID",
                value: new Guid("c24dfe95-78c0-4a28-ac4e-1b24626ee8c9"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1222,
                column: "CityGUID",
                value: new Guid("4dcd1c15-9c08-4fe9-9df8-2926fd443802"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1223,
                column: "CityGUID",
                value: new Guid("c5fedc31-e450-4b2c-abf8-0bfef3cf8d64"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1224,
                column: "CityGUID",
                value: new Guid("e6992f01-ca2d-4f02-a176-38034567f306"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1225,
                column: "CityGUID",
                value: new Guid("272fc266-14cc-4aed-847c-e53e91a4695c"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1226,
                column: "CityGUID",
                value: new Guid("0a0fee5c-0118-4553-afb2-346984bf19dc"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1227,
                column: "CityGUID",
                value: new Guid("a4a57936-32dd-405f-a2c0-33a284f123d6"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1228,
                column: "CityGUID",
                value: new Guid("ba304977-7070-4955-be7a-63157fbc5778"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1229,
                column: "CityGUID",
                value: new Guid("603b35d5-3a78-4eba-8e2c-59e469f967e6"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1230,
                column: "CityGUID",
                value: new Guid("fb893093-3425-4754-a7ec-4999f20e7a05"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1231,
                column: "CityGUID",
                value: new Guid("05446761-4050-42da-833a-222c361f8453"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1232,
                column: "CityGUID",
                value: new Guid("9c49c68f-25aa-40ee-8bf9-0355f771bb1a"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1233,
                column: "CityGUID",
                value: new Guid("97931990-138d-4f29-95b0-6a4f96891a70"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1234,
                column: "CityGUID",
                value: new Guid("32ea4e42-ec7c-403a-a82c-c20ea2c9d22f"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1235,
                column: "CityGUID",
                value: new Guid("dae23aa6-3a86-4a6b-a5bf-f2cc177c8f29"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1236,
                column: "CityGUID",
                value: new Guid("96e46032-c094-4344-bd94-8ec4d4b18e3c"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1237,
                column: "CityGUID",
                value: new Guid("1a2c8530-6924-417d-abc3-b1af37f744e2"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1238,
                column: "CityGUID",
                value: new Guid("6975c761-fd5d-4dcc-b8ab-b61114c7bbb2"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1239,
                column: "CityGUID",
                value: new Guid("f8dac7e7-d9c9-4ca9-8f0f-75be10c8d861"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1240,
                column: "CityGUID",
                value: new Guid("ac755b65-9fb8-4875-9d1e-e5be00e25f98"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1241,
                column: "CityGUID",
                value: new Guid("fe49d736-3745-4020-896c-1afd2b6582db"));

            migrationBuilder.UpdateData(
                table: "Client",
                keyColumn: "ClientID",
                keyValue: 1,
                columns: new[] { "ClientGUID", "ModifiedDate" },
                values: new object[] { new Guid("feba42b3-34ff-4c22-90ae-6f2fbc2a0401"), new DateTime(2020, 6, 8, 18, 21, 58, 275, DateTimeKind.Local).AddTicks(7551) });

            migrationBuilder.UpdateData(
                table: "Code",
                keyColumn: "CodeID",
                keyValue: 1,
                column: "CodeGUID",
                value: new Guid("fc20e91f-1eb1-4912-87be-1708f2706367"));

            migrationBuilder.UpdateData(
                table: "Code",
                keyColumn: "CodeID",
                keyValue: 2,
                column: "CodeGUID",
                value: new Guid("3f009296-db7a-4fde-a659-4ca1541a2504"));

            migrationBuilder.UpdateData(
                table: "Code",
                keyColumn: "CodeID",
                keyValue: 3,
                column: "CodeGUID",
                value: new Guid("3209341a-07d4-437b-9301-2d0f909ad713"));

            migrationBuilder.UpdateData(
                table: "Code",
                keyColumn: "CodeID",
                keyValue: 4,
                column: "CodeGUID",
                value: new Guid("09cb21ac-d99e-42ba-904d-337bdd561e6e"));

            migrationBuilder.UpdateData(
                table: "Code",
                keyColumn: "CodeID",
                keyValue: 5,
                column: "CodeGUID",
                value: new Guid("2383b70e-f41f-4b67-b0c9-c48706a70a46"));

            migrationBuilder.UpdateData(
                table: "Code",
                keyColumn: "CodeID",
                keyValue: 6,
                column: "CodeGUID",
                value: new Guid("cf5a1929-db68-43d6-8fc7-e3b7ccc51678"));

            migrationBuilder.UpdateData(
                table: "Code",
                keyColumn: "CodeID",
                keyValue: 7,
                column: "CodeGUID",
                value: new Guid("2b451e4c-c9b8-415a-bcb4-05da15447b89"));

            migrationBuilder.UpdateData(
                table: "Code",
                keyColumn: "CodeID",
                keyValue: 8,
                column: "CodeGUID",
                value: new Guid("6e48b657-2c83-4481-a9c5-009ffe10158b"));

            migrationBuilder.UpdateData(
                table: "Code",
                keyColumn: "CodeID",
                keyValue: 9,
                column: "CodeGUID",
                value: new Guid("b5d74bda-849b-427c-a6e0-463c1e5f615b"));

            migrationBuilder.UpdateData(
                table: "Code",
                keyColumn: "CodeID",
                keyValue: 10,
                column: "CodeGUID",
                value: new Guid("10afdac9-a075-40e1-9207-1813befcf4d6"));

            migrationBuilder.UpdateData(
                table: "Code",
                keyColumn: "CodeID",
                keyValue: 11,
                column: "CodeGUID",
                value: new Guid("2b9d07c8-5535-495e-8557-da32acb58600"));

            migrationBuilder.UpdateData(
                table: "Code",
                keyColumn: "CodeID",
                keyValue: 12,
                column: "CodeGUID",
                value: new Guid("61960336-e912-4658-9ab3-59f4c58e0b23"));

            migrationBuilder.UpdateData(
                table: "Code",
                keyColumn: "CodeID",
                keyValue: 13,
                column: "CodeGUID",
                value: new Guid("46a09d81-c57f-4655-a8f5-027c66a6cfb1"));

            migrationBuilder.UpdateData(
                table: "Code",
                keyColumn: "CodeID",
                keyValue: 14,
                column: "CodeGUID",
                value: new Guid("91b3cdab-39c1-40fb-b077-a2d6e611f50a"));

            migrationBuilder.UpdateData(
                table: "Code",
                keyColumn: "CodeID",
                keyValue: 15,
                column: "CodeGUID",
                value: new Guid("959b10a3-b8ed-4a9d-bdf3-17ec9b2ceb15"));

            migrationBuilder.UpdateData(
                table: "Code",
                keyColumn: "CodeID",
                keyValue: 16,
                column: "CodeGUID",
                value: new Guid("a05c4f54-5999-42b9-a36f-6a04aa7cd476"));

            migrationBuilder.UpdateData(
                table: "Code",
                keyColumn: "CodeID",
                keyValue: 17,
                column: "CodeGUID",
                value: new Guid("ccef9d1f-343b-442a-a041-1908e4cbc235"));

            migrationBuilder.UpdateData(
                table: "CodeGroup",
                keyColumn: "CodeGroupID",
                keyValue: 1,
                column: "CodeGroupGUID",
                value: new Guid("5b739a57-164e-4b39-8b1c-1129bc9d8991"));

            migrationBuilder.UpdateData(
                table: "CodeGroup",
                keyColumn: "CodeGroupID",
                keyValue: 2,
                column: "CodeGroupGUID",
                value: new Guid("2d9c9e83-39eb-42d7-b71f-ef26002c8470"));

            migrationBuilder.UpdateData(
                table: "CodeGroup",
                keyColumn: "CodeGroupID",
                keyValue: 3,
                column: "CodeGroupGUID",
                value: new Guid("a76da3ba-d12a-42c4-b7e1-732d0990af70"));

            migrationBuilder.UpdateData(
                table: "CodeGroup",
                keyColumn: "CodeGroupID",
                keyValue: 4,
                column: "CodeGroupGUID",
                value: new Guid("39c56245-8e42-4cef-8ddd-5e4c17782e8b"));

            migrationBuilder.UpdateData(
                table: "CodeGroup",
                keyColumn: "CodeGroupID",
                keyValue: 5,
                column: "CodeGroupGUID",
                value: new Guid("7e9db57a-0c09-47ff-98b5-f49363beff67"));

            migrationBuilder.UpdateData(
                table: "CodeGroup",
                keyColumn: "CodeGroupID",
                keyValue: 6,
                column: "CodeGroupGUID",
                value: new Guid("107a7244-6e66-4369-8ba6-dfb0636642c4"));

            migrationBuilder.UpdateData(
                table: "Contractor",
                keyColumn: "ContractorID",
                keyValue: 1,
                columns: new[] { "ContractorGUID", "ModifiedDate" },
                values: new object[] { new Guid("e31dd5ca-de05-4f3f-b6d1-8d744ca838aa"), new DateTime(2020, 6, 8, 18, 21, 58, 276, DateTimeKind.Local).AddTicks(7729) });

            migrationBuilder.UpdateData(
                table: "Contractor",
                keyColumn: "ContractorID",
                keyValue: 2,
                columns: new[] { "ContractorGUID", "ModifiedDate" },
                values: new object[] { new Guid("d2f788ec-fe5f-4b29-952b-d43c45d1ebef"), new DateTime(2020, 6, 8, 18, 21, 58, 276, DateTimeKind.Local).AddTicks(8382) });

            migrationBuilder.UpdateData(
                table: "ContractorCategory",
                keyColumn: "ContractorCategoryID",
                keyValue: 1,
                column: "ContractorCategoryGUID",
                value: new Guid("cc91af77-01dc-4c71-8adc-a7136da44d3a"));

            migrationBuilder.UpdateData(
                table: "ContractorCategory",
                keyColumn: "ContractorCategoryID",
                keyValue: 2,
                column: "ContractorCategoryGUID",
                value: new Guid("eca665e1-f7e3-4971-81a2-1975d5b594d1"));

            migrationBuilder.UpdateData(
                table: "ContractorCategory",
                keyColumn: "ContractorCategoryID",
                keyValue: 3,
                column: "ContractorCategoryGUID",
                value: new Guid("e94b2c0c-2251-4529-876a-dc1857a28d0e"));

            migrationBuilder.UpdateData(
                table: "ContractorCategory",
                keyColumn: "ContractorCategoryID",
                keyValue: 4,
                column: "ContractorCategoryGUID",
                value: new Guid("5b3fc82d-0e0a-45ad-9165-9f7f264bf077"));

            migrationBuilder.UpdateData(
                table: "ContractorCategory",
                keyColumn: "ContractorCategoryID",
                keyValue: 5,
                column: "ContractorCategoryGUID",
                value: new Guid("999c03c7-2ddb-4c58-8a02-104906552340"));

            migrationBuilder.UpdateData(
                table: "ContractorCategory",
                keyColumn: "ContractorCategoryID",
                keyValue: 6,
                column: "ContractorCategoryGUID",
                value: new Guid("c8a43632-0822-4d4a-acf9-cf71541193c9"));

            migrationBuilder.UpdateData(
                table: "ContractorCategory",
                keyColumn: "ContractorCategoryID",
                keyValue: 7,
                column: "ContractorCategoryGUID",
                value: new Guid("a1d899c6-30c7-49de-b819-e93453199918"));

            migrationBuilder.UpdateData(
                table: "ContractorCategory",
                keyColumn: "ContractorCategoryID",
                keyValue: 8,
                column: "ContractorCategoryGUID",
                value: new Guid("334be994-c6c6-40e2-bb5f-221118a1df13"));

            migrationBuilder.UpdateData(
                table: "ContractorCategory",
                keyColumn: "ContractorCategoryID",
                keyValue: 9,
                column: "ContractorCategoryGUID",
                value: new Guid("3f2592be-f427-4ea2-b4ad-b09f1795e4a1"));

            migrationBuilder.UpdateData(
                table: "ContractorCategory",
                keyColumn: "ContractorCategoryID",
                keyValue: 10,
                column: "ContractorCategoryGUID",
                value: new Guid("7e5758ae-4073-4626-9203-4edba1499889"));

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderID",
                keyValue: 1,
                columns: new[] { "ModifiedDate", "OrderGUID" },
                values: new object[] { new DateTime(2020, 6, 8, 18, 21, 58, 277, DateTimeKind.Local).AddTicks(8035), new Guid("ffa2dbcc-a39a-431b-a88f-15f0ced5f909") });

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderID",
                keyValue: 2,
                columns: new[] { "ModifiedDate", "OrderGUID" },
                values: new object[] { new DateTime(2020, 6, 8, 18, 21, 58, 277, DateTimeKind.Local).AddTicks(8658), new Guid("d7aa0dd5-cb25-480b-86e3-1c64877c2d5e") });

            migrationBuilder.UpdateData(
                table: "OrderRequest",
                keyColumn: "OrderRequestID",
                keyValue: 1,
                columns: new[] { "IsAllow", "ModifiedDate", "OrderRequestGUID" },
                values: new object[] { true, new DateTime(2020, 6, 8, 18, 21, 58, 278, DateTimeKind.Local).AddTicks(5176), new Guid("db08b504-6b51-4711-be8d-38d0457e7f60") });

            migrationBuilder.UpdateData(
                table: "Province",
                keyColumn: "ProvinceID",
                keyValue: 1,
                column: "ProvinceGUID",
                value: new Guid("ebdc8408-3872-4725-935f-05f44bf8afe5"));

            migrationBuilder.UpdateData(
                table: "Province",
                keyColumn: "ProvinceID",
                keyValue: 2,
                column: "ProvinceGUID",
                value: new Guid("fd885d3d-96dc-41e8-b36e-059b50959981"));

            migrationBuilder.UpdateData(
                table: "Province",
                keyColumn: "ProvinceID",
                keyValue: 3,
                column: "ProvinceGUID",
                value: new Guid("eac67130-9c8f-4e03-8935-89d70f828e09"));

            migrationBuilder.UpdateData(
                table: "Province",
                keyColumn: "ProvinceID",
                keyValue: 4,
                column: "ProvinceGUID",
                value: new Guid("732ae16c-643a-4eaa-a753-4f70cfcef3cb"));

            migrationBuilder.UpdateData(
                table: "Province",
                keyColumn: "ProvinceID",
                keyValue: 5,
                column: "ProvinceGUID",
                value: new Guid("82d696f7-b280-4299-9b02-82c54e15cb2a"));

            migrationBuilder.UpdateData(
                table: "Province",
                keyColumn: "ProvinceID",
                keyValue: 6,
                column: "ProvinceGUID",
                value: new Guid("a39dc437-0fdc-4219-94d4-dc6e34b39653"));

            migrationBuilder.UpdateData(
                table: "Province",
                keyColumn: "ProvinceID",
                keyValue: 7,
                column: "ProvinceGUID",
                value: new Guid("78040a85-7209-4f4b-b3e8-9e7769808c6a"));

            migrationBuilder.UpdateData(
                table: "Province",
                keyColumn: "ProvinceID",
                keyValue: 8,
                column: "ProvinceGUID",
                value: new Guid("89fdcf0f-1ed1-4f19-b926-b5f17b27e8f3"));

            migrationBuilder.UpdateData(
                table: "Province",
                keyColumn: "ProvinceID",
                keyValue: 9,
                column: "ProvinceGUID",
                value: new Guid("13044aa4-da2d-4ffc-8374-ad073d94d472"));

            migrationBuilder.UpdateData(
                table: "Province",
                keyColumn: "ProvinceID",
                keyValue: 10,
                column: "ProvinceGUID",
                value: new Guid("23105c4a-b32b-4555-aace-7ea44e9b3b18"));

            migrationBuilder.UpdateData(
                table: "Province",
                keyColumn: "ProvinceID",
                keyValue: 11,
                column: "ProvinceGUID",
                value: new Guid("af1509c8-e3ee-406a-af5c-98d786d21f4a"));

            migrationBuilder.UpdateData(
                table: "Province",
                keyColumn: "ProvinceID",
                keyValue: 12,
                column: "ProvinceGUID",
                value: new Guid("c6ea1567-c6d9-4a45-a605-bfa05e977303"));

            migrationBuilder.UpdateData(
                table: "Province",
                keyColumn: "ProvinceID",
                keyValue: 13,
                column: "ProvinceGUID",
                value: new Guid("2bc3ca64-44ae-4975-b156-85a8c6cc3f49"));

            migrationBuilder.UpdateData(
                table: "Province",
                keyColumn: "ProvinceID",
                keyValue: 14,
                column: "ProvinceGUID",
                value: new Guid("3f09c927-df64-42c1-ae52-10dafb548d13"));

            migrationBuilder.UpdateData(
                table: "Province",
                keyColumn: "ProvinceID",
                keyValue: 15,
                column: "ProvinceGUID",
                value: new Guid("32051c61-8783-45e7-bb29-a4aaecd7cdff"));

            migrationBuilder.UpdateData(
                table: "Province",
                keyColumn: "ProvinceID",
                keyValue: 16,
                column: "ProvinceGUID",
                value: new Guid("274a73e6-1fed-4284-bf67-f87795b21300"));

            migrationBuilder.UpdateData(
                table: "Province",
                keyColumn: "ProvinceID",
                keyValue: 17,
                column: "ProvinceGUID",
                value: new Guid("c1c33286-dbe9-47a7-a472-635d3543db58"));

            migrationBuilder.UpdateData(
                table: "Province",
                keyColumn: "ProvinceID",
                keyValue: 18,
                column: "ProvinceGUID",
                value: new Guid("df9d5aa2-e411-4216-8a7e-bd79c4ae4782"));

            migrationBuilder.UpdateData(
                table: "Province",
                keyColumn: "ProvinceID",
                keyValue: 19,
                column: "ProvinceGUID",
                value: new Guid("c82fbc20-e0f0-477d-a22e-37923a1353ba"));

            migrationBuilder.UpdateData(
                table: "Province",
                keyColumn: "ProvinceID",
                keyValue: 20,
                column: "ProvinceGUID",
                value: new Guid("7a41e4c6-7eb5-407f-a84c-7af3798efe95"));

            migrationBuilder.UpdateData(
                table: "Province",
                keyColumn: "ProvinceID",
                keyValue: 21,
                column: "ProvinceGUID",
                value: new Guid("fe29476c-5458-4d6b-bfb2-94418ad4ca2a"));

            migrationBuilder.UpdateData(
                table: "Province",
                keyColumn: "ProvinceID",
                keyValue: 22,
                column: "ProvinceGUID",
                value: new Guid("45ee115c-377b-4030-83f5-a97f030f4a34"));

            migrationBuilder.UpdateData(
                table: "Province",
                keyColumn: "ProvinceID",
                keyValue: 23,
                column: "ProvinceGUID",
                value: new Guid("7299c0d4-d0ce-4b0a-a459-e6f76fb76134"));

            migrationBuilder.UpdateData(
                table: "Province",
                keyColumn: "ProvinceID",
                keyValue: 24,
                column: "ProvinceGUID",
                value: new Guid("67738ada-dd01-4d8b-98c6-9877d7a9491f"));

            migrationBuilder.UpdateData(
                table: "Province",
                keyColumn: "ProvinceID",
                keyValue: 25,
                column: "ProvinceGUID",
                value: new Guid("9cfae304-42fa-4850-b47d-c4a668824fab"));

            migrationBuilder.UpdateData(
                table: "Province",
                keyColumn: "ProvinceID",
                keyValue: 26,
                column: "ProvinceGUID",
                value: new Guid("d0121f2c-1a80-45da-bc99-fb3510f62fc3"));

            migrationBuilder.UpdateData(
                table: "Province",
                keyColumn: "ProvinceID",
                keyValue: 27,
                column: "ProvinceGUID",
                value: new Guid("359c9c84-2e4d-4864-a2cf-622db9318d4b"));

            migrationBuilder.UpdateData(
                table: "Province",
                keyColumn: "ProvinceID",
                keyValue: 28,
                column: "ProvinceGUID",
                value: new Guid("46f259c8-8a32-4808-bb28-fba283b286d4"));

            migrationBuilder.UpdateData(
                table: "Province",
                keyColumn: "ProvinceID",
                keyValue: 29,
                column: "ProvinceGUID",
                value: new Guid("aceebea9-ee67-42b4-aa61-cc6e86c7f361"));

            migrationBuilder.UpdateData(
                table: "Province",
                keyColumn: "ProvinceID",
                keyValue: 30,
                column: "ProvinceGUID",
                value: new Guid("75e41d51-18ff-42c2-8c65-3d05e1bc8449"));

            migrationBuilder.UpdateData(
                table: "Province",
                keyColumn: "ProvinceID",
                keyValue: 31,
                column: "ProvinceGUID",
                value: new Guid("84807ea5-37a3-44e3-868d-4781600bac1b"));

            migrationBuilder.UpdateData(
                table: "Role",
                keyColumn: "RoleID",
                keyValue: 1,
                columns: new[] { "ModifiedDate", "RoleGUID" },
                values: new object[] { new DateTime(2020, 6, 8, 18, 21, 58, 272, DateTimeKind.Local).AddTicks(1581), new Guid("e24ab2a2-a4ed-494f-a49e-1f4c86ccaa98") });

            migrationBuilder.UpdateData(
                table: "Role",
                keyColumn: "RoleID",
                keyValue: 2,
                columns: new[] { "ModifiedDate", "RoleGUID" },
                values: new object[] { new DateTime(2020, 6, 8, 18, 21, 58, 272, DateTimeKind.Local).AddTicks(2654), new Guid("ccb207ae-9417-485f-b2c3-50dc37f55eb5") });

            migrationBuilder.UpdateData(
                table: "Role",
                keyColumn: "RoleID",
                keyValue: 3,
                columns: new[] { "ModifiedDate", "RoleGUID" },
                values: new object[] { new DateTime(2020, 6, 8, 18, 21, 58, 272, DateTimeKind.Local).AddTicks(2691), new Guid("40a59cca-dc3b-4bf3-9151-247e908debdd") });

            migrationBuilder.UpdateData(
                table: "SMSProviderConfiguration",
                keyColumn: "SMSProviderConfigurationID",
                keyValue: 1,
                columns: new[] { "ModifiedDate", "SMSProviderConfigurationGUID" },
                values: new object[] { new DateTime(2020, 6, 8, 18, 21, 58, 267, DateTimeKind.Local).AddTicks(2008), new Guid("48b73fb6-aa47-40ed-9164-b174dd97c341") });

            migrationBuilder.UpdateData(
                table: "SMSSetting",
                keyColumn: "SMSSettingID",
                keyValue: 1,
                columns: new[] { "ModifiedDate", "SMSSettingGUID" },
                values: new object[] { new DateTime(2020, 6, 8, 18, 21, 58, 271, DateTimeKind.Local).AddTicks(346), new Guid("e1fac661-5f6a-4853-b28a-92fc3e7d4cfd") });

            migrationBuilder.UpdateData(
                table: "SMSTemplate",
                keyColumn: "SMSTemplateID",
                keyValue: 1,
                columns: new[] { "ModifiedDate", "SMSTemplateGUID" },
                values: new object[] { new DateTime(2020, 6, 8, 18, 21, 58, 271, DateTimeKind.Local).AddTicks(6036), new Guid("a6e54779-9de5-4726-91ba-9773cc9c1c18") });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserID",
                keyValue: 1,
                columns: new[] { "IsActive", "IsRegister", "ModifiedDate", "RegisteredDate", "UserGUID" },
                values: new object[] { true, true, new DateTime(2020, 6, 8, 18, 21, 58, 274, DateTimeKind.Local).AddTicks(8025), new DateTime(2020, 6, 8, 18, 21, 58, 274, DateTimeKind.Local).AddTicks(7505), new Guid("3e655abd-4640-454d-b440-de9f537c956d") });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserID",
                keyValue: 2,
                columns: new[] { "IsActive", "IsRegister", "ModifiedDate", "RegisteredDate", "UserGUID" },
                values: new object[] { true, true, new DateTime(2020, 6, 8, 18, 21, 58, 275, DateTimeKind.Local).AddTicks(126), new DateTime(2020, 6, 8, 18, 21, 58, 275, DateTimeKind.Local).AddTicks(103), new Guid("7c3b3e90-7c94-4860-b351-82be18e913f5") });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserID",
                keyValue: 3,
                columns: new[] { "IsActive", "IsRegister", "ModifiedDate", "RegisteredDate", "UserGUID" },
                values: new object[] { true, true, new DateTime(2020, 6, 8, 18, 21, 58, 275, DateTimeKind.Local).AddTicks(170), new DateTime(2020, 6, 8, 18, 21, 58, 275, DateTimeKind.Local).AddTicks(166), new Guid("a68e0e0c-a829-4c39-8186-1dd5cc78f757") });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserID",
                keyValue: 4,
                columns: new[] { "IsActive", "IsRegister", "ModifiedDate", "RegisteredDate", "UserGUID" },
                values: new object[] { true, true, new DateTime(2020, 6, 8, 18, 21, 58, 275, DateTimeKind.Local).AddTicks(183), new DateTime(2020, 6, 8, 18, 21, 58, 275, DateTimeKind.Local).AddTicks(179), new Guid("06c19a56-ded0-4de3-a152-3e9608adf4a8") });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsInSlider",
                table: "Post");

            migrationBuilder.DropColumn(
                name: "IsSuggested",
                table: "Post");

            migrationBuilder.UpdateData(
                table: "Admin",
                keyColumn: "AdminID",
                keyValue: 1,
                columns: new[] { "AdminGUID", "ModifiedDate" },
                values: new object[] { new Guid("865f87b9-660d-4ad8-a25c-0566e983ba8a"), new DateTime(2020, 5, 31, 15, 29, 22, 154, DateTimeKind.Local).AddTicks(8679) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "CategoryID",
                keyValue: 1,
                columns: new[] { "CategoryGUID", "IsActive", "ModifiedDate" },
                values: new object[] { new Guid("c265fd02-0194-4d38-83e8-a93bc3698fcc"), true, new DateTime(2020, 5, 31, 15, 29, 22, 159, DateTimeKind.Local).AddTicks(6148) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "CategoryID",
                keyValue: 2,
                columns: new[] { "CategoryGUID", "IsActive", "ModifiedDate" },
                values: new object[] { new Guid("dec37f17-0ab2-4208-8ba7-11cc1120369b"), true, new DateTime(2020, 5, 31, 15, 29, 22, 159, DateTimeKind.Local).AddTicks(7996) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "CategoryID",
                keyValue: 3,
                columns: new[] { "CategoryGUID", "IsActive", "ModifiedDate" },
                values: new object[] { new Guid("f32c3568-d38a-42d2-9fbe-6d9bf40ec535"), true, new DateTime(2020, 5, 31, 15, 29, 22, 159, DateTimeKind.Local).AddTicks(8044) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "CategoryID",
                keyValue: 4,
                columns: new[] { "CategoryGUID", "IsActive", "ModifiedDate" },
                values: new object[] { new Guid("ee21fd18-130c-4051-9ac6-afa2b21027b3"), true, new DateTime(2020, 5, 31, 15, 29, 22, 159, DateTimeKind.Local).AddTicks(8103) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "CategoryID",
                keyValue: 5,
                columns: new[] { "CategoryGUID", "IsActive", "ModifiedDate" },
                values: new object[] { new Guid("ec280897-5121-41fb-9998-03a0d099b537"), true, new DateTime(2020, 5, 31, 15, 29, 22, 159, DateTimeKind.Local).AddTicks(8111) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "CategoryID",
                keyValue: 6,
                columns: new[] { "CategoryGUID", "IsActive", "ModifiedDate" },
                values: new object[] { new Guid("b0007142-5302-487d-acf5-07ed92bf086f"), true, new DateTime(2020, 5, 31, 15, 29, 22, 159, DateTimeKind.Local).AddTicks(8121) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "CategoryID",
                keyValue: 7,
                columns: new[] { "CategoryGUID", "IsActive", "ModifiedDate" },
                values: new object[] { new Guid("bb9cf753-2340-4156-a16a-b4da29bb6e8c"), true, new DateTime(2020, 5, 31, 15, 29, 22, 159, DateTimeKind.Local).AddTicks(8135) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "CategoryID",
                keyValue: 8,
                columns: new[] { "CategoryGUID", "IsActive", "ModifiedDate" },
                values: new object[] { new Guid("66f93429-c99a-4db3-8905-99aecb716f61"), true, new DateTime(2020, 5, 31, 15, 29, 22, 159, DateTimeKind.Local).AddTicks(8143) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "CategoryID",
                keyValue: 9,
                columns: new[] { "CategoryGUID", "IsActive", "ModifiedDate" },
                values: new object[] { new Guid("cb90a321-8eb8-4aec-8396-2985f5e28bc5"), true, new DateTime(2020, 5, 31, 15, 29, 22, 159, DateTimeKind.Local).AddTicks(8151) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "CategoryID",
                keyValue: 10,
                columns: new[] { "CategoryGUID", "IsActive", "ModifiedDate" },
                values: new object[] { new Guid("5286785f-74fc-4fa8-8e8e-ea9c39bac4ce"), true, new DateTime(2020, 5, 31, 15, 29, 22, 159, DateTimeKind.Local).AddTicks(8159) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "CategoryID",
                keyValue: 11,
                columns: new[] { "CategoryGUID", "IsActive", "ModifiedDate" },
                values: new object[] { new Guid("39aac5f2-d73c-4793-a9ef-58b0d34acc31"), true, new DateTime(2020, 5, 31, 15, 29, 22, 159, DateTimeKind.Local).AddTicks(8166) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "CategoryID",
                keyValue: 12,
                columns: new[] { "CategoryGUID", "IsActive", "ModifiedDate" },
                values: new object[] { new Guid("e240469f-f87d-4a4a-bf79-2cb38e99a4c7"), true, new DateTime(2020, 5, 31, 15, 29, 22, 159, DateTimeKind.Local).AddTicks(8173) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "CategoryID",
                keyValue: 13,
                columns: new[] { "CategoryGUID", "IsActive", "ModifiedDate" },
                values: new object[] { new Guid("f6487b10-c99d-4b9a-bd2e-19045431d6dc"), true, new DateTime(2020, 5, 31, 15, 29, 22, 159, DateTimeKind.Local).AddTicks(8181) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "CategoryID",
                keyValue: 14,
                columns: new[] { "CategoryGUID", "IsActive", "ModifiedDate" },
                values: new object[] { new Guid("de5f9c38-9778-4dbe-8ae8-dc472d33b13c"), true, new DateTime(2020, 5, 31, 15, 29, 22, 159, DateTimeKind.Local).AddTicks(8188) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "CategoryID",
                keyValue: 15,
                columns: new[] { "CategoryGUID", "IsActive", "ModifiedDate" },
                values: new object[] { new Guid("0b9a97c2-3588-4191-b774-d067455d18e8"), true, new DateTime(2020, 5, 31, 15, 29, 22, 159, DateTimeKind.Local).AddTicks(8199) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "CategoryID",
                keyValue: 16,
                columns: new[] { "CategoryGUID", "IsActive", "ModifiedDate" },
                values: new object[] { new Guid("e1d789de-a417-49f5-adca-b12e8b294fde"), true, new DateTime(2020, 5, 31, 15, 29, 22, 159, DateTimeKind.Local).AddTicks(8206) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "CategoryID",
                keyValue: 17,
                columns: new[] { "CategoryGUID", "IsActive", "ModifiedDate" },
                values: new object[] { new Guid("3477ccb4-d7d1-4182-8e3e-4d4f2c1270c2"), true, new DateTime(2020, 5, 31, 15, 29, 22, 159, DateTimeKind.Local).AddTicks(8213) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "CategoryID",
                keyValue: 18,
                columns: new[] { "CategoryGUID", "IsActive", "ModifiedDate" },
                values: new object[] { new Guid("014bf726-935c-4b8a-a870-0f5939b2e564"), true, new DateTime(2020, 5, 31, 15, 29, 22, 159, DateTimeKind.Local).AddTicks(8220) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "CategoryID",
                keyValue: 19,
                columns: new[] { "CategoryGUID", "IsActive", "ModifiedDate" },
                values: new object[] { new Guid("aebfe70d-b2b1-4832-b4f3-fc66df39c20e"), true, new DateTime(2020, 5, 31, 15, 29, 22, 159, DateTimeKind.Local).AddTicks(8227) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "CategoryID",
                keyValue: 20,
                columns: new[] { "CategoryGUID", "IsActive", "ModifiedDate" },
                values: new object[] { new Guid("256244bb-f571-440f-807b-14a750a70436"), true, new DateTime(2020, 5, 31, 15, 29, 22, 159, DateTimeKind.Local).AddTicks(8260) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "CategoryID",
                keyValue: 21,
                columns: new[] { "CategoryGUID", "IsActive", "ModifiedDate" },
                values: new object[] { new Guid("c0242e69-67b4-4c59-9634-9411705a0bc2"), true, new DateTime(2020, 5, 31, 15, 29, 22, 159, DateTimeKind.Local).AddTicks(8268) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "CategoryID",
                keyValue: 22,
                columns: new[] { "CategoryGUID", "IsActive", "ModifiedDate" },
                values: new object[] { new Guid("dd6b1cb2-7abc-4c73-a57a-f885d68127aa"), true, new DateTime(2020, 5, 31, 15, 29, 22, 159, DateTimeKind.Local).AddTicks(8276) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "CategoryID",
                keyValue: 23,
                columns: new[] { "CategoryGUID", "IsActive", "ModifiedDate" },
                values: new object[] { new Guid("37c98adc-2089-4123-ae98-69c6e5201dbc"), true, new DateTime(2020, 5, 31, 15, 29, 22, 159, DateTimeKind.Local).AddTicks(8287) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "CategoryID",
                keyValue: 24,
                columns: new[] { "CategoryGUID", "IsActive", "ModifiedDate" },
                values: new object[] { new Guid("e562f9c2-70ff-44eb-be6a-fd2778231ebe"), true, new DateTime(2020, 5, 31, 15, 29, 22, 159, DateTimeKind.Local).AddTicks(8294) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "CategoryID",
                keyValue: 25,
                columns: new[] { "CategoryGUID", "IsActive", "ModifiedDate" },
                values: new object[] { new Guid("0e6ec30b-427c-41de-a53f-26315ef6887a"), true, new DateTime(2020, 5, 31, 15, 29, 22, 159, DateTimeKind.Local).AddTicks(8302) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "CategoryID",
                keyValue: 26,
                columns: new[] { "CategoryGUID", "IsActive", "ModifiedDate" },
                values: new object[] { new Guid("fd0817a6-0c70-4f36-ab22-d28f75d3a760"), true, new DateTime(2020, 5, 31, 15, 29, 22, 159, DateTimeKind.Local).AddTicks(8309) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "CategoryID",
                keyValue: 27,
                columns: new[] { "CategoryGUID", "IsActive", "ModifiedDate" },
                values: new object[] { new Guid("4b5e2557-011c-44d5-bd3b-82929b52e139"), true, new DateTime(2020, 5, 31, 15, 29, 22, 159, DateTimeKind.Local).AddTicks(8316) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "CategoryID",
                keyValue: 28,
                columns: new[] { "CategoryGUID", "IsActive", "ModifiedDate" },
                values: new object[] { new Guid("aaf5fd69-e3ca-48ed-9dbd-17f74c54fa1c"), true, new DateTime(2020, 5, 31, 15, 29, 22, 159, DateTimeKind.Local).AddTicks(8323) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "CategoryID",
                keyValue: 29,
                columns: new[] { "CategoryGUID", "IsActive", "ModifiedDate" },
                values: new object[] { new Guid("659b989f-bd5d-49bd-bafa-b929bee4957d"), true, new DateTime(2020, 5, 31, 15, 29, 22, 159, DateTimeKind.Local).AddTicks(8331) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "CategoryID",
                keyValue: 30,
                columns: new[] { "CategoryGUID", "IsActive", "ModifiedDate" },
                values: new object[] { new Guid("3406b5d6-dd6b-4041-b40e-60fdbb335a6f"), true, new DateTime(2020, 5, 31, 15, 29, 22, 159, DateTimeKind.Local).AddTicks(8338) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "CategoryID",
                keyValue: 31,
                columns: new[] { "CategoryGUID", "IsActive", "ModifiedDate" },
                values: new object[] { new Guid("32840171-1287-4a85-9774-4fe0421c7f0c"), true, new DateTime(2020, 5, 31, 15, 29, 22, 159, DateTimeKind.Local).AddTicks(8348) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "CategoryID",
                keyValue: 32,
                columns: new[] { "CategoryGUID", "IsActive", "ModifiedDate" },
                values: new object[] { new Guid("bf34042e-0b65-4411-ad98-f9b9be25fd9c"), true, new DateTime(2020, 5, 31, 15, 29, 22, 159, DateTimeKind.Local).AddTicks(8355) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "CategoryID",
                keyValue: 33,
                columns: new[] { "CategoryGUID", "IsActive", "ModifiedDate" },
                values: new object[] { new Guid("7ca27d6a-e162-4424-a1e3-059f3774fd25"), true, new DateTime(2020, 5, 31, 15, 29, 22, 159, DateTimeKind.Local).AddTicks(8363) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "CategoryID",
                keyValue: 34,
                columns: new[] { "CategoryGUID", "IsActive", "ModifiedDate" },
                values: new object[] { new Guid("81d368ec-bfdf-4b24-be78-0128185963fd"), true, new DateTime(2020, 5, 31, 15, 29, 22, 159, DateTimeKind.Local).AddTicks(8370) });

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1,
                column: "CityGUID",
                value: new Guid("8a1ed461-9458-4a3f-90a3-24ed2ceb6b75"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 2,
                column: "CityGUID",
                value: new Guid("447fcffa-09c3-4e3d-8d90-0889f3032735"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 3,
                column: "CityGUID",
                value: new Guid("b92ef5b1-4b41-44dc-99c9-e93d0e469f72"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 4,
                column: "CityGUID",
                value: new Guid("3f345c46-da94-449a-9a95-c02b36b6a1fc"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 5,
                column: "CityGUID",
                value: new Guid("004c2491-895e-4b16-aa51-64f891b8577f"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 6,
                column: "CityGUID",
                value: new Guid("65de1e5e-0bc4-492e-990f-85574ce12347"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 7,
                column: "CityGUID",
                value: new Guid("f8379b3b-7be6-439f-ba71-fdedc2d22634"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 8,
                column: "CityGUID",
                value: new Guid("267b7ffa-425c-4be6-9518-ccbcf78ae195"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 9,
                column: "CityGUID",
                value: new Guid("ee784d0a-1696-48ee-81df-cadda515a24e"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 10,
                column: "CityGUID",
                value: new Guid("d45b3a89-2b43-44b2-ad14-9db488c20ad6"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 11,
                column: "CityGUID",
                value: new Guid("d36fbc73-a89d-487e-9ba7-a9df3cd4177a"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 12,
                column: "CityGUID",
                value: new Guid("0a0ff8e6-55a8-402f-8913-9f62436adba6"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 13,
                column: "CityGUID",
                value: new Guid("c9232868-9b9d-4a47-b77b-870bae5ae4a1"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 14,
                column: "CityGUID",
                value: new Guid("01a1643b-7d46-43b1-81c1-e2a7dd5d3983"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 15,
                column: "CityGUID",
                value: new Guid("13d31e85-5a2f-4f57-ac12-572964baebec"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 16,
                column: "CityGUID",
                value: new Guid("603879bf-725e-48b8-9bfe-e70930d1492b"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 17,
                column: "CityGUID",
                value: new Guid("ca9851e5-eaa0-460e-9647-962c75b75db5"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 18,
                column: "CityGUID",
                value: new Guid("b3a348e3-34a2-408f-928d-d63272669270"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 19,
                column: "CityGUID",
                value: new Guid("772c3026-b097-4d41-a3d0-e212dad02a03"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 20,
                column: "CityGUID",
                value: new Guid("0deb3cd9-9b14-4f92-b0f7-77c023990888"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 21,
                column: "CityGUID",
                value: new Guid("360cbda0-d472-4ae2-b7c6-d33854bf3a1f"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 22,
                column: "CityGUID",
                value: new Guid("074406bf-7975-4507-bfde-41343cdfe2ca"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 23,
                column: "CityGUID",
                value: new Guid("2324b640-2219-4142-9eb1-4c14f119b4d2"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 24,
                column: "CityGUID",
                value: new Guid("d7dd3926-d8db-4462-ba22-6900d9d29f63"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 25,
                column: "CityGUID",
                value: new Guid("acf52711-795d-4b2a-ba50-dd8941c47c3e"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 26,
                column: "CityGUID",
                value: new Guid("5af0e4fa-d314-4c4e-92b9-2e17ab3b9d47"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 27,
                column: "CityGUID",
                value: new Guid("d6cfd3ae-0a82-4675-bf90-d64aa1707f8e"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 28,
                column: "CityGUID",
                value: new Guid("29908326-524e-49c0-99a3-dbcd16a54c55"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 29,
                column: "CityGUID",
                value: new Guid("2ef5b788-32c7-41b0-8de1-31089a113258"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 30,
                column: "CityGUID",
                value: new Guid("bd58504b-421e-4a28-b640-b3722db0a7a8"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 31,
                column: "CityGUID",
                value: new Guid("b08c4b2c-13c2-4ca9-b205-2a24cbf11f40"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 32,
                column: "CityGUID",
                value: new Guid("081bf4ba-d862-459d-ba7e-99b9ad40c73b"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 33,
                column: "CityGUID",
                value: new Guid("401e2aa9-9f67-4c05-b140-3e060734da49"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 34,
                column: "CityGUID",
                value: new Guid("c164da4c-d634-478f-8d1a-029c70479981"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 35,
                column: "CityGUID",
                value: new Guid("879da14f-5b79-4446-8149-f376614a29fd"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 36,
                column: "CityGUID",
                value: new Guid("0c80c251-3b51-4fe1-bda2-064f271252c9"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 37,
                column: "CityGUID",
                value: new Guid("2fef6727-0a37-4333-af07-fa4b4e70a97f"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 38,
                column: "CityGUID",
                value: new Guid("724e5521-f303-4660-a2b4-0cc8d8ebd3be"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 39,
                column: "CityGUID",
                value: new Guid("6a351b6a-d6fb-491e-bd42-36250dc38e71"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 40,
                column: "CityGUID",
                value: new Guid("d1538655-d017-4896-a38e-0679cce19879"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 41,
                column: "CityGUID",
                value: new Guid("f9e494fe-2cb9-4a61-b717-b6815540435c"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 42,
                column: "CityGUID",
                value: new Guid("e399fd8f-c0f4-4ddd-8d16-79c3763a3ba2"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 43,
                column: "CityGUID",
                value: new Guid("5c1b2f9f-bdca-4a70-a517-882dc118666c"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 44,
                column: "CityGUID",
                value: new Guid("e238021f-72a2-4f13-978d-558075fa037c"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 45,
                column: "CityGUID",
                value: new Guid("3e6b7fb4-bf02-4035-bc8c-a929169e0049"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 46,
                column: "CityGUID",
                value: new Guid("fa05ed8e-30eb-4000-87e8-ba4b6178e5f6"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 47,
                column: "CityGUID",
                value: new Guid("6f3547ec-cf96-4912-8743-36c7d7329635"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 48,
                column: "CityGUID",
                value: new Guid("b503d561-e93f-4179-8b26-6690071d735d"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 49,
                column: "CityGUID",
                value: new Guid("b41f8f7f-9b5f-4212-84f8-40295d09e467"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 50,
                column: "CityGUID",
                value: new Guid("9044fd49-27e4-41e4-b246-6cba20c43f2d"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 51,
                column: "CityGUID",
                value: new Guid("85bb4378-7164-4c74-a2dc-b3f519ebaf6e"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 52,
                column: "CityGUID",
                value: new Guid("a7481f31-fac3-45da-8771-758ae8c587b0"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 53,
                column: "CityGUID",
                value: new Guid("4c77dc71-46b2-44ec-878e-93cec8dd57d5"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 54,
                column: "CityGUID",
                value: new Guid("3e6ea290-1581-49fc-904b-19440c1636fb"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 55,
                column: "CityGUID",
                value: new Guid("09ba3934-2c52-465d-88b8-558c96af7b92"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 56,
                column: "CityGUID",
                value: new Guid("372876eb-0fa8-4f1b-be53-a7082ab8e59b"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 57,
                column: "CityGUID",
                value: new Guid("1e81f858-6460-4e3c-82f4-29ae25515cdd"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 58,
                column: "CityGUID",
                value: new Guid("eb808aed-0b47-4277-8cee-630d882a42dd"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 59,
                column: "CityGUID",
                value: new Guid("66d29895-00ba-46e4-8039-4da2be76be64"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 60,
                column: "CityGUID",
                value: new Guid("0bd0b35b-2cca-48a7-8708-581278e89230"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 61,
                column: "CityGUID",
                value: new Guid("8fae0e85-c181-4b9e-b55a-8ed564b52013"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 62,
                column: "CityGUID",
                value: new Guid("2ddecd94-7355-4cd2-88cf-68ed7095c9bc"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 63,
                column: "CityGUID",
                value: new Guid("78a79841-ed88-49c6-ba3b-c7072dabda79"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 64,
                column: "CityGUID",
                value: new Guid("f33385a5-f01f-4ad0-b1f1-fe522d94fb0e"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 65,
                column: "CityGUID",
                value: new Guid("c3965da2-0cd8-4334-9425-03152532045b"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 66,
                column: "CityGUID",
                value: new Guid("cafda3c8-cd13-44a0-8788-475f5ad3ed9a"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 67,
                column: "CityGUID",
                value: new Guid("68ca6b1b-a8cc-487d-b7b9-1a5a5c715a0a"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 68,
                column: "CityGUID",
                value: new Guid("c6e3bb44-f1fc-4b83-932e-4379d62555e8"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 69,
                column: "CityGUID",
                value: new Guid("f3437594-e8ea-4f88-8131-4ad9cdb5936f"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 70,
                column: "CityGUID",
                value: new Guid("4c320e88-79c0-4daf-a1ce-9e1835306fa3"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 71,
                column: "CityGUID",
                value: new Guid("67a90bd4-e34f-480f-bf28-1e660a1814fc"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 72,
                column: "CityGUID",
                value: new Guid("cb1a8f79-9d96-4edb-80fc-78817685da89"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 73,
                column: "CityGUID",
                value: new Guid("76168c94-7f3e-44d4-9274-fe9ade36fb46"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 74,
                column: "CityGUID",
                value: new Guid("3984d35b-b10a-480c-9666-af2a4f880469"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 75,
                column: "CityGUID",
                value: new Guid("22a24df9-6d61-48da-a4b6-51b3a5463300"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 76,
                column: "CityGUID",
                value: new Guid("c5123544-692a-4737-9410-0a17e6c9f07b"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 77,
                column: "CityGUID",
                value: new Guid("71bcb654-7b6d-4b7a-876e-8244564bcbef"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 78,
                column: "CityGUID",
                value: new Guid("b7b9207c-b7b8-4b4a-bb4a-811042aabeb3"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 79,
                column: "CityGUID",
                value: new Guid("2545eec4-8057-4214-ab9f-bb35524e8bab"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 80,
                column: "CityGUID",
                value: new Guid("b6d3d2f2-1f28-41e0-889c-3ce315c06583"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 81,
                column: "CityGUID",
                value: new Guid("f0e1b79f-926c-47ec-8c2a-3ef26fb878d1"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 82,
                column: "CityGUID",
                value: new Guid("430001bb-a9a8-4ee9-9b16-0f1500b033a6"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 83,
                column: "CityGUID",
                value: new Guid("d050eea2-9907-48e8-8f52-8daa813dbb19"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 84,
                column: "CityGUID",
                value: new Guid("34b1473d-b350-4219-bc9d-abc357e4f49f"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 85,
                column: "CityGUID",
                value: new Guid("52a5178d-f23b-40d0-9ad4-1b19a284c440"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 86,
                column: "CityGUID",
                value: new Guid("55d4704e-1d15-4f5e-9311-ec1d7bc4ad8e"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 87,
                column: "CityGUID",
                value: new Guid("62c207e7-9bac-4583-926a-369a102909e5"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 88,
                column: "CityGUID",
                value: new Guid("a688dfd7-0d2c-4cdb-8120-4e55a2d1d22b"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 89,
                column: "CityGUID",
                value: new Guid("22ba80a3-ad17-4db4-be8c-307c889f33d8"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 90,
                column: "CityGUID",
                value: new Guid("e4104315-15c6-434c-9ac2-e84395c35010"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 91,
                column: "CityGUID",
                value: new Guid("b6a30010-b070-49b6-ab75-bb7d6cd77770"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 92,
                column: "CityGUID",
                value: new Guid("bd360383-cf8f-477f-984b-740287479dd2"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 93,
                column: "CityGUID",
                value: new Guid("5c03f9f0-fd1c-4502-910c-548dba7df4ff"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 94,
                column: "CityGUID",
                value: new Guid("411fa5ea-b13b-474e-af64-42a9c467153f"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 95,
                column: "CityGUID",
                value: new Guid("632b49a1-4af5-47e6-85c1-b37a78f8bf3d"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 96,
                column: "CityGUID",
                value: new Guid("d5e5ae14-f49c-49c1-b566-798a41280374"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 97,
                column: "CityGUID",
                value: new Guid("48c0b8dc-767a-49ca-ab68-8e4734698670"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 98,
                column: "CityGUID",
                value: new Guid("6a9f156f-7f2e-4c5e-a40d-375bbdf5c838"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 99,
                column: "CityGUID",
                value: new Guid("b7c3ddbd-ebf5-410e-82c7-bd86bbd29b1a"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 100,
                column: "CityGUID",
                value: new Guid("7aa340cc-c0c8-4ca1-8e6d-4fc2dccc3592"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 101,
                column: "CityGUID",
                value: new Guid("3c06e3de-39d0-4e50-9c4e-65ccc6fa2606"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 102,
                column: "CityGUID",
                value: new Guid("e157fa35-c9ce-49d4-9e67-ff1ec231234c"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 103,
                column: "CityGUID",
                value: new Guid("9eedfb0e-ba8f-4d81-8a1c-1e79cd300351"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 104,
                column: "CityGUID",
                value: new Guid("a3549f3a-2c12-46f7-8462-18e73d18215c"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 105,
                column: "CityGUID",
                value: new Guid("254973ab-ddac-43a0-8740-fa09ccd292e6"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 106,
                column: "CityGUID",
                value: new Guid("44de7dac-93fd-4e05-ad9a-d57936791278"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 107,
                column: "CityGUID",
                value: new Guid("d43ebfd4-039f-44c3-b34e-5f6b29bdd341"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 108,
                column: "CityGUID",
                value: new Guid("bf7ff8b6-d4f0-459b-9369-fce54376b951"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 109,
                column: "CityGUID",
                value: new Guid("7af386fd-bd1a-42a5-bba4-6d72e920930b"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 110,
                column: "CityGUID",
                value: new Guid("dc187e84-3dc7-4577-b257-17cd9c297f2c"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 111,
                column: "CityGUID",
                value: new Guid("51f4ef2e-cdf4-494f-a433-dc6c3167b619"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 112,
                column: "CityGUID",
                value: new Guid("80058036-380f-4ff3-860e-b3115396292d"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 113,
                column: "CityGUID",
                value: new Guid("481fb21d-f98c-415b-8fa9-98cfd9acd73f"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 114,
                column: "CityGUID",
                value: new Guid("0571ec23-e257-45e5-aab7-29b7751e799b"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 115,
                column: "CityGUID",
                value: new Guid("5a2ef5fc-57f6-4657-bc11-ce824476eb92"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 116,
                column: "CityGUID",
                value: new Guid("e69e99b4-8d64-45e1-b7ce-f341a040d3d9"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 117,
                column: "CityGUID",
                value: new Guid("a5d30a61-ad2f-42be-b5fc-ddee3bdf598f"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 118,
                column: "CityGUID",
                value: new Guid("65092f75-567a-4a80-abc6-1a5bc819988d"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 119,
                column: "CityGUID",
                value: new Guid("5884489e-eaae-4630-8e8d-1b79482b129b"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 120,
                column: "CityGUID",
                value: new Guid("180d0660-cbb9-41b9-b5a7-53afcadba141"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 121,
                column: "CityGUID",
                value: new Guid("ac6e2347-3179-4ac8-9852-76dd2f08cc11"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 122,
                column: "CityGUID",
                value: new Guid("3c6a850f-1306-496f-9848-2cc50ad3124a"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 123,
                column: "CityGUID",
                value: new Guid("840a3749-89ec-48e8-abc8-294ace188e69"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 124,
                column: "CityGUID",
                value: new Guid("bbc473b1-02a8-4dd7-81f3-70f7162a6919"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 125,
                column: "CityGUID",
                value: new Guid("2753fbb9-91df-4a31-a3bb-e3fd395b99a2"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 126,
                column: "CityGUID",
                value: new Guid("c7a9ed43-3047-4be3-a46d-93fa26c7fd0b"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 127,
                column: "CityGUID",
                value: new Guid("6d114617-57e7-44e4-b7a6-456ec3a3031b"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 128,
                column: "CityGUID",
                value: new Guid("e0172745-8df4-4753-8532-a64c4fdef55f"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 129,
                column: "CityGUID",
                value: new Guid("419f86cc-2de2-410c-821c-dfec21495885"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 130,
                column: "CityGUID",
                value: new Guid("71454154-b03c-497c-9a8c-2b0ef06f7fb9"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 131,
                column: "CityGUID",
                value: new Guid("21363deb-e6a0-415f-9d2e-dd175ae82277"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 132,
                column: "CityGUID",
                value: new Guid("8713d39b-553b-4e53-92e8-abb823222981"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 133,
                column: "CityGUID",
                value: new Guid("6d453b9a-22a8-4397-a2f1-224d65599dcf"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 134,
                column: "CityGUID",
                value: new Guid("6c3aca6e-8b9c-4423-b082-eacf764a6c7f"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 135,
                column: "CityGUID",
                value: new Guid("5a93bc60-2119-4a46-a6d6-b62ef9a3ce59"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 136,
                column: "CityGUID",
                value: new Guid("7e0d1544-3070-476e-b329-3c1202c5dd93"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 137,
                column: "CityGUID",
                value: new Guid("1fa1f122-4af0-41b1-a098-25aa673c694c"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 138,
                column: "CityGUID",
                value: new Guid("b84da5d0-2bfe-4131-a1bb-2ff10785ee7a"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 139,
                column: "CityGUID",
                value: new Guid("354f35fb-1bac-4c61-a5c8-ef16bfa634bd"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 140,
                column: "CityGUID",
                value: new Guid("0095f6a6-8024-427d-a8d5-52bc3006a0a1"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 141,
                column: "CityGUID",
                value: new Guid("87b0ffe1-2a4a-44f7-94f8-cdad44caaf3b"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 142,
                column: "CityGUID",
                value: new Guid("f757321d-0dce-4b47-b37e-aa65d7a76529"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 143,
                column: "CityGUID",
                value: new Guid("a4b1c3c3-e6fd-4a3d-91b9-e51177fa6d9b"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 144,
                column: "CityGUID",
                value: new Guid("da5c9e8f-9a83-494b-82b1-5c3b8789dc17"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 145,
                column: "CityGUID",
                value: new Guid("b99a7400-9f23-4a8f-9023-3f8046b0db5a"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 146,
                column: "CityGUID",
                value: new Guid("b6e0c837-adbb-43c1-a004-34eb2d4da4d4"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 147,
                column: "CityGUID",
                value: new Guid("010de5ff-1643-4f81-a047-d852209af2cf"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 148,
                column: "CityGUID",
                value: new Guid("1f5f32a2-edbd-47e9-a5db-2ee2c142ce9a"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 149,
                column: "CityGUID",
                value: new Guid("cf416fde-3df2-49a5-8407-523d9abd37be"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 150,
                column: "CityGUID",
                value: new Guid("8fe8be1d-8c9e-4e5a-b997-ff89ecd84621"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 151,
                column: "CityGUID",
                value: new Guid("fdcd19b6-bfd9-424b-824d-962f775a0626"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 152,
                column: "CityGUID",
                value: new Guid("61715f5a-0338-49df-8af2-5d33aba6a094"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 153,
                column: "CityGUID",
                value: new Guid("cb2cc491-22fa-42d7-9f48-0811f1ca8270"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 154,
                column: "CityGUID",
                value: new Guid("a73e40aa-aae8-488b-98e2-292603129d58"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 155,
                column: "CityGUID",
                value: new Guid("21b3f8cd-245c-47c0-9d1a-9a0c704bde94"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 156,
                column: "CityGUID",
                value: new Guid("d0d4c9a8-6184-4b27-a005-849f12e48b0b"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 157,
                column: "CityGUID",
                value: new Guid("c0b833d7-16c3-46b4-a8c0-1dfefba92d4c"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 158,
                column: "CityGUID",
                value: new Guid("013dfcad-7c09-4ced-bf61-c618ee5e9008"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 159,
                column: "CityGUID",
                value: new Guid("63746dc5-7816-4505-b004-735c8a5acefb"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 160,
                column: "CityGUID",
                value: new Guid("d068513f-0728-4e19-8893-8f11aa6601d8"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 161,
                column: "CityGUID",
                value: new Guid("c91bd6f3-3bb8-4ed2-ad1c-2e190a882b5f"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 162,
                column: "CityGUID",
                value: new Guid("ff974252-e397-4a2e-a3e3-8b9c1c13613b"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 163,
                column: "CityGUID",
                value: new Guid("e56e2027-5f40-4bdc-a33a-52bc614a1eef"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 164,
                column: "CityGUID",
                value: new Guid("28b3f939-0b64-4f32-9df9-c1622ba6041a"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 165,
                column: "CityGUID",
                value: new Guid("28f9eb88-e02c-4648-b003-20c50f7386cb"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 166,
                column: "CityGUID",
                value: new Guid("3bfc3c57-e933-4d9d-91d6-dadae4c20f6c"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 167,
                column: "CityGUID",
                value: new Guid("137f6e2b-5fb4-4811-a0f5-e5805056bee0"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 168,
                column: "CityGUID",
                value: new Guid("5f24b55e-84e3-4081-854f-a26180feff00"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 169,
                column: "CityGUID",
                value: new Guid("a76f813c-a07d-4672-a9ba-b062ca9acb53"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 170,
                column: "CityGUID",
                value: new Guid("2fcac315-2abb-44c3-a3e0-9189c56d05bc"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 171,
                column: "CityGUID",
                value: new Guid("c6f682da-272e-48a3-84dc-f4b888265958"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 172,
                column: "CityGUID",
                value: new Guid("77ee497e-d09d-4887-bf56-2290d753dc91"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 173,
                column: "CityGUID",
                value: new Guid("fed7f423-c89b-484b-8923-8d450304d9b9"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 174,
                column: "CityGUID",
                value: new Guid("6aeb83a5-3e2a-432a-83a4-d001dd62f8f5"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 175,
                column: "CityGUID",
                value: new Guid("e9ae636f-5eb1-48ed-84e9-54fd86231aa7"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 176,
                column: "CityGUID",
                value: new Guid("40f382f0-2409-4e6a-8c1d-b2e8bca9496f"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 177,
                column: "CityGUID",
                value: new Guid("a6aa207f-d821-41e4-bd94-38fd059c5e73"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 178,
                column: "CityGUID",
                value: new Guid("7d8b75ee-b503-4958-bac8-520040f9a162"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 179,
                column: "CityGUID",
                value: new Guid("cdce76cd-bbd6-4ee7-aa2e-091a30dd6396"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 180,
                column: "CityGUID",
                value: new Guid("781aad3f-b33c-44d1-ae9c-e59c4ff7f9e9"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 181,
                column: "CityGUID",
                value: new Guid("09262b9a-7f50-48e2-b9e2-67af50a5aa61"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 182,
                column: "CityGUID",
                value: new Guid("e880059a-6b77-471b-aa94-3b8e38250d37"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 183,
                column: "CityGUID",
                value: new Guid("2d097412-ce91-4273-9f29-dd84b6b45e8f"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 184,
                column: "CityGUID",
                value: new Guid("91bf4162-2778-407e-8baa-7a82b34995d4"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 185,
                column: "CityGUID",
                value: new Guid("25aaa541-eb90-4819-a067-bad67948dc48"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 186,
                column: "CityGUID",
                value: new Guid("56e18341-e886-43d4-85a7-94f192599df4"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 187,
                column: "CityGUID",
                value: new Guid("8db48776-b49e-4a44-9e1d-5ca9af635d9d"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 188,
                column: "CityGUID",
                value: new Guid("d5125455-1af0-431f-b385-e5daf90aecf9"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 189,
                column: "CityGUID",
                value: new Guid("c94bc7bb-88bb-43f9-a980-460f581c5d2a"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 190,
                column: "CityGUID",
                value: new Guid("59ffb0fe-9bb5-4f7e-af90-8f211b0bc952"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 191,
                column: "CityGUID",
                value: new Guid("35a7e1e0-43c3-4a56-a560-c0462e2daa20"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 192,
                column: "CityGUID",
                value: new Guid("3f052af7-1c3d-4b23-b28e-0fa0aa78598c"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 193,
                column: "CityGUID",
                value: new Guid("2c529867-d1a8-4583-b54b-8d9732892c92"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 194,
                column: "CityGUID",
                value: new Guid("6ad8a39c-74a6-4526-882d-76e187a5df67"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 195,
                column: "CityGUID",
                value: new Guid("e58fade1-4307-4309-88a0-2df14f545a1c"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 196,
                column: "CityGUID",
                value: new Guid("4c9553a1-29e3-4785-983f-6e7aada0851d"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 197,
                column: "CityGUID",
                value: new Guid("1043b622-fc4b-47ec-b777-1cd5fa7134c2"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 198,
                column: "CityGUID",
                value: new Guid("8b643e39-d5d3-46c6-9d00-7f2063f44ae7"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 199,
                column: "CityGUID",
                value: new Guid("4c6de884-69df-461c-80a5-5138d5ae725f"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 200,
                column: "CityGUID",
                value: new Guid("980c38e6-956e-4269-a276-65fc89a1f1bf"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 201,
                column: "CityGUID",
                value: new Guid("baab40ee-5950-426e-bd68-527c9fda63a8"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 202,
                column: "CityGUID",
                value: new Guid("a62abf63-a09a-437c-8967-39e47db96503"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 203,
                column: "CityGUID",
                value: new Guid("06f9ccc1-e07d-4eb3-a000-196feabcd2cb"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 204,
                column: "CityGUID",
                value: new Guid("f6e3cdc4-ddb9-427d-bbe7-88a951b95af2"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 205,
                column: "CityGUID",
                value: new Guid("8fc9141e-38c1-4e28-97e1-c06f575a47d0"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 206,
                column: "CityGUID",
                value: new Guid("1af103e1-744f-4b3c-9140-40df127e685d"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 207,
                column: "CityGUID",
                value: new Guid("a1f4de67-fc24-4473-8762-49a698001ab9"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 208,
                column: "CityGUID",
                value: new Guid("6f9bd62b-0636-477c-93db-477461d3f9d9"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 209,
                column: "CityGUID",
                value: new Guid("4b56608d-51fc-4184-90ae-bb9a9ac8b875"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 210,
                column: "CityGUID",
                value: new Guid("726eb08a-e0a5-4e12-8704-ead5d591a1c3"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 211,
                column: "CityGUID",
                value: new Guid("2d0be8cf-0f72-44e3-9ea9-69d180117cb1"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 212,
                column: "CityGUID",
                value: new Guid("57e76193-127e-4489-b552-d34dbbf0d27b"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 213,
                column: "CityGUID",
                value: new Guid("6cef3c45-cf03-417d-b2df-c87f2499ab7d"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 214,
                column: "CityGUID",
                value: new Guid("7bf7db82-64c1-4b5d-b9f0-61aa93343101"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 215,
                column: "CityGUID",
                value: new Guid("78873468-f8f4-410a-b80b-ee77c40ba593"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 216,
                column: "CityGUID",
                value: new Guid("3267b2e3-0c58-4b15-8816-ef5c96a9740f"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 217,
                column: "CityGUID",
                value: new Guid("a86bfe0d-9533-4a63-91bb-eded507ceb0a"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 218,
                column: "CityGUID",
                value: new Guid("4773eeba-b40b-476e-90b1-e378f0f254c5"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 219,
                column: "CityGUID",
                value: new Guid("45a61087-9254-420b-b4b8-cef92ac4513a"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 220,
                column: "CityGUID",
                value: new Guid("bde989f2-3e68-4420-9494-aaaee05ec218"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 221,
                column: "CityGUID",
                value: new Guid("fc6a93b6-9905-450b-87bd-584e4106bac4"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 222,
                column: "CityGUID",
                value: new Guid("5d65cb51-33b5-4089-921f-801d4b264f5e"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 223,
                column: "CityGUID",
                value: new Guid("a2718bdb-bd38-4f38-b878-3fa84f801c68"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 224,
                column: "CityGUID",
                value: new Guid("ec659451-4433-4c45-825f-08244b083e0c"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 225,
                column: "CityGUID",
                value: new Guid("fc35c2c8-0258-4da5-a699-b1df764d9b78"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 226,
                column: "CityGUID",
                value: new Guid("60e6b4da-355d-4b40-a612-544e92d63429"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 227,
                column: "CityGUID",
                value: new Guid("5e6b24d4-2d26-41f7-90d4-3f5bc27b75a0"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 228,
                column: "CityGUID",
                value: new Guid("f4778803-de90-48cb-b753-899204a67f72"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 229,
                column: "CityGUID",
                value: new Guid("9b771e8d-b352-460a-a4d3-3ca2dd2bc13d"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 230,
                column: "CityGUID",
                value: new Guid("8c72a011-ef58-4c1f-a563-541158e7f145"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 231,
                column: "CityGUID",
                value: new Guid("14dc6e17-f57f-4e31-9638-021e7c86c491"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 232,
                column: "CityGUID",
                value: new Guid("a452b38e-f311-4a8f-977a-87b5e110970b"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 233,
                column: "CityGUID",
                value: new Guid("201fd5ed-9a9a-40b2-a0a5-71454a9b9d26"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 234,
                column: "CityGUID",
                value: new Guid("5c809374-1086-41d0-8adb-72bb16e51e90"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 235,
                column: "CityGUID",
                value: new Guid("98423e6b-a4b2-4e0b-bef6-d7362e941021"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 236,
                column: "CityGUID",
                value: new Guid("70445b8a-31e6-468a-8c56-fc64e1b3f7ce"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 237,
                column: "CityGUID",
                value: new Guid("45e38a79-4b37-4367-a578-cb8cdad5a240"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 238,
                column: "CityGUID",
                value: new Guid("6b61abdd-da31-48f2-8d73-37b755abf804"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 239,
                column: "CityGUID",
                value: new Guid("c357d22b-9f7c-4fab-8499-85da9fb110db"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 240,
                column: "CityGUID",
                value: new Guid("997ca4b7-265c-4eaa-ab2c-0ad7e8a11107"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 241,
                column: "CityGUID",
                value: new Guid("58ba80bd-8389-4712-a354-65ce055d1b95"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 242,
                column: "CityGUID",
                value: new Guid("d7309ea1-102a-4e13-b0e3-dd743a93904c"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 243,
                column: "CityGUID",
                value: new Guid("ef9fbc55-6580-4ee8-b53c-6201f840e216"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 244,
                column: "CityGUID",
                value: new Guid("24ae001e-e697-48b1-b7cf-ab0fcf1316a4"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 245,
                column: "CityGUID",
                value: new Guid("acd00ed7-1755-4c1b-a6f5-97e5ee37b255"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 246,
                column: "CityGUID",
                value: new Guid("89c53988-035d-4ce9-9537-9096587dca5a"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 247,
                column: "CityGUID",
                value: new Guid("20d91726-6bf2-43d0-ae55-c52385ca649a"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 248,
                column: "CityGUID",
                value: new Guid("cc47b2bd-d692-42d3-9037-61b8606c4419"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 249,
                column: "CityGUID",
                value: new Guid("5811a2d1-ea2c-4d8f-8e6c-5532950ddc97"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 250,
                column: "CityGUID",
                value: new Guid("b402f5fb-93be-46f8-add1-9e101b329294"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 251,
                column: "CityGUID",
                value: new Guid("7ef8979e-2e47-4f6e-88f2-95d0744133f5"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 252,
                column: "CityGUID",
                value: new Guid("be0e5d61-f3eb-496f-8e88-da5307685f4b"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 253,
                column: "CityGUID",
                value: new Guid("560a1e1d-09d2-4a91-95c8-f82952ced0f1"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 254,
                column: "CityGUID",
                value: new Guid("b1e24575-d938-4bf2-a468-77aeebbec7eb"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 255,
                column: "CityGUID",
                value: new Guid("f29b7c47-41dd-4bab-b6a9-6e4773b01adb"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 256,
                column: "CityGUID",
                value: new Guid("2c85539f-20ec-4f46-bfa9-1c7f2c253f78"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 257,
                column: "CityGUID",
                value: new Guid("afdf273c-ebc0-42a5-9eee-b2ed4eb2d700"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 258,
                column: "CityGUID",
                value: new Guid("de2f762e-3c83-44a1-bfa4-d30a9b92cc4a"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 259,
                column: "CityGUID",
                value: new Guid("80d59f89-8aff-4a7c-91ca-4d8ed827fb2b"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 260,
                column: "CityGUID",
                value: new Guid("ffad4373-8e29-4c3a-8fed-d5630d52f55a"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 261,
                column: "CityGUID",
                value: new Guid("0127a3b1-a17c-409b-8eed-99718ae58bae"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 262,
                column: "CityGUID",
                value: new Guid("9930584e-b99b-41dd-9529-d50c75f85e9a"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 263,
                column: "CityGUID",
                value: new Guid("c324dce0-4cfd-4fb5-a2aa-269397b01696"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 264,
                column: "CityGUID",
                value: new Guid("7352e057-1d4a-457f-ae6e-8cdc66cf2f08"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 265,
                column: "CityGUID",
                value: new Guid("64d62f7a-ac77-4452-9d65-246eb97f4e8a"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 266,
                column: "CityGUID",
                value: new Guid("49e775ca-1b70-4d5a-af5f-0b9f5c82882f"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 267,
                column: "CityGUID",
                value: new Guid("cdf0acf5-9c77-4039-90d6-f81e67b00fac"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 268,
                column: "CityGUID",
                value: new Guid("74f5ee17-3f21-44d7-b04d-7e87c85bc9b9"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 269,
                column: "CityGUID",
                value: new Guid("ee92b9bf-246a-48ed-b9c0-17a758cb373e"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 270,
                column: "CityGUID",
                value: new Guid("7b3eaf28-9f22-4453-940d-dfaf27b55375"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 271,
                column: "CityGUID",
                value: new Guid("beabf5cf-d01e-433b-b76b-07d49b365def"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 272,
                column: "CityGUID",
                value: new Guid("687d24d3-84d3-4ca7-a8f4-56077a9726c7"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 273,
                column: "CityGUID",
                value: new Guid("62c16ced-b3e1-477c-aedd-47ad7afca7cd"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 274,
                column: "CityGUID",
                value: new Guid("225299f1-abcd-4263-b320-7aaa1a767a24"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 275,
                column: "CityGUID",
                value: new Guid("f1c785b4-119d-48b6-8d7e-55b3615ad9ca"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 276,
                column: "CityGUID",
                value: new Guid("29e5f5f8-b7bf-4f55-a619-30516f394c82"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 277,
                column: "CityGUID",
                value: new Guid("abc13684-f8bd-40b6-9881-2e0a601eda3f"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 278,
                column: "CityGUID",
                value: new Guid("bbd38aca-50d9-4a2a-b288-08c11f4f4283"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 279,
                column: "CityGUID",
                value: new Guid("153407a3-21d1-48bf-a189-fb470633c7ae"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 280,
                column: "CityGUID",
                value: new Guid("73def4fd-da08-4fd9-9b7f-9329507130c7"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 281,
                column: "CityGUID",
                value: new Guid("4ba08833-def9-41f6-aced-5c70875f5232"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 282,
                column: "CityGUID",
                value: new Guid("d3f63f0c-87c1-4c6d-b3e4-5aa346831725"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 283,
                column: "CityGUID",
                value: new Guid("6565c2e4-7bd8-4445-b41f-4488ff8c8cbf"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 284,
                column: "CityGUID",
                value: new Guid("8679b755-a148-4284-9e48-7c06fc330cc9"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 285,
                column: "CityGUID",
                value: new Guid("5e91bcc2-29d2-428a-b098-4a52faced9ee"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 286,
                column: "CityGUID",
                value: new Guid("c71ce043-df38-45bf-a937-3aaf7c1910f4"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 287,
                column: "CityGUID",
                value: new Guid("ce664882-b704-4340-b16c-0000f60c8c53"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 288,
                column: "CityGUID",
                value: new Guid("96c569ed-d872-4ae1-a713-9d9b1ea81523"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 289,
                column: "CityGUID",
                value: new Guid("879496d4-06b4-4972-91fd-19af17fad4f2"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 290,
                column: "CityGUID",
                value: new Guid("752c2f76-907b-4a1e-ac3d-68c6da9a1679"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 291,
                column: "CityGUID",
                value: new Guid("ee142bbb-716e-4784-ac97-c5a1ff556dd0"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 292,
                column: "CityGUID",
                value: new Guid("4f5f7cc1-6ae1-4ff1-adfd-6f3106498e94"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 293,
                column: "CityGUID",
                value: new Guid("4ffa3df2-b90e-4c7b-8ae1-5a37cca1468e"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 294,
                column: "CityGUID",
                value: new Guid("46be66d2-49b3-453e-bc33-9a67901d26bc"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 295,
                column: "CityGUID",
                value: new Guid("b9c7f0c2-892a-4aa7-a3c7-f178ec96a63d"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 296,
                column: "CityGUID",
                value: new Guid("f78b32d8-4a38-49cb-91c1-12dfa69c2632"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 297,
                column: "CityGUID",
                value: new Guid("45f578d3-0304-4ee9-87af-bae50554f16f"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 298,
                column: "CityGUID",
                value: new Guid("86947287-bc91-4d0a-8333-e0648cab739d"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 299,
                column: "CityGUID",
                value: new Guid("d39ee372-c379-4f3a-9a26-ed7dbd77a38d"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 300,
                column: "CityGUID",
                value: new Guid("6b6c1a5e-7689-467a-9dba-6c67efa8599c"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 301,
                column: "CityGUID",
                value: new Guid("71f446e8-7b50-4645-8618-520caeea7867"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 302,
                column: "CityGUID",
                value: new Guid("23e9feae-2675-439c-949e-2278f68e63fc"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 303,
                column: "CityGUID",
                value: new Guid("9864ea30-d4b2-4dc5-9ec3-4ac4ecb8208f"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 304,
                column: "CityGUID",
                value: new Guid("51f4c98c-6e5e-4661-be03-6e4b45c418f9"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 305,
                column: "CityGUID",
                value: new Guid("b1e16c00-bdd5-49e0-bed1-2aceb8548520"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 306,
                column: "CityGUID",
                value: new Guid("8bce3b22-ef7b-484e-83dd-ec8692aca543"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 307,
                column: "CityGUID",
                value: new Guid("e30befd6-d71c-4714-8812-262f899e84d3"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 308,
                column: "CityGUID",
                value: new Guid("f5eee6d7-033b-43eb-beff-9fbdf0ece2ca"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 309,
                column: "CityGUID",
                value: new Guid("7c1bcb38-33bc-479f-b743-87fe81b39e0e"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 310,
                column: "CityGUID",
                value: new Guid("79f44890-d130-49f7-9aff-d80ec356c0d5"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 311,
                column: "CityGUID",
                value: new Guid("8cb06a9d-73de-4f43-b8cc-d946bc98fc22"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 312,
                column: "CityGUID",
                value: new Guid("21120535-a79e-4df4-a194-afc3aed8d95c"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 313,
                column: "CityGUID",
                value: new Guid("044f2cc8-07ad-4d74-adbc-90e742402398"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 314,
                column: "CityGUID",
                value: new Guid("4877aba6-1198-4853-a8aa-addb8e068beb"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 315,
                column: "CityGUID",
                value: new Guid("a293a4a1-37fa-46c4-88e0-2cfe2da75111"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 316,
                column: "CityGUID",
                value: new Guid("d1d529f3-8749-4cf7-bffa-a7f1007aea90"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 317,
                column: "CityGUID",
                value: new Guid("ca1c89b8-c2de-4303-a651-9ca7e87f22cb"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 318,
                column: "CityGUID",
                value: new Guid("dfea4217-023d-410c-a701-2bd1c930c5f6"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 319,
                column: "CityGUID",
                value: new Guid("8886b66f-b1fd-4629-82fc-17c29c1570e1"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 320,
                column: "CityGUID",
                value: new Guid("81989ca7-d35c-4531-97e8-0c7d026195d3"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 321,
                column: "CityGUID",
                value: new Guid("98721c57-69de-4c05-803d-85dd9c26df71"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 322,
                column: "CityGUID",
                value: new Guid("b5978e64-38b4-4e48-a5c3-08ea52cd285e"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 323,
                column: "CityGUID",
                value: new Guid("39e83225-755e-46b9-bbcc-30dc7a431557"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 324,
                column: "CityGUID",
                value: new Guid("e75c7fda-ba41-4054-8d5d-90b5efea2a77"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 325,
                column: "CityGUID",
                value: new Guid("77f28a11-712f-4ddf-aea9-7bba339f018a"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 326,
                column: "CityGUID",
                value: new Guid("cc67ac0b-3a7b-464c-a7cb-07519d49c822"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 327,
                column: "CityGUID",
                value: new Guid("c930adb4-1c7a-4a48-a119-d0a6e1a4a881"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 328,
                column: "CityGUID",
                value: new Guid("7b2aca7a-d143-4c7a-ad56-ea52dc8c8a23"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 329,
                column: "CityGUID",
                value: new Guid("126454b4-c73b-4225-a43e-970168bbba00"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 330,
                column: "CityGUID",
                value: new Guid("4e1d28b6-29d8-4305-8c00-4f2f4491b4d7"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 331,
                column: "CityGUID",
                value: new Guid("ceb0b896-3442-4e39-a6e8-17d7933eef2e"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 332,
                column: "CityGUID",
                value: new Guid("c2b387a8-1959-4060-9a52-cc65bcfe0200"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 333,
                column: "CityGUID",
                value: new Guid("6fbbd161-ef4f-4d0d-ba67-caf31b9a2b73"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 334,
                column: "CityGUID",
                value: new Guid("786cb243-9385-49e0-9502-690867eb169b"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 335,
                column: "CityGUID",
                value: new Guid("076d05f5-ca20-4e67-8117-81d8571ab5fa"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 336,
                column: "CityGUID",
                value: new Guid("2e9a58b5-d3b1-46f6-ae3f-1c00b8cf57ba"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 337,
                column: "CityGUID",
                value: new Guid("e14c8934-cfaa-4401-b79e-5792bbbfa688"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 338,
                column: "CityGUID",
                value: new Guid("a90e7d1a-8853-492f-ac24-fa36184bfe6a"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 339,
                column: "CityGUID",
                value: new Guid("ebfb147e-caa8-4a90-9c53-9c5ef7e41cd9"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 340,
                column: "CityGUID",
                value: new Guid("3542827e-8f3c-41fb-a451-86db55a47c20"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 341,
                column: "CityGUID",
                value: new Guid("cc4e0ee4-d560-43a2-a019-d43e3fb849a2"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 342,
                column: "CityGUID",
                value: new Guid("7520d18d-743c-40a4-8dac-c3cd15eae144"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 343,
                column: "CityGUID",
                value: new Guid("c630739d-7adc-4797-b12d-d454619690e7"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 344,
                column: "CityGUID",
                value: new Guid("8ee214f7-453f-4ff7-9ada-0e36bfeebd65"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 345,
                column: "CityGUID",
                value: new Guid("fffd0ad2-fcb3-4ba7-b12d-82db3efc7be4"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 346,
                column: "CityGUID",
                value: new Guid("b6c61c44-3bd9-4fc1-b592-afb614ce2908"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 347,
                column: "CityGUID",
                value: new Guid("3a86cc9f-c00d-4e4f-8f0c-1786ea3b5f4b"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 348,
                column: "CityGUID",
                value: new Guid("73bcb420-9202-4fd4-ba95-39252b1613b7"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 349,
                column: "CityGUID",
                value: new Guid("bb901592-1137-4346-8f06-3bb24de93251"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 350,
                column: "CityGUID",
                value: new Guid("342bf2f5-3eac-4a1d-a012-9f621726ec5e"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 351,
                column: "CityGUID",
                value: new Guid("f723b17b-3662-43d4-bc1a-9bf8d2139025"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 352,
                column: "CityGUID",
                value: new Guid("7340b309-d25e-45ae-9284-a13b351b5644"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 353,
                column: "CityGUID",
                value: new Guid("a8d2ff35-80a0-474b-a927-74bc11382f86"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 354,
                column: "CityGUID",
                value: new Guid("b025e6f3-36c5-4da3-b7a6-1d82d9d906fd"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 355,
                column: "CityGUID",
                value: new Guid("2b65f0a3-a8f8-4421-9e4a-8b34989c52cf"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 356,
                column: "CityGUID",
                value: new Guid("7b3b37f6-eee8-48b9-b22f-810eab6d5e82"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 357,
                column: "CityGUID",
                value: new Guid("b72f0171-ff4c-41d0-b8b0-81214721a034"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 358,
                column: "CityGUID",
                value: new Guid("36a10139-666d-4a85-a303-1d2ad8ec9c02"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 359,
                column: "CityGUID",
                value: new Guid("095c16ac-83f0-469a-97c8-1892d45768fb"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 360,
                column: "CityGUID",
                value: new Guid("b8abe03d-fe83-4d39-8d30-a6cc3906010a"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 361,
                column: "CityGUID",
                value: new Guid("b749d4cf-63f3-4f9a-beb0-ce444637cc48"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 362,
                column: "CityGUID",
                value: new Guid("f220e11d-a68d-4fb9-8b4f-93295f5fe18c"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 363,
                column: "CityGUID",
                value: new Guid("33cfa123-6292-4caf-ad2f-d7fc901366e8"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 364,
                column: "CityGUID",
                value: new Guid("ceb2e697-3a8a-45c7-a889-ad154bd48440"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 365,
                column: "CityGUID",
                value: new Guid("04926166-dbac-4c3e-ac02-53cd45f6df9f"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 366,
                column: "CityGUID",
                value: new Guid("ec99253c-893f-4923-a52c-b5c30cfde36b"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 367,
                column: "CityGUID",
                value: new Guid("81231052-ce94-4706-b29f-1ce0f29a39e1"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 368,
                column: "CityGUID",
                value: new Guid("c75fa04f-8354-4e8b-997c-d8a0971fb35e"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 369,
                column: "CityGUID",
                value: new Guid("6a48cea0-456a-4685-a3bd-cea9ff6e1031"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 370,
                column: "CityGUID",
                value: new Guid("921130ef-da90-473e-b908-8aa7b060b9fb"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 371,
                column: "CityGUID",
                value: new Guid("38467de6-5b0b-4adc-a974-d851a84abaf1"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 372,
                column: "CityGUID",
                value: new Guid("49886192-8a06-4e7d-9370-10a0f79b8a3c"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 373,
                column: "CityGUID",
                value: new Guid("7cad703c-2f38-4f5b-87bb-f9b024543ead"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 374,
                column: "CityGUID",
                value: new Guid("a57edee2-5f30-4c4d-a776-670aad05de38"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 375,
                column: "CityGUID",
                value: new Guid("59bb72eb-b980-4315-9036-3067d45d706c"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 376,
                column: "CityGUID",
                value: new Guid("0351c52d-eeaa-4e32-9cde-46e68ee3d48c"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 377,
                column: "CityGUID",
                value: new Guid("44980186-bc72-434d-9eaa-e72abb08a200"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 378,
                column: "CityGUID",
                value: new Guid("6d3a97a9-a812-463f-bf47-475c8766b8bf"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 379,
                column: "CityGUID",
                value: new Guid("655543ba-38ad-49fc-ba60-d47eb7faab6e"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 380,
                column: "CityGUID",
                value: new Guid("ad91816b-1546-4b99-887a-64fdf4f7733a"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 381,
                column: "CityGUID",
                value: new Guid("20eb1925-0074-4258-8672-b752d269cd9b"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 382,
                column: "CityGUID",
                value: new Guid("a9b4e11b-cdec-447f-a073-2c77a306401b"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 383,
                column: "CityGUID",
                value: new Guid("c55539b0-37d3-497e-8d5d-eaba8740c9af"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 384,
                column: "CityGUID",
                value: new Guid("b9b6a587-7609-4048-a502-710c7e3058dc"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 385,
                column: "CityGUID",
                value: new Guid("615e912f-15f0-4285-baee-dd8e61a8abef"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 386,
                column: "CityGUID",
                value: new Guid("5ecee57f-35b0-463d-bda4-05a407dcefab"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 387,
                column: "CityGUID",
                value: new Guid("54bbda61-7859-4602-85e2-2d83b2bda7b2"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 388,
                column: "CityGUID",
                value: new Guid("14f1c7c4-2649-464d-b70c-205816dcb390"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 389,
                column: "CityGUID",
                value: new Guid("adec59b6-3f76-41bf-875e-eecec7634448"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 390,
                column: "CityGUID",
                value: new Guid("98ae6e4b-9deb-401d-88e2-5b918b27ca02"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 391,
                column: "CityGUID",
                value: new Guid("3fd579b3-548f-48e4-bf65-40bc9dea7f1d"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 392,
                column: "CityGUID",
                value: new Guid("4976ffbe-4823-49c8-a10a-a20fdd6adf62"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 393,
                column: "CityGUID",
                value: new Guid("bf9aa4d9-5eb5-4711-919e-b40f7b854daa"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 394,
                column: "CityGUID",
                value: new Guid("c663191c-ed98-4cb8-9552-92e8c0cd08fd"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 395,
                column: "CityGUID",
                value: new Guid("f637f7a5-7a29-4b04-9618-e9bf3c6c56c0"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 396,
                column: "CityGUID",
                value: new Guid("c1bbc196-3efc-42f5-bfc8-61ef3abcd007"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 397,
                column: "CityGUID",
                value: new Guid("7f455ac1-03dc-4778-ad34-77339fbb102b"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 398,
                column: "CityGUID",
                value: new Guid("3fba483b-8d83-4547-9019-f38be2728129"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 399,
                column: "CityGUID",
                value: new Guid("ad3b7800-4dec-494e-b682-5ca9e8655008"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 400,
                column: "CityGUID",
                value: new Guid("904d9739-671e-40a9-9f51-d65554a80744"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 401,
                column: "CityGUID",
                value: new Guid("3ba87b60-1d5a-4834-a1cd-f26232c23b23"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 402,
                column: "CityGUID",
                value: new Guid("17e43a75-97d1-4042-9ea7-a7c15b993842"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 403,
                column: "CityGUID",
                value: new Guid("eb49a5ab-db36-4368-8514-f6a460669acd"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 404,
                column: "CityGUID",
                value: new Guid("ccb2533a-e487-4a65-9e51-8a51c81332e9"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 405,
                column: "CityGUID",
                value: new Guid("e22403e5-fb27-4720-9728-10fe8c098a2f"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 406,
                column: "CityGUID",
                value: new Guid("265263de-72ec-425c-ba9b-184800807600"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 407,
                column: "CityGUID",
                value: new Guid("37b74246-ae39-4a09-8b67-d3098f8732ad"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 408,
                column: "CityGUID",
                value: new Guid("c73f79cf-a463-4e23-9956-01f60f9b8a98"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 409,
                column: "CityGUID",
                value: new Guid("cedb63ac-16f4-4ec2-9b17-a169108ef5b4"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 410,
                column: "CityGUID",
                value: new Guid("c5f00c10-0eb1-48aa-8bc1-23c359741912"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 411,
                column: "CityGUID",
                value: new Guid("cee23791-6052-4224-9c23-150a7083eda0"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 412,
                column: "CityGUID",
                value: new Guid("54999306-8f2c-4a1f-a44b-cb67737c9515"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 413,
                column: "CityGUID",
                value: new Guid("01404ab3-6a32-4620-ae68-b414a31b3d54"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 414,
                column: "CityGUID",
                value: new Guid("6f22e2da-58a4-4b93-9f8c-fe384984ac74"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 415,
                column: "CityGUID",
                value: new Guid("45f7f1b6-96e0-4926-98c1-0f84050686d6"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 416,
                column: "CityGUID",
                value: new Guid("00e5492f-49c8-47bb-a934-38819bc61d2d"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 417,
                column: "CityGUID",
                value: new Guid("637a60fb-1f53-498e-8bab-5a0545ab7932"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 418,
                column: "CityGUID",
                value: new Guid("48f21710-ebf6-467a-8974-fa7a81d8b2c5"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 419,
                column: "CityGUID",
                value: new Guid("72bf2c7d-6d42-49d6-a070-f5ea15444143"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 420,
                column: "CityGUID",
                value: new Guid("9742887f-0188-42a6-91a1-b1830e833bc7"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 421,
                column: "CityGUID",
                value: new Guid("65d57124-1b15-4669-9dab-3d890b890bd8"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 422,
                column: "CityGUID",
                value: new Guid("4949d6f6-fb50-4bce-9cb3-79e2b4b3cd66"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 423,
                column: "CityGUID",
                value: new Guid("773b25ba-ed29-48d6-abd7-4283400676a0"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 424,
                column: "CityGUID",
                value: new Guid("17695443-0d95-4bef-aa90-4325942adb84"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 425,
                column: "CityGUID",
                value: new Guid("b084e187-05bb-4168-afc4-3ddfb4940843"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 426,
                column: "CityGUID",
                value: new Guid("c1454f66-7e94-455c-8593-f2db9447bf4d"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 427,
                column: "CityGUID",
                value: new Guid("d77136d4-e9c6-40e4-8c1a-8fed835efb4b"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 428,
                column: "CityGUID",
                value: new Guid("9edcac70-94e7-4a8d-b817-96b84fa735f0"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 429,
                column: "CityGUID",
                value: new Guid("9b9e6c6e-3f29-456d-a984-0990ed04184f"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 430,
                column: "CityGUID",
                value: new Guid("d72c01b8-ac3f-4da5-a112-6fbb44a4a08d"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 431,
                column: "CityGUID",
                value: new Guid("d8cb409d-c143-4e66-ba38-306c0c342ed0"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 432,
                column: "CityGUID",
                value: new Guid("253579ba-594c-4143-91c3-c0376b4909bf"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 433,
                column: "CityGUID",
                value: new Guid("cd17a5fd-760e-4d1e-ac47-ca401c944525"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 434,
                column: "CityGUID",
                value: new Guid("5bcf9533-1578-4f8c-9acb-4b001a1a55f9"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 435,
                column: "CityGUID",
                value: new Guid("95d2d606-34ab-4d82-a6ae-d1f829ffcb86"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 436,
                column: "CityGUID",
                value: new Guid("48a4d9ca-8adb-45ae-b0a6-5aeace8ba8ed"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 437,
                column: "CityGUID",
                value: new Guid("70096ebd-2597-4e11-b1fd-49bd994dfe1b"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 438,
                column: "CityGUID",
                value: new Guid("3edf047e-ef04-421b-ab82-e1b76285b4f4"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 439,
                column: "CityGUID",
                value: new Guid("6a81c1e5-9c5d-4c12-ba52-7f687c6c453b"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 440,
                column: "CityGUID",
                value: new Guid("888cee70-7372-4b45-81ed-f3240344b23c"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 441,
                column: "CityGUID",
                value: new Guid("717bf960-080e-44eb-b261-7afda034f00b"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 442,
                column: "CityGUID",
                value: new Guid("3fc919dd-f831-4571-ab38-182f2e7dc27c"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 443,
                column: "CityGUID",
                value: new Guid("2037d422-6ae9-48e8-8df8-60ecd0020476"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 444,
                column: "CityGUID",
                value: new Guid("4137235e-3936-473f-8a64-a899fba371d7"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 445,
                column: "CityGUID",
                value: new Guid("6f5213db-8f20-40bd-83d0-ceabfb093bbe"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 446,
                column: "CityGUID",
                value: new Guid("e4fea466-2df1-4087-b7ce-f7afb9491425"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 447,
                column: "CityGUID",
                value: new Guid("3429a59c-aa77-4c9f-9b3d-bfe1bc7b3614"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 448,
                column: "CityGUID",
                value: new Guid("960d7ca2-1e88-44d7-bed2-a89c042ea893"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 449,
                column: "CityGUID",
                value: new Guid("71e7fa4b-ebba-49bf-9356-f8b8bc0f5276"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 450,
                column: "CityGUID",
                value: new Guid("1af39243-bf27-4063-991d-b482866bd61e"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 451,
                column: "CityGUID",
                value: new Guid("855e05f7-f11a-4c96-b176-6fa8b7d05dda"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 452,
                column: "CityGUID",
                value: new Guid("ca55b4e3-323e-4e24-b8c2-bd4035ab45b6"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 453,
                column: "CityGUID",
                value: new Guid("ef15c32d-edaa-4091-8017-d52429a04575"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 454,
                column: "CityGUID",
                value: new Guid("4a3117f1-d5dc-48d9-9137-2173c39bffe7"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 455,
                column: "CityGUID",
                value: new Guid("9086381a-8077-49c0-a97e-b251262eb578"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 456,
                column: "CityGUID",
                value: new Guid("b236e9bf-cd6e-4f95-b57d-eac06972be23"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 457,
                column: "CityGUID",
                value: new Guid("4dfcfb72-950c-4d50-ba89-a71f94b29982"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 458,
                column: "CityGUID",
                value: new Guid("2c149794-6b81-4e23-b6a8-ad165f5f3584"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 459,
                column: "CityGUID",
                value: new Guid("fb38b7d0-d003-4f24-8f1b-151991c799a8"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 460,
                column: "CityGUID",
                value: new Guid("1765c501-ee74-4ee9-b579-3d42d0f05a87"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 461,
                column: "CityGUID",
                value: new Guid("d06e3bc7-7e48-4108-ae32-6684c7bbcc24"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 462,
                column: "CityGUID",
                value: new Guid("1d927b1e-8914-4072-87d3-02d75c08a89a"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 463,
                column: "CityGUID",
                value: new Guid("bfbcbe3a-f052-4826-86a9-d591808b7c3b"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 464,
                column: "CityGUID",
                value: new Guid("a1d0d6f2-c20a-4df1-8dd3-9d5b58759ed1"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 465,
                column: "CityGUID",
                value: new Guid("1ef04b50-0809-4e01-be48-f088ffb41565"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 466,
                column: "CityGUID",
                value: new Guid("8578f2a5-e145-42ba-8df5-27db222cd185"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 467,
                column: "CityGUID",
                value: new Guid("aebc717d-8d61-46b2-9445-d78b66e84311"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 468,
                column: "CityGUID",
                value: new Guid("c3c264ca-cfc1-4b64-b4e2-c6ce86d89d06"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 469,
                column: "CityGUID",
                value: new Guid("b2211c14-f6a7-4d0d-86e9-3eca765221a3"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 470,
                column: "CityGUID",
                value: new Guid("37eb7faa-266b-4dc9-a8a2-f5bbbc0033ad"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 471,
                column: "CityGUID",
                value: new Guid("06d9c717-a410-4f79-ba04-7c0675a45a6f"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 472,
                column: "CityGUID",
                value: new Guid("30638888-5abe-4f6a-91dc-7fdd75fc67ca"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 473,
                column: "CityGUID",
                value: new Guid("4e1dc155-5aae-46e6-9015-032299569bfb"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 474,
                column: "CityGUID",
                value: new Guid("59d7f125-bfd1-430a-9541-19d960876e11"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 475,
                column: "CityGUID",
                value: new Guid("329e133d-9353-45e5-9820-9ea989c92bbe"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 476,
                column: "CityGUID",
                value: new Guid("362cbe3c-7587-417f-a751-a849fb899dee"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 477,
                column: "CityGUID",
                value: new Guid("fc9bd43a-792f-4854-a0e2-0be93977fa89"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 478,
                column: "CityGUID",
                value: new Guid("1fa19783-39b1-4cf8-89d1-9c09d4a912e3"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 479,
                column: "CityGUID",
                value: new Guid("19c00fb9-5916-41de-a821-f57b1f77335f"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 480,
                column: "CityGUID",
                value: new Guid("18e94452-be41-45ec-8706-15c094a62bcd"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 481,
                column: "CityGUID",
                value: new Guid("62012c5f-d439-4d0a-8a95-3037b65b84c1"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 482,
                column: "CityGUID",
                value: new Guid("08aa4b5c-eef0-437d-9267-a82d2bfffa80"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 483,
                column: "CityGUID",
                value: new Guid("55a5c511-45ce-4022-9fc1-e803ae17592a"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 484,
                column: "CityGUID",
                value: new Guid("afd58724-ca81-4f91-8e6b-f2754d378f24"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 485,
                column: "CityGUID",
                value: new Guid("42d7ff44-ce76-4cb3-903b-9cfd4dc207bc"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 486,
                column: "CityGUID",
                value: new Guid("bbdc7abb-d23f-47c7-867e-462d7d1e512a"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 487,
                column: "CityGUID",
                value: new Guid("ba433575-92f8-45fe-940f-759f1f07f3ef"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 488,
                column: "CityGUID",
                value: new Guid("f58cab11-078a-4fda-9c06-663e422504e9"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 489,
                column: "CityGUID",
                value: new Guid("879a6d8d-cc80-4785-ac08-655d7e45b7a3"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 490,
                column: "CityGUID",
                value: new Guid("f2b5da9d-2125-4a22-b240-e38eefd1a930"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 491,
                column: "CityGUID",
                value: new Guid("ea582869-4ccb-4a57-919d-0d77b91c6062"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 492,
                column: "CityGUID",
                value: new Guid("7387a1cd-83ed-4cc1-935f-b387efe0a07f"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 493,
                column: "CityGUID",
                value: new Guid("6aae43fe-bd33-42b2-b031-e5d9c0591d82"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 494,
                column: "CityGUID",
                value: new Guid("e01b7e00-fd1d-4fef-86d8-6a043dc02f6c"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 495,
                column: "CityGUID",
                value: new Guid("7df05aed-10fb-47fa-9959-25c7477d7b28"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 496,
                column: "CityGUID",
                value: new Guid("63fa5f28-d19e-42cd-9fbf-22b70abbdff0"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 497,
                column: "CityGUID",
                value: new Guid("44bf370e-5a6b-4bc6-a025-1634c3512c6d"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 498,
                column: "CityGUID",
                value: new Guid("d1e6e538-ba14-42ca-9a75-0e3072e0017b"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 499,
                column: "CityGUID",
                value: new Guid("3b7c7b1c-8eee-4644-83da-638e9c321a68"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 500,
                column: "CityGUID",
                value: new Guid("1eac15b7-9d45-469e-936b-5ce55d25e815"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 501,
                column: "CityGUID",
                value: new Guid("d3488186-8579-44bd-a9b1-48c828e3141c"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 502,
                column: "CityGUID",
                value: new Guid("da554f15-8650-4a1e-aa7f-14001efd748c"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 503,
                column: "CityGUID",
                value: new Guid("995277da-542a-4d24-9eff-6eecb35a31c3"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 504,
                column: "CityGUID",
                value: new Guid("a9173940-1cf4-4877-9302-9a06249282af"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 505,
                column: "CityGUID",
                value: new Guid("989a7ded-4755-4329-af58-13ce898cc0e9"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 506,
                column: "CityGUID",
                value: new Guid("e87a8f3b-b507-480e-8b49-aade1aa21e80"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 507,
                column: "CityGUID",
                value: new Guid("43fe17c3-d960-478e-9697-6f06eda7afa6"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 508,
                column: "CityGUID",
                value: new Guid("c5155936-1c75-43bc-8a1a-55ffa26e4673"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 509,
                column: "CityGUID",
                value: new Guid("e380d58a-ae3c-4ad6-9e47-12293e522661"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 510,
                column: "CityGUID",
                value: new Guid("f2b03f32-5eb3-49a3-b5c1-8a3d125c7ad8"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 511,
                column: "CityGUID",
                value: new Guid("26a80511-fc82-45c6-8ae5-c065789cb10e"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 512,
                column: "CityGUID",
                value: new Guid("2b324bd6-5171-4e02-8bb7-f225863ff292"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 513,
                column: "CityGUID",
                value: new Guid("1877a196-c4c7-45e2-a91d-6ad61c634421"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 514,
                column: "CityGUID",
                value: new Guid("5ba56ae3-c98b-4bd6-b2e2-f922b6ad3dd3"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 515,
                column: "CityGUID",
                value: new Guid("1835e64e-d82d-4ae9-be1f-bb91b59da324"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 516,
                column: "CityGUID",
                value: new Guid("20d17a09-71eb-4478-b44f-9d83b2e6f895"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 517,
                column: "CityGUID",
                value: new Guid("1c247d76-3aae-40b7-aaa8-428569e07378"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 518,
                column: "CityGUID",
                value: new Guid("d205d656-ed10-4a1a-a505-da1864c0d702"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 519,
                column: "CityGUID",
                value: new Guid("2ae1d733-a06b-4532-8d88-bf47e083c792"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 520,
                column: "CityGUID",
                value: new Guid("b0c59981-0e3e-4265-b877-31b24be34261"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 521,
                column: "CityGUID",
                value: new Guid("0fa0d2ce-7e5c-43c4-ac9f-0d4805195e0c"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 522,
                column: "CityGUID",
                value: new Guid("44915605-b5e0-449e-8b2d-2bf522d19a6f"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 523,
                column: "CityGUID",
                value: new Guid("d5753c2b-a348-4e30-ac9b-0349a0598f75"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 524,
                column: "CityGUID",
                value: new Guid("9c1209cf-313c-4cc7-ab03-15c1bd4c8dc9"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 525,
                column: "CityGUID",
                value: new Guid("b67bcc5a-f8c9-4ffd-91ba-7ea94a69a3eb"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 526,
                column: "CityGUID",
                value: new Guid("ea5d4a83-6c7c-413b-97aa-d3b5cb67ed80"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 527,
                column: "CityGUID",
                value: new Guid("e2672dbc-e03f-47ac-b048-e1a7778c2f73"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 528,
                column: "CityGUID",
                value: new Guid("ad242a4d-46d1-428a-ba05-55c0996fb9c6"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 529,
                column: "CityGUID",
                value: new Guid("106534bf-ed58-4b80-a966-f7686ecbc0bd"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 530,
                column: "CityGUID",
                value: new Guid("40934c49-cfb4-45ef-a9d4-23115861075a"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 531,
                column: "CityGUID",
                value: new Guid("542919a5-b9bb-4d24-9881-b2af1d66348f"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 532,
                column: "CityGUID",
                value: new Guid("469fcb34-bc9a-4e3c-8b38-1e5630ca8d4d"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 533,
                column: "CityGUID",
                value: new Guid("f8bbfbb4-cfbc-4108-a238-4db890fbf44e"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 534,
                column: "CityGUID",
                value: new Guid("a78a361c-0058-4dc2-883c-680927bd2401"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 535,
                column: "CityGUID",
                value: new Guid("c6cdda54-8334-43c1-ad27-7fa9287e70c2"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 536,
                column: "CityGUID",
                value: new Guid("92e849d2-ce21-4215-9562-c7d8cf8f15cc"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 537,
                column: "CityGUID",
                value: new Guid("9fcb9592-91b5-48b7-a273-3cd53eae3447"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 538,
                column: "CityGUID",
                value: new Guid("115260b5-3ecb-49c7-92f8-278b06e356a8"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 539,
                column: "CityGUID",
                value: new Guid("0fcbc285-df74-4df5-b827-80ce0d1db1b7"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 540,
                column: "CityGUID",
                value: new Guid("6229a2fe-206b-4a50-aab2-bd3177feb405"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 541,
                column: "CityGUID",
                value: new Guid("2b3061f1-bed8-4ed0-bbda-38c6a2470d3c"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 542,
                column: "CityGUID",
                value: new Guid("1d087869-d3ab-47ff-87fb-8e1e612889a8"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 543,
                column: "CityGUID",
                value: new Guid("de4b23a9-42de-410a-85c1-338a9a76fd3c"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 544,
                column: "CityGUID",
                value: new Guid("e06c218b-7aae-4e2f-ba90-4a3eac044ce7"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 545,
                column: "CityGUID",
                value: new Guid("16087cde-c39c-4011-a36e-cdef372cfdb2"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 546,
                column: "CityGUID",
                value: new Guid("444d7c22-b979-4e0f-a0c7-4b7c8606444f"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 547,
                column: "CityGUID",
                value: new Guid("0673ed3e-187e-4757-971b-fb6ea64f9154"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 548,
                column: "CityGUID",
                value: new Guid("db51753c-f989-4874-8ae3-8ff0b5f7c146"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 549,
                column: "CityGUID",
                value: new Guid("1a14a9e8-fc01-48a8-a0ac-3dc1156c0c51"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 550,
                column: "CityGUID",
                value: new Guid("dc53587e-22b3-47ef-9257-4a577ccb1340"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 551,
                column: "CityGUID",
                value: new Guid("c3e416b0-46f1-4ab1-b7eb-715df35b6794"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 552,
                column: "CityGUID",
                value: new Guid("258ed66a-6b02-4783-ae9d-ffac5700c7eb"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 553,
                column: "CityGUID",
                value: new Guid("6f13319a-5703-439c-b925-fe8ac1f50e67"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 554,
                column: "CityGUID",
                value: new Guid("e7aed6dc-4653-4438-876d-d28d37485132"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 555,
                column: "CityGUID",
                value: new Guid("961b8c2c-5b41-4d5f-ac28-635e82085038"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 556,
                column: "CityGUID",
                value: new Guid("1f979da6-f870-4389-8e93-4bb1c180a848"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 557,
                column: "CityGUID",
                value: new Guid("c69b39a8-7e99-43ac-9913-163145e5963a"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 558,
                column: "CityGUID",
                value: new Guid("ce4f0e33-3a61-400c-8bfe-6f44d2757072"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 559,
                column: "CityGUID",
                value: new Guid("0191f40f-7ba5-4c49-92b9-93b4d45885ab"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 560,
                column: "CityGUID",
                value: new Guid("e5f67b29-dc72-45b8-a0bd-7774e31a38e6"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 561,
                column: "CityGUID",
                value: new Guid("6c4e519e-0b48-4206-9d93-7e15e56b72d2"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 562,
                column: "CityGUID",
                value: new Guid("2565c287-b35b-4880-97a0-a9d9a2d6c34e"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 563,
                column: "CityGUID",
                value: new Guid("377179a4-7d24-4150-913e-af09b7d97923"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 564,
                column: "CityGUID",
                value: new Guid("75736494-9256-4993-9383-8568192f0418"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 565,
                column: "CityGUID",
                value: new Guid("ecade3cb-0aaa-4341-9b12-78f56dbcf68b"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 566,
                column: "CityGUID",
                value: new Guid("59f9459a-fe5b-491c-b5a4-0d29ae36ba1e"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 567,
                column: "CityGUID",
                value: new Guid("225d76cc-1019-492f-bb03-ad552819426e"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 568,
                column: "CityGUID",
                value: new Guid("0743bdcf-bf92-4fb2-96a9-58cded07ca32"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 569,
                column: "CityGUID",
                value: new Guid("ebb201ae-aa3e-4198-9a15-93c6b028de7c"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 570,
                column: "CityGUID",
                value: new Guid("79f8110d-7388-411b-9f96-ec9390b97789"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 571,
                column: "CityGUID",
                value: new Guid("0faa7847-f590-4ab2-b80e-7bfefb9c6ee6"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 572,
                column: "CityGUID",
                value: new Guid("d7e57184-5f7a-4b92-aa1e-d133cf2977ef"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 573,
                column: "CityGUID",
                value: new Guid("f163a9dc-2387-4333-9057-e724f46a3f8c"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 574,
                column: "CityGUID",
                value: new Guid("d2dee0b9-0f93-4186-89cb-9ab3f80c1fe4"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 575,
                column: "CityGUID",
                value: new Guid("4417ad77-5105-4a5f-beb9-67a119f4ec07"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 576,
                column: "CityGUID",
                value: new Guid("72adc500-ad01-47f0-a6b0-fb8313d57815"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 577,
                column: "CityGUID",
                value: new Guid("eb69e7ce-42bb-46b6-9b7c-931598b13d13"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 578,
                column: "CityGUID",
                value: new Guid("1177bf7f-09ee-4146-8742-01cbe598315a"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 579,
                column: "CityGUID",
                value: new Guid("3cc8b6d6-a81d-447f-80d4-5028b956f257"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 580,
                column: "CityGUID",
                value: new Guid("41ed3dfe-078f-4ce6-ade0-76c2a616b60d"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 581,
                column: "CityGUID",
                value: new Guid("866aa482-2bda-4ae8-92c3-6bdec3d9ff92"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 582,
                column: "CityGUID",
                value: new Guid("53cdab7e-4dbf-45fd-b569-992fa1261e0a"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 583,
                column: "CityGUID",
                value: new Guid("1c718ecc-4eb4-4e49-ab03-2c5933bd1c24"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 584,
                column: "CityGUID",
                value: new Guid("274c5d15-9b15-4270-9c1b-68b1d83468e1"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 585,
                column: "CityGUID",
                value: new Guid("308ec851-9e3b-43aa-b4aa-df75a4812a9d"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 586,
                column: "CityGUID",
                value: new Guid("44d221c9-eefb-4967-a994-0158a0f38587"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 587,
                column: "CityGUID",
                value: new Guid("ce727388-7c5a-41fc-a8c7-92a2252bb069"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 588,
                column: "CityGUID",
                value: new Guid("3dd2af94-e05c-49e8-bca6-dd42120786fe"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 589,
                column: "CityGUID",
                value: new Guid("597e1b50-7c35-419e-9d83-93acae40582a"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 590,
                column: "CityGUID",
                value: new Guid("7af5c8de-4b7a-4ce9-b629-d4cc69951d8b"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 591,
                column: "CityGUID",
                value: new Guid("569ce52d-cb21-472c-b5e1-cc047e62793f"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 592,
                column: "CityGUID",
                value: new Guid("00ded3a1-a592-4e93-89ee-6b5e5e6582a7"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 593,
                column: "CityGUID",
                value: new Guid("5a7a4087-8a20-4d9c-9bab-d38b8ad3ea3c"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 594,
                column: "CityGUID",
                value: new Guid("4ac03a0f-7386-4a5d-97d0-0257533e7a7d"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 595,
                column: "CityGUID",
                value: new Guid("c63ec374-c463-4d34-9613-4cae4cb9120f"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 596,
                column: "CityGUID",
                value: new Guid("a3a2763f-7c93-4015-81e3-126ecc1e1f1d"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 597,
                column: "CityGUID",
                value: new Guid("5fd9aeb0-3719-4b2c-8f6d-cb8f062cfb92"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 598,
                column: "CityGUID",
                value: new Guid("67aeee2f-b7b6-4cc2-84fc-9bfa65ad3f44"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 599,
                column: "CityGUID",
                value: new Guid("28ff43f1-801f-4c44-8aaf-6417e86ae0aa"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 600,
                column: "CityGUID",
                value: new Guid("f82e25dc-b10d-43cf-ba0d-2c1e04b2dbe7"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 601,
                column: "CityGUID",
                value: new Guid("772d202d-e166-4397-8adb-79487a314210"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 602,
                column: "CityGUID",
                value: new Guid("555c4c89-5228-49d0-8d68-1cf85886c8ee"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 603,
                column: "CityGUID",
                value: new Guid("8b65c9e4-c2cd-46ec-bfb1-09c2af5fdd9e"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 604,
                column: "CityGUID",
                value: new Guid("070666b2-440a-48bf-843e-49798cd9d633"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 605,
                column: "CityGUID",
                value: new Guid("f86b62ee-4270-43a7-9f57-5af83624922a"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 606,
                column: "CityGUID",
                value: new Guid("bf178972-fedf-47e1-99b3-369e311113a0"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 607,
                column: "CityGUID",
                value: new Guid("4da8b30e-b075-4c79-8c50-b447e7d448d6"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 608,
                column: "CityGUID",
                value: new Guid("1cac8de0-cf95-41e2-8780-4f9ef0ab3f32"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 609,
                column: "CityGUID",
                value: new Guid("d17549db-2dff-4149-b509-ad4e42b85b87"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 610,
                column: "CityGUID",
                value: new Guid("a84f9411-e298-4377-a625-48fa3c60e575"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 611,
                column: "CityGUID",
                value: new Guid("204f4751-4513-4de0-b17d-d91f11c4da04"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 612,
                column: "CityGUID",
                value: new Guid("76aa2c48-494b-452d-ad03-e264a1a17d39"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 613,
                column: "CityGUID",
                value: new Guid("f0acf738-4372-486c-8140-8e20941b63ed"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 614,
                column: "CityGUID",
                value: new Guid("42786c17-6a07-4f62-8de6-db3e7c5d1993"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 615,
                column: "CityGUID",
                value: new Guid("e35ded97-6230-49d0-81b3-6fe540ad5bd9"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 616,
                column: "CityGUID",
                value: new Guid("c9aed348-567f-404e-a723-575ae0c63f2b"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 617,
                column: "CityGUID",
                value: new Guid("e4c5721a-76bf-4bb9-9fa2-e74bc0f926ef"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 618,
                column: "CityGUID",
                value: new Guid("6ef0b390-f414-44cd-80ea-f79028ef7bda"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 619,
                column: "CityGUID",
                value: new Guid("6cbc7a67-3eeb-4703-a2be-d04df3542614"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 620,
                column: "CityGUID",
                value: new Guid("c5b70403-8c91-48bb-8957-c72a9befa278"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 621,
                column: "CityGUID",
                value: new Guid("23461ce7-275d-41dd-a7f6-fe08fd303836"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 622,
                column: "CityGUID",
                value: new Guid("2be3cf61-98c3-4474-a91d-fe9f0484323e"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 623,
                column: "CityGUID",
                value: new Guid("6598d157-d95d-4ea9-bc29-44178ed6efe2"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 624,
                column: "CityGUID",
                value: new Guid("35e6ac28-6fbb-40bb-b7a8-91068d7f57b8"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 625,
                column: "CityGUID",
                value: new Guid("da9fce53-710e-49b0-a137-f5d8249ed1e5"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 626,
                column: "CityGUID",
                value: new Guid("77fe6a34-6097-44b1-95f4-89f70a95d74e"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 627,
                column: "CityGUID",
                value: new Guid("0c9793bb-9eef-46f7-beec-2efd77427809"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 628,
                column: "CityGUID",
                value: new Guid("f6e8ea5d-f2cd-4b27-bff6-115a8c7d2f60"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 629,
                column: "CityGUID",
                value: new Guid("52bf4982-10d4-40bd-8bae-a46d8501616f"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 630,
                column: "CityGUID",
                value: new Guid("24290046-42da-48f4-a8a3-e3a835489e5a"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 631,
                column: "CityGUID",
                value: new Guid("4bef14b3-7680-424a-8dc8-5abb4954efc1"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 632,
                column: "CityGUID",
                value: new Guid("622dc8c8-c3c4-4165-b87f-537380ded719"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 633,
                column: "CityGUID",
                value: new Guid("d542a6a3-0de0-4648-92e3-755f26c90055"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 634,
                column: "CityGUID",
                value: new Guid("1aae6a80-5311-4b00-babf-f61bbf05bfb9"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 635,
                column: "CityGUID",
                value: new Guid("a0fea4eb-4544-417e-b437-b59f9285985f"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 636,
                column: "CityGUID",
                value: new Guid("b3d8a0f6-3a25-4969-b3ce-c6330dfc8e69"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 637,
                column: "CityGUID",
                value: new Guid("e2cf2b27-a95f-4502-b6ff-550ab3f6c7ec"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 638,
                column: "CityGUID",
                value: new Guid("9359de8d-662c-495f-8abf-7b9d14010dbb"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 639,
                column: "CityGUID",
                value: new Guid("6fde675d-f471-4242-8c30-f84ce0509471"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 640,
                column: "CityGUID",
                value: new Guid("dcff0c4d-494f-4671-94c4-84f7afe2d016"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 641,
                column: "CityGUID",
                value: new Guid("a8e9a913-3908-4c6e-9805-983619b9d62c"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 642,
                column: "CityGUID",
                value: new Guid("8d502813-b51c-499b-8f70-254f76a333c8"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 643,
                column: "CityGUID",
                value: new Guid("18ed6bd9-596d-4c4c-a2d5-bd5e50152f6f"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 644,
                column: "CityGUID",
                value: new Guid("a32747a6-4553-442c-bf3c-605557a6c91d"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 645,
                column: "CityGUID",
                value: new Guid("233537d3-04df-424a-b9d0-0f7d4f7df807"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 646,
                column: "CityGUID",
                value: new Guid("72ed584b-436a-410f-983a-074967c44b52"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 647,
                column: "CityGUID",
                value: new Guid("9bec66e2-43bb-4735-8c75-3928eb244ad8"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 648,
                column: "CityGUID",
                value: new Guid("97cca982-500b-4c68-a811-22b9cb46ec46"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 649,
                column: "CityGUID",
                value: new Guid("83eeba40-5706-457e-bdd0-2d92df3cf057"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 650,
                column: "CityGUID",
                value: new Guid("26b11bf3-3837-4652-afb3-3b21f793e8a9"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 651,
                column: "CityGUID",
                value: new Guid("9658b011-d058-4a0e-8149-2c3339e117c4"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 652,
                column: "CityGUID",
                value: new Guid("68091bb1-6013-41a6-9b4a-b56fe5aa9451"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 653,
                column: "CityGUID",
                value: new Guid("4372742d-bfa3-448d-a510-d23745a0d788"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 654,
                column: "CityGUID",
                value: new Guid("35a35e9b-2fa3-48b5-98e8-4f74e63eee51"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 655,
                column: "CityGUID",
                value: new Guid("e8a03035-fbc4-42d9-8430-d7d6f452d86c"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 656,
                column: "CityGUID",
                value: new Guid("85277302-393c-4cb9-822d-38d2189c660f"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 657,
                column: "CityGUID",
                value: new Guid("3aa62550-3e66-47fb-b57e-589c46e486aa"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 658,
                column: "CityGUID",
                value: new Guid("19ce6721-683f-45db-b741-90e59220aa04"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 659,
                column: "CityGUID",
                value: new Guid("df8adcdd-f851-4558-862a-b13017a36c33"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 660,
                column: "CityGUID",
                value: new Guid("bc59a3a0-2abd-4600-8919-10d72e5fdc87"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 661,
                column: "CityGUID",
                value: new Guid("037d4260-483e-49fa-b5f4-3c64b583882b"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 662,
                column: "CityGUID",
                value: new Guid("0196702d-988a-45e3-ba99-0518dbea3c72"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 663,
                column: "CityGUID",
                value: new Guid("98efd473-19c4-44ba-b5f0-030e282e0561"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 664,
                column: "CityGUID",
                value: new Guid("b9cd03cc-9f17-4189-b9e0-6b2a8f279cf6"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 665,
                column: "CityGUID",
                value: new Guid("abb84dc0-b849-466f-ab7b-8b385fc6a47b"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 666,
                column: "CityGUID",
                value: new Guid("4518dbd3-403d-4865-ae46-572e55bfc5a2"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 667,
                column: "CityGUID",
                value: new Guid("70e6768d-a671-4ba6-bc28-cde5fe7ddb47"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 668,
                column: "CityGUID",
                value: new Guid("f73621b9-0ef6-4387-baf1-da68b482a7df"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 669,
                column: "CityGUID",
                value: new Guid("a0495091-a25b-4475-88e6-fc0d3c5c50aa"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 670,
                column: "CityGUID",
                value: new Guid("9b1791cb-02b1-4633-83a2-579ec89e8a37"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 671,
                column: "CityGUID",
                value: new Guid("50c51b54-e51b-4eea-a7cb-c22070bd10c5"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 672,
                column: "CityGUID",
                value: new Guid("a6704845-e162-4d0c-b30c-805be7205631"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 673,
                column: "CityGUID",
                value: new Guid("3b557f90-a849-4497-99b1-47732386750d"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 674,
                column: "CityGUID",
                value: new Guid("f86a6e03-8862-4b58-aec6-62917c41b9d3"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 675,
                column: "CityGUID",
                value: new Guid("67d42344-c844-4227-9c2f-86b6aa7b1dc4"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 676,
                column: "CityGUID",
                value: new Guid("3b0c189c-4968-4404-9791-6465a9d403c9"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 677,
                column: "CityGUID",
                value: new Guid("cfffe170-1255-422a-91e4-2483bb83ada0"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 678,
                column: "CityGUID",
                value: new Guid("548e09c3-9595-442b-bd15-080d15dd1b32"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 679,
                column: "CityGUID",
                value: new Guid("fe5c4d1b-ab00-4973-98b6-0bd6fb4bf272"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 680,
                column: "CityGUID",
                value: new Guid("ceaf102a-d842-4c2b-a290-09ec4fda7aee"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 681,
                column: "CityGUID",
                value: new Guid("ac28beba-762b-448a-b731-0ee696b54e3b"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 682,
                column: "CityGUID",
                value: new Guid("285ae566-b3a8-44d2-a9dc-1a045e7f8b77"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 683,
                column: "CityGUID",
                value: new Guid("7f81ba16-c405-4727-9896-db638de11e7f"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 684,
                column: "CityGUID",
                value: new Guid("c7140d3d-edb8-4f4a-9e5c-78953799d0a3"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 685,
                column: "CityGUID",
                value: new Guid("fb55f442-6d19-49ff-8a6b-d3e15359cff8"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 686,
                column: "CityGUID",
                value: new Guid("39e85ba0-f29d-479e-8188-8880be4503cc"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 687,
                column: "CityGUID",
                value: new Guid("2b789cb7-3bf8-4e9c-a6d1-d4979544f096"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 688,
                column: "CityGUID",
                value: new Guid("7b747fa9-bccb-4c65-96ba-5afb376e696f"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 689,
                column: "CityGUID",
                value: new Guid("316b3125-fe1e-4daf-9d90-4c7d2e4e900f"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 690,
                column: "CityGUID",
                value: new Guid("68dab86f-3bc2-4b01-aced-c918735df6b7"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 691,
                column: "CityGUID",
                value: new Guid("c82fc8e0-65c6-4941-a424-eab0e4bba40d"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 692,
                column: "CityGUID",
                value: new Guid("afde16fd-af9e-48b4-b4a5-91035fcf469c"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 693,
                column: "CityGUID",
                value: new Guid("6c7b99cf-2a78-40eb-abac-de9c764a36ef"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 694,
                column: "CityGUID",
                value: new Guid("3450b5f3-e977-4289-b6ee-42b217b9a263"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 695,
                column: "CityGUID",
                value: new Guid("4b78e3f2-ee52-44fc-b468-067c85d17922"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 696,
                column: "CityGUID",
                value: new Guid("52a811fc-92c7-4fa5-8df0-a47468e7d7fc"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 697,
                column: "CityGUID",
                value: new Guid("e074ba7f-f9f4-400c-8934-397b75300545"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 698,
                column: "CityGUID",
                value: new Guid("0f683531-b56e-4348-810c-45faaa6ce9fb"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 699,
                column: "CityGUID",
                value: new Guid("a4d7b3d9-d54c-42ba-a96d-bc75a04c626a"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 700,
                column: "CityGUID",
                value: new Guid("4c011737-4bca-432d-9afa-ad0835eee6e4"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 701,
                column: "CityGUID",
                value: new Guid("e64866c2-bbc5-4f57-960e-7e91b52d026a"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 702,
                column: "CityGUID",
                value: new Guid("ba54b1bc-378d-4a61-8662-94b296970704"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 703,
                column: "CityGUID",
                value: new Guid("cd1e692a-e3ae-4175-8577-523ccca69ee0"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 704,
                column: "CityGUID",
                value: new Guid("f20ff5c1-0483-4721-b46c-f8637653e638"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 705,
                column: "CityGUID",
                value: new Guid("a218963a-937d-4bd5-b445-2d0c9f6755a8"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 706,
                column: "CityGUID",
                value: new Guid("944a7bac-cb87-42bc-b524-2a5b6faa61f1"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 707,
                column: "CityGUID",
                value: new Guid("91b17aca-d454-47be-a887-b72f147faff9"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 708,
                column: "CityGUID",
                value: new Guid("7217ee96-f84c-4d98-9ee5-a7ff8c1fda04"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 709,
                column: "CityGUID",
                value: new Guid("024db787-664a-45cd-8f24-5750a75aa189"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 710,
                column: "CityGUID",
                value: new Guid("a19c9eb5-4739-4b02-aef4-79f040d236ec"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 711,
                column: "CityGUID",
                value: new Guid("b4dcfbd1-2d7d-4f0d-8f12-99c616fef1a7"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 712,
                column: "CityGUID",
                value: new Guid("b74d80f1-fa17-4f15-9a0f-84d36c974c53"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 713,
                column: "CityGUID",
                value: new Guid("28b84a64-95ab-4d25-bca7-9cc05f4f45af"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 714,
                column: "CityGUID",
                value: new Guid("107d7c9f-d29b-41cd-bf23-8b2da0ebc896"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 715,
                column: "CityGUID",
                value: new Guid("60a33929-4697-4529-ab9d-74940c16ee8e"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 716,
                column: "CityGUID",
                value: new Guid("152f0bb6-c36c-43a8-b631-9cece2258231"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 717,
                column: "CityGUID",
                value: new Guid("a17dc1c4-7c32-4267-b859-a59a8a9ad2aa"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 718,
                column: "CityGUID",
                value: new Guid("314f715b-85ba-4111-94f2-9f9e3828438b"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 719,
                column: "CityGUID",
                value: new Guid("20ecfd3b-2443-4442-93e6-6dfa90b2f851"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 720,
                column: "CityGUID",
                value: new Guid("0db5e68b-65cd-4ec7-858e-0f22127cf75b"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 721,
                column: "CityGUID",
                value: new Guid("364f115d-02e1-416b-acd3-f112b2b46cf3"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 722,
                column: "CityGUID",
                value: new Guid("4aeff63e-8e9d-4c09-b561-2c84b0802556"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 723,
                column: "CityGUID",
                value: new Guid("d7aca44d-6412-4382-974a-b07878b36a97"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 724,
                column: "CityGUID",
                value: new Guid("f50f8b7c-9da3-4974-a1aa-13b4b1e53664"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 725,
                column: "CityGUID",
                value: new Guid("f04407a5-2a0c-4ff4-a434-dde87dd0a332"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 726,
                column: "CityGUID",
                value: new Guid("90d02b42-1dd4-4a66-b428-bbd517f0d170"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 727,
                column: "CityGUID",
                value: new Guid("2d2e49f4-425c-477e-898a-468d42360b4f"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 728,
                column: "CityGUID",
                value: new Guid("e47c6fdb-f492-4e2c-b90e-1ffb9df7ce65"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 729,
                column: "CityGUID",
                value: new Guid("8ec9bed7-2550-41e9-aaa2-299a756bcf50"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 730,
                column: "CityGUID",
                value: new Guid("0dd680b0-f683-419a-a8c0-a9b0265f2783"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 731,
                column: "CityGUID",
                value: new Guid("19b7e705-261e-4e3a-abcc-faffeb46931a"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 732,
                column: "CityGUID",
                value: new Guid("beeaddad-f530-465e-9500-88bfadd17f67"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 733,
                column: "CityGUID",
                value: new Guid("edf52544-83b9-44d9-ac52-e58b3071f803"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 734,
                column: "CityGUID",
                value: new Guid("797fac08-5cfa-4e3b-bcf1-4a1ce32d97f8"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 735,
                column: "CityGUID",
                value: new Guid("aea3a53a-b5e4-44b7-9241-f0420c6b377c"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 736,
                column: "CityGUID",
                value: new Guid("c50fe88e-a777-4992-a881-2dc4faff1ad4"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 737,
                column: "CityGUID",
                value: new Guid("88236ad3-1198-4818-8a5f-b1f2e17d847e"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 738,
                column: "CityGUID",
                value: new Guid("263f6825-4991-4397-83ea-c409159a54d3"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 739,
                column: "CityGUID",
                value: new Guid("c05000a4-d928-49aa-98fe-9eab7a8766da"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 740,
                column: "CityGUID",
                value: new Guid("2a6fda9e-dee3-4b6f-9b3e-d48b30fe5221"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 741,
                column: "CityGUID",
                value: new Guid("495f72f2-78a2-4b03-b5e0-ffa9cd24dbb9"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 742,
                column: "CityGUID",
                value: new Guid("b7a6c0fe-ca1f-4348-aed9-bafb16fdb560"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 743,
                column: "CityGUID",
                value: new Guid("be4693cd-6f52-46f3-86cf-27ac334d45cf"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 744,
                column: "CityGUID",
                value: new Guid("f1f129e4-c611-4671-b785-9fcc9c6cb9c3"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 745,
                column: "CityGUID",
                value: new Guid("da3fca7d-7980-4686-bb23-c38ce1a6d2f1"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 746,
                column: "CityGUID",
                value: new Guid("b6029f8c-2aba-4d81-82a3-c18e49e4e514"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 747,
                column: "CityGUID",
                value: new Guid("29c3a764-991c-4487-871b-d450dd11d277"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 748,
                column: "CityGUID",
                value: new Guid("3b55acfd-dcbd-4da6-8714-b8528f56de93"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 749,
                column: "CityGUID",
                value: new Guid("665520a8-69ae-4d97-b1d3-f89a632a2df8"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 750,
                column: "CityGUID",
                value: new Guid("774d826a-ebe2-4e82-be12-c457c11494dc"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 751,
                column: "CityGUID",
                value: new Guid("57c990a7-fc3c-4e4e-8b27-98292d113343"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 752,
                column: "CityGUID",
                value: new Guid("9a11cfee-c04c-43be-8a63-155125ff0dc4"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 753,
                column: "CityGUID",
                value: new Guid("fdc5c601-ac52-4313-a76b-22d7accdee72"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 754,
                column: "CityGUID",
                value: new Guid("cabfb0bf-926b-41ba-94f3-fe918df9fed9"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 755,
                column: "CityGUID",
                value: new Guid("cc74fe0c-7a59-4816-aae8-0a34fe748bb0"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 756,
                column: "CityGUID",
                value: new Guid("7abc8a2c-e880-4d28-9653-862b7100e970"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 757,
                column: "CityGUID",
                value: new Guid("8b4312b2-abf6-4f6d-8e86-a0af60159078"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 758,
                column: "CityGUID",
                value: new Guid("29b6f117-bca2-45f7-a31b-d37a2b6e1188"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 759,
                column: "CityGUID",
                value: new Guid("3d4763d1-c846-4605-96ad-3359f7d8de8d"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 760,
                column: "CityGUID",
                value: new Guid("25fa198e-b0c9-4dcb-8d9f-9e33c540c122"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 761,
                column: "CityGUID",
                value: new Guid("824bddf2-3335-44a4-8387-0a59c2952e85"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 762,
                column: "CityGUID",
                value: new Guid("7794da15-405c-4393-ab9f-6bae7d1bb2b2"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 763,
                column: "CityGUID",
                value: new Guid("34910a5a-20ec-44d3-89b5-6645627415c6"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 764,
                column: "CityGUID",
                value: new Guid("b9606cf3-e3a1-4017-be21-7c269b16f59b"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 765,
                column: "CityGUID",
                value: new Guid("613e96c2-9114-470b-b504-40393a9309d4"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 766,
                column: "CityGUID",
                value: new Guid("752aaa25-c9bc-4ea0-b24b-4149eaa172f7"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 767,
                column: "CityGUID",
                value: new Guid("10b32aad-b3c2-47e4-8714-79c41b5c620a"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 768,
                column: "CityGUID",
                value: new Guid("8636631d-1e82-4d46-8955-5b77bf5c7671"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 769,
                column: "CityGUID",
                value: new Guid("9fbda25c-0772-487a-9616-48289b13e0b4"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 770,
                column: "CityGUID",
                value: new Guid("ad052d48-652b-47ae-8d53-a5ab0919167c"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 771,
                column: "CityGUID",
                value: new Guid("232a04ca-cf9c-45f2-89ac-21c5adcc7dc5"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 772,
                column: "CityGUID",
                value: new Guid("04a3d5a6-714a-40d7-9400-b23f033b5654"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 773,
                column: "CityGUID",
                value: new Guid("796af53d-4f21-4396-ba34-59e23c11ddee"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 774,
                column: "CityGUID",
                value: new Guid("c7eb948c-f0bf-40df-a54e-40dbd6b54fbb"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 775,
                column: "CityGUID",
                value: new Guid("5a841e70-ef06-40d1-98f7-ccb431869b66"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 776,
                column: "CityGUID",
                value: new Guid("82f93aa6-f444-4c77-bb42-6a9c9c73505d"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 777,
                column: "CityGUID",
                value: new Guid("936e8266-d6e3-4795-bdc1-38d0c3ab703d"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 778,
                column: "CityGUID",
                value: new Guid("6aabca0c-7e54-429a-b0ca-aeb2ad308a6c"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 779,
                column: "CityGUID",
                value: new Guid("882734b1-63c5-4784-a82e-7d96b048c3ba"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 780,
                column: "CityGUID",
                value: new Guid("0c9ed239-e761-42a6-9a25-2bc47b7e34f6"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 781,
                column: "CityGUID",
                value: new Guid("cc5bd1b5-784f-4a05-8978-d1ba106d21a7"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 782,
                column: "CityGUID",
                value: new Guid("3b7cf6e6-f1e6-4288-a33f-ae0aa77357a1"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 783,
                column: "CityGUID",
                value: new Guid("6bad1adc-4902-49d6-b4d6-d461a6d9eeca"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 784,
                column: "CityGUID",
                value: new Guid("2d15db7c-bb8f-48a9-96b1-b8a748f25981"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 785,
                column: "CityGUID",
                value: new Guid("5bcad925-23fd-4fae-9bc8-a79cc45f385f"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 786,
                column: "CityGUID",
                value: new Guid("b2f4cc65-5325-49da-ae0c-e52c8ad7ba5f"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 787,
                column: "CityGUID",
                value: new Guid("60711e02-f504-4480-b3fd-88be418f0d90"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 788,
                column: "CityGUID",
                value: new Guid("033ddca9-a08c-4005-9bff-53e56056f492"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 789,
                column: "CityGUID",
                value: new Guid("6ce4b078-0ff5-4d71-b8ca-31b28809e0cf"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 790,
                column: "CityGUID",
                value: new Guid("76775f93-ec8d-42c9-bc50-b6540f784e1c"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 791,
                column: "CityGUID",
                value: new Guid("bd51e0ad-df0a-4e98-97a1-f77efe12ad47"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 792,
                column: "CityGUID",
                value: new Guid("671eaae4-6494-4f52-a14c-53f7601b5b2a"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 793,
                column: "CityGUID",
                value: new Guid("4db50eca-14ac-43bb-84ae-17292150f425"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 794,
                column: "CityGUID",
                value: new Guid("5a1cc492-4b7e-409e-b542-0603cc59cb20"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 795,
                column: "CityGUID",
                value: new Guid("70f148cb-90b1-4da1-8034-3b5780bf64c2"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 796,
                column: "CityGUID",
                value: new Guid("86ba863c-8477-46e8-8894-8d0505f6d661"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 797,
                column: "CityGUID",
                value: new Guid("6baa9dcf-a695-4a98-af7a-ba99d6d119bc"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 798,
                column: "CityGUID",
                value: new Guid("69186fcf-8282-4f62-aaa9-75fdc45ded57"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 799,
                column: "CityGUID",
                value: new Guid("2a19e8b8-fa40-4c2c-bb1d-8aee38bbaf45"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 800,
                column: "CityGUID",
                value: new Guid("3bfd3f3e-dc2b-4bc7-9c4b-21711aef5614"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 801,
                column: "CityGUID",
                value: new Guid("b0abd7f9-416c-49d8-b1a4-a93f7b69234a"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 802,
                column: "CityGUID",
                value: new Guid("55234e10-7d9a-408c-adeb-d717ed32894b"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 803,
                column: "CityGUID",
                value: new Guid("929c8d7d-cc0d-480e-a338-c5a397472900"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 804,
                column: "CityGUID",
                value: new Guid("e080fc49-ad33-481a-9af3-7cc6cf93ace5"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 805,
                column: "CityGUID",
                value: new Guid("95bf6a83-c8f4-40cd-b48b-eb93b52b1f3d"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 806,
                column: "CityGUID",
                value: new Guid("c458d35a-fefc-43dd-8276-402fa7ce271e"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 807,
                column: "CityGUID",
                value: new Guid("f2782a6b-dcac-4cd2-bd09-9ff8d704972a"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 808,
                column: "CityGUID",
                value: new Guid("74e84884-3a3a-4194-89e1-ba7f13dac7c2"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 809,
                column: "CityGUID",
                value: new Guid("06c70e6e-d7d3-4fc1-83c8-37ef1a0a6066"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 810,
                column: "CityGUID",
                value: new Guid("56eee6a6-b8ae-4b43-8949-5a488af2952c"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 811,
                column: "CityGUID",
                value: new Guid("2c685ec8-feca-4a77-92cb-2aefd9c97983"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 812,
                column: "CityGUID",
                value: new Guid("5286d710-1021-4df3-b526-ed30b03b9d74"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 813,
                column: "CityGUID",
                value: new Guid("822a1dc2-19a9-494f-91df-e79736033702"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 814,
                column: "CityGUID",
                value: new Guid("80df2971-2a26-490b-82ec-e4fc74ed94f3"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 815,
                column: "CityGUID",
                value: new Guid("8dc4693e-886b-4991-86af-861fcb98f56b"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 816,
                column: "CityGUID",
                value: new Guid("5911f01b-88ba-46f1-ae1f-1b3a56517a8d"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 817,
                column: "CityGUID",
                value: new Guid("4a1b9ce8-5e8a-43e2-8543-de838fda256c"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 818,
                column: "CityGUID",
                value: new Guid("a9ecb4b4-d176-48c2-957a-6087560c112e"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 819,
                column: "CityGUID",
                value: new Guid("ba3520ad-719f-466a-8e4b-9ecdf4d93fc3"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 820,
                column: "CityGUID",
                value: new Guid("3e695d07-2c3f-4138-bca6-a89df581bc0c"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 821,
                column: "CityGUID",
                value: new Guid("afb4101d-e8d9-40df-b4b2-b113199ff5e3"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 822,
                column: "CityGUID",
                value: new Guid("8f0e161c-c8d1-4a70-b7e2-d545e47aa03e"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 823,
                column: "CityGUID",
                value: new Guid("05a1d9bd-90f9-4ff6-b943-2b45288d425d"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 824,
                column: "CityGUID",
                value: new Guid("cd5b6ccc-4dd5-4edf-9a40-63f698b4575b"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 825,
                column: "CityGUID",
                value: new Guid("a688357b-19a1-4ebf-873c-a665f5d48789"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 826,
                column: "CityGUID",
                value: new Guid("02b10bca-9a1f-4d4b-89dd-57b6f4a49fe9"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 827,
                column: "CityGUID",
                value: new Guid("dd327726-27dc-465d-a779-193087330c6c"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 828,
                column: "CityGUID",
                value: new Guid("f0d5c511-d77a-40e2-b14c-db4cb32c5d76"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 829,
                column: "CityGUID",
                value: new Guid("0eb43ea2-76cf-421a-b64f-2795f968187a"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 830,
                column: "CityGUID",
                value: new Guid("44091167-59d0-4dcd-b72f-edacae297833"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 831,
                column: "CityGUID",
                value: new Guid("4eddc3f3-abf4-4133-aa88-202c77478d49"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 832,
                column: "CityGUID",
                value: new Guid("63a5a680-f347-4d7c-9c82-eb4762ddb50e"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 833,
                column: "CityGUID",
                value: new Guid("166d9272-6dc4-4de1-bde9-a7a0c2eb3aac"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 834,
                column: "CityGUID",
                value: new Guid("d93190ee-e52c-4a2f-9606-da794c0a454b"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 835,
                column: "CityGUID",
                value: new Guid("a195b595-9fc6-4f3e-ad06-83e4902868b6"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 836,
                column: "CityGUID",
                value: new Guid("6e65847f-5713-4d3f-ba43-217b5893b0ec"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 837,
                column: "CityGUID",
                value: new Guid("b4ac3c22-acc8-4529-956e-eb722c7cd2c1"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 838,
                column: "CityGUID",
                value: new Guid("5c6dd590-4ed3-46d1-9ed2-20333f6fa79a"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 839,
                column: "CityGUID",
                value: new Guid("5ff86ddd-c34c-4291-9fcd-b2597cffe6af"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 840,
                column: "CityGUID",
                value: new Guid("7b7ff920-0cf6-411c-aa6b-743450ebd0cc"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 841,
                column: "CityGUID",
                value: new Guid("e4bcbae7-94c3-4156-94c2-007a5edc59fb"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 842,
                column: "CityGUID",
                value: new Guid("8165c501-ebb4-40e0-b194-13b4b028de55"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 843,
                column: "CityGUID",
                value: new Guid("167c8ecc-5a9a-45a7-93cf-aa6b030ea7da"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 844,
                column: "CityGUID",
                value: new Guid("0f5acbde-6ad2-43bb-8256-22ebd5b60540"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 845,
                column: "CityGUID",
                value: new Guid("da581d46-2907-4c7f-ae34-440457598c59"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 846,
                column: "CityGUID",
                value: new Guid("08a467d2-7f25-4803-b973-b52d538d87cd"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 847,
                column: "CityGUID",
                value: new Guid("bc644c36-2131-4b42-8331-00ccc2486ae6"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 848,
                column: "CityGUID",
                value: new Guid("7f2b21da-802b-40e4-b0f1-4768ae360a5c"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 849,
                column: "CityGUID",
                value: new Guid("7f0bd375-1039-4339-beaa-028f50fd01f5"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 850,
                column: "CityGUID",
                value: new Guid("14b9e6a4-26f0-4945-a7c3-907415c85894"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 851,
                column: "CityGUID",
                value: new Guid("d8d79c3b-5fa5-42fa-9120-30cf8a9dac5d"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 852,
                column: "CityGUID",
                value: new Guid("af2d2f0b-4d77-42a7-a559-1978a5cee6ef"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 853,
                column: "CityGUID",
                value: new Guid("ab35f5ef-ff3d-4b94-9a5b-832833e2dfbb"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 854,
                column: "CityGUID",
                value: new Guid("e8b16e76-a63f-4464-9d33-d5038b671068"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 855,
                column: "CityGUID",
                value: new Guid("ae6029cb-fb6a-43b4-acde-9a1649ec58c1"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 856,
                column: "CityGUID",
                value: new Guid("fdcb101e-625a-4ddb-9ecd-fbfda93a2507"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 857,
                column: "CityGUID",
                value: new Guid("aa195702-3cab-458a-9405-279ab68e3bb6"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 858,
                column: "CityGUID",
                value: new Guid("a96ef8aa-75ae-4715-af6d-89726ce9911d"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 859,
                column: "CityGUID",
                value: new Guid("1524973c-8bcb-4cd5-ad75-c1a4755808ac"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 860,
                column: "CityGUID",
                value: new Guid("8d1780ce-23ea-40ff-bcf9-8550317ecd5d"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 861,
                column: "CityGUID",
                value: new Guid("4ed65718-73b8-4673-8dde-437132899027"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 862,
                column: "CityGUID",
                value: new Guid("456213af-ab7c-4e86-9532-c6b2db0f4d3c"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 863,
                column: "CityGUID",
                value: new Guid("87691aab-8f9d-4346-921d-2b73487fdbb0"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 864,
                column: "CityGUID",
                value: new Guid("73cd2d0f-d401-456a-b2a6-2b15361e833f"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 865,
                column: "CityGUID",
                value: new Guid("92f912ee-c634-454a-b4b1-eea92076527a"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 866,
                column: "CityGUID",
                value: new Guid("53ab15b2-3284-4ce9-af17-1f90a129d347"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 867,
                column: "CityGUID",
                value: new Guid("a4ea4bd3-2f8a-4d84-accf-c79fc2702c22"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 868,
                column: "CityGUID",
                value: new Guid("c48e99c5-4ef5-41db-80ea-f28f63c65313"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 869,
                column: "CityGUID",
                value: new Guid("1cb8af0f-183b-4f93-94c9-3ef3e0308dcb"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 870,
                column: "CityGUID",
                value: new Guid("531014c0-73cc-4ca3-9825-a9ff10253e9f"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 871,
                column: "CityGUID",
                value: new Guid("ad44a423-5595-4a3c-90f9-62cf963b7aea"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 872,
                column: "CityGUID",
                value: new Guid("8f7d058e-9c1d-4af3-afb2-21aa204007a3"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 873,
                column: "CityGUID",
                value: new Guid("89490725-858a-45be-b265-0bdbef451ca9"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 874,
                column: "CityGUID",
                value: new Guid("9afb43d9-8015-496d-9554-5cfaf2725d2c"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 875,
                column: "CityGUID",
                value: new Guid("d88aa347-ce4f-480b-8e87-b278a3f6fb95"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 876,
                column: "CityGUID",
                value: new Guid("2f8ea11e-dcef-488c-a2f7-92df580dde98"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 877,
                column: "CityGUID",
                value: new Guid("8e3e1e45-822b-44c3-b147-d351be09a8ef"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 878,
                column: "CityGUID",
                value: new Guid("2fb47812-4313-47fb-8606-fc63cdfc1ecd"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 879,
                column: "CityGUID",
                value: new Guid("b70a0780-fa62-41ed-b1f8-9b07c71d4830"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 880,
                column: "CityGUID",
                value: new Guid("10a2b249-7d79-45dd-80ac-16858821ec18"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 881,
                column: "CityGUID",
                value: new Guid("25591376-fd37-4af1-9219-17639dc814d7"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 882,
                column: "CityGUID",
                value: new Guid("9c019571-e937-442f-aa5f-c9d293ad33e2"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 883,
                column: "CityGUID",
                value: new Guid("423d48bd-2459-4201-a52c-7ee0811ef569"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 884,
                column: "CityGUID",
                value: new Guid("577cebc0-d759-4245-b827-5380988d0f9d"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 885,
                column: "CityGUID",
                value: new Guid("4e894027-a256-4aac-be8e-f0b63452102b"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 886,
                column: "CityGUID",
                value: new Guid("d08dc532-4dde-4e1d-9f8a-64f34230ae90"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 887,
                column: "CityGUID",
                value: new Guid("fc84da09-945d-4457-a376-91f208a1e838"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 888,
                column: "CityGUID",
                value: new Guid("83cfff50-f6cf-402e-87e8-62b0b41fbe94"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 889,
                column: "CityGUID",
                value: new Guid("680185c6-73ff-46f3-adb4-be529e1be84b"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 890,
                column: "CityGUID",
                value: new Guid("67afa827-4697-46a7-86b9-193475269816"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 891,
                column: "CityGUID",
                value: new Guid("69483a3e-921a-4ea4-8a8f-012b91d6d388"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 892,
                column: "CityGUID",
                value: new Guid("9f545b62-a6b6-4fb6-a82a-cf1e08b48c9d"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 893,
                column: "CityGUID",
                value: new Guid("b49bbcc6-e28a-49e7-af14-17e2b797dea0"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 894,
                column: "CityGUID",
                value: new Guid("24d20376-8c82-40d0-995a-98868b1d6ee2"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 895,
                column: "CityGUID",
                value: new Guid("9cc616f5-6e18-4d62-a71e-2eacbaba90ba"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 896,
                column: "CityGUID",
                value: new Guid("5253287e-81ce-4e05-a617-11b663c080aa"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 897,
                column: "CityGUID",
                value: new Guid("5a80fcb5-b42e-445b-946f-b0e35f31e525"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 898,
                column: "CityGUID",
                value: new Guid("f2af351c-d562-4711-b45e-c0f28e7ea3cf"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 899,
                column: "CityGUID",
                value: new Guid("7183500f-33d1-4d0a-8095-7b08f9114098"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 900,
                column: "CityGUID",
                value: new Guid("287bea9c-d82e-4cdf-a176-cc8e88282741"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 901,
                column: "CityGUID",
                value: new Guid("b786e104-2cc3-4248-aa44-c659e7ca8791"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 902,
                column: "CityGUID",
                value: new Guid("bed80cb5-9db3-4f60-b6e9-649dbc76f661"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 903,
                column: "CityGUID",
                value: new Guid("04077ad3-b6b8-4df9-9937-ea683deac72d"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 904,
                column: "CityGUID",
                value: new Guid("338ef449-a364-4505-879b-4f3397981160"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 905,
                column: "CityGUID",
                value: new Guid("12e7ad06-b7a0-4a42-b361-2a054e714557"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 906,
                column: "CityGUID",
                value: new Guid("5d6d72b3-acc6-4ab5-9e35-a5c09ffd4a37"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 907,
                column: "CityGUID",
                value: new Guid("a3a9b951-546b-4c41-995e-cfa351ea74a8"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 908,
                column: "CityGUID",
                value: new Guid("7b520ae6-5922-4cec-a1ae-79c417683a29"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 909,
                column: "CityGUID",
                value: new Guid("c561f832-dc0b-4812-9600-fc0b4b409a3c"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 910,
                column: "CityGUID",
                value: new Guid("cfb0daec-9f5e-49d7-989e-3852fa3f5239"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 911,
                column: "CityGUID",
                value: new Guid("0366d60e-9000-4af6-9614-4ebdf5ac81ab"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 912,
                column: "CityGUID",
                value: new Guid("26e35dcd-0316-48e8-9462-9c79f75e1c37"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 913,
                column: "CityGUID",
                value: new Guid("dffb6d6a-86e8-4bb4-ae39-a253f78ff997"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 914,
                column: "CityGUID",
                value: new Guid("98192585-6114-4288-82b8-51d187a59433"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 915,
                column: "CityGUID",
                value: new Guid("3df189d5-d1c7-48ba-9c06-773c658a2310"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 916,
                column: "CityGUID",
                value: new Guid("5100a7c7-198f-4633-a066-4bc604475db0"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 917,
                column: "CityGUID",
                value: new Guid("cba801d8-cf37-4747-bda0-8a09ef3b9297"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 918,
                column: "CityGUID",
                value: new Guid("1364438e-de66-4c78-a367-30f73bc923d3"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 919,
                column: "CityGUID",
                value: new Guid("ee0dff3b-5dcd-4000-b1d4-36c961ea05c5"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 920,
                column: "CityGUID",
                value: new Guid("29eea0ed-29a7-4def-8eb9-907ed6f64cac"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 921,
                column: "CityGUID",
                value: new Guid("6a8e655f-534d-4e93-bd5e-3fdfa7aecd50"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 922,
                column: "CityGUID",
                value: new Guid("f47a1bd1-02f7-4138-be5f-61ea2c05cbf6"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 923,
                column: "CityGUID",
                value: new Guid("94601ead-0b01-44c4-8e2d-1adcdc9a9cda"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 924,
                column: "CityGUID",
                value: new Guid("c134b78c-c407-448f-b5d1-33a5d93b65f9"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 925,
                column: "CityGUID",
                value: new Guid("53b651d2-dbbd-44a0-89ef-efe3ce6ab5f4"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 926,
                column: "CityGUID",
                value: new Guid("0f57a71a-71e7-415f-8bb8-4f0abfb07479"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 927,
                column: "CityGUID",
                value: new Guid("fe4a3661-fc1d-4588-8ecf-319b0d977c18"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 928,
                column: "CityGUID",
                value: new Guid("301cdad6-2a14-4a20-82ee-8a349a5aa614"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 929,
                column: "CityGUID",
                value: new Guid("34a1438d-35a9-4261-8e61-c9db409684c7"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 930,
                column: "CityGUID",
                value: new Guid("48e33e3f-49be-4811-9bfd-a5f754d0219d"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 931,
                column: "CityGUID",
                value: new Guid("dc25549c-a714-4e55-b354-393d973b8091"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 932,
                column: "CityGUID",
                value: new Guid("f103a61b-0bc3-4d4e-9c9e-a433ed13bf70"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 933,
                column: "CityGUID",
                value: new Guid("52414baf-fd84-4f76-886e-2ef820fa4ca5"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 934,
                column: "CityGUID",
                value: new Guid("f0f66989-12a4-4233-9ff0-beb0c79b4a54"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 935,
                column: "CityGUID",
                value: new Guid("f68f17eb-7a26-492f-a448-df8a12a98dbf"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 936,
                column: "CityGUID",
                value: new Guid("98328a7e-ae62-4786-b90a-d9277a795bbd"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 937,
                column: "CityGUID",
                value: new Guid("d99fafc3-419c-4ec6-acd8-62562dc9df04"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 938,
                column: "CityGUID",
                value: new Guid("1aa76fcc-deb8-48fa-be96-4287b79fc92e"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 939,
                column: "CityGUID",
                value: new Guid("39d91d51-334b-46ad-a3a1-2862b800373a"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 940,
                column: "CityGUID",
                value: new Guid("1b79526f-0985-4785-90c2-cd477eb176fa"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 941,
                column: "CityGUID",
                value: new Guid("07478c4f-e24e-4bd1-bb01-8377e4876b41"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 942,
                column: "CityGUID",
                value: new Guid("0422f367-5e4c-4c75-87c4-a130478883a7"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 943,
                column: "CityGUID",
                value: new Guid("a874b34b-cc5a-4c1a-ab4b-35e8a86a118d"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 944,
                column: "CityGUID",
                value: new Guid("22a18bd9-b914-46f3-bb48-069a0afca202"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 945,
                column: "CityGUID",
                value: new Guid("3c5ebf67-079a-4f37-8378-db39e31177c3"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 946,
                column: "CityGUID",
                value: new Guid("b729a4be-3248-4136-b98c-fb2255088258"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 947,
                column: "CityGUID",
                value: new Guid("4162e34f-4ae0-4406-b0e5-602349433fd6"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 948,
                column: "CityGUID",
                value: new Guid("c75be56b-ef23-4b9c-ac44-8d17620ed17c"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 949,
                column: "CityGUID",
                value: new Guid("009e4c5a-d29c-4800-96af-eef9fce7c787"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 950,
                column: "CityGUID",
                value: new Guid("079e064d-d929-4b86-b438-528dd3045a5c"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 951,
                column: "CityGUID",
                value: new Guid("7fa32cd0-9cfe-4649-9c7a-16a8ddf0a030"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 952,
                column: "CityGUID",
                value: new Guid("d196f8b4-bf60-4dbd-aff5-47c96bcfa01c"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 953,
                column: "CityGUID",
                value: new Guid("753a452a-bacf-4cc6-a0a5-2224584d7b98"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 954,
                column: "CityGUID",
                value: new Guid("433bc5fb-ff56-4d59-8e7f-f1eb53b7e1a6"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 955,
                column: "CityGUID",
                value: new Guid("fef144c3-e93c-4a74-83a0-c46330f040a4"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 956,
                column: "CityGUID",
                value: new Guid("4e0933ae-46c8-48e6-b5d7-ec8d3abca8a1"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 957,
                column: "CityGUID",
                value: new Guid("afd410df-41a9-4ff9-8ab2-badaa06716fe"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 958,
                column: "CityGUID",
                value: new Guid("9f8bd5b9-92e5-4c09-a7fa-361f060dfdd5"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 959,
                column: "CityGUID",
                value: new Guid("f3063e22-5774-4ef9-be0c-75d542cbbec1"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 960,
                column: "CityGUID",
                value: new Guid("f419abfa-adbe-4345-906a-1d7a005bb8a1"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 961,
                column: "CityGUID",
                value: new Guid("47000760-ff23-4df8-8437-2bb64f884a02"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 962,
                column: "CityGUID",
                value: new Guid("40ca2dc6-0a1d-48cd-86ff-4ff73d9a55a1"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 963,
                column: "CityGUID",
                value: new Guid("c60484e0-8aa4-4fe9-b75a-b58a73915cd0"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 964,
                column: "CityGUID",
                value: new Guid("d340af64-a012-4adf-b017-00cc9576b9f2"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 965,
                column: "CityGUID",
                value: new Guid("5207cc58-5e7a-46c6-ae39-647b212bc48b"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 966,
                column: "CityGUID",
                value: new Guid("71a8f4e4-c31b-4678-b6d2-71c63a26a0da"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 967,
                column: "CityGUID",
                value: new Guid("c7ed69fb-621a-476d-a09f-2082f3b60367"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 968,
                column: "CityGUID",
                value: new Guid("8ea5bdae-c0e6-464f-ab37-8896647008bd"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 969,
                column: "CityGUID",
                value: new Guid("16f23f83-3d71-44cf-b9e0-ccb7382cf945"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 970,
                column: "CityGUID",
                value: new Guid("2b5f0db3-ecc3-45ae-bd47-cfe442b393de"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 971,
                column: "CityGUID",
                value: new Guid("368f2f12-a9b4-4797-88c3-db181679f0d5"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 972,
                column: "CityGUID",
                value: new Guid("f0d9896c-1b07-470c-ab6f-cd8e1db7c57b"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 973,
                column: "CityGUID",
                value: new Guid("385f5031-b46f-43c2-abca-e305051ec450"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 974,
                column: "CityGUID",
                value: new Guid("cc778309-7cad-49a1-a434-1ef0ba700a93"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 975,
                column: "CityGUID",
                value: new Guid("f488997f-342c-4103-8a53-e264dfc4df45"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 976,
                column: "CityGUID",
                value: new Guid("82579d6a-99d9-4f5a-b9ff-a0a6166d2ec0"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 977,
                column: "CityGUID",
                value: new Guid("6de7f5ec-8398-4af1-a38a-230f4371902d"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 978,
                column: "CityGUID",
                value: new Guid("25cb2a77-d86a-49ec-aba7-69d7ed0a0c0d"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 979,
                column: "CityGUID",
                value: new Guid("b8931a47-3633-4478-a75b-3cd5f6399452"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 980,
                column: "CityGUID",
                value: new Guid("53aff039-0bb3-4fbd-8a71-9a616441430b"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 981,
                column: "CityGUID",
                value: new Guid("31203707-977f-4c92-babe-204258c165ca"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 982,
                column: "CityGUID",
                value: new Guid("49af67f5-5813-4ba2-b2a7-9155660f94e1"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 983,
                column: "CityGUID",
                value: new Guid("e938023c-9613-47ec-90f7-92df8cf17586"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 984,
                column: "CityGUID",
                value: new Guid("b0160dfc-a4bc-4a15-be2f-17ca5040551d"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 985,
                column: "CityGUID",
                value: new Guid("aff037ea-b7be-42c1-aee5-994eb8f7cbc3"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 986,
                column: "CityGUID",
                value: new Guid("6dc4b43b-433e-4636-af7d-066079c5d638"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 987,
                column: "CityGUID",
                value: new Guid("6d3034f4-fcb6-4a84-b047-6f32cb54e4ec"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 988,
                column: "CityGUID",
                value: new Guid("e4ac7c99-d597-4633-9a3c-dd812161fc5d"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 989,
                column: "CityGUID",
                value: new Guid("a18785d8-6173-453d-a7f3-80b8b36b0be0"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 990,
                column: "CityGUID",
                value: new Guid("83278733-ad31-470f-88d8-52d71d2cdd47"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 991,
                column: "CityGUID",
                value: new Guid("6207ccde-bfbc-409b-ae61-5322b216580a"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 992,
                column: "CityGUID",
                value: new Guid("4d8feff6-7b3d-489d-a526-0bbd794e5227"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 993,
                column: "CityGUID",
                value: new Guid("a7d30789-c1b0-4278-905d-b5abd1a0c7b3"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 994,
                column: "CityGUID",
                value: new Guid("e02ae3a3-3e5d-439b-8154-59660d991067"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 995,
                column: "CityGUID",
                value: new Guid("71229c43-0623-4083-bfae-f2c749c17570"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 996,
                column: "CityGUID",
                value: new Guid("50909055-e1b5-469c-a090-6a4ed475c5da"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 997,
                column: "CityGUID",
                value: new Guid("472f0d48-4280-41f6-90d7-00c46ac767af"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 998,
                column: "CityGUID",
                value: new Guid("dc989c14-269f-4488-aee9-5d6c86adddbc"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 999,
                column: "CityGUID",
                value: new Guid("5198f674-3f46-4be7-809f-91634b9fe00a"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1000,
                column: "CityGUID",
                value: new Guid("7cf1b5b2-4c1f-4a8e-b17c-fa4e206d3d42"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1001,
                column: "CityGUID",
                value: new Guid("32087305-fe2f-417c-9a58-93fda55795c6"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1002,
                column: "CityGUID",
                value: new Guid("84487f17-b0c1-4131-bfd3-297811927196"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1003,
                column: "CityGUID",
                value: new Guid("21191b48-0d83-42c4-8919-706d5ca91649"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1004,
                column: "CityGUID",
                value: new Guid("305c7767-f68e-499d-a8f0-6ba46d19704d"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1005,
                column: "CityGUID",
                value: new Guid("671da058-8e8f-4455-962f-e086118964c2"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1006,
                column: "CityGUID",
                value: new Guid("6d9bd125-d696-4a22-a9e0-9e70d233dd3c"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1007,
                column: "CityGUID",
                value: new Guid("a7e71c99-09d3-4d59-b354-927eca339d91"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1008,
                column: "CityGUID",
                value: new Guid("e0610c66-b2cd-4244-bb6b-d1ed32003e0f"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1009,
                column: "CityGUID",
                value: new Guid("4fe01490-04c0-44ae-97ae-8b1233ae35f6"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1010,
                column: "CityGUID",
                value: new Guid("99497852-018d-4772-8d2a-9841b6b8c84c"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1011,
                column: "CityGUID",
                value: new Guid("ba618900-c665-442f-9f5c-1642b0f55645"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1012,
                column: "CityGUID",
                value: new Guid("6cb4a30b-8f83-4b82-b029-0fe63aaac8ff"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1013,
                column: "CityGUID",
                value: new Guid("bd527361-68ed-42cc-abf1-d83b17f7090f"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1014,
                column: "CityGUID",
                value: new Guid("d371e1d3-be33-4469-94a7-8758c5eaa64d"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1015,
                column: "CityGUID",
                value: new Guid("e8d67063-5bab-45e8-b5cb-691388f4d009"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1016,
                column: "CityGUID",
                value: new Guid("5f6453db-4752-48a7-97bd-5c86a946ccd4"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1017,
                column: "CityGUID",
                value: new Guid("184a77e3-d320-418e-9b51-e83b4ab51503"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1018,
                column: "CityGUID",
                value: new Guid("5b696018-88b9-41db-bf56-4c54c264f3cf"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1019,
                column: "CityGUID",
                value: new Guid("4069ec7d-6745-494c-96ff-206c0566287a"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1020,
                column: "CityGUID",
                value: new Guid("f3573813-2858-4b89-90c8-182dbf029663"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1021,
                column: "CityGUID",
                value: new Guid("9c037501-76ec-47ad-85db-96067ca29419"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1022,
                column: "CityGUID",
                value: new Guid("9fbfd01c-d7fc-428a-b207-7406722c14a5"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1023,
                column: "CityGUID",
                value: new Guid("493fa48f-e67d-4405-b773-99bbaa34c559"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1024,
                column: "CityGUID",
                value: new Guid("520cd506-32c2-4806-b63e-718c77f5d934"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1025,
                column: "CityGUID",
                value: new Guid("ceb9534b-94e1-4921-bd8a-917c1b0ea31f"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1026,
                column: "CityGUID",
                value: new Guid("243cb38f-b5a1-4414-959e-0f51cf884ad2"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1027,
                column: "CityGUID",
                value: new Guid("3419736b-cc9b-4417-8331-b8932abb148d"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1028,
                column: "CityGUID",
                value: new Guid("e3d59f3e-474d-4805-bd24-ca79a5f8a0ea"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1029,
                column: "CityGUID",
                value: new Guid("3e27890d-846f-4909-bdac-2416bcdf75e2"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1030,
                column: "CityGUID",
                value: new Guid("d195e507-02d5-4923-9826-1a9547480607"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1031,
                column: "CityGUID",
                value: new Guid("e639b29e-abc1-4e6e-a2c3-f34dbf323ddf"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1032,
                column: "CityGUID",
                value: new Guid("dd1d257d-6d44-469e-b451-df3c19b75c4f"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1033,
                column: "CityGUID",
                value: new Guid("d156a766-e4d5-48e0-8533-e230ac6d4caf"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1034,
                column: "CityGUID",
                value: new Guid("f29f34d4-5276-48ed-96f9-68851e982918"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1035,
                column: "CityGUID",
                value: new Guid("7a53cecb-925f-442b-b71e-bde099517b26"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1036,
                column: "CityGUID",
                value: new Guid("21506912-621e-4ca5-b15b-6a3cd60933d5"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1037,
                column: "CityGUID",
                value: new Guid("c0fb4af7-55a0-4263-842b-1e9bbdb827a8"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1038,
                column: "CityGUID",
                value: new Guid("fac26b81-dfb8-4c4b-adae-2b98c520bb4c"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1039,
                column: "CityGUID",
                value: new Guid("4309935d-0bcb-4f46-b148-571023e8a351"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1040,
                column: "CityGUID",
                value: new Guid("e2e5b19d-8795-4508-834e-969a447f8551"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1041,
                column: "CityGUID",
                value: new Guid("43990f7c-e33f-4af0-8ac1-8977fe3a94bf"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1042,
                column: "CityGUID",
                value: new Guid("a37465fb-deae-4247-8109-e92402b2471c"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1043,
                column: "CityGUID",
                value: new Guid("4c7f5c43-a5d5-48eb-9575-fd1d9561d4cb"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1044,
                column: "CityGUID",
                value: new Guid("bd324536-2b23-48a7-9a67-52552ee556b2"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1045,
                column: "CityGUID",
                value: new Guid("8ce67666-3971-4298-bd3e-11eb32e68cc9"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1046,
                column: "CityGUID",
                value: new Guid("57fc9d4f-c1b8-45ca-ba6e-e15e7684858d"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1047,
                column: "CityGUID",
                value: new Guid("d035d2a3-25f3-4368-bb11-0a2e8548e436"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1048,
                column: "CityGUID",
                value: new Guid("aa3a181a-cec5-4983-874c-7eab1f3b5973"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1049,
                column: "CityGUID",
                value: new Guid("66829e0a-f680-4e0f-b830-fdddd9c4a18a"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1050,
                column: "CityGUID",
                value: new Guid("bcac6572-2259-43da-a224-066eafb2c53d"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1051,
                column: "CityGUID",
                value: new Guid("5e03d17e-8c73-416a-be9f-ee01cade84c6"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1052,
                column: "CityGUID",
                value: new Guid("0aeab5f3-f5ce-4030-8d45-7945023ee6b9"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1053,
                column: "CityGUID",
                value: new Guid("88122fd4-b7b5-4c9b-bf2f-b23ea6b6bce9"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1054,
                column: "CityGUID",
                value: new Guid("350465bf-c51d-41da-b709-d672db802ae1"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1055,
                column: "CityGUID",
                value: new Guid("f94efe71-c05c-48d3-943e-01536452acbf"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1056,
                column: "CityGUID",
                value: new Guid("33330dc6-1a01-486a-a4fd-8d64755ed0c4"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1057,
                column: "CityGUID",
                value: new Guid("fb85d1fa-b394-4c28-b40e-f0f44ac8edb9"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1058,
                column: "CityGUID",
                value: new Guid("aa05149c-9f4c-4b36-8e5c-95e42f30e240"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1059,
                column: "CityGUID",
                value: new Guid("e8300b90-d8e6-4304-91a5-0987bdf7b353"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1060,
                column: "CityGUID",
                value: new Guid("9083851c-c095-4d30-bb7d-89e49797ae6a"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1061,
                column: "CityGUID",
                value: new Guid("e94beb24-f0bc-4092-800d-658bd69762f5"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1062,
                column: "CityGUID",
                value: new Guid("3bfd44b6-3ac4-41fa-8594-55e0e5130d7e"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1063,
                column: "CityGUID",
                value: new Guid("48a359b3-f462-4464-a4a1-c002537fae9d"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1064,
                column: "CityGUID",
                value: new Guid("13587de5-5dc8-4728-b874-9eb8088283d4"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1065,
                column: "CityGUID",
                value: new Guid("98d48e8b-3b5c-4014-b9dd-84f5c8495788"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1066,
                column: "CityGUID",
                value: new Guid("cf1a62be-9d47-43fb-b5b4-6ee0dd5d342d"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1067,
                column: "CityGUID",
                value: new Guid("3ea24e93-3744-4899-b563-5939264b532d"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1068,
                column: "CityGUID",
                value: new Guid("d7a970bb-ec20-4ddf-abf2-4c4ec3b3f845"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1069,
                column: "CityGUID",
                value: new Guid("6e3f37cc-a8c4-4c6a-9d75-cb3921c25038"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1070,
                column: "CityGUID",
                value: new Guid("e76d33cb-e9d1-4497-b52c-239d3fcbeb2c"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1071,
                column: "CityGUID",
                value: new Guid("93b53f49-28bb-4f81-a08f-0250cfdf9730"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1072,
                column: "CityGUID",
                value: new Guid("2db0c874-a4fd-4fa0-a843-1cfc411247c3"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1073,
                column: "CityGUID",
                value: new Guid("3c9494d2-d5fe-4e6a-8d6b-e88cf9a31e5e"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1074,
                column: "CityGUID",
                value: new Guid("c762f20f-d0f5-4e3c-9c2c-0b831e5c32b5"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1075,
                column: "CityGUID",
                value: new Guid("651f55c9-b4e6-468a-bd97-2b2fb710719b"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1076,
                column: "CityGUID",
                value: new Guid("945f4d6d-4818-4f11-b95f-0b5c9557fbdc"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1077,
                column: "CityGUID",
                value: new Guid("50ce1e3c-f4bf-461b-b420-04dda3dd814d"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1078,
                column: "CityGUID",
                value: new Guid("c4d9b351-3930-4b30-b9fe-cfec0a9622a4"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1079,
                column: "CityGUID",
                value: new Guid("56829624-30cd-4dd8-9a30-3734db717294"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1080,
                column: "CityGUID",
                value: new Guid("cada697c-db07-4156-b747-53b80849e023"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1081,
                column: "CityGUID",
                value: new Guid("6fd09374-9725-4981-8e1b-29f8569dc06f"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1082,
                column: "CityGUID",
                value: new Guid("56294879-dd8b-453a-9c33-6c281751d6b6"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1083,
                column: "CityGUID",
                value: new Guid("8239e878-9b5c-42ab-a088-3ef353b39d86"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1084,
                column: "CityGUID",
                value: new Guid("e7e0f0dd-be6c-422d-a2b9-f33e9870476c"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1085,
                column: "CityGUID",
                value: new Guid("2e248f1a-d5f3-4bbe-9cac-51002a835c38"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1086,
                column: "CityGUID",
                value: new Guid("f1860c99-5988-485c-8c60-1c8a12a3e809"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1087,
                column: "CityGUID",
                value: new Guid("233753e7-a494-4837-afde-333c92951d06"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1088,
                column: "CityGUID",
                value: new Guid("25acd50b-c5f1-4b95-9278-8e0abb44e680"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1089,
                column: "CityGUID",
                value: new Guid("e163645a-7611-43cb-95a8-eb176f2065ed"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1090,
                column: "CityGUID",
                value: new Guid("5da9a1fd-2849-4b75-b116-460556f0cf08"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1091,
                column: "CityGUID",
                value: new Guid("ab3929ad-7c0e-45e9-81db-f4263680699e"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1092,
                column: "CityGUID",
                value: new Guid("b2d58a93-b7c2-4694-850b-dc8f8e357901"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1093,
                column: "CityGUID",
                value: new Guid("bfad1b3a-b50e-4cd1-9aea-523c62e9db07"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1094,
                column: "CityGUID",
                value: new Guid("9ccab9a1-f86b-48fd-8dd0-9ba5cbcf9870"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1095,
                column: "CityGUID",
                value: new Guid("619dfbbb-c091-4c3d-a6d7-daf4d266da18"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1096,
                column: "CityGUID",
                value: new Guid("a1f79771-dad8-48c8-9aee-0e2a2fe97f6c"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1097,
                column: "CityGUID",
                value: new Guid("286b2ba1-c178-49b1-aa40-d21b11b4b23d"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1098,
                column: "CityGUID",
                value: new Guid("70720d71-533e-48b2-aa63-cc290866ec9e"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1099,
                column: "CityGUID",
                value: new Guid("a42b86f0-ae4b-452f-aa77-27eb7173ec2a"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1100,
                column: "CityGUID",
                value: new Guid("431b44b8-4331-42ab-b591-67eb5bdaec35"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1101,
                column: "CityGUID",
                value: new Guid("da43a87b-7ce3-460a-af2c-cc635c474c03"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1102,
                column: "CityGUID",
                value: new Guid("d82cbd04-a64d-4bad-bee2-0566c80b4579"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1103,
                column: "CityGUID",
                value: new Guid("ed0854df-ba22-4b63-82ab-90e3490a40c6"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1104,
                column: "CityGUID",
                value: new Guid("bf403548-a017-426a-a25c-d9af04e74a88"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1105,
                column: "CityGUID",
                value: new Guid("37da4e5e-c92d-44a3-a301-8785514ac23b"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1106,
                column: "CityGUID",
                value: new Guid("c0ddb53d-f228-44b7-865e-e6c09a562db0"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1107,
                column: "CityGUID",
                value: new Guid("e1cf4073-7087-4725-ab52-ada4c468e239"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1108,
                column: "CityGUID",
                value: new Guid("4a395106-4dbb-459a-95e3-b7c14c898954"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1109,
                column: "CityGUID",
                value: new Guid("e2d2cd4b-3000-4ccf-8f7f-c02b2846df43"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1110,
                column: "CityGUID",
                value: new Guid("2697989a-c070-4ad6-b152-3b564da153cd"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1111,
                column: "CityGUID",
                value: new Guid("96ae18e6-7fb4-4f31-8dd0-5edc9d53bbc7"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1112,
                column: "CityGUID",
                value: new Guid("68eb0a60-bf03-48e8-8251-101cec9a71e7"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1113,
                column: "CityGUID",
                value: new Guid("805e13c0-06fe-4e04-b4e4-d82ff94394c3"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1114,
                column: "CityGUID",
                value: new Guid("9ab3dcba-2dcd-4520-b844-f1f68acf038b"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1115,
                column: "CityGUID",
                value: new Guid("3bdb69fd-a33c-42ec-9620-2923f72cce85"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1116,
                column: "CityGUID",
                value: new Guid("935494b9-2c1f-483a-aa1c-27e465a58942"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1117,
                column: "CityGUID",
                value: new Guid("b64e3036-077e-4eea-abfa-7f03a582efb5"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1118,
                column: "CityGUID",
                value: new Guid("f6561f38-52c4-4480-9b65-362010a4764c"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1119,
                column: "CityGUID",
                value: new Guid("70c484ae-8334-4ddf-9edf-3203405e6030"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1120,
                column: "CityGUID",
                value: new Guid("4f2e00b8-7087-4531-9209-e8cd0937b58e"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1121,
                column: "CityGUID",
                value: new Guid("b98652b8-7edb-4eda-88fe-251a35f8df7b"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1122,
                column: "CityGUID",
                value: new Guid("839a1463-11bc-4c8b-8a27-2824edf9e77f"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1123,
                column: "CityGUID",
                value: new Guid("0b83a297-a102-451a-8cc8-223c9367de4e"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1124,
                column: "CityGUID",
                value: new Guid("ecb00b75-7818-4102-9f96-5a6ca8b09dc6"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1125,
                column: "CityGUID",
                value: new Guid("a0b3c6be-f602-408c-a216-6b907b46dcec"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1126,
                column: "CityGUID",
                value: new Guid("475dda53-b7ff-45c0-885a-80ade8a1e7cb"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1127,
                column: "CityGUID",
                value: new Guid("6660b819-f2b1-409f-bb55-1adf8c3e9b5e"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1128,
                column: "CityGUID",
                value: new Guid("0195370e-ee02-438e-8ec9-ff11822a8c8b"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1129,
                column: "CityGUID",
                value: new Guid("4cc79f95-1a3a-4ac1-92b2-b58395a6f826"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1130,
                column: "CityGUID",
                value: new Guid("90cb3270-8088-4db9-b844-5e1a0bde87e8"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1131,
                column: "CityGUID",
                value: new Guid("eb61307d-c8a3-4c65-9be2-902c454d0fd2"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1132,
                column: "CityGUID",
                value: new Guid("6c41d419-6926-4072-8a26-7af6d66b4d0c"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1133,
                column: "CityGUID",
                value: new Guid("03a3a834-7566-428c-8ffd-34ef8cac3a92"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1134,
                column: "CityGUID",
                value: new Guid("98f9dc4a-9e39-49ad-9bfb-096c140bd910"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1135,
                column: "CityGUID",
                value: new Guid("73848377-107f-4f98-b652-d263035764a9"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1136,
                column: "CityGUID",
                value: new Guid("7bbd9f84-24e6-40a6-bd58-d558403f8ee5"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1137,
                column: "CityGUID",
                value: new Guid("c63cb144-f264-487e-a462-a66d2ce97b5d"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1138,
                column: "CityGUID",
                value: new Guid("ca272224-efed-49aa-ab76-85ec179ee032"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1139,
                column: "CityGUID",
                value: new Guid("b47d52dc-a44e-438b-9228-60f32c525703"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1140,
                column: "CityGUID",
                value: new Guid("e91695b6-511c-44f7-a47d-d1c4510530ff"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1141,
                column: "CityGUID",
                value: new Guid("6ee43c07-7a47-42de-b9a5-4a4436ad0972"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1142,
                column: "CityGUID",
                value: new Guid("d85819ec-8f44-4b57-b51f-ba2171523308"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1143,
                column: "CityGUID",
                value: new Guid("f48483c9-d747-4ac3-bbb6-4ecd2495be51"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1144,
                column: "CityGUID",
                value: new Guid("d3cde7c0-8f10-4e0c-bc68-b0bbfc0e69e4"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1145,
                column: "CityGUID",
                value: new Guid("66e39c66-5611-47b1-99f7-75a5beeb2a6f"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1146,
                column: "CityGUID",
                value: new Guid("e92a4e4a-fe89-49e8-ad6a-a8883c5a95a5"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1147,
                column: "CityGUID",
                value: new Guid("c1a31f4c-a55a-4466-84ea-790db14bb2e0"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1148,
                column: "CityGUID",
                value: new Guid("448ac33b-a928-446e-b7de-ef5a96bda9f1"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1149,
                column: "CityGUID",
                value: new Guid("f397ccae-3df9-4920-a738-b194d530fd59"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1150,
                column: "CityGUID",
                value: new Guid("7814fd8d-0287-426c-b18a-acd82f3eb583"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1151,
                column: "CityGUID",
                value: new Guid("8bfa4109-55a3-4ab6-807a-1157708fdf54"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1152,
                column: "CityGUID",
                value: new Guid("b792345f-6c9f-4e4a-acd8-70bb105e6b03"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1153,
                column: "CityGUID",
                value: new Guid("cf430b91-4af7-4d46-9dc3-06c7c485e8c1"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1154,
                column: "CityGUID",
                value: new Guid("c3c25440-e5af-4208-953a-952406359ab1"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1155,
                column: "CityGUID",
                value: new Guid("2e53fc03-38b3-4aeb-9c22-4c71aa07b312"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1156,
                column: "CityGUID",
                value: new Guid("0b2449a6-7b01-41d8-a2ff-dea361bc5162"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1157,
                column: "CityGUID",
                value: new Guid("1e8f4423-7112-4d88-aaf2-e76f12cffc25"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1158,
                column: "CityGUID",
                value: new Guid("4491ea1d-ce73-4317-88a2-4ecca9e78fe7"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1159,
                column: "CityGUID",
                value: new Guid("a7f6e574-f105-49e4-8a5f-066928e4a000"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1160,
                column: "CityGUID",
                value: new Guid("4680020b-7cf4-4f34-8370-40f52114a569"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1161,
                column: "CityGUID",
                value: new Guid("b6d73b8f-3544-4fb6-9abb-8904875d91ea"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1162,
                column: "CityGUID",
                value: new Guid("cf29a67d-74f5-4677-988e-88d741031c02"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1163,
                column: "CityGUID",
                value: new Guid("1832b406-3a02-491a-89f1-80dcd0212b39"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1164,
                column: "CityGUID",
                value: new Guid("bf280ca9-20ab-4742-ba34-5db313306b58"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1165,
                column: "CityGUID",
                value: new Guid("b05adcfc-6097-44f3-bd96-697ba4d7b835"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1166,
                column: "CityGUID",
                value: new Guid("ae30e11b-9552-4afa-9b29-a004a3940d7e"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1167,
                column: "CityGUID",
                value: new Guid("4ec0badf-95e3-496e-9057-017e8476eb92"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1168,
                column: "CityGUID",
                value: new Guid("21c67878-26dc-47d8-b502-a486dee7c893"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1169,
                column: "CityGUID",
                value: new Guid("59f0ce5a-71ab-435f-94f9-c5a327f97136"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1170,
                column: "CityGUID",
                value: new Guid("a6884f7b-8c0f-448d-8d40-6b84fb079640"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1171,
                column: "CityGUID",
                value: new Guid("08ba4bd3-ec48-442d-8d40-b90b442b0e56"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1172,
                column: "CityGUID",
                value: new Guid("31b718ae-4649-4bf1-b341-3a0561e1c9a9"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1173,
                column: "CityGUID",
                value: new Guid("00fe82ae-009e-41b7-9d36-b2183b73f886"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1174,
                column: "CityGUID",
                value: new Guid("8e16b5c9-0be0-45fd-aae2-08b24674f2b7"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1175,
                column: "CityGUID",
                value: new Guid("96489454-a02f-4532-a727-42cca3c21675"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1176,
                column: "CityGUID",
                value: new Guid("b5ec7aa0-a3a2-4d7d-98d3-f6f502a525ba"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1177,
                column: "CityGUID",
                value: new Guid("0e3804fc-68fa-48ec-97d0-6f3240614d0d"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1178,
                column: "CityGUID",
                value: new Guid("3b124d86-4471-428c-ad99-efd25665509c"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1179,
                column: "CityGUID",
                value: new Guid("71ab2795-5153-4904-ad60-bfabbdbe0d5d"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1180,
                column: "CityGUID",
                value: new Guid("b6280668-5b93-4612-a165-4e0df832ddc2"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1181,
                column: "CityGUID",
                value: new Guid("62c8a454-b2fb-4b3e-b065-61e690ed81c0"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1182,
                column: "CityGUID",
                value: new Guid("d27a65bd-36ad-429f-8677-afb1b52892b6"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1183,
                column: "CityGUID",
                value: new Guid("3893f68c-4ae0-4910-b9af-661f7b448a8f"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1184,
                column: "CityGUID",
                value: new Guid("fdae8613-1ed3-438c-9505-80ee07b2f8b1"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1185,
                column: "CityGUID",
                value: new Guid("47ee56ae-e178-4c86-9a56-cbde20ab390a"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1186,
                column: "CityGUID",
                value: new Guid("92be0c5d-f48d-48fa-a8ea-26358fc069e7"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1187,
                column: "CityGUID",
                value: new Guid("5b4a3721-9d88-49fa-bb5a-84c736c7e7ea"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1188,
                column: "CityGUID",
                value: new Guid("3c9fb622-2c1c-4336-8933-2e46b6a95bac"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1189,
                column: "CityGUID",
                value: new Guid("1e265a3a-5744-4719-ba65-866b2f808af7"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1190,
                column: "CityGUID",
                value: new Guid("b1f1d6f4-fcfc-4ecd-bbe8-aa1f88986615"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1191,
                column: "CityGUID",
                value: new Guid("bc4c2b23-46d0-4a45-8519-def742d0ac06"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1192,
                column: "CityGUID",
                value: new Guid("344f5349-8832-471c-9c99-e79c75ae9cde"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1193,
                column: "CityGUID",
                value: new Guid("b9eba4d3-974d-4469-91c4-9690fc0b5d76"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1194,
                column: "CityGUID",
                value: new Guid("9eba4c2a-af69-4e49-967b-74e53ddbf215"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1195,
                column: "CityGUID",
                value: new Guid("a54099a4-5e5f-416a-b13c-4df1586b6a2f"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1196,
                column: "CityGUID",
                value: new Guid("137d6685-6497-447f-bbd5-ae304984ca20"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1197,
                column: "CityGUID",
                value: new Guid("597161e1-8c6b-4f13-a3be-95170af21671"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1198,
                column: "CityGUID",
                value: new Guid("b0b13e0b-00ff-4bf1-8b4a-21fe958a7a70"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1199,
                column: "CityGUID",
                value: new Guid("85abd607-f15f-41f8-90fb-4905d6af2580"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1200,
                column: "CityGUID",
                value: new Guid("b3552ee0-2a82-47ab-9fae-48a8e6c5ba23"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1201,
                column: "CityGUID",
                value: new Guid("f8254934-3f88-4c79-9da7-39338df96bc0"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1202,
                column: "CityGUID",
                value: new Guid("fedec3a8-9f0f-457c-b95f-31dd3525e396"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1203,
                column: "CityGUID",
                value: new Guid("aa371d2a-74d4-49b5-b852-e02564b5f973"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1204,
                column: "CityGUID",
                value: new Guid("d093aab9-602b-4c86-a051-473bb1e91215"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1205,
                column: "CityGUID",
                value: new Guid("04c369a9-10b8-4fbe-bfe5-3e6ec21416c2"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1206,
                column: "CityGUID",
                value: new Guid("49a2e437-2cc4-4fe3-8a84-60f65a7360fa"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1207,
                column: "CityGUID",
                value: new Guid("821f8da3-0a71-4364-9f01-29cd92d753d3"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1208,
                column: "CityGUID",
                value: new Guid("4361d114-c62e-4026-9d14-4a070d034f93"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1209,
                column: "CityGUID",
                value: new Guid("66181ba2-d70d-4497-a50f-7b4cf13673f1"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1210,
                column: "CityGUID",
                value: new Guid("cc3155dc-6d81-4d8a-9e42-1607e4cb2c92"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1211,
                column: "CityGUID",
                value: new Guid("70576daf-44df-44b8-9c35-d3ed6baf543e"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1212,
                column: "CityGUID",
                value: new Guid("58ada605-9ce4-4cee-ad23-b810f9508dcb"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1213,
                column: "CityGUID",
                value: new Guid("9321c230-ddb8-4c69-849f-f8a272e1bfc0"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1214,
                column: "CityGUID",
                value: new Guid("6ae757dc-5336-48a6-b1e3-904a3cd4ddc8"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1215,
                column: "CityGUID",
                value: new Guid("cf2a5e56-d6dd-493c-9f8a-978d4772aeb3"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1216,
                column: "CityGUID",
                value: new Guid("e19ecb03-15a3-4305-b9d0-b9714117dc45"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1217,
                column: "CityGUID",
                value: new Guid("b5260655-5e00-4f7f-821a-731b056d12b6"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1218,
                column: "CityGUID",
                value: new Guid("2e6ce902-32d0-4bee-b714-88aeaf48e548"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1219,
                column: "CityGUID",
                value: new Guid("3ee7f76d-1669-4ac3-8571-35c6b5208b2f"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1220,
                column: "CityGUID",
                value: new Guid("077610d5-0c6f-44f0-8d7f-f3480d7c4414"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1221,
                column: "CityGUID",
                value: new Guid("7b5f7aef-ff62-49ee-8c5d-0cc25915300e"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1222,
                column: "CityGUID",
                value: new Guid("62b85308-2459-47ce-8ef0-af5686c4e469"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1223,
                column: "CityGUID",
                value: new Guid("15b6a5c7-ee1d-4423-8a54-1a8971babac2"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1224,
                column: "CityGUID",
                value: new Guid("48397b96-e825-467b-87a7-f34147af4ed6"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1225,
                column: "CityGUID",
                value: new Guid("efa7869e-3e42-4276-b5a6-5a56812ca5ca"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1226,
                column: "CityGUID",
                value: new Guid("2565fb19-6c81-4606-a1a1-b5c9e43608ad"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1227,
                column: "CityGUID",
                value: new Guid("09357f0a-31d5-4a35-ac4a-6f2e770f1858"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1228,
                column: "CityGUID",
                value: new Guid("68637465-dae2-471f-b7ea-afc0b16c1e1c"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1229,
                column: "CityGUID",
                value: new Guid("7cf74731-2a63-4a22-8b7a-eef3c3ff88c7"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1230,
                column: "CityGUID",
                value: new Guid("f7be7bd3-0543-452d-91a2-b3758e9dad3b"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1231,
                column: "CityGUID",
                value: new Guid("06fc8ec3-659d-42b7-9eae-eb93f1a44e41"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1232,
                column: "CityGUID",
                value: new Guid("dc67686c-d5c1-4d6b-845f-e7e725941cb2"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1233,
                column: "CityGUID",
                value: new Guid("45773748-cdf0-4078-b8b3-1bf63b6840da"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1234,
                column: "CityGUID",
                value: new Guid("76f40d84-5e19-4878-9d63-6a0d631b4b2b"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1235,
                column: "CityGUID",
                value: new Guid("db7f5c7d-f383-4e80-840d-113fb63564fd"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1236,
                column: "CityGUID",
                value: new Guid("71596995-68fe-4c99-8cf7-d374baa276b8"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1237,
                column: "CityGUID",
                value: new Guid("077da544-95a6-4228-9fa0-34240a3bfd6f"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1238,
                column: "CityGUID",
                value: new Guid("bcf8bbf4-eab6-435a-91a0-76380a8e7c62"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1239,
                column: "CityGUID",
                value: new Guid("ebdc64da-82f3-4b73-93ef-248e9d1dbfbc"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1240,
                column: "CityGUID",
                value: new Guid("93a2c5aa-6e84-428d-a95a-6d6b07e6f712"));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityID",
                keyValue: 1241,
                column: "CityGUID",
                value: new Guid("abacf388-0e92-4126-b549-8adacaf4aaa3"));

            migrationBuilder.UpdateData(
                table: "Client",
                keyColumn: "ClientID",
                keyValue: 1,
                columns: new[] { "ClientGUID", "ModifiedDate" },
                values: new object[] { new Guid("fbe3f6f2-6770-4cb8-bb98-791dc01d0677"), new DateTime(2020, 5, 31, 15, 29, 22, 155, DateTimeKind.Local).AddTicks(4823) });

            migrationBuilder.UpdateData(
                table: "Code",
                keyColumn: "CodeID",
                keyValue: 1,
                column: "CodeGUID",
                value: new Guid("fc20e91f-1eb1-4912-87be-1708f2706367"));

            migrationBuilder.UpdateData(
                table: "Code",
                keyColumn: "CodeID",
                keyValue: 2,
                column: "CodeGUID",
                value: new Guid("3f009296-db7a-4fde-a659-4ca1541a2504"));

            migrationBuilder.UpdateData(
                table: "Code",
                keyColumn: "CodeID",
                keyValue: 3,
                column: "CodeGUID",
                value: new Guid("3209341a-07d4-437b-9301-2d0f909ad713"));

            migrationBuilder.UpdateData(
                table: "Code",
                keyColumn: "CodeID",
                keyValue: 4,
                column: "CodeGUID",
                value: new Guid("09cb21ac-d99e-42ba-904d-337bdd561e6e"));

            migrationBuilder.UpdateData(
                table: "Code",
                keyColumn: "CodeID",
                keyValue: 5,
                column: "CodeGUID",
                value: new Guid("2383b70e-f41f-4b67-b0c9-c48706a70a46"));

            migrationBuilder.UpdateData(
                table: "Code",
                keyColumn: "CodeID",
                keyValue: 6,
                column: "CodeGUID",
                value: new Guid("cf5a1929-db68-43d6-8fc7-e3b7ccc51678"));

            migrationBuilder.UpdateData(
                table: "Code",
                keyColumn: "CodeID",
                keyValue: 7,
                column: "CodeGUID",
                value: new Guid("2b451e4c-c9b8-415a-bcb4-05da15447b89"));

            migrationBuilder.UpdateData(
                table: "Code",
                keyColumn: "CodeID",
                keyValue: 8,
                column: "CodeGUID",
                value: new Guid("6e48b657-2c83-4481-a9c5-009ffe10158b"));

            migrationBuilder.UpdateData(
                table: "Code",
                keyColumn: "CodeID",
                keyValue: 9,
                column: "CodeGUID",
                value: new Guid("b5d74bda-849b-427c-a6e0-463c1e5f615b"));

            migrationBuilder.UpdateData(
                table: "Code",
                keyColumn: "CodeID",
                keyValue: 10,
                column: "CodeGUID",
                value: new Guid("10afdac9-a075-40e1-9207-1813befcf4d6"));

            migrationBuilder.UpdateData(
                table: "Code",
                keyColumn: "CodeID",
                keyValue: 11,
                column: "CodeGUID",
                value: new Guid("2b9d07c8-5535-495e-8557-da32acb58600"));

            migrationBuilder.UpdateData(
                table: "Code",
                keyColumn: "CodeID",
                keyValue: 12,
                column: "CodeGUID",
                value: new Guid("61960336-e912-4658-9ab3-59f4c58e0b23"));

            migrationBuilder.UpdateData(
                table: "Code",
                keyColumn: "CodeID",
                keyValue: 13,
                column: "CodeGUID",
                value: new Guid("46a09d81-c57f-4655-a8f5-027c66a6cfb1"));

            migrationBuilder.UpdateData(
                table: "Code",
                keyColumn: "CodeID",
                keyValue: 14,
                column: "CodeGUID",
                value: new Guid("91b3cdab-39c1-40fb-b077-a2d6e611f50a"));

            migrationBuilder.UpdateData(
                table: "Code",
                keyColumn: "CodeID",
                keyValue: 15,
                column: "CodeGUID",
                value: new Guid("959b10a3-b8ed-4a9d-bdf3-17ec9b2ceb15"));

            migrationBuilder.UpdateData(
                table: "Code",
                keyColumn: "CodeID",
                keyValue: 16,
                column: "CodeGUID",
                value: new Guid("a05c4f54-5999-42b9-a36f-6a04aa7cd476"));

            migrationBuilder.UpdateData(
                table: "Code",
                keyColumn: "CodeID",
                keyValue: 17,
                column: "CodeGUID",
                value: new Guid("ccef9d1f-343b-442a-a041-1908e4cbc235"));

            migrationBuilder.UpdateData(
                table: "CodeGroup",
                keyColumn: "CodeGroupID",
                keyValue: 1,
                column: "CodeGroupGUID",
                value: new Guid("5b739a57-164e-4b39-8b1c-1129bc9d8991"));

            migrationBuilder.UpdateData(
                table: "CodeGroup",
                keyColumn: "CodeGroupID",
                keyValue: 2,
                column: "CodeGroupGUID",
                value: new Guid("2d9c9e83-39eb-42d7-b71f-ef26002c8470"));

            migrationBuilder.UpdateData(
                table: "CodeGroup",
                keyColumn: "CodeGroupID",
                keyValue: 3,
                column: "CodeGroupGUID",
                value: new Guid("a76da3ba-d12a-42c4-b7e1-732d0990af70"));

            migrationBuilder.UpdateData(
                table: "CodeGroup",
                keyColumn: "CodeGroupID",
                keyValue: 4,
                column: "CodeGroupGUID",
                value: new Guid("39c56245-8e42-4cef-8ddd-5e4c17782e8b"));

            migrationBuilder.UpdateData(
                table: "CodeGroup",
                keyColumn: "CodeGroupID",
                keyValue: 5,
                column: "CodeGroupGUID",
                value: new Guid("7e9db57a-0c09-47ff-98b5-f49363beff67"));

            migrationBuilder.UpdateData(
                table: "CodeGroup",
                keyColumn: "CodeGroupID",
                keyValue: 6,
                column: "CodeGroupGUID",
                value: new Guid("107a7244-6e66-4369-8ba6-dfb0636642c4"));

            migrationBuilder.UpdateData(
                table: "Contractor",
                keyColumn: "ContractorID",
                keyValue: 1,
                columns: new[] { "ContractorGUID", "ModifiedDate" },
                values: new object[] { new Guid("90d46f9f-ef04-437f-a27c-4f0a44df01f7"), new DateTime(2020, 5, 31, 15, 29, 22, 156, DateTimeKind.Local).AddTicks(5208) });

            migrationBuilder.UpdateData(
                table: "Contractor",
                keyColumn: "ContractorID",
                keyValue: 2,
                columns: new[] { "ContractorGUID", "ModifiedDate" },
                values: new object[] { new Guid("5d92c92e-4865-4c17-99cb-a43d8d95ccfc"), new DateTime(2020, 5, 31, 15, 29, 22, 156, DateTimeKind.Local).AddTicks(5922) });

            migrationBuilder.UpdateData(
                table: "ContractorCategory",
                keyColumn: "ContractorCategoryID",
                keyValue: 1,
                column: "ContractorCategoryGUID",
                value: new Guid("ff00eb64-28c5-432a-bb85-e62a3e49c5ea"));

            migrationBuilder.UpdateData(
                table: "ContractorCategory",
                keyColumn: "ContractorCategoryID",
                keyValue: 2,
                column: "ContractorCategoryGUID",
                value: new Guid("6e6cad59-eb11-4b9a-81e4-01cf70ab408b"));

            migrationBuilder.UpdateData(
                table: "ContractorCategory",
                keyColumn: "ContractorCategoryID",
                keyValue: 3,
                column: "ContractorCategoryGUID",
                value: new Guid("27b1400b-3c9e-4c30-b2e3-e29b4683ccd5"));

            migrationBuilder.UpdateData(
                table: "ContractorCategory",
                keyColumn: "ContractorCategoryID",
                keyValue: 4,
                column: "ContractorCategoryGUID",
                value: new Guid("9981ac32-1e7d-4f7e-adf4-fb374f0f2165"));

            migrationBuilder.UpdateData(
                table: "ContractorCategory",
                keyColumn: "ContractorCategoryID",
                keyValue: 5,
                column: "ContractorCategoryGUID",
                value: new Guid("f02c0ebf-9ae0-4dff-8ddd-9ffddb6605cc"));

            migrationBuilder.UpdateData(
                table: "ContractorCategory",
                keyColumn: "ContractorCategoryID",
                keyValue: 6,
                column: "ContractorCategoryGUID",
                value: new Guid("8c787195-4463-4dba-822c-7fa6d9f1b522"));

            migrationBuilder.UpdateData(
                table: "ContractorCategory",
                keyColumn: "ContractorCategoryID",
                keyValue: 7,
                column: "ContractorCategoryGUID",
                value: new Guid("d65262da-7f25-4c76-ab52-b2940f4f30fe"));

            migrationBuilder.UpdateData(
                table: "ContractorCategory",
                keyColumn: "ContractorCategoryID",
                keyValue: 8,
                column: "ContractorCategoryGUID",
                value: new Guid("a27bae18-fa4f-4772-96cd-e1b642124fb6"));

            migrationBuilder.UpdateData(
                table: "ContractorCategory",
                keyColumn: "ContractorCategoryID",
                keyValue: 9,
                column: "ContractorCategoryGUID",
                value: new Guid("1e2472f0-b9d1-46f9-aafa-4ddc7df0e07c"));

            migrationBuilder.UpdateData(
                table: "ContractorCategory",
                keyColumn: "ContractorCategoryID",
                keyValue: 10,
                column: "ContractorCategoryGUID",
                value: new Guid("aea85e1d-9772-422b-863e-481dd964c5bf"));

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderID",
                keyValue: 1,
                columns: new[] { "ModifiedDate", "OrderGUID" },
                values: new object[] { new DateTime(2020, 5, 31, 15, 29, 22, 157, DateTimeKind.Local).AddTicks(5950), new Guid("e763b9e9-f39c-4a92-94e4-6555edc85d50") });

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderID",
                keyValue: 2,
                columns: new[] { "ModifiedDate", "OrderGUID" },
                values: new object[] { new DateTime(2020, 5, 31, 15, 29, 22, 157, DateTimeKind.Local).AddTicks(7227), new Guid("74559ca5-8da9-4b73-b558-535f57484aeb") });

            migrationBuilder.UpdateData(
                table: "OrderRequest",
                keyColumn: "OrderRequestID",
                keyValue: 1,
                columns: new[] { "IsAllow", "ModifiedDate", "OrderRequestGUID" },
                values: new object[] { true, new DateTime(2020, 5, 31, 15, 29, 22, 158, DateTimeKind.Local).AddTicks(2732), new Guid("4840c276-52db-46db-a208-959844a3e9f3") });

            migrationBuilder.UpdateData(
                table: "Province",
                keyColumn: "ProvinceID",
                keyValue: 1,
                column: "ProvinceGUID",
                value: new Guid("30254e83-5493-4f29-8322-6a3d3bf71cb6"));

            migrationBuilder.UpdateData(
                table: "Province",
                keyColumn: "ProvinceID",
                keyValue: 2,
                column: "ProvinceGUID",
                value: new Guid("c33b4349-fee7-4e49-b0a2-7a2923e67704"));

            migrationBuilder.UpdateData(
                table: "Province",
                keyColumn: "ProvinceID",
                keyValue: 3,
                column: "ProvinceGUID",
                value: new Guid("b97bbb33-fd5c-45bd-9f35-28714d1d768a"));

            migrationBuilder.UpdateData(
                table: "Province",
                keyColumn: "ProvinceID",
                keyValue: 4,
                column: "ProvinceGUID",
                value: new Guid("393c0a1e-db98-4497-bd1a-4047c5ba00d5"));

            migrationBuilder.UpdateData(
                table: "Province",
                keyColumn: "ProvinceID",
                keyValue: 5,
                column: "ProvinceGUID",
                value: new Guid("b483c2e4-edaa-427f-aff6-465287645c12"));

            migrationBuilder.UpdateData(
                table: "Province",
                keyColumn: "ProvinceID",
                keyValue: 6,
                column: "ProvinceGUID",
                value: new Guid("ddc2ca76-7faf-493b-88cb-97d6907edadf"));

            migrationBuilder.UpdateData(
                table: "Province",
                keyColumn: "ProvinceID",
                keyValue: 7,
                column: "ProvinceGUID",
                value: new Guid("7bf8f1a6-8c39-4ad0-9b48-e9e92fc875b1"));

            migrationBuilder.UpdateData(
                table: "Province",
                keyColumn: "ProvinceID",
                keyValue: 8,
                column: "ProvinceGUID",
                value: new Guid("e672e69d-9e41-48b7-b2a0-ba8c3430ee97"));

            migrationBuilder.UpdateData(
                table: "Province",
                keyColumn: "ProvinceID",
                keyValue: 9,
                column: "ProvinceGUID",
                value: new Guid("9b676f50-696e-4b1a-b91b-0fa42b99c08c"));

            migrationBuilder.UpdateData(
                table: "Province",
                keyColumn: "ProvinceID",
                keyValue: 10,
                column: "ProvinceGUID",
                value: new Guid("8d067472-4977-4d89-b75a-6940246421d6"));

            migrationBuilder.UpdateData(
                table: "Province",
                keyColumn: "ProvinceID",
                keyValue: 11,
                column: "ProvinceGUID",
                value: new Guid("e198747f-7359-4237-984c-9f77aadeee0f"));

            migrationBuilder.UpdateData(
                table: "Province",
                keyColumn: "ProvinceID",
                keyValue: 12,
                column: "ProvinceGUID",
                value: new Guid("76007847-81fe-423b-af88-23d48d612d64"));

            migrationBuilder.UpdateData(
                table: "Province",
                keyColumn: "ProvinceID",
                keyValue: 13,
                column: "ProvinceGUID",
                value: new Guid("309f5a9c-a0ad-45fe-b7c7-63b60c81094b"));

            migrationBuilder.UpdateData(
                table: "Province",
                keyColumn: "ProvinceID",
                keyValue: 14,
                column: "ProvinceGUID",
                value: new Guid("5e58491a-5646-486e-bf3c-e2e024e2786c"));

            migrationBuilder.UpdateData(
                table: "Province",
                keyColumn: "ProvinceID",
                keyValue: 15,
                column: "ProvinceGUID",
                value: new Guid("ecdc6046-d08d-45bb-817b-ff5c95c8c3e8"));

            migrationBuilder.UpdateData(
                table: "Province",
                keyColumn: "ProvinceID",
                keyValue: 16,
                column: "ProvinceGUID",
                value: new Guid("ea9f84d6-43c2-4dc3-aedb-8257d6277984"));

            migrationBuilder.UpdateData(
                table: "Province",
                keyColumn: "ProvinceID",
                keyValue: 17,
                column: "ProvinceGUID",
                value: new Guid("ec154207-a51d-4089-9476-c8501bf8e2da"));

            migrationBuilder.UpdateData(
                table: "Province",
                keyColumn: "ProvinceID",
                keyValue: 18,
                column: "ProvinceGUID",
                value: new Guid("4c09413b-512c-469f-8208-c103c6eb7249"));

            migrationBuilder.UpdateData(
                table: "Province",
                keyColumn: "ProvinceID",
                keyValue: 19,
                column: "ProvinceGUID",
                value: new Guid("7a8db7a6-52d7-40d7-88f4-b8ca5812d7bc"));

            migrationBuilder.UpdateData(
                table: "Province",
                keyColumn: "ProvinceID",
                keyValue: 20,
                column: "ProvinceGUID",
                value: new Guid("914f2d87-172a-4685-ad78-fff4f7b19ecf"));

            migrationBuilder.UpdateData(
                table: "Province",
                keyColumn: "ProvinceID",
                keyValue: 21,
                column: "ProvinceGUID",
                value: new Guid("af59fd1f-2810-4853-b838-ed3ff7531b83"));

            migrationBuilder.UpdateData(
                table: "Province",
                keyColumn: "ProvinceID",
                keyValue: 22,
                column: "ProvinceGUID",
                value: new Guid("c916885e-a973-442a-978d-474eae2a6e2e"));

            migrationBuilder.UpdateData(
                table: "Province",
                keyColumn: "ProvinceID",
                keyValue: 23,
                column: "ProvinceGUID",
                value: new Guid("29a89e91-9bad-4dd9-b705-7b64b804cc83"));

            migrationBuilder.UpdateData(
                table: "Province",
                keyColumn: "ProvinceID",
                keyValue: 24,
                column: "ProvinceGUID",
                value: new Guid("8366b82d-92fa-485d-9c85-f0d00e5ad0fe"));

            migrationBuilder.UpdateData(
                table: "Province",
                keyColumn: "ProvinceID",
                keyValue: 25,
                column: "ProvinceGUID",
                value: new Guid("24d44963-57d7-44f0-8892-25d4ca36ea0f"));

            migrationBuilder.UpdateData(
                table: "Province",
                keyColumn: "ProvinceID",
                keyValue: 26,
                column: "ProvinceGUID",
                value: new Guid("754068a5-a946-4460-bc5b-287011924a1b"));

            migrationBuilder.UpdateData(
                table: "Province",
                keyColumn: "ProvinceID",
                keyValue: 27,
                column: "ProvinceGUID",
                value: new Guid("204d06b1-1d3c-429c-afee-1ee57941efe2"));

            migrationBuilder.UpdateData(
                table: "Province",
                keyColumn: "ProvinceID",
                keyValue: 28,
                column: "ProvinceGUID",
                value: new Guid("de68479d-355f-4e4a-801a-27bab7d329bd"));

            migrationBuilder.UpdateData(
                table: "Province",
                keyColumn: "ProvinceID",
                keyValue: 29,
                column: "ProvinceGUID",
                value: new Guid("0fa47c40-239e-4bc3-99a9-151f8c636c7a"));

            migrationBuilder.UpdateData(
                table: "Province",
                keyColumn: "ProvinceID",
                keyValue: 30,
                column: "ProvinceGUID",
                value: new Guid("4902d48a-3b31-4785-938d-fe0003997032"));

            migrationBuilder.UpdateData(
                table: "Province",
                keyColumn: "ProvinceID",
                keyValue: 31,
                column: "ProvinceGUID",
                value: new Guid("b3d1ac71-3d8d-4644-bd68-e79afb7e99db"));

            migrationBuilder.UpdateData(
                table: "Role",
                keyColumn: "RoleID",
                keyValue: 1,
                columns: new[] { "ModifiedDate", "RoleGUID" },
                values: new object[] { new DateTime(2020, 5, 31, 15, 29, 22, 152, DateTimeKind.Local).AddTicks(8668), new Guid("75c866e0-bcce-4038-972c-a2dba6f54315") });

            migrationBuilder.UpdateData(
                table: "Role",
                keyColumn: "RoleID",
                keyValue: 2,
                columns: new[] { "ModifiedDate", "RoleGUID" },
                values: new object[] { new DateTime(2020, 5, 31, 15, 29, 22, 152, DateTimeKind.Local).AddTicks(9693), new Guid("ff48363b-4cb9-4649-b43f-b0b941e1fb03") });

            migrationBuilder.UpdateData(
                table: "Role",
                keyColumn: "RoleID",
                keyValue: 3,
                columns: new[] { "ModifiedDate", "RoleGUID" },
                values: new object[] { new DateTime(2020, 5, 31, 15, 29, 22, 152, DateTimeKind.Local).AddTicks(9724), new Guid("649181f1-ba55-4998-8cef-bf17848d353c") });

            migrationBuilder.UpdateData(
                table: "SMSProviderConfiguration",
                keyColumn: "SMSProviderConfigurationID",
                keyValue: 1,
                columns: new[] { "ModifiedDate", "SMSProviderConfigurationGUID" },
                values: new object[] { new DateTime(2020, 5, 31, 15, 29, 22, 148, DateTimeKind.Local).AddTicks(112), new Guid("cd0a4f5f-020c-43e3-8ce2-cf505a90a0ec") });

            migrationBuilder.UpdateData(
                table: "SMSSetting",
                keyColumn: "SMSSettingID",
                keyValue: 1,
                columns: new[] { "ModifiedDate", "SMSSettingGUID" },
                values: new object[] { new DateTime(2020, 5, 31, 15, 29, 22, 151, DateTimeKind.Local).AddTicks(8074), new Guid("97a9cf05-865b-4553-8b48-bf0e67ac4ef2") });

            migrationBuilder.UpdateData(
                table: "SMSTemplate",
                keyColumn: "SMSTemplateID",
                keyValue: 1,
                columns: new[] { "ModifiedDate", "SMSTemplateGUID" },
                values: new object[] { new DateTime(2020, 5, 31, 15, 29, 22, 152, DateTimeKind.Local).AddTicks(2989), new Guid("37078822-c939-4e93-9e5b-2e056e34938f") });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserID",
                keyValue: 1,
                columns: new[] { "IsActive", "IsRegister", "ModifiedDate", "RegisteredDate", "UserGUID" },
                values: new object[] { true, true, new DateTime(2020, 5, 31, 15, 29, 22, 154, DateTimeKind.Local).AddTicks(4094), new DateTime(2020, 5, 31, 15, 29, 22, 154, DateTimeKind.Local).AddTicks(3538), new Guid("ec4ad1b4-dc7a-4048-887f-482333415571") });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserID",
                keyValue: 2,
                columns: new[] { "IsActive", "IsRegister", "ModifiedDate", "RegisteredDate", "UserGUID" },
                values: new object[] { true, true, new DateTime(2020, 5, 31, 15, 29, 22, 154, DateTimeKind.Local).AddTicks(6440), new DateTime(2020, 5, 31, 15, 29, 22, 154, DateTimeKind.Local).AddTicks(6418), new Guid("031ce13e-678a-4fb5-97b5-69fa42d85de1") });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserID",
                keyValue: 3,
                columns: new[] { "IsActive", "IsRegister", "ModifiedDate", "RegisteredDate", "UserGUID" },
                values: new object[] { true, true, new DateTime(2020, 5, 31, 15, 29, 22, 154, DateTimeKind.Local).AddTicks(6483), new DateTime(2020, 5, 31, 15, 29, 22, 154, DateTimeKind.Local).AddTicks(6479), new Guid("78d16ba2-a83c-4479-8c49-63c7a2c899b1") });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserID",
                keyValue: 4,
                columns: new[] { "IsActive", "IsRegister", "ModifiedDate", "RegisteredDate", "UserGUID" },
                values: new object[] { true, true, new DateTime(2020, 5, 31, 15, 29, 22, 154, DateTimeKind.Local).AddTicks(6496), new DateTime(2020, 5, 31, 15, 29, 22, 154, DateTimeKind.Local).AddTicks(6493), new Guid("cdd61d0e-16f1-4b2e-8799-1d0a0e339b3b") });
        }
    }
}
