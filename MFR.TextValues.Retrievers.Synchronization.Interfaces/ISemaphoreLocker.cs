using System;
using System.Threading.Tasks;

namespace MFR.TextValues.Retrievers.Synchronization.Interfaces
{
    /// <summary>
    /// Defines the publicly-exposed methods and properties of an object that manages
    /// semaphore locks for asynchronous method calls..
    /// </summary>
    public interface ISemaphoreLocker
    {
        /// <summary>
        /// Uses a semaphore instead of a critical section to ensure that only one thread
        /// at a time runs an asynchronous operation.
        /// </summary>
        /// <param name="worker">(Required.) Thread that must be synchronized.</param>
        /// <returns>An awaitable <see cref="T:System.Threading.Tasks.Task" />.</returns>
        Task LockAsync(Func<Task> worker);

        /// <summary>
        /// Uses a semaphore instead of a critical section to ensure that only one thread
        /// at a time runs an asynchronous operation.
        /// </summary>
        /// <typeparam name="T">
        /// (Required.) Data type of the return value of the specified
        /// <paramref name="worker" /> thread.
        /// </typeparam>
        /// <param name="worker">(Required.) Thread that must be synchronized.</param>
        /// <returns>An awaitable <see cref="T:System.Threading.Tasks.Task" />.</returns>
        Task<T> LockAsync<T>(Func<Task<T>> worker);
    }
}