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
 */using MFR.FileSystem.Interfaces;
using PostSharp.Patterns.Diagnostics;
using System;
using System.IO;
using xyLOGIX.Core.Debug;
using File = Alphaleonis.Win32.Filesystem.File;
using FileInfo = Alphaleonis.Win32.Filesystem.FileInfo;

namespace MFR.FileSystem.Factories
{
    /// <summary>
    /// Creates new instances of <see cref="T:Alphaleonis.Win32.Filesystem.FileInfo" /> and returns
    /// references to them.
    /// </summary>
    [Log(AttributeExclude = true)]
    public static class MakeNewFileInfo
    {
        /// <summary>
        /// Creates a new instance of <see cref="T:Alphaleonis.Win32.Filesystem.FileInfo" />,
        /// initializes it with the <paramref name="path" /> specified, and
        /// returns it.
        /// </summary>
        /// <param name="path">
        /// (Required.) String containing the pathname of a file on the file system.
        /// </param>
        /// <returns>
        /// A <see cref="T:Alphaleonis.Win32.Filesystem.FileInfo" />, initialized with the specified
        /// <paramref name="path" />.<para/><see langword="null" /> is returned if the operation failed.
        /// </returns>
        /// <exception cref="T:System.ArgumentException">
        /// Thrown if the required parameter, <paramref name="path" />, is passed
        /// a blank or <see langword="null" /> string for a value.
        /// </exception>
        /// <exception cref="T:System.IO.FileNotFoundException">
        /// Thrown if the file, the path to which is specified by the
        /// <paramref
        ///     name="path" />
        /// parameter, cannot be located on the file system.
        /// </exception>
        public static FileInfo ForPath(string path)
        {
            if (string.IsNullOrWhiteSpace(path))
                throw new ArgumentException(
                    "Value cannot be null or whitespace.", nameof(path)
                );
            if (!File.Exists(path))
                throw new FileNotFoundException(
                    "The system cannot locate the file specified.", path
                );

            FileInfo result;

            try
            {
                /*
                 * We add extra robustness here, since this a File I/O
                 * operation.  The operation may fail because the provided
                 * path may refer to a file that can't be accessed by the
                 * user, or any one of a myriad other reasons.
                 *
                 * If this is so, then we set the result variable to null
                 * as a signal to the caller of this method that the operation
                 * failed.
                 */

                result = new FileInfo(path);
            }
            catch (Exception ex)
            {
                // dump all the exception info to the log
                DebugUtils.LogException(ex);

                result = null;
            }

            return result;
        }

        /// <summary>
        /// Creates a new instance of <see cref="T:Alphaleonis.Win32.Filesystem.FileInfo" /> for the
        /// file whose path is specified by the object that implements the
        /// <see
        ///     cref="T:MFR.FileSystem.Interfaces.IFileSystemEntry" />
        /// interface, a reference to which is passed in the
        /// <paramref
        ///     name="entry" />
        /// parameter.
        /// </summary>
        /// <param name="entry">
        /// Reference to an instance of an object that implements the
        /// <see
        ///     cref="T:MFR.FileSystem.Interfaces.IFileSystemEntry" />
        /// interface that contains the file's path.
        /// </param>
        /// <returns>
        /// Reference to an instance of <see cref="T:Alphaleonis.Win32.Filesystem.FileInfo" /> that
        /// is initialized with the path to the file referred to by the value of
        /// the <paramref name="entry" /> parameter.
        /// </returns>
        /// <exception cref="T:System.ArgumentException">
        /// Thrown if the required
        /// <see
        ///     cref="P:MFR.FileSystem.Interfaces.IFileSystemEntry.Path" />
        /// property is passed a blank or <see langword="null" /> string for a value.
        /// </exception>
        /// <exception cref="T:System.ArgumentNullException">
        /// Thrown if the required parameter, <paramref name="entry" />, is
        /// passed a <see langword="null" /> value.
        /// </exception>
        public static FileInfo FromFileSystemEntry(IFileSystemEntry entry)
        {
            if (entry == null) throw new ArgumentNullException(nameof(entry));
            if (string.IsNullOrWhiteSpace(entry.Path))
                throw new ArgumentException(
                    "The path of the FileSystemEntry provided cannot be blank.",
                    nameof(entry.Path)
                );

            return ForPath(entry.Path);
        }
    }
}