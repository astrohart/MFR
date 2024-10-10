using MFR.Operations.Constants;
using MFR.Replacers.Factories.Interfaces;

namespace MFR.Replacers.Factories
{
    /// <summary>
    /// Factory object that creates string replacers, specific to the Rename
    /// Solution Folders type of operation, for the various combinations of
    /// Match Case and Match Exact Word.
    /// </summary>
    public class
        RenameSolutionFoldersStringReplacerFactory :
            RenameSubFoldersStringReplacerFactory
    {
        /// <summary>
        /// Empty, static constructor to prohibit direct allocation of this class.
        /// </summary>
        static RenameSolutionFoldersStringReplacerFactory() { }

        /// <summary>
        /// Empty, protected constructor to prohibit direct allocation of this class.
        /// </summary>
        protected RenameSolutionFoldersStringReplacerFactory() { }

        /// <summary>
        /// Gets a reference to the one and only instance of the object that implements the
        /// <see cref="T:MFR.Replacers.Factories.Interfaces.IStringReplacerFactory" />
        /// interface that creates objects which are responsible for renaming file folders
        /// within a specific directory tree, that contain Visual Studio Solution (
        /// <c>*.sln</c>) files, according to a text-replacement pattern that was specified
        /// by the user.
        /// </summary>
        public new static IStringReplacerFactory Instance
        {
            get;
        } = new RenameSolutionFoldersStringReplacerFactory();

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
        } = OperationType.RenameSolutionFolders;
    }
}