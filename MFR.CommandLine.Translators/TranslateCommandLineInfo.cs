using MFR.CommandLine.Models.Interfaces;
using MFR.Settings.Configuration.Factories;
using MFR.Settings.Configuration.Interfaces;
using MFR.Settings.Configuration.Providers.Factories;
using MFR.Settings.Configuration.Providers.Interfaces;
using PostSharp.Patterns.Diagnostics;
using System;
using xyLOGIX.Core.Debug;

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
    /// <see
    ///     cref="T:MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfig" />
    /// interface, for example.
    /// </remarks>
    public static class TranslateCommandLineInfo
    {
        /// <summary>
        /// Gets a reference to the sole instance of the object that implements the
        /// <see
        ///     cref="T:MFR.Settings.Configuration.Providers.Interfaces.IProjectFileRenamerConfigProvider" />
        /// interface.
        /// </summary>
        /// <remarks>
        /// This object allows access to the user config and the
        /// actions
        /// associated with it.
        /// </remarks>
        private static IProjectFileRenamerConfigProvider ConfigProvider
            => GetProjectFileRenamerConfigProvider.SoleInstance();

        /// <summary>
        /// Gets or sets a reference to the one and only instance of the object that
        /// implements the
        /// <see
        ///     cref="T:MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfig" />
        /// interface that represents the currently-loaded config.
        /// </summary>
        private static IProjectFileRenamerConfig CurrentConfig
        {
            get => ConfigProvider.CurrentConfig;
            set => ConfigProvider.CurrentConfig = value;
        }

        /// <summary>
        /// Translates an instance of an object that implements the
        /// <see cref="T:MFR.CommandLine.Models.Interfaces.ICommandLineInfo" /> interface
        /// to an instance of an object that implements the
        /// <see
        ///     cref="T:MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfig" />
        /// interface.
        /// </summary>
        /// <param name="cmdInfo">
        /// (Required.) Reference to an instance of an object that implements the
        /// <see cref="T:MFR.CommandLine.Models.Interfaces.ICommandLineInfo" /> interface.
        /// </param>
        /// <returns>
        /// Reference to an instance of an object that implements the
        /// <see
        ///     cref="T:MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfig" />
        /// interface
        /// whose properties have been initialized with the values specified in the
        /// properties of the <paramref name="cmdInfo" /> object.
        /// </returns>
        public static IProjectFileRenamerConfig ToConfiguration(
            [NotLogged] this ICommandLineInfo cmdInfo
        )
        {
            IProjectFileRenamerConfig result = default;

            try
            {
                DebugUtils.WriteLine(
                    DebugLevel.Info,
                    "TranslateCommandLineInfo.ToConfiguration: Checking whether the 'cmdInfo' method parameter has a null reference for a value..."
                );

                // Check to see if the required parameter, cmdInfo, is null. If it is, send an 
                // error to the log file and quit, returning the default return value of this
                // method.
                if (cmdInfo == null)
                {
                    // the parameter cmdInfo is required.
                    DebugUtils.WriteLine(
                        DebugLevel.Error,
                        "TranslateCommandLineInfo.ToConfiguration: *** ERROR *** A null reference was passed for the 'cmdInfo' method parameter.  Stopping."
                    );

                    // stop.
                    return result;
                }

                DebugUtils.WriteLine(
                    DebugLevel.Info,
                    "TranslateCommandLineInfo.ToConfiguration: *** SUCCESS *** We have been passed a valid object reference for the 'cmdInfo' method parameter."
                );	 

                // Dump the property cmdInfo.StartingFolder to the log
                DebugUtils.WriteLine(
                    DebugLevel.Debug,
                    $"TranslateCommandLineInfo.ToConfiguration: cmdInfo.StartingFolder = '{cmdInfo.StartingFolder}'"
                );

                // Dump the value of the property, cmdInfo.FindWhat, to the log
                DebugUtils.WriteLine(
                    DebugLevel.Debug,
                    $"TranslateCommandLineInfo.ToConfiguration: cmdInfo.FindWhat = '{cmdInfo.FindWhat}'"
                );

                // Dump the value of the property, cmdInfo.ReplaceWith, to the log
                DebugUtils.WriteLine(
                    DebugLevel.Debug,
                    $"TranslateCommandLineInfo.ToConfiguration: cmdInfo.ReplaceWith = '{cmdInfo.ReplaceWith}'"
                );

                // Dump the value of the property, cmdInfo.RenameFilesInFolder, to the log
                DebugUtils.WriteLine(
                    DebugLevel.Debug,
                    $"TranslateCommandLineInfo.ToConfiguration: cmdInfo.RenameFilesInFolder = {cmdInfo.RenameFilesInFolder}"
                );

                // Dump the value of the property, cmdInfo.RenameSubFolders, to the log
                DebugUtils.WriteLine(
                    DebugLevel.Debug,
                    $"TranslateCommandLineInfo.ToConfiguration: cmdInfo.RenameSubFolders = {cmdInfo.RenameSubFolders}"
                );

                // Dump the value of the property, cmdInfo.ReplaceTextInFiles, to the log
                DebugUtils.WriteLine(
                    DebugLevel.Debug,
                    $"TranslateCommandLineInfo.ToConfiguration: cmdInfo.ReplaceTextInFiles = {cmdInfo.ReplaceTextInFiles}"
                );

                // Dump the value of the property, cmdInfo.RenameSolutionFolders, to the log
                DebugUtils.WriteLine(
                    DebugLevel.Debug,
                    $"TranslateCommandLineInfo.ToConfiguration: cmdInfo.RenameSolutionFolders = {cmdInfo.RenameSolutionFolders}"
                );

                // Dump the value of the property, cmdInfo.ReOpenSolution, to the log
                DebugUtils.WriteLine(
                    DebugLevel.Debug,
                    $"TranslateCommandLineInfo.ToConfiguration: cmdInfo.ReOpenSolution = {cmdInfo.ReOpenSolution}"
                );

                // Dump the value of the property, cmdInfo.AutoStart, to the log
                DebugUtils.WriteLine(
                    DebugLevel.Debug,
                    $"TranslateCommandLineInfo.ToConfiguration: cmdInfo.AutoStart = {cmdInfo.AutoStart}"
                );

                // Dump the value of the property, cmdInfo.ShouldCommitPostOperationChanges, to the log
                DebugUtils.WriteLine(
                    DebugLevel.Debug,
                    $"TranslateCommandLineInfo.ToConfiguration: cmdInfo.ShouldCommitPostOperationChanges = {cmdInfo.ShouldCommitPostOperationChanges}"
                );

                // Dump the value of the property, cmdInfo.ShouldCommitPendingChanges, to the log
                DebugUtils.WriteLine(
                    DebugLevel.Debug,
                    $"TranslateCommandLineInfo.ToConfiguration: cmdInfo.ShouldCommitPendingChanges = {cmdInfo.ShouldCommitPendingChanges}"
                );

                result = MakeNewProjectFileRenamerConfig
                         .FromScratch()
                         .ForStartingFolder(cmdInfo.StartingFolder)
                         .AndFindWhat(cmdInfo.FindWhat)
                         .AndReplaceWith(cmdInfo.ReplaceWith)
                         .ShouldRenameFilesInFolder(cmdInfo.RenameFilesInFolder)
                         .AndShouldRenameSubFolders(cmdInfo.RenameSubFolders)
                         .AndShouldReplaceTextInFiles(
                             cmdInfo.ReplaceTextInFiles
                         )
                         .AndShouldRenameSolutionFolders(
                             cmdInfo.RenameSolutionFolders
                         )
                         .AndShouldReOpenSolution(cmdInfo.ReOpenSolution)
                         .SetIsFromCommandLine(
                             true
                         ) // mark this as a command-line specified config
                         .ShouldAutoStart(cmdInfo.AutoStart)
                         .ShouldCommitPostOperationChanges(
                             cmdInfo.ShouldCommitPostOperationChanges
                         )
                         .ShouldCommitPendingChanges(
                             cmdInfo.ShouldCommitPendingChanges
                         );
            }
            catch (Exception ex)
            {
                // dump all the exception info to the log
                DebugUtils.LogException(ex);

                result = default;
            }

            return result;
        }
    }
}