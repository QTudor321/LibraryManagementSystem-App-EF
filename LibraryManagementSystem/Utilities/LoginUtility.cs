using LibraryManagementSystem.Database;
using LibraryManagementSystem.Entities;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using System.Windows;

namespace LibraryManagementSystem.Utilities
{
    internal class LoginUtility
    {
        private readonly LibraryDatabaseContext _libraryDatabaseContext;
        public LoginUtility(LibraryDatabaseContext libraryDatabaseContext)
        {
            _libraryDatabaseContext = libraryDatabaseContext;
        }
        public async Task<Users?> LoginFunction(string username, string password) {
            try
            {
                string hashedPassword = HashUtility.ComputeSha256Hash(password);
                var user = await _libraryDatabaseContext.Users.FirstOrDefaultAsync(u => u.username == username && u.password == hashedPassword);
                if (user != null)
                    return user;
                else
                    return null;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error in login utility!");
                return null;
            }
        }
        public async Task<bool> RegisterFunction(string username, string firstname, string lastname, string address, string password)
        {
            var existinguser = await _libraryDatabaseContext.Users.FirstOrDefaultAsync(u => u.username == username);
            if (existinguser != null)
            {
                return false;
            }
            var hashedPassword = HashUtility.ComputeSha256Hash(password);
            var newUser = new Users
            {
                username = username,
                firstname = firstname,
                lastname = lastname,
                address = address,
                password = hashedPassword,
                subscriptionstatus = 0,
                isLibrarian = 0
            };
            _libraryDatabaseContext.Users.Add(newUser);
            await _libraryDatabaseContext.SaveChangesAsync();
            return true;
        }
    }
}
