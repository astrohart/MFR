using MFR.Settings.Configuration.Interfaces;
using PostSharp.Patterns.Diagnostics;
using MFR.Settings.Profiles.Factories.Properties;
using MFR.Settings.Profiles.Interfaces;
using System;

namespace MFR.Settings.Profiles.Factories
{
    /// <summary>
    /// Creates new instances of objects that implement the
    /// <see cref="T:MFR.Settings.Profiles.Interfaces.IProfile" /> interface, and
    /// returns references to them.
    /// </summary>
    [Log(AttributeExclude = true)]
    public static class MakeNewProfile
    {
        /// <summary>
        /// Creates a new instance of an object that implements the
        /// <see cref="T:MFR.Settings.Profiles.Interfaces.IProfile" /> interface and
        /// returns a reference to it.
        /// </summary>
        /// <returns>
        /// Reference to an instance of an object that implements the
        /// <see cref="T:MFR.Settings.Profiles.Interfaces.IProfile" /> interface.
        /// </returns>
        public static IProfile FromScratch()
            => new Profile();

        /// <summary>
        /// Assigns a name to the <paramref name="profile" /> specified.
        /// </summary>
        /// <param name="profile">
        /// (Required.) Reference to an instance of an object that
        /// implements the <see cref="T:MFR.Settings.Profiles.Interfaces.IProfile" />
        /// interface.
        /// </param>
        /// <param name="name">
        /// (Required.) String containing the new name to be assigned to
        /// the profile.
        /// </param>
        /// <returns>
        /// Reference to an instance of an object that implements the
        /// <see cref="T:MFR.Settings.Profiles.Interfaces.IProfile" /> interface, or
        /// <see langword="null" /> if an error occurs.
        /// </returns>
        /// <exception cref="T:System.ArgumentNullException">
        /// Thrown if the required
        /// parameter, <paramref name="profile" />, is passed a <see langword="null" />
        /// value.
        /// </exception>
        /// <exception cref="T:System.ArgumentException">
        /// Thrown if the required parameter,
        /// <paramref name="name" />, is passed a blank or <see langword="null" /> string
        /// for a value.
        /// </exception>
        /// <remarks>
        /// This method will not check whether a profile with the specified name already
        /// exists.
        /// <para />
        /// Doing so is the job of the caller.
        /// <para />
        /// Along with assigning the specified <paramref name="profile" /> a new name, this
        /// method also generates a new GUID to use to identify the profile by.  This
        /// done because only one profile can be saved having the same name.
        /// </remarks>
        public static IProfile HavingName(this IProfile profile, string name)
        {
            if (profile == null)
                throw new ArgumentNullException(nameof(profile));
            if (string.IsNullOrWhiteSpace(name))
                throw new ArgumentException(
                    Resources.Error_ValueCannotBeNullOrWhiteSpace, nameof(name)
                );

            profile.Name = name;

            /*
             * Along with changing the name of a profile, we also give it a new GUID.
             */

            profile.ProfileId = Guid.NewGuid();

            return profile;
        }

        /// <summary>
        /// Extension method that converts the specified <paramref name="config" />
        /// object to a profile object.
        /// <para />
        /// the config settings in the source are copied to the new profile, and the
        /// specified <paramref name="name" /> is also assigned to the new profile.
        /// </summary>
        /// <param name="config">
        /// (Required.) Reference to an instance of an object
        /// that implements the
        /// <see cref="T:MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfig" />
        /// interface.
        /// </param>
        /// <param name="name">
        /// (Required.) String containing the name to be assigned to the
        /// new profile.
        /// </param>
        /// <returns>
        /// Reference to an instance of an object that implements the
        /// <see cref="T:MFR.Settings.Profiles.Interfaces.IProfile" /> interface, or
        /// <see langword="null" /> if an error occurs.
        /// </returns>
        /// <remarks>
        /// This method will not check whether a profile with the specified name already
        /// exists.
        /// <para />
        /// Doing so is the job of the caller.
        /// </remarks>
        /// <exception cref="T:System.ArgumentNullException">
        /// Thrown if the required
        /// parameter, <paramref name="config" />, is passed a
        /// <see langword="null" /> value.
        /// </exception>
        /// <exception cref="T:System.ArgumentException">
        /// Thrown if the required parameter,
        /// <paramref name="name" />, is passed a blank or <see langword="null" /> string
        /// for a value.
        /// </exception>
        public static IProfile ToProfile(this IProjectFileRenamerConfig config,
            string name)
        {
            if (config == null)
                throw new ArgumentNullException(nameof(config));
            if (string.IsNullOrWhiteSpace(name))
                throw new ArgumentException(
                    Resources.Error_ValueCannotBeNullOrWhiteSpace, nameof(name)
                );

            return new Profile(config, name);
        }
    }
}
