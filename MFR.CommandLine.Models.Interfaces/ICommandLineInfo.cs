namespace MFR.CommandLine.Models.Interfaces
{
    /// <summary>
    /// Defines the publicly-exposed methods and properties of an object that stores
    /// the information supplied by the user on the application's command line.
    /// </summary>
    public interface ICommandLineInfo
    {
        /// <summary>
        /// Gets or sets a string containing the content to be found in the file system
        /// entries.
        /// </summary>
        string FindWhat
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets a value indicating whether a case-sensitive search should be done.
        /// </summary>
        bool MatchCase
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets a value indicating whether a whole-word search should be done.
        /// </summary>
        bool MatchWholeWord
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets a value indicating whether the files are to be renamed.
        /// </summary>
        bool RenameFiles
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets a value indicating whether sub folders should be renamed.
        /// </summary>
        bool RenameSubFolders
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets a value indicating whether text in files should be replaced.
        /// </summary>
        bool ReplaceinFiles
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets a string containing the content to be replaced in the file system
        /// entries.
        /// </summary>
        string ReplaceWith
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets a string that contains the starting folder.
        /// </summary>
        string RootDirectory
        {
            get;
            set;
        }
    }
}
