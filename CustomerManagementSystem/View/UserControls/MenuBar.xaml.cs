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
    }
}
