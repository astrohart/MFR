using MFR.GUI.Dialogs.Interfaces;
using PostSharp.Patterns.Diagnostics;

namespace MFR.GUI.Dialogs.Factories
{
    /// <summary>
    /// Creates new instances of objects that implement the
    /// <see
    ///     cref="T:MFR.GUI.Dialogs.Interfaces.ICancellableProgressDialog" />
    /// interface, and
    /// returns references to them.
    /// </summary>
    [Log(AttributeExclude = true)]
    public static class MakeNewProgressDialog
    {
        /// <summary>
        /// Creates a new instance of an object that implements the
        /// <see
        ///     cref="T:MFR.GUI.Dialogs.Interfaces.ICancellableProgressDialog" />
        /// interface and
        /// returns a reference to it.
        /// </summary>
        public static ICancellableProgressDialog FromScratch()
            => new CancellableProgressDialog();
    }
}