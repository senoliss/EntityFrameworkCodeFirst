using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkCodeFirst
{
    public class Page
    {
        public Guid Id { get; set; }
        public int Number { get; set; }
        public string Content { get; set; }

        [ForeignKey("Book")] // navigation property to be able to pin pages to books by book id
        public Guid BookId { get; set; }
        public Book Book { get; set; }
        public Page(int number, string content) 
        {
            Guid id = Guid.NewGuid(); // if you want to have guid in order for pages use Guid id = Guid.NewGuid(); by not applying id to nothing the nugget package creates new Guid following pattern which in DB groups by id nicely.
            Number = number;
            Content = content;
        }
        public Page(Guid id) 
        {
            Id = id;
        }
    }
}
