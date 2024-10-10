using MFR.Settings.Configuration.Interfaces;
using MFR.Settings.Profiles.Interfaces;
using MFR.Settings.Profiles.Properties;
using Newtonsoft.Json;
using PostSharp.Patterns.Diagnostics;
using System;

namespace MFR.Settings.Profiles
{
    /// <summary>
    /// A <c>Profile</c> is basically a <c>ProjectFileRenamerConfig</c>, just with an ID
    /// and a name.
    /// </summary>
    /// <remarks>
    /// <c>Profile</c> s allow the user to hot-swap settings mid-flight, without
    /// actually leaving the app and coming back in.
    /// </remarks>
    [Log(AttributeExclude = true)]
    public class Profile : Configuration.ProjectFileRenamerConfig, IProfile
    {
        /// <summary>
        /// Constructs a new instance of <see cref="T:MFR.Settings.Profiles.Profile" />
        /// and returns a reference to it.
        /// </summary>
        /// <remarks>
        /// This constructor overload is here simply to define the behavior of
        /// setting the <see cref="P:MFR.Settings.Profiles.Profile.Name" /> property to
        /// <see cref="P:System.String.Empty" />.
        /// </remarks>
        [Log(AttributeExclude = true)]
        public Profile()
        {
            Name = string.Empty;
        }

        /// <summary>
        /// Constructs a new instance of <see cref="T:MFR.Settings.Profiles.Profile" />
        /// and returns a reference to it.
        /// </summary>
        /// <param name="name">
        /// (Required.) String containing the name of this profile. Cannot be empty.
        /// </param>
        /// <exception cref="T:System.ArgumentException">
        /// Thrown if the required parameter, <paramref name="name" />, is passed
        /// a blank or <see langword="null" /> string for a value.
        /// </exception>
        [Log(AttributeExclude = true)]
        public Profile(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
                throw new ArgumentException(
                    Resources.Error_ValueCannotBeBlankOrNull, nameof(name)
                );
            Name = name;
            ProfileId = Guid.NewGuid();
        }

        /// <summary>
        /// Constructs a new instance of <see cref="T:MFR.Settings.Profiles.Profile" /> and
        /// returns a reference to it.
        /// </summary>
        /// <param name="source">
        /// (Required.) Reference to an instance of an object that implements the
        /// <see cref="T:MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfig" /> interface
        /// that contains config settings to copy into this object.
        /// </param>
        /// <param name="name">
        /// (Required.) String containing the descriptive name that the user wants to use
        /// for this profile.
        /// </param>
        [Log(AttributeExclude = true)]
        public Profile(IProjectFileRenamerConfig source, string name) : base(source)
        {
            if (string.IsNullOrWhiteSpace(name))
                throw new ArgumentException(
                    Resources.Error_ValueCannotBeBlankOrNull, nameof(name)
                );

            Name = name;
            ProfileId = Guid.NewGuid();
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
        /// Gets or sets a <see cref="T:System.Guid" /> value that uniquely identifies
        /// this <see cref="T:MFR.Settings.Profiles.Profile" />.
        /// </summary>
        /// <remarks>
        /// This property is automatically initialized with a newly-generated
        /// <c>GUID</c> upon construction.
        /// </remarks>
        [JsonProperty("id")]
        public Guid ProfileId
        {
            get;
            set;
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