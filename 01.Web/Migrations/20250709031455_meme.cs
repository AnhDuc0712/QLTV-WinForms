using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace QLTV.Migrations
{
    /// <inheritdoc />
    public partial class meme : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Authors",
                columns: table => new
                {
                    AuthorId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
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
                        .Annotation("SqlServer:Identity", "1, 1"),
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
                        .Annotation("SqlServer:Identity", "1, 1"),
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
                        .Annotation("SqlServer:Identity", "1, 1"),
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
                        .Annotation("SqlServer:Identity", "1, 1"),
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
                        .Annotation("SqlServer:Identity", "1, 1"),
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
                    { 1, "Nguyễn Nhật Ánh" },
                    { 2, "Hermione Granger" },
                    { 3, "Paulo Coelho" },
                    { 4, "Stephen Hawking" },
                    { 5, "Yuval Noah Harari" },
                    { 6, "J.K. Rowling" },
                    { 7, "Daniel Kahneman" },
                    { 8, "Tony Robbins" },
                    { 9, "Malcolm Gladwell" },
                    { 10, "George Orwell" },
                    { 11, "Harper Lee" },
                    { 12, "Fyodor Dostoevsky" },
                    { 13, "Gabriel Garcia Marquez" },
                    { 14, "Isaac Asimov" },
                    { 15, "Sun Tzu" },
                    { 16, "Ernest Hemingway" },
                    { 17, "Agatha Christie" },
                    { 18, "Edgar Allan Poe" },
                    { 19, "Ralph Waldo Emerson" },
                    { 20, "Đỗ Phấn" },
                    { 21, "Arthur C. Clarke" },
                    { 22, "Nicholas Sparks" },
                    { 23, "Dale Carnegie" },
                    { 24, "Robert Kiyosaki" },
                    { 25, "Stephen R. Covey" },
                    { 26, "Nguyễn Trãi" },
                    { 27, "William Shakespeare" },
                    { 28, "Sigmund Freud" },
                    { 29, "Noam Chomsky" },
                    { 30, "Trần Đại Nghĩa" }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "Name" },
                values: new object[,]
                {
                    { 1, "Văn học Việt Nam" },
                    { 2, "Văn học nước ngoài" },
                    { 3, "Nghiên cứu khoa học" },
                    { 4, "Lịch sử – Địa lý" },
                    { 5, "Công nghệ thông tin" },
                    { 6, "Tâm lý – Kỹ năng sống" },
                    { 7, "Thiếu nhi" },
                    { 8, "Kinh tế – Quản trị" },
                    { 9, "Y học – Sức khỏe" },
                    { 10, "Nghệ thuật – Kiến trúc" },
                    { 11, "Truyện tranh – Manga" },
                    { 12, "Tự lực – Phát triển bản thân" },
                    { 13, "Thơ ca" },
                    { 14, "Du lịch – Khám phá" },
                    { 15, "Ẩm thực – Nấu ăn" },
                    { 16, "Văn học trẻ" },
                    { 17, "Tiểu thuyết trinh thám" },
                    { 18, "Kinh dị – Giật gân" },
                    { 19, "Thơ cách mạng" },
                    { 20, "Tôn giáo – Triết học" },
                    { 21, "Khoa học viễn tưởng" },
                    { 22, "Lãng mạn – Tình cảm" },
                    { 23, "Phát triển bản thân" },
                    { 24, "Kinh doanh – Khởi nghiệp" },
                    { 25, "Sách kỹ năng mềm" },
                    { 26, "Văn hóa – Xã hội" },
                    { 27, "Sách thiếu nhi – Thiếu niên" },
                    { 28, "Sách luật pháp" },
                    { 29, "Sách đại học" },
                    { 30, "Sách chuyên ngành y" }
                });

            migrationBuilder.InsertData(
                table: "Publishers",
                columns: new[] { "PublisherId", "Name" },
                values: new object[,]
                {
                    { 1, "NXB Giáo dục Việt Nam" },
                    { 2, "NXB Văn hóa – Thông tin" },
                    { 3, "NXB Khoa học và Kỹ thuật" },
                    { 4, "NXB Trẻ" },
                    { 5, "NXB Kim Đồng" },
                    { 6, "NXB Thống Kê" },
                    { 7, "NXB Đại học Quốc gia" },
                    { 8, "NXB Công nghệ Thông tin" },
                    { 9, "NXB Hội Nhà văn" },
                    { 10, "NXB Văn học" },
                    { 11, "NXB Phụ nữ" },
                    { 12, "NXB Tri thức" },
                    { 13, "NXB Phương Đông" },
                    { 14, "NXB Văn học Đông Á" },
                    { 15, "NXB Đại học Quốc gia TP.HCM" },
                    { 16, "NXB An ninh quốc gia" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserId", "Address", "Email", "FullName", "Password", "Phone", "UserType", "Username" },
                values: new object[,]
                {
                    { 1, "Số 12, ngõ 34 Phố Hoàng Hoa Thám, Quận Ba Đình, Hà Nội", "vanvu@gmail.com", "Nguyễn Văn Vũ", null, "0912345678", "Customer", "nguyenvanvu" },
                    { 2, "Số 45, Đường 3/2, Phường Hưng Lợi, Quận Ninh Kiều, TP. Cần Thơ", "thiba@gmail.com", "Trần Thị Ba", null, "0987654321", "Customer", "tranthiba" },
                    { 3, "Số 78, Phố Nguyễn Văn Cừ, Phường Gia Thuỷ, TP. Bắc Ninh", "vanchi@gmail.com", "Lê Văn Chi", null, "0901234567", "Customer", "levanchi" },
                    { 4, "Số 22, Đường Láng Hạ, Phường Láng Hạ, Quận Đống Đa, Hà Nội", "dungpham@gmail.com", "Phạm Thị Dung", null, "0918765432", "Customer", "phamthidung" },
                    { 5, "Số 99, Đường Trần Phú, Phường 5, TP. Vũng Tàu", "anvo@gmail.com", "Võ Văn An", null, "0932123456", "Customer", "vovan_an" },
                    { 6, "Số 5, Phố Hoàng Diệu, Phường Hải Châu 1, Quận Hải Châu, Đà Nẵng", "hienly@gmail.com", "Lý Thị Hiền", null, "0983344556", "Customer", "lythihien" },
                    { 7, "Số 150, Đường Cách Mạng Tháng 8, Phường Bến Thành, Quận 1, TP. Hồ Chí Minh", "tuanngo@gmail.com", "Ngô Minh Tuấn", null, "0909988776", "Customer", "ngominhtuan" },
                    { 8, "Số 10, Đường Hai Bà Trưng, Phường Phạm Ngũ Lão, Quận 1, TP. Hồ Chí Minh", "lan.dang@gmail.com", "Đặng Thị Lan", null, "0911223344", "Customer", "dangthilan" },
                    { 9, "Số 8, Đường Nguyễn Thị Minh Khai, Phường 1, TP. Vĩnh Long", "vanhoa.phan@gmail.com", "Phan Văn Hòa", null, "0977554433", "Customer", "phanvanhoa" },
                    { 10, "Số 120, Đường Phan Đình Phùng, Phường Thành Nhất, TP. Buôn Ma Thuột", "maitruong@gmail.com", "Trương Thị Mai", null, "0911335577", "Customer", "truongthimai" },
                    { 11, "Số 33, Phố Lý Thường Kiệt, Phường Phủ Hà, TP. Lạng Sơn", "quocviet.bui@gmail.com", "Bùi Quốc Việt", null, "0987665544", "Customer", "buiquo cviet" },
                    { 12, "Số 27, Đường Hùng Vương, Phường Mỹ Xuyên, TP. Sóc Trăng", "phuongle@gmail.com", "Lê Thị Phương", null, "0968877665", "Customer", "lethiphuong" },
                    { 13, "Số 55, Đường Trần Hưng Đạo, Phường Lê Lợi, TP. Nam Định", "minhtu.do@gmail.com", "Đỗ Minh Tú", null, "0933445566", "Customer", "dominhtu" },
                    { 14, "Số 18, Đường Lê Lợi, Phường An Lạc, TP. Biên Hòa", "minhquan.pham@gmail.com", "Phạm Minh Quân", null, "0914556677", "Customer", "phamminhquan" },
                    { 15, "Số 66, Phố Trần Nhân Tông, Phường Nam Đàn, TP. Thanh Hóa", "ngocvu@gmail.com", "Vũ Thị Ngọc", null, "0988112233", "Customer", "vuthingoc" },
                    { 16, "Số 102, Đường Trần Phú, Phường Xuân Phú, TP. Huế", "quoccuong.nguyen@gmail.com", "Nguyễn Quốc Cường", null, "0902334455", "Customer", "nguyencuong" },
                    { 17, "Số 5, Đường Nguyễn Văn Trỗi, Phường Đông Vệ, TP. Thanh Hóa", "thuyhang.le@gmail.com", "Lê Thúy Hằng", null, "0977665544", "Customer", "lethuyhang" },
                    { 18, "Số 250, Đường Nguyễn Thái Học, Phường Phan Chu Trinh, TP. Quy Nhơn", "anhtuan.tran@gmail.com", "Trần Anh Tuấn", null, "0933667788", "Customer", "trananhtuan" },
                    { 19, "Số 14, Đường Nguyễn Huệ, Phường Phước Ninh, TP. Đà Nẵng", "hanhphan@gmail.com", "Phan Thị Hạnh", null, "0901778899", "Customer", "phanthihanh" },
                    { 20, "Số 77, Phố Phan Đình Phùng, Phường Đội Cấn, Quận Ba Đình, Hà Nội", "sontruong@gmail.com", "Trương Văn Sơn", null, "0977001122", "Customer", "truongvanson" },
                    { 21, "Số 33, Đường Trần Khánh Dư, Phường Trần Hưng Đạo, Quận Hoàn Kiếm, Hà Nội", "leminhtam@gmail.com", "Lê Minh Tâm", null, "0912993344", "Customer", "leminhtam" },
                    { 22, "Số 55, Đường Đinh Tiên Hoàng, Phường Bến Nghé, Quận 1, TP. Hồ Chí Minh", "phucdang@gmail.com", "Đặng Văn Phúc", null, "0933100234", "Customer", "dangvanphuc" },
                    { 23, "Số 99, Đường Lý Tự Trọng, Phường Phú Hòa, TP. Thủ Dầu Một", "kieuvo@gmail.com", "Võ Thị Kiều", null, "0988776655", "Customer", "vothikieu" }
                });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "BookId", "CategoryId", "ImageUrl", "PublisherId", "StockQuantity", "Title" },
                values: new object[,]
                {
                    { 1, 7, null, 5, 12, "Dế Mèn Phiêu Lưu Ký" },
                    { 2, 2, null, 2, 8, "Hoàng Tử Bé" },
                    { 3, 1, null, 4, 5, "Nhà Giả Kim" },
                    { 4, 3, null, 3, 3, "Lược Sử Thời Gian" },
                    { 5, 4, null, 3, 4, "Sapiens: Lược Sử Loài Người" },
                    { 6, 7, null, 5, 6, "Harry Potter và Hòn Đá Phù Thủy" },
                    { 7, 6, null, 8, 10, "Tư Duy, Nhanh và Chậm" },
                    { 8, 5, null, 8, 2, "Cấu Trúc Dữ Liệu và Giải Thuật" },
                    { 9, 1, null, 2, 5, "Trên Đường" },
                    { 10, 6, null, 1, 4, "21 Bài Học Cho Thế Kỷ 21" },
                    { 11, 2, null, 2, 7, "1984" },
                    { 12, 2, null, 2, 5, "To Kill a Mockingbird" },
                    { 13, 1, null, 3, 6, "Tội Ác và Hình Phạt" },
                    { 14, 1, null, 1, 4, "Nửa Xuân" },
                    { 15, 6, null, 8, 9, "The Power of Habit" },
                    { 16, 6, null, 1, 11, "Đi Tìm Lẽ Sống" },
                    { 17, 4, null, 3, 3, "Chiến Tranh và Hòa Bình" },
                    { 18, 8, null, 8, 8, "Bí Quyết Làm Giàu" },
                    { 19, 5, null, 8, 2, "Artificial Intelligence Basics" },
                    { 20, 4, null, 2, 7, "The Art of War" },
                    { 21, 11, null, 4, 20, "One Piece – Tập 1" },
                    { 22, 12, null, 8, 15, "Atomic Habits" },
                    { 23, 13, null, 2, 8, "Thơ Trẻ – Cố Quận" },
                    { 24, 14, null, 3, 10, "Lonely Planet Việt Nam" },
                    { 25, 15, null, 5, 12, "MasterChef – Công Thức Nấu Ăn" },
                    { 26, 11, null, 5, 25, "Doraemon – Tập 1" },
                    { 27, 12, null, 1, 7, "How to Win Friends & Influence People" },
                    { 28, 13, null, 7, 5, "Thơ Viết Cho Tuổi 20" },
                    { 29, 14, null, 6, 9, "1001 Địa Điểm Việt Nam" },
                    { 30, 15, null, 6, 14, "Cẩm Nang Nấu Ăn Gia Đình" },
                    { 31, 17, null, 9, 7, "Ông già và biển cả" },
                    { 32, 17, null, 10, 5, "Án mạng trên chuyến tàu tốc hành phương Đông" },
                    { 33, 18, null, 11, 4, "Con quạ và các truyện khác" },
                    { 34, 16, null, 9, 6, "Tản văn Du ký" },
                    { 35, 20, null, 11, 3, "Tinh thần triết học" },
                    { 36, 21, null, 12, 5, "2001: A Space Odyssey" },
                    { 37, 22, null, 13, 8, "Notebook – Nhật ký tình yêu" },
                    { 38, 23, null, 12, 10, "How to Win Friends" },
                    { 39, 24, null, 14, 7, "Rich Dad Poor Dad" },
                    { 40, 25, null, 13, 6, "7 Thói Quen Hiệu Quả" },
                    { 41, 26, null, 15, 5, "Lược sử phát minh" },
                    { 42, 27, null, 16, 7, "Harry Potter và Phòng Chứa Bí Ẩn" },
                    { 43, 28, null, 15, 3, "Luật Dân sự Việt Nam" },
                    { 44, 29, null, 15, 4, "Toán Cao Cấp – Đại cương" },
                    { 45, 30, null, 16, 6, "Y học cổ truyền Việt Nam" },
                    { 46, 5, null, 8, 15, "Lập Trình C# Toàn Tập" },
                    { 47, 5, null, 8, 8, "Thiết Kế Kiến Trúc Phần Mềm" },
                    { 48, 5, null, 8, 12, "Giải Thuật và Cấu Trúc Dữ Liệu" },
                    { 49, 5, null, 14, 10, "An Ninh Mạng Cơ Bản" },
                    { 50, 5, null, 12, 7, "Hướng Dẫn ReactJS" },
                    { 51, 25, null, 13, 9, "Kỹ Năng Giao Tiếp Trong Công Việc" },
                    { 52, 25, null, 13, 6, "Nghệ Thuật Thuyết Phục" },
                    { 53, 5, null, 8, 5, "Quản Trị Mạng CCNA" },
                    { 54, 5, null, 9, 11, "Phân Tích Dữ Liệu với Python" },
                    { 55, 5, null, 14, 4, "Machine Learning Cơ Bản" },
                    { 56, 5, null, 14, 5, "Deep Learning Cơ Bản" },
                    { 57, 25, null, 13, 8, "Kỹ Năng Lãnh Đạo" },
                    { 58, 5, null, 8, 7, "Phát Triển Ứng Dụng Android" },
                    { 59, 5, null, 9, 10, "C# Trong Thực Tiễn" },
                    { 60, 5, null, 12, 6, "Docker và Kubernetes" },
                    { 61, 6, null, 11, 9, "Phân Tích Hành Vi Người Dùng" },
                    { 62, 24, null, 10, 4, "Quản Trị Dự Án Agile" },
                    { 63, 5, null, 8, 5, "Kiến Trúc Microservices" },
                    { 64, 23, null, 9, 7, "Trò Chuyện Với Stanley" },
                    { 65, 14, null, 15, 3, "Hành Trình Về Phương Đông" },
                    { 66, 5, null, 12, 8, "Thiết Kế UX/UI Cơ Bản" },
                    { 67, 25, null, 13, 6, "Phương Pháp Đặt Câu Hỏi" },
                    { 68, 5, null, 8, 12, "Lập Trình Python" },
                    { 69, 9, null, 6, 5, "An Toàn Thực Phẩm" },
                    { 70, 14, null, 2, 7, "Kỹ Thuật Chụp Ảnh" },
                    { 71, 24, null, 10, 4, "Quản Lý Nhân Sự Hiện Đại" },
                    { 72, 12, null, 14, 9, "Sức Mạnh Thói Quen" },
                    { 73, 20, null, 3, 3, "Ngôn Ngữ Cơ Thể" },
                    { 74, 3, null, 1, 6, "Khoa Học Hành Vi" },
                    { 75, 25, null, 13, 8, "Thuyết Trình Tuyệt Đỉnh" },
                    { 76, 5, null, 14, 5, "Công Nghệ Blockchain" },
                    { 77, 28, null, 15, 4, "Luật Hình Sự Cơ Bản" },
                    { 78, 16, null, 9, 7, "Viết Kịch Bản Phim" },
                    { 79, 10, null, 2, 5, "Âm Nhạc Thế Kỷ 21" },
                    { 80, 24, null, 10, 6, "Khởi Nghiệp Tinh Gọn" },
                    { 81, 5, null, 8, 9, "Xử Lý Ngôn Ngữ Tự Nhiên" },
                    { 82, 6, null, 1, 10, "Psychology of Money" },
                    { 83, 24, null, 12, 5, "Nghiên Cứu Thị Trường" },
                    { 84, 25, null, 13, 7, "Châm Ngôn Thành Công" },
                    { 85, 6, null, 6, 4, "Sách Về Thiền Định" },
                    { 86, 10, null, 2, 6, "Lý Thuyết Âm Nhạc" },
                    { 87, 9, null, 6, 5, "Dinh Dưỡng Học" },
                    { 88, 29, null, 15, 3, "Thủy Văn Cơ Sở" },
                    { 89, 5, null, 8, 12, "Lập Trình Web Toàn Tập" },
                    { 90, 5, null, 14, 8, "Công Nghệ IoT" },
                    { 91, 24, null, 10, 5, "Quản Trị Rủi Ro" },
                    { 92, 13, null, 2, 7, "Thơ Tình Việt Nam" },
                    { 93, 14, null, 15, 6, "Du Lịch Tây Bắc" },
                    { 94, 5, null, 9, 4, "Quản Lý Dữ Liệu Lớn" },
                    { 95, 29, null, 15, 5, "Toán Rời Rạc" },
                    { 96, 5, null, 14, 3, "Blockchain trong Ngân Hàng" },
                    { 97, 5, null, 8, 7, "Xử Lý Ảnh Số" },
                    { 98, 24, null, 10, 5, "Phân Tích Tài Chính" },
                    { 99, 25, null, 13, 8, "Hạt Giống Tâm Hồn" },
                    { 100, 24, null, 10, 6, "Sách Về Chiến Lược" },
                    { 101, 5, null, 8, 9, "Thiết Kế Game" },
                    { 102, 24, null, 10, 4, "Quản Trị Công Nghệ" },
                    { 103, 5, null, 9, 7, "Phát Triển iOS" },
                    { 104, 13, null, 2, 5, "Thơ Trẻ" },
                    { 105, 15, null, 5, 10, "Ẩm Thực Việt" }
                });

            migrationBuilder.InsertData(
                table: "BorrowReceipts",
                columns: new[] { "ReceiptId", "BorrowDate", "ReturnDate", "Status", "UserId" },
                values: new object[,]
                {
                    { 1, new DateTime(2025, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 6, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Returned", 1 },
                    { 2, new DateTime(2025, 6, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Returned", 2 },
                    { 3, new DateTime(2025, 6, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 6, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Overdue", 3 },
                    { 4, new DateTime(2025, 6, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 6, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "NotFullyReturned", 1 },
                    { 5, new DateTime(2025, 6, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Returned", 2 },
                    { 6, new DateTime(2025, 6, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Borrowing", 3 },
                    { 7, new DateTime(2025, 6, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Borrowing", 1 },
                    { 8, new DateTime(2025, 6, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 6, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Returned", 2 },
                    { 9, new DateTime(2025, 6, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Borrowing", 3 },
                    { 10, new DateTime(2025, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 6, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Borrowing", 1 },
                    { 11, new DateTime(2025, 6, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 6, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Returned", 4 },
                    { 12, new DateTime(2025, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 6, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Borrowing", 5 },
                    { 13, new DateTime(2025, 6, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 6, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Returned", 6 },
                    { 14, new DateTime(2025, 6, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 6, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Borrowing", 7 },
                    { 15, new DateTime(2025, 6, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 6, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "NotFullyReturned", 8 },
                    { 16, new DateTime(2025, 6, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 6, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Returned", 9 },
                    { 17, new DateTime(2025, 6, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 6, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Borrowing", 10 },
                    { 18, new DateTime(2025, 6, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 6, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Returned", 11 },
                    { 19, new DateTime(2025, 6, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 6, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Overdue", 12 },
                    { 20, new DateTime(2025, 6, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 6, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "NotFullyReturned", 13 },
                    { 21, new DateTime(2025, 6, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 6, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Returned", 14 },
                    { 22, new DateTime(2025, 6, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Borrowing", 15 },
                    { 23, new DateTime(2025, 6, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Returned", 16 },
                    { 24, new DateTime(2025, 6, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Borrowing", 17 },
                    { 25, new DateTime(2025, 6, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 7, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Borrowing", 18 }
                });

            migrationBuilder.InsertData(
                table: "BookAuthors",
                columns: new[] { "AuthorId", "BookId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 3, 2 },
                    { 3, 3 },
                    { 11, 3 },
                    { 4, 4 },
                    { 5, 5 },
                    { 6, 6 },
                    { 7, 7 },
                    { 9, 7 },
                    { 14, 8 },
                    { 1, 9 },
                    { 2, 10 },
                    { 5, 10 },
                    { 10, 11 },
                    { 11, 12 },
                    { 12, 13 },
                    { 1, 14 },
                    { 8, 15 },
                    { 2, 16 },
                    { 5, 16 },
                    { 9, 17 },
                    { 2, 18 },
                    { 8, 18 },
                    { 14, 19 },
                    { 15, 20 },
                    { 16, 31 },
                    { 17, 32 },
                    { 18, 33 },
                    { 19, 34 },
                    { 20, 35 },
                    { 21, 36 },
                    { 22, 37 },
                    { 23, 38 },
                    { 24, 39 },
                    { 25, 40 },
                    { 26, 41 },
                    { 26, 42 },
                    { 27, 43 },
                    { 28, 44 },
                    { 29, 45 },
                    { 28, 46 },
                    { 29, 47 },
                    { 21, 48 },
                    { 21, 49 },
                    { 22, 50 },
                    { 23, 51 },
                    { 23, 52 },
                    { 14, 53 },
                    { 17, 54 },
                    { 24, 55 },
                    { 24, 56 },
                    { 25, 57 },
                    { 14, 58 },
                    { 16, 59 },
                    { 21, 60 },
                    { 27, 61 },
                    { 23, 62 },
                    { 22, 63 },
                    { 29, 64 },
                    { 26, 65 },
                    { 24, 66 },
                    { 25, 67 },
                    { 21, 68 },
                    { 27, 69 },
                    { 29, 70 },
                    { 23, 71 },
                    { 25, 72 },
                    { 29, 73 },
                    { 21, 74 },
                    { 23, 75 },
                    { 21, 76 },
                    { 22, 77 },
                    { 16, 78 },
                    { 10, 79 },
                    { 17, 80 },
                    { 14, 81 },
                    { 5, 82 },
                    { 12, 83 },
                    { 23, 84 },
                    { 15, 85 },
                    { 14, 86 },
                    { 8, 87 },
                    { 26, 88 },
                    { 21, 89 },
                    { 21, 90 },
                    { 23, 91 },
                    { 22, 92 },
                    { 26, 93 },
                    { 28, 94 },
                    { 27, 95 },
                    { 21, 96 },
                    { 24, 97 },
                    { 22, 98 },
                    { 25, 99 },
                    { 23, 100 },
                    { 22, 101 },
                    { 23, 102 },
                    { 22, 103 },
                    { 27, 104 },
                    { 26, 105 }
                });

            migrationBuilder.InsertData(
                table: "BorrowDetails",
                columns: new[] { "BookId", "ReceiptId", "ActualReturnDate", "FineAmount" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2025, 6, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 0m },
                    { 2, 1, new DateTime(2025, 6, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 0m },
                    { 3, 2, new DateTime(2025, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 0m },
                    { 4, 2, new DateTime(2025, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 0m },
                    { 5, 3, null, null },
                    { 6, 3, null, null },
                    { 7, 4, null, null },
                    { 8, 5, new DateTime(2025, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 15000m },
                    { 9, 5, new DateTime(2025, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 20000m },
                    { 10, 5, new DateTime(2025, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 2.00m },
                    { 11, 6, null, null },
                    { 12, 6, null, null },
                    { 13, 7, null, null },
                    { 14, 7, null, null },
                    { 15, 8, new DateTime(2025, 6, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 0m },
                    { 16, 8, new DateTime(2025, 6, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 0m },
                    { 17, 9, null, null },
                    { 18, 9, null, null },
                    { 19, 10, null, null },
                    { 20, 10, null, null }
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
