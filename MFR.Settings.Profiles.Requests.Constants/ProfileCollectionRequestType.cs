using MFR.Messages.Constants;
using PostSharp.Patterns.Diagnostics;
using System;

namespace MFR.Settings.Profiles.Requests.Constants
{
    /// <summary>
    /// Available requests for use when working with <c>Profile</c> objects.
    /// </summary>
    [Log(AttributeExclude = true)]
    public class ProfileCollectionRequestType : RequestType
    {
        /// <summary>
        /// Creates a new (blank) profile.
        /// </summary>
        public static readonly ProfileCollectionRequestType
            CreateNewBlankProfile = new ProfileCollectionRequestType(
                Guid.NewGuid(), nameof(CreateNewBlankProfile)
            );

        /// <summary>
        /// Generic, unknown message.
        /// </summary>
        public static readonly ProfileCollectionRequestType Unknown =
            new ProfileCollectionRequestType(Guid.Empty, nameof(Unknown));

        /// <summary>
        /// Constructs a new instance of
        /// <see
        ///     cref="T:MFR.Settings.Profiles.Requests.Constants.ProfileCollectionRequestType" />
        /// and returns a reference to it.
        /// </summary>
        /// <param name="messageId">
        /// (Required.) Reference to an instance of <see cref="T:System.Guid" />
        /// that provides a unique identifier to be associated with this instance.
        /// </param>
        public ProfileCollectionRequestType(Guid messageId) :
            base(messageId) { }

        /// <summary>
        /// Constructs a new instance of
        /// <see
        ///     cref="T:MFR.Settings.Profiles.Requests.Constants.ProfileCollectionRequestType" />
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
        public ProfileCollectionRequestType(Guid messageId, string description)
            : base(messageId, description) { }
    }
}