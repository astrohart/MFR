using PostSharp.Patterns.Threading;
using System;

namespace MFR.CommandLine.Parsers.Events
{
    /// <summary>
    /// Provides information for DisplayHelp event handlers.
    /// </summary>
[ExplicitlySynchronized]
    public class DisplayHelpEventArgs : EventArgs
    {
        /// <summary>
        /// Constructs a new instance of
        /// <see cref="T:MFR.CommandLine.Parsers.Events.DisplayHelpEventArgs" /> and
        /// returns a reference to it.
        /// </summary>
        /// <param name="helpText">
        /// (Required.) String containing the Help text that is to be displayed.
        /// </param>
        public DisplayHelpEventArgs(string helpText)
        {
            HelpText = helpText;
        }

        /// <summary>
        /// Gets a string that contains the Help text that is to be displayed.
        /// </summary>
        public string HelpText
        {
            get;
        }
    }
}