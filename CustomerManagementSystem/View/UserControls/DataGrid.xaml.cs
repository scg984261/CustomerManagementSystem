using System;
using System.Collections.Generic;
using System.Windows.Controls;
using CustomerManagementSystem.Data;
using DataModel;

namespace CustomerManagementSystem.View.UserControls
{
    /// <summary>
    /// Interaction logic for DataGrid.xaml
    /// </summary>
    public partial class DataGrid : UserControl
    {
        public DataProvider DataProvider { get; set; } = new DataProvider();
        public List<Customer> Customers { get; set; }

        public DataGrid()
        {
            InitializeComponent();
            this.Customers = this.DataProvider.GetAllCustomers();
        }

        public void Window_Loaded(object sender, EventArgs e)
        {
            this.CustomerTable.ItemsSource = this.Customers;
        }

        private void CustomerTable_RowEditEnding(object sender, DataGridRowEditEndingEventArgs rowEventArgs)
        {
            Customer customerToUpdate = (Customer) this.CustomerTable.SelectedItem;
            this.DataProvider.UpdateCustomer(customerToUpdate);
        }
    }
}
