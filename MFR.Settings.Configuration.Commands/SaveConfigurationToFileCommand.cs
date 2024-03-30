using MFR.FileSystem.Interfaces;
using MFR.Messages.Commands;
using MFR.Messages.Constants;
using MFR.Settings.Configuration.Commands.Constants;
using MFR.Settings.Configuration.Interfaces;
using MFR.Settings.Configuration.Serializers;
using PostSharp.Patterns.Diagnostics;
using System;
using xyLOGIX.Core.Debug;

namespace MFR.Settings.Configuration.Commands
{
    /// <summary>
    /// Saves a config object, i.e., one that implements the
    /// <see
    ///     cref="T:MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfig" />
    /// interface, to a JSON file.
    /// </summary>
    /// <remarks>
    /// This command takes a reference to an instance of an object that
    /// implements the <see cref="T:MFR.FileSystem.Interfaces.IFileSystemEntry" />
    /// interface as input, and does not return any output.
    /// <para />
    /// This command requires that the
    /// <see
    ///     cref="P:MFR.IFileSystemEntry.Path" />
    /// property be
    /// initialized to the pathname where the config data should be
    /// saved; preferably, the file should have the .json extension.
    /// <para />
    /// This command also requires that the
    /// <see
    ///     cref="P:MFR.IFileSystemEntry.UserState" />
    /// property
    /// be initialized to a reference to the config object containing the
    /// data that is to be saved.
    /// </remarks>
    public class SaveConfigurationToFileCommand : CommandBase<IFileSystemEntry>
    {
        /// <summary>
        /// Empty, static constructor to prohibit direct allocation of this class.
        /// </summary>
        [Log(AttributeExclude = true)]
        static SaveConfigurationToFileCommand() { }

        /// <summary>
        /// Empty, protected constructor to prohibit direct allocation of this class.
        /// </summary>
        [Log(AttributeExclude = true)]
        protected SaveConfigurationToFileCommand() { }

        /// <summary>
        /// Gets a reference to the one and only instance of
        /// <see
        ///     cref="T:MFR.SavePathToRegistryAction" />
        /// .
        /// </summary>
        [Log(AttributeExclude = true)]
        public static SaveConfigurationToFileCommand Instance
        {
            get;
        } = new SaveConfigurationToFileCommand();

        /// <summary>
        /// Gets the <see cref="T:MFR.MessageType" /> that is
        /// being used to identify which message this.
        /// </summary>
        [Log(AttributeExclude = true)]
        public override MessageType MessageType
            => ConfigurationCommandType.SaveConfigurationToFile;

        /// <summary>
        /// Executes this command and does not return anything.
        /// </summary>
        /// <remarks>
        /// Implementers must override this method in order to return this
        /// object's functionality.
        /// <para />
        /// This method is to stop executing, without throwing any exceptions,
        /// if the input is <see langword="null" />.
        /// </remarks>
        protected override void CommonExecute()
        {
            /*
             * OKAY, so here, the _input field is of type IFileSystemEntry.  We assume
             * that it is referencing a valid object (not null) and that its Path property
             * points to the pathname of the file to which the config data should
             * be saved.  Furthermore, we assume its UserState property has been initialized
             * with a reference to the config data that is to be saved.
             */

            // Check to see if the required field, _input, is null. If it is, send an
            if (Input == null) return;

            if (string.IsNullOrWhiteSpace(Input.Path)) return;

            // Check to see if the required property, _input.UserState, is null. If it is, send an
            // to the config data that needs saving.
            if (Input.UserState == null) return;

            try
            {
                ConfigurationSerializer.Save(
                    Input.Path, Input.UserState as IProjectFileRenamerConfig
                );
            }
            catch (Exception ex)
            {
                // dump all the exception info to the log
                DebugUtils.LogException(ex);
            }
        }
    }
}
