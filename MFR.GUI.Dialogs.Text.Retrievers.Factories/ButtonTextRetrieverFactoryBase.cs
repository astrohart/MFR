using System;

namespace MFR.GUI.Dialogs.Text.Retrievers.Factories
{
    /// <summary>
    /// Creates instances of objects that implement the
    /// <see cref="T:MFR.GUI.Dialogs.Text.Retrievers.Interfaces.IButtonTextRetriever" />
    /// interface.
    /// </summary>
    /// <typeparam name="TEnumerator">
    /// Type name of the enumeration that is used to
    /// decide which object to create.
    /// </typeparam>
    public abstract class ButtonTextRetrieverFactoryBase<TEnumerator>
        where TEnumerator : Enum
    {
        /// <summary>
        /// Creates a new instance of an object that implements the
        /// <see cref="T:MFR.GUI.Dialogs.Text.Retrievers.Interfaces.IButtonTextRetriever" />
        /// interface and returns a reference to it.
        /// </summary>
        /// <param name="retrieverType">
        /// (Required.) One of the <typeparamref name="TEnumerator" /> values that
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
        public abstract string EnumerationValue(TEnumerator retrieverType);
    }
}