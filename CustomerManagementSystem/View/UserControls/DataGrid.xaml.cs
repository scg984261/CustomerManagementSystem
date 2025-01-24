using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
        public ObservableCollection<Customer> Customers { get; set; }

        public DataGrid()
        {
            InitializeComponent();
            List<Customer> customerList = this.DataProvider.GetAllCustomers();
            this.Customers = new ObservableCollection<Customer>(customerList);
        }

        public void Window_Loaded(object sender, EventArgs e)
        {
            this.CustomerTable.ItemsSource = this.Customers;
        }

        private void CustomerTable_RowEditEnding(object sender, DataGridRowEditEndingEventArgs rowEventArgs)
        {
            Customer customerToUpdate = (Customer) this.CustomerTable.SelectedValue;
            this.DataProvider.UpdateCustomer(customerToUpdate);
            // var datag = (DataGrid) sender;
            // var c = datag.;
        }
    }
}
