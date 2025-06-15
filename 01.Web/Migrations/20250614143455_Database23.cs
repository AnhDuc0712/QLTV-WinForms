using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Ngducanh.Migrations
{
    /// <inheritdoc />
    public partial class Database23 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1001);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1002);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1003);

            migrationBuilder.AlterColumn<string>(
                name: "Password",
                table: "Users",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AddColumn<string>(
                name: "UserType",
                table: "Users",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: false,
                defaultValue: "");

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserId", "Address", "Email", "FullName", "Password", "Phone", "UserType", "Username" },
                values: new object[,]
                {
                    { 1001, "Số 12, ngõ 34 Phố Hoàng Hoa Thám, Quận Ba Đình, Hà Nội", "vanvu@gmail.com", "Nguyễn Văn Vũ", null, "0912345678", "Customer", "nguyenvanvu" },
                    { 1002, "Số 45, Đường 3/2, Phường Hưng Lợi, Quận Ninh Kiều, TP. Cần Thơ", "thiba@gmail.com", "Trần Thị Ba", null, "0987654321", "Customer", "tranthiba" },
                    { 1003, "Số 78, Phố Nguyễn Văn Cừ, Phường Gia Thuỷ, TP. Bắc Ninh", "vanchi@gmail.com", "Lê Văn Chi", null, "0901234567", "Customer", "levanchi" }
                });

            migrationBuilder.AddCheckConstraint(
                name: "CK_Users_Password_NotNull_IfEmployee",
                table: "Users",
                sql: "(UserType = 'Customer' AND Password IS NULL) OR (UserType = 'Employee' AND Password IS NOT NULL)");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropCheckConstraint(
                name: "CK_Users_Password_NotNull_IfEmployee",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "UserType",
                table: "Users");

            migrationBuilder.AlterColumn<string>(
                name: "Password",
                table: "Users",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100,
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1001,
                column: "Password",
                value: "P@ssw0rd1");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1002,
                column: "Password",
                value: "B@Password2");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1003,
                column: "Password",
                value: "Ch1Secure!");
        }
    }
}
