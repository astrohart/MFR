using MFR.Settings.Profiles.Collections.Interfaces;
using System;

namespace MFR.Settings.Profiles.Providers.Interfaces
{
    /// <summary>
    /// Defines the publicly-exposed methods and properties of a
    /// <c> ProfileProvider</c> object.
    /// </summary>
    /// <remarks>
    /// A <c>ProfileProvider</c> object maintains a collection of the saved
    /// configuration setting profiles defined by the user.
    /// </remarks>
    public interface IProfileProvider
    {
        /// <summary>
        /// Gets a string whose value is the fully-qualified pathname of the profile list
        /// file.
        /// </summary>
        /// <remarks>
        /// This property raises the
        /// <see
        ///     cref="E:MFR.Settings.Profiles.Providers.Interfaces.IProfileProvider.ProfileCollectionFilePathChanged" />
        /// event if its value is updated.
        /// </remarks>
        string ProfileCollectionFilePath
        {
            get;
            set;
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
        /// Occurs when the value of the
        /// <see
        ///     cref="P:MFR.Settings.Profiles.Providers.Interfaces.IProfileProvider.ProfileCollectionFilePath" />
        /// property is updated.
        /// </summary>
        event EventHandler ProfileCollectionFilePathChanged;

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
        ///     cref="P:MFR.Settings.Profiles.Providers.Interfaces.IProfileProvider.ProfileCollectionFilePath" />
        /// property.
        /// </param>
        /// <remarks>
        /// If the
        /// <see
        ///     cref="P:MFR.Settings.Profiles.Providers.Interfaces.IProfileProvider.ProfileCollectionFilePath" />
        /// property is blank, then this method does nothing.
        /// </remarks>
        void Save(string pathname = "");

        /// <summary>
        /// This method is called in order to set the value of the
        /// </summary>
        void InitializeProfileCollectionFilePath(
            string companyName = "", string productName = "");
    }
}