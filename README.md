## WPF Expense Tracker

A desktop application built with WPF (.NET) for tracking personal expenses. The app provides a simple and elegant interface for adding, editing, viewing, and deleting expense entries. All data is stored in an XML file (`Expenses.xml`), making it lightweight and portable.

## Features

- **Add Expenses**: Capture item name, description, category, amount, and date.
- **View Expenses**: Automatically load and display expenses in a table/grid.
- **Edit Expenses**: Modify entries directly from the grid.
- **Delete Expenses**: Remove selected expenses.
- **Persistent Storage**: Expenses are saved to and loaded from an XML file.
- **Total Expense Calculation**: Display real-time total amount.
- **User Controls**:
  - `Expenses`: Main entry point for adding expenses.
  - `Manager`: A management interface for editing and deleting expenses.


## Getting Started

### Prerequisites
- [.NET Desktop Runtime](https://dotnet.microsoft.com/en-us/download/dotnet)
- Windows OS
- Visual Studio (or any C#-capable IDE)

### Installation

1. Clone the repository:
   ```bash
   git clone https://github.com/yourusername/expense-tracker-wpf.git