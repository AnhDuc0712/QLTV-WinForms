// Models/BorrowReceipt.cs
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace QLTV.Models
{
    [PrimaryKey("ReceiptId")]
    public class BorrowReceipt
    {
        [Key]
        public int ReceiptId { get; set; }

        public int UserId { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime BorrowDate { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? ReturnDate { get; set; }

        [Required, StringLength(20)]
        public string Status { get; set; }

        [ForeignKey("UserId")]
        public User User { get; set; }

        public virtual ICollection<BorrowDetail> BorrowDetails { get; set; }
    }
}
