using MFR.Objects.Operations.Constants;
using MFR.Objects.Operations.Descriptions.Interfaces;
using MFR.Objects.Operations.Descriptions.Properties;
using PostSharp.Patterns.Diagnostics;

namespace MFR.Objects.Operations.Descriptions
{
    /// <summary>
    /// Gets the descriptive text to be displayed to the user during a Rename Files in Folder operation.
    /// </summary>
    public class
        RenameFilesInFolderOperationTypeDescription : IOperationTypeDescription
    {
        /// <summary>
        /// Gets a reference to the one and only instance of <see cref="T:MFR.Objects.RenameFilesInFolderOperationDescription"/>.
        /// </summary>
        [Log(AttributeExclude = true)]
        public static RenameFilesInFolderOperationTypeDescription Instance
        {
            get;
        } = new RenameFilesInFolderOperationTypeDescription();

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
        /// Gets one of the
        /// <see
        ///     cref="T:MFR.Objects.OperationType" />
        /// values that
        /// corresponds to the type of operation being performed.
        /// </summary>
        public OperationType OperationType
        {
            get;
        } = OperationType.RenameFilesInFolder;

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