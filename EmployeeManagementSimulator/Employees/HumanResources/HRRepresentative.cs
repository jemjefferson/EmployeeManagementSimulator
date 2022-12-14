namespace EmployeeManagementSimulator
{
    /// <summary>
    /// This class representas a HR representative
    /// </summary>
    public class HRRepresentative : Employee, IEmployee
    {
        /// <summary>
        /// Instantiates a new instance of the HRRepresentative class.
        /// </summary>
        /// <param name="firstName">First name of employee.</param>
        /// <param name="lastName">Last name of employee.</param>
        /// <param name="jobTitle">Job of the employee.</param>
        /// <param name="age">Age of employee.</param>
        /// <param name="salary">Salary of employee.</param>
        public HRRepresentative(string firstName, string lastName, Jobs jobTitle, int age, decimal salary)
            : base(firstName, lastName, jobTitle, age, salary)
        {
        }
    }
}
