namespace EmployeeManagementSimulator
{
    /// <summary>
    /// This interface represents the subject that observers will observe.
    /// </summary>
    public interface ISubject
    {
        /// <summary>
        /// This method registers an observer to observe the subject.
        /// </summary>
        /// <param name="o"></param>
        void RegisterObserver(IObserver o);

        /// <summary>
        /// This method removes an observer from observing the subject.
        /// </summary>
        /// <param name="o"></param>
        void RemoveObserver(IObserver o);

        /// <summary>
        /// This method notifies all observers that are observing the subject.
        /// </summary>
        /// <param name="message">The message being added to the observers.</param>
        void NotifyObservers(string message);
    }
}
