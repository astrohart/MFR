using Alphaleonis.Win32.Filesystem;
using Fclp;
using MFR.CommandLine.Constants;
using MFR.CommandLine.Models;
using MFR.CommandLine.Models.Factories;
using MFR.CommandLine.Models.Interfaces;
using MFR.CommandLine.Parsers.Events;
using MFR.CommandLine.Parsers.Interfaces;
using PostSharp.Patterns.Diagnostics;
using System;
using System.Linq;
using xyLOGIX.Core.Debug;

namespace MFR.CommandLine.Parsers
{
    /// <summary>
    /// Manages the parsing and validation of the command line of the application.
    /// </summary>
    public class CommandLineParser : ICommandLineParser
    {
        /// <summary>
        /// Empty, static constructor to prohibit direct allocation of this class.
        /// </summary>
        [Log(AttributeExclude = true)]
        static CommandLineParser() { }

        /// <summary>
        /// Empty, protected constructor to prohibit direct allocation of this class.
        /// </summary>
        [Log(AttributeExclude = true)]
        protected CommandLineParser() { }

        /// <summary>
        /// Gets a reference to the one and only instance of
        /// <see cref="T:MFR.CommandLine.Parsers.CommandLineParser" />.
        /// </summary>
        [Log(AttributeExclude = true)]
        public static ICommandLineParser Instance
        {
            get;
        } = new CommandLineParser();

        /// <summary>
        /// Parses the application's command-line arguments and sets the properties of a
        /// new instance of an object that implements the
        /// <see cref="T:MFR.CommandLine.Models.Interfaces.ICommandLineInfo" /> interface
        /// accordingly.
        /// </summary>
        /// <param name="args">
        /// (Required.) Array containing the command-line arguments passed to this application.
        /// application.
        /// </param>
        public ICommandLineInfo Parse(string[] args)
        {
            var result = MakeNewCommandLineInfo.FromScratch();
            if (args == null || !args.Any())
                return result;

            var p = new FluentCommandLineParser<CommandLineInfo>();

            try
            {
                p.Setup(arg => arg.StartingFolder)
                 .As('r', "root")
                 .WithDescription(
                     "Sets the directory that this application begins in."
                 )
                 .Required()
                 .SetDefault(Directory.GetCurrentDirectory());

                p.Setup(arg => arg.FindWhat)
                 .As("findWhat")
                 .WithDescription(
                     "Sets the string to be found in file system entries."
                 )
                 .Required();

                p.Setup(arg => arg.ReplaceWith)
                 .As("replaceWith")
                 .WithDescription(
                     "Sets the string to be substituted in file system entry names."
                 )
                 .SetDefault(string.Empty);

                p.Setup(arg => arg.RenameFiles)
                 .As("renameFiles")
                 .WithDescription("Indicates that files should be renamed.")
                 .SetDefault(true);

                p.Setup(arg => arg.RenameSubFolders)
                 .As("renameSubFolders")
                 .WithDescription("Indicates that folders should be renamed.")
                 .SetDefault(true);

                p.Setup(arg => arg.ReplaceTextInFiles)
                 .As("replaceTextInFiles")
                 .WithDescription(
                     "Indicates that text should be replaced in files."
                 )
                 .SetDefault(true);

                p.Setup(arg => arg.ReOpenSolution)
                 .As("reOpenSolution")
                 .WithDescription(
                     "Indicates that any currently-open Solution in the target directory should be re-loaded when the operation(s) are completed."
                 )
                 .SetDefault(false);

                p.Setup(arg => arg.MatchCase)
                 .As("matchCase")
                 .WithDescription(
                     "Indicates that a case-sensitive search should be performed."
                 )
                 .SetDefault(true);

                p.Setup(arg => arg.MatchWholeWord)
                 .As("matchWholeWord")
                 .WithDescription(
                     "Indicates that a case-sensitive search should be performed."
                 )
                 .SetDefault(false);

                p.SetupHelp("?", "help")
                 .Callback(
                     text => OnDisplayHelp(new DisplayHelpEventArgs(text))
                 );

                var parsingResult = p.Parse(args);
                if (parsingResult != null && parsingResult.HasErrors)
                    throw new InvalidOperationException(
                        "ERROR: Failed to parse command line."
                    );

                result = p.Object;

                /*
                 * If the user didn't specify any of the operation flags
                 * on the command line, assume that the user wants to perform
                 * all of them.
                 */
                if (!result.RenameFiles && !result.RenameSubFolders &&
                    !result.ReplaceTextInFiles)
                    result.RenameFiles = result.RenameSubFolders =
                        result.ReplaceTextInFiles = true;
            }
            catch (Exception ex)
            {
                // dump all the exception info to the log
                DebugUtils.LogException(ex);

                if (p != null && p.Options.Any())
                    p.HelpOption.ShowHelp(p.Options);

                Environment.Exit(-1);
            }

            return result;
        }

        /// <summary>
        /// Occurs when Help text is to be displayed.
        /// </summary>
        public event DisplayHelpEventHandler DisplayHelp;

        /// <summary>
        /// Raises the
        /// <see cref="E:MFR.CommandLine.Parsers.CommandLineParser.DisplayHelp" /> event.
        /// </summary>
        /// <param name="e">
        /// A
        /// <see cref="T:MFR.CommandLine.Parsers.Events.DisplayHelpEventArgs" /> that
        /// contains the event data.
        /// </param>
        protected virtual void OnDisplayHelp(DisplayHelpEventArgs e)
            => DisplayHelp?.Invoke(this, e);
    }
}
