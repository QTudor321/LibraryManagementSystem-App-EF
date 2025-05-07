using LibraryManagementSystem.Database;
using LibraryManagementSystem.Entities;
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

namespace LibraryManagementSystem.Library
{
    /// <summary>
    /// Interaction logic for ManageUsers.xaml
    /// </summary>
    public partial class ManageUsers : Window
    {
        private readonly LibraryDatabaseContext _databaseContext;
        private readonly UserUtility _userUtility;
        public ManageUsers(LibraryDatabaseContext databaseContext)
        {
            InitializeComponent();
            _databaseContext = databaseContext;
            _userUtility = new UserUtility(databaseContext);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (GridAddUser.Visibility == Visibility.Visible)
            {
                GridAddUser.Visibility = Visibility.Collapsed;
            }
            else
            {
                GridAddUser.Visibility = Visibility.Visible;
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (GridAddCard.Visibility == Visibility.Visible)
            {
                GridAddCard.Visibility = Visibility.Collapsed;
            }
            else
            {
                GridAddCard.Visibility = Visibility.Visible;
            }
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            if (GridDeleteUser.Visibility == Visibility.Visible)
            {
                GridDeleteUser.Visibility = Visibility.Collapsed;
            }
            else
            {
                GridDeleteUser.Visibility = Visibility.Visible;
            }
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            if (GridUpdateCardCredit.Visibility == Visibility.Visible)
            {
                GridUpdateCardCredit.Visibility = Visibility.Collapsed;
            }
            else
            {
                GridUpdateCardCredit.Visibility = Visibility.Visible;
            }
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            if (GridUpdateStatus.Visibility == Visibility.Visible)
            {
                GridUpdateStatus.Visibility = Visibility.Collapsed;
            }
            else
            {
                GridUpdateStatus.Visibility = Visibility.Visible;
            }
        }

        private async void Button_Click_5(object sender, RoutedEventArgs e)
        {
            var newUser = new Users
            {
                username = TxtUsernameAdd.Text,
                lastname = TxtLastAdd.Text,
                firstname = TxtFirstNameAdd.Text,
                address = TxtAddressAdd.Text,
                password = TxtPasswordAdd.Text,
                subscriptionstatus = byte.Parse(TxtStatusAdd.Text),
                isLibrarian = byte.Parse(TxtLibByteAdd.Text)
            };

            bool result = await _userUtility.AddUserAsync(newUser);
            MessageBox.Show(result ? "User added!" : "Failed to add user.");
        }

        private async void Button_Click_6(object sender, RoutedEventArgs e)
        {
            int userId = int.Parse(TxtUserIDAddCard.Text);
            decimal credit = decimal.Parse(TxtCreditAddCard.Text);
            string number=TxtNumberAddCard.Text;
            DateTime expiration = DateTime.Parse(TxtExpirationAddCard.Text);
            string cvv=TxtCVVAddCard.Text;
            bool result = await _userUtility.AddCardAsync(userId, credit, number, expiration, cvv);
            MessageBox.Show(result ? "Card added!" : "Failed to add card.");
        }

        private async void Button_Click_7(object sender, RoutedEventArgs e)
        {
            int userId = int.Parse(TxtUserIDDelete.Text);

            bool result = await _userUtility.DeleteUserAsync(userId);
            MessageBox.Show(result ? "User deleted!" : "User not found.");
        }

        private async void Button_Click_8(object sender, RoutedEventArgs e)
        {
            int cardId = int.Parse(TxtCardIDUpdateCredit.Text);
            decimal newCredit = decimal.Parse(TxtCardCreditUpdateCredit.Text);

            bool result = await _userUtility.UpdateCardCreditAsync(cardId, newCredit);
            MessageBox.Show(result ? "Credit updated!" : "Card not found.");
        }

        private async void Button_Click_9(object sender, RoutedEventArgs e)
        {
            int userId = int.Parse(TxtUserIDStatus.Text);
            byte status = byte.Parse(TxtUserStatusStatus.Text);

            bool result = await _userUtility.UpdateSubscriptionStatusAsync(userId, status);
            MessageBox.Show(result ? "Subscription status updated!" : "User not found.");
        }

        private void Button_Click_10(object sender, RoutedEventArgs e)
        {
            LibrarianMainWindow librarianWindow=new LibrarianMainWindow(_databaseContext);
            librarianWindow.Show();
            this.Close();
        }
    }
}
