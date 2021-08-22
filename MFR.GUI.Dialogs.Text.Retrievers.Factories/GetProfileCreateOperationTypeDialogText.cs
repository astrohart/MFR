using MFR.GUI.Dialogs.Constants;
using PostSharp.Patterns.Diagnostics;

namespace MFR.GUI.Dialogs.Text.Retrievers.Factories
{
    /// <summary>
    /// Retrieves the text to be displayed on a dialog box's title bar given a
    /// particular
    /// <see cref="T:MFR.GUI.Dialogs.Constants.ProfileCreateOperationType" /> value.
    /// </summary>
    public class GetProfileCreateOperationTypeDialogText :
        DialogTextRetrieverFactoryBase<ProfileCreateOperationType>
    {
        /// <summary>
        /// Empty, static constructor to prohibit direct allocation of this class.
        /// </summary>
        [Log(AttributeExclude = true)]
        static GetProfileCreateOperationTypeDialogText() { }

        /// <summary>
        /// Empty, protected constructor to prohibit direct allocation of this class.
        /// </summary>
        [Log(AttributeExclude = true)]
        protected GetProfileCreateOperationTypeDialogText() { }

        /// <summary>
        /// Gets a reference to the one and only instance of
        /// <see
        ///     cref="T:MFR.GUI.Dialogs.Text.Retrievers.Factories.GetProfileCreateOperationTypeDialogText" />
        /// .
        /// </summary>
        [Log(AttributeExclude = true)]
        public static GetProfileCreateOperationTypeDialogText By
        {
            get;
        } = new GetProfileCreateOperationTypeDialogText();

        /// <summary>
        /// Creates a new instance of an object that implements the
        /// <see cref="T:MFR.GUI.Dialogs.Text.Retrievers.Interfaces.IDialogTextRetriever" />
        /// interface and returns a reference to it.
        /// </summary>
        /// <param name="retrieverType">
        /// (Required.) One of the <see cref="T:MFR.GUI.Dialogs.Constants.ProfileCreateOperationType"/> values that
        /// specifies which dialog text retriever object to create.
        /// </param>
        /// <returns>
        /// String containing the text that should be displayed on the calling dialog box's
        /// title bar.
        /// </returns>
        /// <remarks>
        /// This method is to be used for dialog boxes whose title bar text varies
        /// slightly, depending on the specific user operation for which the dialog box was
        /// summoned.
        /// </remarks>
        /// <exception cref="T:System.ArgumentOutOfRangeException">
        /// Thrown if the object retrieverType requested is not supported.
        /// </exception>
        public override string EnumerationValue(
            ProfileCreateOperationType retrieverType)
            => MakeNewProfileCreateOperationTypeDialogTextRetriever
               .FromScratch(retrieverType)
               .Text;
    }
}