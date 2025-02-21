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
 */using MFR.Operations.Interfaces;
using System;

namespace MFR.FileSystem.Interfaces
{
    /// <summary>
    /// Defines the public-exposed methods and properties of a POCO that
    /// encapsulates data about a file-system entry.
    /// </summary>
    public interface IFileSystemEntry : IOperationTypeSpecificObject,
        IEquatable<IFileSystemEntry>
    {
        /// <summary>
        /// Gets or sets the pathname of the parent folder of this file system entry.
        /// </summary>
        string ContainingFolder
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
        bool Exists
        {
            get;
        }

        /// <summary>
        /// Gets a value indicating whether the entry represents a file or a folder on the
        /// file system.
        /// </summary>
        /// <returns>
        /// <see langword="true" /> if this file system entry is folder;
        /// <see langword="false" /> otherwise.
        /// </returns>
        bool IsFolder
        {
            get;
        }

        /// <summary>
        /// Gets or sets the pathname of the file-system entry.
        /// </summary>
        string Path
        {
            get;
            set;
        }

        /// <summary>
        /// Gets a <see cref="T:System.String" /> that contains a truncated version of the
        /// value of the <see cref="P:MFR.FileSystem.FileSystemEntry.Path" /> property.
        /// </summary>
        string ShortPath
        {
            get;
        }

        /// <summary>
        /// Gets or sets user state.
        /// </summary>
        /// <remarks>
        /// For example, if the file-system entry is representing a text file,
        /// then this property might contain the file's contents from them
        /// having been previously read in.
        /// </remarks>
        dynamic UserState
        {
            get;
            set;
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
        IFileSystemEntry SetUserState(dynamic userState);
    }
}