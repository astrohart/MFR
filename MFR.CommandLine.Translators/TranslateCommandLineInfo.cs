using MFR.CommandLine.Models.Interfaces;
using MFR.Settings.Configuration.Interfaces;
using MFR.Settings.Configuration.Providers.Factories;
using MFR.Settings.Configuration.Providers.Interfaces;
using PostSharp.Patterns.Diagnostics;
using System;
using System.Diagnostics;
using xyLOGIX.Core.Debug;
using xyLOGIX.Core.Extensions.Actions;

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
        {
            [DebuggerStepThrough] get;
        } = GetProjectFileRenamerConfigProvider.SoleInstance();

        /// <summary>
        /// Gets or sets a reference to the one and only instance of the object that
        /// implements the
        /// <see
        ///     cref="T:MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfig" />
        /// interface that represents the currently-loaded config.
        /// </summary>
        private static IProjectFileRenamerConfig CurrentConfig
        {
            [DebuggerStepThrough] get => ConfigProvider.CurrentConfig;
            [DebuggerStepThrough] set => ConfigProvider.CurrentConfig = value;
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
        [return: NotLogged]
        public static IProjectFileRenamerConfig ToConfig(
            [NotLogged] this ICommandLineInfo cmdInfo
        )
        {
            var result = CurrentConfig;

            try
            {
                DebugUtils.WriteLine(
                    DebugLevel.Info,
                    "TranslateCommandLineInfo.ToConfig: Checking whether the 'cmdInfo' method parameter has a null reference for a value..."
                );

                // Check to see if the required parameter, cmdInfo, is null. If it is, send an
                // error to the log file and quit, returning the default return value of this
                // method.
                if (cmdInfo == null)
                {
                    // the parameter cmdInfo is required.
                    DebugUtils.WriteLine(
                        DebugLevel.Error,
                        "TranslateCommandLineInfo.ToConfig: *** ERROR *** A null reference was passed for the 'cmdInfo' method parameter.  Stopping."
                    );

                    // stop.
                    return result;
                }

                DebugUtils.WriteLine(
                    DebugLevel.Info,
                    "TranslateCommandLineInfo.ToConfig: *** SUCCESS *** We have been passed a valid object reference for the 'cmdInfo' method parameter."
                );

                CurrentConfig.AutoQuitOnCompletion = Prefer.BoolOverNull(
                    cmdInfo.AutoQuitOnCompletion,
                    CurrentConfig.AutoQuitOnCompletion
                );
                CurrentConfig.AutoStart = cmdInfo.AutoStart;
                CurrentConfig.FindWhat = Prefer.StringOverBlank(
                    cmdInfo.FindWhat, CurrentConfig.FindWhat
                );
                CurrentConfig.IsFromCommandLine = true;
                CurrentConfig.MatchCase = Prefer.BoolOverNull(
                    cmdInfo.MatchCase, CurrentConfig.MatchCase
                );
                CurrentConfig.MatchExactWord = Prefer.BoolOverNull(
                    cmdInfo.MatchExactWord, CurrentConfig.MatchExactWord
                );
                CurrentConfig.RenameFilesInFolder = Prefer.BoolOverNull(
                    cmdInfo.RenameFilesInFolder,
                    CurrentConfig.RenameFilesInFolder
                );
                CurrentConfig.RenameSubFolders = Prefer.BoolOverNull(
                    cmdInfo.RenameSubFolders, CurrentConfig.RenameSubFolders
                );
                CurrentConfig.ReplaceTextInFiles = Prefer.BoolOverNull(
                    cmdInfo.ReplaceTextInFiles, CurrentConfig.ReplaceTextInFiles
                );
                CurrentConfig.ReplaceWith = Prefer.StringOverBlank(
                    cmdInfo.ReplaceWith, CurrentConfig.ReplaceWith
                );
                CurrentConfig.RenameSolutionFolders = Prefer.BoolOverNull(
                    cmdInfo.RenameSolutionFolders,
                    CurrentConfig.RenameSolutionFolders
                );
                CurrentConfig.ReOpenSolution = Prefer.BoolOverNull(
                    cmdInfo.ReOpenSolution, CurrentConfig.ReOpenSolution
                );
                CurrentConfig.ShouldCommitPendingChanges = Prefer.BoolOverNull(
                    cmdInfo.ShouldCommitPendingChanges,
                    CurrentConfig.ShouldCommitPendingChanges
                );
                CurrentConfig.ShouldCommitPostOperationChanges =
                    Prefer.BoolOverNull(
                        cmdInfo.ShouldCommitPostOperationChanges,
                        CurrentConfig.ShouldCommitPostOperationChanges
                    );
                CurrentConfig.StartingFolder = Prefer.StringOverBlank(
                    cmdInfo.StartingFolder, CurrentConfig.StartingFolder
                );
                CurrentConfig.UpdateGitOnAutoStart = Prefer.BoolOverNull(
                    cmdInfo.UpdateGitOnAutoStart,
                    CurrentConfig.UpdateGitOnAutoStart
                );

                if (CurrentConfig.IsFromCommandLine &&
                    CurrentConfig.UpdateGitOnAutoStart &&
                    CurrentConfig.AutoStart)
                    CurrentConfig.ShouldCommitPendingChanges =
                        CurrentConfig.ShouldCommitPostOperationChanges =
                            CurrentConfig.PushChangesToRemoteWhenDone = true;

                result = CurrentConfig;
            }
            catch (Exception ex)
            {
                // dump all the exception info to the log
                DebugUtils.LogException(ex);

                result = CurrentConfig;
            }

            return result;
        }
    }
}