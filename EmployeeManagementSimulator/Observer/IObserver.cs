namespace EmployeeManagementSimulator
{
    /// <summary>
    /// This interface represents observers that will update when the subject is updated.
    /// </summary>
    public interface IObserver
    {
        /// <summary>
        /// THis method updates the observers when a new message is added.
        /// </summary>
        /// <param name="message">The message being added.</param>
        void Update(string message);
    }
}
