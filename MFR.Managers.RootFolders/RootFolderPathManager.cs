using MFR.FileSystem.Interfaces;
using MFR.Managers.RootFolders.Interfaces;
using PostSharp.Patterns.Diagnostics;
using System.Collections.Generic;

namespace MFR.Managers.RootFolders
{
    /// <summary>
    /// Class to manage a collection of root folder paths to iterate over, processing
    /// the find/replace operations for all folders listed in the collection.
    /// </summary>
    public class RootFolderPathManager : IRootFolderPathManager
    {
        /// <summary>
        /// Empty, static constructor to prohibit direct allocation of this class.
        /// </summary>
        [Log(AttributeExclude = true)]
        static RootFolderPathManager() { }

        /// <summary>
        /// Empty, protected constructor to prohibit direct allocation of this class.
        /// </summary>
        [Log(AttributeExclude = true)]
        protected RootFolderPathManager() { }

        /// <summary>
        /// Gets a reference to the one and only instance of
        /// <see cref="T:MFR.Managers.RootFolders.RootFolderPathManager" />.
        /// </summary>
        [Log(AttributeExclude = true)]
        public static RootFolderPathManager Instance
        {
            get;
        } = new RootFolderPathManager();

        /// <summary>
        /// Gets a reference to a collection of instances of objects that implement the
        /// <see cref="T:System.String" /> interface.
        /// <para />
        /// Each object plays the role of a folder from which the operation(s) that are
        /// selected by the user start processing from.
        /// </summary>
        public ICollection<string> RootFolders
        {
            get;
        } = new List<string>();
    }
}