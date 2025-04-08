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
        //Utilitatea de logare
        public async Task<Users?> LoginFunction(string username, string password) {
            try
            {
                var user = await _libraryDatabaseContext.Users.FirstOrDefaultAsync(u => u.username == username && u.password == password);//verificarea facuta de functia FirstOrDefaultAsync din libraria EntityFramework
                if (user != null)
                    return user;
                else
                    return null;//dupa verificare, daca obiectul user este nenul va returna obiectul
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error in login utility!");
                return null;
            }
        }
        //Utilitatea de inregistrare
        public async Task<bool> RegisterFunction(string username, string firstname, string lastname, string address, string password)
        {
            var existinguser = await _libraryDatabaseContext.Users.FirstOrDefaultAsync(u => u.username == username);
            if (existinguser != null)
            {
                return false;
            }
            var newUser = new Users
            {
                username = username,
                firstname = firstname,
                lastname = lastname,
                address = address,
                password = password,
                subscriptionstatus = 0
            };
            _libraryDatabaseContext.Users.Add(newUser);
            await _libraryDatabaseContext.SaveChangesAsync();
            return true;
        }
    }
}
