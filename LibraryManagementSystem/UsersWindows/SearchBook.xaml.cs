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
using LibraryManagementSystem.Database;
using LibraryManagementSystem.Utilities;
using LibraryManagementSystem.Entities;
using Microsoft.EntityFrameworkCore;
namespace LibraryManagementSystem.UsersWindows
{
    /// <summary>
    /// Interaction logic for SearchBook.xaml
    /// </summary>
    public partial class SearchBook : Window
    {
        private Users _loggedUser;
        private Books searchedBook;
        private LibraryDatabaseContext _databaseContext;
        public SearchBook(LibraryDatabaseContext databaseContext, Users loggedUser)
        {
            InitializeComponent();
            _databaseContext = databaseContext;
            _loggedUser = loggedUser;
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            SubscribedLibraryMainWindow subscribedLibMain = new SubscribedLibraryMainWindow(_databaseContext, _loggedUser);
            subscribedLibMain.Show();
            this.Close();
        }

        private async void Button_Click_1(object sender, RoutedEventArgs e)
        {
            string name = TxtName.Text;
            if (string.IsNullOrEmpty(name))
            {
                MessageBox.Show("Enter a book Title!");
                return;
            }
            searchedBook = await _databaseContext.Books.FirstOrDefaultAsync(b => b.title == name);
            if (searchedBook == null)
            {
                MessageBox.Show($"Title {name} is invalid!");
                return;
            }
            else
            {
                TxtTitle.Text = searchedBook.title;
                TxtTheme.Text = searchedBook.theme;
                TxtAuthor.Text = searchedBook.author;
                TxtIdentifier.Text = searchedBook.identifier;
                TxtCopies.Text = searchedBook.copies.ToString();
                TxtPrice.Text = searchedBook.price.ToString();
            }
        }
    }
}
