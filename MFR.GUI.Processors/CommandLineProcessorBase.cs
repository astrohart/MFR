using MFR.CommandLine.Models.Interfaces;
using MFR.GUI.Processors.Constants;
using MFR.GUI.Processors.Interfaces;
using MFR.Settings.Configuration.Interfaces;
using MFR.Settings.Configuration.Providers.Factories;
using MFR.Settings.Configuration.Providers.Interfaces;

namespace MFR.GUI.Processors
{
    /// <summary>
    /// Defines the events, methods, properties, and behaviors for all command-line
    /// processors.
    /// </summary>
    public abstract class CommandLineProcessorBase : ICommandLineProcessor
    {
        /// <summary>
        /// Gets or sets a reference to an instance of an object that implements the
        /// <see cref="T:MFR.CommandLine.Models.Interfaces.ICommandLineInfo" /> interface
        /// from which settings should be read.
        /// </summary>
        public ICommandLineInfo CommandLineInfo
        {
            get;
            set;
        }

        /// <summary>
        /// Gets a reference to an instance of an object that implements the
        /// <see
        ///     cref="T:MFR.Settings.Configuration.Providers.Interfaces.IProjectFileRenamerConfigurationProvider" />
        /// interface.
        /// </summary>
        /// <remarks>
        /// The object that implements the
        /// <see
        ///     cref="T:MFR.Settings.Configuration.Providers.Interfaces.IProjectFileRenamerConfigurationProvider" />
        /// interface allows access to the configuration settings that the user can use to
        /// control the behavior of the application.
        /// <para />
        /// As this class is an abstract base class, we made this property <c>protected</c>
        /// so that our child classes can see it.
        /// </remarks>
        protected static IProjectFileRenamerConfigurationProvider
            ConfigurationProvider
            => GetProjectFileRenamerConfigurationProvider.SoleInstance();

        /// <summary>
        /// Gets or sets a reference to an instance of an object that implements the
        /// <see
        ///     cref="T:MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfiguration" />
        /// interface.
        /// </summary>
        /// <remarks>
        /// This property can be both read from and written to.  This way, if a
        /// command-line processor decides to update the configuration from the command
        /// line, then the data currently being stored and loaded by the configuration
        /// provider can be manipulated by simply setting this property.
        /// <para />
        /// Given that this class is an abstract base class, we have marked this property
        /// as <c>protected</c> so that our child classes can see it.
        /// </remarks>
        protected static IProjectFileRenamerConfiguration CurrentConfiguration
        {
            get => ConfigurationProvider.CurrentConfiguration;
            set => ConfigurationProvider.CurrentConfiguration = value;
        }

        /// <summary>
        /// Gets a <see cref="T:MFR.GUI.Processors.Constants.CommandLineProcessorType" />
        /// enumeration value that identifies the type of processing this processor does.
        /// </summary>
        public abstract CommandLineProcessorType Type
        {
            get;
        }

        /// <summary>
        /// Executes the processing specified by this processor type.
        /// </summary>
        public abstract void Process();
    }
}