using MFR.Messages.Constants;
using PostSharp.Patterns.Diagnostics;
using System;

namespace MFR.Settings.Profiles.Requests.Constants
{
    /// <summary>
    /// Available requests for use when working with <c>Profile</c> objects.
    /// </summary>
    [Log(AttributeExclude = true)]
    public class ProfileRequest : RequestType
    {
        /// <summary>
        /// Creates a new (blank) profile.
        /// </summary>
        public static readonly ProfileRequest CreateNewBlankProfile =
            new ProfileRequest(Guid.NewGuid());

        /// <summary>
        /// Generic, unknown message.
        /// </summary>
        public static readonly ProfileRequest Unknown =
            new ProfileRequest(Guid.Empty);

        /// <summary>
        /// Constructs a new instance of
        /// <see
        ///     cref="T:MFR.Settings.Profiles.Requests.Constants.ProfileRequest" />
        /// and returns a reference to it.
        /// </summary>
        /// <param name="messageId">
        /// (Required.) Reference to an instance of <see cref="T:System.Guid" />
        /// that provides a unique identifier to be associated with this instance.
        /// </param>
        public ProfileRequest(Guid messageId) : base(messageId) { }
    }
}