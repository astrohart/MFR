using MFR.Errors.Reports.Commands.Constants;
using PostSharp.Patterns.Diagnostics;
using MFR.Messages.Commands.Interfaces;
using MFR.Messages.Constants;
using System;

namespace MFR.Errors.Reports.Commands.Factories
{
    /// <summary>
    /// Creates instances of objects that implement the <see
    /// cref="T:MFR.ICommand"/> interface, that define operations on the configuration file and its data.
    /// </summary>
    /// <remarks>
    /// In our vernacular, a <c>command</c> object is an object that performs an
    /// operation that accepts input, but has no output.
    /// </remarks>
    [Log(AttributeExclude = true)]
    public static class GetErrorReportCommandType
    {
        /// <summary>
        /// Creates a new instance of an object that implements the <see
        /// cref="T:MFR.ICommand"/> interface and returns a reference to it.
        /// </summary>
        public static ICommand<TInput> For<TInput>(MessageType type)
            where TInput : class
        {
            ICommand<TInput> command;

            switch (type)
            {
                case var _ when type == ErrorReportCommandType.ViewErrorReportWithNotepad:
                    command =
                        (ICommand<TInput>) GetViewErrorReportWithNotepadCommand.SoleInstance();
                    break;

                default:
                    throw new ArgumentOutOfRangeException(
                        nameof(type), type,
                        $"There is no command available that corresponds to the message type '{type}'."
                    );
            }

            return command;
        }
    }
}
