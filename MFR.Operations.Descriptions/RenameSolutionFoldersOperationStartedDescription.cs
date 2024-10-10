using MFR.Operations.Constants;
using MFR.Operations.Descriptions.Interfaces;
using MFR.Operations.Descriptions.Properties;
using PostSharp.Patterns.Diagnostics;

namespace MFR.Operations.Descriptions
{
    /// <summary>
    /// Gets the descriptive, user-friendly text that is to be used in order to explain
    /// to the user that the application is beginning the operation of renaming the
    /// folder(s) that the Visual Studio Solution (<c>*.sln</c>) file(s) contained
    /// within a specified directory tree live in, are to be renamed according to a
    /// text-replacement pattern that has been specified by the user.
    /// </summary>
    public class
        RenameSolutionFoldersOperationStartedDescription :
            IOperationStartedDescription
    {
        /// <summary>
        /// Empty, static constructor to prohibit direct allocation of this class.
        /// </summary>
        [Log(AttributeExclude = true)]
        static RenameSolutionFoldersOperationStartedDescription() { }

        /// <summary>
        /// Empty, protected constructor to prohibit direct allocation of this class.
        /// </summary>
        [Log(AttributeExclude = true)]
        protected RenameSolutionFoldersOperationStartedDescription() { }

        /// <summary>
        /// Gets a reference to the one and only instance of the object that implements the
        /// <see
        ///     cref="T:MFR.Operations.Descriptions.Interfaces.IOperationStartedDescription" />
        /// interface that represents the description to display to the user when we are
        /// beginning the operation to rename the folder that a Solution lives in.
        /// </summary>
        [Log(AttributeExclude = true)]
        public static IOperationStartedDescription Instance
        {
            get;
        } = new RenameSolutionFoldersOperationStartedDescription();

        /// <summary>
        /// Gets one of the
        /// <see
        ///     cref="T:MFR.Operations.Constants.OperationType" />
        /// values that
        /// corresponds to the type of operation being performed.
        /// </summary>
        public OperationType OperationType
            => OperationType.RenameSolutionFolders;

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
        } = Resources.OperationStartedDescription_RenameSolutionFolder;
    }
}