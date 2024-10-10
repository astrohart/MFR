using MFR.Messages.Constants;
using PostSharp.Patterns.Diagnostics;
using System;

namespace MFR.Settings.Profiles.Commands.Constants
{
    /// <summary>
    /// Available commands for use when working with profile list.
    /// </summary>
    [Log(AttributeExclude = true)]
    public class ProfileCollectionCommandType : CommandType
    {
        /// <summary>
        /// Saves a string value to the system Registry.
        /// </summary>
        public static readonly ProfileCollectionCommandType
            SaveProfileCollectionPathToRegistry =
                new ProfileCollectionCommandType(
                    Guid.NewGuid(), nameof(SaveProfileCollectionPathToRegistry)
                );

        /// <summary>
        /// Saves the profile list to a file.
        /// </summary>
        public static readonly ProfileCollectionCommandType
            SaveProfileCollectionToFile = new ProfileCollectionCommandType(
                Guid.NewGuid(), nameof(SaveProfileCollectionToFile)
            );

        /// <summary>
        /// Generic, unknown message.
        /// </summary>
        public static readonly ProfileCollectionCommandType Unknown =
            new ProfileCollectionCommandType(Guid.Empty, nameof(Unknown));

        /// <summary>
        /// Constructs a new instance of
        /// <see
        ///     cref="T:MFR.Settings.Profiles.Commands.Constants.ProfileCollectionCommandType" />
        /// and returns a reference to it.
        /// </summary>
        /// <param name="messageId">
        /// (Required.) Reference to an instance of <see cref="T:System.Guid" />
        /// that provides a unique identifier to be associated with this instance.
        /// </param>
        public ProfileCollectionCommandType(Guid messageId) :
            base(messageId) { }

        /// <summary>
        /// Constructs a new instance of
        /// <see
        ///     cref="T:MFR.Settings.Profiles.Commands.Constants.ProfileCollectionCommandType" />
        /// and returns a reference to it.
        /// </summary>
        /// <param name="description">
        /// (Required.) A <see cref="T:System.String" /> containing a user-friendly
        /// descriptive name for this message type.
        /// </param>
        /// <param name="messageId">
        /// (Required.) Reference to an instance of <see cref="T:System.Guid" />
        /// that provides a unique identifier to be associated with this instance.
        /// </param>
        public ProfileCollectionCommandType(Guid messageId, string description)
            : base(messageId, description) { }
    }
}