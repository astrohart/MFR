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
        SolutionFolderStringReplacerFactory :
            RenameSubFoldersStringReplacerFactory
    {
        /// <summary>
        /// Empty, static constructor to prohibit direct allocation of this class.
        /// </summary>
        static SolutionFolderStringReplacerFactory() { }

        /// <summary>
        /// Empty, protected constructor to prohibit direct allocation of this class.
        /// </summary>
        protected SolutionFolderStringReplacerFactory() { }

        /// <summary>
        /// Gets a reference to the one and only instance of the object that implements the
        /// <see cref="T:MFR.Replacers.Factories.Interfaces.IStringReplacerFactory" />
        /// interface that represents an object that renames solution folders.
        /// </summary>
        public new static IStringReplacerFactory Instance
        {
            get;
        } = new SolutionFolderStringReplacerFactory();

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