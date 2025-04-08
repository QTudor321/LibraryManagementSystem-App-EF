using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryManagementSystem.Database;
using LibraryManagementSystem.Entities;
using Microsoft.EntityFrameworkCore;
namespace LibraryManagementSystem.Utilities
{
    internal class UserUtility
    {
        private readonly LibraryDatabaseContext _databaseContext;
        public UserUtility(LibraryDatabaseContext databaseContext)
        {
            _databaseContext = databaseContext;
        }
        public async Task<bool> AddUserAsync(Users user)
        {
            if (user == null)
            {
                return false;
            }
            _databaseContext.Users.Add(user);
            await _databaseContext.SaveChangesAsync();
            return true;
        }
        public async Task<bool> AddCardAsync(int userId, decimal credit)
        {
            var user = await _databaseContext.Users.Include(u => u.Cards).FirstOrDefaultAsync(u => u.userID == userId);
            if (user == null)
            {
                return false;
            }
            var card = new Cards
            {
                userID = userId,
                credit = credit
            };
            _databaseContext.Cards.Add(card);
            await _databaseContext.SaveChangesAsync();
            return true;
        }
        public async Task<bool> DeleteUserAsync(int userId)
        {
            var user = await _databaseContext.Users.Include(u => u.Cards).FirstOrDefaultAsync(u => u.userID == userId);
            if (user == null)
            {
                return false;
            }
            _databaseContext.Cards.RemoveRange(user.Cards);
            _databaseContext.Users.Remove(user);
            await _databaseContext.SaveChangesAsync();
            return true;
        }
        public async Task<bool> UpdateCardCreditAsync(int cardId, decimal newCredit)
        {
            var card = await _databaseContext.Cards.FindAsync(cardId);
            if (card == null)
            {
                return false;
            }
            card.credit = newCredit;
            await _databaseContext.SaveChangesAsync();
            return true;
        }
        public async Task<bool> UpdateSubscriptionStatusAsync(int userId, byte status)
        {
            var user = await _databaseContext.Users.FindAsync(userId);
            if (user == null)
            {
                return false;
            }
            user.subscriptionstatus = status;
            await _databaseContext.SaveChangesAsync();
            return true;
        }
    }
}
