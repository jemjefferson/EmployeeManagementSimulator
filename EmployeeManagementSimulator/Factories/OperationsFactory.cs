using System.Windows;

namespace EmployeeManagementSimulator
{
    /// <summary>
    /// This class is responsible for creating operations employees.
    /// </summary>
    public class OperationsFactory : IEmployeeFactory
    {
        /// <summary>
        /// Creates operations employees.
        /// </summary>
        /// <param name="firstName">First name of employee</param>
        /// <param name="lastName">Last name of employee</param>
        /// <param name="jobTitle">Job title of employee</param>
        /// <param name="age">Age of employee</param>
        /// <param name="salary">Salary of employee</param>
        /// <returns>Created operations employee</returns>
        public Employee CreateEmployee(string firstName, string lastName, Jobs jobTitle, int age, decimal salary)
        {
            Employee employee = null;

            switch (jobTitle)
            {
                case Jobs.CEO:
                    return new CEO(firstName, lastName, jobTitle, age, salary);
                case Jobs.CustomerServiceRepresentative:
                    return new CustomerServiceRepresentative(firstName, lastName, jobTitle, age, salary);
                case Jobs.GeneralManager:
                    return new GeneralManager(firstName, lastName, jobTitle, age, salary);
                default:
                    MessageBox.Show("Job Title that was entered is not valid.");
                    return employee;
            }
        }
    }
}
