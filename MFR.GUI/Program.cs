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

using MFR.Common;
using MFR.GUI.Actions;
using MFR.GUI.Application.Factories;
using MFR.GUI.Application.Interfaces;
using MFR.GUI.Properties;
using MFR.Settings.Configuration.Providers.Factories;
using MFR.Settings.Configuration.Providers.Interfaces;
using PostSharp.Patterns.Diagnostics;
using System;
using System.Diagnostics;
using xyLOGIX.Core.Debug;
using xyLOGIX.Interop.Processes.Actions;
using xyLOGIX.Win32.Interact;

namespace MFR.GUI
{
    /// <summary>
    /// Provides the entry point for the program and all application-level
    /// functionality.
    /// </summary>
    public static class Program
    {
        /// <summary>
        /// Initializes static data or performs actions that need to be performed once only
        /// for the <see cref="T:MFR.GUI.Program" /> class.
        /// </summary>
        /// <remarks>
        /// This constructor is called automatically prior to the first instance being
        /// created or before any static members are referenced.
        /// <para />
        /// We've decorated this constructor with the <c>[Log(AttributeExclude = true)]</c>
        /// attribute in order to simplify the logging output.
        /// </remarks>
        [Log(AttributeExclude = true)]
        static Program() { }

        /// <summary>
        /// Gets a reference to an instance of an object that implements the
        /// <see cref="T:MFR.GUI.Application.Interfaces.IWinApp" /> interface.
        /// </summary>
        private static IWinApp Application
        {
            [DebuggerStepThrough] get;
        } = GetProjectFileRenamerApp.SoleInstance();

        /// <summary>
        /// Gets a <see cref="T:System.String" /> that contains the fully-qualified
        /// pathname of the currently-loaded config file.
        /// </summary>
        private static string ConfigFilePath
        {
            [DebuggerStepThrough] get => ConfigProvider.ConfigFilePath;
        }

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
        /// The main entry point for the application.
        /// </summary>
        /// <param name="args">
        /// (Optional.) Array of strings, each of which represents a different
        /// command-line argument passed to this application.
        /// </param>
        [STAThread]
        public static void Main([NotLogged] string[] args)
        {
            SetUpLogging(); // has to be called here for the log file to be stored in the proper location.

            if (!Register.WindowsMessageFilter())
            {
                Messages.ShowStopError(
                    Resources.Error_FailedRegisterWindowsMessageFilter
                );
                return;
            }

            InitializeSystemCommandRunner();

            Application.WinInit(args);

            Revoke.WindowsMessageFilter();
        }

        /// <summary>
        /// Initializes the events and properties of a <c>System Command Runner</c> object;
        /// aka, the <see cref="T:xyLOGIX.Interop.Processes.Actions.Run" /> class.
        /// </summary>
        private static void InitializeSystemCommandRunner()
        {
            try
            {
                Run.DataReceived -= OnRunDataReceived;
                Run.DataReceived += OnRunDataReceived;
            }
            catch (Exception ex)
            {
                // dump all the exception info to the log
                DebugUtils.LogException(ex);
            }
        }

        /// <summary>
        /// Handles the <see cref="E:xyLOGIX.Interop.Processes.Actions.Run.DataReceived" />
        /// event raised by the <see cref="T:xyLOGIX.Interop.Processes.Actions.Run" />
        /// class when its methods are called to execute processes.
        /// </summary>
        /// <param name="sender">
        /// Reference to an instance of the object that raised the
        /// event.
        /// </param>
        /// <param name="e">
        /// A <see cref="T:System.EventArgs" /> that contains the event
        /// data.
        /// </param>
        /// <remarks>
        /// This method responds by writing the results of executing system
        /// commands to the log file.
        /// </remarks>
        private static void OnRunDataReceived(
            object sender,
            DataReceivedEventArgs e
        )
        {
            if (e == null) return;
            if (string.IsNullOrWhiteSpace(e.Data)) return;

            DebugUtils.WriteLine(
                DebugLevel.Info, $"*** DEBUG *** {e.Data.Trim()}"
            );
        }

        private static void OnConfigProviderConfigFilePathChanged(
            object sender,
            EventArgs e
        )
            => Messages.ShowInformation(
                $"The new config file pathname is '{ConfigFilePath}"
            );

        /// <summary>
        /// Configures the logging infrastructure.
        /// </summary>
        private static void SetUpLogging()
            => LogFileManager.InitializeLogging(
                muteConsole: false,
                infrastructureType: LoggingInfrastructureType.PostSharp,
                logFileName: Get.LogFilePath(),
                applicationName: Get.ApplicationProductName()
            );
    }
}