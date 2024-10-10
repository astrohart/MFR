namespace MFR.GUI.Models.Interfaces
{
    /// <summary>
    /// Defines the publicly-exposed events, methods and properties of an object that
    /// encapsulates data about a process that is to be forcibly terminated prior to
    /// the start of either the <c>Rename Files in Folder</c> or
    /// <c>Rename Sub Folders</c> operations.
    /// </summary>
    public interface IErrantProcessInfo
    {
        /// <summary>
        /// Gets a <see cref="T:System.String" /> containing just the filename only, of the
        /// <c>.exe</c> file representing a process that is to be forcibly terminated.
        /// </summary>
        string FileName
        {
            get;
        }

        /// <summary>
        /// Gets or sets a <see cref="T:System.String" /> that contains the fully-qualified
        /// pathname of a <c>.exe</c> file that is to be forcibly terminated.
        /// </summary>
        string Pathname
        {
            get;
            set;
        }
    }
}