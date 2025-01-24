using System.Windows;
using DataModel;
using CDB;

namespace CustomerManagementSystem.View
{
    public partial class NewCustomerWindow : Window
    {
        private Customer customer = new Customer();

        public NewCustomerWindow(MainWindow mainWindow)
        {
            this.Owner = mainWindow;
            InitializeComponent();
        }

        private void NewCustomerSaveButton_Click(object sender, RoutedEventArgs e)
        {
            string companyName = this.CompanyNameTextBox.Text;
            this.customer.CompanyName = companyName;
            this.Close();
        }

        private void NewCustomerCancelButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
