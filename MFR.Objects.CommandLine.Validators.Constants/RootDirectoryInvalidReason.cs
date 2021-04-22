namespace MFR.Objects.CommandLine.Validators.Constants
{
    /// <summary>
    /// Specifies the reason that validation either failed or did not fail.
    /// </summary>
    public enum RootDirectoryInvalidReason
    {
        /// <summary>
        /// The root directory specified does not exist on the disk.
        /// </summary>
        DoesntExist,

        /// <summary>
        /// The root directory specified does not contain a Visual Studio
        /// Solution (*.sln) file.
        /// </summary>
        DoesntContainSolution,

        /// <summary>
        /// The specified directory exists on the disk and contains a Visual
        /// Studio Solution (*.sln) file.
        /// </summary>
        Valid,

        /// <summary>
        /// Unknown validation failure.
        /// </summary>
        Unknown = -1
    }
}