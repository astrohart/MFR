using MFR.GUI.Dialogs.Text.Retrievers.Interfaces;
using System;

namespace MFR.GUI.Dialogs.Text.Retrievers
{
    /// <summary>
    /// Defines the methods and properties that are common to all Button Text Retriever
    /// objects.
    /// </summary>
    /// <typeparam name="TEnumerator">
    /// Enumeration type used by child classes to decide
    /// what text that the button should display on its titlebar.
    /// </typeparam>
    public abstract class
        ButtonTextRetrieverBase<TEnumerator> : IButtonTextRetriever
        where TEnumerator : Enum
    {
        /// <summary>
        /// Constructs a new instance of
        /// <see cref="T:MFR.GUI.Dialogs.Text.Retrievers.ButtonTextRetrieverBase" /> and
        /// returns a reference to it.
        /// </summary>
        /// <param name="enumeratorValue">
        /// (Required.) Reference to an instance of the enumeration used to decide which
        /// text to set.
        /// </param>
        protected ButtonTextRetrieverBase(TEnumerator enumeratorValue)
        {
            OnSetText(enumeratorValue);
        }

        /// <summary>
        /// Gets a string containing the text that should be displayed on the button's
        /// title bar.
        /// </summary>
        public abstract string Text
        {
            get;
            protected set;
        }

        /// <summary>
        /// Called to set the value of the
        /// <see cref="P:MFR.GUI.Dialogs.Text.Retrievers.ButtonTextRetrieverBase.Text" />
        /// property based on the value of the enumeration provided.
        /// </summary>
        /// <param name="enumeratorValue">
        /// (Required.) Reference to an instance of the enumeration used to decide which
        /// text to set.
        /// </param>
        /// <remarks>After calling this method, then read the Text property.</remarks>
        protected abstract void OnSetText(TEnumerator enumeratorValue);
    }
}
