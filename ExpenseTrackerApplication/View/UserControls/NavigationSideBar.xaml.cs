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
using ExpenseTrackerApplication.View.UserControls;

namespace ExpenseTrackerApplication.View.UserControls
{
    /// <summary>
    /// Interaction logic for NavigationSideBar.xaml
    /// </summary>
    public partial class NavigationSideBar : UserControl
    {
        public NavigationSideBar()
        {
            InitializeComponent();
            btnLogin.Click += BtnLogin_Click;
            btnSignup.Click += BtnSignup_Click;
           
        }

        private void BtnSignup_Click(object sender, RoutedEventArgs e)
        {
            var mainWindow = Window.GetWindow(this) as MainWindow;
            if (mainWindow != null)
            {
                mainWindow.LoadView(new SignupForm()); // Load the SignForm UserControl
            }
        }

        private void BtnLogin_Click(object sender, RoutedEventArgs e)
        {
            var mainWindow = Window.GetWindow(this) as MainWindow;
            if (mainWindow != null)
            {
                mainWindow.LoadView(new LoginForm()); // Load the LoginForm UserControl
            }
        }
        
    }
}