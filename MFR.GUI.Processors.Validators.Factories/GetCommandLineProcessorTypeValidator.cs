using MFR.GUI.Processors.Validators.Interfaces;
using PostSharp.Patterns.Diagnostics;
using System;
using System.Diagnostics;
using xyLOGIX.Core.Debug;

namespace MFR.GUI.Processors.Validators.Factories
{
    /// <summary>
    /// Provides access to the one and only instance of the object that implements the
    /// <see
    ///     cref="T:MFR.GUI.Processors.Validators.Interfaces.ICommandLineProcessorTypeValidator" />
    /// interface.
    /// </summary>
    public static class GetCommandLineProcessorTypeValidator
    {
        /// <summary>
        /// Initializes static data or performs actions that need to be performed once only
        /// for the
        /// <see
        ///     cref="T:MFR.GUI.Processors.Validators.Factories.GetCommandLineProcessorTypeValidator" />
        /// class.
        /// </summary>
        /// <remarks>
        /// This constructor is called automatically prior to the first instance
        /// being created or before any static members are referenced.
        /// </remarks>
        [Log(AttributeExclude = true)]
        static GetCommandLineProcessorTypeValidator() { }

        /// <summary>
        /// Obtains access to the sole instance of the object that implements the
        /// <see
        ///     cref="T:MFR.GUI.Processors.Validators.Interfaces.ICommandLineProcessorTypeValidator" />
        /// interface, and returns a reference to it.
        /// </summary>
        /// <returns>
        /// Reference to the one, and only, instance of the object that implements the
        /// <see
        ///     cref="T:MFR.GUI.Processors.Validators.Interfaces.ICommandLineProcessorTypeValidator" />
        /// interface.
        /// </returns>
        [DebuggerStepThrough]
        public static ICommandLineProcessorTypeValidator SoleInstance()
        {
            ICommandLineProcessorTypeValidator result;

            try
            {
                result = CommandLineProcessorTypeValidator.Instance;
            }
            catch (Exception ex)
            {
                // dump all the exception info to the log
                DebugUtils.LogException(ex);

                result = default;
            }

            return result;
        }
    }
}