﻿using PostSharp.Patterns.Diagnostics;
using System;
using xyLOGIX.Core.Debug;

namespace MassFileRenamer.Objects
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
        ///     cref="T:MassFileRenamer.Objects.SavePathToRegistryAction" />
        /// .
        /// </summary>
        [Log(AttributeExclude = true)]
        public static SaveStringToRegistryCommand Instance
        {
            get;
        } = new SaveStringToRegistryCommand();

        /// <summary>
        /// Gets the <see cref="T:MassFileRenamer.Objects.MessageType" /> that is
        /// being used to identify which message this is.
        /// </summary>
        [Log(AttributeExclude = true)]
        public override MessageType MessageType
            => MessageType.SaveStringToRegistry;

        /// <summary>
        /// Executes this command and does not return anything.
        /// </summary>
        /// <remarks>
        /// Implementers must override this method in order to return this
        /// object's functionality.
        /// <para />
        /// This method is to stop executing, without throwing any exceptions,
        /// if the input is <c>null</c>.
        /// </remarks>
        protected override void CommonExecute()
        {
            DebugUtils.WriteLine(
                DebugLevel.Info,
                "*** INFO: Checking whether the _input field has a null reference for a value..."
            );

            // Check to see if the required field, _input, is null. If it is,
            // send an error to the log file and quit.
            if (_input == null)
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
            if (string.IsNullOrWhiteSpace(_input.Value))
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
                $"SavePathToRegistryCommand.Execute: _input.KeyPath = '{_input.KeyPath}'"
            );

            // Dump the variable _input.ValueName to the log
            DebugUtils.WriteLine(
                DebugLevel.Debug,
                $"SavePathToRegistryCommand.Execute: _input.ValueName = '{_input.ValueName}'"
            );

            // Dump the variable _input.Value to the log
            DebugUtils.WriteLine(
                DebugLevel.Debug,
                $"SavePathToRegistryCommand.Execute: _input.Value = '{_input.Value}'"
            );

            try
            {
                SystemPreparer.SetRegistryString(
                    _input.KeyPath, _input.ValueName, _input.Value
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