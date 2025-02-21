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
using MFR.FileSystem.Win32;
using MFR.Operations;
using MFR.Operations.Constants;
using PostSharp.Patterns.Diagnostics;
using System;
using xyLOGIX.Core.Debug;
using xyLOGIX.Files.Actions;

namespace MFR.FileSystem
{
    /// <summary>
    /// POCO to encapsulate the details of a file-system entry, such as a file
    /// or a folder.
    /// </summary>
    [Log(AttributeExclude = true)]
    public class FileSystemEntry : OperationTypeSpecificObjectBase,
        IFileSystemEntry, IEquatable<FileSystemEntry>
    {
        /// <summary>
        /// Constructs a new instance of
        /// <see
        ///     cref="T:MFR.FileSystem.FileSystemEntry" />
        /// and returns a
        /// reference to it.
        /// </summary>
        /// <param name="path">
        /// (Required.) String containing the pathname of the file-system entry.
        /// </param>
        /// <exception cref="T:System.ArgumentException">
        /// Thrown if the required parameter, <paramref name="path" />, is passed
        /// a blank or <see langword="null" /> string for a value.
        /// </exception>
        public FileSystemEntry(string path)
        {
            /*
             * OKAY, this class is POCO-ish, and normally, we do
             * not throw exceptions, EVER, from the constructor
             * of a POCO! However, here we have to check for a
             * blank input because we attempt to automatically
             * initialize the ContainingFolder property from the
             * path specified -- if the path parameter is blank,
             * then we're screwed.  Not only that, it represents
             * a major error in this program, since we are technically
             * only supposed to be creating these objects for
             * non-blank path values.
             */
            if (string.IsNullOrWhiteSpace(path))
                throw new ArgumentException(
                    "Value cannot be null or whitespace.", nameof(path)
                );
            ContainingFolder = System.IO.Path.GetDirectoryName(path);
            Path = path;
        }

        /// <summary>
        /// Gets or sets the pathname of the parent folder of this file system entry.
        /// </summary>
        public string ContainingFolder
        {
            get;
            set;
        }

        /// <summary>
        /// Gets a value that indicates whether the file system entry exists.
        /// </summary>
        /// <returns>
        /// <see langword="true" /> if the file system entry exists;
        /// <see langword="false" /> otherwise.
        /// </returns>
        public bool Exists
        {
            get {
                var result = false;

                try
                {
                    // Obviously, a blank path does not exist
                    if (string.IsNullOrWhiteSpace(Path)) return result;

                    result = Does.FileSystemEntryExist(Path);
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

        /// <summary>
        /// Gets a value indicating whether the entry represents a file or a folder on the
        /// file system.
        /// </summary>
        /// <returns>
        /// <see langword="true" /> if this file system entry is folder;
        /// <see langword="false" /> otherwise.
        /// </returns>
        public bool IsFolder
        {
            get {
                var result = false;

                try
                {
                    if (string.IsNullOrWhiteSpace(Path)) return result;

                    result = Is.Folder(Path);
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

        /// <summary>
        /// Gets one of the
        /// <see
        ///     cref="T:MFR.Operations.Constants.OperationType" />
        /// values that
        /// corresponds to the type of operation being performed.
        /// </summary>
        [Log(AttributeExclude = true)]
        public override OperationType OperationType
        {
            get;
            protected set;
        }

        /// <summary>
        /// Gets or sets the pathname of the file-system entry.
        /// </summary>
        [Log(AttributeExclude = true)]
        public string Path
        {
            get;
            set;
        }

        /// <summary>
        /// Gets a <see cref="T:System.String" /> that contains a truncated version of the
        /// value of the <see cref="P:MFR.FileSystem.FileSystemEntry.Path" /> property.
        /// </summary>
        public string ShortPath
            => NativeMethods.PathCompactPathEx(Path);

        /// <summary>
        /// Gets or sets user state.
        /// </summary>
        /// <remarks>
        /// For example, if the file-system entry is representing a text file,
        /// then this property might contain the file's contents from them
        /// having been previously read in.
        /// </remarks>
        [Log(AttributeExclude = true)]
        public dynamic UserState
        {
            get;
            set;
        }

        /// <summary>
        /// Indicates whether the current object is equal to another object of the
        /// same type.
        /// </summary>
        /// <param name="other">An object to compare with this object.</param>
        /// <returns>
        /// <see langword="true" /> if the current object is equal to the
        /// <paramref name="other" /> parameter; otherwise, <see langword="false" />.
        /// </returns>
        public bool Equals(FileSystemEntry other)
            => Equals((IFileSystemEntry)other);

        /// <summary>
        /// Indicates whether the current object is equal to another object of the
        /// same type.
        /// </summary>
        /// <param name="other">An object to compare with this object.</param>
        /// <returns>
        /// <see langword="true" /> if the current object is equal to the
        /// <paramref name="other" /> parameter; otherwise, <see langword="false" />.
        /// </returns>
        [Log(AttributeExclude = true)]
        public bool Equals(IFileSystemEntry other)
        {
            var result = false;

            try
            {
                if (ReferenceEquals(null, other)) return false;
                if (ReferenceEquals(this, other)) return true;
                result = ContainingFolder == other.ContainingFolder &&
                         OperationType == other.OperationType &&
                         Path == other.Path;
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
        /// Associates user state information, such as file contents or other
        /// data, with this file-system entry.
        /// </summary>
        /// <param name="userState">
        /// (Required.) Reference to an instance of an object that serves as
        /// user state information.
        /// </param>
        /// <returns>
        /// Reference to the same instance of the object that called this
        /// method, for fluent use.
        /// </returns>
        /// <exception cref="T:System.ArgumentNullException">
        /// Thrown if the required parameter, <paramref name="userState" />, is
        /// passed a <see langword="null" /> value.
        /// </exception>
        public IFileSystemEntry SetUserState(dynamic userState)
        {
            UserState = userState ??
                        throw new ArgumentNullException(nameof(userState));

            return this;
        }

        /// <summary>
        /// Determines whether the specified object is equal to the current
        /// object.
        /// </summary>
        /// <param name="obj">The object to compare with the current object.</param>
        /// <returns>
        /// <see langword="true" /> if the specified object  is equal to the current
        /// object; otherwise, <see langword="false" />.
        /// </returns>
        [Log(AttributeExclude = true)]
        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != GetType()) return false;
            return Equals((FileSystemEntry)obj);
        }

        /// <summary>Serves as the default hash function.</summary>
        /// <returns>A hash code for the current object.</returns>
        [Log(AttributeExclude = true)]
        public override int GetHashCode()
        {
            unchecked
            {
                var hashCode = ContainingFolder != null
                    ? ContainingFolder.GetHashCode()
                    : 0;
                hashCode = (hashCode * 397) ^ (int)OperationType;
                hashCode = (hashCode * 397) ^
                           (Path != null ? Path.GetHashCode() : 0);
                hashCode = (hashCode * 397) ^
                           (UserState != null ? UserState.GetHashCode() : 0);
                return hashCode;
            }
        }

        /// <summary>Returns a string that represents the current object.</summary>
        /// <returns>A string that represents the current object.</returns>
        [Log(AttributeExclude = true)]
        public override string ToString()
            => Path;
    }
}