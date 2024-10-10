using PostSharp.Patterns.Threading;
using MFR.Events.Common;
using System;

namespace MFR.Operations.Events
{
    /// <summary>
    /// Provides information for DataOperationError event handlers.
    /// </summary>
[ExplicitlySynchronized]
    public class DataOperationErrorEventArgs : ExceptionRaisedEventArgs
    {
        /// <summary>
        /// Constructs a new instance of <see
        /// cref="T:MFR.Operations.Events.DataOperationErrorEventArgs"/>
        /// and returns a reference to it.
        /// </summary>
        /// <param name="exception">
        /// (Required.) Reference to an instance of <see
        /// cref="T:System.Exception"/> , or a child of it, that provides error details.
        /// </param>
        /// <exception cref="T:System.ArgumentNullException">
        /// Thrown if the required parameter, <paramref name="exception"/>, is
        /// passed a <see langword="null"/> reference for a value.
        /// </exception>
        public DataOperationErrorEventArgs(Exception exception) : base(
            exception
        )
        {
        }
    }
}