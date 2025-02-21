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

namespace MFR.Paths.Profiles.Provider.Actions
{
    /// <summary>
    /// Exposes static methods to formulate data values from other data values.
    /// </summary>
    public static class Formulate
    {
        /// <summary>
        /// Attempts to get the fully-qualified Registry key pathname of the key storing
        /// the pathnames of the profile list and configuration files.
        /// </summary>
        /// <param name="companyName">
        /// (Required.) A <see cref="T:System.String" /> that
        /// contains the company name associated with the application.
        /// </param>
        /// <param name="productName">
        /// (Required.) A <see cref="T:System.String" /> that
        /// contains the product name associated with the application.
        /// </param>
        /// <returns>
        /// If successful, a <see cref="T:System.String" /> that contains the
        /// fully-qualified Registry key pathname of the key storing the pathnames of the
        /// profile list and configuration files.
        /// </returns>
        /// <remarks>
        /// If either of the required parameters, <paramref name="companyName" /> and
        /// <paramref name="productName" /> are passed the blank or <see langword="null" />
        /// value as an argument, then this method returns the
        /// <see cref="F:System.String.Empty" /> value.
        /// <para />
        /// The <see cref="F:System.String.Empty" /> value is also returned if an error
        /// occurs during the processing of the operation.
        /// </remarks>
        public static string ProfileFilePathRegistryKeyPathname(
            string companyName, string productName)
        {
            var result = string.Empty;

            try
            {
                if (string.IsNullOrWhiteSpace(companyName)) return result;
                if (string.IsNullOrWhiteSpace(productName)) return result;

                result =
                    $@"HKEY_CURRENT_USER\SOFTWARE\{companyName}\{productName}\Paths";
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
        /// Attempts to formulate a default value for the <c>profiles.json</c> file that
        /// contains the user's previously-saved configuration profiles.
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
        /// <returns>
        /// If successful, a <see cref="T:System.String" /> that contains the
        /// default fully-qualified pathname of the <c>profiles.json</c> value that should
        /// be used as a fallback in the event that a <c>profiles.json</c> file cannot be
        /// located either on the file system or in the system Registry.
        /// </returns>
        /// <remarks>
        /// Configuration profiles let the user save a set of their previously-used
        /// settings to easily recall for later use.
        /// <para />
        /// If an error occurred, or if required information is missing, during the
        /// operation, then this method returns the <see cref="F:System.String.Empty" />
        /// value.
        /// </remarks>
        public static string DefaultProfileCollectionPathname(
            string companyName,
            string productName,
            string currentPathname = ""
        )
        {
            var result = currentPathname;

            try
            {
                if (string.IsNullOrWhiteSpace(companyName)) return result;
                if (string.IsNullOrWhiteSpace(productName)) return result;

                var localAppDataFolderPath = Environment.GetFolderPath(
                    Environment.SpecialFolder.LocalApplicationData
                );
                if (string.IsNullOrWhiteSpace(localAppDataFolderPath))
                    return result;

                var companyProgramDataFolderPath = Path.Combine(
                    localAppDataFolderPath, companyName
                );
                if (string.IsNullOrWhiteSpace(companyProgramDataFolderPath))
                    return result;

                var profileCollectionFileFolder = Path.Combine(
                    companyProgramDataFolderPath, $@"{productName}\Config"
                );
                if (string.IsNullOrWhiteSpace(profileCollectionFileFolder))
                    return result;

                result = Path.Combine(
                    profileCollectionFileFolder, ProfileFile.DefaultFilename
                );
            }
            catch (Exception ex)
            {
                // dump all the exception info to the log
                DebugUtils.LogException(ex);

                result = string.Empty;
            }

            return result;
        }
    }
}