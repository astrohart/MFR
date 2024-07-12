using MFR.Events.Common;
using MFR.Settings.Profiles.Collections.Interfaces;
using System;
using System.ComponentModel;

namespace MFR.Settings.Profiles.Providers.Interfaces
{
    /// <summary>
    /// Defines the publicly-exposed methods and properties of an object that manages
    /// the user's saved configuration-settings profiles..
    /// </summary>
    public interface IProfileProvider
    {
        /// <summary>
        /// Gets or sets the fully-qualified pathname of the <c>profiles.json</c> file.
        /// </summary>
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
        /// Occurs when we are about to begin the process of loading the user's saved
        /// configuration-setting profiles from the data source.
        /// </summary>
        event CancelEventHandler LoadingProfiles;

        /// <summary>
        /// Occurs when the value of the
        /// <see
        ///     cref="P:MFR.Settings.Profiles.Providers.Interfaces.IProfileProvider.ProfileCollectionFilePath" />
        /// property is updated.
        /// </summary>
        event EventHandler ProfileCollectionFilePathChanged;

        /// <summary>
        /// Occurs when loading the collection of profiles has failed.
        /// </summary>
        event ExceptionRaisedEventHandler ProfileLoadFailed;

        /// <summary>
        /// Occurs when saving the collection of profiles has failed.
        /// </summary>
        event EventHandler ProfileSaveFailed;

        /// <summary>
        /// Occurs when the collection of profiles has been loaded successfully.
        /// </summary>
        event EventHandler ProfilesLoaded;

        /// <summary>
        /// Occurs when the collection of profiles has been saved successfully.
        /// </summary>
        event EventHandler ProfilesSaved;

        /// <summary>
        /// Occurs when we are about to begin the process of saving the user's saved
        /// configuration-setting profiles from the data source.
        /// </summary>
        event CancelEventHandler SavingProfiles;

        /// <summary>
        /// Loads the profiles from the profile list file.
        /// </summary>
        void Load();

        /// <summary>
        /// Saves profile list data to a file on the file system having path
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
    }
}