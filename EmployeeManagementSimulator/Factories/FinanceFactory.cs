using System.Windows;

namespace EmployeeManagementSimulator
{
    /// <summary>
    /// This class is responsible for creating finance employees.
    /// </summary>
    public class FinanceFactory : IEmployeeFactory
    {
        /// <summary>
        /// Creates finance employees.
        /// </summary>
        /// <param name="firstName">First name of employee</param>
        /// <param name="lastName">Last name of employee</param>
        /// <param name="jobTitle">Job title of employee</param>
        /// <param name="age">Age of employee</param>
        /// <param name="salary">Salary of employee</param>
        /// <returns>Created finance employee</returns>
        public Employee CreateEmployee(string firstName, string lastName, Jobs jobTitle, int age, decimal salary)
        {
            Employee employee = null;

            switch (jobTitle)
            {
                case Jobs.Accountant:
                    return new Accountant(firstName, lastName, jobTitle, age, salary);
                case Jobs.PayrollClerk:
                    return new PayrollClerk(firstName, lastName, jobTitle, age, salary);
                case Jobs.PurchasingClerk:
                    return new PurchasingClerk(firstName, lastName, jobTitle, age, salary);
                default:
                    MessageBox.Show("Job Title that was entered is not valid.");
                    return employee;
            }
        }
    }
}
