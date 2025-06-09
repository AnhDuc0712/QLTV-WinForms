// Models/Author.cs
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace Ngducanh
{
    [PrimaryKey("AuthorId")]
    public class Author
    {
        [Key]
        public int AuthorId { get; set; }

        [Required, StringLength(100)]
        public string Name { get; set; }

        public virtual ICollection<BookAuthor> BookAuthors { get; set; }
    }
}
