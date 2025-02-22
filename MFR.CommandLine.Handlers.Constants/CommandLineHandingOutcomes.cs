namespace MFR.CommandLine.Handlers.Constants
{
    /// <summary>
    /// Possible outcomes of handling invalid command-line arguments.
    /// </summary>
    public enum CommandLineHandingOutcomes
    {
        /// <summary>
        /// Do nothing but allow the application to continue loading.
        /// </summary>
        DoNothing,

        /// <summary>
        /// Display an error message to the user stating that the application cannot
        /// continue loading due to an unrecoverable error, and then terminate the
        /// execution of the application.
        /// </summary>
        FailFatalExit,

        /// <summary>
        /// Launch the <b>Code Locator Wizard</b> to guide the user through the process of
        /// determining what code base is to be acted upon.
        /// </summary>
        RunCodeLocatorWizard,

        Unknown = -1
    }
}