using LibraryManagementSystem.Database;
using LibraryManagementSystem.Entities;
using Microsoft.EntityFrameworkCore;
using System.Windows;

namespace LibraryManagementSystem.Utilities
{
    internal class LoanUtility
    {
        private readonly LibraryDatabaseContext _databaseContext;
        public LoanUtility(LibraryDatabaseContext databaseContext)
        {
            _databaseContext = databaseContext;
        }
        public async Task<bool> LoanBookAsync(int userId, int bookId)
        {
            var activeLoan = await _databaseContext.Loans.Where(l => l.userID == userId && l.loanstatus == "Active").FirstOrDefaultAsync();
            if (activeLoan != null)
            {
                MessageBox.Show("User has an active loan. You cannot loan another book at this time.");
                return false;
            }
            var user = await _databaseContext.Users.Include(u=>u.Cards).FirstOrDefaultAsync(u => u.userID == userId);
            var book = await _databaseContext.Books.FirstOrDefaultAsync(b=>b.bookID == bookId);
            if (user == null || book == null)
            {
                MessageBox.Show("User or Book invalid.");
                return false;
            }
            if(book.copies <= 0)
            {
                MessageBox.Show("Unavailable book, no available copies to loan.");
                return false;
            }
            var card = user.Cards.FirstOrDefault();
            if (card == null || card.credit<book.price)
            {
                MessageBox.Show("Insufficient credit to loan the book!");
                return false;
            }
            book.copies -= 1;//retragerea unei carti din depozit, dupa imprumut
            card.credit -= book.price;//retragerea creditului din card dupa imprumut
            await _databaseContext.SaveChangesAsync();//salvarea retragerii creditului in baza de date
            var loan = new Loans//crearea unei noi inregistrari de imprumut
            {
                userID = userId,
                bookID = bookId,
                loandate = DateTime.Now,
                duedate = DateTime.Now.AddDays(17),//se returneaza dupa 17 zile
                loanstatus = "Active"
            };
            _databaseContext.Loans.Add(loan);
            await _databaseContext.SaveChangesAsync();
            MessageBox.Show($"Loaning Successful of the book {book.title}! Return it until {loan.duedate.ToShortTimeString()}.");
            return true;
        }
        public async Task<Loans> LoanDetailsAsync( int userId, int bookId)
        {
            var loan = await _databaseContext.Loans.Where(l => l.userID == userId && l.bookID == bookId).FirstOrDefaultAsync();
            return loan;
        }
        public async Task<bool> ReturnBookAsync(int userId)
        {
            //verificarea si salvarea informatiilor din inregistrarea loan
            var activeLoan = await _databaseContext.Loans.Include(l => l.Books).FirstOrDefaultAsync(l => l.userID == userId && l.loanstatus == "Active");
            if(activeLoan == null)
            {
                MessageBox.Show("You don't have any active loans.");
                return false;
            }
            //Update informatiile despre tabelul loan
            activeLoan.loanstatus = "Returned";
            activeLoan.returndate = DateTime.Now;
            if (activeLoan.Books != null)
            {
                activeLoan.Books.copies += 1;
            }
            await _databaseContext.SaveChangesAsync();
            MessageBox.Show("Book returned successfully!");
            return true;
        }
    }
}
