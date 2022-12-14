namespace EmployeeManagementSimulator
{
    /// <summary>
    /// This class represents an accountant.
    /// </summary>
    public class Accountant : Employee, IEmployee
    {
        /// <summary>
        /// Instantiates a new instance of the Accountant class.
        /// </summary>
        /// <param name="firstName">First name of employee.</param>
        /// <param name="lastName">Last name of employee.</param>
        /// <param name="jobTitle">Job of the employee.</param>
        /// <param name="age">Age of employee.</param>
        /// <param name="salary">Salary of employee.</param>
        public Accountant(string firstName, string lastName, Jobs jobTitle, int age, decimal salary)
            : base(firstName, lastName, jobTitle, age, salary)
        {
        }
    }
}
