using System;
using System.Reflection;
using System.Windows.Controls;

namespace CustomerManagementSystem.View.UserControls
{
    /// <summary>
    /// Interaction logic for FooterBar.xaml
    /// </summary>
    public partial class FooterBar : UserControl
    {
        public string MachineName
        { 
            get
            {
                return Environment.MachineName;
            }
        }

        public string VersionNumber
        {
            get
            {
                return Assembly.GetAssembly(this.GetType()).GetName().Version.ToString();
            }
        }

        public FooterBar()
        {
            InitializeComponent();
            DataContext = this;
        }
    }
}
