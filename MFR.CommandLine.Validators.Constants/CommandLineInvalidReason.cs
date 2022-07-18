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
        /// Unknown reason for validation failure.
        /// </summary>
        Unknown = -1
    }
}
