using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsumeIftaaAPI.Models
{
    public class Book
    {
        public Book()
        {
         
        }

        public int BookId { get; set; }
        public string BookName { get; set; }
        public int AuthorId { get; set; }

      
    }
}
