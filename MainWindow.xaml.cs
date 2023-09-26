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
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.IO;

namespace _07_WPF_Konyvek
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Book> books = new List<Book>();
        List<string> authors = new List<string>();
        public MainWindow()
        {
            InitializeComponent();
            loadBooks();
            loadAuthors();
        
            CBO_authors.ItemsSource = authors;
            CBO_authors.SelectedIndex = 0;
        }

        private void loadBooks()
        {
            foreach (var row in File.ReadAllLines("bookList.csv").Skip(1))
            {
                books.Add(new Book(row));
            } 
        }


        private void loadAuthors()
        {
            foreach (var oneBook in books)
            {
                if (!authors.Contains(oneBook.Author))
                {
                    authors.Add(oneBook.Author);
                }
            }
            authors.Sort(); //remdezés
        }

    }
}
