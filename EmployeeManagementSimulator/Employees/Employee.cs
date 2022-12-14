using System.Collections.Generic;
using System.Windows;

namespace EmployeeManagementSimulator
{
    /// <summary>
    /// This class represents the abstract class that all employees will inherit from to define characteristics of each employee.
    /// </summary>
    public class Employee : IObserver
    {
        /// <summary>
        /// The employee's age.
        /// </summary>
        private int age;

        /// <summary>
        /// Shows if the employee is clocked in.
        /// </summary>
        private bool isActive;

        /// <summary>
        /// The employee's first name.
        /// </summary>
        private string firstName;

        /// <summary>
        /// This employee's job title.
        /// </summary>
        private Jobs jobTitle;

        /// <summary>
        /// The employee's last name.
        /// </summary>
        private string lastName;

        /// <summary>
        /// This employee's salaary.
        /// </summary>
        private decimal salary;

        /// <summary>
        /// List of employee's messages.
        /// </summary>
        private List<string> messageList = new List<string>();

        /// <summary>
        /// Instantiates an instance of the Employee class.
        /// </summary>
        /// <param name="firstName">Employee's first name.</param>
        /// <param name="lastName">Employee's last name.</param>
        /// <param name="jobTitle">Title of employee's job.</param>
        /// <param name="age">Employee's age.</param>
        /// <param name="salary">Employee's salary.</param>
        public Employee(string firstName, string lastName, Jobs jobTitle, int age, decimal salary)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.jobTitle = jobTitle;
            this.age = age;
            this.salary = salary;
            this.isActive = false;
        }

        /// <summary>
        /// Gets or sets the employee's age.
        /// </summary>
        public int Age
        {
            get
            {
                return this.age;
            }
            set
            {
                if (value >= 18 && value < 80)
                {
                    this.age = value;
                }
                else
                {
                    MessageBox.Show("Please choose an age between 18 and 80.");
                }
            }
        }

        /// <summary>
        /// Gets or sets the employee's IsActive status.
        /// </summary>
        public bool IsActive
        {
            get
            {
                return this.isActive;
            }
            set
            {
                this.isActive = value;
            }
        }


        /// <summary>
        /// Gets or sets the employee's first name.
        /// </summary>
        public string FirstName
        {
            get
            {
                return this.firstName;
            }
            set
            {
                this.firstName = value;
            }
        }

        /// <summary>
        /// Gets or sets the employee's job title.
        /// </summary>
        public Jobs JobTitle
        {
            get
            {
                return this.jobTitle;
            }
        }

        /// <summary>
        /// Gets or sets the employee's last name.
        /// </summary>
        public string LastName
        {
            get
            {
                return this.lastName;
            }
            set
            {
                this.lastName = value;
            }
        }

        /// <summary>
        /// Gets the employees list of messages.
        /// </summary>
        public List<string> MessageList
        {
            get
            {
                return this.messageList;
            }
        }
       
        /// <summary>
        /// Gets or sets the employee's salaary.
        /// </summary>
        public decimal Salary
        {
            get
            {
                return this.salary;
            }
            set
            {
                this.salary = value;
            }
        }

        /// <summary>
        /// Generates a string representation of the employee.
        /// </summary>
        /// <returns>A string representation of the employee.</returns>
        public override string ToString()
        {
            string employeeString = this.FirstName + " " + this.LastName + ": " + this.JobTitle;

            employeeString = (this.IsActive == true) ? employeeString + " (✓)" : employeeString + " (X)";
            return employeeString;
        }

        /// <summary>
        /// This method adds a message to the employee's message list.
        /// </summary>
        /// <param name="message">Message being added.</param>
        public void Update(string message)
        {
            this.messageList.Add(message);
        }
    }
}
