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
        GettingListOfFilesToBeRenamedOperationTypeStartedDescription :
            IOperationTypeStartedDescription
    {
        /// <summary>
        /// Empty, static constructor to prohibit direct allocation of this class.
        /// </summary>
        [Log(AttributeExclude = true)]
        static GettingListOfFilesToBeRenamedOperationTypeStartedDescription()
        {
        }

        /// <summary>
        /// Empty, protected constructor to prohibit direct allocation of this class.
        /// </summary>
        [Log(AttributeExclude = true)]
        protected GettingListOfFilesToBeRenamedOperationTypeStartedDescription()
        {
        }

        /// <summary>
        /// Gets a reference to the one and only instance of <see
        /// cref="T:MFR.GettingListOfFilesToBeRenamedOperationStartedDescription"/> .
        /// </summary>
        [Log(AttributeExclude = true)]
        public static GettingListOfFilesToBeRenamedOperationTypeStartedDescription Instance
        {
            get;
        } = new GettingListOfFilesToBeRenamedOperationTypeStartedDescription();

        /// <summary>
        /// Gets one of the <see
        /// cref="T:MFR.OperationType"/> values that
        /// corresponds to the type of operation being performed.
        /// </summary>
        public OperationType OperationType
            => OperationType.GettingListOfFilesToBeRenamed;

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
        } = Resources.OperationStartedDescription_GettingListOfFilesToBeRenamed;
    }
}
