using System.Windows;

namespace EmployeeManagementSimulator
{
    /// <summary>
    /// This class is responsible for creating administration employees.
    /// </summary>
    public class AdministrationFactory : IEmployeeFactory
    {
        /// <summary>
        /// Creates administration employees.
        /// </summary>
        /// <param name="firstName">First name of employee</param>
        /// <param name="lastName">Last name of employee</param>
        /// <param name="jobTitle">Job title of employee</param>
        /// <param name="age">Age of employee</param>
        /// <param name="salary">Salary of employee</param>
        /// <returns>Created administration employee</returns>
        public Employee CreateEmployee(string firstName, string lastName, Jobs jobTitle, int age, decimal salary)
        {
            Employee employee = null;

            switch (jobTitle)
            {
                case Jobs.AdministrativeAssistant:
                     return new AdministrativeAssistant(firstName, lastName, jobTitle, age, salary);
                case Jobs.AdministrativeManager:
                    return new AdministrativeManager(firstName, lastName, jobTitle, age, salary);
                case Jobs.DataEntryClerk:
                    return new DataEntryClerk(firstName, lastName, jobTitle, age, salary);
                default:
                    MessageBox.Show("Job Title that was entered is not valid.");
                    return employee;
            }
        }
    }
}
