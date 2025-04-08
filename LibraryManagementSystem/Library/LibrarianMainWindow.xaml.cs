using LibraryManagementSystem.Database;
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

namespace LibraryManagementSystem.Library
{
    /// <summary>
    /// Interaction logic for LibrarianMainWindow.xaml
    /// </summary>
    public partial class LibrarianMainWindow : Window
    {
        private readonly LibraryDatabaseContext _databaseContext;
        public LibrarianMainWindow(LibraryDatabaseContext databaseContext)
        {
            InitializeComponent();
            _databaseContext = databaseContext;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            LoginWindow loginWindow = new LoginWindow(_databaseContext);
            loginWindow.Show();
            MessageBox.Show("Librarian logged off!");
            this.Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            ManageUsers manageUsers = new ManageUsers(_databaseContext);
            manageUsers.Show();
            this.Close();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            ManageBooks manageBooks= new ManageBooks(_databaseContext);
            manageBooks.Show();
            this.Close();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            ManageLoans manageLoans = new ManageLoans(_databaseContext);
            manageLoans.Show();
            this.Close();
        }
    }
}
