using System.Windows;

namespace EmployeeManagementSimulator
{
    /// <summary>
    /// This class is responsible for creating human resources employees.
    /// </summary>
    public class HumanResourcesFactory : IEmployeeFactory
    {
        /// <summary>
        /// Creates human resources employees.
        /// </summary>
        /// <param name="firstName">First name of employee</param>
        /// <param name="lastName">Last name of employee</param>
        /// <param name="jobTitle">Job title of employee</param>
        /// <param name="age">Age of employee</param>
        /// <param name="salary">Salary of employee</param>
        /// <returns>Created human resources employee</returns>
        public Employee CreateEmployee(string firstName, string lastName, Jobs jobTitle, int age, decimal salary)
        {
            Employee employee = null;

            switch (jobTitle)
            {
                case Jobs.HRManager:
                    return new HRManager(firstName, lastName, jobTitle, age, salary);
                case Jobs.HRRepresentative:
                    return new HRRepresentative(firstName, lastName, jobTitle, age, salary);
                case Jobs.StaffCoordinator:
                    return new StaffCoordinator(firstName, lastName, jobTitle, age, salary);
                default:
                    MessageBox.Show("Job Title that was entered is not valid.");
                    return employee;
            }
        }
    }
}
