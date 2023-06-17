using MFR.Expressions.Registry.Interfaces;
using MFR.FileSystem.Interfaces;
using MFR.Messages.Actions.Interfaces;
using MFR.Messages.Commands.Interfaces;
using MFR.Metadata.Registry.Interfaces;
using MFR.Settings.Configuration.Actions.Constants;
using MFR.Settings.Configuration.Commands.Constants;
using System;
using xyLOGIX.Core.Debug;

namespace MFR.Paths.Config.Provider.Actions
{
    /// <summary>
    /// Exposes static methods for executing operations associated with loading and
    /// storing information about the user's favorite configuration-setting profiles.
    /// </summary>
    public static class Execute
    {
        /// <summary>
        /// Executes the operation to fetch the fully-qualified pathname of the
        /// <c>config.json</c> file from the system Registry, if it is configured.
        /// </summary>
        /// <param name="action">
        /// (Required.) Reference to an instance of an object that
        /// implements the
        /// <see cref="T:MFR.Messages.Actions.Interfaces.IAction{TInput, TResult}" />
        /// interface that represents the operation that is to be executed.
        /// </param>
        /// <returns>
        /// Reference to an instance of an object that implements the
        /// <see cref="T:MFR.FileSystem.Interfaces.IFileSystemEntry" /> interface that
        /// should contain the pathname of the <c>config.json</c> file; or
        /// <see langword="null" /> if the pathname could not be read.
        /// </returns>
        public static IFileSystemEntry
            OperationToLoadConfigFilePathFromRegistry(
                IAction<IRegQueryExpression<string>, IFileSystemEntry> action
            )
        {
            IFileSystemEntry result = default;

            try
            {
                if (action == null) return result;
                if (action.MessageType !=
                    ConfigActionType.LoadConfigFilePathFromRegistry)
                    return result;

                result = action.Execute();
            }
            catch (Exception ex)
            {
                // dump all the exception info to the log
                DebugUtils.LogException(ex);

                result = default;
            }

            return result;
        }

        /// <summary>
        /// Executes a <c>Command</c> that saves the pathname of the application
        /// configuration file to the system Registry.
        /// </summary>
        /// <param name="command">
        /// (Required.) Reference to an instance of an object that
        /// implements the
        /// <see cref="T:MFR.Messages.Commands.Interfaces.ICommand{TInput}" /> interface
        /// that, when executed, saves the pathname of the application configuration file
        /// to the system Registry..
        /// </param>
        public static void OperationToSaveConfigFilePathToRegistry(
            ICommand<IRegOperationMetadata<string>> command
        )
        {
            try
            {
                if (command == null) return;
                if (command.MessageType != ConfigurationCommandType
                        .SaveConfigurationFilePathToRegistry)
                    return;

                command.Execute();
            }
            catch (Exception ex)
            {
                // dump all the exception info to the log
                DebugUtils.LogException(ex);
            }
        }
    }
}