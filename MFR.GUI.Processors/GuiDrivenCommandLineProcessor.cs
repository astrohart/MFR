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
 */using MFR.CommandLine.Translators;
using MFR.GUI.Processors.Constants;
using MFR.GUI.Processors.Interfaces;
using MFR.GUI.Windows.Factories;
using MFR.GUI.Windows.Interfaces;
using System.Diagnostics;
using System.Windows.Forms;

namespace MFR.GUI.Processors
{
    /// <summary>
    /// Processes the command line, filling in form fields on the GUI with values
    /// supplied by the user on the command line but otherwise does not run automated
    /// operations.
    /// </summary>
    public class GuiDrivenCommandLineProcessor : CommandLineProcessorBase
    {
        /// <summary>
        /// Empty, static constructor to prohibit direct allocation of this class.
        /// </summary>
        static GuiDrivenCommandLineProcessor()
        {
        }

        /// <summary>
        /// Empty, protected constructor to prohibit direct allocation of this class.
        /// </summary>
        protected GuiDrivenCommandLineProcessor()
        {
        }

        /// <summary>
        /// Gets a reference to the one and only instance of the object that implements the
        /// <see cref="T:MFR.GUI.Processors.Interfaces.ICommandLineProcessor" /> interface
        /// and which represents the processor that allows the application's user interface
        /// to be shown, but with command-line argument values specifying the settings of
        /// the controls.
        /// </summary>
        public static ICommandLineProcessor Instance
        {
            [DebuggerStepThrough]
            get;
        } = new GuiDrivenCommandLineProcessor();

        /// <summary>
        /// Gets a <see cref="T:MFR.GUI.Processors.Constants.CommandLineProcessorType" />
        /// enumeration value that identifies the type of processing this processor does.
        /// </summary>
        public override CommandLineProcessorType Type
            => CommandLineProcessorType.GuiDriven;

        /// <summary>
        /// Gets a reference to the one and only instance of the object that implements the
        /// <see cref="T:MFR.GUI.Windows.Interfaces.IMainWindow" /> interface that
        /// represents the main window of the application.
        /// </summary>
        private static IMainWindow MainWindow
        {
            [DebuggerStepThrough]
            get;
        } = GetMainWindow.SoleInstance();

        /// <summary>
        /// Executes the processing specified by this processor type.
        /// </summary>
        public override void Process()
        {
            // Set the current configuration to the one specified on the command line.
            CurrentConfig = CommandLineInfo.ToConfig();

            MainWindow.AttachCommandLineInfo(CommandLineInfo);

            Application.Run((Form)MainWindow);
        }
    }
}