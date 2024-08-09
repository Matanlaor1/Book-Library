using BookLib;
using BookLib.Models;
using System.Windows;
using System.Windows.Controls;

namespace LibraryProject.Views
{
    public partial class AddItemsView : Window
    {
        public AddItemsView()
        {
            InitializeComponent();
            ComboBoxMonths.ItemsSource = Enum.GetValues(typeof(Months));
            PopulateCB();
            //(List<AbstractItem> general1, List<AbstractItem> general2) = LibCollection.Init.LoadData();
            //List<AbstractItem> allData = new List<AbstractItem>();
            //allData = general1.Concat(general2).ToList();
            //lvItems.ItemsSource = allData;
        }

        private void PopulateCB()
        {

            ComboBoxItemType.Text = "Type of item";
            ComboBoxItemType.Items.Add("Book");
            ComboBoxItemType.Items.Add("Journal");
        }


        private void AddItem_Click(object sender, RoutedEventArgs e)
        {
            if (ComboBoxItemType.SelectedItem != null && tbTitle.Text != null)
            {
                if (ComboBoxItemType.Text == "Book")
                {
                    int.TryParse(tbPrice.Text, out var price);
                    string newBookName = tbTitle.Text;
                    Book newBook = new Book(newBookName, price);
                    lvItems.Items.Add(newBook);
                    lvItemsPrice.Items.Add(newBook);
                    LibCollection.Init.AddItem(newBook);
                }
                if (ComboBoxItemType.SelectedItem.ToString() == "Journal" && ComboBoxMonths.Text != null)
                {
                    int.TryParse(tbPrice.Text, out int price);
                    Journal newJournal = new Journal(tbTitle.Text,(Months)ComboBoxMonths.SelectedItem, price);
                    lvItems.Items.Add(newJournal);
                    lvItemsPrice.Items.Add(newJournal);
                    LibCollection.Init.AddItem(newJournal);
                }

                //lvItems.Items.Add(new Journal(newname, (Months)ComboBoxMonths.SelectedItem));

            }
            else { MessageBox.Show("Input is not valid"); }
        }

        private void ComboBoxItemType_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var selectedItem = (sender as ComboBox)?.SelectedItem as string;
            if (selectedItem != null && selectedItem == "Journal")
            {
                ComboBoxMonths.IsEnabled = true; 
            }
            else if (selectedItem != null && selectedItem == "Book")
            {
                ComboBoxMonths.IsEnabled = false;
            }
            else { ComboBoxMonths.IsEnabled = false; }
        }
    }
}
