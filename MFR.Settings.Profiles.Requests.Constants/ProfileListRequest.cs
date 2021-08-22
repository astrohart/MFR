using MFR.Messages.Constants;
using PostSharp.Patterns.Diagnostics;
using System;

namespace MFR.Settings.Profiles.Requests.Constants
{
    /// <summary>
    /// Available requests for use when working with <c>Profile</c> objects.
    /// </summary>
    [Log(AttributeExclude = true)]
    public class ProfileListRequest : RequestType
    {
        /// <summary>
        /// Creates a new (blank) profile.
        /// </summary>
        public static readonly ProfileListRequest CreateNewBlankProfile =
            new ProfileListRequest(Guid.NewGuid());

        /// <summary>
        /// Generic, unknown message.
        /// </summary>
        public static readonly ProfileListRequest Unknown =
            new ProfileListRequest(Guid.Empty);

        /// <summary>
        /// Constructs a new instance of
        /// <see
        ///     cref="T:MFR.Settings.Profiles.Requests.Constants.ProfileListRequest" />
        /// and returns a reference to it.
        /// </summary>
        /// <param name="messageId">
        /// (Required.) Reference to an instance of <see cref="T:System.Guid" />
        /// that provides a unique identifier to be associated with this instance.
        /// </param>
        public ProfileListRequest(Guid messageId) : base(messageId) { }
    }
}