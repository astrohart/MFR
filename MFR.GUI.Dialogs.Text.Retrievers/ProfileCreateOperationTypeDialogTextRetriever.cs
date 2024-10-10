using MFR.GUI.Dialogs.Constants;
using MFR.GUI.Dialogs.Text.Retrievers.Properties;
using System;

namespace MFR.GUI.Dialogs.Text.Retrievers
{
    /// <summary>
    /// Decides on what text a New Profile dialog box is to have in its title bar,
    /// based on the operation being performed.
    /// </summary>
    public class
        ProfileCreateOperationTypeDialogTextRetriever : DialogTextRetrieverBase<
            ProfileCreateOperationType>
    {
        /// <summary>
        /// Constructs a new instance of
        /// <see cref="T:MFR.GUI.Dialogs.Text.Retrievers.DialogTextRetrieverBase" /> and
        /// returns a reference to it.
        /// </summary>
        /// <param name="enumeratorValue">
        /// (Required.) Reference to an instance of the enumeration used to decide which
        /// text to set.
        /// </param>
        public ProfileCreateOperationTypeDialogTextRetriever(
            ProfileCreateOperationType enumeratorValue) :
            base(enumeratorValue) { }

        /// <summary>
        /// Gets a string containing the text that should be displayed on the dialog's
        /// title bar.
        /// </summary>
        public override string Text
        {
            get;
            protected set;
        }

        /// <summary>
        /// Called to set the value of the
        /// <see cref="P:MFR.GUI.Dialogs.Text.Retrievers.DialogTextRetrieverBase.Text" />
        /// property based on the value of the enumeration provided.
        /// </summary>
        /// <param name="enumeratorValue">
        /// (Required.) Reference to an instance of the enumeration used to decide which
        /// text to set.
        /// </param>
        /// <remarks>After calling this method, then read the Text property.</remarks>
        protected override void OnSetText(
            ProfileCreateOperationType enumeratorValue)
        {
            switch (enumeratorValue)
            {
                case ProfileCreateOperationType.New:
                    Text = Resources.Text_Dialogs_AddNewProifile;
                    break;

                case ProfileCreateOperationType.SaveAs:
                    Text = Resources.Text_Dialogs_SaveProfileAs;
                    break;

                default:
                    throw new ArgumentOutOfRangeException(
                        nameof(enumeratorValue), enumeratorValue,
                        Resources.Error_RequestedOperationTypeNotSupported
                    );
            }
        }
    }
}