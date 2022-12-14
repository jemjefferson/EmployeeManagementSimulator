namespace EmployeeManagementSimulator
{
    /// <summary>
    /// This class represents a customer service representative.
    /// </summary>
    public class CustomerServiceRepresentative : Employee, IEmployee
    {
        /// <summary>
        /// Instantiates a new instance of the CustomerServiceRepresentative class.
        /// </summary>
        /// <param name="firstName">First name of employee.</param>
        /// <param name="lastName">Last name of employee.</param>
        /// <param name="jobTitle">Job of the employee.</param>
        /// <param name="age">Age of employee.</param>
        /// <param name="salary">Salary of employee.</param>
        public CustomerServiceRepresentative(string firstName, string lastName, Jobs jobTitle, int age, decimal salary)
            : base(firstName, lastName, jobTitle, age, salary)
        {
        }
    }
}
