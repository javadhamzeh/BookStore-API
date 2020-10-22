using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookStore_API.Data
{
    [Table("Authors")]
    public partial class Author
    {
        public int Id { get; set; }
        public int Firstname { get; set; }
        public int Lastname { get; set; }
        public int Bio { get; set; }

        public virtual IList<Book> Books { get; set; }

    }
}