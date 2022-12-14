namespace EmployeeManagementSimulator
{
    /// <summary>
    /// This class represents a HR manager.
    /// </summary>
    public class HRManager : Employee, IEmployee
    {
        /// <summary>
        /// Instantiates a new instance of the HRManager class.
        /// </summary>
        /// <param name="firstName">First name of employee.</param>
        /// <param name="lastName">Last name of employee.</param>
        /// <param name="jobTitle">Job of the employee.</param>
        /// <param name="age">Age of employee.</param>
        /// <param name="salary">Salary of employee.</param>
        public HRManager(string firstName, string lastName, Jobs jobTitle, int age, decimal salary)
            : base(firstName, lastName, jobTitle, age, salary)
        {
        }
    }
}
