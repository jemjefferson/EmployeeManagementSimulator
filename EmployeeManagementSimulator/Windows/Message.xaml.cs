using System;
using System.Windows;

namespace EmployeeManagementSimulator
{
    /// <summary>
    /// Interaction logic for Message.xaml
    /// </summary>
    public partial class Message : Window
    {
        /// <summary>
        /// This message being added.
        /// </summary>
        private string message;

        /// <summary>
        /// Instantiates a new instance of the Message class.
        /// </summary>
        /// <param name="message">The message being added.</param>
        public Message(string message)
        {
            InitializeComponent();

            this.message = message;
            this.departmentComboBox.ItemsSource = Enum.GetValues(typeof(DepartmentTypes));
            this.messageTextBox.Text = message;
        }

        // This method is the logic for when the send button is clicked.
        private void sendButton_Click(object sender, RoutedEventArgs e)
        {
            this.message = this.messageTextBox.Text;

            if (this.departmentComboBox.SelectedItem == null)
            {
                MessageBox.Show("Please select a department.");
            }
            else
            {
                if (this.departmentComboBox.SelectedItem.ToString() == "Administration")
                {
                    AdministrationDepartment.GetInstance().NotifyObservers(this.message);
                }
                else if (this.departmentComboBox.SelectedItem.ToString() == "Finance")
                {
                    FinanceDepartment.GetInstance().NotifyObservers(this.message);
                }
                else if (this.departmentComboBox.SelectedItem.ToString() == "HumanResources")
                {
                    HumanResourcesDepartment.GetInstance().NotifyObservers(this.message);
                }
                else if (this.departmentComboBox.SelectedItem.ToString() == "Operations")
                {
                    OperationsDepartment.GetInstance().NotifyObservers(this.message);
                }
                else if (this.departmentComboBox.SelectedItem.ToString() == "SalesMarketing")
                {
                    SalesMarketingDepartment.GetInstance().NotifyObservers(this.message);
                }

                this.DialogResult = true;
            }
        }
    }
}
