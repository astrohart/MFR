using MFR.Messages.Constants;
using PostSharp.Patterns.Diagnostics;
using System;

namespace MFR.Settings.Profiles.Commands.Constants
{
    /// <summary>
    /// Available commands for use when working with profile list.
    /// </summary>
    [Log(AttributeExclude = true)]
    public class ProfileListCommand : CommandType
    {
        /// <summary>
        /// Saves the profile list to a file.
        /// </summary>
        public static readonly ProfileListCommand SaveProfileListToFile =
            new ProfileListCommand(Guid.NewGuid());

        /// <summary>
        /// Saves a string value to the system Registry.
        /// </summary>
        public static readonly ProfileListCommand SaveProfileListPathToRegistry =
            new ProfileListCommand(Guid.NewGuid());

        /// <summary>
        /// Generic, unknown message.
        /// </summary>
        public static readonly ProfileListCommand Unknown =
            new ProfileListCommand(Guid.Empty);

        /// <summary>
        /// Constructs a new instance of
        /// <see
        ///     cref="T:MFR.Settings.Profiles.Commands.Constants.ProfileListCommand" />
        /// and returns a reference to it.
        /// </summary>
        /// <param name="messageId">
        /// (Required.) Reference to an instance of <see cref="T:System.Guid" />
        /// that provides a unique identifier to be associated with this instance.
        /// </param>
        public ProfileListCommand(Guid messageId) : base(messageId) { }
    }
}