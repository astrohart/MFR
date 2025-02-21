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
 */using Alphaleonis.Win32.Filesystem;
using MFR.Constants;
using System;
using xyLOGIX.Core.Debug;
using xyLOGIX.Files.Actions;

namespace MFR.Paths.Config.Provider.Actions
{
    /// <summary>
    /// Exposes static methods to obtain and formulate various values.
    /// </summary>
    public static class Obtain
    {
        /// <summary>
        /// Attempts to determine the fully-qualified pathname of the <c>config.json</c>
        /// file that stores the application configuration.
        /// </summary>
        /// <param name="companyName">
        /// (Required.) A <see cref="T:System.String" /> that
        /// contains the company name associated with the application.
        /// </param>
        /// <param name="productName">
        /// (Required.) A <see cref="T:System.String" /> that
        /// contains the product name associated with the application.
        /// </param>
        /// <param name="currentPathname">
        /// (Optional.) A <see cref="T:System.String" /> that
        /// serves as a default return value for this method in case a failure mode is
        /// otherwise hit (blank input, missing file, missing Registry value, etc.
        /// </param>
        /// <returns></returns>
        /// <returns>
        /// If successful, a <see cref="T:System.String" /> containing the
        /// fully-qualified pathname of the <c>config.json</c> file that contains the
        /// user's previously-saved configuration profiles.
        /// </returns>
        /// <remarks>
        /// Configuration profiles let the user save a set of their previously-used
        /// settings to easily recall for later use.
        /// <para />
        /// If an error occurred, or if required information is missing, during the
        /// operation, then this method returns the value of the
        /// <paramref name="currentPathname" />
        /// parameter.
        /// <para />
        /// <b>NOTE:</b> The <paramref name="currentPathname" /> is allowed to be passed
        /// the <see cref="F:System.String.Empty" /> value as its argument, so be mindful.
        /// </remarks>
        public static string ConfigFilePath(
            string companyName,
            string productName,
            string currentPathname = ""
        )
        {
            var result = currentPathname;

            /*
             * OKAY, the objective of this method is to give the caller a
             * fully-qualified pathname to a config.json file to be used
             * for storing the application configuration.
             *
             * We formulate this using the name of the company associated with
             * this application and the product name to string together the
             * default pathname and the name of the key in the system Registry
             * under which the pathname is stored.
             *
             * If either of these pieces of info are blank, then stop.  The
             * currentPathname parameter allows us to return it as a default
             * value in case we otherwise fail.
             *
             * If the path listed in the argument of the currentPathname
             * parameter refers to a file on the file system that exists, and that
             * has a name of config.json, then simply return that pathname.
             * Otherwise, try to load the config.json file's pathname from the
             * system Registry.
             */

            try
            {
                if (string.IsNullOrWhiteSpace(companyName)) return result;
                if (string.IsNullOrWhiteSpace(productName)) return result;
                if (Does.FileExist(currentPathname) &&
                    ConfigFile.DefaultFilename.Equals(
                        Path.GetFileName(currentPathname)
                    ))
                    return result;

                result = Retrieve.ConfigPathFromRegistry(
                    companyName, productName, currentPathname
                );
            }
            catch (Exception ex)
            {
                // dump all the exception info to the log
                DebugUtils.LogException(ex);

                result = currentPathname;
            }

            return result;
        }
    }
}