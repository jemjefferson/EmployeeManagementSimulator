using System.Collections.Generic;

namespace EmployeeManagementSimulator
{
    /// <summary>
    /// This interface represents the common interface for departments.
    /// </summary>
    public interface IDepartment
    {
        /// <summary>
        /// Add employee to department.
        /// </summary>
        /// <param name="employee">The employee being added.</param>
        void AddEmployee(Employee employee);

        /// <summary>
        /// Removes employee from department.
        /// </summary>
        /// <param name="employee">The employee being removed.</param>
        void RemoveEmployee(Employee employee);

        /// <summary>
        /// Gets all employees in department.
        /// </summary>
        /// <returns>List of employees in department.</returns>
        List<Employee> GetEmployees();
    }
}
