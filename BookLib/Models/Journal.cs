namespace BookLib.Models
{

    public class Journal : AbstractItem
    {
        public Months Month { get; set; }
        public string Type { get { return typeof(Journal).Name; } }

        public Journal(string title = "default") : base(title) { }
        public Journal(string title, Months month, int price) : base(title) { Month = month; Price = price; }

    }


}
