using MFR.Settings.Configuration.Commands.Constants;
using MFR.Messages.Commands.Interfaces;
using MFR.Messages.Constants;
using MFR.Metadata.Registry.Factories;
using MFR.Metadata.Registry.Interfaces;
using System;

namespace MFR.Settings.Configuration.Commands.Factories
{
    /// <summary>
    /// Gets a reference to an instance of an object that implements the
    /// <see
    ///     cref="T:MFR.ICommand" />
    /// interface and provides access to the
    /// operation of saving the path of a configuration file to the system Registry.
    /// </summary>
    public static class GetSaveConfigPathCommand
    {
        /// <summary>
        /// Provides access to the <see cref="T:MFR.ICommand" />
        /// -derived object that allows saving the pathname of a configuration
        /// file to the system Registry.
        /// </summary>
        /// <param name="keyPath">
        /// (Required.) String containing the path to the key in the system
        /// Registry under which the config file's pathname is to be saved.
        /// </param>
        /// <param name="valueName">
        /// (Required.) String containing the name of the value under the
        /// Registry key where the config file's pathname is to be saved.
        /// </param>
        /// <param name="value">
        /// (Required.) Fully-qualified pathname that is to be saved in the
        /// system Registry. This value can, optionally, be surrounded by double
        /// quotation marks, which become mandatory in the case that the path
        /// contains spaces.
        /// </param>
        /// <returns>
        /// Reference to an instance of an object that implements the
        /// <see
        ///     cref="T:MFR.Messages.Commands.Interfaces.ICommand" />
        /// interface.
        /// </returns>
        public static ICommand<IRegOperationMetadata<string>> ForPath(
            string keyPath, string valueName, string value)
        {
            if (string.IsNullOrWhiteSpace(keyPath))
                throw new ArgumentException(
                    "Value cannot be null or whitespace.", nameof(keyPath)
                );
            if (string.IsNullOrWhiteSpace(valueName))
                throw new ArgumentException(
                    "Value cannot be null or whitespace.", nameof(valueName)
                );
            if (string.IsNullOrWhiteSpace(value))
                throw new ArgumentException(
                    "Value cannot be null or whitespace.", nameof(value)
                );

            return GetConfigurationCommand
                   .For<IRegOperationMetadata<string>>(
                       ConfigurationCommandType.SaveConfigurationFilePathToRegistry
                   )
                   .WithInput(
                       MakeNewRegOperationMetadata.FromScatch<string>()
                                                  .ForKeyPath(keyPath)
                                                  .AndValueName(valueName)
                                                  .WithValue(value)
                   );
        }
    }
}