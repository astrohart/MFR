using MFR.Directories.Managers.Interfaces;

namespace MFR.Directories.Managers
{
    public class SearchDirectoryManager : ISearchDirectoryManager
    {
        /// <summary>
        /// Empty, static constructor to prohibit direct allocation of this class.
        /// </summary>
        static SearchDirectoryManager() { }

        /// <summary>
        /// Empty, protected constructor to prohibit direct allocation of this class.
        /// </summary>
        protected SearchDirectoryManager() { }

        /// <summary>
        /// Gets a reference to the one and only instance of the object that implements the
        /// <see cref="T:MFR.Directories.Managers.Interfaces.ISearchDirectoryManager" />
        /// interface.
        /// </summary>
        public static ISearchDirectoryManager Instance
        {
            get;
        } = new SearchDirectoryManager();
    }
}