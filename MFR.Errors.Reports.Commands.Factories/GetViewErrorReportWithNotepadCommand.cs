using MFR.GUI.Dialogs.Events;
using MFR.Messages.Commands.Interfaces;

namespace MFR.Errors.Reports.Commands.Factories
{
    /// <summary>
    /// Creates instances of objects that implement the
    /// <see cref="T:MFR.Messages.Commands.Interfaces.ICommand" />, with a reference to
    /// a <see cref="T:MFR.GUI.Dialogs.Events.ViewErrorReportRequestedEventArgs" /> as
    /// input, interface.
    /// </summary>
    public static class GetViewErrorReportWithNotepadCommand
    {
        /// <summary>
        /// Creates a new instance of an object that implements the
        /// <see cref="T:MFR.Messages.Commands.Interfaces.ICommand" />, with a reference to
        /// a <see cref="T:MFR.GUI.Dialogs.Events.ViewErrorReportRequestedEventArgs" /> as
        /// input, interface and returns a reference to it.
        /// </summary>
        /// <returns>
        /// Reference to an instance of an object that implements the
        /// <see cref="T:MFR.Messages.Commands.Interfaces.ICommand" /> interface with a
        /// reference to a
        /// <see cref="T:MFR.GUI.Dialogs.Events.ViewErrorReportRequestedEventArgs" /> as
        /// input.
        /// </returns>
        /// <exception cref="T:System.ArgumentOutOfRangeException">
        /// Thrown if the object type requested is not supported.
        /// </exception>
        public static ICommand<ViewErrorReportRequestedEventArgs> SoleInstance()
            => ViewErrorReportWithNotepadCommand.Instance;
    }
}