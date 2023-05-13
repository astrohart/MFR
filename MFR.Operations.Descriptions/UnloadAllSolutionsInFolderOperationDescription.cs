using MFR.Operations.Constants;
using MFR.Operations.Descriptions.Interfaces;
using MFR.Operations.Descriptions.Properties;
using PostSharp.Patterns.Diagnostics;

namespace MFR.Operations.Descriptions
{
    /// <summary>
    /// Gets the descriptive text to be displayed to the user during a Unload
    /// All Solutions in Folder operation.
    /// </summary>
    public class
        UnloadAllSolutionsInFolderOperationDescription :
            IOperationDescription
    {
        /// <summary>
        /// Empty, static constructor to prohibit direct allocation of this class.
        /// </summary>
        [Log(AttributeExclude = true)]
        static UnloadAllSolutionsInFolderOperationDescription() { }

        /// <summary>
        /// Empty, protected constructor to prohibit direct allocation of this class.
        /// </summary>
        [Log(AttributeExclude = true)]
        protected UnloadAllSolutionsInFolderOperationDescription() { }

        /// <summary>
        /// Gets a reference to the one and only instance of
        /// <see cref="T:MFR.Operations.Descriptions.UnloadAllSolutionsInFolderOperationTypeDescription" />.
        /// </summary>
        [Log(AttributeExclude = true)]
        public static UnloadAllSolutionsInFolderOperationDescription
            Instance
        {
            get;
        } = new UnloadAllSolutionsInFolderOperationDescription();

        /// <summary>
        /// Gets one of the <see cref="T:MFR.Operations.Constants.OperationType" /> values
        /// that corresponds to the type of operation being performed.
        /// </summary>
        public OperationType OperationType
            => OperationType.UnloadAllSolutionsInFolder;

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
        } = Resources.OperationDescription_UnloadAllSolutionsInFolder;
    }
}
