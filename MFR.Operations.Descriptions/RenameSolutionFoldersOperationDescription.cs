using MFR.Operations.Constants;
using MFR.Operations.Descriptions.Interfaces;
using MFR.Operations.Descriptions.Properties;
using PostSharp.Patterns.Diagnostics;

namespace MFR.Operations.Descriptions
{
    /// <summary>
    /// Gets the descriptive text to be displayed to the user during a <c>Rename Solution Folders</c> operation.
    /// </summary>
    public class RenameSolutionFoldersOperationDescription : OperationDescriptionBase
    {
        /// <summary>
        /// Empty, static constructor to prohibit direct allocation of this class.
        /// </summary>
        [Log(AttributeExclude = true)]
        static RenameSolutionFoldersOperationDescription() { }

        /// <summary>
        /// Empty, protected constructor to prohibit direct allocation of this class.
        /// </summary>
        [Log(AttributeExclude = true)]
        protected RenameSolutionFoldersOperationDescription() { }

        /// <summary>
        /// Gets a reference to the one and only instance of the object that implements the
        /// <see cref="T:MFR.Operations.Descriptions.Interfaces.IOperationDescription" />
        /// interface and which provides user-friendly text that explains that the
        /// application is currently in the process of renaming subfolders of the root
        /// directory.
        /// </summary>
        [Log(AttributeExclude = true)]
        public static IOperationDescription Instance
        {
            get;
        } = new RenameSolutionFoldersOperationDescription();

        /// <summary>
        /// Gets one of the
        /// <see
        ///     cref="T:MFR.Operations.Constants.OperationType" />
        /// values that
        /// corresponds to the type of operation being performed.
        /// </summary>
        public override OperationType OperationType
        { get; } = OperationType.RenameSolutionFolders;

        /// <summary>
        /// Gets a string to be displayed to the user, that corresponds to the
        /// current type of operation that is being performed.
        /// </summary>
        /// <remarks>
        /// It is up to the implementers of this interface to supply the proper text.
        /// </remarks>
        public override string Text
        {
            get;
        } = Resources.OperationDescription_RenameSolutionFolders;
    }
}