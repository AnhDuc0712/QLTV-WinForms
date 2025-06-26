using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FullToping.Migrations
{
    /// <inheritdoc />
    public partial class FirstAdd : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Authors",
                columns: table => new
                {
                    AuthorId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "2001, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Authors", x => x.AuthorId);
                });

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    CategoryId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "3001, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.CategoryId);
                });

            migrationBuilder.CreateTable(
                name: "Publishers",
                columns: table => new
                {
                    PublisherId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "4001, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Publishers", x => x.PublisherId);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1001, 1"),
                    FullName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Address = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    Username = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Password = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    UserType = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.UserId);
                    table.CheckConstraint("CK_Users_Password_NotNull_IfEmployee", "(UserType = 'Customer' AND Password IS NULL) OR (UserType = 'Employee' AND Password IS NOT NULL)");
                });

            migrationBuilder.CreateTable(
                name: "Books",
                columns: table => new
                {
                    BookId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "5001, 1"),
                    Title = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false),
                    PublisherId = table.Column<int>(type: "int", nullable: false),
                    StockQuantity = table.Column<int>(type: "int", nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Books", x => x.BookId);
                    table.ForeignKey(
                        name: "FK_Books_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "CategoryId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Books_Publishers_PublisherId",
                        column: x => x.PublisherId,
                        principalTable: "Publishers",
                        principalColumn: "PublisherId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BorrowReceipts",
                columns: table => new
                {
                    ReceiptId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "6001, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    BorrowDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ReturnDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Status = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BorrowReceipts", x => x.ReceiptId);
                    table.ForeignKey(
                        name: "FK_BorrowReceipts_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BookAuthors",
                columns: table => new
                {
                    BookId = table.Column<int>(type: "int", nullable: false),
                    AuthorId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BookAuthors", x => new { x.BookId, x.AuthorId });
                    table.ForeignKey(
                        name: "FK_BookAuthors_Authors_AuthorId",
                        column: x => x.AuthorId,
                        principalTable: "Authors",
                        principalColumn: "AuthorId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BookAuthors_Books_BookId",
                        column: x => x.BookId,
                        principalTable: "Books",
                        principalColumn: "BookId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BorrowDetails",
                columns: table => new
                {
                    ReceiptId = table.Column<int>(type: "int", nullable: false),
                    BookId = table.Column<int>(type: "int", nullable: false),
                    ActualReturnDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    FineAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BorrowDetails", x => new { x.ReceiptId, x.BookId });
                    table.ForeignKey(
                        name: "FK_BorrowDetails_Books_BookId",
                        column: x => x.BookId,
                        principalTable: "Books",
                        principalColumn: "BookId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BorrowDetails_BorrowReceipts_ReceiptId",
                        column: x => x.ReceiptId,
                        principalTable: "BorrowReceipts",
                        principalColumn: "ReceiptId",
                        onDelete: ReferentialAction.Cascade);
                });

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
                    { 2015, "Sun Tzu" },
                    { 2016, "Ernest Hemingway" },
                    { 2017, "Agatha Christie" },
                    { 2018, "Edgar Allan Poe" },
                    { 2019, "Ralph Waldo Emerson" },
                    { 2020, "Đỗ Phấn" },
                    { 2021, "Arthur C. Clarke" },
                    { 2022, "Nicholas Sparks" },
                    { 2023, "Dale Carnegie" },
                    { 2024, "Robert Kiyosaki" },
                    { 2025, "Stephen R. Covey" },
                    { 2026, "Nguyễn Trãi" },
                    { 2027, "William Shakespeare" },
                    { 2028, "Sigmund Freud" },
                    { 2029, "Noam Chomsky" },
                    { 2030, "Trần Đại Nghĩa" }
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
                    { 3015, "Ẩm thực – Nấu ăn" },
                    { 3016, "Văn học trẻ" },
                    { 3017, "Tiểu thuyết trinh thám" },
                    { 3018, "Kinh dị – Giật gân" },
                    { 3019, "Thơ cách mạng" },
                    { 3020, "Tôn giáo – Triết học" },
                    { 3021, "Khoa học viễn tưởng" },
                    { 3022, "Lãng mạn – Tình cảm" },
                    { 3023, "Phát triển bản thân" },
                    { 3024, "Kinh doanh – Khởi nghiệp" },
                    { 3025, "Sách kỹ năng mềm" },
                    { 3026, "Văn hóa – Xã hội" },
                    { 3027, "Sách thiếu nhi – Thiếu niên" },
                    { 3028, "Sách luật pháp" },
                    { 3029, "Sách đại học" },
                    { 3030, "Sách chuyên ngành y" }
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
                    { 4008, "NXB Công nghệ Thông tin" },
                    { 4009, "NXB Hội Nhà văn" },
                    { 4010, "NXB Văn học" },
                    { 4011, "NXB Phụ nữ" },
                    { 4012, "NXB Tri thức" },
                    { 4013, "NXB Phương Đông" },
                    { 4014, "NXB Văn học Đông Á" },
                    { 4015, "NXB Đại học Quốc gia TP.HCM" },
                    { 4016, "NXB An ninh quốc gia" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserId", "Address", "Email", "FullName", "Password", "Phone", "UserType", "Username" },
                values: new object[,]
                {
                    { 1001, "Số 12, ngõ 34 Phố Hoàng Hoa Thám, Quận Ba Đình, Hà Nội", "vanvu@gmail.com", "Nguyễn Văn Vũ", null, "0912345678", "Customer", "nguyenvanvu" },
                    { 1002, "Số 45, Đường 3/2, Phường Hưng Lợi, Quận Ninh Kiều, TP. Cần Thơ", "thiba@gmail.com", "Trần Thị Ba", null, "0987654321", "Customer", "tranthiba" },
                    { 1003, "Số 78, Phố Nguyễn Văn Cừ, Phường Gia Thuỷ, TP. Bắc Ninh", "vanchi@gmail.com", "Lê Văn Chi", null, "0901234567", "Customer", "levanchi" },
                    { 1004, "Số 22, Đường Láng Hạ, Phường Láng Hạ, Quận Đống Đa, Hà Nội", "dungpham@gmail.com", "Phạm Thị Dung", null, "0918765432", "Customer", "phamthidung" },
                    { 1005, "Số 99, Đường Trần Phú, Phường 5, TP. Vũng Tàu", "anvo@gmail.com", "Võ Văn An", null, "0932123456", "Customer", "vovan_an" },
                    { 1006, "Số 5, Phố Hoàng Diệu, Phường Hải Châu 1, Quận Hải Châu, Đà Nẵng", "hienly@gmail.com", "Lý Thị Hiền", null, "0983344556", "Customer", "lythihien" },
                    { 1007, "Số 150, Đường Cách Mạng Tháng 8, Phường Bến Thành, Quận 1, TP. Hồ Chí Minh", "tuanngo@gmail.com", "Ngô Minh Tuấn", null, "0909988776", "Customer", "ngominhtuan" },
                    { 1008, "Số 10, Đường Hai Bà Trưng, Phường Phạm Ngũ Lão, Quận 1, TP. Hồ Chí Minh", "lan.dang@gmail.com", "Đặng Thị Lan", null, "0911223344", "Customer", "dangthilan" },
                    { 1009, "Số 8, Đường Nguyễn Thị Minh Khai, Phường 1, TP. Vĩnh Long", "vanhoa.phan@gmail.com", "Phan Văn Hòa", null, "0977554433", "Customer", "phanvanhoa" },
                    { 1010, "Số 120, Đường Phan Đình Phùng, Phường Thành Nhất, TP. Buôn Ma Thuột", "maitruong@gmail.com", "Trương Thị Mai", null, "0911335577", "Customer", "truongthimai" },
                    { 1011, "Số 33, Phố Lý Thường Kiệt, Phường Phủ Hà, TP. Lạng Sơn", "quocviet.bui@gmail.com", "Bùi Quốc Việt", null, "0987665544", "Customer", "buiquo cviet" },
                    { 1012, "Số 27, Đường Hùng Vương, Phường Mỹ Xuyên, TP. Sóc Trăng", "phuongle@gmail.com", "Lê Thị Phương", null, "0968877665", "Customer", "lethiphuong" },
                    { 1013, "Số 55, Đường Trần Hưng Đạo, Phường Lê Lợi, TP. Nam Định", "minhtu.do@gmail.com", "Đỗ Minh Tú", null, "0933445566", "Customer", "dominhtu" },
                    { 1014, "Số 18, Đường Lê Lợi, Phường An Lạc, TP. Biên Hòa", "minhquan.pham@gmail.com", "Phạm Minh Quân", null, "0914556677", "Customer", "phamminhquan" },
                    { 1015, "Số 66, Phố Trần Nhân Tông, Phường Nam Đàn, TP. Thanh Hóa", "ngocvu@gmail.com", "Vũ Thị Ngọc", null, "0988112233", "Customer", "vuthingoc" },
                    { 1016, "Số 102, Đường Trần Phú, Phường Xuân Phú, TP. Huế", "quoccuong.nguyen@gmail.com", "Nguyễn Quốc Cường", null, "0902334455", "Customer", "nguyencuong" },
                    { 1017, "Số 5, Đường Nguyễn Văn Trỗi, Phường Đông Vệ, TP. Thanh Hóa", "thuyhang.le@gmail.com", "Lê Thúy Hằng", null, "0977665544", "Customer", "lethuyhang" },
                    { 1018, "Số 250, Đường Nguyễn Thái Học, Phường Phan Chu Trinh, TP. Quy Nhơn", "anhtuan.tran@gmail.com", "Trần Anh Tuấn", null, "0933667788", "Customer", "trananhtuan" },
                    { 1019, "Số 14, Đường Nguyễn Huệ, Phường Phước Ninh, TP. Đà Nẵng", "hanhphan@gmail.com", "Phan Thị Hạnh", null, "0901778899", "Customer", "phanthihanh" },
                    { 1020, "Số 77, Phố Phan Đình Phùng, Phường Đội Cấn, Quận Ba Đình, Hà Nội", "sontruong@gmail.com", "Trương Văn Sơn", null, "0977001122", "Customer", "truongvanson" },
                    { 1021, "Số 33, Đường Trần Khánh Dư, Phường Trần Hưng Đạo, Quận Hoàn Kiếm, Hà Nội", "leminhtam@gmail.com", "Lê Minh Tâm", null, "0912993344", "Customer", "leminhtam" },
                    { 1022, "Số 55, Đường Đinh Tiên Hoàng, Phường Bến Nghé, Quận 1, TP. Hồ Chí Minh", "phucdang@gmail.com", "Đặng Văn Phúc", null, "0933100234", "Customer", "dangvanphuc" },
                    { 1023, "Số 99, Đường Lý Tự Trọng, Phường Phú Hòa, TP. Thủ Dầu Một", "kieuvo@gmail.com", "Võ Thị Kiều", null, "0988776655", "Customer", "vothikieu" }
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
                    { 5030, 3015, null, 4006, 14, "Cẩm Nang Nấu Ăn Gia Đình" },
                    { 5031, 3017, null, 4009, 7, "Ông già và biển cả" },
                    { 5032, 3017, null, 4010, 5, "Án mạng trên chuyến tàu tốc hành phương Đông" },
                    { 5033, 3018, null, 4011, 4, "Con quạ và các truyện khác" },
                    { 5034, 3016, null, 4009, 6, "Tản văn Du ký" },
                    { 5035, 3020, null, 4011, 3, "Tinh thần triết học" },
                    { 5036, 3021, null, 4012, 5, "2001: A Space Odyssey" },
                    { 5037, 3022, null, 4013, 8, "Notebook – Nhật ký tình yêu" },
                    { 5038, 3023, null, 4012, 10, "How to Win Friends" },
                    { 5039, 3024, null, 4014, 7, "Rich Dad Poor Dad" },
                    { 5040, 3025, null, 4013, 6, "7 Thói Quen Hiệu Quả" },
                    { 5041, 3026, null, 4015, 5, "Lược sử phát minh" },
                    { 5042, 3027, null, 4016, 7, "Harry Potter và Phòng Chứa Bí Ẩn" },
                    { 5043, 3028, null, 4015, 3, "Luật Dân sự Việt Nam" },
                    { 5044, 3029, null, 4015, 4, "Toán Cao Cấp – Đại cương" },
                    { 5045, 3030, null, 4016, 6, "Y học cổ truyền Việt Nam" },
                    { 5046, 3005, null, 4008, 15, "Lập Trình C# Toàn Tập" },
                    { 5047, 3005, null, 4008, 8, "Thiết Kế Kiến Trúc Phần Mềm" },
                    { 5048, 3005, null, 4008, 12, "Giải Thuật và Cấu Trúc Dữ Liệu" },
                    { 5049, 3005, null, 4014, 10, "An Ninh Mạng Cơ Bản" },
                    { 5050, 3005, null, 4012, 7, "Hướng Dẫn ReactJS" },
                    { 5051, 3025, null, 4013, 9, "Kỹ Năng Giao Tiếp Trong Công Việc" },
                    { 5052, 3025, null, 4013, 6, "Nghệ Thuật Thuyết Phục" },
                    { 5053, 3005, null, 4008, 5, "Quản Trị Mạng CCNA" },
                    { 5054, 3005, null, 4009, 11, "Phân Tích Dữ Liệu với Python" },
                    { 5055, 3005, null, 4014, 4, "Machine Learning Cơ Bản" },
                    { 5056, 3005, null, 4014, 5, "Deep Learning Cơ Bản" },
                    { 5057, 3025, null, 4013, 8, "Kỹ Năng Lãnh Đạo" },
                    { 5058, 3005, null, 4008, 7, "Phát Triển Ứng Dụng Android" },
                    { 5059, 3005, null, 4009, 10, "C# Trong Thực Tiễn" },
                    { 5060, 3005, null, 4012, 6, "Docker và Kubernetes" },
                    { 5061, 3006, null, 4011, 9, "Phân Tích Hành Vi Người Dùng" },
                    { 5062, 3024, null, 4010, 4, "Quản Trị Dự Án Agile" },
                    { 5063, 3005, null, 4008, 5, "Kiến Trúc Microservices" },
                    { 5064, 3023, null, 4009, 7, "Trò Chuyện Với Stanley" },
                    { 5065, 3014, null, 4015, 3, "Hành Trình Về Phương Đông" },
                    { 5066, 3005, null, 4012, 8, "Thiết Kế UX/UI Cơ Bản" },
                    { 5067, 3025, null, 4013, 6, "Phương Pháp Đặt Câu Hỏi" },
                    { 5068, 3005, null, 4008, 12, "Lập Trình Python" },
                    { 5069, 3009, null, 4006, 5, "An Toàn Thực Phẩm" },
                    { 5070, 3014, null, 4002, 7, "Kỹ Thuật Chụp Ảnh" },
                    { 5071, 3024, null, 4010, 4, "Quản Lý Nhân Sự Hiện Đại" },
                    { 5072, 3012, null, 4014, 9, "Sức Mạnh Thói Quen" },
                    { 5073, 3020, null, 4003, 3, "Ngôn Ngữ Cơ Thể" },
                    { 5074, 3003, null, 4001, 6, "Khoa Học Hành Vi" },
                    { 5075, 3025, null, 4013, 8, "Thuyết Trình Tuyệt Đỉnh" },
                    { 5076, 3005, null, 4014, 5, "Công Nghệ Blockchain" },
                    { 5077, 3028, null, 4015, 4, "Luật Hình Sự Cơ Bản" },
                    { 5078, 3016, null, 4009, 7, "Viết Kịch Bản Phim" },
                    { 5079, 3010, null, 4002, 5, "Âm Nhạc Thế Kỷ 21" },
                    { 5080, 3024, null, 4010, 6, "Khởi Nghiệp Tinh Gọn" },
                    { 5081, 3005, null, 4008, 9, "Xử Lý Ngôn Ngữ Tự Nhiên" },
                    { 5082, 3006, null, 4001, 10, "Psychology of Money" },
                    { 5083, 3024, null, 4012, 5, "Nghiên Cứu Thị Trường" },
                    { 5084, 3025, null, 4013, 7, "Châm Ngôn Thành Công" },
                    { 5085, 3006, null, 4006, 4, "Sách Về Thiền Định" },
                    { 5086, 3010, null, 4002, 6, "Lý Thuyết Âm Nhạc" },
                    { 5087, 3009, null, 4006, 5, "Dinh Dưỡng Học" },
                    { 5088, 3029, null, 4015, 3, "Thủy Văn Cơ Sở" },
                    { 5089, 3005, null, 4008, 12, "Lập Trình Web Toàn Tập" },
                    { 5090, 3005, null, 4014, 8, "Công Nghệ IoT" },
                    { 5091, 3024, null, 4010, 5, "Quản Trị Rủi Ro" },
                    { 5092, 3013, null, 4002, 7, "Thơ Tình Việt Nam" },
                    { 5093, 3014, null, 4015, 6, "Du Lịch Tây Bắc" },
                    { 5094, 3005, null, 4009, 4, "Quản Lý Dữ Liệu Lớn" },
                    { 5095, 3029, null, 4015, 5, "Toán Rời Rạc" },
                    { 5096, 3005, null, 4014, 3, "Blockchain trong Ngân Hàng" },
                    { 5097, 3005, null, 4008, 7, "Xử Lý Ảnh Số" },
                    { 5098, 3024, null, 4010, 5, "Phân Tích Tài Chính" },
                    { 5099, 3025, null, 4013, 8, "Hạt Giống Tâm Hồn" },
                    { 5100, 3024, null, 4010, 6, "Sách Về Chiến Lược" },
                    { 5101, 3005, null, 4008, 9, "Thiết Kế Game" },
                    { 5102, 3024, null, 4010, 4, "Quản Trị Công Nghệ" },
                    { 5103, 3005, null, 4009, 7, "Phát Triển iOS" },
                    { 5104, 3013, null, 4002, 5, "Thơ Trẻ" },
                    { 5105, 3015, null, 4005, 10, "Ẩm Thực Việt" }
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
                    { 6010, new DateTime(2025, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Borrowed", 1001 },
                    { 6011, new DateTime(2025, 6, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 6, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Returned", 1004 },
                    { 6012, new DateTime(2025, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Borrowed", 1005 },
                    { 6013, new DateTime(2025, 6, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 6, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Returned", 1006 },
                    { 6014, new DateTime(2025, 6, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Borrowed", 1007 },
                    { 6015, new DateTime(2025, 6, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Borrowed", 1008 },
                    { 6016, new DateTime(2025, 6, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 6, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Returned", 1009 },
                    { 6017, new DateTime(2025, 6, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Borrowed", 1010 },
                    { 6018, new DateTime(2025, 6, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 6, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Returned", 1011 },
                    { 6019, new DateTime(2025, 6, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Borrowed", 1012 },
                    { 6020, new DateTime(2025, 6, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Borrowed", 1013 },
                    { 6021, new DateTime(2025, 6, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 6, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Returned", 1014 },
                    { 6022, new DateTime(2025, 6, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Borrowed", 1015 },
                    { 6023, new DateTime(2025, 6, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Returned", 1016 },
                    { 6024, new DateTime(2025, 6, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Borrowed", 1017 },
                    { 6025, new DateTime(2025, 6, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Borrowed", 1018 }
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
                    { 2015, 5020 },
                    { 2016, 5031 },
                    { 2017, 5032 },
                    { 2018, 5033 },
                    { 2019, 5034 },
                    { 2020, 5035 },
                    { 2021, 5036 },
                    { 2022, 5037 },
                    { 2023, 5038 },
                    { 2024, 5039 },
                    { 2025, 5040 },
                    { 2026, 5041 },
                    { 2026, 5042 },
                    { 2027, 5043 },
                    { 2028, 5044 },
                    { 2029, 5045 },
                    { 2028, 5046 },
                    { 2029, 5047 },
                    { 2021, 5048 },
                    { 2021, 5049 },
                    { 2022, 5050 },
                    { 2023, 5051 },
                    { 2023, 5052 },
                    { 2014, 5053 },
                    { 2017, 5054 },
                    { 2024, 5055 },
                    { 2024, 5056 },
                    { 2025, 5057 },
                    { 2014, 5058 },
                    { 2016, 5059 },
                    { 2021, 5060 },
                    { 2027, 5061 },
                    { 2023, 5062 },
                    { 2022, 5063 },
                    { 2029, 5064 },
                    { 2026, 5065 },
                    { 2024, 5066 },
                    { 2025, 5067 },
                    { 2021, 5068 },
                    { 2027, 5069 },
                    { 2029, 5070 },
                    { 2023, 5071 },
                    { 2025, 5072 },
                    { 2029, 5073 },
                    { 2021, 5074 },
                    { 2023, 5075 },
                    { 2021, 5076 },
                    { 2022, 5077 },
                    { 2016, 5078 },
                    { 2010, 5079 },
                    { 2017, 5080 },
                    { 2014, 5081 },
                    { 2005, 5082 },
                    { 2012, 5083 },
                    { 2023, 5084 },
                    { 2015, 5085 },
                    { 2014, 5086 },
                    { 2008, 5087 },
                    { 2026, 5088 },
                    { 2021, 5089 },
                    { 2021, 5090 },
                    { 2023, 5091 },
                    { 2022, 5092 },
                    { 2026, 5093 },
                    { 2028, 5094 },
                    { 2027, 5095 },
                    { 2021, 5096 },
                    { 2024, 5097 },
                    { 2022, 5098 },
                    { 2025, 5099 },
                    { 2023, 5100 },
                    { 2022, 5101 },
                    { 2023, 5102 },
                    { 2022, 5103 },
                    { 2027, 5104 },
                    { 2026, 5105 }
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

            migrationBuilder.CreateIndex(
                name: "IX_BookAuthors_AuthorId",
                table: "BookAuthors",
                column: "AuthorId");

            migrationBuilder.CreateIndex(
                name: "IX_Books_CategoryId",
                table: "Books",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Books_PublisherId",
                table: "Books",
                column: "PublisherId");

            migrationBuilder.CreateIndex(
                name: "IX_BorrowDetails_BookId",
                table: "BorrowDetails",
                column: "BookId");

            migrationBuilder.CreateIndex(
                name: "IX_BorrowReceipts_UserId",
                table: "BorrowReceipts",
                column: "UserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BookAuthors");

            migrationBuilder.DropTable(
                name: "BorrowDetails");

            migrationBuilder.DropTable(
                name: "Authors");

            migrationBuilder.DropTable(
                name: "Books");

            migrationBuilder.DropTable(
                name: "BorrowReceipts");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Publishers");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
