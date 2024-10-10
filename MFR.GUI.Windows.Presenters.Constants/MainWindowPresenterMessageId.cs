using MFR.Messages.Identifiers;
using PostSharp.Patterns.Diagnostics;
using System;

namespace MFR.GUI.Windows.Presenters.Constants
{
    /// <summary>
    /// Encapsulates a unique identifier for a message, as well as its name.
    /// </summary>
    [Log(AttributeExclude = true)]
    public class MainWindowPresenterMessageId : MessageIdentifier
    {
        /// <summary>
        /// s
        /// Allows us to pass instances of this class to methods that accept a
        /// <see cref="T:System.Guid" /> as an input parameter.
        /// </summary>
        /// <param name="id">
        /// (Required.) Reference to an instance of
        /// <see cref="T:MFR.GUI.Windows.Presenters.Constants.MainWindowPresenterMessageId" />
        /// to be converted.
        /// </param>
        public static implicit operator Guid(MainWindowPresenterMessageId id)
            => id.MessageId;
    }
}