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

        public string Phone { get; set; }
        
        public string Address { get; set; }

        public virtual ICollection<BorrowReceipt> BorrowReceipts { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
    }
}
