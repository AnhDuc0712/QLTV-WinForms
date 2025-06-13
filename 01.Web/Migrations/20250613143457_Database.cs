using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Ngducanh.Migrations
{
    /// <inheritdoc />
    public partial class Database : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Authors",
                columns: new[] { "AuthorId", "Name" },
                values: new object[,]
                {
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
                table: "Books",
                columns: new[] { "BookId", "CategoryId", "ImageUrl", "PublisherId", "StockQuantity", "Title" },
                values: new object[,]
                {
                    { 5046, 3005, null, 4008, 15, "Lập Trình C# Toàn Tập" },
                    { 5047, 3005, null, 4008, 8, "Thiết Kế Kiến Trúc Phần Mềm" },
                    { 5048, 3005, null, 4008, 12, "Giải Thuật và Cấu Trúc Dữ Liệu" },
                    { 5053, 3005, null, 4008, 5, "Quản Trị Mạng CCNA" },
                    { 5058, 3005, null, 4008, 7, "Phát Triển Ứng Dụng Android" },
                    { 5063, 3005, null, 4008, 5, "Kiến Trúc Microservices" },
                    { 5068, 3005, null, 4008, 12, "Lập Trình Python" },
                    { 5069, 3009, null, 4006, 5, "An Toàn Thực Phẩm" },
                    { 5070, 3014, null, 4002, 7, "Kỹ Thuật Chụp Ảnh" },
                    { 5074, 3003, null, 4001, 6, "Khoa Học Hành Vi" },
                    { 5079, 3010, null, 4002, 5, "Âm Nhạc Thế Kỷ 21" },
                    { 5081, 3005, null, 4008, 9, "Xử Lý Ngôn Ngữ Tự Nhiên" },
                    { 5082, 3006, null, 4001, 10, "Psychology of Money" },
                    { 5085, 3006, null, 4006, 4, "Sách Về Thiền Định" },
                    { 5086, 3010, null, 4002, 6, "Lý Thuyết Âm Nhạc" },
                    { 5087, 3009, null, 4006, 5, "Dinh Dưỡng Học" },
                    { 5089, 3005, null, 4008, 12, "Lập Trình Web Toàn Tập" },
                    { 5092, 3013, null, 4002, 7, "Thơ Tình Việt Nam" },
                    { 5097, 3005, null, 4008, 7, "Xử Lý Ảnh Số" },
                    { 5101, 3005, null, 4008, 9, "Thiết Kế Game" },
                    { 5104, 3013, null, 4002, 5, "Thơ Trẻ" },
                    { 5105, 3015, null, 4005, 10, "Ẩm Thực Việt" }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "Name" },
                values: new object[,]
                {
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
                table: "BookAuthors",
                columns: new[] { "AuthorId", "BookId" },
                values: new object[,]
                {
                    { 2028, 5046 },
                    { 2029, 5047 },
                    { 2021, 5048 },
                    { 2014, 5053 },
                    { 2014, 5058 },
                    { 2022, 5063 },
                    { 2021, 5068 },
                    { 2027, 5069 },
                    { 2029, 5070 },
                    { 2021, 5074 },
                    { 2010, 5079 },
                    { 2014, 5081 },
                    { 2005, 5082 },
                    { 2015, 5085 },
                    { 2014, 5086 },
                    { 2008, 5087 },
                    { 2021, 5089 },
                    { 2022, 5092 },
                    { 2024, 5097 },
                    { 2022, 5101 },
                    { 2027, 5104 },
                    { 2026, 5105 }
                });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "BookId", "CategoryId", "ImageUrl", "PublisherId", "StockQuantity", "Title" },
                values: new object[,]
                {
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
                    { 5049, 3005, null, 4014, 10, "An Ninh Mạng Cơ Bản" },
                    { 5050, 3005, null, 4012, 7, "Hướng Dẫn ReactJS" },
                    { 5051, 3025, null, 4013, 9, "Kỹ Năng Giao Tiếp Trong Công Việc" },
                    { 5052, 3025, null, 4013, 6, "Nghệ Thuật Thuyết Phục" },
                    { 5054, 3005, null, 4009, 11, "Phân Tích Dữ Liệu với Python" },
                    { 5055, 3005, null, 4014, 4, "Machine Learning Cơ Bản" },
                    { 5056, 3005, null, 4014, 5, "Deep Learning Cơ Bản" },
                    { 5057, 3025, null, 4013, 8, "Kỹ Năng Lãnh Đạo" },
                    { 5059, 3005, null, 4009, 10, "C# Trong Thực Tiễn" },
                    { 5060, 3005, null, 4012, 6, "Docker và Kubernetes" },
                    { 5061, 3006, null, 4011, 9, "Phân Tích Hành Vi Người Dùng" },
                    { 5062, 3024, null, 4010, 4, "Quản Trị Dự Án Agile" },
                    { 5064, 3023, null, 4009, 7, "Trò Chuyện Với Stanley" },
                    { 5065, 3014, null, 4015, 3, "Hành Trình Về Phương Đông" },
                    { 5066, 3005, null, 4012, 8, "Thiết Kế UX/UI Cơ Bản" },
                    { 5067, 3025, null, 4013, 6, "Phương Pháp Đặt Câu Hỏi" },
                    { 5071, 3024, null, 4010, 4, "Quản Lý Nhân Sự Hiện Đại" },
                    { 5072, 3012, null, 4014, 9, "Sức Mạnh Thói Quen" },
                    { 5073, 3020, null, 4003, 3, "Ngôn Ngữ Cơ Thể" },
                    { 5075, 3025, null, 4013, 8, "Thuyết Trình Tuyệt Đỉnh" },
                    { 5076, 3005, null, 4014, 5, "Công Nghệ Blockchain" },
                    { 5077, 3028, null, 4015, 4, "Luật Hình Sự Cơ Bản" },
                    { 5078, 3016, null, 4009, 7, "Viết Kịch Bản Phim" },
                    { 5080, 3024, null, 4010, 6, "Khởi Nghiệp Tinh Gọn" },
                    { 5083, 3024, null, 4012, 5, "Nghiên Cứu Thị Trường" },
                    { 5084, 3025, null, 4013, 7, "Châm Ngôn Thành Công" },
                    { 5088, 3029, null, 4015, 3, "Thủy Văn Cơ Sở" },
                    { 5090, 3005, null, 4014, 8, "Công Nghệ IoT" },
                    { 5091, 3024, null, 4010, 5, "Quản Trị Rủi Ro" },
                    { 5093, 3014, null, 4015, 6, "Du Lịch Tây Bắc" },
                    { 5094, 3005, null, 4009, 4, "Quản Lý Dữ Liệu Lớn" },
                    { 5095, 3029, null, 4015, 5, "Toán Rời Rạc" },
                    { 5096, 3005, null, 4014, 3, "Blockchain trong Ngân Hàng" },
                    { 5098, 3024, null, 4010, 5, "Phân Tích Tài Chính" },
                    { 5099, 3025, null, 4013, 8, "Hạt Giống Tâm Hồn" },
                    { 5100, 3024, null, 4010, 6, "Sách Về Chiến Lược" },
                    { 5102, 3024, null, 4010, 4, "Quản Trị Công Nghệ" },
                    { 5103, 3005, null, 4009, 7, "Phát Triển iOS" }
                });

            migrationBuilder.InsertData(
                table: "BookAuthors",
                columns: new[] { "AuthorId", "BookId" },
                values: new object[,]
                {
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
                    { 2021, 5049 },
                    { 2022, 5050 },
                    { 2023, 5051 },
                    { 2023, 5052 },
                    { 2017, 5054 },
                    { 2024, 5055 },
                    { 2024, 5056 },
                    { 2025, 5057 },
                    { 2016, 5059 },
                    { 2021, 5060 },
                    { 2027, 5061 },
                    { 2023, 5062 },
                    { 2029, 5064 },
                    { 2026, 5065 },
                    { 2024, 5066 },
                    { 2025, 5067 },
                    { 2023, 5071 },
                    { 2025, 5072 },
                    { 2029, 5073 },
                    { 2023, 5075 },
                    { 2021, 5076 },
                    { 2022, 5077 },
                    { 2016, 5078 },
                    { 2017, 5080 },
                    { 2012, 5083 },
                    { 2023, 5084 },
                    { 2026, 5088 },
                    { 2021, 5090 },
                    { 2023, 5091 },
                    { 2026, 5093 },
                    { 2028, 5094 },
                    { 2027, 5095 },
                    { 2021, 5096 },
                    { 2022, 5098 },
                    { 2025, 5099 },
                    { 2023, 5100 },
                    { 2023, 5102 },
                    { 2022, 5103 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 2030);

            migrationBuilder.DeleteData(
                table: "BookAuthors",
                keyColumns: new[] { "AuthorId", "BookId" },
                keyValues: new object[] { 2016, 5031 });

            migrationBuilder.DeleteData(
                table: "BookAuthors",
                keyColumns: new[] { "AuthorId", "BookId" },
                keyValues: new object[] { 2017, 5032 });

            migrationBuilder.DeleteData(
                table: "BookAuthors",
                keyColumns: new[] { "AuthorId", "BookId" },
                keyValues: new object[] { 2018, 5033 });

            migrationBuilder.DeleteData(
                table: "BookAuthors",
                keyColumns: new[] { "AuthorId", "BookId" },
                keyValues: new object[] { 2019, 5034 });

            migrationBuilder.DeleteData(
                table: "BookAuthors",
                keyColumns: new[] { "AuthorId", "BookId" },
                keyValues: new object[] { 2020, 5035 });

            migrationBuilder.DeleteData(
                table: "BookAuthors",
                keyColumns: new[] { "AuthorId", "BookId" },
                keyValues: new object[] { 2021, 5036 });

            migrationBuilder.DeleteData(
                table: "BookAuthors",
                keyColumns: new[] { "AuthorId", "BookId" },
                keyValues: new object[] { 2022, 5037 });

            migrationBuilder.DeleteData(
                table: "BookAuthors",
                keyColumns: new[] { "AuthorId", "BookId" },
                keyValues: new object[] { 2023, 5038 });

            migrationBuilder.DeleteData(
                table: "BookAuthors",
                keyColumns: new[] { "AuthorId", "BookId" },
                keyValues: new object[] { 2024, 5039 });

            migrationBuilder.DeleteData(
                table: "BookAuthors",
                keyColumns: new[] { "AuthorId", "BookId" },
                keyValues: new object[] { 2025, 5040 });

            migrationBuilder.DeleteData(
                table: "BookAuthors",
                keyColumns: new[] { "AuthorId", "BookId" },
                keyValues: new object[] { 2026, 5041 });

            migrationBuilder.DeleteData(
                table: "BookAuthors",
                keyColumns: new[] { "AuthorId", "BookId" },
                keyValues: new object[] { 2026, 5042 });

            migrationBuilder.DeleteData(
                table: "BookAuthors",
                keyColumns: new[] { "AuthorId", "BookId" },
                keyValues: new object[] { 2027, 5043 });

            migrationBuilder.DeleteData(
                table: "BookAuthors",
                keyColumns: new[] { "AuthorId", "BookId" },
                keyValues: new object[] { 2028, 5044 });

            migrationBuilder.DeleteData(
                table: "BookAuthors",
                keyColumns: new[] { "AuthorId", "BookId" },
                keyValues: new object[] { 2029, 5045 });

            migrationBuilder.DeleteData(
                table: "BookAuthors",
                keyColumns: new[] { "AuthorId", "BookId" },
                keyValues: new object[] { 2028, 5046 });

            migrationBuilder.DeleteData(
                table: "BookAuthors",
                keyColumns: new[] { "AuthorId", "BookId" },
                keyValues: new object[] { 2029, 5047 });

            migrationBuilder.DeleteData(
                table: "BookAuthors",
                keyColumns: new[] { "AuthorId", "BookId" },
                keyValues: new object[] { 2021, 5048 });

            migrationBuilder.DeleteData(
                table: "BookAuthors",
                keyColumns: new[] { "AuthorId", "BookId" },
                keyValues: new object[] { 2021, 5049 });

            migrationBuilder.DeleteData(
                table: "BookAuthors",
                keyColumns: new[] { "AuthorId", "BookId" },
                keyValues: new object[] { 2022, 5050 });

            migrationBuilder.DeleteData(
                table: "BookAuthors",
                keyColumns: new[] { "AuthorId", "BookId" },
                keyValues: new object[] { 2023, 5051 });

            migrationBuilder.DeleteData(
                table: "BookAuthors",
                keyColumns: new[] { "AuthorId", "BookId" },
                keyValues: new object[] { 2023, 5052 });

            migrationBuilder.DeleteData(
                table: "BookAuthors",
                keyColumns: new[] { "AuthorId", "BookId" },
                keyValues: new object[] { 2014, 5053 });

            migrationBuilder.DeleteData(
                table: "BookAuthors",
                keyColumns: new[] { "AuthorId", "BookId" },
                keyValues: new object[] { 2017, 5054 });

            migrationBuilder.DeleteData(
                table: "BookAuthors",
                keyColumns: new[] { "AuthorId", "BookId" },
                keyValues: new object[] { 2024, 5055 });

            migrationBuilder.DeleteData(
                table: "BookAuthors",
                keyColumns: new[] { "AuthorId", "BookId" },
                keyValues: new object[] { 2024, 5056 });

            migrationBuilder.DeleteData(
                table: "BookAuthors",
                keyColumns: new[] { "AuthorId", "BookId" },
                keyValues: new object[] { 2025, 5057 });

            migrationBuilder.DeleteData(
                table: "BookAuthors",
                keyColumns: new[] { "AuthorId", "BookId" },
                keyValues: new object[] { 2014, 5058 });

            migrationBuilder.DeleteData(
                table: "BookAuthors",
                keyColumns: new[] { "AuthorId", "BookId" },
                keyValues: new object[] { 2016, 5059 });

            migrationBuilder.DeleteData(
                table: "BookAuthors",
                keyColumns: new[] { "AuthorId", "BookId" },
                keyValues: new object[] { 2021, 5060 });

            migrationBuilder.DeleteData(
                table: "BookAuthors",
                keyColumns: new[] { "AuthorId", "BookId" },
                keyValues: new object[] { 2027, 5061 });

            migrationBuilder.DeleteData(
                table: "BookAuthors",
                keyColumns: new[] { "AuthorId", "BookId" },
                keyValues: new object[] { 2023, 5062 });

            migrationBuilder.DeleteData(
                table: "BookAuthors",
                keyColumns: new[] { "AuthorId", "BookId" },
                keyValues: new object[] { 2022, 5063 });

            migrationBuilder.DeleteData(
                table: "BookAuthors",
                keyColumns: new[] { "AuthorId", "BookId" },
                keyValues: new object[] { 2029, 5064 });

            migrationBuilder.DeleteData(
                table: "BookAuthors",
                keyColumns: new[] { "AuthorId", "BookId" },
                keyValues: new object[] { 2026, 5065 });

            migrationBuilder.DeleteData(
                table: "BookAuthors",
                keyColumns: new[] { "AuthorId", "BookId" },
                keyValues: new object[] { 2024, 5066 });

            migrationBuilder.DeleteData(
                table: "BookAuthors",
                keyColumns: new[] { "AuthorId", "BookId" },
                keyValues: new object[] { 2025, 5067 });

            migrationBuilder.DeleteData(
                table: "BookAuthors",
                keyColumns: new[] { "AuthorId", "BookId" },
                keyValues: new object[] { 2021, 5068 });

            migrationBuilder.DeleteData(
                table: "BookAuthors",
                keyColumns: new[] { "AuthorId", "BookId" },
                keyValues: new object[] { 2027, 5069 });

            migrationBuilder.DeleteData(
                table: "BookAuthors",
                keyColumns: new[] { "AuthorId", "BookId" },
                keyValues: new object[] { 2029, 5070 });

            migrationBuilder.DeleteData(
                table: "BookAuthors",
                keyColumns: new[] { "AuthorId", "BookId" },
                keyValues: new object[] { 2023, 5071 });

            migrationBuilder.DeleteData(
                table: "BookAuthors",
                keyColumns: new[] { "AuthorId", "BookId" },
                keyValues: new object[] { 2025, 5072 });

            migrationBuilder.DeleteData(
                table: "BookAuthors",
                keyColumns: new[] { "AuthorId", "BookId" },
                keyValues: new object[] { 2029, 5073 });

            migrationBuilder.DeleteData(
                table: "BookAuthors",
                keyColumns: new[] { "AuthorId", "BookId" },
                keyValues: new object[] { 2021, 5074 });

            migrationBuilder.DeleteData(
                table: "BookAuthors",
                keyColumns: new[] { "AuthorId", "BookId" },
                keyValues: new object[] { 2023, 5075 });

            migrationBuilder.DeleteData(
                table: "BookAuthors",
                keyColumns: new[] { "AuthorId", "BookId" },
                keyValues: new object[] { 2021, 5076 });

            migrationBuilder.DeleteData(
                table: "BookAuthors",
                keyColumns: new[] { "AuthorId", "BookId" },
                keyValues: new object[] { 2022, 5077 });

            migrationBuilder.DeleteData(
                table: "BookAuthors",
                keyColumns: new[] { "AuthorId", "BookId" },
                keyValues: new object[] { 2016, 5078 });

            migrationBuilder.DeleteData(
                table: "BookAuthors",
                keyColumns: new[] { "AuthorId", "BookId" },
                keyValues: new object[] { 2010, 5079 });

            migrationBuilder.DeleteData(
                table: "BookAuthors",
                keyColumns: new[] { "AuthorId", "BookId" },
                keyValues: new object[] { 2017, 5080 });

            migrationBuilder.DeleteData(
                table: "BookAuthors",
                keyColumns: new[] { "AuthorId", "BookId" },
                keyValues: new object[] { 2014, 5081 });

            migrationBuilder.DeleteData(
                table: "BookAuthors",
                keyColumns: new[] { "AuthorId", "BookId" },
                keyValues: new object[] { 2005, 5082 });

            migrationBuilder.DeleteData(
                table: "BookAuthors",
                keyColumns: new[] { "AuthorId", "BookId" },
                keyValues: new object[] { 2012, 5083 });

            migrationBuilder.DeleteData(
                table: "BookAuthors",
                keyColumns: new[] { "AuthorId", "BookId" },
                keyValues: new object[] { 2023, 5084 });

            migrationBuilder.DeleteData(
                table: "BookAuthors",
                keyColumns: new[] { "AuthorId", "BookId" },
                keyValues: new object[] { 2015, 5085 });

            migrationBuilder.DeleteData(
                table: "BookAuthors",
                keyColumns: new[] { "AuthorId", "BookId" },
                keyValues: new object[] { 2014, 5086 });

            migrationBuilder.DeleteData(
                table: "BookAuthors",
                keyColumns: new[] { "AuthorId", "BookId" },
                keyValues: new object[] { 2008, 5087 });

            migrationBuilder.DeleteData(
                table: "BookAuthors",
                keyColumns: new[] { "AuthorId", "BookId" },
                keyValues: new object[] { 2026, 5088 });

            migrationBuilder.DeleteData(
                table: "BookAuthors",
                keyColumns: new[] { "AuthorId", "BookId" },
                keyValues: new object[] { 2021, 5089 });

            migrationBuilder.DeleteData(
                table: "BookAuthors",
                keyColumns: new[] { "AuthorId", "BookId" },
                keyValues: new object[] { 2021, 5090 });

            migrationBuilder.DeleteData(
                table: "BookAuthors",
                keyColumns: new[] { "AuthorId", "BookId" },
                keyValues: new object[] { 2023, 5091 });

            migrationBuilder.DeleteData(
                table: "BookAuthors",
                keyColumns: new[] { "AuthorId", "BookId" },
                keyValues: new object[] { 2022, 5092 });

            migrationBuilder.DeleteData(
                table: "BookAuthors",
                keyColumns: new[] { "AuthorId", "BookId" },
                keyValues: new object[] { 2026, 5093 });

            migrationBuilder.DeleteData(
                table: "BookAuthors",
                keyColumns: new[] { "AuthorId", "BookId" },
                keyValues: new object[] { 2028, 5094 });

            migrationBuilder.DeleteData(
                table: "BookAuthors",
                keyColumns: new[] { "AuthorId", "BookId" },
                keyValues: new object[] { 2027, 5095 });

            migrationBuilder.DeleteData(
                table: "BookAuthors",
                keyColumns: new[] { "AuthorId", "BookId" },
                keyValues: new object[] { 2021, 5096 });

            migrationBuilder.DeleteData(
                table: "BookAuthors",
                keyColumns: new[] { "AuthorId", "BookId" },
                keyValues: new object[] { 2024, 5097 });

            migrationBuilder.DeleteData(
                table: "BookAuthors",
                keyColumns: new[] { "AuthorId", "BookId" },
                keyValues: new object[] { 2022, 5098 });

            migrationBuilder.DeleteData(
                table: "BookAuthors",
                keyColumns: new[] { "AuthorId", "BookId" },
                keyValues: new object[] { 2025, 5099 });

            migrationBuilder.DeleteData(
                table: "BookAuthors",
                keyColumns: new[] { "AuthorId", "BookId" },
                keyValues: new object[] { 2023, 5100 });

            migrationBuilder.DeleteData(
                table: "BookAuthors",
                keyColumns: new[] { "AuthorId", "BookId" },
                keyValues: new object[] { 2022, 5101 });

            migrationBuilder.DeleteData(
                table: "BookAuthors",
                keyColumns: new[] { "AuthorId", "BookId" },
                keyValues: new object[] { 2023, 5102 });

            migrationBuilder.DeleteData(
                table: "BookAuthors",
                keyColumns: new[] { "AuthorId", "BookId" },
                keyValues: new object[] { 2022, 5103 });

            migrationBuilder.DeleteData(
                table: "BookAuthors",
                keyColumns: new[] { "AuthorId", "BookId" },
                keyValues: new object[] { 2027, 5104 });

            migrationBuilder.DeleteData(
                table: "BookAuthors",
                keyColumns: new[] { "AuthorId", "BookId" },
                keyValues: new object[] { 2026, 5105 });

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 3019);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 2016);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 2017);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 2018);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 2019);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 2020);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 2021);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 2022);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 2023);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 2024);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 2025);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 2026);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 2027);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 2028);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 2029);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 5031);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 5032);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 5033);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 5034);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 5035);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 5036);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 5037);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 5038);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 5039);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 5040);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 5041);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 5042);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 5043);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 5044);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 5045);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 5046);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 5047);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 5048);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 5049);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 5050);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 5051);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 5052);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 5053);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 5054);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 5055);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 5056);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 5057);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 5058);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 5059);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 5060);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 5061);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 5062);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 5063);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 5064);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 5065);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 5066);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 5067);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 5068);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 5069);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 5070);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 5071);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 5072);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 5073);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 5074);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 5075);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 5076);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 5077);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 5078);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 5079);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 5080);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 5081);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 5082);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 5083);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 5084);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 5085);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 5086);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 5087);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 5088);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 5089);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 5090);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 5091);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 5092);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 5093);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 5094);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 5095);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 5096);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 5097);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 5098);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 5099);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 5100);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 5101);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 5102);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 5103);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 5104);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 5105);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 3016);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 3017);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 3018);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 3020);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 3021);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 3022);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 3023);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 3024);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 3025);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 3026);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 3027);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 3028);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 3029);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 3030);

            migrationBuilder.DeleteData(
                table: "Publishers",
                keyColumn: "PublisherId",
                keyValue: 4009);

            migrationBuilder.DeleteData(
                table: "Publishers",
                keyColumn: "PublisherId",
                keyValue: 4010);

            migrationBuilder.DeleteData(
                table: "Publishers",
                keyColumn: "PublisherId",
                keyValue: 4011);

            migrationBuilder.DeleteData(
                table: "Publishers",
                keyColumn: "PublisherId",
                keyValue: 4012);

            migrationBuilder.DeleteData(
                table: "Publishers",
                keyColumn: "PublisherId",
                keyValue: 4013);

            migrationBuilder.DeleteData(
                table: "Publishers",
                keyColumn: "PublisherId",
                keyValue: 4014);

            migrationBuilder.DeleteData(
                table: "Publishers",
                keyColumn: "PublisherId",
                keyValue: 4015);

            migrationBuilder.DeleteData(
                table: "Publishers",
                keyColumn: "PublisherId",
                keyValue: 4016);
        }
    }
}
