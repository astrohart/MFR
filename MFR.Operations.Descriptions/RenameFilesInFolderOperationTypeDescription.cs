using MFR.Operations.Constants;
using MFR.Operations.Descriptions.Interfaces;
using MFR.Operations.Descriptions.Properties;
using PostSharp.Patterns.Diagnostics;

namespace MFR.Operations.Descriptions
{
    /// <summary>
    /// Gets the descriptive text to be displayed to the user during a Rename
    /// Files in Folder operation.
    /// </summary>
    public class
        RenameFilesInFolderOperationTypeDescription : IOperationTypeDescription
    {
        /// <summary>
        /// Empty, static constructor to prohibit direct allocation of this class.
        /// </summary>
        [Log(AttributeExclude = true)]
        static RenameFilesInFolderOperationTypeDescription() { }

        /// <summary>
        /// Empty, protected constructor to prohibit direct allocation of this class.
        /// </summary>
        [Log(AttributeExclude = true)]
        protected RenameFilesInFolderOperationTypeDescription() { }

        /// <summary>
        /// Gets a reference to the one and only instance of
        /// <see
        ///     cref="T:MFR.Operations.Descriptions.RenameFilesInFolderOperationTypeDescription" />
        /// .
        /// </summary>
        [Log(AttributeExclude = true)]
        public static RenameFilesInFolderOperationTypeDescription Instance
        {
            get;
        } = new RenameFilesInFolderOperationTypeDescription();

        /// <summary>
        /// Gets one of the <see cref="T:MFR.OperationType" /> values
        /// that corresponds to the type of operation being performed.
        /// </summary>
        public OperationType OperationType
            => OperationType.RenameFilesInFolder;

        /// <summary>
        /// Gets a string to be displayed to the user, that corresponds to the
        /// current type of operation that is being performed.
        /// </summary>
        /// <remarks>
        /// It is up to the implementers of this interface to supply the proper text.
        /// </remarks>
        public string Text
        {
            get;
        } = Resources.OperationDescription_RenameFilesInFolder;
    }
}
