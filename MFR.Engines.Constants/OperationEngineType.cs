namespace MFR.Engines.Constants
{
    /// <summary>
    /// Values that describe the type of operation engine -- e.g., full GUI, automated GUI (called from command line) or console app, which which we are working.
    /// </summary>
    public enum OperationEngineType
    {
        /// <summary>
        /// The GUI was brought up by the user without any automated operations being requested.
        /// </summary>
        FullGUI,

        /// <summary>
        /// Application is run as a console program.
        /// </summary>
        Console,

        /// <summary>
        /// Unknown operation engine type.
        /// </summary>
        Unknown = -1,
    }
}