namespace MFR.GUI.Dialogs.Text.Retrievers.Interfaces
{
    /// <summary>
    /// Defines the publicly-exposed methods and properties of a Dialog Text Retriever
    /// object.
    /// </summary>
    public interface IDialogTextRetriever
    {
        /// <summary>
        /// Gets a string containing the text that should be displayed on the dialog's
        /// title bar.
        /// </summary>
        string Text
        {
            get;
        }
    }
}