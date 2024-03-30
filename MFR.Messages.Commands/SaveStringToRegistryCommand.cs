using MFR.Messages.Constants;
using MFR.Metadata.Registry.Interfaces;
using MFR.Registry.Writers.Factories;
using MFR.Settings.Configuration.Commands.Constants;
using PostSharp.Patterns.Diagnostics;
using System;
using xyLOGIX.Core.Debug;

namespace MFR.Messages.Commands
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
        ///     cref="T:MFR.SavePathToRegistryAction" />
        /// .
        /// </summary>
        [Log(AttributeExclude = true)]
        public static SaveStringToRegistryCommand Instance
        {
            get;
        } = new SaveStringToRegistryCommand();

        /// <summary>
        /// Gets the <see cref="T:MFR.MessageType" /> that is
        /// being used to identify which message this.
        /// </summary>
        [Log(AttributeExclude = true)]
        public override MessageType MessageType
            => ConfigurationCommandType.SaveConfigurationFilePathToRegistry;

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
            // Check to see if the required field, _input, is null. If it is,
            if (Input == null)

                // the field _input is required.
                // stop.
                return;

            // Check to see if the required property, _input.Value, is null. If
            if (string.IsNullOrWhiteSpace(Input.Value))

                // the property _input.Value is required.
                // stop.
                return;
            try
            {
                Write.String.ToRegistry(
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