namespace EmployeeManagementSimulator
{
    /// <summary>
    /// This class represents a staff coordinator.
    /// </summary>
    public class StaffCoordinator : Employee, IEmployee
    {
        /// <summary>
        /// Instantiates a new instance of the StaffCoordinator class.
        /// </summary>
        /// <param name="firstName">First name of employee.</param>
        /// <param name="lastName">Last name of employee.</param>
        /// <param name="jobTitle">Job of the employee.</param>
        /// <param name="age">Age of employee.</param>
        /// <param name="salary">Salary of employee.</param>
        public StaffCoordinator(string firstName, string lastName, Jobs jobTitle, int age, decimal salary)
            : base(firstName, lastName, jobTitle, age, salary)
        {
        }
    }
}
