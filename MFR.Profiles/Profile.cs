using MFR.Objects.Configuration;
using MFR.Profiles.Interfaces;
using Newtonsoft.Json;
using System;

namespace MFR.Profiles
{
    /// <summary>
    /// A <c>Profile</c> is basically a <c>Configuration</c>, just with an ID
    /// and a name.
    /// </summary>
    /// <remarks>
    /// <c>Profile</c> s allow the user to hot-swap settings mid-flight, without
    /// actually leaving the app and coming back in.
    /// </remarks>
    public class Profile : Configuration, IProfile
    {
        /// <summary>
        /// Constructs a new instance of <see cref="T:MFR.Profiles.Profile" />
        /// and returns a reference to it.
        /// </summary>
        /// <remarks>
        /// This constructor overload is here simply to define the behavior of
        /// setting the <see cref="P:MFR.Profiles.Profile.Name" /> property to
        /// <see cref="P:System.String.Empty" />.
        /// </remarks>
        public Profile()
        {
            Name = string.Empty;
        }

        /// <summary>
        /// Constructs a new instance of <see cref="T:MFR.Profiles.Profile" />
        /// and returns a reference to it.
        /// </summary>
        /// <param name="name">
        /// (Required.) String containing the name of this profile. Cannot be empty.
        /// </param>
        /// <exception cref="T:System.ArgumentException">
        /// Thrown if the required parameter, <paramref name="name" />, is passed
        /// a blank or <see langword="null" /> string for a value.
        /// </exception>
        public Profile(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
                throw new ArgumentException(
                    "Value cannot be blank or null.", nameof(name)
                );
            Name = name;
        }

        /// <summary>
        /// Gets or sets a string value that is the name of this profile.
        /// </summary>
        [JsonProperty("name")]
        public string Name
        {
            get;
            set;
        }

        /// <summary>
        /// Gets a <see cref="T:System.Guid" /> value that uniquely identifies
        /// this <see cref="T:MFR.Profiles.Profile" />.
        /// </summary>
        /// <remarks>
        /// This property is automatically initialized with a newly-generated
        /// <c>GUID</c> upon construction.
        /// </remarks>
        [JsonProperty("id")]
        public Guid ProfileId
        {
            get;
        } = Guid.NewGuid();

        /// <summary>
        /// Returns a string that represents the current object.
        /// </summary>
        /// <returns>
        /// A string that represents the current object.
        /// </returns>
        public override string ToString()
            => Name;
    }
}