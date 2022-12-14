namespace EmployeeManagementSimulator
{
    /// <summary>
    /// This class represents a sales representative.
    /// </summary>
    public class SalesRepresentative : Employee, IEmployee
    {
        /// <summary>
        /// Instantiates a new instance of the SalesRepresentative class.
        /// </summary>
        /// <param name="firstName">First name of employee.</param>
        /// <param name="lastName">Last name of employee.</param>
        /// <param name="jobTitle">Job of the employee.</param>
        /// <param name="age">Age of employee.</param>
        /// <param name="salary">Salary of employee.</param>
        public SalesRepresentative(string firstName, string lastName, Jobs jobTitle, int age, decimal salary)
            : base(firstName, lastName, jobTitle, age, salary)
        {
        }
    }
}
