using MFR.GUI.Processors.Constants;

namespace MFR.GUI.Actions
{
    /// <summary>
    /// Exposes static methods to obtain information from sources of data.
    /// </summary>
    public static class Get
    {
        /// <summary>
        /// Obtains the proper
        /// <see cref="T:MFR.GUI.Processors.Constants.CommandLineProcessorType" />
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
        /// <see cref="T:MFR.GUI.Processors.Constants.CommandLineProcessorType" />
        /// enumeration values that specifies how the application is to behave, given how
        /// it was launched.
        /// </returns>
        public static CommandLineProcessorType CommandLineProcessorType(
            bool commandLineSpecified,
            bool autoStart
        )
        {
            if (!commandLineSpecified)
                return Processors.Constants.CommandLineProcessorType
                                 .NoCommandLine;

            return autoStart
                ? Processors.Constants.CommandLineProcessorType.AutoStart
                : Processors.Constants.CommandLineProcessorType.GuiDriven;
        }
    }
}