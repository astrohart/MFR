namespace MFR.GUI.Processors.Constants
{
    /// <summary>
    /// Values to indicate how we are going to process the application's command line.
    /// </summary>
    public enum CommandLineProcessorType
    {
        /// <summary>
        /// The user launched the application but specified nothing on the application's
        /// command line.
        /// </summary>
        NoCommandLine,

        /// <summary>
        /// We are going to display the GUI and allow the user to make selections on their
        /// own.
        /// </summary>
        /// <remarks>
        /// If the configuration has been specified on the command line, we'll
        /// fill those fields in on the user-interface for the user in advance.
        /// </remarks>
        GuiDriven,

        /// <summary>
        /// The user has supplied configuration on the command line and then requested that
        /// the operation be started without further intervention.
        /// </summary>
        AutoStart,

        /// <summary>
        /// Unknown command line processor.
        /// </summary>
        Unknown = -1
    }
}