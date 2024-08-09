using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookLib.Models
{
    public class Book : AbstractItem
    {
        public string ISBN { get; set; }
        public string Type { get { return typeof(Book).Name; } }

        public Book(string title = "default") : base(title) { }

        public Book() { }


        public Book(string title, int price) : base(title) { Price = price; }

        public Book(string title,int price,string ISBNInput) : base(title) { Price = price; ISBN = ISBNInput; }
    }
}
