using MFR.Messages.Constants;
using PostSharp.Patterns.Diagnostics;
using System;

namespace MFR.Settings.Profiles.Actions.Constants
{
    /// <summary>
    /// Available actions for use when working with configuration.
    /// </summary>
    [Log(AttributeExclude = true)]
    public class ProfileCollectionAction : ActionType
    {
        /// <summary>
        /// Creates a new, named profile that can be added to the list.
        /// </summary>
        public static readonly ProfileCollectionAction CreateNewNamedProfile =
            new ProfileCollectionAction(Guid.NewGuid());

        /// <summary>
        /// Loads the configuration from a file.
        /// </summary>
        public static readonly ProfileCollectionAction LoadProfileCollectionFromFile =
            new ProfileCollectionAction(Guid.NewGuid());

        /// <summary>
        /// Loads a string value from the system Registry.
        /// </summary>
        public static readonly ProfileCollectionAction LoadStringFromRegistry =
            new ProfileCollectionAction(Guid.NewGuid());

        /// <summary>
        /// Constructs a new instance of
        /// <see
        ///     cref="T:MFR.Settings.Profiles.Actions.Constants.ProfileCollectionAction" />
        /// and returns a reference to it.
        /// </summary>
        /// <param name="messageId">
        /// (Required.) Reference to an instance of <see cref="T:System.Guid" />
        /// that provides a unique identifier to be associated with this instance.
        /// </param>
        public ProfileCollectionAction(Guid messageId) : base(messageId) { }
    }
}