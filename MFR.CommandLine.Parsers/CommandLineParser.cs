/*71b451a5-ec2a-4538-a74d-a520fd3c98ef
 * # xyLOGIX Project File Renamer License
 * 
 * This software and associated documentation files (the "Software") are the exclusive property of xyLOGIX, LLC ("xyLOGIX"), a Tennessee Limited Liability Company. Copyright © 2025 by 
 * xyLOGIX, LLC.  All rights reserved.
 * 
 * ## License Grant
 * 
 * Permission is hereby granted, free of charge, to any person obtaining a copy of this Software, to use the Software solely for the purpose of evaluating its functionality and performance.
 * This license does not grant the right to modify, distribute, sublicense, or sell copies of the Software, nor to use the Software for any commercial purpose.
 * 
 * ## Restrictions
 * 
 * 1.  No Distribution: You may not distribute, sublicense, or sell copies of the Software, in whole or in part, to any third party.
 * 2.  No Modification:  You may not modify, adapt, or create derivative works of the Software.
 * 3.  No Reverse Engineering:  You may not reverse engineer, decompile, or disassemble the Software.
 * 4.  No Commercial Use:  You may not use the Software for any commercial purpose without the prior written consent of xyLOGIX.
 * 5.  No Removal of Notices:  You may not remove or alter any proprietary notices, labels, or marks on the Software.
 * 
 * ## Intellectual Property Rights
 * 
 * All intellectual property rights, including but not limited to copyrights, patents, trademarks, and trade secrets, in and to the Software are and shall remain the exclusive property of xyLOGIX.
 * This license does not transfer any ownership rights in the Software to you.
 * 
 * ## Disclaimer of Warranty
 * 
 * THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE, AND NON-INFRINGEMENT. 
 * IN NO EVENT SHALL XYLOGIX BE LIABLE FOR ANY CLAIM, DAMAGES, OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT, OR OTHERWISE, ARISING FROM, OUT OF, OR IN CONNECTION WITH THE SOFTWARE OR THE USE 
 * OR OTHER DEALINGS IN THE SOFTWARE.
 * 
 * ## Limitation of Liability
 * 
 * IN NO EVENT SHALL XYLOGIX BE LIABLE FOR ANY INDIRECT, INCIDENTAL, SPECIAL, EXEMPLARY, OR CONSEQUENTIAL DAMAGES (INCLUDING, BUT NOT LIMITED TO, PROCUREMENT OF SUBSTITUTE GOODS OR SERVICES; LOSS OF USE, DATA, OR
 * PROFITS; OR BUSINESS INTERRUPTION) HOWEVER CAUSED AND ON ANY THEORY OF LIABILITY, WHETHER IN CONTRACT, STRICT LIABILITY, OR TORT(INCLUDING NEGLIGENCE OR OTHERWISE) ARISING IN ANY WAY OUT OF THE USE OF THE SOFTWARE
 * EVEN IF ADVISED OF THE POSSIBILITY OF SUCH DAMAGE.
 * 
 * ## Termination
 * 
 * This license is effective until terminated.  Your rights under this license will terminate automatically without notice from xyLOGIX if you fail to comply with any term(s) of this license. Upon termination, you must
 * cease all use of the Software and destroy all copies, full or partial, of the Software.
 * 
 * ## Governing Law
 *
 * This license shall be governed by and construed in accordance with the laws of the State of Washington, without regard to its conflict of laws principles and without regard to the principle of contra proferentem.
 *
 * ## Contact Information
 *
 * For inquiries regarding this license, please contact:
 *
 * xyLOGIX, LLC
 * info@xylogix.net
 */

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
using xyLOGIX.Files.Actions;
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

                p.Setup(arg => arg.AutoQuitOnCompletion)
                 .As("autoQuit")
                 .SetDefault(null)
                 .WithDescription(
                     "Specifies whether the application is to be exited when the specified operation(s) have been completed."
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

                p.Setup(arg => arg.MatchCase)
                 .As("matchCase")
                 .SetDefault(null)
                 .WithDescription(
                     "Indicates that a case-sensitive search should be performed."
                 );

                p.Setup(arg => arg.MatchExactWord)
                 .As("matchWholeWord")
                 .SetDefault(null)
                 .WithDescription(
                     "Indicates that a whole-word search (respecting periods) should be performed."
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
                 .SetDefault(null);

                p.Setup(arg => arg.RenameSubFolders)
                 .As("renameSubFolders")
                 .WithDescription("Indicates that folders should be renamed.")
                 .SetDefault(null);

                p.Setup(arg => arg.RenameSolutionFolders)
                 .As("renameSolutionFolders")
                 .WithDescription(
                     "Indication that the search text should be found and replaced in the same of those folder(s) in the directory tree that contain .sln files."
                 )
                 .SetDefault(null);

                p.Setup(arg => arg.ReOpenSolution)
                 .As("reOpenSolution")
                 .SetDefault(null)
                 .WithDescription(
                     "Indicates that any currently-open Solution in the target directory should be re-loaded when the operation(s) are completed."
                 )
                 .SetDefault(null);

                p.Setup(arg => arg.ReplaceTextInFiles)
                 .As("replaceTextInFiles")
                 .WithDescription(
                     "Indicates that text should be replaced in files."
                 )
                 .SetDefault(null);

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

                p.Setup(arg => arg.UpdateGitOnAutoStart)
                 .As("updateGitOnAutoStart")
                 .SetDefault(null)
                 .WithDescription(
                     "Indicates that the local Git repository should be updated when the application is auto-started."
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
                if (!result.RenameFilesInFolder.HasValue &&
                    !result.RenameSubFolders.HasValue &&
                    !result.ReplaceTextInFiles.HasValue)
                    result.RenameFilesInFolder = result.RenameSubFolders =
                        result.ReplaceTextInFiles = true;

                if (!result.RenameSolutionFolders.HasValue)
                    result.RenameSolutionFolders = false;

                if (!result.ReOpenSolution.HasValue)
                    result.ReOpenSolution = Does.FolderHaveAtLeastOneFileMatching(result.StartingFolder, "*.sln", false);

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
        protected virtual void OnDisplayHelp([NotLogged] DisplayHelpEventArgs e)
            => DisplayHelp?.Invoke(this, e);
    }
}