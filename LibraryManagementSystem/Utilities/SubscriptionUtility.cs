using LibraryManagementSystem.Database;
using LibraryManagementSystem.Entities;
using Microsoft.EntityFrameworkCore;
using System.Windows;

namespace LibraryManagementSystem.Utilities
{
    internal class SubscriptionUtility
    {
        private readonly LibraryDatabaseContext _databaseContext;
        public SubscriptionUtility(LibraryDatabaseContext databaseContext)
        {
            _databaseContext = databaseContext;
        }
        public async Task<bool> ProcessSubscription(string number, DateTime expiration, string cvv, int userID)
        {
            string hashedNumber = HashUtility.ComputeSha256Hash(number);
            var card = await _databaseContext.Cards.Include(c => c.Users).FirstOrDefaultAsync(c => c.number == hashedNumber && c.expiration.Date == expiration.Date && c.cvv == cvv && c.userID == userID);
            if (card == null)
            {
                MessageBox.Show("Card is invalid");
                return false;
            }
            if(card.credit<100)
            {
                MessageBox.Show("Insufficient Credit, at least 100 is required for subscription.");
                return false;
            }
            card.credit -= 100;
            card.Users.subscriptionstatus = 1;
            await _databaseContext.SaveChangesAsync();
            MessageBox.Show("Subscription successful!");
            return true;
        }
    }
}
