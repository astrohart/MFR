using PostSharp.Patterns.Diagnostics;

namespace MFR.Managers.RootFolders
{
    /// <summary>
    /// Class to manage a collection of root folder paths to iterate over, processing
    /// the find/replace operations for all folders listed in the collection.
    /// </summary>
    public class RootFolderPathManager
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
    }
}