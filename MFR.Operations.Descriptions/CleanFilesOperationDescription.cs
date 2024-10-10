using MFR.Operations.Constants;
using MFR.Operations.Descriptions.Properties;
using MFR.Operations.Descriptions.Interfaces;
using PostSharp.Patterns.Diagnostics;

namespace MFR.Operations.Descriptions
{
    /// <summary>
    /// Description of the <c>Clean Files</c> operation.
    /// </summary>
    public class CleanFilesOperationDescription : OperationDescriptionBase
    {
        /// <summary>
        /// Empty, static constructor to prohibit direct allocation of this class.
        /// </summary>
        [Log(AttributeExclude = true)]
        static CleanFilesOperationDescription() { }

        /// <summary>
        /// Empty, protected constructor to prohibit direct allocation of this class.
        /// </summary>
        [Log(AttributeExclude = true)]
        protected CleanFilesOperationDescription() { }

        /// <summary>
        /// Gets a reference to the one and only instance of the object that implements the
        /// <see cref="T:MFR.Operations.Descriptions.Interfaces.IOperationDescription" />
        /// interface.
        /// </summary>
        public static IOperationDescription Instance
        {
            get;
        } = new CleanFilesOperationDescription();

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
        } = OperationType.CleanFiles;

        /// <summary>
        /// Gets a string to be displayed to the user, that corresponds to the
        /// current type of operation that is currently being performed.
        /// </summary>
        /// <remarks>
        /// It is up to the implementers of this interface to supply the proper text.
        /// </remarks>
        public override string Text
        {
            get;
        } = Resources.OperationDescription_CleanFiles;
    }
}