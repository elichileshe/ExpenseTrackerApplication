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

namespace ExpenseTrackerApplication.View.UserControls
{
    /// <summary>
    /// Interaction logic for MenuSideBar.xaml
    /// </summary>
    public partial class MenuSideBar : UserControl
    {
        public MenuSideBar()
        {
            InitializeComponent();
            btnLogout.Click += BtnLogout_Click;
            btnDashboard.Click += BtnDashboard_Click;
            btnExpenses.Click += BtnExpenses_Click;
            btnManager.Click += BtnManager_Click;
            btnReports.Click += BtnReports_Click;
        }
        private void BtnLogout_Click(object sender, RoutedEventArgs e)
        {
            var mainWindow = Window.GetWindow(this) as MainWindow;
            if (mainWindow != null)
            {
                mainWindow.LoadView(new LoginForm()); // Load the LoginForm UserControl
                mainWindow.LoadNavigationSideBar(new NavigationSideBar()); // Load the NavigationSideBar UserControl
            }

        }
        private void BtnDashboard_Click(object sender, RoutedEventArgs e)
        {
            var mainWindow = Window.GetWindow(this) as MainWindow;
            if (mainWindow != null)
            {
                mainWindow.LoadView(new Dashboard()); // Load the Dashboard UserControl
            }
        }
        private void BtnExpenses_Click(object sender, RoutedEventArgs e)
        {
            var mainWindow = Window.GetWindow(this) as MainWindow;
            if (mainWindow != null)
            {
                mainWindow.LoadView(new Expenses()); // Load the Expenses UserControl
            }
        }
        private void BtnManager_Click(object sender, RoutedEventArgs e)
        {
            var mainWindow = Window.GetWindow(this) as MainWindow;
            if (mainWindow != null)
            {
                mainWindow.LoadView(new Manager()); // Load the Manager UserControl
            }
        }
        private void BtnReports_Click(object sender, RoutedEventArgs e)
        {
            var mainWindow = Window.GetWindow(this) as MainWindow;
            if (mainWindow != null)
            {
                mainWindow.LoadView(new Reports()); // Load the Reports UserControl
            }
        }
      
    }

}
