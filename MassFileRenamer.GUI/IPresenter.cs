using MassFileRenamer.Objects;
using System.Windows.Forms;

namespace MassFileRenamer.GUI
{
    /// <summary>
    /// Defines the publicly-exposed methods and properties of any object that
    /// has functionality common to all presenters.
    /// </summary>
    public interface IPresenter<TView, TChildPresenterInterface> : IConfigurationComposedObject where TView : class where TChildPresenterInterface : class
    {
        /// <summary>
        /// Dismisses the progress dialog.
        /// </summary>
        void CloseProgressDialog();

        /// <summary>
        /// Shows the progress window.
        /// </summary>
        void ShowProgressDialog();

        /// <summary>
        /// Updates data. Moves data from the screen to the model (
        /// <paramref
        ///     name="bSavingAndValidating" />
        /// equals <c>true</c>) or from the model
        /// to the screen ( <paramref name="bSavingAndValidating" /> equals <c>false</c>).
        /// </summary>
        /// <param name="bSavingAndValidating">
        /// Set to <c>true</c> to move data from the screen to the model;
        /// <c>false</c> to move data from the model to the screen.
        /// </param>
        /// <remarks>
        /// Note that whatever operations this method performs may potentially
        /// throw exceptions.
        /// </remarks>
        void UpdateData(bool bSavingAndValidating = true);

        /// <summary>
        /// Fluent-builder method to set a reference to the main window of the application.
        /// </summary>
        /// <param name="mainWindow">
        /// (Required.) Reference to an instance of an object that is of the
        /// <typeparamref name="TView" /> type and which represents the form that
        /// is to be associated with this presenter.
        /// </param>
        /// <returns>
        /// Reference to the same instance of the object that called this
        /// method, for fluent use.
        /// </returns>
        /// <exception cref="T:System.ArgumentNullException">
        /// Thrown if the required parameter, <paramref name="mainWindow" />, is
        /// passed a <c>null</c> value.
        /// </exception>
        TChildPresenterInterface HavingWindowReference(TView view);
    }
}