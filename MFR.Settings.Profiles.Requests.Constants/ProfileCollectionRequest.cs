using MFR.Messages.Constants;
using PostSharp.Patterns.Diagnostics;
using System;

namespace MFR.Settings.Profiles.Requests.Constants
{
    /// <summary>
    /// Available requests for use when working with <c>Profile</c> objects.
    /// </summary>
    [Log(AttributeExclude = true)]
    public class ProfileCollectionRequest : RequestType
    {
        /// <summary>
        /// Creates a new (blank) profile.
        /// </summary>
        public static readonly ProfileCollectionRequest CreateNewBlankProfile =
            new ProfileCollectionRequest(Guid.NewGuid());

        /// <summary>
        /// Generic, unknown message.
        /// </summary>
        public static readonly ProfileCollectionRequest Unknown =
            new ProfileCollectionRequest(Guid.Empty);

        /// <summary>
        /// Constructs a new instance of
        /// <see
        ///     cref="T:MFR.Settings.Profiles.Requests.Constants.ProfileCollectionRequest" />
        /// and returns a reference to it.
        /// </summary>
        /// <param name="messageId">
        /// (Required.) Reference to an instance of <see cref="T:System.Guid" />
        /// that provides a unique identifier to be associated with this instance.
        /// </param>
        public ProfileCollectionRequest(Guid messageId) : base(messageId) { }
    }
}