using System;

namespace MFR.FileSystem.Enumerators.Tests.Constants
{
    /// <summary>
    /// Constants for strings that are used by the Enumerator tests.
    /// </summary>
    public static class UnitTestStringConstants
    {
        /// <summary>
        /// String that is <see langword="null" />.
        /// </summary>
        public const string NULL = null;

        /// <summary>
        /// String that contains only whitespace.
        /// </summary>
        public const string WHITESPACE = "\n\t\t\t   ";

        /// <summary>
        /// String that is the value of the <see cref="F:System.String.Empty" /> field.
        /// </summary>
        public static readonly string BLANK = string.Empty;

        /// <summary>
        /// String containing the fully-qualified pathname of a folder whose contents are
        /// to be listed as a test.
        /// </summary>
        public static readonly string FOLDER_TO_TEST =
            Environment.ExpandEnvironmentVariables(@"%USERPROFILE%\Documents");
    }
}