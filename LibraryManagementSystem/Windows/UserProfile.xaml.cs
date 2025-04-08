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
namespace LibraryManagementSystem.Windows
{
    /// <summary>
    /// Interaction logic for UserProfile.xaml
    /// </summary>
    public partial class UserProfile : Window
    {
        private Users _loggedUser;
        private readonly LibraryDatabaseContext _libraryDatabaseContext;
        public UserProfile(LibraryDatabaseContext libraryDatabaseContext, Users loggedUser)
        {
            InitializeComponent();
            _loggedUser = loggedUser;
            _libraryDatabaseContext = libraryDatabaseContext;
            ShowLoggedUserProfile();
        }
        private void ShowLoggedUserProfile()
        {
            TxtUsername.Text = _loggedUser.username;
            TxtLastName.Text = _loggedUser.lastname;
            TxtFirstName.Text = _loggedUser.firstname;
            TxtAddress.Text = _loggedUser.address;
            TxtSubscribed.Text = _loggedUser.subscriptionstatus == 1 ? "Valid" : "Invalid";
            var cardcount=_libraryDatabaseContext.Cards.Where(c=>c.userID == _loggedUser.userID).Count();
            TxtCardCount.Text=cardcount.ToString();
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            LibraryMainWindow libraryMain = new LibraryMainWindow(_libraryDatabaseContext, _loggedUser);
            libraryMain.Show();
            this.Close();
        }
    }
}
