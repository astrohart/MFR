using MFR.Messages.Constants;
using PostSharp.Patterns.Diagnostics;
using System;

namespace MFR.Settings.Profiles.Actions.Constants
{
    /// <summary>
    /// Available actions for use when working with configuration.
    /// </summary>
    [Log(AttributeExclude = true)]
    public class ProfileListAction : ActionType
    {
        /// <summary>
        /// Loads the configuration from a file.
        /// </summary>
        public static readonly ProfileListAction LoadProfileListFromFile =
            new ProfileListAction(Guid.NewGuid());

        /// <summary>
        /// Loads a string value from the system Registry.
        /// </summary>
        public static readonly ProfileListAction LoadStringFromRegistry =
            new ProfileListAction(Guid.NewGuid());

        /// <summary>
        /// Constructs a new instance of
        /// <see
        ///     cref="T:MFR.Settings.Profiles.Actions.Constants.ProfileListAction" />
        /// and returns a reference to it.
        /// </summary>
        /// <param name="messageId">
        /// (Required.) Reference to an instance of <see cref="T:System.Guid" />
        /// that provides a unique identifier to be associated with this instance.
        /// </param>
        public ProfileListAction(Guid messageId) : base(messageId) { }
    }
}