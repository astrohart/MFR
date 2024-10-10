using PostSharp.Patterns.Diagnostics;
using System;
using xyLOGIX.Core.Debug;

namespace MFR.Constants
{
    /// <summary>
    /// Encapsulates a unique identifier for a message, as well as its name.
    /// </summary>
    [Log(AttributeExclude = true)]
    public class FileRenamerMessageId
    {
        /// <summary>
        /// Gets or sets a <see cref="T:System.Guid" /> value that uniquely identifies the
        /// message.
        /// </summary>
        public Guid MessageId
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets a <see cref="T:System.String" /> that names this message
        /// identifier.
        /// </summary>
        public string Name
        {
            get;
            set;
        }

        /// <summary>
        /// s
        /// Allows us to pass instances of this class to methods that accept a
        /// <see cref="T:System.Guid" /> as an input parameter.
        /// </summary>
        /// <param name="id">
        /// (Required.) Reference to an instance of
        /// <see cref="T:MFR.Constants.FileRenamerMessageId" /> to be converted.
        /// </param>
        public static implicit operator Guid(FileRenamerMessageId id)
            => id.MessageId;

        /// <summary>
        /// Determines whether the value of the
        /// <see cref="P:MFR.Constants.FileRenamerMessageId.MessageId" /> property is set
        /// to the Zero GUID.
        /// </summary>
        /// <returns>
        /// <see langword="true" /> if the value of the
        /// <see cref="P:MFR.Constants.FileRenamerMessageId.MessageId" /> property is set
        /// to the Zero GUID; <see langword="false" /> otherwise.
        /// </returns>
        public bool IsZero()
        {
            bool result;

            try
            {
                result = Guid.Empty.Equals(MessageId);
            }
            catch (Exception ex)
            {
                // dump all the exception info to the log
                DebugUtils.LogException(ex);

                result = false;
            }

            return result;
        }

        /// <summary>Returns a string that represents the current object.</summary>
        /// <returns>A string that represents the current object.</returns>
        public override string ToString()
            => Name;
    }
}