using MFR.Operations.Constants;
using MFR.TextValues.Retrievers.Interfaces;
using PostSharp.Patterns.Diagnostics;

namespace MFR.TextValues.Retrievers
{
    /// <summary>
    /// Retrieves the value to be used in which to search for text to be substituted in
    /// the names of file folders that contain Visual Studio Solution (<c>*.sln</c>)
    /// files.
    /// </summary>
    [Log(AttributeExclude = true)]
    public class
        SolutionFolderTextValueRetriever : FileAndFolderTextValueRetrieverBase
    {
        /// <summary>
        /// Empty, static constructor to prohibit direct allocation of this class.
        /// </summary>
        static SolutionFolderTextValueRetriever() { }

        /// <summary>
        /// Empty, protected constructor to prohibit direct allocation of this class.
        /// </summary>
        protected SolutionFolderTextValueRetriever() { }

        /// <summary>
        /// Gets a reference to the one and only instance of the object that implements the
        /// <see cref="T:MFR.TextValues.Retrievers.Interfaces.ITextValueRetriever" />
        /// interface for retrieving the pathname of a folder that contains one or more
        /// Visual Studio Solution (<c>*.sln</c>) file(s).
        /// </summary>
        public static ITextValueRetriever Instance
        {
            get;
        } = new SolutionFolderTextValueRetriever();

        /// <summary>
        /// Gets one of the <see cref="T:MFR.Operations.Constants.OperationType" /> values
        /// that corresponds to the type of operation being performed.
        /// </summary>
        public override OperationType OperationType
        {
            get;
        } = OperationType.RenameSolutionFolders;
    }
}