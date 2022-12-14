using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace EmployeeManagementSimulator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        /// <summary>
        /// The company being instantiated.
        /// </summary>
        Company company;

        /// <summary>
        /// List of all employees in the company.
        /// </summary>
        List<Employee> allEmployees = new List<Employee>();

        public MainWindow()
        {
            InitializeComponent();

            this.company = new Company("Jordan's Company");
            this.company.CreateCompany();

            this.PopulateEmployees();

            this.jobTitleComboBox.ItemsSource = Enum.GetValues(typeof(Jobs));
            this.allEmployees = this.company.GetAllEmployees();
            this.UpdateDisplays();
        }

        /// <summary>
        /// This method allows for the functionality to edit employees in the company.
        /// </summary>
        private void EditEmployee()
        {
            if (this.employeeListBox.SelectedItem != null)
            {
                Employee employee = this.employeeListBox.SelectedItem as Employee;

                if (employee != null)
                {
                    AddEmployeeWindow employeeWindow = new AddEmployeeWindow(employee);
                    employeeWindow.ShowDialog();

                    this.UpdateDisplays();
                }
            }
            else if (this.employeeListBox.SelectedItem == null)
            {
                MessageBox.Show("Please select an employee to edit.");
            }
        }

        /// <summary>
        /// This method populates the employees in the employee list box in the main window.
        /// </summary>
        private void PopulateEmployees()
        {
            this.allEmployees = this.company.GetAllEmployees();
            this.employeeListBox.ItemsSource = null;

            foreach (IEmployee e in this.company.GetAllEmployees())
            {
                this.employeeListBox.Items.Add(e);
            }
        }

        /// <summary>
        /// This method refreshes the list boxes in the main window.
        /// </summary>
        private void UpdateDisplays()
        {
            this.employeeListBox.Items.Refresh();
            this.messageListBox.Items.Refresh();
        }

        // This method is the logic for the button that clocks an employee in.
        private void clockInButton_Click(object sender, RoutedEventArgs e)
        {
            Employee employee = this.employeeListBox.SelectedItem as Employee;

            if (employee != null && employee.IsActive == false)
            {
                employee.IsActive = true;
            }
            else if (employee == null)
            {
                MessageBox.Show("Select an employee to clock in.");
            }

            this.UpdateDisplays();
        }

        // This method is the logic for the button that clocks an employee out.
        private void clockOutButton_Click(object sender, RoutedEventArgs e)
        {
            Employee employee = this.employeeListBox.SelectedItem as Employee;

            if (employee != null && employee.IsActive == true)
            {
                employee.IsActive = false;
            }
            else if (employee == null)
            {
                MessageBox.Show("Select an employee to clock out.");
            }

            this.UpdateDisplays();
        }

        // This method is the logic for the button that adds an employee to the company.
        private void addEmployeeButton_Click(object sender, RoutedEventArgs e)
        {
            if (this.jobTitleComboBox.SelectedItem != null)
            {
                Jobs jobTitle = (Jobs)this.jobTitleComboBox.SelectedItem;

                Employee employee = new Employee("First Name", "Last Name", jobTitle, 30, 30000);

                AddEmployeeWindow employeeWindow = new AddEmployeeWindow(employee);
                employeeWindow.ShowDialog();

                if (employeeWindow.DialogResult == true)
                {
                    this.employeeListBox.Items.Add(employee);
                    this.company.AddEmployee(employee);
                }

                this.allEmployees = this.company.GetAllEmployees();
                this.UpdateDisplays();
            }
            else if (this.jobTitleComboBox.SelectedItem == null)
            {
                MessageBox.Show("Please select a job title before adding a new employee.");
            }
        }

        // This method is the logic for the button that removes an employee from the company.
        private void removeEmployeeButton_Click(object sender, RoutedEventArgs e)
        {
            Employee employee = this.employeeListBox.SelectedItem as Employee;

            if (employee != null)
            {
                if (MessageBox.Show(string.Format("Are you sure you want to remove employee: {0}?", employee.FirstName), "Confirmation", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
                {
                    this.employeeListBox.Items.Remove(employee);
                    this.company.RemoveEmployee(employee);
                }
            }
            else if (employee == null)
            {
                MessageBox.Show("Select an employee to remove.");
            }
        }

        // This method is the logic for the button the edits an employee in the company.
        private void editEmployeeButton_Click(object sender, RoutedEventArgs e)
        {
            this.EditEmployee();
        }

        // This method is the logic for when an employee in the employee list box is double clicked.
        private void employeeListBox_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            this.EditEmployee();
        }

        // This method is the logic for the button that creates a new message and opens the message window.
        private void newMessageButton_Click(object sender, RoutedEventArgs e)
        {
            string message = "Enter message...";
            Message messageWindow = new Message(message);
            messageWindow.ShowDialog();

            if (messageWindow.DialogResult == true)
            {
                this.UpdateDisplays();
            }
        }

        // This method is the logic for the button that deletes an employee's selected message.
        private void deleteMessageButton_Click(object sender, RoutedEventArgs e)
        {
            if (this.employeeListBox.SelectedItem != null && this.messageListBox.SelectedItem != null)
            {
                Employee employee = this.employeeListBox.SelectedItem as Employee;
                string message = this.messageListBox.SelectedItem as string;
                employee.MessageList.Remove(message);
                this.UpdateDisplays();
            }
            else
            {
                MessageBox.Show("Select both an employee and message in order to delete a message.");
            }
        }

        // This method is the logic that shows an employee's messages when the employee is selected.
        private void employeeListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            try
            {
                if (this.employeeListBox.SelectedItem != null)
                {
                    Employee employee = this.employeeListBox.SelectedItem as Employee;

                    if (employee != null)
                    {
                        this.messageListBox.ItemsSource = employee.MessageList;

                        this.UpdateDisplays();
                    }
                }
            }
            catch (NullReferenceException)
            {
            }
        }

        // This method is the logic for the button that subscribes an employee to receive department messages.
        private void subscribeEmployeeButton_Click(object sender, RoutedEventArgs e)
        {
            if (this.employeeListBox.SelectedItem != null)
            {
                IObserver o = this.employeeListBox.SelectedItem as IObserver;
                Department.AssignObserver(o);
                MessageBox.Show("Employee has been subscribed to their department.");
            }
            else
            {
                MessageBox.Show("Select an employee to subscribe.");
            }
        }

        // This method is the logic for the button that unsubscribes an employee from receiving department messages.
        private void unsubscribeEmployeeButton_Click(object sender, RoutedEventArgs e)
        {
            if (this.employeeListBox.SelectedItem != null)
            {
                IObserver o = this.employeeListBox.SelectedItem as IObserver;
                Department.RemoveObserver(o);
                MessageBox.Show("Employee has been unsubscribed from their department.");
            }
            else
            {
                MessageBox.Show("Select an employee to unsubscribe.");
            }
        }

        // This method is the logic for the button that unsubscribes all employees from receiving department messages.
        private void removeSubscribersButton_Click(object sender, RoutedEventArgs e)
        {
            for (int i = this.employeeListBox.Items.Count - 1; i >= 0; i--)
            {
                Department.RemoveObserver(this.employeeListBox.Items[i] as IObserver);
            }

            MessageBox.Show("All employeses have been unsubscribed from their departments.");
        }

        // This method is the logic for when a message is double clicked and the message is expanded in a new expand window.
        private void messageListBox_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            string message = this.messageListBox.SelectedItem as string;
            ExpandMessage expandWindow = new ExpandMessage(message);

            expandWindow.ShowDialog();
        }
    }
}
