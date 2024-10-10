using MFR.Settings.Profiles.Interfaces;

namespace MFR.GUI.Windows.Presenters.Events
{
    /// <summary>
    /// Represents a handler for a CreateNewBlankProfileRequested event.
    /// </summary>
    /// <param name="sender">
    /// Reference to the instance of the object that raised the event.
    /// </param>
    /// <param name="e">
    /// A
    /// <see
    ///     cref="T:MFR.GUI.Windows.Presenters.Events.CreateNewBlankProfileRequestedEventArgs" />
    /// that contains the event data.
    /// </param>
    /// <remarks>
    /// This delegate merely specifies the signature of all methods that handle the
    /// CreateNewBlankProfileRequested event.
    /// </remarks>
    public delegate IProfile CreateNewBlankProfileRequestedEventHandler(
        object sender, CreateNewBlankProfileRequestedEventArgs e);
}