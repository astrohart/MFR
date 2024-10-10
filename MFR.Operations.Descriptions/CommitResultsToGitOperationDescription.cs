using MFR.Operations.Constants;
using MFR.Operations.Descriptions.Interfaces;
using MFR.Operations.Descriptions.Properties;
using PostSharp.Patterns.Diagnostics;

namespace MFR.Operations.Descriptions
{
    /// <summary>
    /// Gets the descriptive text to be displayed to the user during a Rename Sub
    /// Folders Of operation.
    /// </summary>
    public class
        CommitResultsToGitOperationDescription : OperationDescriptionBase
    {
        /// <summary>
        /// Empty, static constructor to prohibit direct allocation of this class.
        /// </summary>
        [Log(AttributeExclude = true)]
        static CommitResultsToGitOperationDescription() { }

        /// <summary>
        /// Empty, protected constructor to prohibit direct allocation of this class.
        /// </summary>
        [Log(AttributeExclude = true)]
        protected CommitResultsToGitOperationDescription() { }

        /// <summary>
        /// Gets a reference to the one and only instance of the object that implements the
        /// <see cref="T:MFR.Operations.Descriptions.Interfaces.IOperationDescription" />
        /// interface and which provides user-friendly text that explains to the user that
        /// the application is currently processing committing the results of running
        /// the main renaming operations to the various local Git repository(ies) that reside within
        /// the directory tree of the root folder.
        /// </summary>
        [Log(AttributeExclude = true)]
        public static IOperationDescription Instance
        {
            get;
        } = new CommitResultsToGitOperationDescription();

        /// <summary>
        /// Gets one of the
        /// <see
        ///     cref="T:MFR.Operations.Constants.OperationType" />
        /// values that
        /// corresponds to the type of operation being performed.
        /// </summary>
        public override OperationType OperationType
        {
            get;
        } = OperationType.CommitResultsToGit;

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
        } = Resources.OperationDescription_CommitResultsToGit;
    }
}