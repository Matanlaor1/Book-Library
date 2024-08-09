using BookLib;
using BookLib.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace LibraryProject.Views
{
    /// <summary>
    /// Interaction logic for ObjectInfo.xaml
    /// </summary>
    public partial class ObjectInfo : Window
    {
        private AbstractItem item;
        public ObjectInfo(AbstractItem item)
        {
            this.item = item;
            InitializeComponent();
            if (item.GetType() == typeof(Book))
            {
                tbISBNEditInput.Visibility = Visibility.Visible;
                tbISBNEditTitle.Visibility = Visibility.Visible;
            }
            if (item.GetType() == typeof(Journal))
            {
                tbMonthEditTitle.Visibility = Visibility.Visible;
                cbMonthsEditInput.Visibility = Visibility.Visible;
            }
            cbMonthsEditInput.ItemsSource = Enum.GetValues(typeof(Months));
            Populate();
        }

        private void Populate()
        {
            tbItemName.Text = "Title: "+item.Title;
            tbItemPrice.Text = "Price: " +item.Price.ToString()+"$";
            tbType.Text = "Category: "+item.GetType().Name;
        }

        private void UpdateButton_Click(object sender, RoutedEventArgs e)
        {
            if (tbEditName.Text.Length > 0)
            {
                item.Title = tbEditName.Text;
            }
            if (tbEditPrice.Text.Length > 0)
            {
                int.TryParse(tbEditPrice.Text, out int result);
                if (result < 0) { result = 0; }
                item.Price = result;
            }
            if (item.GetType() == typeof(Book) && tbISBNEditInput.Text.Length > 0)
            {
                LibCollection.EditBookISBN((Book)item, tbISBNEditInput.Text);
            }
            if (cbMonthsEditInput.SelectedIndex > 0)
            {
                LibCollection.EditJournalMonth((Journal)item, (Months)cbMonthsEditInput.SelectedItem);
            }
            MessageBox.Show("Updated");
            tbEditName.Clear();
            tbEditPrice.Clear();
            tbISBNEditInput.Clear();
            this.Close();
        }

        private void DeleteButton_Click(object sender, RoutedEventArgs e)
        {
            LibCollection.Init.Collection.Remove(item);
            Close();
            MessageBox.Show("Item Deleted");
        }
    }
}
