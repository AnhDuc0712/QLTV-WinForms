// Models/User.cs
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace QLTV.Models
{
    [PrimaryKey("UserId")]
    public class User
    {
        [Key]
        public int UserId { get; set; }

        [Required, StringLength(100)]
        public string FullName { get; set; }

        [Required, StringLength(100)]
        public string Email { get; set; }

        [Required, StringLength(20)]
        public string Phone { get; set; }

        [Required, StringLength(250)]
        public string Address { get; set; }

        public virtual ICollection<BorrowReceipt> BorrowReceipts { get; set; }

        [Required, StringLength(50)]
        public string Username { get; set; }

        // Bỏ [Required] để Password có thể NULL (dành cho Customer)
        [StringLength(100)]
        public string? Password { get; set; }

        // Thêm cột phân biệt Employee/Customer
        [Required, StringLength(20)]
        public string UserType { get; set; }
    }

    public class Employee : User { }
    public class Customer : User { }
}
