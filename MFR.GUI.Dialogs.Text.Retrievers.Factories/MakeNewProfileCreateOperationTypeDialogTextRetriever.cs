using MFR.GUI.Dialogs.Text.Retrievers.Interfaces;
using PostSharp.Patterns.Diagnostics;

namespace MFR.GUI.Dialogs.Text.Retrievers.Factories
{
    /// <summary>
    /// Creates new instances of objects that implement the
    /// <see cref="T:MFR.GUI.Dialogs.Text.Retrievers.Interfaces.IDialogTextRetriever" />
    /// interface, specifically for the values of the
    /// <see cref="T:MFR.GUI.Dialogs.Constants.ProfileCreateOperationType" />
    /// enumeration, and returns references to them.
    /// </summary>
    [Log(AttributeExclude = true)]
    public static class MakeNewProfileCreateOperationTypeDialogTextRetriever
    {
        /// <summary>
        /// Creates a new instance of an object that implements the
        /// <see cref="T:MFR.GUI.Dialogs.Text.Retrievers.Interfaces.IDialogTextRetriever" />
        /// interface and returns a reference to it.
        /// </summary>
        /// <returns>
        /// Reference to an instance of an object that implements the
        /// <see cref="T:MFR.GUI.Dialogs.Text.Retrievers.Interfaces.IDialogTextRetriever" />
        /// interface.
        /// </returns>
        /// <param name="enumeratorValue">
        /// (Required.) Reference to an instance of the enumeration used to decide which
        /// text to set.
        /// </param>
        public static IDialogTextRetriever FromScratch(dynamic enumeratorValue)
            => new ProfileCreateOperationTypeDialogTextRetriever(
                enumeratorValue
            );
    }
}