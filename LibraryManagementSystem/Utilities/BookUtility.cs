using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryManagementSystem.Database;
using LibraryManagementSystem.Entities;

namespace LibraryManagementSystem.Utilities
{
    internal class BookUtility
    {
        private readonly LibraryDatabaseContext _databaseContext;
        public BookUtility(LibraryDatabaseContext databaseContext)
        {
            _databaseContext = databaseContext;
        }
        public async Task<bool> AddBookAsync(Books book)
        {
            if (book == null)
            {
                return false;
            }
            _databaseContext.Books.Add(book);
            await _databaseContext.SaveChangesAsync();
            return true;
        }
        public async Task<bool> DeleteBookAsync(int bookId)
        {
            var book = await _databaseContext.Books.FindAsync(bookId);
            if (book == null)
            {
                return false;
            }
            _databaseContext.Books.Remove(book);
            await _databaseContext.SaveChangesAsync();
            return true;
        }
        public async Task<bool> UpdateBookPriceAsync(int bookId, decimal newPrice)
        {
            var book = await _databaseContext.Books.FindAsync(bookId);
            if(book == null)
            {
                return false;
            }
            book.price=newPrice;
            await _databaseContext.SaveChangesAsync();
            return true;
        }
        public async Task<bool> UpdateBookCopiesAsync(int bookId, int newCopies)
        {
            var book = await _databaseContext.Books.FindAsync(bookId);
            if( book == null )
            {
                return false;
            }
            book.copies = newCopies;
            await _databaseContext.SaveChangesAsync();
            return true;
        }
    }
}
