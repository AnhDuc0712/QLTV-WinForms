// Models/Book.cs
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace QLTV.Models
{
    [PrimaryKey("BookId")]
    public class Book
    {
        [Key]
        public int BookId { get; set; }

        [Required, StringLength(200)]
        public string Title { get; set; }

        public int CategoryId { get; set; }
        public int PublisherId { get; set; }
        public int StockQuantity { get; set; }
        public string? ImageUrl { get; set; }

        [ForeignKey("CategoryId")]
        public Category Category { get; set; }

        [ForeignKey("PublisherId")]
        public Publisher Publisher { get; set; }


        public virtual ICollection<BookAuthor> BookAuthors { get; set; }
        public virtual ICollection<BorrowDetail> BorrowDetails { get; set; }
    }
}
