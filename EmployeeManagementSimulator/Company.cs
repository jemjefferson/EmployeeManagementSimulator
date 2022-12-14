using System.Collections.Generic;

namespace EmployeeManagementSimulator
{
    /// <summary>
    /// This class represents the company that is reflected in the main window.
    /// </summary>
    public class Company
    {
        /// Factories that will create employees. This could have been done under one factory, however I wanted to show polymorphism at work.
        private IEmployeeFactory administrationFactory;
        private IEmployeeFactory financeFactory;
        private IEmployeeFactory humanResourcesFactory;
        private IEmployeeFactory operationsFactory;
        private IEmployeeFactory salesMarketingFactory;

        /// <summary>
        /// All list of all employees in the company.
        /// </summary>
        private List<Employee> allEmployees = new List<Employee>();

        /// <summary>
        /// Instantiates a new instance of the Company class.
        /// </summary>
        /// <param name="name">The name of the company.</param>
        public Company(string name)
        {
            // Creating the factories when the company is instantiated.
            this.administrationFactory = new AdministrationFactory();
            this.financeFactory = new FinanceFactory();
            this.humanResourcesFactory = new HumanResourcesFactory();
            this.operationsFactory = new OperationsFactory();
            this.salesMarketingFactory = new SalesMarketingFactory();
        }

        /// <summary>
        /// This method creates the company and populates with employees and messages. The employees are automatically clocked in and subscribed to receive department messages.
        /// </summary>
        public void CreateCompany()
        {
            // Creating administration employees
            AdministrationDepartment.GetInstance().AddEmployee(this.administrationFactory.CreateEmployee("Tricia", "Ramos", Jobs.AdministrativeAssistant, 23, 43500));
            AdministrationDepartment.GetInstance().AddEmployee(this.administrationFactory.CreateEmployee("Gregg", "Robles", Jobs.AdministrativeManager, 31, 76700));
            AdministrationDepartment.GetInstance().AddEmployee(this.administrationFactory.CreateEmployee("Barton", "McDonald", Jobs.DataEntryClerk, 21, 31000));
            // Creating finance employees
            FinanceDepartment.GetInstance().AddEmployee(this.financeFactory.CreateEmployee("Adrian", "Sosa", Jobs.Accountant, 29, 52600));
            FinanceDepartment.GetInstance().AddEmployee(this.financeFactory.CreateEmployee("Olen", "Hamilton", Jobs.PayrollClerk, 33, 41200));
            FinanceDepartment.GetInstance().AddEmployee(this.financeFactory.CreateEmployee("Mohammad", "Bradley", Jobs.PurchasingClerk, 36, 49800));
            // Creating human resources employees
            HumanResourcesDepartment.GetInstance().AddEmployee(this.humanResourcesFactory.CreateEmployee("Sophie", "Park", Jobs.HRManager, 53, 102000));
            HumanResourcesDepartment.GetInstance().AddEmployee(this.humanResourcesFactory.CreateEmployee("Maxine", "Carey", Jobs.HRRepresentative, 34, 63600));
            HumanResourcesDepartment.GetInstance().AddEmployee(this.humanResourcesFactory.CreateEmployee("Gary", "Lamont", Jobs.StaffCoordinator, 56, 39500));
            // Creating operations employees
            OperationsDepartment.GetInstance().AddEmployee(this.operationsFactory.CreateEmployee("Jordan", "Jefferson", Jobs.CEO, 23, 1000000));
            OperationsDepartment.GetInstance().AddEmployee(this.operationsFactory.CreateEmployee("Matthew", "Peterson", Jobs.CustomerServiceRepresentative, 29, 33000));
            OperationsDepartment.GetInstance().AddEmployee(this.operationsFactory.CreateEmployee("Bessie", "Watson", Jobs.GeneralManager, 30, 56000));
            // Creating sales/marketing employees
            SalesMarketingDepartment.GetInstance().AddEmployee(this.salesMarketingFactory.CreateEmployee("Cleo", "Huff", Jobs.MarketingManager, 28, 87000));
            SalesMarketingDepartment.GetInstance().AddEmployee(this.salesMarketingFactory.CreateEmployee("Marie", "Garza", Jobs.SalesAssistant, 22, 38000));
            SalesMarketingDepartment.GetInstance().AddEmployee(this.salesMarketingFactory.CreateEmployee("Travis", "Tracy", Jobs.SalesRepresentative, 25, 62100));

            // Clocking all employees in and subscribing them.
            foreach (IEmployee e in this.GetAllEmployees())
            {
                (e as Employee).IsActive = true;
                Department.AssignObserver(e as IObserver);
            }

            // Creating messages so the message list box is not empty.
            AdministrationDepartment.GetInstance().NotifyObservers("Good morning! Let's have a great day everyone!");
            FinanceDepartment.GetInstance().NotifyObservers("Quarterly spending meeting next Tuesday. See you there!");
            OperationsDepartment.GetInstance().NotifyObservers("Systems will be under maintenence. 5/30/22 (8:00PM - 11:00PM)");
            HumanResourcesDepartment.GetInstance().NotifyObservers("Hello, I just wanted to let everyone know that there were ZERO reports of work place harassment this month.");
            SalesMarketingDepartment.GetInstance().NotifyObservers("Sales continue to rise, great job team!");
        }

        /// <summary>
        ///  This method gets all the employees in the company and returns a list of them.
        /// </summary>
        /// <returns>A list of all employees in the comapny.</returns>
        public List<Employee> GetAllEmployees()
        {
            this.allEmployees.Clear();
            List<Employee> allEmployees = new List<Employee>();
            allEmployees.AddRange(AdministrationDepartment.GetInstance().GetEmployees());
            allEmployees.AddRange(FinanceDepartment.GetInstance().GetEmployees());
            allEmployees.AddRange(HumanResourcesDepartment.GetInstance().GetEmployees());
            allEmployees.AddRange(OperationsDepartment.GetInstance().GetEmployees());
            allEmployees.AddRange(SalesMarketingDepartment.GetInstance().GetEmployees());

            this.allEmployees = allEmployees;

            return this.allEmployees;
        }

        /// <summary>
        /// This method adds an employee to the list of employees and the department that they belong too.
        /// </summary>
        /// <param name="employee">The employee being added.</param>
        public void AddEmployee(Employee employee)
        {
            Department.AssignDepartment(employee);
            this.allEmployees.Add(employee);
        }

        /// <summary>
        /// This method removes an employee from the list of employees.
        /// </summary>
        /// <param name="employee">The employee being removed.</param>
        public void RemoveEmployee(Employee employee)
        {
            this.allEmployees.Remove(employee);
        }
    }
}
