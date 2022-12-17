using MFR.Operations.Constants;
using MFR.Operations.Descriptions.Interfaces;
using MFR.Operations.Descriptions.Properties;
using PostSharp.Patterns.Diagnostics;

namespace MFR.Operations.Descriptions
{
    /// <summary>
    /// Gets the descriptive text to be displayed to the user at the start of a
    /// Rename Sub Folders Of operation.
    /// </summary>
    public class
        RenameSubFoldersOperationStartedDescription :
            IOperationStartedDescription
    {
        /// <summary>
        /// Empty, static constructor to prohibit direct allocation of this class.
        /// </summary>
        [Log(AttributeExclude = true)]
        static RenameSubFoldersOperationStartedDescription() { }

        /// <summary>
        /// Empty, protected constructor to prohibit direct allocation of this class.
        /// </summary>
        [Log(AttributeExclude = true)]
        protected RenameSubFoldersOperationStartedDescription() { }

        /// <summary>
        /// Gets a reference to the one and only instance of
        /// <see
        ///     cref="T:MFR.RenameSubFoldersOperationStartedDescription" />
        /// .
        /// </summary>
        [Log(AttributeExclude = true)]
        public static RenameSubFoldersOperationStartedDescription Instance
        {
            get;
        } = new RenameSubFoldersOperationStartedDescription();

        /// <summary>
        /// Gets one of the
        /// <see
        ///     cref="T:MFR.OperationType" />
        /// values that
        /// corresponds to the type of operation being performed.
        /// </summary>
        public OperationType OperationType
            => OperationType.RenameSubFolders;

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
        } = Resources.OperationStartedDescription_RenameSubFolders;
    }
}
