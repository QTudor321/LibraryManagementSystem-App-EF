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
using LibraryManagementSystem.Entities;
using LibraryManagementSystem.Database;
using LibraryManagementSystem.Utilities;

namespace LibraryManagementSystem.Windows
{
    /// <summary>
    /// Interaction logic for LibraryMainWindow.xaml
    /// </summary>
    public partial class LibraryMainWindow : Window
    {
        private Users _loggedUser;
        private readonly LibraryDatabaseContext _databaseContext;
        public LibraryMainWindow(LibraryDatabaseContext databaseContext, Users loggedUser)
        {
            InitializeComponent();
            _loggedUser = loggedUser;
            _databaseContext = databaseContext;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            UserProfile userProfile = new UserProfile(_databaseContext, _loggedUser);
            userProfile.Show();
            this.Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("In order to have acces to the Book Search Utility you need to be subscribed!");
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("In order to have acces to the Loaning Utility you need to be subscribed!");
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            LoginWindow loginWindow=new LoginWindow(_databaseContext);
            loginWindow.Show();
            this.Close();
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            SubscriptionWindow subscriptionW = new SubscriptionWindow(_databaseContext, _loggedUser.userID);
            subscriptionW.Show();
            this.Close();
        }
    }
}
