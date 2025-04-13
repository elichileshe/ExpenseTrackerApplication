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
using System.Collections.ObjectModel;
using System.Linq;


namespace ExpenseTrackerApplication.View.UserControls
{
    public partial class Expenses : UserControl
    {
        // ObservableCollection to hold the list of expenses
        public ObservableCollection<Expense> ExpenseList { get; set; }

        public Expenses()
        {
            InitializeComponent();
            AddButton.Click += AddButton_Click;

            // Initialize the ExpenseList and bind it to the DataGrid
            ExpenseList = new ObservableCollection<Expense>();
            ExpensesDataGrid.ItemsSource = ExpenseList;

            // Update the total expenses whenever the list changes
            ExpenseList.CollectionChanged += (s, e) => UpdateTotalExpenses();
        }

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            // Validate input fields
            if (string.IsNullOrWhiteSpace(DescriptionTextBox.Text) ||
                CategoryComboBox.SelectedItem == null ||
                !decimal.TryParse(AmountTextBox.Text, out decimal amount) ||
                DatePicker.SelectedDate == null)
            {
                MessageBox.Show("Please fill in all fields with valid data.", "Validation Error", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }

            // Check if an expense with the same description, category, amount, and date already exists
            var existingExpense = ExpenseList.FirstOrDefault(expense =>
                expense.Description.Equals(DescriptionTextBox.Text, StringComparison.OrdinalIgnoreCase) &&
                expense.Category == (CategoryComboBox.SelectedItem as ComboBoxItem)?.Content.ToString() &&
                expense.Amount == amount &&
                expense.Date == DatePicker.SelectedDate.Value);

            if (existingExpense != null)
            {
                MessageBox.Show("An expense with the same details already exists.", "Duplicate Entry", MessageBoxButton.OK, MessageBoxImage.Information);
                return;
            }

            // Add a new expense to the list
            ExpenseList.Add(new Expense
            {
                ExpenseID = Guid.NewGuid().ToString(),
                Description = DescriptionTextBox.Text,
                Category = (CategoryComboBox.SelectedItem as ComboBoxItem)?.Content.ToString(),
                Amount = amount,
                Date = DatePicker.SelectedDate.Value
            });

            // Clear input fields
            DescriptionTextBox.Clear();
            CategoryComboBox.SelectedIndex = -1;
            AmountTextBox.Clear();
            DatePicker.SelectedDate = null;
        }

        private void UpdateTotalExpenses()
        {
            // Calculate the total expenses and update the TextBlock
            var total = ExpenseList.Sum(expense => expense.Amount);
            TotalExpensesTextBlock.Text = $"${total:0.00}";
        }
    }

    // Updated the 'Category' property in the 'Expense' class to be nullable to address CS8618.
    public class Expense
    {
        public string ExpenseID { get; set; } = string.Empty; // Initialize with a default value to avoid CS8618
        public string Description { get; set; } = string.Empty; // Initialize with a default value to avoid CS8618
        public string? Category { get; set; } // Made nullable to avoid the non-nullable property error.
        public decimal Amount { get; set; }
        public DateTime Date { get; set; }
    }
}