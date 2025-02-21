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
 */using MFR.CommandLine.Models.Interfaces;
using MFR.Settings.Configuration.Interfaces;
using MFR.Settings.Configuration.Providers.Factories;
using MFR.Settings.Configuration.Providers.Interfaces;
using PostSharp.Patterns.Diagnostics;
using System;
using System.Diagnostics;
using xyLOGIX.Core.Debug;
using xyLOGIX.Core.Extensions.Actions;

namespace MFR.CommandLine.Translators
{
    /// <summary>
    /// Exposes extension methods for objects that implement the
    /// <see cref="T:MFR.CommandLine.Models.Interfaces.ICommandLineInfo" /> interface.
    /// </summary>
    /// <remarks>
    /// The methods in this class translate objects that implement the
    /// <see cref="T:MFR.CommandLine.Models.Interfaces.ICommandLineInfo" /> interface
    /// into instances of objects of other types, such as an instance of an object that
    /// implements the
    /// <see
    ///     cref="T:MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfig" />
    /// interface, for example.
    /// </remarks>
    public static class TranslateCommandLineInfo
    {
        /// <summary>
        /// Gets a reference to the sole instance of the object that implements the
        /// <see
        ///     cref="T:MFR.Settings.Configuration.Providers.Interfaces.IProjectFileRenamerConfigProvider" />
        /// interface.
        /// </summary>
        /// <remarks>
        /// This object allows access to the user config and the
        /// actions
        /// associated with it.
        /// </remarks>
        private static IProjectFileRenamerConfigProvider ConfigProvider
        {
            [DebuggerStepThrough] get;
        } = GetProjectFileRenamerConfigProvider.SoleInstance();

        /// <summary>
        /// Gets or sets a reference to the one and only instance of the object that
        /// implements the
        /// <see
        ///     cref="T:MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfig" />
        /// interface that represents the currently-loaded config.
        /// </summary>
        private static IProjectFileRenamerConfig CurrentConfig
        {
            [DebuggerStepThrough] get => ConfigProvider.CurrentConfig;
            [DebuggerStepThrough] set => ConfigProvider.CurrentConfig = value;
        }

        /// <summary>
        /// Translates an instance of an object that implements the
        /// <see cref="T:MFR.CommandLine.Models.Interfaces.ICommandLineInfo" /> interface
        /// to an instance of an object that implements the
        /// <see
        ///     cref="T:MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfig" />
        /// interface.
        /// </summary>
        /// <param name="cmdInfo">
        /// (Required.) Reference to an instance of an object that implements the
        /// <see cref="T:MFR.CommandLine.Models.Interfaces.ICommandLineInfo" /> interface.
        /// </param>
        /// <returns>
        /// Reference to an instance of an object that implements the
        /// <see
        ///     cref="T:MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfig" />
        /// interface
        /// whose properties have been initialized with the values specified in the
        /// properties of the <paramref name="cmdInfo" /> object.
        /// </returns>
        [return: NotLogged]
        public static IProjectFileRenamerConfig ToConfig(
            [NotLogged] this ICommandLineInfo cmdInfo
        )
        {
            var result = CurrentConfig;

            try
            {
                DebugUtils.WriteLine(
                    DebugLevel.Info,
                    "TranslateCommandLineInfo.ToConfig: Checking whether the 'cmdInfo' method parameter has a null reference for a value..."
                );

                // Check to see if the required parameter, cmdInfo, is null. If it is, send an
                // error to the log file and quit, returning the default return value of this
                // method.
                if (cmdInfo == null)
                {
                    // the parameter cmdInfo is required.
                    DebugUtils.WriteLine(
                        DebugLevel.Error,
                        "TranslateCommandLineInfo.ToConfig: *** ERROR *** A null reference was passed for the 'cmdInfo' method parameter.  Stopping."
                    );

                    // stop.
                    return result;
                }

                DebugUtils.WriteLine(
                    DebugLevel.Info,
                    "TranslateCommandLineInfo.ToConfig: *** SUCCESS *** We have been passed a valid object reference for the 'cmdInfo' method parameter."
                );

                CurrentConfig.AutoQuitOnCompletion = Prefer.BoolOverNull(
                    cmdInfo.AutoQuitOnCompletion,
                    CurrentConfig.AutoQuitOnCompletion
                );
                CurrentConfig.AutoStart = cmdInfo.AutoStart;
                CurrentConfig.FindWhat = Prefer.StringOverBlank(
                    cmdInfo.FindWhat, CurrentConfig.FindWhat
                );
                CurrentConfig.IsFromCommandLine = true;
                CurrentConfig.MatchCase = Prefer.BoolOverNull(
                    cmdInfo.MatchCase, CurrentConfig.MatchCase
                );
                CurrentConfig.MatchExactWord = Prefer.BoolOverNull(
                    cmdInfo.MatchExactWord, CurrentConfig.MatchExactWord
                );
                CurrentConfig.RenameFilesInFolder = Prefer.BoolOverNull(
                    cmdInfo.RenameFilesInFolder,
                    CurrentConfig.RenameFilesInFolder
                );
                CurrentConfig.RenameSubFolders = Prefer.BoolOverNull(
                    cmdInfo.RenameSubFolders, CurrentConfig.RenameSubFolders
                );
                CurrentConfig.ReplaceTextInFiles = Prefer.BoolOverNull(
                    cmdInfo.ReplaceTextInFiles, CurrentConfig.ReplaceTextInFiles
                );
                CurrentConfig.ReplaceWith = Prefer.StringOverBlank(
                    cmdInfo.ReplaceWith, CurrentConfig.ReplaceWith
                );
                CurrentConfig.RenameSolutionFolders = Prefer.BoolOverNull(
                    cmdInfo.RenameSolutionFolders,
                    CurrentConfig.RenameSolutionFolders
                );
                CurrentConfig.ReOpenSolution = Prefer.BoolOverNull(
                    cmdInfo.ReOpenSolution, CurrentConfig.ReOpenSolution
                );
                CurrentConfig.ShouldCommitPendingChanges = Prefer.BoolOverNull(
                    cmdInfo.ShouldCommitPendingChanges,
                    CurrentConfig.ShouldCommitPendingChanges
                );
                CurrentConfig.ShouldCommitPostOperationChanges =
                    Prefer.BoolOverNull(
                        cmdInfo.ShouldCommitPostOperationChanges,
                        CurrentConfig.ShouldCommitPostOperationChanges
                    );
                CurrentConfig.StartingFolder = Prefer.StringOverBlank(
                    cmdInfo.StartingFolder, CurrentConfig.StartingFolder
                );
                CurrentConfig.UpdateGitOnAutoStart = Prefer.BoolOverNull(
                    cmdInfo.UpdateGitOnAutoStart,
                    CurrentConfig.UpdateGitOnAutoStart
                );

                if (CurrentConfig.IsFromCommandLine &&
                    CurrentConfig.UpdateGitOnAutoStart &&
                    CurrentConfig.AutoStart)
                    CurrentConfig.ShouldCommitPendingChanges =
                        CurrentConfig.ShouldCommitPostOperationChanges =
                            CurrentConfig.PushChangesToRemoteWhenDone = true;

                result = CurrentConfig;
            }
            catch (Exception ex)
            {
                // dump all the exception info to the log
                DebugUtils.LogException(ex);

                result = CurrentConfig;
            }

            return result;
        }
    }
}