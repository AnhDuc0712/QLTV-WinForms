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
                new Category { CategoryId = 1, Name = "Văn học Việt Nam" },
                new Category { CategoryId = 2, Name = "Văn học nước ngoài" },
                new Category { CategoryId = 3, Name = "Nghiên cứu khoa học" },
                new Category { CategoryId = 4, Name = "Lịch sử – Địa lý" },
                new Category { CategoryId = 5, Name = "Công nghệ thông tin" },
                new Category { CategoryId = 6, Name = "Tâm lý – Kỹ năng sống" },
                new Category { CategoryId = 7, Name = "Thiếu nhi" },
                new Category { CategoryId = 8, Name = "Kinh tế – Quản trị" },
                new Category { CategoryId = 9, Name = "Y học – Sức khỏe" },
                new Category { CategoryId = 10, Name = "Nghệ thuật – Kiến trúc" },
                new Category { CategoryId = 11, Name = "Truyện tranh – Manga" },
                new Category { CategoryId = 12, Name = "Tự lực – Phát triển bản thân" },
                new Category { CategoryId = 13, Name = "Thơ ca" },
                new Category { CategoryId = 14, Name = "Du lịch – Khám phá" },
                new Category { CategoryId = 15, Name = "Ẩm thực – Nấu ăn" },
                new Category { CategoryId = 16, Name = "Văn học trẻ" },
                new Category { CategoryId = 17, Name = "Tiểu thuyết trinh thám" },
                new Category { CategoryId = 18, Name = "Kinh dị – Giật gân" },
                new Category { CategoryId = 19, Name = "Thơ cách mạng" },
                new Category { CategoryId = 20, Name = "Tôn giáo – Triết học" },
                new Category { CategoryId = 21, Name = "Khoa học viễn tưởng" },
                new Category { CategoryId = 22, Name = "Lãng mạn – Tình cảm" },
                new Category { CategoryId = 23, Name = "Phát triển bản thân" },
                new Category { CategoryId = 24, Name = "Kinh doanh – Khởi nghiệp" },
                new Category { CategoryId = 25, Name = "Sách kỹ năng mềm" },
                new Category { CategoryId = 26, Name = "Văn hóa – Xã hội" },
                new Category { CategoryId = 27, Name = "Sách thiếu nhi – Thiếu niên" },
                new Category { CategoryId = 28, Name = "Sách luật pháp" },
                new Category { CategoryId = 29, Name = "Sách đại học" },
                new Category { CategoryId = 30, Name = "Sách chuyên ngành y" }
            );

            // Publishers
            model.Entity<Publisher>().HasData(
                new Publisher { PublisherId = 1, Name = "NXB Giáo dục Việt Nam" },
                new Publisher { PublisherId = 2, Name = "NXB Văn hóa – Thông tin" },
                new Publisher { PublisherId = 3, Name = "NXB Khoa học và Kỹ thuật" },
                new Publisher { PublisherId = 4, Name = "NXB Trẻ" },
                new Publisher { PublisherId = 5, Name = "NXB Kim Đồng" },
                new Publisher { PublisherId = 6, Name = "NXB Thống Kê" },
                new Publisher { PublisherId = 7, Name = "NXB Đại học Quốc gia" },
                new Publisher { PublisherId = 8, Name = "NXB Công nghệ Thông tin" },
                new Publisher { PublisherId = 9, Name = "NXB Hội Nhà văn" },
                new Publisher { PublisherId = 10, Name = "NXB Văn học" },
                new Publisher { PublisherId = 11, Name = "NXB Phụ nữ" },
                new Publisher { PublisherId = 12, Name = "NXB Tri thức" },
                new Publisher { PublisherId = 13, Name = "NXB Phương Đông" },
                new Publisher { PublisherId = 14, Name = "NXB Văn học Đông Á" },
                new Publisher { PublisherId = 15, Name = "NXB Đại học Quốc gia TP.HCM" },
                new Publisher { PublisherId = 16, Name = "NXB An ninh quốc gia" }

            );

            // Authors
            model.Entity<Author>().HasData(
                new Author { AuthorId = 1, Name = "Nguyễn Nhật Ánh" },
                new Author { AuthorId = 2, Name = "Hermione Granger" },
                new Author { AuthorId = 3, Name = "Paulo Coelho" },
                new Author { AuthorId = 4, Name = "Stephen Hawking" },
                new Author { AuthorId = 5, Name = "Yuval Noah Harari" },
                new Author { AuthorId = 6, Name = "J.K. Rowling" },
                new Author { AuthorId = 7, Name = "Daniel Kahneman" },
                new Author { AuthorId = 8, Name = "Tony Robbins" },
                new Author { AuthorId = 9, Name = "Malcolm Gladwell" },
                new Author { AuthorId = 10, Name = "George Orwell" },
                new Author { AuthorId = 11, Name = "Harper Lee" },
                new Author { AuthorId = 12, Name = "Fyodor Dostoevsky" },
                new Author { AuthorId = 13, Name = "Gabriel Garcia Marquez" },
                new Author { AuthorId = 14, Name = "Isaac Asimov" },
                new Author { AuthorId = 15, Name = "Sun Tzu" },
                new Author { AuthorId = 16, Name = "Ernest Hemingway" },
                new Author { AuthorId = 17, Name = "Agatha Christie" },
                new Author { AuthorId = 18, Name = "Edgar Allan Poe" },
                new Author { AuthorId = 19, Name = "Ralph Waldo Emerson" },
                new Author { AuthorId = 20, Name = "Đỗ Phấn" },
                new Author { AuthorId = 21, Name = "Arthur C. Clarke" },
                new Author { AuthorId = 22, Name = "Nicholas Sparks" },
                new Author { AuthorId = 23, Name = "Dale Carnegie" },
                new Author { AuthorId = 24, Name = "Robert Kiyosaki" },
                new Author { AuthorId = 25, Name = "Stephen R. Covey" },
                new Author { AuthorId = 26, Name = "Nguyễn Trãi" },
                new Author { AuthorId = 27, Name = "William Shakespeare" },
                new Author { AuthorId = 28, Name = "Sigmund Freud" },
                new Author { AuthorId = 29, Name = "Noam Chomsky" },
                new Author { AuthorId = 30, Name = "Trần Đại Nghĩa" }
            );

            // Users (3 bản ghi với địa chỉ chi tiết)
            model.Entity<User>().HasData(
                new User
                {
                    UserId = 1,
                    FullName = "Nguyễn Văn Vũ",
                    Email = "vanvu@gmail.com",
                    Username = "nguyenvanvu",
                    Address = "Số 12, ngõ 34 Phố Hoàng Hoa Thám, Quận Ba Đình, Hà Nội",
                    Phone = "0912345678",
                    UserType = "Customer"
                },
                new User
                {
                    UserId = 2,
                    FullName = "Trần Thị Ba",
                    Email = "thiba@gmail.com",
                    Username = "tranthiba",
                    Address = "Số 45, Đường 3/2, Phường Hưng Lợi, Quận Ninh Kiều, TP. Cần Thơ",
                    Phone = "0987654321",
                    UserType = "Customer"

                },
                new User
                {
                    UserId = 3,
                    FullName = "Lê Văn Chi",
                    Email = "vanchi@gmail.com",
                    Username = "levanchi",
                    Address = "Số 78, Phố Nguyễn Văn Cừ, Phường Gia Thuỷ, TP. Bắc Ninh",
                    Phone = "0901234567",
                    UserType = "Customer"

                },
                new User
                {
                    UserId = 4,
                    FullName = "Phạm Thị Dung",
                    Email = "dungpham@gmail.com",
                    Username = "phamthidung",
                    Address = "Số 22, Đường Láng Hạ, Phường Láng Hạ, Quận Đống Đa, Hà Nội",
                    Phone = "0918765432",
                    UserType = "Customer"
                },
                new User
                {
                    UserId = 5,
                    FullName = "Võ Văn An",
                    Email = "anvo@gmail.com",
                    Username = "vovan_an",
                    Address = "Số 99, Đường Trần Phú, Phường 5, TP. Vũng Tàu",
                    Phone = "0932123456",
                    UserType = "Customer"
                },
                new User
                {
                    UserId = 6,
                    FullName = "Lý Thị Hiền",
                    Email = "hienly@gmail.com",
                    Username = "lythihien",
                    Address = "Số 5, Phố Hoàng Diệu, Phường Hải Châu 1, Quận Hải Châu, Đà Nẵng",
                    Phone = "0983344556",
                    UserType = "Customer"
                },
                new User
                {
                    UserId = 7,
                    FullName = "Ngô Minh Tuấn",
                    Email = "tuanngo@gmail.com",
                    Username = "ngominhtuan",
                    Address = "Số 150, Đường Cách Mạng Tháng 8, Phường Bến Thành, Quận 1, TP. Hồ Chí Minh",
                    Phone = "0909988776",
                    UserType = "Customer"
                },
                new User
                {
                    UserId = 8,
                    FullName = "Đặng Thị Lan",
                    Email = "lan.dang@gmail.com",
                    Username = "dangthilan",
                    Address = "Số 10, Đường Hai Bà Trưng, Phường Phạm Ngũ Lão, Quận 1, TP. Hồ Chí Minh",
                    Phone = "0911223344",
                    UserType = "Customer"
                },
                new User
                {
                    UserId = 9,
                    FullName = "Phan Văn Hòa",
                    Email = "vanhoa.phan@gmail.com",
                    Username = "phanvanhoa",
                    Address = "Số 8, Đường Nguyễn Thị Minh Khai, Phường 1, TP. Vĩnh Long",
                    Phone = "0977554433",
                    UserType = "Customer"
                },
                new User
                {
                    UserId = 10,
                    FullName = "Trương Thị Mai",
                    Email = "maitruong@gmail.com",
                    Username = "truongthimai",
                    Address = "Số 120, Đường Phan Đình Phùng, Phường Thành Nhất, TP. Buôn Ma Thuột",
                    Phone = "0911335577",
                    UserType = "Customer"
                },
                new User
                {
                    UserId = 11,
                    FullName = "Bùi Quốc Việt",
                    Email = "quocviet.bui@gmail.com",
                    Username = "buiquo cviet",
                    Address = "Số 33, Phố Lý Thường Kiệt, Phường Phủ Hà, TP. Lạng Sơn",
                    Phone = "0987665544",
                    UserType = "Customer"
                },
                new User
                {
                    UserId = 12,
                    FullName = "Lê Thị Phương",
                    Email = "phuongle@gmail.com",
                    Username = "lethiphuong",
                    Address = "Số 27, Đường Hùng Vương, Phường Mỹ Xuyên, TP. Sóc Trăng",
                    Phone = "0968877665",
                    UserType = "Customer"
                },
                new User
                {
                    UserId = 13,
                    FullName = "Đỗ Minh Tú",
                    Email = "minhtu.do@gmail.com",
                    Username = "dominhtu",
                    Address = "Số 55, Đường Trần Hưng Đạo, Phường Lê Lợi, TP. Nam Định",
                    Phone = "0933445566",
                    UserType = "Customer"
                },
                new User
                {
                    UserId = 14,
                    FullName = "Phạm Minh Quân",
                    Email = "minhquan.pham@gmail.com",
                    Username = "phamminhquan",
                    Address = "Số 18, Đường Lê Lợi, Phường An Lạc, TP. Biên Hòa",
                    Phone = "0914556677",
                    UserType = "Customer"
                },
                new User
                {
                    UserId = 15,
                    FullName = "Vũ Thị Ngọc",
                    Email = "ngocvu@gmail.com",
                    Username = "vuthingoc",
                    Address = "Số 66, Phố Trần Nhân Tông, Phường Nam Đàn, TP. Thanh Hóa",
                    Phone = "0988112233",
                    UserType = "Customer"
                },
                new User
                {
                    UserId = 16,
                    FullName = "Nguyễn Quốc Cường",
                    Email = "quoccuong.nguyen@gmail.com",
                    Username = "nguyencuong",
                    Address = "Số 102, Đường Trần Phú, Phường Xuân Phú, TP. Huế",
                    Phone = "0902334455",
                    UserType = "Customer"
                },
                new User
                {
                    UserId = 17,
                    FullName = "Lê Thúy Hằng",
                    Email = "thuyhang.le@gmail.com",
                    Username = "lethuyhang",
                    Address = "Số 5, Đường Nguyễn Văn Trỗi, Phường Đông Vệ, TP. Thanh Hóa",
                    Phone = "0977665544",
                    UserType = "Customer"
                },
                new User
                {
                    UserId = 18,
                    FullName = "Trần Anh Tuấn",
                    Email = "anhtuan.tran@gmail.com",
                    Username = "trananhtuan",
                    Address = "Số 250, Đường Nguyễn Thái Học, Phường Phan Chu Trinh, TP. Quy Nhơn",
                    Phone = "0933667788",
                    UserType = "Customer"
                },
                new User
                {
                    UserId = 19,
                    FullName = "Phan Thị Hạnh",
                    Email = "hanhphan@gmail.com",
                    Username = "phanthihanh",
                    Address = "Số 14, Đường Nguyễn Huệ, Phường Phước Ninh, TP. Đà Nẵng",
                    Phone = "0901778899",
                    UserType = "Customer"
                },
                new User
                {
                    UserId = 20,
                    FullName = "Trương Văn Sơn",
                    Email = "sontruong@gmail.com",
                    Username = "truongvanson",
                    Address = "Số 77, Phố Phan Đình Phùng, Phường Đội Cấn, Quận Ba Đình, Hà Nội",
                    Phone = "0977001122",
                    UserType = "Customer"
                },
                new User
                {
                    UserId = 21,
                    FullName = "Lê Minh Tâm",
                    Email = "leminhtam@gmail.com",
                    Username = "leminhtam",
                    Address = "Số 33, Đường Trần Khánh Dư, Phường Trần Hưng Đạo, Quận Hoàn Kiếm, Hà Nội",
                    Phone = "0912993344",
                    UserType = "Customer"
                },
                new User
                {
                    UserId = 22,
                    FullName = "Đặng Văn Phúc",
                    Email = "phucdang@gmail.com",
                    Username = "dangvanphuc",
                    Address = "Số 55, Đường Đinh Tiên Hoàng, Phường Bến Nghé, Quận 1, TP. Hồ Chí Minh",
                    Phone = "0933100234",
                    UserType = "Customer"
                },
                new User
                {
                    UserId = 23,
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
                new Book { BookId = 1, Title = "Dế Mèn Phiêu Lưu Ký", CategoryId = 7, PublisherId = 5, StockQuantity = 12, ImageUrl = null },
                new Book { BookId = 2, Title = "Hoàng Tử Bé", CategoryId = 2, PublisherId = 2, StockQuantity = 8, ImageUrl = null },
                new Book { BookId = 3, Title = "Nhà Giả Kim", CategoryId = 1, PublisherId = 4, StockQuantity = 5, ImageUrl = null },
                new Book { BookId = 4, Title = "Lược Sử Thời Gian", CategoryId = 3, PublisherId = 3, StockQuantity = 3, ImageUrl = null },
                new Book { BookId = 5, Title = "Sapiens: Lược Sử Loài Người", CategoryId = 4, PublisherId = 3, StockQuantity = 4, ImageUrl = null },
                new Book { BookId = 6, Title = "Harry Potter và Hòn Đá Phù Thủy", CategoryId = 7, PublisherId = 5, StockQuantity = 6, ImageUrl = null },
                new Book { BookId = 7, Title = "Tư Duy, Nhanh và Chậm", CategoryId = 6, PublisherId = 8, StockQuantity = 10, ImageUrl = null },
                new Book { BookId = 8, Title = "Cấu Trúc Dữ Liệu và Giải Thuật", CategoryId = 5, PublisherId = 8, StockQuantity = 2, ImageUrl = null },
                new Book { BookId = 9, Title = "Trên Đường", CategoryId = 1, PublisherId = 2, StockQuantity = 5, ImageUrl = null },
                new Book { BookId = 10, Title = "21 Bài Học Cho Thế Kỷ 21", CategoryId = 6, PublisherId = 1, StockQuantity = 4, ImageUrl = null },
                new Book { BookId = 11, Title = "1984", CategoryId = 2, PublisherId = 2, StockQuantity = 7, ImageUrl = null },
                new Book { BookId = 12, Title = "To Kill a Mockingbird", CategoryId = 2, PublisherId = 2, StockQuantity = 5, ImageUrl = null },
                new Book { BookId = 13, Title = "Tội Ác và Hình Phạt", CategoryId = 1, PublisherId = 3, StockQuantity = 6, ImageUrl = null },
                new Book { BookId = 14, Title = "Nửa Xuân", CategoryId = 1, PublisherId = 1, StockQuantity = 4, ImageUrl = null },
                new Book { BookId = 15, Title = "The Power of Habit", CategoryId = 6, PublisherId = 8, StockQuantity = 9, ImageUrl = null },
                new Book { BookId = 16, Title = "Đi Tìm Lẽ Sống", CategoryId = 6, PublisherId = 1, StockQuantity = 11, ImageUrl = null },
                new Book { BookId = 17, Title = "Chiến Tranh và Hòa Bình", CategoryId = 4, PublisherId = 3, StockQuantity = 3, ImageUrl = null },
                new Book { BookId = 18, Title = "Bí Quyết Làm Giàu", CategoryId = 8, PublisherId = 8, StockQuantity = 8, ImageUrl = null },
                new Book { BookId = 19, Title = "Artificial Intelligence Basics", CategoryId = 5, PublisherId = 8, StockQuantity = 2, ImageUrl = null },
                new Book { BookId = 20, Title = "The Art of War", CategoryId = 4, PublisherId = 2, StockQuantity = 7, ImageUrl = null },
                new Book { BookId = 21, Title = "One Piece – Tập 1", CategoryId = 11, PublisherId = 4, StockQuantity = 20, ImageUrl = null },
                new Book { BookId = 22, Title = "Atomic Habits", CategoryId = 12, PublisherId = 8, StockQuantity = 15, ImageUrl = null },
                new Book { BookId = 23, Title = "Thơ Trẻ – Cố Quận", CategoryId = 13, PublisherId = 2, StockQuantity = 8, ImageUrl = null },
                new Book { BookId = 24, Title = "Lonely Planet Việt Nam", CategoryId = 14, PublisherId = 3, StockQuantity = 10, ImageUrl = null },
                new Book { BookId = 25, Title = "MasterChef – Công Thức Nấu Ăn", CategoryId = 15, PublisherId = 5, StockQuantity = 12, ImageUrl = null },
                new Book { BookId = 26, Title = "Doraemon – Tập 1", CategoryId = 11, PublisherId = 5, StockQuantity = 25, ImageUrl = null },
                new Book { BookId = 27, Title = "How to Win Friends & Influence People", CategoryId = 12, PublisherId = 1, StockQuantity = 7, ImageUrl = null },
                new Book { BookId = 28, Title = "Thơ Viết Cho Tuổi 20", CategoryId = 13, PublisherId = 7, StockQuantity = 5, ImageUrl = null },
                new Book { BookId = 29, Title = "1001 Địa Điểm Việt Nam", CategoryId = 14, PublisherId = 6, StockQuantity = 9, ImageUrl = null },
                new Book { BookId = 30, Title = "Cẩm Nang Nấu Ăn Gia Đình", CategoryId = 15, PublisherId = 6, StockQuantity = 14, ImageUrl = null },
                new Book { BookId = 31, Title = "Ông già và biển cả", CategoryId = 17, PublisherId = 9, StockQuantity = 7, ImageUrl = null },
                new Book { BookId = 32, Title = "Án mạng trên chuyến tàu tốc hành phương Đông", CategoryId = 17, PublisherId = 10, StockQuantity = 5, ImageUrl = null },
                new Book { BookId = 33, Title = "Con quạ và các truyện khác", CategoryId = 18, PublisherId = 11, StockQuantity = 4, ImageUrl = null },
                new Book { BookId = 34, Title = "Tản văn Du ký", CategoryId = 16, PublisherId = 9, StockQuantity = 6, ImageUrl = null },
                new Book { BookId = 35, Title = "Tinh thần triết học", CategoryId = 20, PublisherId = 11, StockQuantity = 3, ImageUrl = null },
                new Book { BookId = 36, Title = "2001: A Space Odyssey", CategoryId = 21, PublisherId = 12, StockQuantity = 5, ImageUrl = null },
                new Book { BookId = 37, Title = "Notebook – Nhật ký tình yêu", CategoryId = 22, PublisherId = 13, StockQuantity = 8, ImageUrl = null },
                new Book { BookId = 38, Title = "How to Win Friends", CategoryId = 23, PublisherId = 12, StockQuantity = 10, ImageUrl = null },
                new Book { BookId = 39, Title = "Rich Dad Poor Dad", CategoryId = 24, PublisherId = 14, StockQuantity = 7, ImageUrl = null },
                new Book { BookId = 40, Title = "7 Thói Quen Hiệu Quả", CategoryId = 25, PublisherId = 13, StockQuantity = 6, ImageUrl = null },
                new Book { BookId = 41, Title = "Lược sử phát minh", CategoryId = 26, PublisherId = 15, StockQuantity = 5, ImageUrl = null },
                new Book { BookId = 42, Title = "Harry Potter và Phòng Chứa Bí Ẩn", CategoryId = 27, PublisherId = 16, StockQuantity = 7, ImageUrl = null },
                new Book { BookId = 43, Title = "Luật Dân sự Việt Nam", CategoryId = 28, PublisherId = 15, StockQuantity = 3, ImageUrl = null },
                new Book { BookId = 44, Title = "Toán Cao Cấp – Đại cương", CategoryId = 29, PublisherId = 15, StockQuantity = 4, ImageUrl = null },
                new Book { BookId = 45, Title = "Y học cổ truyền Việt Nam", CategoryId = 30, PublisherId = 16, StockQuantity = 6, ImageUrl = null },
                new Book { BookId = 46, Title = "Lập Trình C# Toàn Tập", CategoryId = 5, PublisherId = 8, StockQuantity = 15, ImageUrl = null },
                new Book { BookId = 47, Title = "Thiết Kế Kiến Trúc Phần Mềm", CategoryId = 5, PublisherId = 8, StockQuantity = 8, ImageUrl = null },
                new Book { BookId = 48, Title = "Giải Thuật và Cấu Trúc Dữ Liệu", CategoryId = 5, PublisherId = 8, StockQuantity = 12, ImageUrl = null },
                new Book { BookId = 49, Title = "An Ninh Mạng Cơ Bản", CategoryId = 5, PublisherId = 14, StockQuantity = 10, ImageUrl = null },
                new Book { BookId = 50, Title = "Hướng Dẫn ReactJS", CategoryId = 5, PublisherId = 12, StockQuantity = 7, ImageUrl = null },
                new Book { BookId = 51, Title = "Kỹ Năng Giao Tiếp Trong Công Việc", CategoryId = 25, PublisherId = 13, StockQuantity = 9, ImageUrl = null },
                new Book { BookId = 52, Title = "Nghệ Thuật Thuyết Phục", CategoryId = 25, PublisherId = 13, StockQuantity = 6, ImageUrl = null },
                new Book { BookId = 53, Title = "Quản Trị Mạng CCNA", CategoryId = 5, PublisherId = 8, StockQuantity = 5, ImageUrl = null },
                new Book { BookId = 54, Title = "Phân Tích Dữ Liệu với Python", CategoryId = 5, PublisherId = 9, StockQuantity = 11, ImageUrl = null },
                new Book { BookId = 55, Title = "Machine Learning Cơ Bản", CategoryId = 5, PublisherId = 14, StockQuantity = 4, ImageUrl = null },
                new Book { BookId = 56, Title = "Deep Learning Cơ Bản", CategoryId = 5, PublisherId = 14, StockQuantity = 5, ImageUrl = null },
                new Book { BookId = 57, Title = "Kỹ Năng Lãnh Đạo", CategoryId = 25, PublisherId = 13, StockQuantity = 8, ImageUrl = null },
                new Book { BookId = 58, Title = "Phát Triển Ứng Dụng Android", CategoryId = 5, PublisherId = 8, StockQuantity = 7, ImageUrl = null },
                new Book { BookId = 59, Title = "C# Trong Thực Tiễn", CategoryId = 5, PublisherId = 9, StockQuantity = 10, ImageUrl = null },
                new Book { BookId = 60, Title = "Docker và Kubernetes", CategoryId = 5, PublisherId = 12, StockQuantity = 6, ImageUrl = null },
                new Book { BookId = 61, Title = "Phân Tích Hành Vi Người Dùng", CategoryId = 6, PublisherId = 11, StockQuantity = 9, ImageUrl = null },
                new Book { BookId = 62, Title = "Quản Trị Dự Án Agile", CategoryId = 24, PublisherId = 10, StockQuantity = 4, ImageUrl = null },
                new Book { BookId = 63, Title = "Kiến Trúc Microservices", CategoryId = 5, PublisherId = 8, StockQuantity = 5, ImageUrl = null },
                new Book { BookId = 64, Title = "Trò Chuyện Với Stanley", CategoryId = 23, PublisherId = 9, StockQuantity = 7, ImageUrl = null },
                new Book { BookId = 65, Title = "Hành Trình Về Phương Đông", CategoryId = 14, PublisherId = 15, StockQuantity = 3, ImageUrl = null },
                new Book { BookId = 66, Title = "Thiết Kế UX/UI Cơ Bản", CategoryId = 5, PublisherId = 12, StockQuantity = 8, ImageUrl = null },
                new Book { BookId = 67, Title = "Phương Pháp Đặt Câu Hỏi", CategoryId = 25, PublisherId = 13, StockQuantity = 6, ImageUrl = null },
                new Book { BookId = 68, Title = "Lập Trình Python", CategoryId = 5, PublisherId = 8, StockQuantity = 12, ImageUrl = null },
                new Book { BookId = 69, Title = "An Toàn Thực Phẩm", CategoryId = 9, PublisherId = 6, StockQuantity = 5, ImageUrl = null },
                new Book { BookId = 70, Title = "Kỹ Thuật Chụp Ảnh", CategoryId = 14, PublisherId = 2, StockQuantity = 7, ImageUrl = null },
                new Book { BookId = 71, Title = "Quản Lý Nhân Sự Hiện Đại", CategoryId = 24, PublisherId = 10, StockQuantity = 4, ImageUrl = null },
                new Book { BookId = 72, Title = "Sức Mạnh Thói Quen", CategoryId = 12, PublisherId = 14, StockQuantity = 9, ImageUrl = null },
                new Book { BookId = 73, Title = "Ngôn Ngữ Cơ Thể", CategoryId = 20, PublisherId = 3, StockQuantity = 3, ImageUrl = null },
                new Book { BookId = 74, Title = "Khoa Học Hành Vi", CategoryId = 3, PublisherId = 1, StockQuantity = 6, ImageUrl = null },
                new Book { BookId = 75, Title = "Thuyết Trình Tuyệt Đỉnh", CategoryId = 25, PublisherId = 13, StockQuantity = 8, ImageUrl = null },
                new Book { BookId = 76, Title = "Công Nghệ Blockchain", CategoryId = 5, PublisherId = 14, StockQuantity = 5, ImageUrl = null },
                new Book { BookId = 77, Title = "Luật Hình Sự Cơ Bản", CategoryId = 28, PublisherId = 15, StockQuantity = 4, ImageUrl = null },
                new Book { BookId = 78, Title = "Viết Kịch Bản Phim", CategoryId = 16, PublisherId = 9, StockQuantity = 7, ImageUrl = null },
                new Book { BookId = 79, Title = "Âm Nhạc Thế Kỷ 21", CategoryId = 10, PublisherId = 2, StockQuantity = 5, ImageUrl = null },
                new Book { BookId = 80, Title = "Khởi Nghiệp Tinh Gọn", CategoryId = 24, PublisherId = 10, StockQuantity = 6, ImageUrl = null },
                new Book { BookId = 81, Title = "Xử Lý Ngôn Ngữ Tự Nhiên", CategoryId = 5, PublisherId = 8, StockQuantity = 9, ImageUrl = null },
                new Book { BookId = 82, Title = "Psychology of Money", CategoryId = 6, PublisherId = 1, StockQuantity = 10, ImageUrl = null },
                new Book { BookId = 83, Title = "Nghiên Cứu Thị Trường", CategoryId = 24, PublisherId = 12, StockQuantity = 5, ImageUrl = null },
                new Book { BookId = 84, Title = "Châm Ngôn Thành Công", CategoryId = 25, PublisherId = 13, StockQuantity = 7, ImageUrl = null },
                new Book { BookId = 85, Title = "Sách Về Thiền Định", CategoryId = 6, PublisherId = 6, StockQuantity = 4, ImageUrl = null },
                new Book { BookId = 86, Title = "Lý Thuyết Âm Nhạc", CategoryId = 10, PublisherId = 2, StockQuantity = 6, ImageUrl = null },
                new Book { BookId = 87, Title = "Dinh Dưỡng Học", CategoryId = 9, PublisherId = 6, StockQuantity = 5, ImageUrl = null },
                new Book { BookId = 88, Title = "Thủy Văn Cơ Sở", CategoryId = 29, PublisherId = 15, StockQuantity = 3, ImageUrl = null },
                new Book { BookId = 89, Title = "Lập Trình Web Toàn Tập", CategoryId = 5, PublisherId = 8, StockQuantity = 12, ImageUrl = null },
                new Book { BookId = 90, Title = "Công Nghệ IoT", CategoryId = 5, PublisherId = 14, StockQuantity = 8, ImageUrl = null },
                new Book { BookId = 91, Title = "Quản Trị Rủi Ro", CategoryId = 24, PublisherId = 10, StockQuantity = 5, ImageUrl = null },
                new Book { BookId = 92, Title = "Thơ Tình Việt Nam", CategoryId = 13, PublisherId = 2, StockQuantity = 7, ImageUrl = null },
                new Book { BookId = 93, Title = "Du Lịch Tây Bắc", CategoryId = 14, PublisherId = 15, StockQuantity = 6, ImageUrl = null },
                new Book { BookId = 94, Title = "Quản Lý Dữ Liệu Lớn", CategoryId = 5, PublisherId = 9, StockQuantity = 4, ImageUrl = null },
                new Book { BookId = 95, Title = "Toán Rời Rạc", CategoryId = 29, PublisherId = 15, StockQuantity = 5, ImageUrl = null },
                new Book { BookId = 96, Title = "Blockchain trong Ngân Hàng", CategoryId = 5, PublisherId = 14, StockQuantity = 3, ImageUrl = null },
                new Book { BookId = 97, Title = "Xử Lý Ảnh Số", CategoryId = 5, PublisherId = 8, StockQuantity = 7, ImageUrl = null },
                new Book { BookId = 98, Title = "Phân Tích Tài Chính", CategoryId = 24, PublisherId = 10, StockQuantity = 5, ImageUrl = null },
                new Book { BookId = 99, Title = "Hạt Giống Tâm Hồn", CategoryId = 25, PublisherId = 13, StockQuantity = 8, ImageUrl = null },
                new Book { BookId = 100, Title = "Sách Về Chiến Lược", CategoryId = 24, PublisherId = 10, StockQuantity = 6, ImageUrl = null },
                new Book { BookId = 101, Title = "Thiết Kế Game", CategoryId = 5, PublisherId = 8, StockQuantity = 9, ImageUrl = null },
                new Book { BookId = 102, Title = "Quản Trị Công Nghệ", CategoryId = 24, PublisherId = 10, StockQuantity = 4, ImageUrl = null },
                new Book { BookId = 103, Title = "Phát Triển iOS", CategoryId = 5, PublisherId = 9, StockQuantity = 7, ImageUrl = null },
                new Book { BookId = 104, Title = "Thơ Trẻ", CategoryId = 13, PublisherId = 2, StockQuantity = 5, ImageUrl = null },
                new Book { BookId = 105, Title = "Ẩm Thực Việt", CategoryId = 15, PublisherId = 5, StockQuantity = 10, ImageUrl = null }



            );

            // BookAuthor
            model.Entity<BookAuthor>().HasData(
                new BookAuthor { BookId = 1, AuthorId = 1 },
                new BookAuthor { BookId = 2, AuthorId = 3 },
                new BookAuthor { BookId = 3, AuthorId = 3 },
                new BookAuthor { BookId = 4, AuthorId = 4 },
                new BookAuthor { BookId = 5, AuthorId = 5 },
                new BookAuthor { BookId = 6, AuthorId = 6 },
                new BookAuthor { BookId = 7, AuthorId = 7 },
                new BookAuthor { BookId = 8, AuthorId = 14 },
                new BookAuthor { BookId = 9, AuthorId = 1 },
                new BookAuthor { BookId = 10, AuthorId = 5 },
                new BookAuthor { BookId = 11, AuthorId = 10 },
                new BookAuthor { BookId = 12, AuthorId = 11 },
                new BookAuthor { BookId = 13, AuthorId = 12 },
                new BookAuthor { BookId = 14, AuthorId = 1 },
                new BookAuthor { BookId = 15, AuthorId = 8 },
                new BookAuthor { BookId = 16, AuthorId = 2 },
                new BookAuthor { BookId = 17, AuthorId = 9 },
                new BookAuthor { BookId = 18, AuthorId = 8 },
                new BookAuthor { BookId = 19, AuthorId = 14 },
                new BookAuthor { BookId = 20, AuthorId = 15 },
                new BookAuthor { BookId = 3, AuthorId = 11 },
                new BookAuthor { BookId = 7, AuthorId = 9 },
                new BookAuthor { BookId = 10, AuthorId = 2 },
                new BookAuthor { BookId = 16, AuthorId = 5 },
                new BookAuthor { BookId = 18, AuthorId = 2 },
                new BookAuthor { BookId = 31, AuthorId = 16 },
                new BookAuthor { BookId = 32, AuthorId = 17 },
                new BookAuthor { BookId = 33, AuthorId = 18 },
                new BookAuthor { BookId = 34, AuthorId = 19 },
                new BookAuthor { BookId = 35, AuthorId = 20 },
                new BookAuthor { BookId = 36, AuthorId = 21 },
                new BookAuthor { BookId = 37, AuthorId = 22 },
                new BookAuthor { BookId = 38, AuthorId = 23 },
                new BookAuthor { BookId = 39, AuthorId = 24 },
                new BookAuthor { BookId = 40, AuthorId = 25 },
                new BookAuthor { BookId = 41, AuthorId = 26 },
                new BookAuthor { BookId = 42, AuthorId = 26 },
                new BookAuthor { BookId = 43, AuthorId = 27 },
                new BookAuthor { BookId = 44, AuthorId = 28 },
                new BookAuthor { BookId = 45, AuthorId = 29 },
                new BookAuthor { BookId = 46, AuthorId = 28 },
                new BookAuthor { BookId = 47, AuthorId = 29 },
                new BookAuthor { BookId = 48, AuthorId = 21 },
                new BookAuthor { BookId = 49, AuthorId = 21 },
                new BookAuthor { BookId = 50, AuthorId = 22 },
                new BookAuthor { BookId = 51, AuthorId = 23 },
                new BookAuthor { BookId = 52, AuthorId = 23 },
                new BookAuthor { BookId = 53, AuthorId = 14 },
                new BookAuthor { BookId = 54, AuthorId = 17 },
                new BookAuthor { BookId = 55, AuthorId = 24 },
                new BookAuthor { BookId = 56, AuthorId = 24 },
                new BookAuthor { BookId = 57, AuthorId = 25 },
                new BookAuthor { BookId = 58, AuthorId = 14 },
                new BookAuthor { BookId = 59, AuthorId = 16 },
                new BookAuthor { BookId = 60, AuthorId = 21 },
                new BookAuthor { BookId = 61, AuthorId = 27 },
                new BookAuthor { BookId = 62, AuthorId = 23 },
                new BookAuthor { BookId = 63, AuthorId = 22 },
                new BookAuthor { BookId = 64, AuthorId = 29 },
                new BookAuthor { BookId = 65, AuthorId = 26 },
                new BookAuthor { BookId = 66, AuthorId = 24 },
                new BookAuthor { BookId = 67, AuthorId = 25 },
                new BookAuthor { BookId = 68, AuthorId = 21 },
                new BookAuthor { BookId = 69, AuthorId = 27 },
                new BookAuthor { BookId = 70, AuthorId = 29 },
                new BookAuthor { BookId = 71, AuthorId = 23 },
                new BookAuthor { BookId = 72, AuthorId = 25 },
                new BookAuthor { BookId = 73, AuthorId = 29 },
                new BookAuthor { BookId = 74, AuthorId = 21 },
                new BookAuthor { BookId = 75, AuthorId = 23 },
                new BookAuthor { BookId = 76, AuthorId = 21 },
                new BookAuthor { BookId = 77, AuthorId = 22 },
                new BookAuthor { BookId = 78, AuthorId = 16 },
                new BookAuthor { BookId = 79, AuthorId = 10 },
                new BookAuthor { BookId = 80, AuthorId = 17 },
                new BookAuthor { BookId = 81, AuthorId = 14 },
                new BookAuthor { BookId = 82, AuthorId = 5 },
                new BookAuthor { BookId = 83, AuthorId = 12 },
                new BookAuthor { BookId = 84, AuthorId = 23 },
                new BookAuthor { BookId = 85, AuthorId = 15 },
                new BookAuthor { BookId = 86, AuthorId = 14 },
                new BookAuthor { BookId = 87, AuthorId = 8 },
                new BookAuthor { BookId = 88, AuthorId = 26 },
                new BookAuthor { BookId = 89, AuthorId = 21 },
                new BookAuthor { BookId = 90, AuthorId = 21 },
                new BookAuthor { BookId = 91, AuthorId = 23 },
                new BookAuthor { BookId = 92, AuthorId = 22 },
                new BookAuthor { BookId = 93, AuthorId = 26 },
                new BookAuthor { BookId = 94, AuthorId = 28 },
                new BookAuthor { BookId = 95, AuthorId = 27 },
                new BookAuthor { BookId = 96, AuthorId = 21 },
                new BookAuthor { BookId = 97, AuthorId = 24 },
                new BookAuthor { BookId = 98, AuthorId = 22 },
                new BookAuthor { BookId = 99, AuthorId = 25 },
                new BookAuthor { BookId = 100, AuthorId = 23 },
                new BookAuthor { BookId = 101, AuthorId = 22 },
                new BookAuthor { BookId = 102, AuthorId = 23 },
                new BookAuthor { BookId = 103, AuthorId = 22 },
                new BookAuthor { BookId = 104, AuthorId = 27 },
                new BookAuthor { BookId = 105, AuthorId = 26 }
            );

            // BorrowReceipts
            model.Entity<BorrowReceipt>().HasData(
    new BorrowReceipt { ReceiptId = 1, UserId = 1, BorrowDate = DateTime.Parse("2025-06-01"), ReturnDate = DateTime.Parse("2025-06-05"), Status = "Returned" },
    new BorrowReceipt { ReceiptId = 2, UserId = 2, BorrowDate = DateTime.Parse("2025-06-02"), ReturnDate = DateTime.Parse("2025-06-10"), Status = "Returned" },
    new BorrowReceipt { ReceiptId = 3, UserId = 3, BorrowDate = DateTime.Parse("2025-06-03"), ReturnDate = DateTime.Parse("2025-06-05"), Status = "Overdue" },
    new BorrowReceipt { ReceiptId = 4, UserId = 1, BorrowDate = DateTime.Parse("2025-06-04"), ReturnDate = DateTime.Parse("2025-06-05"), Status = "NotFullyReturned" },
    new BorrowReceipt { ReceiptId = 5, UserId = 2, BorrowDate = DateTime.Parse("2025-06-05"), ReturnDate = DateTime.Parse("2025-06-12"), Status = "Returned" },
    new BorrowReceipt { ReceiptId = 6, UserId = 3, BorrowDate = DateTime.Parse("2025-06-06"), ReturnDate = DateTime.Parse("2025-06-10"), Status = "Borrowing" },
    new BorrowReceipt { ReceiptId = 7, UserId = 1, BorrowDate = DateTime.Parse("2025-06-07"), ReturnDate = DateTime.Parse("2025-06-12"), Status = "Borrowing" },
    new BorrowReceipt { ReceiptId = 8, UserId = 2, BorrowDate = DateTime.Parse("2025-06-08"), ReturnDate = DateTime.Parse("2025-06-15"), Status = "Returned" },
    new BorrowReceipt { ReceiptId = 9, UserId = 3, BorrowDate = DateTime.Parse("2025-06-09"), ReturnDate = DateTime.Parse("2025-06-12"), Status = "Borrowing" },
    new BorrowReceipt { ReceiptId = 10, UserId = 1, BorrowDate = DateTime.Parse("2025-06-10"), ReturnDate = DateTime.Parse("2025-06-15"), Status = "Borrowing" },
    new BorrowReceipt { ReceiptId = 11, UserId = 4, BorrowDate = DateTime.Parse("2025-06-11"), ReturnDate = DateTime.Parse("2025-06-16"), Status = "Returned" },
    new BorrowReceipt { ReceiptId = 12, UserId = 5, BorrowDate = DateTime.Parse("2025-06-12"), ReturnDate = DateTime.Parse("2025-06-17"), Status = "Borrowing" },
    new BorrowReceipt { ReceiptId = 13, UserId = 6, BorrowDate = DateTime.Parse("2025-06-13"), ReturnDate = DateTime.Parse("2025-06-20"), Status = "Returned" },
    new BorrowReceipt { ReceiptId = 14, UserId = 7, BorrowDate = DateTime.Parse("2025-06-14"), ReturnDate = DateTime.Parse("2025-06-19"), Status = "Borrowing" },
    new BorrowReceipt { ReceiptId = 15, UserId = 8, BorrowDate = DateTime.Parse("2025-06-15"), ReturnDate = DateTime.Parse("2025-06-20"), Status = "NotFullyReturned" },
    new BorrowReceipt { ReceiptId = 16, UserId = 9, BorrowDate = DateTime.Parse("2025-06-16"), ReturnDate = DateTime.Parse("2025-06-22"), Status = "Returned" },
    new BorrowReceipt { ReceiptId = 17, UserId = 10, BorrowDate = DateTime.Parse("2025-06-17"), ReturnDate = DateTime.Parse("2025-06-23"), Status = "Borrowing" },
    new BorrowReceipt { ReceiptId = 18, UserId = 11, BorrowDate = DateTime.Parse("2025-06-18"), ReturnDate = DateTime.Parse("2025-06-25"), Status = "Returned" },
    new BorrowReceipt { ReceiptId = 19, UserId = 12, BorrowDate = DateTime.Parse("2025-06-19"), ReturnDate = DateTime.Parse("2025-06-24"), Status = "Overdue" },
    new BorrowReceipt { ReceiptId = 20, UserId = 13, BorrowDate = DateTime.Parse("2025-06-20"), ReturnDate = DateTime.Parse("2025-06-26"), Status = "NotFullyReturned" },
    new BorrowReceipt { ReceiptId = 21, UserId = 14, BorrowDate = DateTime.Parse("2025-06-21"), ReturnDate = DateTime.Parse("2025-06-27"), Status = "Returned" },
    new BorrowReceipt { ReceiptId = 22, UserId = 15, BorrowDate = DateTime.Parse("2025-06-22"), ReturnDate = DateTime.Parse("2025-06-30"), Status = "Borrowing" },
    new BorrowReceipt { ReceiptId = 23, UserId = 16, BorrowDate = DateTime.Parse("2025-06-23"), ReturnDate = DateTime.Parse("2025-06-30"), Status = "Returned" },
    new BorrowReceipt { ReceiptId = 24, UserId = 17, BorrowDate = DateTime.Parse("2025-06-24"), ReturnDate = DateTime.Parse("2025-07-01"), Status = "Borrowing" },
    new BorrowReceipt { ReceiptId = 25, UserId = 18, BorrowDate = DateTime.Parse("2025-06-25"), ReturnDate = DateTime.Parse("2025-07-02"), Status = "Borrowing" }
);


            // BorrowDetails
            model.Entity<BorrowDetail>().HasData(
                new BorrowDetail { ReceiptId = 1, BookId = 1, ActualReturnDate = DateTime.Parse("2025-06-05"), FineAmount = 0m },
                new BorrowDetail { ReceiptId = 1, BookId = 2, ActualReturnDate = DateTime.Parse("2025-06-05"), FineAmount = 0m },
                new BorrowDetail { ReceiptId = 2, BookId = 3, ActualReturnDate = DateTime.Parse("2025-06-10"), FineAmount = 0m },
                new BorrowDetail { ReceiptId = 2, BookId = 4, ActualReturnDate = DateTime.Parse("2025-06-10"), FineAmount = 0m },
                new BorrowDetail { ReceiptId = 3, BookId = 5, ActualReturnDate = null, FineAmount = null },
                new BorrowDetail { ReceiptId = 3, BookId = 6, ActualReturnDate = null, FineAmount = null },
                new BorrowDetail { ReceiptId = 4, BookId = 7, ActualReturnDate = null, FineAmount = null },
                new BorrowDetail { ReceiptId = 5, BookId = 8, ActualReturnDate = DateTime.Parse("2025-06-12"), FineAmount = 15000m },
                new BorrowDetail { ReceiptId = 5, BookId = 9, ActualReturnDate = DateTime.Parse("2025-06-12"), FineAmount = 20000m },
                new BorrowDetail { ReceiptId = 5, BookId = 10, ActualReturnDate = DateTime.Parse("2025-06-12"), FineAmount = 2.00m },
                new BorrowDetail { ReceiptId = 6, BookId = 11, ActualReturnDate = null, FineAmount = null },
                new BorrowDetail { ReceiptId = 6, BookId = 12, ActualReturnDate = null, FineAmount = null },
                new BorrowDetail { ReceiptId = 7, BookId = 13, ActualReturnDate = null, FineAmount = null },
                new BorrowDetail { ReceiptId = 7, BookId = 14, ActualReturnDate = null, FineAmount = null },
                new BorrowDetail { ReceiptId = 8, BookId = 15, ActualReturnDate = DateTime.Parse("2025-06-15"), FineAmount = 0m },
                new BorrowDetail { ReceiptId = 8, BookId = 16, ActualReturnDate = DateTime.Parse("2025-06-15"), FineAmount = 0m },
                new BorrowDetail { ReceiptId = 9, BookId = 17, ActualReturnDate = null, FineAmount = null },
                new BorrowDetail { ReceiptId = 9, BookId = 18, ActualReturnDate = null, FineAmount = null },
                new BorrowDetail { ReceiptId = 10, BookId = 19, ActualReturnDate = null, FineAmount = null },
                new BorrowDetail { ReceiptId = 10, BookId = 20, ActualReturnDate = null, FineAmount = null }
            );
        }
    }
}
