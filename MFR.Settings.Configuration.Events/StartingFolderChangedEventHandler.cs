using System;

namespace MFR.Settings.Configuration.Events
{
    /// <summary>
    /// Represents a handler for a <c>StartingFolderChanged</c> event.
    /// </summary>
    /// <param name="sender">
    /// Reference to the instance of the object that raised the event.
    /// </param>
    /// <param name="e">
    /// A <see cref="T:System.EventArgs" /> that contains the event data.
    /// </param>
    /// <remarks>
    /// This delegate merely specifies the signature of all methods that handle the
    /// <c>StartingFolderChanged</c> event.
    /// </remarks>
    public delegate void StartingFolderChangedEventHandler(object sender,
        EventArgs e);
}