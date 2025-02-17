using MFR.CommandLine.Models.Interfaces;
using MFR.GUI.Processors.Constants;
using MFR.GUI.Processors.Interfaces;
using MFR.Settings.Configuration.Interfaces;
using MFR.Settings.Configuration.Providers.Factories;
using MFR.Settings.Configuration.Providers.Interfaces;
using PostSharp.Patterns.Diagnostics;
using System.Diagnostics;

namespace MFR.GUI.Processors
{
    /// <summary>
    /// Defines the events, methods, properties, and behaviors for all command-line
    /// processors.
    /// </summary>
    public abstract class CommandLineProcessorBase : ICommandLineProcessor
    {
        /// <summary>
        /// Initializes static data or performs actions that need to be performed once only
        /// for the <see cref="T:MFR.GUI.Processors.CommandLineProcessorBase" /> class.
        /// </summary>
        /// <remarks>
        /// This constructor is called automatically prior to the first instance being
        /// created or before any static members are referenced.
        /// </remarks>
        [Log(AttributeExclude = true)]
        static CommandLineProcessorBase() { }

        /// <summary>
        /// Initializes a new instance of
        /// <see cref="T:MFR.GUI.Processors.CommandLineProcessorBase" /> and returns a
        /// reference to it.
        /// </summary>
        /// <remarks>
        /// <strong>NOTE:</strong> This constructor is marked <see langword="protected" />
        /// due to the fact that this class is marked <see langword="abstract" />.
        /// </remarks>
        [Log(AttributeExclude = true)]
        protected CommandLineProcessorBase() { }

        /// <summary>
        /// Gets or sets a reference to an instance of an object that implements the
        /// <see cref="T:MFR.CommandLine.Models.Interfaces.ICommandLineInfo" /> interface
        /// from which settings should be read.
        /// </summary>
        public ICommandLineInfo CommandLineInfo
        {
            [DebuggerStepThrough] get;
            [DebuggerStepThrough] set;
        }

        /// <summary>
        /// Gets a reference to an instance of an object that implements the
        /// <see
        ///     cref="T:MFR.Settings.Configuration.Providers.Interfaces.IProjectFileRenamerConfigProvider" />
        /// interface.
        /// </summary>
        /// <remarks>
        /// The object that implements the
        /// <see
        ///     cref="T:MFR.Settings.Configuration.Providers.Interfaces.IProjectFileRenamerConfigProvider" />
        /// interface allows access to the config settings that the user can use to
        /// control the behavior of the application.
        /// <para />
        /// As this class is an abstract base class, we made this property
        /// <see langword="protected" />
        /// so that our child classes can see it.
        /// </remarks>
        protected static IProjectFileRenamerConfigProvider
            ConfigProvider
            => GetProjectFileRenamerConfigProvider.SoleInstance();

        /// <summary>
        /// Gets or sets a reference to an instance of an object that implements the
        /// <see
        ///     cref="T:MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfig" />
        /// interface.
        /// </summary>
        /// <remarks>
        /// This property can be both read from and written to.  This way, if a
        /// command-line processor decides to update the config from the command
        /// line, then the data currently being stored and loaded by the config
        /// provider can be manipulated by simply setting this property.
        /// <para />
        /// Given that this class is an abstract base class, we have marked this property
        /// as <see langword="protected" /> so that our child classes can see it.
        /// </remarks>
        protected static IProjectFileRenamerConfig CurrentConfig
        {
            [DebuggerStepThrough] get => ConfigProvider.CurrentConfig;
            [DebuggerStepThrough] set => ConfigProvider.CurrentConfig = value;
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