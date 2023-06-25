using System;

namespace MFR.Engines.Operations.Jobs.Interfaces
{
    /// <summary>
    /// Defines the publicly-exposed methods and properties of an object that
    /// represents one of the jobs in the job queue for renaming files, folders, and
    /// replacing the text within files..
    /// </summary>
    public interface IFileRenamerJob
    {
        /// <summary>
        /// Gets or sets a <see cref="T:System.String" /> containing the content to be
        /// found in file names, folder names, and file contents.
        /// </summary>
        string FindWhat
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets an instance of <see cref="T:System.Func" /> that points to a
        /// delegate, accepting the current file or folder's path as an argument, that
        /// returns <see langword="true" /> if the file should be included in the operation
        /// or <see langword="false" /> otherwise.
        /// </summary>
        Predicate<string> PathFilter
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets a <see cref="T:System.String" /> that contains the value(s) that
        /// should be substituted for the found content in file names, folder names, and
        /// file contents.
        /// </summary>
        string ReplaceWith
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets a <see cref="T:System.String" /> that contains the fully-qualified
        /// pathname of the folder in which the job was ready to start.
        /// </summary>
        string RootDirectory
        {
            get;
            set;
        }
    }
}