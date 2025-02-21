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
 */using MFR.CommandLine.Parsers.Events;
using MFR.CommandLine.Parsers.Factories;
using MFR.CommandLine.Parsers.Interfaces;
using MFR.Common;
using MFR.Events;
using MFR.Events.Common;
using MFR.Operations.Constants;
using MFR.Operations.Events;
using MFR.Renamers.Files.Factories;
using MFR.Renamers.Files.Interfaces;
using MFR.Settings.Configuration.Interfaces;
using MFR.Settings.Configuration.Providers.Factories;
using MFR.Settings.Configuration.Providers.Interfaces;
using PostSharp.Patterns.Diagnostics;
using System;
using System.Diagnostics;
using xyLOGIX.Core.Debug;

namespace MFR.Console
{
    /// <summary>
    /// Provides the application-level functionality.
    /// </summary>
    public static class Program
    {
        /// <summary>
        /// Gets a reference to an instance of an object that implements the
        /// <see cref="T:MFR.CommandLine.Parsers.Interfaces.ICommandLineParser" />
        /// interface.
        /// </summary>
        private static ICommandLineParser CommandLineParser
        {
            [DebuggerStepThrough] get;
        } = GetCommandLineParser.SoleInstance();

        /// <summary>
        /// Gets a reference to an instance of an object that implements the
        /// <see
        ///     cref="T:MFR.Settings.Configuration.Providers.Interfaces.IProjectFileRenamerConfigProvider" />
        /// interface.
        /// </summary>
        private static IProjectFileRenamerConfigProvider ConfigProvider
        {
            [DebuggerStepThrough] get;
        } = GetProjectFileRenamerConfigProvider.SoleInstance();

        /// <summary>
        /// Gets a reference to an instance of an object that implements the
        /// <see
        ///     cref="T:MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfig" />
        /// interface.
        /// </summary>
        /// <remarks>
        /// This property has a getter and a setter, so that we can initialize it from the
        /// command line.
        /// </remarks>
        private static IProjectFileRenamerConfig CurrentConfig
        {
            [DebuggerStepThrough] get => ConfigProvider.CurrentConfig;
            [DebuggerStepThrough] set => ConfigProvider.CurrentConfig = value;
        }

        /// <summary>
        /// Gets a reference to an instance of an object that implements the
        /// <see cref="T:MFR.Renamers.Files.Interfaces.IFileRenamer" /> interface.
        /// </summary>
        private static IFileRenamer FileRenamer
        {
            [DebuggerStepThrough]
            get;
        } = GetFileRenamer.SoleInstance();

        /// <summary>
        /// Application entry point.
        /// </summary>
        [STAThread]
        public static void Main(string[] args)
        {
            try
            {
                Register.WindowsMessageFilter();

                CommandLineParser.DisplayHelp += OnDisplayHelp;

                ConfigProvider.Load();

                ParseCommandLine(args);

                FileRenamer.UpdateConfiguration(CurrentConfig);

                FileRenamer.StartingFrom(CurrentConfig.StartingFolder)
                           .AndAttachConfiguration(CurrentConfig);

                FileRenamer.FilesToHaveTextReplacedCounted +=
                    OnFilesToHaveTextReplacedCounted;
                FileRenamer.ProcessingOperation +=
                    OnFileRenamerProcessingOperation;
                FileRenamer.StatusUpdate += OnFileRenamerStatusUpdated;

                FileRenamer.ProcessAll(
                    CurrentConfig.FindWhat,
                    CurrentConfig.ReplaceWith
                );

                ConfigProvider.Save();

                Revoke.WindowsMessageFilter();

                System.Console.ReadKey();
            }
            catch (Exception e)
            {
                System.Console.WriteLine(e);
            }
        }

        /// <summary>
        /// Handles the <see cref="E:MFR.CommandLine.Parsers.Interfaces.ICommandLineParser.DisplayHelp"/> event raised by the <c>Command Line Parser</c> component.
        /// </summary>
        /// <param name="sender">Reference to an instance of the object that raised the event.</param>
        /// <param name="e">A <see cref="T:System.EventArgs"/> that contains the event data.</param>
        /// <remarks>This method responds by writing the help message to the console.</remarks>
        private static void OnDisplayHelp([NotLogged] object sender, [NotLogged] DisplayHelpEventArgs e)
            => System.Console.Write(e.HelpText);

        private static void OnFileRenamerProcessingOperation(
            [NotLogged] object sender,
            [NotLogged] ProcessingOperationEventArgs e
        )
        {
            switch (e.OperationType)
            {
                case OperationType.ReplaceTextInFiles:
                    System.Console.WriteLine(
                        $"Replace Text in Files: Processing '{e.Entry}'..."
                    );
                    break;

                case OperationType.RenameFilesInFolder:
                    System.Console.WriteLine(
                        $"Rename Files: Processing '{e.Entry}'..."
                    );
                    break;

                case OperationType.RenameSubFolders:
                    System.Console.WriteLine(
                        $"Rename Subfolders: Processing '{e.Entry}'..."
                    );
                    break;
            }
        }

        private static void OnFileRenamerStatusUpdated([NotLogged] object sender,
            [NotLogged] StatusUpdateEventArgs e
        )
            => System.Console.WriteLine(e.Text);

        private static void OnFilesToHaveTextReplacedCounted(
            [NotLogged] object sender,
            [NotLogged] FilesOrFoldersCountedEventArgs e
        )
        {
            switch (e.OperationType)
            {
                case OperationType.ReplaceTextInFiles:
                    System.Console.WriteLine(
                        $"Replace Text in Files: {e.Count} files are to be processed."
                    );
                    break;

                case OperationType.RenameFilesInFolder:
                    System.Console.WriteLine(
                        $"Rename Files: {e.Count} files are to be processed."
                    );
                    break;

                case OperationType.RenameSubFolders:
                    System.Console.WriteLine(
                        $"Rename Subfolders: {e.Count} folders are to be processed."
                    );
                    break;
            }
        }

        private static void ParseCommandLine(string[] args)
        {
            try
            {
                if (args == null) return;
                if (args.Length == 0) return;

                var cmdInfo = CommandLineParser.Parse(args);

                if (cmdInfo.AutoStart !=
                    CurrentConfig.AutoStart)
                    CurrentConfig.AutoStart = cmdInfo.AutoStart;
                if (!string.IsNullOrWhiteSpace(cmdInfo.FindWhat) &&
                    !cmdInfo.FindWhat.Equals(CurrentConfig.FindWhat))
                    CurrentConfig.FindWhat = cmdInfo.FindWhat;
                if (cmdInfo.MatchCase.HasValue && cmdInfo.MatchCase !=
                    CurrentConfig.MatchCase)
                    CurrentConfig.MatchCase = (bool)cmdInfo.MatchCase;
                if (cmdInfo.MatchExactWord.HasValue && cmdInfo.MatchExactWord !=
                    CurrentConfig.MatchExactWord)
                    CurrentConfig.MatchExactWord =
                        (bool)cmdInfo.MatchExactWord;
            }
            catch (Exception ex)
            {
                // dump all the exception info to the log
                DebugUtils.LogException(ex);
            }
        }
    }
}