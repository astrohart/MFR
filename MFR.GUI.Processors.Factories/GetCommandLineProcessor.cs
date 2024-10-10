using MFR.CommandLine.Models.Interfaces;
using MFR.GUI.Processors.Constants;
using MFR.GUI.Processors.Interfaces;
using PostSharp.Patterns.Diagnostics;
using System;

namespace MFR.GUI.Processors.Factories
{
    /// <summary>
    /// Creates instances of objects that implement the
    /// <see cref="T:MFR.GUI.Processors.Factories.ICommandLineProcessor" /> interface.
    /// </summary>
    public static class GetCommandLineProcessor
    {
        /// <summary>
        /// Initializes static data or performs actions that need to be performed once only
        /// for the <see cref="T:MFR.GUI.Processors.Factories.GetCommandLineProcessor" />
        /// class.
        /// </summary>
        /// <remarks>
        /// This constructor is called automatically prior to the first instance being
        /// created or before any static members are referenced.
        /// <para />
        /// We've decorated this constructor with the <c>[Log(AttributeExclude = true)]</c>
        /// attribute in order to simplify the logging output.
        /// </remarks>
        [Log(AttributeExclude = true)]
        static GetCommandLineProcessor() { }

        /// <summary>
        /// Builder extension method that initializes the
        /// <see
        ///     cref="P:MFR.GUI.Processors.Interfaces.ICommandLineProcessor.CommandLineInfo" />
        /// property.
        /// </summary>
        /// <param name="self">
        /// (Required.) Reference to an instance of an object that implements
        /// the
        /// <see
        ///     cref="T:MFR.GUI.Processors.Interfaces.ICommandLineProcessor" />
        /// interface.
        /// </param>
        /// <param name="cmdInfo">
        /// (Required.) Reference to an instance of an object that implements the
        /// <see cref="T:MFR.CommandLine.Models.Interfaces.ICommandLineInfo" /> interface
        /// that describes the settings specified by the user on this application's command
        /// line.
        /// </param>
        /// <returns>
        /// Reference to the same instance of the object that called this
        /// method, for fluent use.
        /// </returns>
        /// <exception cref="T:System.ArgumentNullException">
        /// Thrown if the required parameter, <paramref name="self" />, is
        /// passed a <see langword="null" /> value.
        /// </exception>
        public static ICommandLineProcessor HavingCommandLineInfo(
            this ICommandLineProcessor self,
            ICommandLineInfo cmdInfo
        )
        {
            if (self == null) throw new ArgumentNullException(nameof(self));

            self.CommandLineInfo = cmdInfo;
            return self;
        }

        /// <summary>
        /// Creates an instance of an object implementing the
        /// <see cref="T:MFR.GUI.Processors.Factories.ICommandLineProcessor" /> interface
        /// which corresponds to the value specified in <paramref name="type" />, and
        /// returns a reference to it.
        /// </summary>
        /// <param name="type">
        /// One of the
        /// <see cref="T:MFR.GUI.Processors.Factories.CommandLineProcessorType" /> values
        /// that describes what type of object you want.
        /// </param>
        /// <returns>
        /// A reference to the instance of the object that implements the
        /// <see cref="T:MFR.GUI.Processors.Factories.ICommandLineProcessor" /> interface
        /// which corresponds to the value specified in <paramref name="type" />.
        /// </returns>
        /// <remarks>
        /// This method will throw an exception if there are no types implemented
        /// that correspond to the value of <paramref name="type" />.
        /// </remarks>
        /// <exception cref="T:System.ArgumentOutOfRangeException">
        /// Thrown if there is no
        /// corresponding concrete type defined that implements the
        /// <see cref="T:MFR.GUI.Processors.Factories.ICommandLineProcessor" /> interface
        /// and which corresponds to the value passed in the <paramref name="type" />
        /// parameter.
        /// </exception>
        public static ICommandLineProcessor OfType(
            CommandLineProcessorType type
        )
        {
            ICommandLineProcessor result;

            switch (type)
            {
                case CommandLineProcessorType.AutoStart:
                    result = AutoStartCommandLineProcessor.Instance;
                    break;

                case CommandLineProcessorType.GuiDriven:
                    result = GuiDrivenCommandLineProcessor.Instance;
                    break;

                case CommandLineProcessorType.NoCommandLine:
                    result = NoCommandLineProcessor.Instance;
                    break;

                default:
                    throw new ArgumentOutOfRangeException(
                        nameof(type), type,
                        $"There are no command-line processors of the type '{type}' that are currently supported."
                    );
            }

            return result;
        }
    }
}