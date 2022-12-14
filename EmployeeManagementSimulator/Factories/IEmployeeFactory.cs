namespace EmployeeManagementSimulator
{
    /// <summary>
    /// This interface represents the factory that will make all employees.
    /// </summary>
    public interface IEmployeeFactory
    {
        Employee CreateEmployee(string firstName, string lastName, Jobs jobTitle, int age, decimal salary);
    }
}
