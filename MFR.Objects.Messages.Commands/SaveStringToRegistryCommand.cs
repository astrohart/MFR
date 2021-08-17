using MFR.Objects.Configuration.Commands.Constants;
using MFR.Objects.Messages.Constants;
using MFR.Objects.Metadata.Registry.Interfaces;
using MFR.Objects.System;
using PostSharp.Patterns.Diagnostics;
using System;
using xyLOGIX.Core.Debug;

namespace MFR.Objects.Messages.Commands
{
    /// <summary>
    /// Saves a string to a key in the system Registry.
    /// </summary>
    public class SaveStringToRegistryCommand : CommandBase<
        IRegOperationMetadata<string>>
    {
        /// <summary>
        /// Empty, static constructor to prohibit direct allocation of this class.
        /// </summary>
        [Log(AttributeExclude = true)]
        static SaveStringToRegistryCommand() { }

        /// <summary>
        /// Empty, protected constructor to prohibit direct allocation of this class.
        /// </summary>
        [Log(AttributeExclude = true)]
        protected SaveStringToRegistryCommand() { }

        /// <summary>
        /// Gets a reference to the one and only instance of
        /// <see
        ///     cref="T:MFR.Objects.SavePathToRegistryAction" />
        /// .
        /// </summary>
        [Log(AttributeExclude = true)]
        public static SaveStringToRegistryCommand Instance
        {
            get;
        } = new SaveStringToRegistryCommand();

        /// <summary>
        /// Gets the <see cref="T:MFR.Objects.MessageType" /> that is
        /// being used to identify which message this is.
        /// </summary>
        [Log(AttributeExclude = true)]
        public override MessageType MessageType
            => ConfigurationCommand.SaveConfigurationFilePathToRegistry;

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
            DebugUtils.WriteLine(
                DebugLevel.Info,
                "*** INFO: Checking whether the _input field has a null reference for a value..."
            );

            // Check to see if the required field, _input, is null. If it is,
            // send an error to the log file and quit.
            if (Input == null)
            {
                // the field _input is required.
                DebugUtils.WriteLine(
                    DebugLevel.Error,
                    "*** ERROR: The _input field has a null reference.  This field is required."
                );

                // stop.
                return;
            }

            DebugUtils.WriteLine(
                DebugLevel.Info,
                "*** SUCCESS *** The _input field has a valid object reference for its value."
            );

            DebugUtils.WriteLine(
                DebugLevel.Info,
                "*** INFO: Checking whether the _input.Value property has a null reference for a value..."
            );

            // Check to see if the required property, _input.Value, is null. If
            // it is, send an error to the log file and quit.
            if (string.IsNullOrWhiteSpace(Input.Value))
            {
                // the property _input.Value is required.
                DebugUtils.WriteLine(
                    DebugLevel.Error,
                    "*** ERROR: The _input.Value property has a null reference.  This property is required."
                );

                // stop.
                return;
            }

            DebugUtils.WriteLine(
                DebugLevel.Info,
                "*** SUCCESS *** The _input.Value property has a valid object reference for its value."
            );

            // Dump the variable _input.KeyPath to the log
            DebugUtils.WriteLine(
                DebugLevel.Debug,
                $"SavePathToRegistryCommand.Execute: _input.KeyPath = '{Input.KeyPath}'"
            );

            // Dump the variable _input.ValueName to the log
            DebugUtils.WriteLine(
                DebugLevel.Debug,
                $"SavePathToRegistryCommand.Execute: _input.ValueName = '{Input.ValueName}'"
            );

            // Dump the variable _input.Value to the log
            DebugUtils.WriteLine(
                DebugLevel.Debug,
                $"SavePathToRegistryCommand.Execute: _input.Value = '{Input.Value}'"
            );

            try
            {
                SystemPreparer.SetRegistryString(
                    Input.KeyPath, Input.ValueName, Input.Value
                );
            }
            catch (Exception ex)
            {
                // dump all the exception info to the log
                DebugUtils.LogException(ex);
            }

            return;
        }
    }
}