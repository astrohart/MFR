using MFR.Events.Common;
using System;
using System.ComponentModel;

namespace MFR.Paths.Profiles.Provider.Interfaces
{
    /// <summary>
    /// Defines the publicly-exposed methods and properties of an object that provides
    /// access to the fully-qualified pathname of the list of the user's favorite
    /// configuration-setting profiles.
    /// </summary>
    public interface IProfileListPathProvider
    {
        /// <summary>
        /// Gets a string whose value is the fully-qualified pathname of the profile list
        /// file.
        /// </summary>
        /// <remarks>
        /// When this property's value is updated, the
        /// <see
        ///     cref="E:MFR.Paths.Profiles.Provider.Interfaces.IProfileListPathProvider.ProfileCollectionFilePathChanged" />
        /// event  is raised.
        /// </remarks>
        string ProfileCollectionFilePath
        {
            get;
            set;
        }

        /// <summary>
        /// Occurs when the process of loading the value of the
        /// <see
        ///     cref="P:MFR.Paths.Profiles.Provider.Interfaces.IProfileListPathProvider.ProfileCollectionFilePath" />
        /// property from the system Registry is about to begin.
        /// </summary>
        event CancelEventHandler LoadingProfileCollectionFilePath;

        /// <summary>
        /// Occurs when the value of the
        /// <see
        ///     cref="P:MFR.Paths.Profiles.Provider.Interfaces.IProfileListPathProvider.ProfileCollectionFilePath" />
        /// property is updated.
        /// </summary>
        event EventHandler ProfileCollectionFilePathChanged;

        /// <summary>
        /// Occurs when the value of the
        /// <see
        ///     cref="P:MFR.Paths.Profiles.Provider.Interfaces.IProfileListPathProvider.ProfileCollectionFilePath" />
        /// property has been loaded from the system Registry.
        /// </summary>
        event EventHandler ProfileCollectionFilePathLoaded;

        /// <summary>
        /// Occurs when the process of loading the value of the
        /// <see
        ///     cref="P:MFR.Paths.Profiles.Provider.Interfaces.IProfileListPathProvider.ProfileCollectionFilePath" />
        /// property from the system Registry has failed.
        /// </summary>
        event ExceptionRaisedEventHandler ProfileCollectionFilePathLoadFailed;

        /// <summary>
        /// Occurs when the value of the
        /// <see
        ///     cref="P:MFR.Paths.Profiles.Provider.Interfaces.IProfileListPathProvider.ProfileCollectionFilePath" />
        /// property has been saved to the system Registry.
        /// </summary>
        event EventHandler ProfileCollectionFilePathSaved;

        /// <summary>
        /// Occurs when the process of saving the value of the
        /// <see
        ///     cref="P:MFR.Paths.Profiles.Provider.Interfaces.IProfileListPathProvider.ProfileCollectionFilePath" />
        /// property to the system Registry has failed.
        /// </summary>
        event ExceptionRaisedEventHandler ProfileCollectionFilePathSaveFailed;

        /// <summary>
        /// Occurs when the process of saving the value of the
        /// <see
        ///     cref="P:MFR.Paths.Profiles.Provider.Interfaces.IProfileListPathProvider.ProfileCollectionFilePath" />
        /// property to the system Registry is about to begin.
        /// </summary>
        event CancelEventHandler SavingProfileCollectionFilePath;

        /// <summary>
        /// Loads the value of the
        /// <see
        ///     cref="P:MFR.Paths.Profiles.Provider.Interfaces.IProfileListPathProvider.ProfileCollectionFilePath" />
        /// property from the system Registry.
        /// </summary>
        /// <remarks>
        /// The
        /// <see
        ///     cref="E:MFR.Paths.Profiles.Provider.Interfaces.IProfileListPathProvider.LoadingProfileCollectionFilePath" />
        /// event is raised before this method begins its operations.  Setting the
        /// <see cref="P:System.ComponentModel.CancelEventArgs.Cancel" /> property to
        /// <see langword="true" /> on this event will prevent this method from executing
        /// further.
        /// <para />
        /// If the operation of obtaining the value of the
        /// <see
        ///     cref="P:MFR.Paths.Profiles.Provider.Interfaces.IProfileListPathProvider.ProfileCollectionFilePath" />
        /// property from the system Registry was successful, then the
        /// <see
        ///     cref="E:MFR.Paths.Profiles.Provider.Interfaces.IProfileListPathProvider.ProfileCollectionFilePathLoaded" />
        /// event is raised.
        /// <para />
        /// Otherwise, if a <see cref="T:System.Exception" /> is raised during the
        /// processing of the operation, then this method raises the
        /// <see
        ///     cref="E:MFR.Paths.Profiles.Provider.Interfaces.IProfileListPathProvider.ProfileCollectionFilePathLoadFailed" />
        /// event.
        /// </remarks>
        void Load();

        /// <summary>
        /// Saves the value of the
        /// <see
        ///     cref="P:MFR.Paths.Profiles.Provider.Interfaces.IProfileListPathProvider.ProfileCollectionFilePath" />
        /// property to the system Registry.
        /// </summary>
        /// <remarks>
        /// The
        /// <see
        ///     cref="E:MFR.Paths.Profiles.Provider.Interfaces.IProfileListPathProvider.SavingProfileCollectionFilePath" />
        /// event is raised before this method begins its operations.  Setting the
        /// <see cref="P:System.ComponentModel.CancelEventArgs.Cancel" /> property to
        /// <see langword="true" /> on this event will prevent this method from executing
        /// further.
        /// <para />
        /// If the operation of storing the value of the
        /// <see
        ///     cref="P:MFR.Paths.Profiles.Provider.Interfaces.IProfileListPathProvider.ProfileCollectionFilePath" />
        /// property to the system Registry was successful, then the
        /// <see
        ///     cref="E:MFR.Paths.Profiles.Provider.Interfaces.IProfileListPathProvider.ProfileCollectionFilePathSaved" />
        /// event is raised.
        /// <para />
        /// Otherwise, if a <see cref="T:System.Exception" /> is raised during the
        /// processing of the operation, then this method raises the
        /// <see
        ///     cref="E:MFR.Paths.Profiles.Provider.Interfaces.IProfileListPathProvider.ProfileCollectionFilePathSaveFailed" />
        /// event.
        /// </remarks>
        void Save();
    }
}