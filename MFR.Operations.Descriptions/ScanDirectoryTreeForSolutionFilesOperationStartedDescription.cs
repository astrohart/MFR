using MFR.Operations.Constants;
using MFR.Operations.Descriptions.Interfaces;
using MFR.Operations.Descriptions.Properties;
using PostSharp.Patterns.Diagnostics;

namespace MFR.Operations.Descriptions
{
    /// <summary>
    /// Gets the descriptive text to be displayed to the user that announces we are
    /// beginning the process of scanning a directory tree for Visual Studio Solution (
    /// <c>*.sln</c>) files.
    /// </summary>
    public class
        ScanDirectoryTreeForSolutionFilesOperationStartedDescription :
            IOperationStartedDescription
    {
        /// <summary>
        /// Empty, static constructor to prohibit direct allocation of this class.
        /// </summary>
        [Log(AttributeExclude = true)]
        static
            ScanDirectoryTreeForSolutionFilesOperationStartedDescription() { }

        /// <summary>
        /// Empty, protected constructor to prohibit direct allocation of this class.
        /// </summary>
        [Log(AttributeExclude = true)]
        protected
            ScanDirectoryTreeForSolutionFilesOperationStartedDescription() { }

        /// <summary>
        /// Gets a reference to the one and only instance of the object that implements the
        /// <see
        ///     cref="T:MFR.Operations.Descriptions.Interfaces.IOperationStartedDescription" />
        /// interface that announces we are beginning the process of scanning a directory
        /// tree for Visual Studio Solution (<c>*.sln</c>) files.
        /// </summary>
        [Log(AttributeExclude = true)]
        public static IOperationStartedDescription Instance
        {
            get;
        } = new ScanDirectoryTreeForSolutionFilesOperationStartedDescription();

        /// <summary>
        /// Gets one of the
        /// <see
        ///     cref="T:MFR.Operations.Constants.OperationType" />
        /// values that
        /// corresponds to the type of operation being performed.
        /// </summary>
        public OperationType OperationType
            => OperationType.ScanDirectoryTreeForSolutionFiles;

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
        } = Resources
            .OperationStartedDescription_GetListOfAllSolutionFilesInDirectoryTree;
    }
}