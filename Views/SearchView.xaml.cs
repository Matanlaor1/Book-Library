using BookLib;
using BookLib.Models;
using System.Windows;

namespace LibraryProject.Views
{
    /// <summary>
    /// Interaction logic for SearchView.xaml
    /// </summary>
    public partial class SearchView : Window
    {
        public SearchView()
        {
            InitializeComponent();
            cbMonths.ItemsSource = Enum.GetValues(typeof(Months));
        }

        private void SearchButton_Click(object sender, RoutedEventArgs e)
        {
            if (tbISBN.IsEnabled == true && tbISBN.Text != "" )
            {
                var resultByISBN = LibCollection.Init.GetBooksByISBN(tbISBN.Text);
                lvItems.ItemsSource = resultByISBN; return;
            }
            if (cbMonths.IsEnabled == true && cbMonths.SelectedIndex > 0)
            {
                var resultByMonth = LibCollection.Init.GetJournalsByMonth((Months)cbMonths.SelectedItem);
                lvItems.ItemsSource = resultByMonth; return;
            }
            int.TryParse(tbPrice.Text, out int price);
            if (price == 0)
            {
                var resultbyName = LibCollection.Init.GetItemsByTitle(tbTitle.Text);
                lvItems.ItemsSource = resultbyName;
            }
            else if (!(price <= 0))
            {
                AbstractItem abstructItem = new Book(tbTitle.Text, price);
                var result = LibCollection.Init.GetItemsByTitleAndPrice(abstructItem);
                lvItems.ItemsSource = result;
            }
            else { lvItems.Items.Clear(); }

        }



        private void lvItems_MouseDoubleClick(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            var item = lvItems.SelectedItem as AbstractItem;
            if (item != null)
            {
                var ObjectInfoWin = new ObjectInfo(item);
                ObjectInfoWin.Show();
            }


        }



        private void tbISBN_TextChanged(object sender, System.Windows.Controls.TextChangedEventArgs e)
        {
            if (tbISBN.Text.Length > 0) { cbMonths.IsEnabled = false; tbTitle.IsEnabled = false; tbPrice.IsEnabled = false; }
            else { cbMonths.IsEnabled = true; }
        }

        private void cbMonths_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {
            if (cbMonths.SelectedIndex == 0) { tbPrice.IsEnabled = true; tbTitle.IsEnabled = true; tbISBN.IsEnabled = true; }
            else { tbPrice.IsEnabled = false; tbTitle.IsEnabled=false; tbISBN.IsEnabled = false; }
            
        }

        private void tbTitle_TextChanged(object sender, System.Windows.Controls.TextChangedEventArgs e)
        {
            if (tbTitle.Text.Length > 0) { tbISBN.IsEnabled = false; cbMonths.IsEnabled=false; }
            else { tbISBN.IsEnabled = true; cbMonths.IsEnabled=true; }
        }

        private void tbPrice_TextChanged(object sender, System.Windows.Controls.TextChangedEventArgs e)
        {
            if (tbPrice.Text.Length > 0) { tbISBN.IsEnabled = false; cbMonths.IsEnabled= false; }
            else { tbISBN.IsEnabled = true;cbMonths.IsEnabled = true; }
        }
    }
}
