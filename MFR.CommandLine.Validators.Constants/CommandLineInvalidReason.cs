namespace MFR.CommandLine.Validators.Constants
{
    /// <summary>
    /// Constants that correspond to the types of validation failures that can
    /// occur for instances of <see cref="T:MFR.CommandLine.CommandLineInfo"/>.
    /// </summary>
    public enum CommandLineInvalidReason
    {
        /// <summary>
        /// A <see langword="null" /> value was passed to the validation method.
        /// </summary>
        IsNull,

        /// <summary>
        /// The <c>Find What</c> value supplied is blank.  This a required value.
        /// </summary>
        FindWhatBlank,

        /// <summary>
        /// The starting folder provided does not contain any .sln files, and not in its hierarchy, either.
        /// <para/>
        /// This application needs to be launched on a directory that contains at least one <c>.sln</c> file.
        /// </summary>
        RootDirectoryDoesntContainSolution,

        /// <summary>
        /// The starting folder whose pathname was provided does not exist on the disk.
        /// </summary>
        RootDirectoryDoesntExist,

        /// <summary>
        /// Unknown reason for validation failure.
        /// </summary>
        Unknown = -1
    }
}
