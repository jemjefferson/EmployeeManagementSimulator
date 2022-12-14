namespace EmployeeManagementSimulator
{
    /// <summary>
    /// This class represents the parent class of the departments of the company.
    /// </summary>
    public abstract class Department
    {
        /// <summary>
        /// This method assignment an employee to their respective department based on their job.
        /// </summary>
        /// <param name="e">The employee being assigned.</param>
        public static void AssignDepartment(Employee e)
        {
            if (e.JobTitle == Jobs.AdministrativeAssistant|| e.JobTitle == Jobs.AdministrativeManager || e.JobTitle == Jobs.DataEntryClerk)
            {
                AdministrationDepartment.GetInstance().AddEmployee(e);
            }
            else if (e.JobTitle == Jobs.Accountant || e.JobTitle == Jobs.PayrollClerk || e.JobTitle == Jobs.PurchasingClerk)
            {
                FinanceDepartment.GetInstance().AddEmployee(e);
            }
            else if (e.JobTitle == Jobs.HRManager || e.JobTitle == Jobs.HRRepresentative || e.JobTitle == Jobs.StaffCoordinator)
            {
                HumanResourcesDepartment.GetInstance().AddEmployee(e);
            }
            else if (e.JobTitle == Jobs.CEO || e.JobTitle == Jobs.CustomerServiceRepresentative || e.JobTitle == Jobs.GeneralManager)
            {
                OperationsDepartment.GetInstance().AddEmployee(e);
            }
            else if (e.JobTitle == Jobs.MarketingManager || e.JobTitle == Jobs.SalesAssistant|| e.JobTitle == Jobs.SalesRepresentative)
            {
                SalesMarketingDepartment.GetInstance().AddEmployee(e);
            }
        }

        /// <summary>
        /// This method finds which department an employee needs to be subscribed to and subscribes the employee to that department.
        /// </summary>
        /// <param name="o">The observer being subscribed.</param>
        public static void AssignObserver(IObserver o)
        {
            if ((o as Employee).JobTitle == Jobs.AdministrativeAssistant || (o as Employee).JobTitle == Jobs.AdministrativeManager || (o as Employee).JobTitle == Jobs.DataEntryClerk)
            {
                AdministrationDepartment.GetInstance().RegisterObserver(o);
            }
            if ((o as Employee).JobTitle == Jobs.Accountant || (o as Employee).JobTitle == Jobs.PayrollClerk || (o as Employee).JobTitle == Jobs.PurchasingClerk)
            {
                FinanceDepartment.GetInstance().RegisterObserver(o);
            }
            if ((o as Employee).JobTitle == Jobs.HRManager || (o as Employee).JobTitle == Jobs.HRRepresentative || (o as Employee).JobTitle == Jobs.StaffCoordinator)
            {
                HumanResourcesDepartment.GetInstance().RegisterObserver(o);
            }
            if ((o as Employee).JobTitle == Jobs.CEO || (o as Employee).JobTitle == Jobs.CustomerServiceRepresentative || (o as Employee).JobTitle == Jobs.GeneralManager)
            {
                OperationsDepartment.GetInstance().RegisterObserver(o);
            }
            if ((o as Employee).JobTitle == Jobs.MarketingManager || (o as Employee).JobTitle == Jobs.SalesAssistant || (o as Employee).JobTitle == Jobs.SalesRepresentative)
            {
                SalesMarketingDepartment.GetInstance().RegisterObserver(o);
            }
        }

        /// <summary>
        /// This method finds which department an employee needs to be unsubscribed from and unsubscribes the employee from that department.
        /// </summary>
        /// <param name="o">The observer being unsubscribed.</param>
        public static void RemoveObserver(IObserver o)
        {
            if ((o as Employee).JobTitle == Jobs.AdministrativeAssistant || (o as Employee).JobTitle == Jobs.AdministrativeManager || (o as Employee).JobTitle == Jobs.DataEntryClerk)
            {
                AdministrationDepartment.GetInstance().RemoveObserver(o);
            }
            if ((o as Employee).JobTitle == Jobs.Accountant || (o as Employee).JobTitle == Jobs.PayrollClerk || (o as Employee).JobTitle == Jobs.PurchasingClerk)
            {
                FinanceDepartment.GetInstance().RemoveObserver(o);
            }
            if ((o as Employee).JobTitle == Jobs.HRManager || (o as Employee).JobTitle == Jobs.HRRepresentative || (o as Employee).JobTitle == Jobs.StaffCoordinator)
            {
                HumanResourcesDepartment.GetInstance().RemoveObserver(o);
            }
            if ((o as Employee).JobTitle == Jobs.CEO || (o as Employee).JobTitle == Jobs.CustomerServiceRepresentative || (o as Employee).JobTitle == Jobs.GeneralManager)
            {
                OperationsDepartment.GetInstance().RemoveObserver(o);
            }
            if ((o as Employee).JobTitle == Jobs.MarketingManager || (o as Employee).JobTitle == Jobs.SalesAssistant || (o as Employee).JobTitle == Jobs.SalesRepresentative)
            {
                SalesMarketingDepartment.GetInstance().RemoveObserver(o);
            }
        }
    }
}
