using MFR.GUI.Windows.Presenters;

namespace MFR.GUI.Presenters.Associators
{
    /// <summary>
    /// Associates presenters with views.
    /// </summary>
    /// <typeparam name="TPresenterInterface">
    /// Name of the interface that the presenter you want implements.
    /// </typeparam>
    public static class AssociatePresenter<TPresenterInterface>
        where TPresenterInterface : class
    {
        /// <summary>
        /// Gets a reference to an instance of an object that implements the
        /// <typeparamref name="TPresenterInterface" /> interface for the
        /// specified view.
        /// </summary>
        /// <returns>
        /// Reference to an instance of an object that implements the
        /// <typeparamref name="TPresenterInterface" /> interface.
        /// </returns>
        public static TPresenterInterface WithView()
            => new MainWindowPresenter() as TPresenterInterface;
    }
}