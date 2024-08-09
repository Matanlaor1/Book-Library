using BookLib.Models;
using System.IO;
using System.Windows;
using System.Xml.Serialization;

namespace BookLib
{
    internal class Repository
    {
        string Booksfilename = "Books.xml";
        string Journalfilename = "Journals.xml";
        public void SaveData<T>(T items, bool isBook) where T : class
        {
            XmlSerializer serializer = new XmlSerializer(typeof(T));
            try
            {
                using (var sw = new StreamWriter(isBook ? Booksfilename : Journalfilename))
                {
                    serializer.Serialize(sw, items);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        public List<AbstractItem> LoadData(bool isBook)
        {
            Type type = isBook ? typeof(List<Book>) : typeof(List<Journal>);
            XmlSerializer serializer = new XmlSerializer(type);
            try
            {
                using (var sr = new StreamReader(isBook ? Booksfilename : Journalfilename))
                {
                    var items = (List<AbstractItem>)serializer.Deserialize(sr);
                    return items ?? new List<AbstractItem>();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return new List<AbstractItem>();
            }
        }


    }
}
