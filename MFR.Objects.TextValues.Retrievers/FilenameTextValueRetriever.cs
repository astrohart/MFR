using MFR.Objects.Operations.Constants;
using PostSharp.Patterns.Diagnostics;

namespace MFR.Objects.TextValues.Retrievers
{
    /// <summary>
    /// Retrieves the search source data for filename replacement operations.
    /// </summary>
    public class FilenameTextValueRetriever : FileAndFolderTextValueRetrieverBase
    {
        /// <summary>
        /// Empty, static constructor to prohibit direct allocation of this class.
        /// </summary>
        [Log(AttributeExclude = true)]
        static FilenameTextValueRetriever()
        {
        }

        /// <summary>
        /// Empty, protected constructor to prohibit direct allocation of this class.
        /// </summary>
        [Log(AttributeExclude = true)]
        protected FilenameTextValueRetriever()
        {
        }

        /// <summary>
        /// Gets a reference to the one and only instance of <see cref="T:MFR.Objects.TextValues.Retrievers.FilenameTextValueRetriever"/>.
        /// </summary>
        [Log(AttributeExclude = true)]
        public static FilenameTextValueRetriever Instance
        {
            get;
        } = new FilenameTextValueRetriever();

        /// <summary>
        /// Gets one of the <see
        /// cref="T:MFR.Objects.OperationType"/> values that
        /// corresponds to the type of operation being performed.
        /// </summary>
        [Log(AttributeExclude = true)]
        public override OperationType OperationType
            => OperationType.RenameFilesInFolder;
    }
}