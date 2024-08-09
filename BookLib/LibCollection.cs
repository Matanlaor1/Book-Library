
using BookLib.Models;

namespace BookLib
{
    public class LibCollection
    {
        //readonly Repository dal = new Repository();

        public List<AbstractItem> Collection = new List<AbstractItem>();
        

        public static LibCollection Init { get; } = new LibCollection();

        public Action UpdateItemsCollection { get; set; }
        
        private LibCollection()
        {
        }

        public void AddItem(AbstractItem item)
        {
            Collection.Add(item);
            UpdateItemsCollection?.Invoke();
            
            //dal.SaveData(Collection.OfType<Book>().ToList(), true);
            //dal.SaveData(Collection.OfType<Journal>().ToList(), false);
        }


        //public (List<AbstractItem>, List<AbstractItem>) LoadData()
        //{
        //    List<AbstractItem> BookList = dal.LoadData(true);
        //    List<AbstractItem> JournalList = dal.LoadData(false);
        //    return (BookList, JournalList);
        //}



        public List<AbstractItem> GetItemsByTitle(string title)
        {
            List<AbstractItem> items = new List<AbstractItem>();
            foreach (var item in Collection)
            {
                if (item.Title.Contains(title))
                {
                    items.Add(item);
                }
            }
            return items;
        }

        public List<AbstractItem> GetItemsByTitleAndPrice(AbstractItem searchItem)
        {
            List<AbstractItem> items = new List<AbstractItem>();
            foreach (var item in Init.Collection)
            {
                if (item is null) { continue; }
                if(item.Title.Contains(searchItem.Title) && searchItem.Price <= item.Price)
                {
                    items.Add(item);
                }
            }
            return items;
        }

        public List<Book> GetBooksByISBN(string ISBN)
        {
            List<Book> books = new List<Book>();
            foreach (var item in Init.Collection)
            {
                if (item is null) { continue; }
                if (item is Book)
                {
                    Book book = (Book)item;
                    if (book.ISBN == null) { continue;}
                    if (book.ISBN.Contains(ISBN)) { books.Add(book); }
                }
            }
            return books;
        }

        public List<Journal> GetJournalsByMonth(Months month)
        {
            List<Journal> journals = new List<Journal>();
            foreach (var item in Init.Collection)
            {
                if (item is null) { continue; }
                if (item is Journal)
                {
                    Journal journal = (Journal)item;
                    if (journal.Month == month) {  journals.Add(journal); }
                }
            }
            return journals;
        }

        public static void EditBookISBN(Book book, string input)
        {
            book.ISBN = input;
        }
        public static void EditJournalMonth(Journal journal, Months month)
        {
            journal.Month = month;
        }

    }

}
