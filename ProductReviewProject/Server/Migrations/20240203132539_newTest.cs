using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProductReviewProject.Server.Migrations
{
    /// <inheritdoc />
    public partial class newTest : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ec514be6-a486-48c7-b66b-ffad4f4a2920", "AQAAAAIAAYagAAAAEKlfWX6SIbtvy0igj1jVdHwBp2hwUpYVkUtrGBU13EjYomKJ2lqRPNQ2Ej3DumDyOw==", "7ad65ee3-617c-4f75-b569-18d767e43f34" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5505fb59-d3a3-48fa-97c3-cca7fb06e101", "AQAAAAIAAYagAAAAEB4XszoBlyKbqOj1RBJaWoKGaX1qNaC3CwfaCPmDvfZWfYCUFNh1lAcGuDHJkanLAQ==", "3927757d-e05b-492e-95c0-5ddd97823322" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 3, 21, 25, 39, 278, DateTimeKind.Local).AddTicks(8549), new DateTime(2024, 2, 3, 21, 25, 39, 278, DateTimeKind.Local).AddTicks(8551) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 3, 21, 25, 39, 278, DateTimeKind.Local).AddTicks(8554), new DateTime(2024, 2, 3, 21, 25, 39, 278, DateTimeKind.Local).AddTicks(8555) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 3, 21, 25, 39, 277, DateTimeKind.Local).AddTicks(9752), new DateTime(2024, 2, 3, 21, 25, 39, 277, DateTimeKind.Local).AddTicks(9763) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 3, 21, 25, 39, 277, DateTimeKind.Local).AddTicks(9766), new DateTime(2024, 2, 3, 21, 25, 39, 277, DateTimeKind.Local).AddTicks(9766) });

            migrationBuilder.UpdateData(
                table: "Staffs",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 3, 21, 25, 39, 279, DateTimeKind.Local).AddTicks(6219), new DateTime(2024, 2, 3, 21, 25, 39, 279, DateTimeKind.Local).AddTicks(6221) });

            migrationBuilder.UpdateData(
                table: "Staffs",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 3, 21, 25, 39, 279, DateTimeKind.Local).AddTicks(6225), new DateTime(2024, 2, 3, 21, 25, 39, 279, DateTimeKind.Local).AddTicks(6225) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9ad86803-8af9-4378-8958-fe33d10d618f", "AQAAAAIAAYagAAAAEL57Wpp25q/CeuD7lwkG3RNWkfliGS3O9+7pH3Wa/SePFqK9Ql8n9GPsy5NmC3hKPw==", "1e9a6355-af00-4553-b2e5-726323bc372a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e25099d1-fcf0-49f1-926e-74fc0197748f", "AQAAAAIAAYagAAAAEGqXnRitBfJk1y5H1FUEETwnF71b39f5Bz2qsJCNifpaEDMbYokJtzTYkcOKqGVq5w==", "78a75608-0272-48c6-88d1-6bc7593d34e0" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 3, 20, 24, 24, 810, DateTimeKind.Local).AddTicks(7942), new DateTime(2024, 2, 3, 20, 24, 24, 810, DateTimeKind.Local).AddTicks(7948) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 3, 20, 24, 24, 810, DateTimeKind.Local).AddTicks(7950), new DateTime(2024, 2, 3, 20, 24, 24, 810, DateTimeKind.Local).AddTicks(7950) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 3, 20, 24, 24, 809, DateTimeKind.Local).AddTicks(7422), new DateTime(2024, 2, 3, 20, 24, 24, 809, DateTimeKind.Local).AddTicks(7432) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 3, 20, 24, 24, 809, DateTimeKind.Local).AddTicks(7434), new DateTime(2024, 2, 3, 20, 24, 24, 809, DateTimeKind.Local).AddTicks(7435) });

            migrationBuilder.UpdateData(
                table: "Staffs",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 3, 20, 24, 24, 811, DateTimeKind.Local).AddTicks(6430), new DateTime(2024, 2, 3, 20, 24, 24, 811, DateTimeKind.Local).AddTicks(6433) });

            migrationBuilder.UpdateData(
                table: "Staffs",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 3, 20, 24, 24, 811, DateTimeKind.Local).AddTicks(6436), new DateTime(2024, 2, 3, 20, 24, 24, 811, DateTimeKind.Local).AddTicks(6436) });
        }
    }
}
