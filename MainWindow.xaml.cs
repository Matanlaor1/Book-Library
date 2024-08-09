using BookLib;
using BookLib.Models;
using LibraryProject.Views;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace LibraryProject
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        readonly LibCollection lib = LibCollection.Init;
        public MainWindow()
        {
            InitializeComponent();
            LibCollection.Init.Collection.Add(new Book("Harry Potter 1", 15, "a"));
            LibCollection.Init.Collection.Add(new Book("Harry Potter 2", 15,"ab"));
            LibCollection.Init.Collection.Add(new Book("Harry Potter 3", 15,"abc"));
            LibCollection.Init.Collection.Add(new Book("The Lord of the Rings", 20));
            LibCollection.Init.Collection.Add(new Book("1984", 10));
            LibCollection.Init.Collection.Add(new Book("The Catcher in the Rye", 12));
            LibCollection.Init.Collection.Add(new Book("To Kill a Mockingbird", 18));
            LibCollection.Init.Collection.Add(new Book("The Great Gatsby", 14));
            LibCollection.Init.Collection.Add(new Book("Moby Dick", 17));
            LibCollection.Init.Collection.Add(new Book("Pride and Prejudice", 16));
            LibCollection.Init.Collection.Add(new Book("Wuthering Heights", 13));
            LibCollection.Init.Collection.Add(new Book("Jane Eyre", 11));

            LibCollection.Init.Collection.Add(new Journal("Whispers of Winter", Months.jan, 20));
            LibCollection.Init.Collection.Add(new Journal("Frosty Chronicles", Months.feb, 25));
            LibCollection.Init.Collection.Add(new Journal("Marching Melodies", Months.mar, 18));
            LibCollection.Init.Collection.Add(new Journal("April Awakening", Months.apr, 22));
            LibCollection.Init.Collection.Add(new Journal("May Mystique", Months.may, 30));
            LibCollection.Init.Collection.Add(new Journal("June Journeys", Months.jun, 28));
            LibCollection.Init.Collection.Add(new Journal("July Jubilations", Months.jul, 24));
            LibCollection.Init.Collection.Add(new Journal("August Auroras", Months.aug, 27));
            LibCollection.Init.Collection.Add(new Journal("September Serenades", Months.sep, 21));
            LibCollection.Init.Collection.Add(new Journal("October Odes", Months.oct, 15));
            LibCollection.Init.Collection.Add(new Journal("November Nocturnes", Months.nov, 23));
            LibCollection.Init.Collection.Add(new Journal("December Dreams", Months.dec, 19));
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var AddItemsview = new AddItemsView();

            AddItemsview.Show();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            var SearchEngine = new SearchView();
            SearchEngine.Show();
        }
    }
}