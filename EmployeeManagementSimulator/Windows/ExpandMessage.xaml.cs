using System.Windows;

namespace EmployeeManagementSimulator
{
    /// <summary>
    /// Interaction logic for ExpandMessage.xaml
    /// </summary>
    public partial class ExpandMessage : Window
    {
        /// <summary>
        /// This message being exapanded.
        /// </summary>
        private string message;

        /// <summary>
        /// Instantiates a new instance of the ExampandMessage class.
        /// </summary>
        /// <param name="message">The message that needs to be expanded.</param>
        public ExpandMessage(string message)
        {
            InitializeComponent();

            this.message = message;
            this.messageTextBox.Text = message;
        }
    }
}
