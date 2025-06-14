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
                new Category { CategoryId = 3015, Name = "Ẩm thực – Nấu ăn" }
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
                new Publisher { PublisherId = 4008, Name = "NXB Công nghệ Thông tin" }
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
                new Author { AuthorId = 2015, Name = "Sun Tzu" }
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
                    Password = "P@ssw0rd1"
                },
                new User
                {
                    UserId = 1002,
                    FullName = "Trần Thị Ba",
                    Email = "thiba@gmail.com",
                    Username = "tranthiba",
                    Address = "Số 45, Đường 3/2, Phường Hưng Lợi, Quận Ninh Kiều, TP. Cần Thơ",
                    Phone = "0987654321",
                    Password = "B@Password2"
                },
                new User
                {
                    UserId = 1003,
                    FullName = "Lê Văn Chi",
                    Email = "vanchi@gmail.com",
                    Username = "levanchi",
                    Address = "Số 78, Phố Nguyễn Văn Cừ, Phường Gia Thuỷ, TP. Bắc Ninh",
                    Phone = "0901234567",
                    Password = "Ch1Secure!"
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
                new Book { BookId = 5030, Title = "Cẩm Nang Nấu Ăn Gia Đình", CategoryId = 3015, PublisherId = 4006, StockQuantity = 14, ImageUrl = null }
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
                new BookAuthor { BookId = 5018, AuthorId = 2002 }
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
                new BorrowReceipt { ReceiptId = 6010, UserId = 1001, BorrowDate = DateTime.Parse("2025-06-10"), ReturnDate = null, Status = "Borrowed" }
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
