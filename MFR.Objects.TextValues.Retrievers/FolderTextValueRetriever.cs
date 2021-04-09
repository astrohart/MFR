using MFR.Objects.Operations.Constants;
using PostSharp.Patterns.Diagnostics;

namespace MFR.Objects.TextValues.Retrievers
{
    public class FolderTextValueRetriever : FileAndFolderTextValueRetrieverBase
    {
        /// <summary>
        /// Empty, static constructor to prohibit direct allocation of this class.
        /// </summary>
        [Log(AttributeExclude = true)]
        static FolderTextValueRetriever()
        {
        }

        /// <summary>
        /// Empty, protected constructor to prohibit direct allocation of this class.
        /// </summary>
        [Log(AttributeExclude = true)]
        protected FolderTextValueRetriever()
        {
        }

        /// <summary>
        /// Gets a reference to the one and only instance of <see cref="T:MFR.Objects.TextValues.Retrievers.FolderTextValueRetriever"/>.
        /// </summary>
        [Log(AttributeExclude = true)]
        public static FolderTextValueRetriever Instance
        {
            get;
        } = new FolderTextValueRetriever();

        /// <summary>
        /// Gets one of the <see
        /// cref="T:MFR.Objects.OperationType"/> values that
        /// corresponds to the type of operation being performed.
        /// </summary>
        [Log(AttributeExclude = true)]
        public override OperationType OperationType
            => OperationType.RenameSubFolders;
    }
}