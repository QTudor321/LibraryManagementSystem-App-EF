using LibraryManagementSystem.Database;
using LibraryManagementSystem.Entities;
using LibraryManagementSystem.Utilities;
using Microsoft.EntityFrameworkCore;
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

namespace LibraryManagementSystem.UsersWindows
{
    /// <summary>
    /// Interaction logic for LoanBook.xaml
    /// </summary>
    public partial class LoanBook : Window
    {
        private readonly LibraryDatabaseContext _libraryDatabaseContext;
        private readonly LoanUtility _loanUtility;
        private Users _loggedUser;
        private Books _currentBook;
        public LoanBook(LibraryDatabaseContext libraryDatabaseContext, Users loggedUser)
        {
            InitializeComponent();
            _libraryDatabaseContext = libraryDatabaseContext;
            _loanUtility = new LoanUtility(libraryDatabaseContext);
            _loggedUser = loggedUser;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (GridLoan.Visibility == Visibility.Visible)
            {
                GridLoan.Visibility = Visibility.Collapsed;
            }
            else
            {
                GridLoan.Visibility = Visibility.Visible;
            }
        }

        private async void Button_Click_1(object sender, RoutedEventArgs e)
        {
            string Identifier = TxtIdentifier.Text;
            if (string.IsNullOrEmpty(Identifier))
            {
                MessageBox.Show("Enter a book Identifier!");
                return;
            }
            _currentBook = await _libraryDatabaseContext.Books.FirstOrDefaultAsync(b => b.identifier == Identifier);
            if (_currentBook == null)
            {
                MessageBox.Show($"Identifier {Identifier} is invalid!");
                return;
            }
            else
            {
                TxtTitle.Text = _currentBook.title;
                TxtTheme.Text = _currentBook.theme;
                TxtAuthor.Text = _currentBook.author;
                TxtCopies.Text = _currentBook.copies.ToString();
                TxtPrice.Text = _currentBook.price.ToString();
            }
        }

        private async void Button_Click_2(object sender, RoutedEventArgs e)
        {
            if (_currentBook == null)
            {
                MessageBox.Show("Invalid book to loan!");
                return;
            }
            bool loanresult = await _loanUtility.LoanBookAsync(_loggedUser.userID, _currentBook.bookID);
            if (loanresult)
            {
                _currentBook = await _libraryDatabaseContext.Books.FirstOrDefaultAsync(b => b.bookID == _currentBook.bookID);
                TxtTitle.Text = _currentBook.title;
                TxtTheme.Text = _currentBook.theme;
                TxtAuthor.Text = _currentBook.author;
                TxtCopies.Text = _currentBook.copies.ToString();
                TxtPrice.Text = _currentBook.price.ToString();
            }
        }

        private async void Button_Click_3(object sender, RoutedEventArgs e)
        {
            bool returnresult = await _loanUtility.ReturnBookAsync(_loggedUser.userID);
            if (returnresult)
            {
                MessageBox.Show($"User {_loggedUser.username} has now 0 loans!");
            }
        }

        private async void Button_Click_4(object sender, RoutedEventArgs e)
        {
            var selectedBook = _currentBook;
            if(selectedBook == null)
            {
                MessageBox.Show("Select a book to view Loan Details!");
                return;
            }
            var loan = await _loanUtility.LoanDetailsAsync(_loggedUser.userID, selectedBook.bookID);
            if(loan== null)
            {
                MessageBox.Show($"Loan unavailable for user {_loggedUser.username} and selected book.");
            }
            else
            {
                TxtUserUsername.Text=_loggedUser.username;
                TxtBookID.Text = selectedBook.identifier;
                TxtLoanDate.Text = loan.loandate.ToString("d");
                TxtDueDate.Text = loan.duedate.ToString("d");
                TxtReturnDate.Text = loan.returndate?.ToString("d") ?? "Not Returned";
                TxtLoanStatus.Text = loan.loanstatus;
            }
        }
    }
}
