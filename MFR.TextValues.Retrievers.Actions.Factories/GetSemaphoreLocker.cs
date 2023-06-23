using MFR.TextValues.Retrievers.Actions.Interfaces;

namespace MFR.TextValues.Retrievers.Actions.Factories
{
    /// <summary>
    /// Provides access to the one and only instance of the object that implements the
    /// <see cref="T:MFR.TextValues.Retrievers.Actions.Interfaces.ISemaphoreLocker" />
    /// interface.
    /// </summary>
    public static class GetSemaphoreLocker
    {
        /// <summary>
        /// Obtains access to the sole instance of the object that implements the
        /// <see cref="T:MFR.TextValues.Retrievers.Actions.Interfaces.ISemaphoreLocker" />
        /// interface, and returns a reference to it.
        /// </summary>
        /// <returns>
        /// Reference to the one, and only, instance of the object that implements the
        /// <see cref="T:MFR.TextValues.Retrievers.Actions.Interfaces.ISemaphoreLocker" />
        /// interface.
        /// </returns>
        public static ISemaphoreLocker SoleInstance()
            => SemaphoreLocker.Instance;
    }
}