using System.Collections.Generic;

namespace EmployeeManagementSimulator
{
    /// <summary>
    /// This class represents the human resources department of the company.
    /// </summary>
    public class HumanResourcesDepartment : IDepartment, ISubject
    {
        /// <summary>
        /// Instance of the class.
        /// </summary>
        private static HumanResourcesDepartment instance;

        /// <summary>
        /// List of employees in the department.
        /// </summary>
        private List<Employee> employees;

        /// <summary>
        /// List of employees that are subscribed to the department.
        /// </summary>
        private List<IObserver> observers = new List<IObserver>();

        /// <summary>
        /// Instantiates a new instance of the HumanResources department.
        /// </summary>
        private HumanResourcesDepartment()
        {
            this.employees = new List<Employee>();
        }

        // This method gets the single instance of this department.
        public static HumanResourcesDepartment GetInstance()
        {
            if (instance == null)
            {
                instance = new HumanResourcesDepartment();
            }
            return instance;
        }

        /// <summary>
        /// This method adds an employee to this department.
        /// </summary>
        /// <param name="e">Employee being added.</param>
        public void AddEmployee(Employee e)
        {
            this.employees.Add(e);
        }

        /// <summary>
        /// This method removes an emoployee from this department.
        /// </summary>
        /// <param name="employee">The employee being removed.</param>
        public void RemoveEmployee(Employee e)
        {
            this.employees.Remove(e);
        }

        /// <summary>
        /// This method gets all of the employees in this department from the list of employees.
        /// </summary>
        /// <returns>The list of all employees in the department.</returns>
        public List<Employee> GetEmployees()
        {
            return this.employees;
        }

        /// <summary>
        /// This method registers an observer to this department.
        /// </summary>
        /// <param name="o">The observer being registered.</param>
        public void RegisterObserver(IObserver o)
        {
            this.observers.Add(o);
        }

        /// <summary>
        /// This method unregisters an observer to this department.
        /// </summary>
        /// <param name="o">The observer being unregistered</The>/param>
        public void RemoveObserver(IObserver o)
        {
            this.observers.Remove(o);
        }

        /// <summary>
        /// This method notifies all observers of this department when a new message is sent.
        /// </summary>
        /// <param name="message"></param>
        public void NotifyObservers(string message)
        {
            foreach (IObserver o in this.observers)
            {
                (o as Employee).Update(message);
            }
        }
    }
}
