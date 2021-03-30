using System;

namespace MFR.Objects
{
    /// <summary>
    /// Provides information for DataOperation event handlers.
    /// </summary>
    public class DataOperationEventArgs : EventArgs
    {
        /// <summary> Constructs a new instance of <see
        /// cref="T:MFR.Objects.DataOperationEventArgs" /> and
        /// returns a reference to it. </summary> /// <param name="message">
        /// (Required.) String containing message text to be displayed to the
        /// user while the operation is progressing. </param
        public DataOperationEventArgs(string message)
        {
            Message = message;
        }

        /// <summary>
        /// Gets a string containing a message to be displayed to the user
        /// during a data update operation.
        /// </summary>
        public string Message
        {
            get;
        }
    }
}