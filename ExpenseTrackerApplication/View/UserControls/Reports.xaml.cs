using System;
using System.Windows;
using System.Windows.Controls;

namespace ExpenseTrackerApplication.View.UserControls
{
    public partial class Reports : UserControl
    {
        public Reports()
        {
            InitializeComponent();
            GenerateReportButton.Click += GenerateReportButton_Click;
        }

        private void GenerateReportButton_Click(object sender, RoutedEventArgs e)
        {
            // Retrieve selected dates and category
            DateTime? startDate = StartDatePicker.SelectedDate;
            DateTime? endDate = EndDatePicker.SelectedDate;
            string selectedCategory = (CategoryComboBox.SelectedItem as ComboBoxItem)?.Content.ToString();

            // Validate inputs
            if (startDate == null || endDate == null || startDate > endDate)
            {
                MessageBox.Show("Please select valid start and end dates.", "Invalid Input", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }

            // Generate a mock report (replace with actual logic)
            string report = $"Report from {startDate:MM/dd/yyyy} to {endDate:MM/dd/yyyy} for category: {selectedCategory ?? "All"}.\n\n" +
                            "This is a placeholder for the actual report data.";

            // Display the report
            ReportView.Text = report;
        }

        private void DownloadReportButton_Click(object sender, RoutedEventArgs e)
        {
            // Retrieve the generated report
            string report = ReportView.Text;

            if (string.IsNullOrWhiteSpace(report) || report == "No report generated yet.")
            {
                MessageBox.Show("No report available to download.", "Download Error", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }

            // Save the report to a file (replace with actual file-saving logic)
            Microsoft.Win32.SaveFileDialog saveFileDialog = new Microsoft.Win32.SaveFileDialog
            {
                FileName = "ExpenseReport",
                DefaultExt = ".txt",
                Filter = "Text documents (.txt)|*.txt"
            };

            if (saveFileDialog.ShowDialog() == true)
            {
                System.IO.File.WriteAllText(saveFileDialog.FileName, report);
                MessageBox.Show("Report downloaded successfully.", "Download Complete", MessageBoxButton.OK, MessageBoxImage.Information);
            }
        }
    }
}
