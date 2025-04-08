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

namespace LibraryManagementSystem.Windows
{
    /// <summary>
    /// Interaction logic for RegisterWindow.xaml
    /// </summary>
    public partial class RegisterWindow : Window
    {
        private readonly LoginUtility _loginUtility;
        private readonly LibraryDatabaseContext _databaseContext;
        public RegisterWindow(LibraryDatabaseContext librarycontext)
        {
            InitializeComponent();
            _databaseContext = librarycontext;
            _loginUtility=new LoginUtility(librarycontext);
        }

        private async void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string username = TxtUsername.Text;//initializarea unui obiect cu continutul din caseta text
                string lastname = TxtLast.Text;
                string firstname = TxtFirst.Text;
                string address = TxtAddress.Text;
                string password = TxtPass.Password;
                bool registerSuccess = await _loginUtility.RegisterFunction(username, lastname, firstname, address, password);//initializarea unui bool prin utilitate

                if (registerSuccess)//daca este adevarat
                {
                    MessageBox.Show("Register successful!");
                    // Navigate to LibraryMainWindow
                    LoginWindow loginWindow = new LoginWindow(_databaseContext);
                    loginWindow.Show();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Invalid username or password.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }
    }
}
