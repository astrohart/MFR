namespace MFR.GUI.Dialogs.Text.Retrievers.Interfaces
{
    /// <summary>
    /// Defines the publicly-exposed methods and properties of a Button Text Retriever
    /// object.
    /// </summary>
    public interface IButtonTextRetriever
    {
        /// <summary>
        /// Gets a string containing the text that should be displayed on the button.
        /// </summary>
        string Text
        {
            get;
        }
    }
}