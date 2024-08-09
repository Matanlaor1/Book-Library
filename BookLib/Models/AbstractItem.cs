using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookLib.Models
{
    public abstract class AbstractItem
    {
        public string Title { get; set; }
        public int Price { get; set; }


        public AbstractItem(string title)
        {
            Title = title;
        }
        public AbstractItem() { }
    }
}
