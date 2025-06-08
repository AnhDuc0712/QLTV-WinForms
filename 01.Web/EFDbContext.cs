// LibraryContext.cs
using Microsoft.EntityFrameworkCore;
using QLTV.Models;
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
            // Khóa chính cho bảng nối nhiều-nhiều
            model.Entity<BookAuthor>()
                 .HasKey(ba => new { ba.BookId, ba.AuthorId });
            model.Entity<BorrowDetail>()
                 .HasKey(bd => new { bd.ReceiptId, bd.BookId });

            // Optional: Seed một vài bản ghi mẫu
            model.Entity<Category>().HasData(
              new Category { CategoryId = 1, Name = "Văn học" },
              new Category { CategoryId = 2, Name = "Khoa học" }
            );
            // … tương tự cho Authors, Publishers, Users …
        }
    }
}
