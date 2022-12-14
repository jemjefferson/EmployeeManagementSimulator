using System.Windows;

namespace EmployeeManagementSimulator
{
    /// <summary>
    /// This class is responsible for making sales/marketing employees.
    /// </summary>
    public class SalesMarketingFactory : IEmployeeFactory
    {
        /// <summary>
        /// Creates sales/marketing employees.
        /// </summary>
        /// <param name="firstName">First name of employee</param>
        /// <param name="lastName">Last name of employee</param>
        /// <param name="jobTitle">Job title of employee</param>
        /// <param name="age">Age of employee</param>
        /// <param name="salary">Salary of employee</param>
        /// <returns>Created sales/marketing employee</returns>
        public Employee CreateEmployee(string firstName, string lastName, Jobs jobTitle, int age, decimal salary)
        {
            Employee employee = null;

            switch (jobTitle)
            {
                case Jobs.MarketingManager:
                    return new MarketingManager(firstName, lastName, jobTitle, age, salary);
                case Jobs.SalesAssistant:
                    return new SalesAssistant(firstName, lastName, jobTitle, age, salary);
                case Jobs.SalesRepresentative:
                    return new SalesRepresentative(firstName, lastName, jobTitle, age, salary);
                default:
                    MessageBox.Show("Job Title that was entered is not valid.");
                    return employee;
            }
        }
    }
}
