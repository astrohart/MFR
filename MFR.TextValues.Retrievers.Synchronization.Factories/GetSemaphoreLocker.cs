using MFR.TextValues.Retrievers.Synchronization.Interfaces;

namespace MFR.TextValues.Retrievers.Synchronization.Factories
{
    /// <summary>
    /// Provides access to the one and only instance of the object that implements the
    /// <see cref="T:MFR.TextValues.Retrievers.Synchronization.Interfaces.ISemaphoreLocker" />
    /// interface.
    /// </summary>
    public static class GetSemaphoreLocker
    {
        /// <summary>
        /// Obtains access to the sole instance of the object that implements the
        /// <see cref="T:MFR.TextValues.Retrievers.Synchronization.Interfaces.ISemaphoreLocker" />
        /// interface, and returns a reference to it.
        /// </summary>
        /// <returns>
        /// Reference to the one, and only, instance of the object that implements the
        /// <see cref="T:MFR.TextValues.Retrievers.Synchronization.Interfaces.ISemaphoreLocker" />
        /// interface.
        /// </returns>
        public static ISemaphoreLocker SoleInstance()
            => SemaphoreLocker.Instance;
    }
}