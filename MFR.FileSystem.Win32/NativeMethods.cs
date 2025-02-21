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
 */using PostSharp.Patterns.Diagnostics;
using System;
using System.Runtime.InteropServices;
using System.Text;
using xyLOGIX.Core.Debug;

namespace MFR.FileSystem.Win32
{
    /// <summary>
    /// Definitions of native Win32 API method calls that can be used to activate
    /// functionality found in the Microsoft Windows operating system.
    /// </summary>
    [Log(AttributeExclude = true)]
    public static class NativeMethods
    {
        /// <summary>
        /// Gets the maximum length of a shortened path, in characters, not counting the
        /// terminating null character.
        /// </summary>
        private const int MAX_LENGTH = 75;

        /// <summary>
        /// Truncates a path to fit within a certain number of characters by replacing path
        /// components with ellipses.
        /// </summary>
        /// <param name="path">
        /// (Required.) A <see cref="T:System.String" /> that contains the fully-qualified
        /// pathname to be truncated.
        /// </param>
        /// <returns>A <see cref="T:System.String" /> containing the truncated path.</returns>
        public static string PathCompactPathEx(string path)
        {
            var result = string.Empty;

            try
            {
                if (string.IsNullOrWhiteSpace(path)) return result;

                var length = path.Length;
                if (length <= 0) return result;
                if (length < MAX_LENGTH) return path;

                var sb = new StringBuilder(length + 1);
                PathCompactPathEx(sb, path, MAX_LENGTH + 1, 0);
                result = sb.ToString();
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
        /// Truncates a path to fit within a certain number of characters by replacing path
        /// components with ellipses.
        /// </summary>
        /// <param name="pszOut">
        /// (Required.) A <see cref="T:System.Text.StringBuilder" />
        /// that receives the result.
        /// </param>
        /// <param name="szPath">
        /// (Required.) A <see cref="T:System.String" /> that contains
        /// the pathname to be truncated.
        /// </param>
        /// <param name="cchMax">
        /// (Required.) The maximum number of characters to be
        /// contained in the new <see cref="T:System.String" />, including the terminating
        /// null character. For example, if <paramref name="cchMax" /> = 8, the resulting
        /// <see cref="T:System.String" /> can contain a maximum of 7 characters plus the
        /// terminating null character.
        /// </param>
        /// <param name="dwFlags">(Required.) Reserved.  Set to zero.</param>
        /// <returns></returns>
        [DllImport("shlwapi.dll", CharSet = CharSet.Auto)]
        private static extern bool PathCompactPathEx(
            [Out] StringBuilder pszOut,
            string szPath,
            int cchMax,
            int dwFlags
        );
    }
}