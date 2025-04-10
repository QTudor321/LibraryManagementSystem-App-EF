using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryManagementSystem.Database;
using LibraryManagementSystem.Entities;

namespace LibraryManagementSystem.Utilities
{
    internal class LibrarianLoanUtility
    {
        private readonly LibraryDatabaseContext _libraryDatabaseContext;
        public LibrarianLoanUtility(LibraryDatabaseContext libraryDatabaseContext)
        {
            _libraryDatabaseContext = libraryDatabaseContext;
        }
        public async Task<bool> UpdateLoanAsync(int loanId)
        {
            var loan = await _libraryDatabaseContext.Loans.FindAsync(loanId);
            if (loan == null || loan.loanstatus == "Returned")
            {
                return false;
            }

            loan.returndate = DateTime.Now;
            loan.loanstatus = "Returned";
            var book = await _libraryDatabaseContext.Books.FindAsync(loan.bookID);
            if (book != null)
            {
                book.copies += 1;
            }

            await _libraryDatabaseContext.SaveChangesAsync();
            return true;
        }
        public async Task<bool> DeleteLoanAsync(int loanId)
        {
            var loan = await _libraryDatabaseContext.Loans.FindAsync(loanId);
            if (loan == null)
            {
                return false;
            }

            _libraryDatabaseContext.Loans.Remove(loan);
            await _libraryDatabaseContext.SaveChangesAsync();
            return true;
        }
    }
}
