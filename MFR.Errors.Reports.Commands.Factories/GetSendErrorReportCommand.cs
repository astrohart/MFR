using MFR.GUI.Dialogs.Events;
using MFR.Messages.Commands.Interfaces;
using PostSharp.Patterns.Diagnostics;
using System.Diagnostics;

namespace MFR.Errors.Reports.Commands.Factories
{
    /// <summary>
    /// Creates instances of objects that implement the
    /// <see cref="T:MFR.Messages.Commands.Interfaces.ICommand" />, with a reference to
    /// a <see cref="T:MFR.GUI.Dialogs.Events.SendErrorReportRequestedEventArgs" /> as
    /// input, interface.
    /// </summary>
    public static class GetSendErrorReportCommand
    {
        /// <summary>
        /// Initializes static data or performs actions that need to be performed once only
        /// for the
        /// <see
        ///     cref="T:MFR.Errors.Reports.Commands.Factories.GetSendErrorReportCommand" />
        /// class.
        /// </summary>
        /// <remarks>
        /// This constructor is called automatically prior to the first instance being
        /// created or before any static members are referenced.
        /// <para />
        /// We've decorated this constructor with the <c>[Log(AttributeExclude = true)]</c>
        /// attribute in order to simplify the logging output.
        /// </remarks>
        [Log(AttributeExclude = true)]
        static GetSendErrorReportCommand() { }

        /// <summary>
        /// Creates a new instance of an object that implements the
        /// <see cref="T:MFR.Messages.Commands.Interfaces.ICommand" />, with a reference to
        /// a <see cref="T:MFR.GUI.Dialogs.Events.SendErrorReportRequestedEventArgs" /> as
        /// input, interface and returns a reference to it.
        /// </summary>
        /// <returns>
        /// Reference to an instance of an object that implements the
        /// <see cref="T:MFR.Messages.Commands.Interfaces.ICommand" /> interface with a
        /// reference to a
        /// <see cref="T:MFR.GUI.Dialogs.Events.SendErrorReportRequestedEventArgs" /> as
        /// input.
        /// </returns>
        /// <exception cref="T:System.ArgumentOutOfRangeException">
        /// Thrown if the object type requested is not supported.
        /// </exception>
        [DebuggerStepThrough]
        public static ICommand<SendErrorReportRequestedEventArgs> SoleInstance()
            => SendErrorReportCommand.Instance;
    }
}