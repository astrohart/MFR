using System;

namespace MFR.Directories.Constants
{
    /// <summary>
    /// Strings containing pathnames of commonly-referenced folders.
    /// </summary>
    public static class Directories
    {
        /// <summary>
        /// The My Documents folder.
        /// </summary>
        public static readonly string MyDocuments =
            Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
    }
}