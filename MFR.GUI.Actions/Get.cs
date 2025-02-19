using Alphaleonis.Win32.Filesystem;
using MFR.GUI.Processors.Constants;
using PostSharp.Patterns.Diagnostics;
using System;
using System.Diagnostics;
using xyLOGIX.Core.Assemblies.Info;
using xyLOGIX.Core.Debug;

namespace MFR.GUI.Actions
{
    /// <summary>
    /// Exposes static methods to obtain information from sources of data.
    /// </summary>
    public static class Get
    {
        /// <summary>
        /// A <see cref="T:System.String" /> containing the final piece of the path of the
        /// log file.
        /// </summary>
        private static readonly string LOG_FILE_PATH_TERMINATOR =
            $@"{AssemblyCompany}\{AssemblyProduct}\Logs\{AssemblyTitle}_log.txt";

        /// <summary>
        /// Initializes static data or performs actions that need to be performed once only
        /// for the <see cref="T:MFR.GUI.Actions.Get" /> class.
        /// </summary>
        /// <remarks>
        /// This constructor is called automatically prior to the first instance being
        /// created or before any static members are referenced.
        /// <para />
        /// We've decorated this constructor with the <c>[Log(AttributeExclude = true)]</c>
        /// attribute in order to simplify the logging output.
        /// </remarks>
        [Log(AttributeExclude = true)]
        static Get() { }

        /// <summary>
        /// Gets a <see cref="T:System.String" /> that contains the product name defined
        /// for this application.
        /// </summary>
        /// <remarks>
        /// This property is really an alias for the
        /// <see cref="P:AssemblyMetadata.AssemblyCompany" /> property.
        /// </remarks>
        private static string AssemblyCompany
        {
            [DebuggerStepThrough] get => AssemblyMetadata.AssemblyCompany;
        }

        /// <summary>
        /// Gets a <see cref="T:System.String" /> that contains the product name defined
        /// for this application.
        /// </summary>
        /// <remarks>
        /// This property is really an alias for the
        /// <see cref="P:AssemblyMetadata.AssemblyProduct" /> property.
        /// </remarks>
        private static string AssemblyProduct
        {
            [DebuggerStepThrough]
            get
                => AssemblyMetadata.AssemblyProduct.Replace(
                    "xyLOGIX ", string.Empty
                );
        }

        /// <summary>
        /// Gets a <see cref="T:System.String" /> that contains the assembly title defined
        /// for this application.
        /// </summary>
        /// <remarks>
        /// This property is really an alias for the
        /// <see cref="P:AssemblyMetadata.AssemblyTitle" /> property.
        /// </remarks>
        private static string AssemblyTitle
        {
            [DebuggerStepThrough]
            get => AssemblyMetadata.AssemblyTitle.Replace(" ", "_");
        }

        /// <summary>
        /// Gets a <see cref="T:System.String" /> that contains a user-friendly name for
        /// the software product of which this application or class library is a part.
        /// </summary>
        /// <returns>
        /// A <see cref="T:System.String" /> that contains a user-friendly name
        /// for the software product of which this application or class library is a part.
        /// </returns>
        public static string ApplicationProductName()
        {
            string result;

            try
            {
                result = AssemblyProduct;
            }
            catch (Exception ex)
            {
                // dump all the exception info to the log
                DebugUtils.LogException(ex);

                result = string.Empty;
            }

            return result;
        }

        /// <summary>
        /// Obtains the proper
        /// <see cref="T:MFR.GUI.Processors.Constants.CurrentCommandLineProcessorType" />
        /// enumeration value that corresponds to the way that the application was
        /// launched.
        /// </summary>
        /// <param name="commandLineSpecified">
        /// (Required.) <see langword="true" /> if more than zero command-line arguments
        /// are specified when the application is launched; <see langword="false" />
        /// otherwise.
        /// </param>
        /// <param name="autoStart">
        /// (Required.) <see langword="true" /> if the user specifies the
        /// <c>--autoStart</c> flag on the command line.
        /// </param>
        /// <returns>
        /// One of the
        /// <see cref="T:MFR.GUI.Processors.Constants.CurrentCommandLineProcessorType" />
        /// enumeration values that specifies how the application is to behave, given how
        /// it was launched.
        /// </returns>
        [DebuggerStepThrough]
        public static CommandLineProcessorType CurrentCommandLineProcessorType(
            bool commandLineSpecified,
            bool autoStart
        )
        {
            var result = CommandLineProcessorType.NoCommandLine;

            try
            {
                DebugUtils.WriteLine(
                    DebugLevel.Info,
                    "*** Get.CurrentCommandLineProcessorType: Checking whether the command-line was specified at all..."
                );

                // Check to see whether the command-line was specified at all.
                // If this is not the case, then write an error message to the log file,
                // and then terminate the execution of this method.
                if (!commandLineSpecified)
                {
                    // Zero command-line argument(s) were passed to the application upon startup.  This is not desirable.
                    DebugUtils.WriteLine(
                        DebugLevel.Error,
                        "*** ERROR *** Zero command-line argument(s) were passed to the application upon startup.  Stopping..."
                    );

                    DebugUtils.WriteLine(
                        DebugLevel.Debug,
                        $"Get.CurrentCommandLineProcessorType: Result = '{result}'"
                    );

                    // stop.
                    return result;
                }

                DebugUtils.WriteLine(
                    DebugLevel.Info,
                    "Get.CurrentCommandLineProcessorType: *** SUCCESS *** Greater than zero command-line argument(s) were passed to the application.  Proceeding..."
                );

                result = autoStart ? CommandLineProcessorType.AutoStart : CommandLineProcessorType.GuiDriven;
            }
            catch (Exception ex)
            {
                // dump all the exception info to the log
                DebugUtils.LogException(ex);

                result = CommandLineProcessorType.Unknown;
            }

            DebugUtils.WriteLine(
                DebugLevel.Debug,
                $"Get.CurrentCommandLineProcessorType: Result = '{result}'"
            );

            return result;
        }

        /// <summary>
        /// Obtains a <see cref="T:System.String" /> that contains the fully-qualified
        /// pathname of the file that should be used for logging messages.
        /// </summary>
        /// <returns>
        /// A <see cref="T:System.String" /> that contains the fully-qualified
        /// pathname of the file that should be used for logging messages.
        /// </returns>
        public static string LogFilePath()
            => Path.Combine(
                Environment.GetFolderPath(
                    Environment.SpecialFolder.CommonApplicationData
                ), LOG_FILE_PATH_TERMINATOR
            );
    }
}