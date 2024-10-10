using PostSharp.Patterns.Threading;
using MFR.Operations.Constants;
using System;

namespace MFR.Renamers.Files.Events
{
    /// <summary>
    /// Provides information for <c>CurrentOperationChanged</c> event handlers.
    /// </summary>
[ExplicitlySynchronized]
    public class CurrentOperationChangedEventArgs : EventArgs
    {
        /// <summary>
        /// Constructs a new instance of
        /// <see cref="T:MFR.Renamers.Files.Events.CurrentOperationChangedEventArgs" /> and
        /// returns a reference to it.
        /// </summary>
        /// <param name="newOperationType">
        /// (Required.) One of the <see cref="T:MFR.Operations.Constants.OperationType" />
        /// values that indicates the new operation that is being performed by the
        /// application.
        /// </param>
        public CurrentOperationChangedEventArgs(OperationType newOperationType)
        {
            NewOperationType = newOperationType;
        }

        /// <summary>
        /// Gets the <see cref="T:MFR.Operations.Constants.OperationType" /> enumeration
        /// value that indicates the new operation that is being executed by the
        /// application..
        /// </summary>
        public OperationType NewOperationType
        {
            get;
        }
    }
}