using MFR.Events.Common;
using System;
using System.ComponentModel;

namespace MFR.Paths.Config.Provider.Interfaces
{
    /// <summary>
    /// Defines the publicly-exposed methods and properties of an object that provides
    /// access to the fully-qualified pathname of the application configuration file.
    /// </summary>
    public interface IConfigPathProvider
    {
        /// <summary>
        /// Gets a string whose value is the fully-qualified pathname of the application configuration file.
        /// </summary>
        /// <remarks>
        /// When this property's value is updated, the
        /// <see
        ///     cref="E:MFR.Paths.Config.Provider.Interfaces.IConfigPathProvider.ConfigFilePathChanged" />
        /// event  is raised.
        /// </remarks>
        string ConfigFilePath
        {
            get;
            set;
        }

        /// <summary>
        /// Occurs when the process of loading the value of the
        /// <see
        ///     cref="P:MFR.Paths.Config.Provider.Interfaces.IConfigPathProvider.ConfigFilePath" />
        /// property from the system Registry is about to begin.
        /// </summary>
        event CancelEventHandler LoadingConfigFilePath;

        /// <summary>
        /// Occurs when the value of the
        /// <see
        ///     cref="P:MFR.Paths.Config.Provider.Interfaces.IConfigPathProvider.ConfigFilePath" />
        /// property is updated.
        /// </summary>
        event EventHandler ConfigFilePathChanged;

        /// <summary>
        /// Occurs when the value of the
        /// <see
        ///     cref="P:MFR.Paths.Config.Provider.Interfaces.IConfigPathProvider.ConfigFilePath" />
        /// property has been loaded from the system Registry.
        /// </summary>
        event EventHandler ConfigFilePathLoaded;

        /// <summary>
        /// Occurs when the process of loading the value of the
        /// <see
        ///     cref="P:MFR.Paths.Config.Provider.Interfaces.IConfigPathProvider.ConfigFilePath" />
        /// property from the system Registry has failed.
        /// </summary>
        event ExceptionRaisedEventHandler ConfigFilePathLoadFailed;

        /// <summary>
        /// Occurs when the value of the
        /// <see
        ///     cref="P:MFR.Paths.Config.Provider.Interfaces.IConfigPathProvider.ConfigFilePath" />
        /// property has been saved to the system Registry.
        /// </summary>
        event EventHandler ConfigFilePathSaved;

        /// <summary>
        /// Occurs when the process of saving the value of the
        /// <see
        ///     cref="P:MFR.Paths.Config.Provider.Interfaces.IConfigPathProvider.ConfigFilePath" />
        /// property to the system Registry has failed.
        /// </summary>
        event ExceptionRaisedEventHandler ConfigFilePathSaveFailed;

        /// <summary>
        /// Occurs when the process of saving the value of the
        /// <see
        ///     cref="P:MFR.Paths.Config.Provider.Interfaces.IConfigPathProvider.ConfigFilePath" />
        /// property to the system Registry is about to begin.
        /// </summary>
        event CancelEventHandler SavingConfigFilePath;

        /// <summary>
        /// Loads the value of the
        /// <see
        ///     cref="P:MFR.Paths.Config.Provider.Interfaces.IConfigPathProvider.ConfigFilePath" />
        /// property from the system Registry.
        /// </summary>
        /// <remarks>
        /// The
        /// <see
        ///     cref="E:MFR.Paths.Config.Provider.Interfaces.IConfigPathProvider.LoadingConfigFilePath" />
        /// event is raised before this method begins its operations.  Setting the
        /// <see cref="P:System.ComponentModel.CancelEventArgs.Cancel" /> property to
        /// <see langword="true" /> on this event will prevent this method from executing
        /// further.
        /// <para />
        /// If the operation of obtaining the value of the
        /// <see
        ///     cref="P:MFR.Paths.Config.Provider.Interfaces.IConfigPathProvider.ConfigFilePath" />
        /// property from the system Registry was successful, then the
        /// <see
        ///     cref="E:MFR.Paths.Config.Provider.Interfaces.IConfigPathProvider.ConfigFilePathLoaded" />
        /// event is raised.
        /// <para />
        /// Otherwise, if a <see cref="T:System.Exception" /> is raised during the
        /// processing of the operation, then this method raises the
        /// <see
        ///     cref="E:MFR.Paths.Config.Provider.Interfaces.IConfigPathProvider.ConfigFilePathLoadFailed" />
        /// event.
        /// </remarks>
        void Load();

        /// <summary>
        /// Saves the value of the
        /// <see
        ///     cref="P:MFR.Paths.Config.Provider.Interfaces.IConfigPathProvider.ConfigFilePath" />
        /// property to the system Registry.
        /// </summary>
        /// <remarks>
        /// The
        /// <see
        ///     cref="E:MFR.Paths.Config.Provider.Interfaces.IConfigPathProvider.SavingConfigFilePath" />
        /// event is raised before this method begins its operations.  Setting the
        /// <see cref="P:System.ComponentModel.CancelEventArgs.Cancel" /> property to
        /// <see langword="true" /> on this event will prevent this method from executing
        /// further.
        /// <para />
        /// If the operation of storing the value of the
        /// <see
        ///     cref="P:MFR.Paths.Config.Provider.Interfaces.IConfigPathProvider.ConfigFilePath" />
        /// property to the system Registry was successful, then the
        /// <see
        ///     cref="E:MFR.Paths.Config.Provider.Interfaces.IConfigPathProvider.ConfigFilePathSaved" />
        /// event is raised.
        /// <para />
        /// Otherwise, if a <see cref="T:System.Exception" /> is raised during the
        /// processing of the operation, then this method raises the
        /// <see
        ///     cref="E:MFR.Paths.Config.Provider.Interfaces.IConfigPathProvider.ConfigFilePathSaveFailed" />
        /// event.
        /// </remarks>
        void Save();
    }
}