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
using MFR.GUI.Processors.Constants;
using PostSharp.Patterns.Diagnostics;
using System;
using System.Diagnostics;
using xyLOGIX.Core.Assemblies.Info;
using xyLOGIX.Core.Debug;

namespace MFR.GUI.Actions
{
    /// <summary>
    /// Exposes static methods to obtain information from sources of data.
    /// </summary>
    public static class Get
    {
        /// <summary>
        /// A <see cref="T:System.String" /> containing the final piece of the path of the
        /// log file.
        /// </summary>
        private static readonly string LOG_FILE_PATH_TERMINATOR =
            $@"{AssemblyCompany}\{AssemblyProduct}\Logs\{AssemblyTitle}_log.txt";

        /// <summary>
        /// Initializes static data or performs actions that need to be performed once only
        /// for the <see cref="T:MFR.GUI.Actions.Get" /> class.
        /// </summary>
        /// <remarks>
        /// This constructor is called automatically prior to the first instance being
        /// created or before any static members are referenced.
        /// <para />
        /// We've decorated this constructor with the <c>[Log(AttributeExclude = true)]</c>
        /// attribute in order to simplify the logging output.
        /// </remarks>
        [Log(AttributeExclude = true)]
        static Get() { }

        /// <summary>
        /// Gets a <see cref="T:System.String" /> that contains the product name defined
        /// for this application.
        /// </summary>
        /// <remarks>
        /// This property is really an alias for the
        /// <see cref="P:AssemblyMetadata.AssemblyCompany" /> property.
        /// </remarks>
        private static string AssemblyCompany
        {
            [DebuggerStepThrough] get => AssemblyMetadata.AssemblyCompany;
        }

        /// <summary>
        /// Gets a <see cref="T:System.String" /> that contains the product name defined
        /// for this application.
        /// </summary>
        /// <remarks>
        /// This property is really an alias for the
        /// <see cref="P:AssemblyMetadata.AssemblyProduct" /> property.
        /// </remarks>
        private static string AssemblyProduct
        {
            [DebuggerStepThrough]
            get
                => AssemblyMetadata.AssemblyProduct.Replace(
                    "xyLOGIX ", string.Empty
                );
        }

        /// <summary>
        /// Gets a <see cref="T:System.String" /> that contains the assembly title defined
        /// for this application.
        /// </summary>
        /// <remarks>
        /// This property is really an alias for the
        /// <see cref="P:AssemblyMetadata.AssemblyTitle" /> property.
        /// </remarks>
        private static string AssemblyTitle
        {
            [DebuggerStepThrough]
            get => AssemblyMetadata.AssemblyTitle.Replace(" ", "_");
        }

        /// <summary>
        /// Gets a <see cref="T:System.String" /> that contains a user-friendly name for
        /// the software product of which this application or class library is a part.
        /// </summary>
        /// <returns>
        /// A <see cref="T:System.String" /> that contains a user-friendly name
        /// for the software product of which this application or class library is a part.
        /// </returns>
        public static string ApplicationProductName()
        {
            string result;

            try
            {
                result = AssemblyProduct;
            }
            catch (Exception ex)
            {
                // dump all the exception info to the log
                DebugUtils.LogException(ex);

                result = string.Empty;
            }

            return result;
        }

        /// <summary>
        /// Obtains the proper
        /// <see cref="T:MFR.GUI.Processors.Constants.CurrentCommandLineProcessorType" />
        /// enumeration value that corresponds to the way that the application was
        /// launched.
        /// </summary>
        /// <param name="commandLineSpecified">
        /// (Required.) <see langword="true" /> if more than zero command-line arguments
        /// are specified when the application is launched; <see langword="false" />
        /// otherwise.
        /// </param>
        /// <param name="autoStart">
        /// (Required.) <see langword="true" /> if the user specifies the
        /// <c>--autoStart</c> flag on the command line.
        /// </param>
        /// <returns>
        /// One of the
        /// <see cref="T:MFR.GUI.Processors.Constants.CurrentCommandLineProcessorType" />
        /// enumeration values that specifies how the application is to behave, given how
        /// it was launched.
        /// </returns>
        [DebuggerStepThrough]
        public static CommandLineProcessorType CurrentCommandLineProcessorType(
            bool commandLineSpecified,
            bool autoStart
        )
        {
            var result = CommandLineProcessorType.NoCommandLine;

            try
            {
                DebugUtils.WriteLine(
                    DebugLevel.Info,
                    "*** Get.CurrentCommandLineProcessorType: Checking whether the command-line was specified at all..."
                );

                // Check to see whether the command-line was specified at all.
                // If this is not the case, then write an error message to the log file,
                // and then terminate the execution of this method.
                if (!commandLineSpecified)
                {
                    // Zero command-line argument(s) were passed to the application upon startup.  This is not desirable.
                    DebugUtils.WriteLine(
                        DebugLevel.Error,
                        "*** ERROR *** Zero command-line argument(s) were passed to the application upon startup.  Stopping..."
                    );

                    DebugUtils.WriteLine(
                        DebugLevel.Debug,
                        $"Get.CurrentCommandLineProcessorType: Result = '{result}'"
                    );

                    // stop.
                    return result;
                }

                DebugUtils.WriteLine(
                    DebugLevel.Info,
                    "Get.CurrentCommandLineProcessorType: *** SUCCESS *** Greater than zero command-line argument(s) were passed to the application.  Proceeding..."
                );

                result = autoStart ? CommandLineProcessorType.AutoStart : CommandLineProcessorType.GuiDriven;
            }
            catch (Exception ex)
            {
                // dump all the exception info to the log
                DebugUtils.LogException(ex);

                result = CommandLineProcessorType.Unknown;
            }

            DebugUtils.WriteLine(
                DebugLevel.Debug,
                $"Get.CurrentCommandLineProcessorType: Result = '{result}'"
            );

            return result;
        }

        /// <summary>
        /// Obtains a <see cref="T:System.String" /> that contains the fully-qualified
        /// pathname of the file that should be used for logging messages.
        /// </summary>
        /// <returns>
        /// A <see cref="T:System.String" /> that contains the fully-qualified
        /// pathname of the file that should be used for logging messages.
        /// </returns>
        public static string LogFilePath()
            => Path.Combine(
                Environment.GetFolderPath(
                    Environment.SpecialFolder.CommonApplicationData
                ), LOG_FILE_PATH_TERMINATOR
            );
    }
}