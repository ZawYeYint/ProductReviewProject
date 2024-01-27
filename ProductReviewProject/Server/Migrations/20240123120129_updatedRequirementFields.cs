using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProductReviewProject.Server.Migrations
{
    /// <inheritdoc />
    public partial class updatedRequirementFields : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Staffs",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Reviews",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Ratings",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Products",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Products",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "169877ff-8250-4508-a9ca-f1c5e54735ba", "AQAAAAIAAYagAAAAECDRkKDbMvrsyuafYHdBNjH6lMqGqljkYsgBTGbBN9gUod8kBpJAz+rTMb/lzMgp0Q==", "92394db2-e135-472c-9aab-ce7a955c648e" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 23, 20, 1, 29, 126, DateTimeKind.Local).AddTicks(7921), new DateTime(2024, 1, 23, 20, 1, 29, 126, DateTimeKind.Local).AddTicks(7949) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 23, 20, 1, 29, 126, DateTimeKind.Local).AddTicks(7956), new DateTime(2024, 1, 23, 20, 1, 29, 126, DateTimeKind.Local).AddTicks(7956) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 23, 20, 1, 29, 125, DateTimeKind.Local).AddTicks(6427), new DateTime(2024, 1, 23, 20, 1, 29, 125, DateTimeKind.Local).AddTicks(6447) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 23, 20, 1, 29, 125, DateTimeKind.Local).AddTicks(6450), new DateTime(2024, 1, 23, 20, 1, 29, 125, DateTimeKind.Local).AddTicks(6450) });

            migrationBuilder.UpdateData(
                table: "Staffs",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 23, 20, 1, 29, 127, DateTimeKind.Local).AddTicks(7957), new DateTime(2024, 1, 23, 20, 1, 29, 127, DateTimeKind.Local).AddTicks(7976) });

            migrationBuilder.UpdateData(
                table: "Staffs",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 23, 20, 1, 29, 127, DateTimeKind.Local).AddTicks(7980), new DateTime(2024, 1, 23, 20, 1, 29, 127, DateTimeKind.Local).AddTicks(7981) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Staffs",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Reviews",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Ratings",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Products",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Products",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f20b9147-7457-4fa4-9ba6-335e7ffd8dbe", "AQAAAAIAAYagAAAAEHVrwvZ1jt1zeYXcZ5ddh4ELgk/2iCc1KuONU8ozANejD9+/7WncOSOu7Ynaf+pqRg==", "7bbcf64e-aac8-4694-97de-688007368e86" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 23, 19, 53, 24, 969, DateTimeKind.Local).AddTicks(1140), new DateTime(2024, 1, 23, 19, 53, 24, 969, DateTimeKind.Local).AddTicks(1144) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 23, 19, 53, 24, 969, DateTimeKind.Local).AddTicks(1147), new DateTime(2024, 1, 23, 19, 53, 24, 969, DateTimeKind.Local).AddTicks(1147) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 23, 19, 53, 24, 968, DateTimeKind.Local).AddTicks(978), new DateTime(2024, 1, 23, 19, 53, 24, 968, DateTimeKind.Local).AddTicks(988) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 23, 19, 53, 24, 968, DateTimeKind.Local).AddTicks(991), new DateTime(2024, 1, 23, 19, 53, 24, 968, DateTimeKind.Local).AddTicks(992) });

            migrationBuilder.UpdateData(
                table: "Staffs",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 23, 19, 53, 24, 969, DateTimeKind.Local).AddTicks(9261), new DateTime(2024, 1, 23, 19, 53, 24, 969, DateTimeKind.Local).AddTicks(9264) });

            migrationBuilder.UpdateData(
                table: "Staffs",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 23, 19, 53, 24, 969, DateTimeKind.Local).AddTicks(9266), new DateTime(2024, 1, 23, 19, 53, 24, 969, DateTimeKind.Local).AddTicks(9267) });
        }
    }
}
