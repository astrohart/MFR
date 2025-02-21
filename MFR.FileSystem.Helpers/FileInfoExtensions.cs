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
using PostSharp.Patterns.Diagnostics;
using System;
using xyLOGIX.Core.Debug;
using xyLOGIX.Core.Extensions;

namespace MFR.FileSystem.Helpers
{
    /// <summary>
    /// Provides helper methods for working with instances of
    /// <see cref="T:Alphaleonis.Win32.Filesystem.FileInfo" />.
    /// </summary>
    [Log(AttributeExclude = true)]
    public static class FileInfoExtensions
    {
        /// <summary>
        /// Determines whether the specified <paramref name="file" /> has a zero length.
        /// </summary>
        /// <param name="file">
        /// (Required.) Reference to an instance of
        /// <see
        ///     cref="T:Alphaleonis.Win32.Filesystem.FileInfo" />
        /// that describes the
        /// file to be checked.
        /// </param>
        /// <returns>
        /// <see langword="true" /> if the <paramref name="file" /> parameter is
        /// not <see langword="null" />, if the file it refers to exists on the
        /// disk, and if the file's length is zero. Otherwise, or if an
        /// operating system error occurred, <see langword="false" /> is returned.
        /// </returns>
        public static bool IsZeroLengthFile(this FileInfo file)
        {
            var result = false;

            try
            {
                if (file == null) return result;

                if (!file.Exists) return result;

                result = file.Length == 0;
            }
            catch (Exception ex)
            {
                // dump all the exception info to the log
                DebugUtils.LogException(ex);

                result = false;
            }

            return result;
        }

        /// <summary>
        /// Renames a file.
        /// </summary>
        /// <param name="source">
        /// (Required.) A <see cref="T:Alphaleonis.Win32.Filesystem.FileInfo" />
        /// instance that refers to the existing file.
        /// </param>
        /// <param name="dest">
        /// (Required.) String containing the fully-qualified pathname of hte
        /// file's new name.
        /// </param>
        /// <returns>
        /// <see langword="true" /> if the operation was successful;
        /// <see
        ///     langword="false" />
        /// otherwise.
        /// </returns>
        /// <remarks>
        /// If <paramref name="source" /> is <see langword="null" /> or
        /// <paramref
        ///     name="dest" />
        /// is blank, or some other issue occurs, then this method
        /// returns <see langword="false" />.
        /// </remarks>
        public static bool RenameTo(this FileInfo source, string dest)
        {
            var result = false;

            try
            {
                if (source == null) return result;

                if (!source.Exists) return result;

                if (string.IsNullOrWhiteSpace(dest)) return result;

                if (!dest.IsAbsolutePath()) return result;

                if (source.FullName.EqualsNoCase(dest)) return result;

                result = source.TryRenameTo(dest);
            }
            catch (Exception ex)
            {
                // dump all the exception info to the log
                DebugUtils.LogException(ex);

                result = false;
            }

            return result;
        }

        /// <summary>
        /// Makes multiple attempts to perform the file-rename operation.<para/>Called by the <see cref="M:MFR.FileSystem.Helpers.FileInfoExtensions.RenameTo"/> method.
        /// </summary>
        /// <param name="source">
        /// (Required.) A <see cref="T:Alphaleonis.Win32.Filesystem.FileInfo" />
        /// instance that refers to the existing file.
        /// </param>
        /// <param name="dest">
        /// (Required.) String containing the fully-qualified pathname of hte
        /// file's new name.
        /// </param>
        /// <param name="maxRetries">(Required.) Count of retries to perform before giving up, in case the operation experiences an operating system error.</param>
        /// <returns><see langword="true" /> if the operation was successfully carried out; <see langword="false" /> otherwise.</returns>
        [Log(AttributeExclude = true)]
        private static bool TryRenameTo(this FileInfo source, string dest,
            int maxRetries = 5)
        {
            var result = false;

            if (maxRetries <= 0) return result;

            if (source == null) return result;

            if (!source.Exists) return result;

            if (string.IsNullOrWhiteSpace(dest)) return result;

            var attempts = 0;
            while (!result && attempts < maxRetries)
                try
                {
                    attempts++;

                    // Save the previous path of the file.  The source
                    // variable will refer to the file's new name after
                    // the move operation is complete.
                    var oldPath = source.FullName;

                    if (source.IsLocked()) return result;

                    result = source.MoveTo(
                                       dest,
                                       MoveOptions.CopyAllowed |
                                       MoveOptions.ReplaceExisting |
                                       MoveOptions.WriteThrough
                                   )
                                   .Exists && !File.Exists(oldPath);
                }
                catch (Exception ex)
                {
                    // dump all the exception info to the log
                    DebugUtils.LogException(ex);

                    result = false;
                }

            return result;
        }
    }
}