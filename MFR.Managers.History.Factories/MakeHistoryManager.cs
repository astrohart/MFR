using MFR.Managers.History.Interfaces;
using System.Windows.Forms;

namespace MFR.Managers.History.Factories
{
    /// <summary>
    /// Creates new instances of History Manager objects.
    /// </summary>
    public static class MakeHistoryManager
    {
        /// <summary>
        /// Obtains a reference to an newly-created instance of a History
        /// Manager object that is associated with the specified <paramref name="form" />.
        /// </summary>
        /// <param name="form">
        /// (Required.) Reference to an instance of an object that implements
        /// the <see cref="T:System.Windows.Forms.IWin32Window" /> interface.
        /// <para />
        /// This object should represent the parent form of the controls for
        /// which the returned History Manager object is managing input history.
        /// </param>
        /// <returns>
        /// Reference to an instance of an object that implements the
        /// <see
        ///     cref="T:MFR.IHistoryManager" />
        /// interface and
        /// which is associated with the specified <paramref name="form" />.
        /// </returns>
        public static IHistoryManager ForForm(IWin32Window form)
            => new HistoryManager(form);
    }
}