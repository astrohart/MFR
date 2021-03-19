using PostSharp.Patterns.Diagnostics;
using System;
using xyLOGIX.Core.Debug;

namespace MassFileRenamer.Objects
{
    /// <summary>
    /// Saves a configuration object, i.e., one that implements the
    /// <see
    ///     cref="T:MassFileRenamer.Objects.IConfiguration" />
    /// interface, to a JSON file.
    /// </summary>
    /// <remarks>
    /// This command takes a reference to an instance of an object that
    /// implements the <see cref="T:MassFileRenamer.Objects.IFileSystemEntry" />
    /// interface as input, and does not return any output.
    /// <para />
    /// This command requires that the
    /// <see
    ///     cref="P:MassFileRenamer.Objects.IFileSystemEntry.Path" />
    /// property be
    /// initialized to the pathname where the configuration data should be
    /// saved; preferably, the file should have the .json extension.
    /// <para />
    /// This command also requires that the
    /// <see
    ///     cref="P:MassFileRenamer.Objects.IFileSystemEntry.UserState" />
    /// property
    /// be initialized to a reference to the configuration object containing the
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
        ///     cref="T:MassFileRenamer.Objects.SavePathToRegistryAction" />
        /// .
        /// </summary>
        [Log(AttributeExclude = true)]
        public static SaveConfigurationToFileCommand Instance
        {
            get;
        } = new SaveConfigurationToFileCommand();

        /// <summary>
        /// Gets the <see cref="T:MassFileRenamer.Objects.MessageType" /> that is
        /// being used to identify which message this is.
        /// </summary>
        [Log(AttributeExclude = true)]
        public override MessageType MessageType
            => MessageType.SaveConfigurationToFile;

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
            // write the name of the current class and method we are now
            // entering, into the log
            DebugUtils.WriteLine(
                DebugLevel.Debug,
                "In SaveConfigurationToFileCommand.CommonExecute"
            );

            /*
             * OKAY, so here, the _input field is of type IFileSystemEntry.  We assume
             * that it is referencing a valid object (not null) and that its Path property
             * points to the pathname of the file to which the configuration data should
             * be saved.  Furthermore, we assume its UserState property has been initialized
             * with a reference to the configuration data that is to be saved.
             */

            DebugUtils.WriteLine(
                DebugLevel.Info,
                "*** INFO: Checking whether the '_input' field has a null reference for a value..."
            );

            // Check to see if the required field, _input, is null. If it is, send an 
            // error to the log file and quit.
            if (_input == null)
            {
                // the field _input is required.
                DebugUtils.WriteLine(
                    DebugLevel.Error,
                    "*** ERROR: The _input field has a null reference.  This field is required."
                );

                DebugUtils.WriteLine(DebugLevel.Debug, "SaveConfigurationToFileCommand.CommonExecute: Done.");

                // stop.
                return;
            }

            DebugUtils.WriteLine(
                DebugLevel.Info,
                "*** SUCCESS *** The _input field has a valid object reference for its value."
            );

            DebugUtils.WriteLine(
                DebugLevel.Info,
                $"*** INFO: Checking whether the value of the '_input.Path' property is blank..."
            );

            if (string.IsNullOrWhiteSpace(_input.Path))
            {
                DebugUtils.WriteLine(
                    DebugLevel.Error,
                    "SaveConfigurationToFileCommand.CommonExecute: Blank value passed for the '_input.Path' property. This property is required."
                );

                DebugUtils.WriteLine(DebugLevel.Debug, "SaveConfigurationToFileCommand.CommonExecute: Done.");

                return;
            }

            DebugUtils.WriteLine(
                DebugLevel.Info,
                $"*** SUCCESS *** The property '_input.Path' is not blank.  Continuing..."
            );

            DebugUtils.WriteLine(
                DebugLevel.Info,
                "*** INFO: Checking whether the _input.UserState property has a null reference for a value..."
            );

            // Check to see if the required property, _input.UserState, is null. If it is, send an 
            // error to the log file and quit.
            if (_input.UserState == null)
            {
                // the property _input.UserState is required.
                DebugUtils.WriteLine(
                    DebugLevel.Error,
                    "*** ERROR: The _input.UserState property has a null reference.  This property is required."
                );

                DebugUtils.WriteLine(DebugLevel.Debug, "SaveConfigurationToFileCommand.CommonExecute: Done.");

                // stop.
                return;
            }

            DebugUtils.WriteLine(
                DebugLevel.Info,
                "*** SUCCESS *** The _input.UserState property has a valid object reference for its value."
            );

            try
            {
                ConfigurationSerializer.Save(
                    _input.Path, _input.UserState as IConfiguration
                );
            }
            catch (Exception ex)
            {
                // dump all the exception info to the log
                DebugUtils.LogException(ex);
            }

            DebugUtils.WriteLine(
                DebugLevel.Debug,
                "SaveConfigurationToFileCommand.CommonExecute: Done."
            );
        }
    }
}