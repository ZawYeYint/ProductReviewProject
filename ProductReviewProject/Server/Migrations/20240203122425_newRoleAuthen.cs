using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProductReviewProject.Server.Migrations
{
    /// <inheritdoc />
    public partial class newRoleAuthen : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ed68093e-d00a-4bff-b072-1c4a5b90cf4b", "AQAAAAIAAYagAAAAEJ3CyfTRFJmeNuCO+2c0+PSG/qGYuihaFh1SXncmyK5PSwQzDP0hSlRGxARjcr0bXQ==", "39ba706b-1c8d-4457-93fb-d53c9ce336dd" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0c79369a-0740-41ac-96c9-6890c72e6078", "AQAAAAIAAYagAAAAECEzfimZi+NddCkGNQBT45Q7Ot3ye5rFcaYneqqI71LuHB8/aK/gkbrtBdIY5pEnpg==", "dcd529a2-b014-4084-9bfc-6524854b6ddf" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 3, 19, 53, 24, 33, DateTimeKind.Local).AddTicks(8137), new DateTime(2024, 2, 3, 19, 53, 24, 33, DateTimeKind.Local).AddTicks(8146) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 3, 19, 53, 24, 33, DateTimeKind.Local).AddTicks(8149), new DateTime(2024, 2, 3, 19, 53, 24, 33, DateTimeKind.Local).AddTicks(8149) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 3, 19, 53, 24, 32, DateTimeKind.Local).AddTicks(6093), new DateTime(2024, 2, 3, 19, 53, 24, 32, DateTimeKind.Local).AddTicks(6106) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 3, 19, 53, 24, 32, DateTimeKind.Local).AddTicks(6109), new DateTime(2024, 2, 3, 19, 53, 24, 32, DateTimeKind.Local).AddTicks(6109) });

            migrationBuilder.UpdateData(
                table: "Staffs",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 3, 19, 53, 24, 34, DateTimeKind.Local).AddTicks(7474), new DateTime(2024, 2, 3, 19, 53, 24, 34, DateTimeKind.Local).AddTicks(7480) });

            migrationBuilder.UpdateData(
                table: "Staffs",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 3, 19, 53, 24, 34, DateTimeKind.Local).AddTicks(7482), new DateTime(2024, 2, 3, 19, 53, 24, 34, DateTimeKind.Local).AddTicks(7483) });
        }
    }
}
