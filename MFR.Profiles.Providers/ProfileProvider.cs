using MFR.Profiles.Collections;
using MFR.Profiles.Collections.Interfaces;
using MFR.Profiles.Providers.Interfaces;
using System;

namespace MFR.Profiles.Providers
{
    /// <summary>
    /// Provides access to the collection of profiles for the current user.
    /// </summary>
    public class ProfileProvider : IProfileProvider
    {
        /// <summary>
        /// Empty, static constructor to prohibit direct allocation of this class.
        /// </summary>
        static ProfileProvider() { }

        /// <summary>
        /// Empty, protected constructor to prohibit direct allocation of this class.
        /// </summary>
        protected ProfileProvider()
        {
            Profiles = new ProfileCollection();
        }

        /// <summary>
        /// Gets a reference to the one and only instance of
        /// <see cref="T:MFR.Profiles.Providers.ProfileProvider" />.
        /// </summary>
        public static ProfileProvider Instance
        {
            get;
        } = new ProfileProvider();

        /// <summary>
        /// Gets the default folder for the configuration file.
        /// </summary>
        /// <remarks>
        /// We store the profile configuration file, by default, in a folder
        /// under the current user's AppData folder.
        /// </remarks>
        public string DefaultProfileDir
        {
            get;
        }

        /// <summary>
        /// Gets a string whose value is the pathname of the profile list file.
        /// </summary>
        public string ProfileListPath
        {
            get;
        }

        /// <summary>
        /// Gets a string whose value is the pathname of the system Registry key
        /// in which Profile settings are stored.
        /// </summary>
        public string ProfileListPathKeyName
        {
            get;
        }

        /// <summary>
        /// Gets a string whose value is the Registry value under which we store
        /// the path to the profile list file.
        /// </summary>
        public string ProfileListPathValueName
        {
            get;
        }

        /// <summary>
        /// Gets a reference to an instance of an object that implements the
        /// <see
        ///     cref="T:MFR.Profiles.Collections.Interfaces.IProfileCollection" />
        /// interface.
        /// </summary>
        /// <remarks>
        /// The object to which a reference is returned by this properties
        /// allows access to the set of profiles defined by the user.
        /// </remarks>
        public IProfileCollection Profiles
        {
            get;
        }

        /// <summary>
        /// Loads the profiles from the profile list file.
        /// </summary>
        /// <param name="pathname">
        /// (Required.) String containing the pathname of the file from which to
        /// load the profiles.
        /// </param>
        /// <remarks>
        /// The file whose pathname is passed must not be the actual
        /// configuration file, but a separate file.
        /// </remarks>
        /// <exception cref="T:System.IO.FileNotFoundException">
        /// Thrown if the file whose pathname is passed in the
        /// <paramref
        ///     name="pathname" />
        /// parameter cannot be found on the disk.
        /// </exception>
        public void Load(string pathname = "")
            => throw new NotImplementedException();

        /// <summary>
        /// Saves profile list data to a file on the disk having path
        /// <paramref name="pathname" />.
        /// </summary>
        /// <param name="pathname">
        /// (Optional.) String containing the path to where the data should be
        /// saved in JSON format.
        /// <para />
        /// If this parameter is blank, then the data is saved to the path that
        /// is stored in the
        /// <see
        ///     cref="P:MFR.Profiles.Providers.Interfaces.IProfileProvider.ProfileListPath" />
        /// property.
        /// </param>
        /// <remarks>
        /// If the
        /// <see
        ///     cref="P:MFR.Profiles.Providers.Interfaces.IProfileProvider.ProfileListPath" />
        /// property is blank, then this method does nothing.
        /// </remarks>
        public void Save(string pathname = "")
            => throw new NotImplementedException();
    }
}