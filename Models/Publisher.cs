// Models/Publisher.cs
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace QLTV.Models
{
    [PrimaryKey("PublisherId")]
    public class Publisher
    {
        [Key]
        public int PublisherId { get; set; }

        [Required, StringLength(100)]
        public string Name { get; set; }

        public virtual ICollection<Book> Books { get; set; }
    }
}
