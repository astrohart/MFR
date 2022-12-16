using MFR.CommandLine.Models.Interfaces;
using MFR.Settings.Configuration.Factories;
using MFR.Settings.Configuration.Interfaces;
using MFR.Settings.Configuration.Providers.Factories;
using MFR.Settings.Configuration.Providers.Interfaces;
using System;

namespace MFR.CommandLine.Translators
{
    /// <summary>
    /// Exposes extension methods for objects that implement the
    /// <see cref="T:MFR.CommandLine.Models.Interfaces.ICommandLineInfo" /> interface.
    /// </summary>
    /// <remarks>
    /// The methods in this class translate objects that implement the
    /// <see cref="T:MFR.CommandLine.Models.Interfaces.ICommandLineInfo" /> interface
    /// into instances of objects of other types, such as an instance of an object that
    /// implements the
    /// <see cref="T:MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfiguration" />
    /// interface, for example.
    /// </remarks>
    public static class TranslateCommandLineInfo
    {
        /// <summary>
        /// Gets a reference to the sole instance of the object that implements the
        /// <see
        ///     cref="T:MFR.Settings.Configuration.Providers.Interfaces.IProjectFileRenamerConfigurationProvider" />
        /// interface.
        /// </summary>
        /// <remarks>
        /// This object allows access to the user projectFileRenamerConfiguration and the
        /// actions
        /// associated with it.
        /// </remarks>
        private static IProjectFileRenamerConfigurationProvider
            ConfigurationProvider
            => GetProjectFileRenamerConfigurationProvider.SoleInstance();

        /// <summary>
        /// Gets or sets a reference to the one and only instance of the object that
        /// implements the
        /// <see
        ///     cref="T:MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfiguration" />
        /// interface that represents the currently-loaded configuration.
        /// </summary>
        private static IProjectFileRenamerConfiguration CurrentConfiguration
        {
            get => ConfigurationProvider.CurrentConfiguration;
            set => ConfigurationProvider.CurrentConfiguration = value;
        }
        
        /// <summary>
        /// Translates an instance of an object that implements the
        /// <see cref="T:MFR.CommandLine.Models.Interfaces.ICommandLineInfo" /> interface
        /// to an instance of an object that implements the
        /// <see cref="T:MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfiguration" />
        /// interface.
        /// </summary>
        /// <param name="cmdInfo">
        /// (Required.) Reference to an instance of an object that implements the
        /// <see cref="T:MFR.CommandLine.Models.Interfaces.ICommandLineInfo" /> interface.
        /// </param>
        /// <returns>
        /// Reference to an instance of an object that implements the
        /// <see cref="T:MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfiguration" /> interface
        /// whose properties have been initialized with the values specified in the
        /// properties of the <paramref name="cmdInfo" /> object.
        /// </returns>
        public static IProjectFileRenamerConfiguration ToConfiguration(
            this ICommandLineInfo cmdInfo)
        {
            if (cmdInfo == null)
                throw new ArgumentNullException(nameof(cmdInfo));

            return CurrentConfiguration
                                       .ForStartingFolder(
                                           cmdInfo.StartingFolder
                                       )
                                       .AndFindWhat(cmdInfo.FindWhat)
                                       .AndReplaceWith(cmdInfo.ReplaceWith)
                                       .SetRenameFilesTo(cmdInfo.RenameFiles)
                                       .AndSetRenameSubFoldersTo(
                                           cmdInfo.RenameSubFolders
                                       )
                                       .AndSetReplaceTextInFilesTo(
                                           cmdInfo.ReplaceTextInFiles
                                       )
                                       .AndShouldReOpenSolution(
                                           cmdInfo.ReOpenSolution
                                       )
                                       .SetIsFromCommandLine(true)  // flag the configuration as being from the command line
                                       .ShouldAutoStart(
                                           cmdInfo.AutoStart
                                       ); // mark this as a command-line specified projectFileRenamerConfiguration
        }
    }
}