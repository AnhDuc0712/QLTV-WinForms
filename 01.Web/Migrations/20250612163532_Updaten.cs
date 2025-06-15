using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Ngducanh.Migrations
{
    /// <inheritdoc />
    public partial class Updaten : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 2);

            migrationBuilder.AlterColumn<int>(
                name: "UserId",
                table: "Users",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("SqlServer:Identity", "1001, 1")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<int>(
                name: "PublisherId",
                table: "Publishers",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("SqlServer:Identity", "4001, 1")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<int>(
                name: "CategoryId",
                table: "Categories",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("SqlServer:Identity", "3001, 1")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<int>(
                name: "ReceiptId",
                table: "BorrowReceipts",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("SqlServer:Identity", "6001, 1")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<int>(
                name: "BookId",
                table: "Books",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("SqlServer:Identity", "5001, 1")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<string>(
                name: "ImageUrl",
                table: "Books",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "AuthorId",
                table: "Authors",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("SqlServer:Identity", "2001, 1")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.InsertData(
                table: "Authors",
                columns: new[] { "AuthorId", "Name" },
                values: new object[,]
                {
                    { 2001, "Nguyễn Nhật Ánh" },
                    { 2002, "Hermione Granger" },
                    { 2003, "Paulo Coelho" },
                    { 2004, "Stephen Hawking" },
                    { 2005, "Yuval Noah Harari" },
                    { 2006, "J.K. Rowling" },
                    { 2007, "Daniel Kahneman" },
                    { 2008, "Tony Robbins" },
                    { 2009, "Malcolm Gladwell" },
                    { 2010, "George Orwell" },
                    { 2011, "Harper Lee" },
                    { 2012, "Fyodor Dostoevsky" },
                    { 2013, "Gabriel Garcia Marquez" },
                    { 2014, "Isaac Asimov" },
                    { 2015, "Sun Tzu" }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "Name" },
                values: new object[,]
                {
                    { 3001, "Văn học Việt Nam" },
                    { 3002, "Văn học nước ngoài" },
                    { 3003, "Nghiên cứu khoa học" },
                    { 3004, "Lịch sử – Địa lý" },
                    { 3005, "Công nghệ thông tin" },
                    { 3006, "Tâm lý – Kỹ năng sống" },
                    { 3007, "Thiếu nhi" },
                    { 3008, "Kinh tế – Quản trị" },
                    { 3009, "Y học – Sức khỏe" },
                    { 3010, "Nghệ thuật – Kiến trúc" },
                    { 3011, "Truyện tranh – Manga" },
                    { 3012, "Tự lực – Phát triển bản thân" },
                    { 3013, "Thơ ca" },
                    { 3014, "Du lịch – Khám phá" },
                    { 3015, "Ẩm thực – Nấu ăn" }
                });

            migrationBuilder.InsertData(
                table: "Publishers",
                columns: new[] { "PublisherId", "Name" },
                values: new object[,]
                {
                    { 4001, "NXB Giáo dục Việt Nam" },
                    { 4002, "NXB Văn hóa – Thông tin" },
                    { 4003, "NXB Khoa học và Kỹ thuật" },
                    { 4004, "NXB Trẻ" },
                    { 4005, "NXB Kim Đồng" },
                    { 4006, "NXB Thống Kê" },
                    { 4007, "NXB Đại học Quốc gia" },
                    { 4008, "NXB Công nghệ Thông tin" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserId", "Address", "Email", "FullName", "Password", "Phone", "Username" },
                values: new object[,]
                {
                    { 1001, "Số 12, ngõ 34 Phố Hoàng Hoa Thám, Quận Ba Đình, Hà Nội", "vanvu@gmail.com", "Nguyễn Văn Vũ", "P@ssw0rd1", "0912345678", "nguyenvanvu" },
                    { 1002, "Số 45, Đường 3/2, Phường Hưng Lợi, Quận Ninh Kiều, TP. Cần Thơ", "thiba@gmail.com", "Trần Thị Ba", "B@Password2", "0987654321", "tranthiba" },
                    { 1003, "Số 78, Phố Nguyễn Văn Cừ, Phường Gia Thuỷ, TP. Bắc Ninh", "vanchi@gmail.com", "Lê Văn Chi", "Ch1Secure!", "0901234567", "levanchi" }
                });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "BookId", "CategoryId", "ImageUrl", "PublisherId", "StockQuantity", "Title" },
                values: new object[,]
                {
                    { 5001, 3007, null, 4005, 12, "Dế Mèn Phiêu Lưu Ký" },
                    { 5002, 3002, null, 4002, 8, "Hoàng Tử Bé" },
                    { 5003, 3001, null, 4004, 5, "Nhà Giả Kim" },
                    { 5004, 3003, null, 4003, 3, "Lược Sử Thời Gian" },
                    { 5005, 3004, null, 4003, 4, "Sapiens: Lược Sử Loài Người" },
                    { 5006, 3007, null, 4005, 6, "Harry Potter và Hòn Đá Phù Thủy" },
                    { 5007, 3006, null, 4008, 10, "Tư Duy, Nhanh và Chậm" },
                    { 5008, 3005, null, 4008, 2, "Cấu Trúc Dữ Liệu và Giải Thuật" },
                    { 5009, 3001, null, 4002, 5, "Trên Đường" },
                    { 5010, 3006, null, 4001, 4, "21 Bài Học Cho Thế Kỷ 21" },
                    { 5011, 3002, null, 4002, 7, "1984" },
                    { 5012, 3002, null, 4002, 5, "To Kill a Mockingbird" },
                    { 5013, 3001, null, 4003, 6, "Tội Ác và Hình Phạt" },
                    { 5014, 3001, null, 4001, 4, "Nửa Xuân" },
                    { 5015, 3006, null, 4008, 9, "The Power of Habit" },
                    { 5016, 3006, null, 4001, 11, "Đi Tìm Lẽ Sống" },
                    { 5017, 3004, null, 4003, 3, "Chiến Tranh và Hòa Bình" },
                    { 5018, 3008, null, 4008, 8, "Bí Quyết Làm Giàu" },
                    { 5019, 3005, null, 4008, 2, "Artificial Intelligence Basics" },
                    { 5020, 3004, null, 4002, 7, "The Art of War" },
                    { 5021, 3011, null, 4004, 20, "One Piece – Tập 1" },
                    { 5022, 3012, null, 4008, 15, "Atomic Habits" },
                    { 5023, 3013, null, 4002, 8, "Thơ Trẻ – Cố Quận" },
                    { 5024, 3014, null, 4003, 10, "Lonely Planet Việt Nam" },
                    { 5025, 3015, null, 4005, 12, "MasterChef – Công Thức Nấu Ăn" },
                    { 5026, 3011, null, 4005, 25, "Doraemon – Tập 1" },
                    { 5027, 3012, null, 4001, 7, "How to Win Friends & Influence People" },
                    { 5028, 3013, null, 4007, 5, "Thơ Viết Cho Tuổi 20" },
                    { 5029, 3014, null, 4006, 9, "1001 Địa Điểm Việt Nam" },
                    { 5030, 3015, null, 4006, 14, "Cẩm Nang Nấu Ăn Gia Đình" }
                });

            migrationBuilder.InsertData(
                table: "BorrowReceipts",
                columns: new[] { "ReceiptId", "BorrowDate", "ReturnDate", "Status", "UserId" },
                values: new object[,]
                {
                    { 6001, new DateTime(2025, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 6, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Returned", 1001 },
                    { 6002, new DateTime(2025, 6, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Returned", 1002 },
                    { 6003, new DateTime(2025, 6, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Borrowed", 1003 },
                    { 6004, new DateTime(2025, 6, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Borrowed", 1001 },
                    { 6005, new DateTime(2025, 6, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Returned", 1002 },
                    { 6006, new DateTime(2025, 6, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Borrowed", 1003 },
                    { 6007, new DateTime(2025, 6, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Borrowed", 1001 },
                    { 6008, new DateTime(2025, 6, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 6, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Returned", 1002 },
                    { 6009, new DateTime(2025, 6, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Borrowed", 1003 },
                    { 6010, new DateTime(2025, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Borrowed", 1001 }
                });

            migrationBuilder.InsertData(
                table: "BookAuthors",
                columns: new[] { "AuthorId", "BookId" },
                values: new object[,]
                {
                    { 2001, 5001 },
                    { 2003, 5002 },
                    { 2003, 5003 },
                    { 2011, 5003 },
                    { 2004, 5004 },
                    { 2005, 5005 },
                    { 2006, 5006 },
                    { 2007, 5007 },
                    { 2009, 5007 },
                    { 2014, 5008 },
                    { 2001, 5009 },
                    { 2002, 5010 },
                    { 2005, 5010 },
                    { 2010, 5011 },
                    { 2011, 5012 },
                    { 2012, 5013 },
                    { 2001, 5014 },
                    { 2008, 5015 },
                    { 2002, 5016 },
                    { 2005, 5016 },
                    { 2009, 5017 },
                    { 2002, 5018 },
                    { 2008, 5018 },
                    { 2014, 5019 },
                    { 2015, 5020 }
                });

            migrationBuilder.InsertData(
                table: "BorrowDetails",
                columns: new[] { "BookId", "ReceiptId", "ActualReturnDate", "FineAmount" },
                values: new object[,]
                {
                    { 5001, 6001, new DateTime(2025, 6, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 0m },
                    { 5002, 6001, new DateTime(2025, 6, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 0m },
                    { 5003, 6002, new DateTime(2025, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 0m },
                    { 5004, 6002, new DateTime(2025, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 0m },
                    { 5005, 6003, null, null },
                    { 5006, 6003, null, null },
                    { 5007, 6004, null, null },
                    { 5008, 6005, new DateTime(2025, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 15000m },
                    { 5009, 6005, new DateTime(2025, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 20000m },
                    { 5010, 6005, new DateTime(2025, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 2.00m },
                    { 5011, 6006, null, null },
                    { 5012, 6006, null, null },
                    { 5013, 6007, null, null },
                    { 5014, 6007, null, null },
                    { 5015, 6008, new DateTime(2025, 6, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 0m },
                    { 5016, 6008, new DateTime(2025, 6, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 0m },
                    { 5017, 6009, null, null },
                    { 5018, 6009, null, null },
                    { 5019, 6010, null, null },
                    { 5020, 6010, null, null }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 2013);

            migrationBuilder.DeleteData(
                table: "BookAuthors",
                keyColumns: new[] { "AuthorId", "BookId" },
                keyValues: new object[] { 2001, 5001 });

            migrationBuilder.DeleteData(
                table: "BookAuthors",
                keyColumns: new[] { "AuthorId", "BookId" },
                keyValues: new object[] { 2003, 5002 });

            migrationBuilder.DeleteData(
                table: "BookAuthors",
                keyColumns: new[] { "AuthorId", "BookId" },
                keyValues: new object[] { 2003, 5003 });

            migrationBuilder.DeleteData(
                table: "BookAuthors",
                keyColumns: new[] { "AuthorId", "BookId" },
                keyValues: new object[] { 2011, 5003 });

            migrationBuilder.DeleteData(
                table: "BookAuthors",
                keyColumns: new[] { "AuthorId", "BookId" },
                keyValues: new object[] { 2004, 5004 });

            migrationBuilder.DeleteData(
                table: "BookAuthors",
                keyColumns: new[] { "AuthorId", "BookId" },
                keyValues: new object[] { 2005, 5005 });

            migrationBuilder.DeleteData(
                table: "BookAuthors",
                keyColumns: new[] { "AuthorId", "BookId" },
                keyValues: new object[] { 2006, 5006 });

            migrationBuilder.DeleteData(
                table: "BookAuthors",
                keyColumns: new[] { "AuthorId", "BookId" },
                keyValues: new object[] { 2007, 5007 });

            migrationBuilder.DeleteData(
                table: "BookAuthors",
                keyColumns: new[] { "AuthorId", "BookId" },
                keyValues: new object[] { 2009, 5007 });

            migrationBuilder.DeleteData(
                table: "BookAuthors",
                keyColumns: new[] { "AuthorId", "BookId" },
                keyValues: new object[] { 2014, 5008 });

            migrationBuilder.DeleteData(
                table: "BookAuthors",
                keyColumns: new[] { "AuthorId", "BookId" },
                keyValues: new object[] { 2001, 5009 });

            migrationBuilder.DeleteData(
                table: "BookAuthors",
                keyColumns: new[] { "AuthorId", "BookId" },
                keyValues: new object[] { 2002, 5010 });

            migrationBuilder.DeleteData(
                table: "BookAuthors",
                keyColumns: new[] { "AuthorId", "BookId" },
                keyValues: new object[] { 2005, 5010 });

            migrationBuilder.DeleteData(
                table: "BookAuthors",
                keyColumns: new[] { "AuthorId", "BookId" },
                keyValues: new object[] { 2010, 5011 });

            migrationBuilder.DeleteData(
                table: "BookAuthors",
                keyColumns: new[] { "AuthorId", "BookId" },
                keyValues: new object[] { 2011, 5012 });

            migrationBuilder.DeleteData(
                table: "BookAuthors",
                keyColumns: new[] { "AuthorId", "BookId" },
                keyValues: new object[] { 2012, 5013 });

            migrationBuilder.DeleteData(
                table: "BookAuthors",
                keyColumns: new[] { "AuthorId", "BookId" },
                keyValues: new object[] { 2001, 5014 });

            migrationBuilder.DeleteData(
                table: "BookAuthors",
                keyColumns: new[] { "AuthorId", "BookId" },
                keyValues: new object[] { 2008, 5015 });

            migrationBuilder.DeleteData(
                table: "BookAuthors",
                keyColumns: new[] { "AuthorId", "BookId" },
                keyValues: new object[] { 2002, 5016 });

            migrationBuilder.DeleteData(
                table: "BookAuthors",
                keyColumns: new[] { "AuthorId", "BookId" },
                keyValues: new object[] { 2005, 5016 });

            migrationBuilder.DeleteData(
                table: "BookAuthors",
                keyColumns: new[] { "AuthorId", "BookId" },
                keyValues: new object[] { 2009, 5017 });

            migrationBuilder.DeleteData(
                table: "BookAuthors",
                keyColumns: new[] { "AuthorId", "BookId" },
                keyValues: new object[] { 2002, 5018 });

            migrationBuilder.DeleteData(
                table: "BookAuthors",
                keyColumns: new[] { "AuthorId", "BookId" },
                keyValues: new object[] { 2008, 5018 });

            migrationBuilder.DeleteData(
                table: "BookAuthors",
                keyColumns: new[] { "AuthorId", "BookId" },
                keyValues: new object[] { 2014, 5019 });

            migrationBuilder.DeleteData(
                table: "BookAuthors",
                keyColumns: new[] { "AuthorId", "BookId" },
                keyValues: new object[] { 2015, 5020 });

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 5021);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 5022);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 5023);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 5024);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 5025);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 5026);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 5027);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 5028);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 5029);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 5030);

            migrationBuilder.DeleteData(
                table: "BorrowDetails",
                keyColumns: new[] { "BookId", "ReceiptId" },
                keyValues: new object[] { 5001, 6001 });

            migrationBuilder.DeleteData(
                table: "BorrowDetails",
                keyColumns: new[] { "BookId", "ReceiptId" },
                keyValues: new object[] { 5002, 6001 });

            migrationBuilder.DeleteData(
                table: "BorrowDetails",
                keyColumns: new[] { "BookId", "ReceiptId" },
                keyValues: new object[] { 5003, 6002 });

            migrationBuilder.DeleteData(
                table: "BorrowDetails",
                keyColumns: new[] { "BookId", "ReceiptId" },
                keyValues: new object[] { 5004, 6002 });

            migrationBuilder.DeleteData(
                table: "BorrowDetails",
                keyColumns: new[] { "BookId", "ReceiptId" },
                keyValues: new object[] { 5005, 6003 });

            migrationBuilder.DeleteData(
                table: "BorrowDetails",
                keyColumns: new[] { "BookId", "ReceiptId" },
                keyValues: new object[] { 5006, 6003 });

            migrationBuilder.DeleteData(
                table: "BorrowDetails",
                keyColumns: new[] { "BookId", "ReceiptId" },
                keyValues: new object[] { 5007, 6004 });

            migrationBuilder.DeleteData(
                table: "BorrowDetails",
                keyColumns: new[] { "BookId", "ReceiptId" },
                keyValues: new object[] { 5008, 6005 });

            migrationBuilder.DeleteData(
                table: "BorrowDetails",
                keyColumns: new[] { "BookId", "ReceiptId" },
                keyValues: new object[] { 5009, 6005 });

            migrationBuilder.DeleteData(
                table: "BorrowDetails",
                keyColumns: new[] { "BookId", "ReceiptId" },
                keyValues: new object[] { 5010, 6005 });

            migrationBuilder.DeleteData(
                table: "BorrowDetails",
                keyColumns: new[] { "BookId", "ReceiptId" },
                keyValues: new object[] { 5011, 6006 });

            migrationBuilder.DeleteData(
                table: "BorrowDetails",
                keyColumns: new[] { "BookId", "ReceiptId" },
                keyValues: new object[] { 5012, 6006 });

            migrationBuilder.DeleteData(
                table: "BorrowDetails",
                keyColumns: new[] { "BookId", "ReceiptId" },
                keyValues: new object[] { 5013, 6007 });

            migrationBuilder.DeleteData(
                table: "BorrowDetails",
                keyColumns: new[] { "BookId", "ReceiptId" },
                keyValues: new object[] { 5014, 6007 });

            migrationBuilder.DeleteData(
                table: "BorrowDetails",
                keyColumns: new[] { "BookId", "ReceiptId" },
                keyValues: new object[] { 5015, 6008 });

            migrationBuilder.DeleteData(
                table: "BorrowDetails",
                keyColumns: new[] { "BookId", "ReceiptId" },
                keyValues: new object[] { 5016, 6008 });

            migrationBuilder.DeleteData(
                table: "BorrowDetails",
                keyColumns: new[] { "BookId", "ReceiptId" },
                keyValues: new object[] { 5017, 6009 });

            migrationBuilder.DeleteData(
                table: "BorrowDetails",
                keyColumns: new[] { "BookId", "ReceiptId" },
                keyValues: new object[] { 5018, 6009 });

            migrationBuilder.DeleteData(
                table: "BorrowDetails",
                keyColumns: new[] { "BookId", "ReceiptId" },
                keyValues: new object[] { 5019, 6010 });

            migrationBuilder.DeleteData(
                table: "BorrowDetails",
                keyColumns: new[] { "BookId", "ReceiptId" },
                keyValues: new object[] { 5020, 6010 });

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 3009);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 3010);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 2001);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 2002);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 2003);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 2004);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 2005);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 2006);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 2007);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 2008);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 2009);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 2010);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 2011);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 2012);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 2014);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 2015);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 5001);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 5002);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 5003);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 5004);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 5005);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 5006);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 5007);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 5008);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 5009);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 5010);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 5011);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 5012);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 5013);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 5014);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 5015);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 5016);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 5017);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 5018);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 5019);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 5020);

            migrationBuilder.DeleteData(
                table: "BorrowReceipts",
                keyColumn: "ReceiptId",
                keyValue: 6001);

            migrationBuilder.DeleteData(
                table: "BorrowReceipts",
                keyColumn: "ReceiptId",
                keyValue: 6002);

            migrationBuilder.DeleteData(
                table: "BorrowReceipts",
                keyColumn: "ReceiptId",
                keyValue: 6003);

            migrationBuilder.DeleteData(
                table: "BorrowReceipts",
                keyColumn: "ReceiptId",
                keyValue: 6004);

            migrationBuilder.DeleteData(
                table: "BorrowReceipts",
                keyColumn: "ReceiptId",
                keyValue: 6005);

            migrationBuilder.DeleteData(
                table: "BorrowReceipts",
                keyColumn: "ReceiptId",
                keyValue: 6006);

            migrationBuilder.DeleteData(
                table: "BorrowReceipts",
                keyColumn: "ReceiptId",
                keyValue: 6007);

            migrationBuilder.DeleteData(
                table: "BorrowReceipts",
                keyColumn: "ReceiptId",
                keyValue: 6008);

            migrationBuilder.DeleteData(
                table: "BorrowReceipts",
                keyColumn: "ReceiptId",
                keyValue: 6009);

            migrationBuilder.DeleteData(
                table: "BorrowReceipts",
                keyColumn: "ReceiptId",
                keyValue: 6010);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 3011);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 3012);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 3013);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 3014);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 3015);

            migrationBuilder.DeleteData(
                table: "Publishers",
                keyColumn: "PublisherId",
                keyValue: 4006);

            migrationBuilder.DeleteData(
                table: "Publishers",
                keyColumn: "PublisherId",
                keyValue: 4007);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 3001);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 3002);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 3003);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 3004);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 3005);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 3006);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 3007);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 3008);

            migrationBuilder.DeleteData(
                table: "Publishers",
                keyColumn: "PublisherId",
                keyValue: 4001);

            migrationBuilder.DeleteData(
                table: "Publishers",
                keyColumn: "PublisherId",
                keyValue: 4002);

            migrationBuilder.DeleteData(
                table: "Publishers",
                keyColumn: "PublisherId",
                keyValue: 4003);

            migrationBuilder.DeleteData(
                table: "Publishers",
                keyColumn: "PublisherId",
                keyValue: 4004);

            migrationBuilder.DeleteData(
                table: "Publishers",
                keyColumn: "PublisherId",
                keyValue: 4005);

            migrationBuilder.DeleteData(
                table: "Publishers",
                keyColumn: "PublisherId",
                keyValue: 4008);

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

            migrationBuilder.DropColumn(
                name: "ImageUrl",
                table: "Books");

            migrationBuilder.AlterColumn<int>(
                name: "UserId",
                table: "Users",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("SqlServer:Identity", "1, 1")
                .OldAnnotation("SqlServer:Identity", "1001, 1");

            migrationBuilder.AlterColumn<int>(
                name: "PublisherId",
                table: "Publishers",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("SqlServer:Identity", "1, 1")
                .OldAnnotation("SqlServer:Identity", "4001, 1");

            migrationBuilder.AlterColumn<int>(
                name: "CategoryId",
                table: "Categories",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("SqlServer:Identity", "1, 1")
                .OldAnnotation("SqlServer:Identity", "3001, 1");

            migrationBuilder.AlterColumn<int>(
                name: "ReceiptId",
                table: "BorrowReceipts",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("SqlServer:Identity", "1, 1")
                .OldAnnotation("SqlServer:Identity", "6001, 1");

            migrationBuilder.AlterColumn<int>(
                name: "BookId",
                table: "Books",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("SqlServer:Identity", "1, 1")
                .OldAnnotation("SqlServer:Identity", "5001, 1");

            migrationBuilder.AlterColumn<int>(
                name: "AuthorId",
                table: "Authors",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("SqlServer:Identity", "1, 1")
                .OldAnnotation("SqlServer:Identity", "2001, 1");

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "Name" },
                values: new object[,]
                {
                    { 1, "Văn học" },
                    { 2, "Khoa học" }
                });
        }
    }
}
