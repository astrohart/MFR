using MFR.FileSystem.Interfaces;
using System.Collections.Generic;

namespace MFR.Managers.RootFolders.Interfaces
{
    /// <summary>
    /// Defines the publicly-exposed methods and properties of an object that manages a
    /// collection of the paths to the root folders from which to start the
    /// operation(s) desired by the user.
    /// </summary>
    public interface IRootFolderPathManager
    {
        /// <summary>
        /// Gets a reference to a collection of instances of objects that implement the
        /// <see cref="T:System.String" /> interface.
        /// <para />
        /// Each object plays the role of a folder from which the operation(s) that are
        /// selected by the user start processing from.
        /// </summary>
        ICollection<string> RootFolders
        {
            get;
        }
    }
}