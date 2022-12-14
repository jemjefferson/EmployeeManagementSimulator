namespace EmployeeManagementSimulator
{
    /// <summary>
    /// This class represents an administrative assistant.
    /// </summary>
    public class AdministrativeAssistant : Employee, IEmployee, IObserver
    {
        /// <summary>
        /// Instantiates a new instance of the AdministrativeAssistant class.
        /// </summary>
        /// <param name="firstName">First name of employee.</param>
        /// <param name="lastName">Last name of employee.</param>
        /// <param name="jobTitle">Job of the employee.</param>
        /// <param name="age">Age of employee.</param>
        /// <param name="salary">Salary of employee.</param>
        public AdministrativeAssistant(string firstName, string lastName, Jobs jobTitle, int age, decimal salary)
            : base(firstName, lastName, jobTitle, age, salary)
        {
        }
    }
}
