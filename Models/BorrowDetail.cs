// Models/BorrowDetail.cs
using System;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Ngducanh

{
    [PrimaryKey("ReceiptId", "BookId")]
    public class BorrowDetail
    {
        public int ReceiptId { get; set; }
        public int BookId { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? ActualReturnDate { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal? FineAmount { get; set; }

        [ForeignKey("ReceiptId")]
        public BorrowReceipt BorrowReceipt { get; set; }

        [ForeignKey("BookId")]
        public Book Book { get; set; }
    }
}
