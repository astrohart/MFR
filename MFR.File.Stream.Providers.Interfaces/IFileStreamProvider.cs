using System;
using System.IO;

namespace MFR.File.Stream.Providers.Interfaces
{
    /// <summary>
    /// Defines the publicly-exposed methods and properties of an object that allocates
    /// instances of <see cref="T:System.IO.StreamReader" /> and hands out
    /// <see cref="T:System.Guid" /> <c>ticket</c> values that other parts of the
    /// application can then redeem to access the allocated
    /// <see cref="T:System.IO.StreamReader" /> instance for later use.
    /// <para />
    /// Also provides a method to dispose all the allocated
    /// <see cref="T:System.IO.StreamReader" /> instances previously allocated (e.g.,
    /// when the application shuts down).
    /// </summary>
    public interface IFileStreamProvider
    {
        /// <summary>
        /// Gets the count of file streams that are currently available.
        /// </summary>
        int Count
        {
            get;
        }

        /// <summary>
        /// Raised when the value of the
        /// <see cref="P:MFR.File.Stream.Providers.Interfaces.IFileStreamProvider.Count" />
        /// property has been updated.
        /// </summary>
        event EventHandler CountChanged;

        /// <summary>
        /// Removes all allocated <see cref="T:System.IO.StreamReader" /> instances
        /// allocated thus far, from memory, and frees resources associated with them.
        /// </summary>
        /// <remarks>After calling this method, all tickets will be invalid.</remarks>
        void DisposeAll();

        /// <summary>
        /// Provides a reference to an instance of <see cref="T:System.IO.StreamReader" />
        /// that corresponds to the specified <paramref name="ticket" />.
        /// </summary>
        /// <param name="ticket">
        /// (Required.) A <see cref="T:System.Guid" /> value that
        /// represents a <c>ticket</c> that can be redeemed for a particular
        /// <see cref="T:System.IO.StreamReader" /> instance that corresponds to a file
        /// stream.
        /// </param>
        /// <returns>
        /// Reference to an instance of <see cref="T:System.IO.StreamReader" />
        /// that corresponds to the specified <paramref name="ticket" />, or
        /// <see langword="null" /> if either no corresponding
        /// <see cref="T:System.IO.StreamReader" /> can be found in the internal
        /// collection, or if the corresponding <see cref="T:System.IO.StreamReader" />
        /// instance has already been disposed or removed from the internal collection.
        /// </returns>
        StreamReader RedeemTicket(Guid ticket);
    }
}