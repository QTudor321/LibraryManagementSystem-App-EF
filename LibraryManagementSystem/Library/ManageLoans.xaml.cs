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

namespace LibraryManagementSystem.Library
{
    /// <summary>
    /// Interaction logic for ManageLoans.xaml
    /// </summary>
    public partial class ManageLoans : Window
    {
        private readonly LibraryDatabaseContext _databaseContext;
        private readonly LibrarianLoanUtility _librarianLoanUtility;
        public ManageLoans(LibraryDatabaseContext databaseContext)
        {
            InitializeComponent();
            _databaseContext = databaseContext;
            _librarianLoanUtility=new LibrarianLoanUtility(databaseContext);
        }

        private async void Button_Click(object sender, RoutedEventArgs e)
        {
            if (int.TryParse(TxtLoanIDUpdate.Text, out int loanId))
            {
                bool updated = await _librarianLoanUtility.UpdateLoanAsync(loanId);
                MessageBox.Show(updated ? "Loan updated successfully." : "Loan not found or already returned.");
            }
            else
            {
                MessageBox.Show("Invalid loan ID.");
            }
        }

        private async void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (int.TryParse(TxtLoanIDDelete.Text, out int loanId))
            {
                bool deleted = await _librarianLoanUtility.DeleteLoanAsync(loanId);
                MessageBox.Show(deleted ? "Loan deleted successfully." : "Loan not found.");
            }
            else
            {
                MessageBox.Show("Invalid loan ID.");
            }
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            LibrarianMainWindow librarianWindow = new LibrarianMainWindow(_databaseContext);
            librarianWindow.Show();
            this.Close();
        }
    }
}
