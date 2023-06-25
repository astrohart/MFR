using MFR.TextValues.Retrievers.Synchronization.Interfaces;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace MFR.TextValues.Retrievers.Synchronization
{
    /// <summary>
    /// Allows the caller to put a mutex or critical section around calls to
    /// asynchronous methods.
    /// </summary>
    public class SemaphoreLocker : ISemaphoreLocker
    {
        /// <summary>
        /// Empty, static constructor to prohibit direct allocation of this class.
        /// </summary>
        static SemaphoreLocker() { }

        /// <summary>
        /// Empty, protected constructor to prohibit direct allocation of this class.
        /// </summary>
        protected SemaphoreLocker()
        {
            Semaphore = new SemaphoreSlim(1, 1);
        }

        /// <summary>
        /// Gets a reference to the one and only instance of the object that implements the
        /// <see
        ///     cref="T:MFR.TextValues.Retrievers.Synchronization.Interfaces.ISemaphoreLocker" />
        /// interface.
        /// </summary>
        public static ISemaphoreLocker Instance
        {
            get;
        } = new SemaphoreLocker();

        /// <summary>
        /// Gets a to an instance of <see cref="T:System.Threading.SemaphoreSlim" />
        /// that provides a semaphore to be used for asynchronous thread synchronization.
        /// </summary>
        private SemaphoreSlim Semaphore
        {
            get;
        }

        /// <summary>
        /// Uses a semaphore instead of a critical section to ensure that only one thread
        /// at a time runs an asynchronous operation.
        /// </summary>
        /// <param name="worker">(Required.) Thread that must be synchronized.</param>
        /// <returns>An awaitable <see cref="T:System.Threading.Tasks.Task" />.</returns>
        public async Task LockAsync(Func<Task> worker)
        {
            var isTaken = false;
            try
            {
                do
                    try { }
                    finally
                    {
                        isTaken =
                            await Semaphore.WaitAsync(TimeSpan.FromSeconds(1));
                    }
                while (!isTaken);

                await worker();
            }
            finally
            {
                if (isTaken) Semaphore.Release();
            }
        }

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
        public async Task<T> LockAsync<T>(Func<Task<T>> worker)
        {
            var isTaken = false;
            try
            {
                do
                    try { }
                    finally
                    {
                        isTaken =
                            await Semaphore.WaitAsync(TimeSpan.FromSeconds(1));
                    }
                while (!isTaken);

                return await worker();
            }
            finally
            {
                if (isTaken) Semaphore.Release();
            }
        }
    }
}