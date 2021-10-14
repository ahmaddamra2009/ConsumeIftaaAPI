using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsumeIftaaAPI.Models
{
    public partial class Author
    {
        public Author()
        {
            Books = new HashSet<Book>();
        }

        public int AuthorId { get; set; }
        public string AuthorName { get; set; }
        public string Email { get; set; }

        public virtual ICollection<Book> Books { get; set; }
    }
}
