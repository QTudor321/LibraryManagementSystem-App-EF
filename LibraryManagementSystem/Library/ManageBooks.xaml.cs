using LibraryManagementSystem.Database;
using LibraryManagementSystem.Entities;
using LibraryManagementSystem.Utilities;
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

namespace LibraryManagementSystem.Library
{
    /// <summary>
    /// Interaction logic for ManageBooks.xaml
    /// </summary>
    public partial class ManageBooks : Window
    {
        private readonly LibraryDatabaseContext _databaseContext;
        private readonly BookUtility _bookUtility;
        public ManageBooks(LibraryDatabaseContext libraryDatabase)
        {
            InitializeComponent();
            _databaseContext = libraryDatabase;
            _bookUtility = new BookUtility(_databaseContext);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (GridAddBook.Visibility == Visibility.Visible)
            {
                GridAddBook.Visibility = Visibility.Collapsed;
            }
            else
            {
                GridAddBook.Visibility = Visibility.Visible;
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (GridUpdatePrice.Visibility == Visibility.Visible)
            {
                GridUpdatePrice.Visibility = Visibility.Collapsed;
            }
            else
            {
                GridUpdatePrice.Visibility = Visibility.Visible;
            }
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            if (GridDeleteBook.Visibility == Visibility.Visible)
            {
                GridDeleteBook.Visibility = Visibility.Collapsed;
            }
            else
            {
                GridDeleteBook.Visibility = Visibility.Visible;
            }
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            if (GridUpdateCopy.Visibility == Visibility.Visible)
            {
                GridUpdateCopy.Visibility = Visibility.Collapsed;
            }
            else
            {
                GridUpdateCopy.Visibility = Visibility.Visible;
            }
        }

        private async void Button_Click_4(object sender, RoutedEventArgs e)
        {
            try
            {
                var book = new Books
                {
                    title = TxtBookTitleAdd.Text,
                    theme = TxtBookThemeAdd.Text,
                    author = TxtBookAuthorAdd.Text,
                    identifier = TxtBookIdentifierAdd.Text,
                    price = decimal.Parse(TxtBookPriceAdd.Text),
                    copies = int.Parse(TxtBookCopiesAdd.Text)
                };

                bool added = await _bookUtility.AddBookAsync(book);
                MessageBox.Show(added ? "Book added successfully!" : "Failed to add book.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private async void Button_Click_5(object sender, RoutedEventArgs e)
        {
            if (int.TryParse(TxtBookIDUpdatePrice.Text, out int bookId) &&
                            decimal.TryParse(TxtPriceUpdatePrice.Text, out decimal newPrice))
            {
                bool updated = await _bookUtility.UpdateBookPriceAsync(bookId, newPrice);
                MessageBox.Show(updated ? "Price updated." : "Book not found.");
            }
            else
            {
                MessageBox.Show("Invalid input.");
            }
        }

        private async void Button_Click_6(object sender, RoutedEventArgs e)
        {
            if (int.TryParse(TxtBookIDDelete.Text, out int bookId))
            {
                bool deleted = await _bookUtility.DeleteBookAsync(bookId);
                MessageBox.Show(deleted ? "Book deleted successfully." : "Book not found.");
            }
            else
            {
                MessageBox.Show("Invalid Book ID.");
            }
        }

        private async void Button_Click_7(object sender, RoutedEventArgs e)
        {
            if (int.TryParse(TxtBookIDUpdateCopy.Text, out int bookId) &&
               int.TryParse(TxtCopiesUpdateCopy.Text, out int newCopies))
            {
                bool updated = await _bookUtility.UpdateBookCopiesAsync(bookId, newCopies);
                MessageBox.Show(updated ? "Copies updated." : "Book not found.");
            }
            else
            {
                MessageBox.Show("Invalid input.");
            }
        }

        private void Button_Click_8(object sender, RoutedEventArgs e)
        {
            LibrarianMainWindow librarianWindow = new LibrarianMainWindow(_databaseContext);
            librarianWindow.Show();
            this.Close();
        }
    }
}
