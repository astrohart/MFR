using MFR.Operations.Constants;
using PostSharp.Patterns.Diagnostics;

namespace MFR.TextValues.Retrievers
{
    /// <summary>
    /// Retrieves the value to be used in which to search for text to be
    /// substituted in the names of file folders.
    /// </summary>
    public class FolderTextValueRetriever : FileAndFolderTextValueRetrieverBase
    {
        /// <summary>
        /// Empty, static constructor to prohibit direct allocation of this class.
        /// </summary>
        [Log(AttributeExclude = true)]
        static FolderTextValueRetriever() { }

        /// <summary>
        /// Empty, protected constructor to prohibit direct allocation of this class.
        /// </summary>
        [Log(AttributeExclude = true)]
        protected FolderTextValueRetriever() { }

        /// <summary>
        /// Gets a reference to the one and only instance of
        /// <see cref="T:MFR.TextValues.Retrievers.FolderTextValueRetriever" />.
        /// </summary>
        [Log(AttributeExclude = true)]
        public static FolderTextValueRetriever Instance
        {
            get;
        } = new FolderTextValueRetriever();

        /// <summary>
        /// Gets one of the <see cref="T:MFR.OperationType" /> values
        /// that corresponds to the type of operation being performed.
        /// </summary>
        [Log(AttributeExclude = true)]
        public override OperationType OperationType
            => OperationType.RenameSubFolders;
    }
}