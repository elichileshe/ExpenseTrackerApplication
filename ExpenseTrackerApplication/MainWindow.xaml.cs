using ExpenseTrackerApplication.View.UserControls;
using System.Windows;
using System.Windows.Controls;

namespace ExpenseTrackerApplication;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    private MenuSideBar MenuSideBar;
    private NavigationSideBar NavigationSideBar;

    public MainWindow()
    {
        InitializeComponent();
        MenuSideBar = new MenuSideBar();
        NavigationSideBar = new NavigationSideBar();

        // Set the initial UserControl to be visible at app launch
        LoadNavigationSideBar(NavigationSideBar);
    }

    public void LoadView(UserControl view)
    {
        ContentArea.Content = view;
    }

    public void LoadMenuSideBar(UserControl view)
    {
        
        ContentArea1.Content = view;
        
    }
    public void LoadNavigationSideBar(UserControl view)
    {
        ContentArea1.Content = view;
    }
}
