using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;
using Microsoft.Win32;

namespace CustomerManagementSystem.View.UserControls
{
    /// <summary>
    /// Interaction logic for MenuBar.xaml
    /// </summary>
    public partial class MenuBar : UserControl
    {
        private MainWindow mainWindow = Application.Current.MainWindow as MainWindow;

        public MenuBar()
        {
            InitializeComponent();
        }

        private void OpenMenuItem_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.InitialDirectory = @"C:\Users\Downloads";
            bool? fileSelected = dialog.ShowDialog();

            if (fileSelected == true)
            {
                string filePath = dialog.FileName;
                ProcessStartInfo startInfo = new ProcessStartInfo();
                startInfo.FileName = filePath;
                Process.Start(startInfo);
            }            
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            

            MessageBoxResult result = MessageBox.Show("Are you sure you want to close?", "Close", MessageBoxButton.YesNo, MessageBoxImage.Question, MessageBoxResult.No);

            if (result == MessageBoxResult.Yes)
            {
                Application.Current.Shutdown();
            }
        }

        private void NewCustomerButton_Click(object sender, RoutedEventArgs e)
        {
            this.mainWindow.Opacity = 0.7;
            // this.MainWindow

            TabItem newTabItem = new TabItem
            {
                Header = "New tab",
                Name = "Test"
            };

            this.mainWindow.TabCollection.Items.Add(newTabItem);

            NewCustomerWindow customerWindow = new NewCustomerWindow(this.mainWindow);
            customerWindow.ShowDialog();

            this.mainWindow.Opacity = 1.0;
        }
    }
}
