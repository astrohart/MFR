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
using MFR.FileSystem.Helpers;
using MFR.Settings.Configuration.Converters;
using MFR.Settings.Configuration.Factories;
using MFR.Settings.Configuration.Interfaces;
using System;
using System.Linq;
using xyLOGIX.Core.Debug;
using xyLOGIX.Files.Actions;
using Initialize = MFR.GUI.Models.Actions.Initialize;

namespace MFR.Settings.Configuration.Serializers
{
    /// <summary>
    /// Provides helper methods for storing the config data to, and
    /// loading it from, a file on the file system.
    /// </summary>
    public static class ConfigurationSerializer
    {
        /// <summary>
        /// Loads the config data from the file on the file system that has the
        /// specified <paramref name="pathname" />.
        /// </summary>
        /// <param name="pathname">
        /// (Required.) String containing the fully-qualified pathname of a
        /// JSON-formatted data file on the file system that contains the config data.
        /// </param>
        /// <returns>
        /// Reference to an instance of an object that implements the
        /// <see
        ///     cref="T:MFR.Settings.Profiles.Interfaces.IProfile" />
        /// interface that has been
        /// initialized with the data present in the file; or
        /// <see
        ///     langword="null" />
        /// if a problem occurred.
        /// </returns>
        public static IProjectFileRenamerConfig Load(string pathname)
        {
            var result = GetBlankProjectFileRenamerConfig.SoleInstance();

            try
            {
                if (string.IsNullOrWhiteSpace(pathname)) return result;
                if (!File.Exists(pathname)) return result;

                var encoding = Determine.FileEncoding(pathname);
                var content = File.ReadAllText(pathname, encoding);
                if (string.IsNullOrWhiteSpace(content))
                    return result;

                // If the file at the path pathname has zero bytes of data, or
                // only whitespace, then return a blank ProjectFileRenamerConfig instance
                // with its properties all set to default values.
                result =
                    ConvertProjectFileRenamerConfig.FromJson(content);

                if (result == null) return result;

                /*
                 * If, for some reason, the loaded config object contains no
                 * operations to perform, initialize the list with the defaults.
                 */

                if (!result.InvokableOperations.Any())
                    result.InvokableOperations = Initialize.OperationList();
            }
            catch (Exception ex)
            {
                // dump all the exception info to the log
                DebugUtils.LogException(ex);

                result = GetBlankProjectFileRenamerConfig.SoleInstance();
            }

            return result;
        }

        /// <summary>
        /// Saves config data to a file.
        /// </summary>
        /// <param name="pathname">
        /// (Required.) String containing the pathname of the file that the data
        /// is to be saved to.
        /// </param>
        /// <param name="config">
        /// (Required.) Reference to an instance of an object that implements
        /// the
        /// <see
        ///     cref="T:MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfig" />
        /// interface.
        /// </param>
        public static void Save(
            string pathname,
            IProjectFileRenamerConfig config
        )
        {
            if (string.IsNullOrWhiteSpace(pathname))
                return;

            if (config == null)
                return;

            try
            {
                var content =
                    ConvertProjectFileRenamerConfig
                        .ToJson(config);

                if (string.IsNullOrWhiteSpace(content))
                    return;

                if (File.Exists(pathname))
                    File.Delete(pathname);

                MakeSure.ContainingFolderExists(pathname);

                File.WriteAllText(pathname, content);
            }
            catch (Exception ex)
            {
                // dump all the exception info to the log
                DebugUtils.LogException(ex);
            }
        }
    }
}