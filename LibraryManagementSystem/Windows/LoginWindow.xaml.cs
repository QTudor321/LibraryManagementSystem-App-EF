using LibraryManagementSystem.Database;
using LibraryManagementSystem.Entities;
using LibraryManagementSystem.Library;
using LibraryManagementSystem.UsersWindows;
using LibraryManagementSystem.Utilities;
using LibraryManagementSystem.Windows;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace LibraryManagementSystem
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class LoginWindow : Window
    {
        private Users _loggedInUser;
        private readonly LoginUtility _loginUtility;
        private readonly LibraryDatabaseContext _databaseContext;
        public LoginWindow(LibraryDatabaseContext librarycontext)
        {
            InitializeComponent();
            _databaseContext=librarycontext;
            _loginUtility=new LoginUtility(librarycontext);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            RegisterWindow registerWindow = new RegisterWindow(_databaseContext);
            registerWindow.Show();
            this.Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (_loggedInUser == null)
            {
                MessageBox.Show("User must be logged in!");
                return;
            }
            SubscriptionWindow subscriptionWindow = new SubscriptionWindow(_databaseContext, _loggedInUser.userID);
            subscriptionWindow.Show();
            this.Close();
        }
        private async void Button_Click_2(object sender, RoutedEventArgs e)
        {
            string username = TxtUsername.Text;
            string password = TxtPassword.Password;
            var loginSuccess = await _loginUtility.LoginFunction(username, password);
            if (loginSuccess!=null)
            {
                _loggedInUser = loginSuccess;
                MessageBox.Show("Login successful!");
                try
                {
                    if (loginSuccess.isLibrarian == 1)
                    {
                        LibrarianMainWindow librarianWindow = new LibrarianMainWindow(_databaseContext);
                        librarianWindow.Show();
                    }
                    else if (loginSuccess.subscriptionstatus == 1 && loginSuccess.isLibrarian == 0)
                    {
                        SubscribedLibraryMainWindow subscribedWindow = new SubscribedLibraryMainWindow(_databaseContext, _loggedInUser);
                        subscribedWindow.Show();
                    }
                    else
                    {
                        LibraryMainWindow libraryWindow = new LibraryMainWindow(_databaseContext, _loggedInUser);
                        libraryWindow.Show();
                    }

                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error in loading windows: "+ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Invalid username or password.");
            }
        }
    }
}