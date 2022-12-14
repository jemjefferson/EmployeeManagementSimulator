using System.Windows;

namespace EmployeeManagementSimulator
{
    /// <summary>
    /// Interaction logic for AddEmployeeWindow.xaml
    /// </summary>
    public partial class AddEmployeeWindow : Window
    {
        /// <summary>
        /// Employee object in the window.
        /// </summary>
        Employee employee;

        /// <summary>
        /// Instantiates a new instance of the AddEmployeeWindow class.
        /// </summary>
        /// <param name="employee">Employee being edited/added.</param>
        public AddEmployeeWindow(Employee employee)
        {
            this.employee = employee;
            InitializeComponent();
        }

        // Sets the textboxes when the window is loaded.
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            int age;
            int.TryParse(this.ageTextBox.Text, out age);
            decimal salary;
            decimal.TryParse(this.salaryTextBox.Text, out salary);
            this.firstNameTextBox.Text = this.employee.FirstName;
            this.lastNameTextBox.Text = this.employee.LastName;
            age = this.employee.Age;
            this.jobLabelTextBox.Text = employee.JobTitle.ToString();
            salary = this.employee.Salary;
            this.ageTextBox.Text = age.ToString();
            this.salaryTextBox.Text = "$" + salary.ToString();

        }

        // Logic when the confirm button is clicked.
        private void confirmButton_Click(object sender, RoutedEventArgs e)
        {
            this.DialogResult = true;
        }

        // Sets the firstname text box as the user input when clicked away from.
        private void firstNameTextBox_LostFocus(object sender, RoutedEventArgs e)
        {
            this.employee.FirstName = this.firstNameTextBox.Text;
        }

        // Sets the lastname text box as the user input when clicked away from.
        private void lastNameTextBox_LostFocus(object sender, RoutedEventArgs e)
        {
            this.employee.LastName = this.lastNameTextBox.Text;
        }

        // Sets the age text box as the user input when clicked away from.
        private void ageTextBox_LostFocus(object sender, RoutedEventArgs e)
        {
            this.employee.Age = int.Parse(this.ageTextBox.Text);
        }

        // Sets the salary text box as the user input when clicked away from.
        private void salaryTextBox_LostFocus(object sender, RoutedEventArgs e)
        {
            decimal salary;
            decimal.TryParse(this.salaryTextBox.Text, out salary);
            this.employee.Salary = salary;
        }
    }
}
