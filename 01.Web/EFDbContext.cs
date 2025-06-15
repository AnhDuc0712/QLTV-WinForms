using Microsoft.EntityFrameworkCore;
using QLTV.Models;
using System;

namespace QLTV
{
    public class LibraryContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Publisher> Publishers { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<BookAuthor> BookAuthors { get; set; }
        public DbSet<BorrowReceipt> BorrowReceipts { get; set; }
        public DbSet<BorrowDetail> BorrowDetails { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer(
                System.Configuration.ConfigurationManager
                    .ConnectionStrings["LibraryDb"].ConnectionString
            );
        }

        protected override void OnModelCreating(ModelBuilder model)
        {
            // ----- Cấu hình Identity seed cho mỗi bảng -----
            model.Entity<User>()
                 .Property(u => u.UserId)
                 .UseIdentityColumn(seed: 1001, increment: 1);

            model.Entity<Author>()
                 .Property(a => a.AuthorId)
                 .UseIdentityColumn(seed: 2001, increment: 1);

            model.Entity<Category>()
                 .Property(c => c.CategoryId)
                 .UseIdentityColumn(seed: 3001, increment: 1);

            model.Entity<Publisher>()
                 .Property(p => p.PublisherId)
                 .UseIdentityColumn(seed: 4001, increment: 1);

            model.Entity<Book>()
                 .Property(b => b.BookId)
                 .UseIdentityColumn(seed: 5001, increment: 1);

            model.Entity<BorrowReceipt>()
                 .Property(br => br.ReceiptId)
                 .UseIdentityColumn(seed: 6001, increment: 1);

            // ----- Composite keys -----
            model.Entity<BookAuthor>()
                 .HasKey(ba => new { ba.BookId, ba.AuthorId });
            model.Entity<BorrowDetail>()
                 .HasKey(bd => new { bd.ReceiptId, bd.BookId });
            model.Entity<User>()
                .HasDiscriminator<string>("UserType")
                .HasValue<Employee>("Employee")
                .HasValue<Customer>("Customer");

            // 2) Check Constraint
            model.Entity<User>(entity =>
            {
                // 1) Đặt discriminator như bình thường
                entity.HasDiscriminator<string>("UserType")
                      .HasValue<Employee>("Employee")
                      .HasValue<Customer>("Customer");

                // 2) Chèn CHECK CONSTRAINT qua ToTable()
                entity.ToTable(table => table.HasCheckConstraint(
                    name: "CK_Users_Password_NotNull_IfEmployee",
                    sql: "(UserType = 'Customer' AND Password IS NULL)"
                       + " OR (UserType = 'Employee' AND Password IS NOT NULL)"
                ));
            });


            // ----- Seed data -----

            // Categories
            model.Entity<Category>().HasData(
                new Category { CategoryId = 3001, Name = "Văn học Việt Nam" },
                new Category { CategoryId = 3002, Name = "Văn học nước ngoài" },
                new Category { CategoryId = 3003, Name = "Nghiên cứu khoa học" },
                new Category { CategoryId = 3004, Name = "Lịch sử – Địa lý" },
                new Category { CategoryId = 3005, Name = "Công nghệ thông tin" },
                new Category { CategoryId = 3006, Name = "Tâm lý – Kỹ năng sống" },
                new Category { CategoryId = 3007, Name = "Thiếu nhi" },
                new Category { CategoryId = 3008, Name = "Kinh tế – Quản trị" },
                new Category { CategoryId = 3009, Name = "Y học – Sức khỏe" },
                new Category { CategoryId = 3010, Name = "Nghệ thuật – Kiến trúc" },
                new Category { CategoryId = 3011, Name = "Truyện tranh – Manga" },
                new Category { CategoryId = 3012, Name = "Tự lực – Phát triển bản thân" },
                new Category { CategoryId = 3013, Name = "Thơ ca" },
                new Category { CategoryId = 3014, Name = "Du lịch – Khám phá" },
                new Category { CategoryId = 3015, Name = "Ẩm thực – Nấu ăn" },
                new Category { CategoryId = 3016, Name = "Văn học trẻ" },
                new Category { CategoryId = 3017, Name = "Tiểu thuyết trinh thám" },
                new Category { CategoryId = 3018, Name = "Kinh dị – Giật gân" },
                new Category { CategoryId = 3019, Name = "Thơ cách mạng" },
                new Category { CategoryId = 3020, Name = "Tôn giáo – Triết học" },
                new Category { CategoryId = 3021, Name = "Khoa học viễn tưởng" },
                new Category { CategoryId = 3022, Name = "Lãng mạn – Tình cảm" },
                new Category { CategoryId = 3023, Name = "Phát triển bản thân" },
                new Category { CategoryId = 3024, Name = "Kinh doanh – Khởi nghiệp" },
                new Category { CategoryId = 3025, Name = "Sách kỹ năng mềm" },
                new Category { CategoryId = 3026, Name = "Văn hóa – Xã hội" },
                new Category { CategoryId = 3027, Name = "Sách thiếu nhi – Thiếu niên" },
                new Category { CategoryId = 3028, Name = "Sách luật pháp" },
                new Category { CategoryId = 3029, Name = "Sách đại học" },
                new Category { CategoryId = 3030, Name = "Sách chuyên ngành y" }
            );

            // Publishers
            model.Entity<Publisher>().HasData(
                new Publisher { PublisherId = 4001, Name = "NXB Giáo dục Việt Nam" },
                new Publisher { PublisherId = 4002, Name = "NXB Văn hóa – Thông tin" },
                new Publisher { PublisherId = 4003, Name = "NXB Khoa học và Kỹ thuật" },
                new Publisher { PublisherId = 4004, Name = "NXB Trẻ" },
                new Publisher { PublisherId = 4005, Name = "NXB Kim Đồng" },
                new Publisher { PublisherId = 4006, Name = "NXB Thống Kê" },
                new Publisher { PublisherId = 4007, Name = "NXB Đại học Quốc gia" },
                new Publisher { PublisherId = 4008, Name = "NXB Công nghệ Thông tin" },
                new Publisher { PublisherId = 4009, Name = "NXB Hội Nhà văn" },
                new Publisher { PublisherId = 4010, Name = "NXB Văn học" },
                new Publisher { PublisherId = 4011, Name = "NXB Phụ nữ" },
                new Publisher { PublisherId = 4012, Name = "NXB Tri thức" },
                new Publisher { PublisherId = 4013, Name = "NXB Phương Đông" },
                new Publisher { PublisherId = 4014, Name = "NXB Văn học Đông Á" },
                new Publisher { PublisherId = 4015, Name = "NXB Đại học Quốc gia TP.HCM" },
                new Publisher { PublisherId = 4016, Name = "NXB An ninh quốc gia" }

            );

            // Authors
            model.Entity<Author>().HasData(
                new Author { AuthorId = 2001, Name = "Nguyễn Nhật Ánh" },
                new Author { AuthorId = 2002, Name = "Hermione Granger" },
                new Author { AuthorId = 2003, Name = "Paulo Coelho" },
                new Author { AuthorId = 2004, Name = "Stephen Hawking" },
                new Author { AuthorId = 2005, Name = "Yuval Noah Harari" },
                new Author { AuthorId = 2006, Name = "J.K. Rowling" },
                new Author { AuthorId = 2007, Name = "Daniel Kahneman" },
                new Author { AuthorId = 2008, Name = "Tony Robbins" },
                new Author { AuthorId = 2009, Name = "Malcolm Gladwell" },
                new Author { AuthorId = 2010, Name = "George Orwell" },
                new Author { AuthorId = 2011, Name = "Harper Lee" },
                new Author { AuthorId = 2012, Name = "Fyodor Dostoevsky" },
                new Author { AuthorId = 2013, Name = "Gabriel Garcia Marquez" },
                new Author { AuthorId = 2014, Name = "Isaac Asimov" },
                new Author { AuthorId = 2015, Name = "Sun Tzu" },
                new Author { AuthorId = 2016, Name = "Ernest Hemingway" },
                new Author { AuthorId = 2017, Name = "Agatha Christie" },
                new Author { AuthorId = 2018, Name = "Edgar Allan Poe" },
                new Author { AuthorId = 2019, Name = "Ralph Waldo Emerson" },
                new Author { AuthorId = 2020, Name = "Đỗ Phấn" },
                new Author { AuthorId = 2021, Name = "Arthur C. Clarke" },
                new Author { AuthorId = 2022, Name = "Nicholas Sparks" },
                new Author { AuthorId = 2023, Name = "Dale Carnegie" },
                new Author { AuthorId = 2024, Name = "Robert Kiyosaki" },
                new Author { AuthorId = 2025, Name = "Stephen R. Covey" },
                new Author { AuthorId = 2026, Name = "Nguyễn Trãi" },
                new Author { AuthorId = 2027, Name = "William Shakespeare" },
                new Author { AuthorId = 2028, Name = "Sigmund Freud" },
                new Author { AuthorId = 2029, Name = "Noam Chomsky" },
                new Author { AuthorId = 2030, Name = "Trần Đại Nghĩa" }
            );

            // Users (3 bản ghi với địa chỉ chi tiết)
            model.Entity<User>().HasData(
                new User
                {
                    UserId = 1001,
                    FullName = "Nguyễn Văn Vũ",
                    Email = "vanvu@gmail.com",
                    Username = "nguyenvanvu",
                    Address = "Số 12, ngõ 34 Phố Hoàng Hoa Thám, Quận Ba Đình, Hà Nội",
                    Phone = "0912345678",
                    UserType = "Customer"
                },
                new User
                {
                    UserId = 1002,
                    FullName = "Trần Thị Ba",
                    Email = "thiba@gmail.com",
                    Username = "tranthiba",
                    Address = "Số 45, Đường 3/2, Phường Hưng Lợi, Quận Ninh Kiều, TP. Cần Thơ",
                    Phone = "0987654321",
                    UserType = "Customer"

                },
                new User
                {
                    UserId = 1003,
                    FullName = "Lê Văn Chi",
                    Email = "vanchi@gmail.com",
                    Username = "levanchi",
                    Address = "Số 78, Phố Nguyễn Văn Cừ, Phường Gia Thuỷ, TP. Bắc Ninh",
                    Phone = "0901234567",
                    UserType = "Customer"

                },
                new User
                {
                    UserId = 1004,
                    FullName = "Phạm Thị Dung",
                    Email = "dungpham@gmail.com",
                    Username = "phamthidung",
                    Address = "Số 22, Đường Láng Hạ, Phường Láng Hạ, Quận Đống Đa, Hà Nội",
                    Phone = "0918765432",
                    UserType = "Customer"
                },
                new User
                {
                    UserId = 1005,
                    FullName = "Võ Văn An",
                    Email = "anvo@gmail.com",
                    Username = "vovan_an",
                    Address = "Số 99, Đường Trần Phú, Phường 5, TP. Vũng Tàu",
                    Phone = "0932123456",
                    UserType = "Customer"
                },
                new User
                {
                    UserId = 1006,
                    FullName = "Lý Thị Hiền",
                    Email = "hienly@gmail.com",
                    Username = "lythihien",
                    Address = "Số 5, Phố Hoàng Diệu, Phường Hải Châu 1, Quận Hải Châu, Đà Nẵng",
                    Phone = "0983344556",
                    UserType = "Customer"
                },
                new User
                {
                    UserId = 1007,
                    FullName = "Ngô Minh Tuấn",
                    Email = "tuanngo@gmail.com",
                    Username = "ngominhtuan",
                    Address = "Số 150, Đường Cách Mạng Tháng 8, Phường Bến Thành, Quận 1, TP. Hồ Chí Minh",
                    Phone = "0909988776",
                    UserType = "Customer"
                },
                new User
                {
                    UserId = 1008,
                    FullName = "Đặng Thị Lan",
                    Email = "lan.dang@gmail.com",
                    Username = "dangthilan",
                    Address = "Số 10, Đường Hai Bà Trưng, Phường Phạm Ngũ Lão, Quận 1, TP. Hồ Chí Minh",
                    Phone = "0911223344",
                    UserType = "Customer"
                },
                new User
                {
                    UserId = 1009,
                    FullName = "Phan Văn Hòa",
                    Email = "vanhoa.phan@gmail.com",
                    Username = "phanvanhoa",
                    Address = "Số 8, Đường Nguyễn Thị Minh Khai, Phường 1, TP. Vĩnh Long",
                    Phone = "0977554433",
                    UserType = "Customer"
                },
                new User
                {
                    UserId = 1010,
                    FullName = "Trương Thị Mai",
                    Email = "maitruong@gmail.com",
                    Username = "truongthimai",
                    Address = "Số 120, Đường Phan Đình Phùng, Phường Thành Nhất, TP. Buôn Ma Thuột",
                    Phone = "0911335577",
                    UserType = "Customer"
                },
                new User
                {
                    UserId = 1011,
                    FullName = "Bùi Quốc Việt",
                    Email = "quocviet.bui@gmail.com",
                    Username = "buiquo cviet",
                    Address = "Số 33, Phố Lý Thường Kiệt, Phường Phủ Hà, TP. Lạng Sơn",
                    Phone = "0987665544",
                    UserType = "Customer"
                },
                new User
                {
                    UserId = 1012,
                    FullName = "Lê Thị Phương",
                    Email = "phuongle@gmail.com",
                    Username = "lethiphuong",
                    Address = "Số 27, Đường Hùng Vương, Phường Mỹ Xuyên, TP. Sóc Trăng",
                    Phone = "0968877665",
                    UserType = "Customer"
                },
                new User
                {
                    UserId = 1013,
                    FullName = "Đỗ Minh Tú",
                    Email = "minhtu.do@gmail.com",
                    Username = "dominhtu",
                    Address = "Số 55, Đường Trần Hưng Đạo, Phường Lê Lợi, TP. Nam Định",
                    Phone = "0933445566",
                    UserType = "Customer"
                },
                new User
                {
                    UserId = 1014,
                    FullName = "Phạm Minh Quân",
                    Email = "minhquan.pham@gmail.com",
                    Username = "phamminhquan",
                    Address = "Số 18, Đường Lê Lợi, Phường An Lạc, TP. Biên Hòa",
                    Phone = "0914556677",
                    UserType = "Customer"
                },
                new User
                {
                    UserId = 1015,
                    FullName = "Vũ Thị Ngọc",
                    Email = "ngocvu@gmail.com",
                    Username = "vuthingoc",
                    Address = "Số 66, Phố Trần Nhân Tông, Phường Nam Đàn, TP. Thanh Hóa",
                    Phone = "0988112233",
                    UserType = "Customer"
                },
                new User
                {
                    UserId = 1016,
                    FullName = "Nguyễn Quốc Cường",
                    Email = "quoccuong.nguyen@gmail.com",
                    Username = "nguyencuong",
                    Address = "Số 102, Đường Trần Phú, Phường Xuân Phú, TP. Huế",
                    Phone = "0902334455",
                    UserType = "Customer"
                },
                new User
                {
                    UserId = 1017,
                    FullName = "Lê Thúy Hằng",
                    Email = "thuyhang.le@gmail.com",
                    Username = "lethuyhang",
                    Address = "Số 5, Đường Nguyễn Văn Trỗi, Phường Đông Vệ, TP. Thanh Hóa",
                    Phone = "0977665544",
                    UserType = "Customer"
                },
                new User
                {
                    UserId = 1018,
                    FullName = "Trần Anh Tuấn",
                    Email = "anhtuan.tran@gmail.com",
                    Username = "trananhtuan",
                    Address = "Số 250, Đường Nguyễn Thái Học, Phường Phan Chu Trinh, TP. Quy Nhơn",
                    Phone = "0933667788",
                    UserType = "Customer"
                },
                new User
                {
                    UserId = 1019,
                    FullName = "Phan Thị Hạnh",
                    Email = "hanhphan@gmail.com",
                    Username = "phanthihanh",
                    Address = "Số 14, Đường Nguyễn Huệ, Phường Phước Ninh, TP. Đà Nẵng",
                    Phone = "0901778899",
                    UserType = "Customer"
                },
                new User
                {
                    UserId = 1020,
                    FullName = "Trương Văn Sơn",
                    Email = "sontruong@gmail.com",
                    Username = "truongvanson",
                    Address = "Số 77, Phố Phan Đình Phùng, Phường Đội Cấn, Quận Ba Đình, Hà Nội",
                    Phone = "0977001122",
                    UserType = "Customer"
                },
                new User
                {
                    UserId = 1021,
                    FullName = "Lê Minh Tâm",
                    Email = "leminhtam@gmail.com",
                    Username = "leminhtam",
                    Address = "Số 33, Đường Trần Khánh Dư, Phường Trần Hưng Đạo, Quận Hoàn Kiếm, Hà Nội",
                    Phone = "0912993344",
                    UserType = "Customer"
                },
                new User
                {
                    UserId = 1022,
                    FullName = "Đặng Văn Phúc",
                    Email = "phucdang@gmail.com",
                    Username = "dangvanphuc",
                    Address = "Số 55, Đường Đinh Tiên Hoàng, Phường Bến Nghé, Quận 1, TP. Hồ Chí Minh",
                    Phone = "0933100234",
                    UserType = "Customer"
                },
                new User
                {
                    UserId = 1023,
                    FullName = "Võ Thị Kiều",
                    Email = "kieuvo@gmail.com",
                    Username = "vothikieu",
                    Address = "Số 99, Đường Lý Tự Trọng, Phường Phú Hòa, TP. Thủ Dầu Một",
                    Phone = "0988776655",
                    UserType = "Customer"
                }



            );

            // Books
            model.Entity<Book>().HasData(
                new Book { BookId = 5001, Title = "Dế Mèn Phiêu Lưu Ký", CategoryId = 3007, PublisherId = 4005, StockQuantity = 12, ImageUrl = null },
                new Book { BookId = 5002, Title = "Hoàng Tử Bé", CategoryId = 3002, PublisherId = 4002, StockQuantity = 8, ImageUrl = null },
                new Book { BookId = 5003, Title = "Nhà Giả Kim", CategoryId = 3001, PublisherId = 4004, StockQuantity = 5, ImageUrl = null },
                new Book { BookId = 5004, Title = "Lược Sử Thời Gian", CategoryId = 3003, PublisherId = 4003, StockQuantity = 3, ImageUrl = null },
                new Book { BookId = 5005, Title = "Sapiens: Lược Sử Loài Người", CategoryId = 3004, PublisherId = 4003, StockQuantity = 4, ImageUrl = null },
                new Book { BookId = 5006, Title = "Harry Potter và Hòn Đá Phù Thủy", CategoryId = 3007, PublisherId = 4005, StockQuantity = 6, ImageUrl = null },
                new Book { BookId = 5007, Title = "Tư Duy, Nhanh và Chậm", CategoryId = 3006, PublisherId = 4008, StockQuantity = 10, ImageUrl = null },
                new Book { BookId = 5008, Title = "Cấu Trúc Dữ Liệu và Giải Thuật", CategoryId = 3005, PublisherId = 4008, StockQuantity = 2, ImageUrl = null },
                new Book { BookId = 5009, Title = "Trên Đường", CategoryId = 3001, PublisherId = 4002, StockQuantity = 5, ImageUrl = null },
                new Book { BookId = 5010, Title = "21 Bài Học Cho Thế Kỷ 21", CategoryId = 3006, PublisherId = 4001, StockQuantity = 4, ImageUrl = null },
                new Book { BookId = 5011, Title = "1984", CategoryId = 3002, PublisherId = 4002, StockQuantity = 7, ImageUrl = null },
                new Book { BookId = 5012, Title = "To Kill a Mockingbird", CategoryId = 3002, PublisherId = 4002, StockQuantity = 5, ImageUrl = null },
                new Book { BookId = 5013, Title = "Tội Ác và Hình Phạt", CategoryId = 3001, PublisherId = 4003, StockQuantity = 6, ImageUrl = null },
                new Book { BookId = 5014, Title = "Nửa Xuân", CategoryId = 3001, PublisherId = 4001, StockQuantity = 4, ImageUrl = null },
                new Book { BookId = 5015, Title = "The Power of Habit", CategoryId = 3006, PublisherId = 4008, StockQuantity = 9, ImageUrl = null },
                new Book { BookId = 5016, Title = "Đi Tìm Lẽ Sống", CategoryId = 3006, PublisherId = 4001, StockQuantity = 11, ImageUrl = null },
                new Book { BookId = 5017, Title = "Chiến Tranh và Hòa Bình", CategoryId = 3004, PublisherId = 4003, StockQuantity = 3, ImageUrl = null },
                new Book { BookId = 5018, Title = "Bí Quyết Làm Giàu", CategoryId = 3008, PublisherId = 4008, StockQuantity = 8, ImageUrl = null },
                new Book { BookId = 5019, Title = "Artificial Intelligence Basics", CategoryId = 3005, PublisherId = 4008, StockQuantity = 2, ImageUrl = null },
                new Book { BookId = 5020, Title = "The Art of War", CategoryId = 3004, PublisherId = 4002, StockQuantity = 7, ImageUrl = null },
                new Book { BookId = 5021, Title = "One Piece – Tập 1", CategoryId = 3011, PublisherId = 4004, StockQuantity = 20, ImageUrl = null },
                new Book { BookId = 5022, Title = "Atomic Habits", CategoryId = 3012, PublisherId = 4008, StockQuantity = 15, ImageUrl = null },
                new Book { BookId = 5023, Title = "Thơ Trẻ – Cố Quận", CategoryId = 3013, PublisherId = 4002, StockQuantity = 8, ImageUrl = null },
                new Book { BookId = 5024, Title = "Lonely Planet Việt Nam", CategoryId = 3014, PublisherId = 4003, StockQuantity = 10, ImageUrl = null },
                new Book { BookId = 5025, Title = "MasterChef – Công Thức Nấu Ăn", CategoryId = 3015, PublisherId = 4005, StockQuantity = 12, ImageUrl = null },
                new Book { BookId = 5026, Title = "Doraemon – Tập 1", CategoryId = 3011, PublisherId = 4005, StockQuantity = 25, ImageUrl = null },
                new Book { BookId = 5027, Title = "How to Win Friends & Influence People", CategoryId = 3012, PublisherId = 4001, StockQuantity = 7, ImageUrl = null },
                new Book { BookId = 5028, Title = "Thơ Viết Cho Tuổi 20", CategoryId = 3013, PublisherId = 4007, StockQuantity = 5, ImageUrl = null },
                new Book { BookId = 5029, Title = "1001 Địa Điểm Việt Nam", CategoryId = 3014, PublisherId = 4006, StockQuantity = 9, ImageUrl = null },
                new Book { BookId = 5030, Title = "Cẩm Nang Nấu Ăn Gia Đình", CategoryId = 3015, PublisherId = 4006, StockQuantity = 14, ImageUrl = null },
                new Book { BookId = 5031, Title = "Ông già và biển cả", CategoryId = 3017, PublisherId = 4009, StockQuantity = 7, ImageUrl = null },
                new Book { BookId = 5032, Title = "Án mạng trên chuyến tàu tốc hành phương Đông", CategoryId = 3017, PublisherId = 4010, StockQuantity = 5, ImageUrl = null },
                new Book { BookId = 5033, Title = "Con quạ và các truyện khác", CategoryId = 3018, PublisherId = 4011, StockQuantity = 4, ImageUrl = null },
                new Book { BookId = 5034, Title = "Tản văn Du ký", CategoryId = 3016, PublisherId = 4009, StockQuantity = 6, ImageUrl = null },
                new Book { BookId = 5035, Title = "Tinh thần triết học", CategoryId = 3020, PublisherId = 4011, StockQuantity = 3, ImageUrl = null },
                new Book { BookId = 5036, Title = "2001: A Space Odyssey", CategoryId = 3021, PublisherId = 4012, StockQuantity = 5, ImageUrl = null },
                new Book { BookId = 5037, Title = "Notebook – Nhật ký tình yêu", CategoryId = 3022, PublisherId = 4013, StockQuantity = 8, ImageUrl = null },
                new Book { BookId = 5038, Title = "How to Win Friends", CategoryId = 3023, PublisherId = 4012, StockQuantity = 10, ImageUrl = null },
                new Book { BookId = 5039, Title = "Rich Dad Poor Dad", CategoryId = 3024, PublisherId = 4014, StockQuantity = 7, ImageUrl = null },
                new Book { BookId = 5040, Title = "7 Thói Quen Hiệu Quả", CategoryId = 3025, PublisherId = 4013, StockQuantity = 6, ImageUrl = null },
                new Book { BookId = 5041, Title = "Lược sử phát minh", CategoryId = 3026, PublisherId = 4015, StockQuantity = 5, ImageUrl = null },
                new Book { BookId = 5042, Title = "Harry Potter và Phòng Chứa Bí Ẩn", CategoryId = 3027, PublisherId = 4016, StockQuantity = 7, ImageUrl = null },
                new Book { BookId = 5043, Title = "Luật Dân sự Việt Nam", CategoryId = 3028, PublisherId = 4015, StockQuantity = 3, ImageUrl = null },
                new Book { BookId = 5044, Title = "Toán Cao Cấp – Đại cương", CategoryId = 3029, PublisherId = 4015, StockQuantity = 4, ImageUrl = null },
                new Book { BookId = 5045, Title = "Y học cổ truyền Việt Nam", CategoryId = 3030, PublisherId = 4016, StockQuantity = 6, ImageUrl = null },
                new Book { BookId = 5046, Title = "Lập Trình C# Toàn Tập", CategoryId = 3005, PublisherId = 4008, StockQuantity = 15, ImageUrl = null },
                new Book { BookId = 5047, Title = "Thiết Kế Kiến Trúc Phần Mềm", CategoryId = 3005, PublisherId = 4008, StockQuantity = 8, ImageUrl = null },
                new Book { BookId = 5048, Title = "Giải Thuật và Cấu Trúc Dữ Liệu", CategoryId = 3005, PublisherId = 4008, StockQuantity = 12, ImageUrl = null },
                new Book { BookId = 5049, Title = "An Ninh Mạng Cơ Bản", CategoryId = 3005, PublisherId = 4014, StockQuantity = 10, ImageUrl = null },
                new Book { BookId = 5050, Title = "Hướng Dẫn ReactJS", CategoryId = 3005, PublisherId = 4012, StockQuantity = 7, ImageUrl = null },
                new Book { BookId = 5051, Title = "Kỹ Năng Giao Tiếp Trong Công Việc", CategoryId = 3025, PublisherId = 4013, StockQuantity = 9, ImageUrl = null },
                new Book { BookId = 5052, Title = "Nghệ Thuật Thuyết Phục", CategoryId = 3025, PublisherId = 4013, StockQuantity = 6, ImageUrl = null },
                new Book { BookId = 5053, Title = "Quản Trị Mạng CCNA", CategoryId = 3005, PublisherId = 4008, StockQuantity = 5, ImageUrl = null },
                new Book { BookId = 5054, Title = "Phân Tích Dữ Liệu với Python", CategoryId = 3005, PublisherId = 4009, StockQuantity = 11, ImageUrl = null },
                new Book { BookId = 5055, Title = "Machine Learning Cơ Bản", CategoryId = 3005, PublisherId = 4014, StockQuantity = 4, ImageUrl = null },
                new Book { BookId = 5056, Title = "Deep Learning Cơ Bản", CategoryId = 3005, PublisherId = 4014, StockQuantity = 5, ImageUrl = null },
                new Book { BookId = 5057, Title = "Kỹ Năng Lãnh Đạo", CategoryId = 3025, PublisherId = 4013, StockQuantity = 8, ImageUrl = null },
                new Book { BookId = 5058, Title = "Phát Triển Ứng Dụng Android", CategoryId = 3005, PublisherId = 4008, StockQuantity = 7, ImageUrl = null },
                new Book { BookId = 5059, Title = "C# Trong Thực Tiễn", CategoryId = 3005, PublisherId = 4009, StockQuantity = 10, ImageUrl = null },
                new Book { BookId = 5060, Title = "Docker và Kubernetes", CategoryId = 3005, PublisherId = 4012, StockQuantity = 6, ImageUrl = null },
                new Book { BookId = 5061, Title = "Phân Tích Hành Vi Người Dùng", CategoryId = 3006, PublisherId = 4011, StockQuantity = 9, ImageUrl = null },
                new Book { BookId = 5062, Title = "Quản Trị Dự Án Agile", CategoryId = 3024, PublisherId = 4010, StockQuantity = 4, ImageUrl = null },
                new Book { BookId = 5063, Title = "Kiến Trúc Microservices", CategoryId = 3005, PublisherId = 4008, StockQuantity = 5, ImageUrl = null },
                new Book { BookId = 5064, Title = "Trò Chuyện Với Stanley", CategoryId = 3023, PublisherId = 4009, StockQuantity = 7, ImageUrl = null },
                new Book { BookId = 5065, Title = "Hành Trình Về Phương Đông", CategoryId = 3014, PublisherId = 4015, StockQuantity = 3, ImageUrl = null },
                new Book { BookId = 5066, Title = "Thiết Kế UX/UI Cơ Bản", CategoryId = 3005, PublisherId = 4012, StockQuantity = 8, ImageUrl = null },
                new Book { BookId = 5067, Title = "Phương Pháp Đặt Câu Hỏi", CategoryId = 3025, PublisherId = 4013, StockQuantity = 6, ImageUrl = null },
                new Book { BookId = 5068, Title = "Lập Trình Python", CategoryId = 3005, PublisherId = 4008, StockQuantity = 12, ImageUrl = null },
                new Book { BookId = 5069, Title = "An Toàn Thực Phẩm", CategoryId = 3009, PublisherId = 4006, StockQuantity = 5, ImageUrl = null },
                new Book { BookId = 5070, Title = "Kỹ Thuật Chụp Ảnh", CategoryId = 3014, PublisherId = 4002, StockQuantity = 7, ImageUrl = null },
                new Book { BookId = 5071, Title = "Quản Lý Nhân Sự Hiện Đại", CategoryId = 3024, PublisherId = 4010, StockQuantity = 4, ImageUrl = null },
                new Book { BookId = 5072, Title = "Sức Mạnh Thói Quen", CategoryId = 3012, PublisherId = 4014, StockQuantity = 9, ImageUrl = null },
                new Book { BookId = 5073, Title = "Ngôn Ngữ Cơ Thể", CategoryId = 3020, PublisherId = 4003, StockQuantity = 3, ImageUrl = null },
                new Book { BookId = 5074, Title = "Khoa Học Hành Vi", CategoryId = 3003, PublisherId = 4001, StockQuantity = 6, ImageUrl = null },
                new Book { BookId = 5075, Title = "Thuyết Trình Tuyệt Đỉnh", CategoryId = 3025, PublisherId = 4013, StockQuantity = 8, ImageUrl = null },
                new Book { BookId = 5076, Title = "Công Nghệ Blockchain", CategoryId = 3005, PublisherId = 4014, StockQuantity = 5, ImageUrl = null },
                new Book { BookId = 5077, Title = "Luật Hình Sự Cơ Bản", CategoryId = 3028, PublisherId = 4015, StockQuantity = 4, ImageUrl = null },
                new Book { BookId = 5078, Title = "Viết Kịch Bản Phim", CategoryId = 3016, PublisherId = 4009, StockQuantity = 7, ImageUrl = null },
                new Book { BookId = 5079, Title = "Âm Nhạc Thế Kỷ 21", CategoryId = 3010, PublisherId = 4002, StockQuantity = 5, ImageUrl = null },
                new Book { BookId = 5080, Title = "Khởi Nghiệp Tinh Gọn", CategoryId = 3024, PublisherId = 4010, StockQuantity = 6, ImageUrl = null },
                new Book { BookId = 5081, Title = "Xử Lý Ngôn Ngữ Tự Nhiên", CategoryId = 3005, PublisherId = 4008, StockQuantity = 9, ImageUrl = null },
                new Book { BookId = 5082, Title = "Psychology of Money", CategoryId = 3006, PublisherId = 4001, StockQuantity = 10, ImageUrl = null },
                new Book { BookId = 5083, Title = "Nghiên Cứu Thị Trường", CategoryId = 3024, PublisherId = 4012, StockQuantity = 5, ImageUrl = null },
                new Book { BookId = 5084, Title = "Châm Ngôn Thành Công", CategoryId = 3025, PublisherId = 4013, StockQuantity = 7, ImageUrl = null },
                new Book { BookId = 5085, Title = "Sách Về Thiền Định", CategoryId = 3006, PublisherId = 4006, StockQuantity = 4, ImageUrl = null },
                new Book { BookId = 5086, Title = "Lý Thuyết Âm Nhạc", CategoryId = 3010, PublisherId = 4002, StockQuantity = 6, ImageUrl = null },
                new Book { BookId = 5087, Title = "Dinh Dưỡng Học", CategoryId = 3009, PublisherId = 4006, StockQuantity = 5, ImageUrl = null },
                new Book { BookId = 5088, Title = "Thủy Văn Cơ Sở", CategoryId = 3029, PublisherId = 4015, StockQuantity = 3, ImageUrl = null },
                new Book { BookId = 5089, Title = "Lập Trình Web Toàn Tập", CategoryId = 3005, PublisherId = 4008, StockQuantity = 12, ImageUrl = null },
                new Book { BookId = 5090, Title = "Công Nghệ IoT", CategoryId = 3005, PublisherId = 4014, StockQuantity = 8, ImageUrl = null },
                new Book { BookId = 5091, Title = "Quản Trị Rủi Ro", CategoryId = 3024, PublisherId = 4010, StockQuantity = 5, ImageUrl = null },
                new Book { BookId = 5092, Title = "Thơ Tình Việt Nam", CategoryId = 3013, PublisherId = 4002, StockQuantity = 7, ImageUrl = null },
                new Book { BookId = 5093, Title = "Du Lịch Tây Bắc", CategoryId = 3014, PublisherId = 4015, StockQuantity = 6, ImageUrl = null },
                new Book { BookId = 5094, Title = "Quản Lý Dữ Liệu Lớn", CategoryId = 3005, PublisherId = 4009, StockQuantity = 4, ImageUrl = null },
                new Book { BookId = 5095, Title = "Toán Rời Rạc", CategoryId = 3029, PublisherId = 4015, StockQuantity = 5, ImageUrl = null },
                new Book { BookId = 5096, Title = "Blockchain trong Ngân Hàng", CategoryId = 3005, PublisherId = 4014, StockQuantity = 3, ImageUrl = null },
                new Book { BookId = 5097, Title = "Xử Lý Ảnh Số", CategoryId = 3005, PublisherId = 4008, StockQuantity = 7, ImageUrl = null },
                new Book { BookId = 5098, Title = "Phân Tích Tài Chính", CategoryId = 3024, PublisherId = 4010, StockQuantity = 5, ImageUrl = null },
                new Book { BookId = 5099, Title = "Hạt Giống Tâm Hồn", CategoryId = 3025, PublisherId = 4013, StockQuantity = 8, ImageUrl = null },
                new Book { BookId = 5100, Title = "Sách Về Chiến Lược", CategoryId = 3024, PublisherId = 4010, StockQuantity = 6, ImageUrl = null },
                new Book { BookId = 5101, Title = "Thiết Kế Game", CategoryId = 3005, PublisherId = 4008, StockQuantity = 9, ImageUrl = null },
                new Book { BookId = 5102, Title = "Quản Trị Công Nghệ", CategoryId = 3024, PublisherId = 4010, StockQuantity = 4, ImageUrl = null },
                new Book { BookId = 5103, Title = "Phát Triển iOS", CategoryId = 3005, PublisherId = 4009, StockQuantity = 7, ImageUrl = null },
                new Book { BookId = 5104, Title = "Thơ Trẻ", CategoryId = 3013, PublisherId = 4002, StockQuantity = 5, ImageUrl = null },
                new Book { BookId = 5105, Title = "Ẩm Thực Việt", CategoryId = 3015, PublisherId = 4005, StockQuantity = 10, ImageUrl = null }



            );

            // BookAuthor
            model.Entity<BookAuthor>().HasData(
                new BookAuthor { BookId = 5001, AuthorId = 2001 },
                new BookAuthor { BookId = 5002, AuthorId = 2003 },
                new BookAuthor { BookId = 5003, AuthorId = 2003 },
                new BookAuthor { BookId = 5004, AuthorId = 2004 },
                new BookAuthor { BookId = 5005, AuthorId = 2005 },
                new BookAuthor { BookId = 5006, AuthorId = 2006 },
                new BookAuthor { BookId = 5007, AuthorId = 2007 },
                new BookAuthor { BookId = 5008, AuthorId = 2014 },
                new BookAuthor { BookId = 5009, AuthorId = 2001 },
                new BookAuthor { BookId = 5010, AuthorId = 2005 },
                new BookAuthor { BookId = 5011, AuthorId = 2010 },
                new BookAuthor { BookId = 5012, AuthorId = 2011 },
                new BookAuthor { BookId = 5013, AuthorId = 2012 },
                new BookAuthor { BookId = 5014, AuthorId = 2001 },
                new BookAuthor { BookId = 5015, AuthorId = 2008 },
                new BookAuthor { BookId = 5016, AuthorId = 2002 },
                new BookAuthor { BookId = 5017, AuthorId = 2009 },
                new BookAuthor { BookId = 5018, AuthorId = 2008 },
                new BookAuthor { BookId = 5019, AuthorId = 2014 },
                new BookAuthor { BookId = 5020, AuthorId = 2015 },
                new BookAuthor { BookId = 5003, AuthorId = 2011 },
                new BookAuthor { BookId = 5007, AuthorId = 2009 },
                new BookAuthor { BookId = 5010, AuthorId = 2002 },
                new BookAuthor { BookId = 5016, AuthorId = 2005 },
                new BookAuthor { BookId = 5018, AuthorId = 2002 },
                new BookAuthor { BookId = 5031, AuthorId = 2016 },
                new BookAuthor { BookId = 5032, AuthorId = 2017 },
                new BookAuthor { BookId = 5033, AuthorId = 2018 },
                new BookAuthor { BookId = 5034, AuthorId = 2019 },
                new BookAuthor { BookId = 5035, AuthorId = 2020 },
                new BookAuthor { BookId = 5036, AuthorId = 2021 },
                new BookAuthor { BookId = 5037, AuthorId = 2022 },
                new BookAuthor { BookId = 5038, AuthorId = 2023 },
                new BookAuthor { BookId = 5039, AuthorId = 2024 },
                new BookAuthor { BookId = 5040, AuthorId = 2025 },
                new BookAuthor { BookId = 5041, AuthorId = 2026 },
                new BookAuthor { BookId = 5042, AuthorId = 2026 },
                new BookAuthor { BookId = 5043, AuthorId = 2027 },
                new BookAuthor { BookId = 5044, AuthorId = 2028 },
                new BookAuthor { BookId = 5045, AuthorId = 2029 },
                new BookAuthor { BookId = 5046, AuthorId = 2028 },
                new BookAuthor { BookId = 5047, AuthorId = 2029 },
                new BookAuthor { BookId = 5048, AuthorId = 2021 },
                new BookAuthor { BookId = 5049, AuthorId = 2021 },
                new BookAuthor { BookId = 5050, AuthorId = 2022 },
                new BookAuthor { BookId = 5051, AuthorId = 2023 },
                new BookAuthor { BookId = 5052, AuthorId = 2023 },
                new BookAuthor { BookId = 5053, AuthorId = 2014 },
                new BookAuthor { BookId = 5054, AuthorId = 2017 },
                new BookAuthor { BookId = 5055, AuthorId = 2024 },
                new BookAuthor { BookId = 5056, AuthorId = 2024 },
                new BookAuthor { BookId = 5057, AuthorId = 2025 },
                new BookAuthor { BookId = 5058, AuthorId = 2014 },
                new BookAuthor { BookId = 5059, AuthorId = 2016 },
                new BookAuthor { BookId = 5060, AuthorId = 2021 },
                new BookAuthor { BookId = 5061, AuthorId = 2027 },
                new BookAuthor { BookId = 5062, AuthorId = 2023 },
                new BookAuthor { BookId = 5063, AuthorId = 2022 },
                new BookAuthor { BookId = 5064, AuthorId = 2029 },
                new BookAuthor { BookId = 5065, AuthorId = 2026 },
                new BookAuthor { BookId = 5066, AuthorId = 2024 },
                new BookAuthor { BookId = 5067, AuthorId = 2025 },
                new BookAuthor { BookId = 5068, AuthorId = 2021 },
                new BookAuthor { BookId = 5069, AuthorId = 2027 },
                new BookAuthor { BookId = 5070, AuthorId = 2029 },
                new BookAuthor { BookId = 5071, AuthorId = 2023 },
                new BookAuthor { BookId = 5072, AuthorId = 2025 },
                new BookAuthor { BookId = 5073, AuthorId = 2029 },
                new BookAuthor { BookId = 5074, AuthorId = 2021 },
                new BookAuthor { BookId = 5075, AuthorId = 2023 },
                new BookAuthor { BookId = 5076, AuthorId = 2021 },
                new BookAuthor { BookId = 5077, AuthorId = 2022 },
                new BookAuthor { BookId = 5078, AuthorId = 2016 },
                new BookAuthor { BookId = 5079, AuthorId = 2010 },
                new BookAuthor { BookId = 5080, AuthorId = 2017 },
                new BookAuthor { BookId = 5081, AuthorId = 2014 },
                new BookAuthor { BookId = 5082, AuthorId = 2005 },
                new BookAuthor { BookId = 5083, AuthorId = 2012 },
                new BookAuthor { BookId = 5084, AuthorId = 2023 },
                new BookAuthor { BookId = 5085, AuthorId = 2015 },
                new BookAuthor { BookId = 5086, AuthorId = 2014 },
                new BookAuthor { BookId = 5087, AuthorId = 2008 },
                new BookAuthor { BookId = 5088, AuthorId = 2026 },
                new BookAuthor { BookId = 5089, AuthorId = 2021 },
                new BookAuthor { BookId = 5090, AuthorId = 2021 },
                new BookAuthor { BookId = 5091, AuthorId = 2023 },
                new BookAuthor { BookId = 5092, AuthorId = 2022 },
                new BookAuthor { BookId = 5093, AuthorId = 2026 },
                new BookAuthor { BookId = 5094, AuthorId = 2028 },
                new BookAuthor { BookId = 5095, AuthorId = 2027 },
                new BookAuthor { BookId = 5096, AuthorId = 2021 },
                new BookAuthor { BookId = 5097, AuthorId = 2024 },
                new BookAuthor { BookId = 5098, AuthorId = 2022 },
                new BookAuthor { BookId = 5099, AuthorId = 2025 },
                new BookAuthor { BookId = 5100, AuthorId = 2023 },
                new BookAuthor { BookId = 5101, AuthorId = 2022 },
                new BookAuthor { BookId = 5102, AuthorId = 2023 },
                new BookAuthor { BookId = 5103, AuthorId = 2022 },
                new BookAuthor { BookId = 5104, AuthorId = 2027 },
                new BookAuthor { BookId = 5105, AuthorId = 2026 }
            );

            // BorrowReceipts
            model.Entity<BorrowReceipt>().HasData(
                new BorrowReceipt { ReceiptId = 6001, UserId = 1001, BorrowDate = DateTime.Parse("2025-06-01"), ReturnDate = DateTime.Parse("2025-06-05"), Status = "Returned" },
                new BorrowReceipt { ReceiptId = 6002, UserId = 1002, BorrowDate = DateTime.Parse("2025-06-02"), ReturnDate = DateTime.Parse("2025-06-10"), Status = "Returned" },
                new BorrowReceipt { ReceiptId = 6003, UserId = 1003, BorrowDate = DateTime.Parse("2025-06-03"), ReturnDate = null, Status = "Borrowed" },
                new BorrowReceipt { ReceiptId = 6004, UserId = 1001, BorrowDate = DateTime.Parse("2025-06-04"), ReturnDate = null, Status = "Borrowed" },
                new BorrowReceipt { ReceiptId = 6005, UserId = 1002, BorrowDate = DateTime.Parse("2025-06-05"), ReturnDate = DateTime.Parse("2025-06-12"), Status = "Returned" },
                new BorrowReceipt { ReceiptId = 6006, UserId = 1003, BorrowDate = DateTime.Parse("2025-06-06"), ReturnDate = null, Status = "Borrowed" },
                new BorrowReceipt { ReceiptId = 6007, UserId = 1001, BorrowDate = DateTime.Parse("2025-06-07"), ReturnDate = null, Status = "Borrowed" },
                new BorrowReceipt { ReceiptId = 6008, UserId = 1002, BorrowDate = DateTime.Parse("2025-06-08"), ReturnDate = DateTime.Parse("2025-06-15"), Status = "Returned" },
                new BorrowReceipt { ReceiptId = 6009, UserId = 1003, BorrowDate = DateTime.Parse("2025-06-09"), ReturnDate = null, Status = "Borrowed" },
                new BorrowReceipt { ReceiptId = 6010, UserId = 1001, BorrowDate = DateTime.Parse("2025-06-10"), ReturnDate = null, Status = "Borrowed" },
                new BorrowReceipt { ReceiptId = 6011, UserId = 1004, BorrowDate = DateTime.Parse("2025-06-11"), ReturnDate = DateTime.Parse("2025-06-16"), Status = "Returned" },
                new BorrowReceipt { ReceiptId = 6012, UserId = 1005, BorrowDate = DateTime.Parse("2025-06-12"), ReturnDate = null, Status = "Borrowed" },
                new BorrowReceipt { ReceiptId = 6013, UserId = 1006, BorrowDate = DateTime.Parse("2025-06-13"), ReturnDate = DateTime.Parse("2025-06-20"), Status = "Returned" },
                new BorrowReceipt { ReceiptId = 6014, UserId = 1007, BorrowDate = DateTime.Parse("2025-06-14"), ReturnDate = null, Status = "Borrowed" },
                new BorrowReceipt { ReceiptId = 6015, UserId = 1008, BorrowDate = DateTime.Parse("2025-06-15"), ReturnDate = null, Status = "Borrowed" },
                new BorrowReceipt { ReceiptId = 6016, UserId = 1009, BorrowDate = DateTime.Parse("2025-06-16"), ReturnDate = DateTime.Parse("2025-06-22"), Status = "Returned" },
                new BorrowReceipt { ReceiptId = 6017, UserId = 1010, BorrowDate = DateTime.Parse("2025-06-17"), ReturnDate = null, Status = "Borrowed" },
                new BorrowReceipt { ReceiptId = 6018, UserId = 1011, BorrowDate = DateTime.Parse("2025-06-18"), ReturnDate = DateTime.Parse("2025-06-25"), Status = "Returned" },
                new BorrowReceipt { ReceiptId = 6019, UserId = 1012, BorrowDate = DateTime.Parse("2025-06-19"), ReturnDate = null, Status = "Borrowed" },
                new BorrowReceipt { ReceiptId = 6020, UserId = 1013, BorrowDate = DateTime.Parse("2025-06-20"), ReturnDate = null, Status = "Borrowed" },
                new BorrowReceipt { ReceiptId = 6021, UserId = 1014, BorrowDate = DateTime.Parse("2025-06-21"), ReturnDate = DateTime.Parse("2025-06-27"), Status = "Returned" },
                new BorrowReceipt { ReceiptId = 6022, UserId = 1015, BorrowDate = DateTime.Parse("2025-06-22"), ReturnDate = null, Status = "Borrowed" },
                new BorrowReceipt { ReceiptId = 6023, UserId = 1016, BorrowDate = DateTime.Parse("2025-06-23"), ReturnDate = DateTime.Parse("2025-06-30"), Status = "Returned" },
                new BorrowReceipt { ReceiptId = 6024, UserId = 1017, BorrowDate = DateTime.Parse("2025-06-24"), ReturnDate = null, Status = "Borrowed" },
                new BorrowReceipt { ReceiptId = 6025, UserId = 1018, BorrowDate = DateTime.Parse("2025-06-25"), ReturnDate = null, Status = "Borrowed" }
            );

            // BorrowDetails
            model.Entity<BorrowDetail>().HasData(
                new BorrowDetail { ReceiptId = 6001, BookId = 5001, ActualReturnDate = DateTime.Parse("2025-06-05"), FineAmount = 0m },
                new BorrowDetail { ReceiptId = 6001, BookId = 5002, ActualReturnDate = DateTime.Parse("2025-06-05"), FineAmount = 0m },
                new BorrowDetail { ReceiptId = 6002, BookId = 5003, ActualReturnDate = DateTime.Parse("2025-06-10"), FineAmount = 0m },
                new BorrowDetail { ReceiptId = 6002, BookId = 5004, ActualReturnDate = DateTime.Parse("2025-06-10"), FineAmount = 0m },
                new BorrowDetail { ReceiptId = 6003, BookId = 5005, ActualReturnDate = null, FineAmount = null },
                new BorrowDetail { ReceiptId = 6003, BookId = 5006, ActualReturnDate = null, FineAmount = null },
                new BorrowDetail { ReceiptId = 6004, BookId = 5007, ActualReturnDate = null, FineAmount = null },
                new BorrowDetail { ReceiptId = 6005, BookId = 5008, ActualReturnDate = DateTime.Parse("2025-06-12"), FineAmount = 15000m },
                new BorrowDetail { ReceiptId = 6005, BookId = 5009, ActualReturnDate = DateTime.Parse("2025-06-12"), FineAmount = 20000m },
                new BorrowDetail { ReceiptId = 6005, BookId = 5010, ActualReturnDate = DateTime.Parse("2025-06-12"), FineAmount = 2.00m },
                new BorrowDetail { ReceiptId = 6006, BookId = 5011, ActualReturnDate = null, FineAmount = null },
                new BorrowDetail { ReceiptId = 6006, BookId = 5012, ActualReturnDate = null, FineAmount = null },
                new BorrowDetail { ReceiptId = 6007, BookId = 5013, ActualReturnDate = null, FineAmount = null },
                new BorrowDetail { ReceiptId = 6007, BookId = 5014, ActualReturnDate = null, FineAmount = null },
                new BorrowDetail { ReceiptId = 6008, BookId = 5015, ActualReturnDate = DateTime.Parse("2025-06-15"), FineAmount = 0m },
                new BorrowDetail { ReceiptId = 6008, BookId = 5016, ActualReturnDate = DateTime.Parse("2025-06-15"), FineAmount = 0m },
                new BorrowDetail { ReceiptId = 6009, BookId = 5017, ActualReturnDate = null, FineAmount = null },
                new BorrowDetail { ReceiptId = 6009, BookId = 5018, ActualReturnDate = null, FineAmount = null },
                new BorrowDetail { ReceiptId = 6010, BookId = 5019, ActualReturnDate = null, FineAmount = null },
                new BorrowDetail { ReceiptId = 6010, BookId = 5020, ActualReturnDate = null, FineAmount = null }
            );
        }
    }
}
