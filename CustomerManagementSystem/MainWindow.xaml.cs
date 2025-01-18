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
using System.Windows.Navigation;
using System.Windows.Shapes;
using CustomerManagementSystem.Data;
using CustomerManagementSystem.View.UserControls;
using DataModel;

namespace CustomerManagementSystem
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public DataProvider DataProvider { get; set; }
        public List<Customer> Customers { get; set; }
        public bool Running { get; set; } = false;

        public MainWindow()
        {
            InitializeComponent();

            // Override the text value in the xaml markup.#
            /*
            this.tbStatus.Text = "Stopped";

            this.btnToggleRun.Content = "Run";
            this.DataProvider = new DataProvider();
            this.Customers = this.DataProvider.GetAllCustomers();
            */
        }

        private void btnToggleRun_Click(object sender, RoutedEventArgs e)
        {
            /*
            if (this.Running)
            {
                this.tbStatus.Text = "Stopped";
                this.btnToggleRun.Content = "Run";
                // this.Background = Control.BackgroundProperty.Col;
            }
            else
            {
                this.tbStatus.Text = "Running";
                this.btnToggleRun.Content = "Stop";
            }

            this.Running = !this.Running;
            */
        }
    }
}
