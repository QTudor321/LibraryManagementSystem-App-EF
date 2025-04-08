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
using LibraryManagementSystem.Windows;
using LibraryManagementSystem.Entities;
namespace LibraryManagementSystem.UsersWindows
{
    /// <summary>
    /// Interaction logic for SubscribedLibraryMainWindow.xaml
    /// </summary>
    public partial class SubscribedLibraryMainWindow : Window
    {
        private Users _loggedUser;
        private readonly LibraryDatabaseContext _databaseContext;
        public SubscribedLibraryMainWindow(LibraryDatabaseContext databaseContext, Users loggedUser)
        {
            InitializeComponent();
            _loggedUser = loggedUser;
            _databaseContext = databaseContext;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            SearchBook searchBook = new SearchBook(_databaseContext, _loggedUser);
            searchBook.Show();
            this.Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            UserProfile userProfile = new UserProfile(_databaseContext, _loggedUser);
            userProfile.Show();
            this.Close();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            LoanBook loanBook = new LoanBook(_databaseContext, _loggedUser);
            loanBook.Show();
            this.Close();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            LoginWindow loginWindow=new LoginWindow(_databaseContext);
            loginWindow.Show();
            this.Close();
        }
    }
}
