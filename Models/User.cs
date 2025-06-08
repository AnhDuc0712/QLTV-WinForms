using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace Ngducanh
{
    [PrimaryKey("UserId")]
    public class User
    {
        [Key]
        public int UserId { get; set; }

        [Required, StringLength(100)]
        public string Username { get; set; } = "";   // Có giá trị mặc định

        [Required, StringLength(100)]
        public string Password { get; set; } = "";   // Có giá trị mặc định

        // Các trường này CHO PHÉP NULL vì trên SQL là NULL
        public string? FullName { get; set; }
        public string? Email { get; set; }
        public string? Phone { get; set; }
        public string? Address { get; set; }

        public virtual ICollection<BorrowReceipt>? BorrowReceipts { get; set; }
    }
}
