using MFR.Messages.Constants;
using PostSharp.Patterns.Diagnostics;
using System;

namespace MFR.Settings.Profiles.Commands.Constants
{
    /// <summary>
    /// Available commands for use when working with profile list.
    /// </summary>
    [Log(AttributeExclude = true)]
    public class ProfileCollectionCommand : CommandType
    {
        /// <summary>
        /// Saves the profile list to a file.
        /// </summary>
        public static readonly ProfileCollectionCommand SaveProfileCollectionToFile =
            new ProfileCollectionCommand(Guid.NewGuid());

        /// <summary>
        /// Saves a string value to the system Registry.
        /// </summary>
        public static readonly ProfileCollectionCommand SaveProfileCollectionPathToRegistry =
            new ProfileCollectionCommand(Guid.NewGuid());

        /// <summary>
        /// Generic, unknown message.
        /// </summary>
        public static readonly ProfileCollectionCommand Unknown =
            new ProfileCollectionCommand(Guid.Empty);

        /// <summary>
        /// Constructs a new instance of
        /// <see
        ///     cref="T:MFR.Settings.Profiles.Commands.Constants.ProfileCollectionCommand" />
        /// and returns a reference to it.
        /// </summary>
        /// <param name="messageId">
        /// (Required.) Reference to an instance of <see cref="T:System.Guid" />
        /// that provides a unique identifier to be associated with this instance.
        /// </param>
        public ProfileCollectionCommand(Guid messageId) : base(messageId) { }
    }
}