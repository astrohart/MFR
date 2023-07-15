using Alphaleonis.Win32.Filesystem;
using MFR.CommandLine.Models.Interfaces;

namespace MFR.CommandLine.Models
{
    /// <summary>
    /// Encapsulates this application's command line arguments.
    /// </summary>
    /// <remarks>
    /// This class depends on the <c>FluentCommandLineParser</c> NuGet package.
    /// </remarks>
    public class CommandLineInfo : ICommandLineInfo
    {
        /// <summary>
        /// Gets or sets a value indicating whether processing starts when the application
        /// starts.
        /// </summary>
        public bool AutoStart
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets a string containing the content to be found in the file system
        /// entries.
        /// </summary>
        public string FindWhat
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets a value indicating whether a case-sensitive search should be done.
        /// </summary>
        /// <remarks>
        /// The default value of this property is <see langword="true" />.
        /// </remarks>
        public bool MatchCase
        {
            get;
            set;
        } = true;

        /// <summary>
        /// Gets or sets a value indicating whether a whole-word search should be done.
        /// </summary>
        public bool MatchWholeWord
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets a value indicating whether the files are to be renamed.
        /// </summary>
        /// <remarks>
        /// The default value of this property is <see langword="true" />.
        /// </remarks>
        public bool RenameFiles
        {
            get;
            set;
        } = true;

        /// <summary>
        /// Gets or sets a value indicating whether we are to rename folder(s) that contain Solution(s).
        /// </summary>
        public bool RenameSolutionFolders
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets a value indicating whether sub folders should be renamed.
        /// </summary>
        /// <remarks>
        /// The default value of this property is <see langword="true" />.
        /// </remarks>
        public bool RenameSubFolders
        {
            get;
            set;
        } = true;

        /// <summary>
        /// Gets or sets a value that indicates that the Solution is to be reloaded when
        /// the operations are finished.
        /// </summary>
        /// <remarks>
        /// The default value of this property is <see langword="true" />.
        /// </remarks>
        public bool ReOpenSolution
        {
            get;
            set;
        } = true;

        /// <summary>
        /// Gets or sets a value indicating whether text in files should be replaced.
        /// </summary>
        /// <remarks>
        /// The default value of this property is <see langword="true" />.
        /// </remarks>
        public bool ReplaceTextInFiles
        {
            get;
            set;
        } = true;

        /// <summary>
        /// Gets or sets a string containing the content to be replaced in the file system
        /// entries.
        /// </summary>
        public string ReplaceWith
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets a string that contains the starting folder.
        /// </summary>
        public string StartingFolder
        {
            get;
            set;
        } = Directory.GetCurrentDirectory();
    }
}