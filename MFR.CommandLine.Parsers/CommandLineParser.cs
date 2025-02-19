using Alphaleonis.Win32.Filesystem;
using Fclp;
using MFR.CommandLine.Models;
using MFR.CommandLine.Models.Factories;
using MFR.CommandLine.Models.Interfaces;
using MFR.CommandLine.Parsers.Events;
using MFR.CommandLine.Parsers.Interfaces;
using PostSharp.Patterns.Diagnostics;
using System;
using System.Diagnostics;
using System.Linq;
using xyLOGIX.Core.Debug;
using xyLOGIX.Win32.Interact;

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
        public static ICommandLineParser Instance
        {
            [DebuggerStepThrough] get;
        } = new CommandLineParser();

        /// <summary>
        /// Occurs when Help text is to be displayed.
        /// </summary>
        public event DisplayHelpEventHandler DisplayHelp;

        /// <summary>
        /// Parses the application's command-line arguments and sets the properties of a
        /// new instance of an object that implements the
        /// <see cref="T:MFR.CommandLine.Models.Interfaces.ICommandLineInfo" /> interface
        /// accordingly.
        /// </summary>
        /// <param name="args">
        /// (Required.) Array containing the command-line arguments passed to this
        /// application.
        /// application.
        /// </param>
        [return: NotLogged]
        public ICommandLineInfo Parse([NotLogged] string[] args)
        {
            DebugUtils.WriteLine(
                DebugLevel.Info,
                "CommandLineParser.Parse: Attempting to parse command line argument(s)..."
            );

            var result = MakeNewCommandLineInfo.FromScratch();

            // Keep this variable outside the try/catch, so a help message can be shown if an error occurs.
            var p = new FluentCommandLineParser<CommandLineInfo>();

            try
            {
                DebugUtils.WriteLine(
                    DebugLevel.Info,
                    "CommandLineParser.Parse: Checking whether the 'args' method parameter has a null reference for a value..."
                );

                // Check to see if the required parameter, args, is null. If it is, send an 
                // error to the log file and quit, returning the default return value of this
                // method.
                if (args == null)
                {
                    // The parameter, 'args', is required and is not supposed to have a NULL value.
                    DebugUtils.WriteLine(
                        DebugLevel.Error,
                        "CommandLineParser.Parse: *** ERROR *** A null reference was passed for the 'args' method parameter.  Stopping..."
                    );

                    // stop.
                    return result;
                }

                DebugUtils.WriteLine(
                    DebugLevel.Info,
                    "CommandLineParser.Parse: *** SUCCESS *** We have been passed a valid object reference for the 'args' method parameter.  Proceeding..."
                );

                DebugUtils.WriteLine(
                    DebugLevel.Info,
                    "CommandLineParser.Parse *** INFO: Checking whether the array, 'args', has greater than zero elements..."
                );

                // Check whether the array, 'args', has greater than zero elements.  If it is empty,
                // then write an error message to the log file, and then terminate the execution of this method.
                // It is preferred for the array to have greater than zero elements.
                if (args.Length <= 0)
                {
                    // The array, 'args', has zero elements, and we can't proceed if this is so.
                    DebugUtils.WriteLine(
                        DebugLevel.Error,
                        "CommandLineParser.Parse *** ERROR *** The array, 'args', has zero elements.  Stopping..."
                    );

                    DebugUtils.WriteLine(
                        DebugLevel.Debug,
                        $"*** CommandLineParser.Parse: Result = {result}"
                    );

                    // stop.
                    return result;
                }

                DebugUtils.WriteLine(
                    DebugLevel.Info,
                    $"CommandLineParser.Parse *** SUCCESS *** {args.Length} element(s) were found in the 'args' array.  Parsing the command-line argument(s)..."
                );

                p.Setup(arg => arg.AutoStart)
                 .As("autoStart")
                 .SetDefault(false)
                 .WithDescription(
                     "Specify this flag to automatically start the specified operation(s) when the application starts and then quit when done. "
                 );

                p.Setup(arg => arg.FindWhat)
                 .As("findWhat")
                 .SetDefault(string.Empty)
                 .WithDescription(
                     "Sets the string to be found in file system entries."
                 );

                /*
                 * Originally, the replaceWith command-line argument was deemed
                 * okay to be made optional, with a default of the empty string.
                 *
                 * Here, however, we are making the parameter required and not
                 * defaulting to an empty string.  The thought occurs that setting
                 * text within a file to a blank string is okay, but allowing this
                 * command-line argument to be a blank string runs the risk of us
                 * setting the names of files and folders to be blank, which the
                 * operating system does not allow.
                 *
                 * Therefore, we updated this parameter to being required.
                 */

                p.Setup(arg => arg.RenameFilesInFolder)
                 .As("renameFiles")
                 .WithDescription("Indicates that files should be renamed.")
                 .SetDefault(true);

                p.Setup(arg => arg.RenameSubFolders)
                 .As("renameSubFolders")
                 .WithDescription("Indicates that folders should be renamed.")
                 .SetDefault(true);

                p.Setup(arg => arg.RenameSolutionFolders)
                 .As("renameSolutionFolders")
                 .WithDescription(
                     "Indication that the search text should be found and replaced in the same of those folder(s) in the directory tree that contain .sln files."
                 )
                 .SetDefault(false);

                p.Setup(arg => arg.ReOpenSolution)
                 .As("reOpenSolution")
                 .SetDefault(true)
                 .WithDescription(
                     "Indicates that any currently-open Solution in the target directory should be re-loaded when the operation(s) are completed."
                 )
                 .SetDefault(true);
                
                p.Setup(arg => arg.ReplaceTextInFiles)
                 .As("replaceTextInFiles")
                 .WithDescription(
                     "Indicates that text should be replaced in files."
                 )
                 .SetDefault(true);

                p.Setup(arg => arg.ShouldCommitPendingChanges)
                 .As("commitPendingChanges")
                 .SetDefault(null)
                 .WithDescription(
                     "Determines whether pending changes are to be committed to the local Git repository before the specified operation(s) are performed."
                 );

                p.Setup(arg => arg.ShouldCommitPostOperationChanges)
                 .As("commitPostOperationChanges")
                 .SetDefault(null)
                 .WithDescription(
                     "Determines whether post-operation changes are to be committed to the local Git repository."
                 );
                
                p.Setup(arg => arg.StartingFolder)
                 .As('r', "root")
                 .SetDefault(string.Empty)
                 .WithDescription(
                     "Sets the directory that this application begins in."
                 )
                 .Required()
                 .SetDefault(Directory.GetCurrentDirectory());

                p.Setup(arg => arg.MatchCase)
                 .As("matchCase")
                 .SetDefault(true)
                 .WithDescription(
                     "Indicates that a case-sensitive search should be performed."
                 );

                p.Setup(arg => arg.MatchExactWord)
                 .As("matchWholeWord")
                 .SetDefault(false)
                 .WithDescription(
                     "Indicates that a whole-word search (respecting periods) should be performed."
                 );

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
                if (!result.RenameFilesInFolder && !result.RenameSubFolders &&
                    !result.ReplaceTextInFiles)
                    result.RenameFilesInFolder = result.RenameSubFolders =
                        result.ReplaceTextInFiles = true;

                DebugUtils.WriteLine(
                    DebugLevel.Info,
                    "CommandLineParser.Parse: *** SUCCESS *** The command-line argument(s) of the application were parsed successfully.  Proceeding..."
                );
            }
            catch (Exception ex)
            {
                // dump all the exception info to the log
                DebugUtils.LogException(ex);

                if (p != null && p.Options.Any())
                    p.HelpOption.ShowHelp(p.Options);

                Messages.ShowStopError(
                    $"Failed to parse the command-line argument(s) that were passed to the application.\n\n{ex.Message}.\n\nThe application will now close."
                );

                Environment.Exit(-1);

                result = MakeNewCommandLineInfo.FromScratch();
            }

            return result;
        }

        /// <summary>
        /// Raises the
        /// <see cref="E:MFR.CommandLine.Parsers.CommandLineParser.DisplayHelp" /> event.
        /// </summary>
        /// <param name="e">
        /// A
        /// <see cref="T:MFR.CommandLine.Parsers.Events.DisplayHelpEventArgs" /> that
        /// contains the event data.
        /// </param>
        protected virtual void OnDisplayHelp(
            [NotLogged] DisplayHelpEventArgs e)
            => DisplayHelp?.Invoke(this, e);
    }
}