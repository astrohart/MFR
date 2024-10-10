using MFR.Messages.Constants;
using PostSharp.Patterns.Diagnostics;
using System;

namespace MFR.Settings.Profiles.Actions.Constants
{
    /// <summary>
    /// Available actions for use when working with configuration profiles.
    /// </summary>
    [Log(AttributeExclude = true)]
    public class ProfileCollectionActionType : ActionType
    {
        /// <summary>
        /// Creates a new, named profile that can be added to the list.
        /// </summary>
        public static readonly ProfileCollectionActionType
            CreateNewNamedProfile = new ProfileCollectionActionType(
                Guid.NewGuid(), nameof(CreateNewNamedProfile)
            );

        /// <summary>
        /// Loads the configuration from a file.
        /// </summary>
        public static readonly ProfileCollectionActionType
            LoadProfileCollectionFromFile = new ProfileCollectionActionType(
                Guid.NewGuid(), nameof(LoadProfileCollectionFromFile)
            );

        /// <summary>
        /// Loads a string value from the system Registry.
        /// </summary>
        public static readonly ProfileCollectionActionType
            LoadStringFromRegistry = new ProfileCollectionActionType(
                Guid.NewGuid(), nameof(LoadStringFromRegistry)
            );

        /// <summary>
        /// Constructs a new instance of
        /// <see
        ///     cref="T:MFR.Settings.Profiles.Actions.Constants.ProfileCollectionActionType" />
        /// and returns a reference to it.
        /// </summary>
        /// <param name="messageId">
        /// (Required.) Reference to an instance of <see cref="T:System.Guid" />
        /// that provides a unique identifier to be associated with this instance.
        /// </param>
        public ProfileCollectionActionType(Guid messageId) : base(messageId) { }

        /// <summary>
        /// Constructs a new instance of
        /// <see
        ///     cref="T:MFR.Settings.Profiles.Actions.Constants.ProfileCollectionActionType" />
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
        public ProfileCollectionActionType(Guid messageId, string description) :
            base(messageId, description) { }
    }
}