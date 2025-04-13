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
    using System.Collections.ObjectModel; // Added missing namespace for ObservableCollection
    /// Interaction logic for Dashboard.xaml  
    /// </summary>  
    public partial class Dashboard : UserControl
    {
        public ObservableCollection<Expense> Expenses { get; set; } // Changed from List to ObservableCollection  

        public Dashboard()
        {
            InitializeComponent();
            Expenses = new ObservableCollection<Expense>(); // Corrected initialization  
        }
    }
}
