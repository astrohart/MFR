using MFR.Settings.Configuration.Interfaces;

namespace MFR.GUI.Presenters.Interfaces
{
    /// <summary>
    /// Defines the publicly-exposed methods and properties of any object that
    /// has functionality common to all presenters.
    /// </summary>
    public interface
        IPresenter<TView, TChildPresenterInterface> :
            IConfigurationComposedObject where TView : class
        where TChildPresenterInterface : class
    {
        /// <summary>
        /// Fluent-builder method to set a reference to the main window of the application.
        /// </summary>
        /// <param name="view">
        /// (Required.) Reference to an instance of an object that is of the
        /// type <typeparamref name="TView" />, and which represents the form
        /// that is to be associated with this presenter.
        /// </param>
        /// <returns>
        /// Reference to the same instance of the object that called this
        /// method, for fluent use.
        /// </returns>
        /// <exception cref="T:System.ArgumentNullException">
        /// Thrown if the required parameter, <paramref name="view" />, is passed
        /// a <see langword="null" /> value.
        /// </exception>
        TChildPresenterInterface HavingWindowReference(TView view);

        /// <summary>
        /// Updates data. Moves data from the screen to the model (
        /// <paramref
        ///     name="bSavingAndValidating" />
        /// equals <see langword="true" />) or from
        /// the model to the screen ( <paramref name="bSavingAndValidating" />
        /// equals <see langword="false" />).
        /// </summary>
        /// <param name="bSavingAndValidating">
        /// Set to <see langword="true" /> to move data from the screen to the
        /// model; <see langword="false" /> to move data from the model to the screen.
        /// </param>
        /// <remarks>
        /// Note that whatever operations this method performs may potentially
        /// throw exceptions.
        /// </remarks>
        void UpdateData(bool bSavingAndValidating = true);
    }
}