 using MFR.Settings.Profiles.Collections.Interfaces;

namespace MFR.Settings.Profiles.Providers.Interfaces
{
    /// <summary>
    /// Defines the publicly-exposed methods and properties of a
    /// <c>
    /// Profile
    /// Provider
    /// </c>
    /// object.
    /// </summary>
    /// <remarks>
    /// A <c>Profile Provider</c> object maintains a collection of the profiles
    /// defined by the user.
    /// </remarks>
    public interface IProfileProvider
    {
        /// <summary>
        /// Gets the default folder for the configuration file.
        /// </summary>
        /// <remarks>
        /// We store the profile configuration file, by default, in a folder
        /// under the current user's AppData folder.
        /// </remarks>
        string DefaultProfileListDir
        {
            get;
        }

        /// <summary>
        /// Gets the default fully-qualified pathname of the profile list file.
        /// </summary>
        string DefaultProfileListPath { get; }

        /// <summary>
        /// Gets a string whose value is the pathname of the profile list file.
        /// </summary>
        string ProfileListFilePath
        {
            get;
            set;
        }

        /// <summary>
        /// Gets a string whose value is the pathname of the system Registry key
        /// in which Profile settings are stored.
        /// </summary>
        string ProfileListPathKeyName
        {
            get;
        }

        /// <summary>
        /// Gets a string whose value is the Registry value under which we store
        /// the path to the profile list file.
        /// </summary>
        string ProfileListPathValueName
        {
            get;
        }

        /// <summary>
        /// Gets a reference to an instance of an object that implements the
        /// <see
        ///     cref="T:MFR.Settings.Profiles.Collections.Interfaces.IProfileCollection" />
        /// interface.
        /// </summary>
        /// <remarks>
        /// The object to which a reference is returned by this properties
        /// allows access to the set of profiles defined by the user.
        /// <para />
        /// If this property is read prior to any profiles being loaded, it
        /// should return a reference the empty collection.
        /// </remarks>
        IProfileCollection Profiles
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
        void Load(string pathname = "");

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
        ///     cref="P:MFR.Settings.Profiles.Providers.Interfaces.IProfileProvider.ProfileListFilePath" />
        /// property.
        /// </param>
        /// <remarks>
        /// If the
        /// <see
        ///     cref="P:MFR.Settings.Profiles.Providers.Interfaces.IProfileProvider.ProfileListFilePath" />
        /// property is blank, then this method does nothing.
        /// </remarks>
        void Save(string pathname = "");
    }
}