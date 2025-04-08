using LibraryManagementSystem.Database;
using LibraryManagementSystem.Utilities;
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

namespace LibraryManagementSystem.Windows
{
    /// <summary>
    /// Interaction logic for SubscriptionWindow.xaml
    /// </summary>
    public partial class SubscriptionWindow : Window
    {
        private readonly SubscriptionUtility _subscriptionUtility;
        private readonly LibraryDatabaseContext _databaseContext;
        private int _userID;
        public SubscriptionWindow(LibraryDatabaseContext databaseContext, int userId)
        {
            InitializeComponent();
            _databaseContext = databaseContext;
            _userID=userId;
            _subscriptionUtility = new SubscriptionUtility(databaseContext);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            LoginWindow loginWindow = new LoginWindow(_databaseContext);
            loginWindow.Show();
            this.Close();
        }

        private async void Button_Click_1(object sender, RoutedEventArgs e) 
        {
            string cardnumber=TxtCardNumber.Text;
            if (!DateTime.TryParse(TxtExpiration.Text, out DateTime expiration))
            {
                MessageBox.Show("Data de expirare invalida!");
                return;
            }
            string cvv = TxtCVV.Text;
            bool subscriptionSuccess = await _subscriptionUtility.ProcessSubscription(cardnumber, expiration, cvv, _userID);
            if (subscriptionSuccess)
            {
                LoginWindow loginW=new LoginWindow(_databaseContext);
                loginW.Show();
                this.Close();
            }
        }
    }
}
