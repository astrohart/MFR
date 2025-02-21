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

using MFR.FileSystem.Interfaces;
using MFR.FileSystem.Validators.Factories;
using MFR.FileSystem.Validators.Interfaces;
using MFR.Operations.Constants;
using MFR.TextValues.Retrievers.Interfaces;
using PostSharp.Patterns.Diagnostics;
using System.Threading.Tasks;

namespace MFR.TextValues.Retrievers
{
    /// <summary>
    /// Defines the events, methods, properties, and behaviors for all
    /// <c>
    /// Text
    /// Value Retriever
    /// </c>
    /// objects.
    /// </summary>
    [Log(AttributeExclude = true)]
    public abstract class TextValueRetrieverBase : ITextValueRetriever
    {
        /// <summary>
        /// Fluent bridge property that accesses the appropriate file-system
        /// entry validator object, that implements the
        /// <see
        ///     cref="T:MFR.FileSystem.Interfaces.IFileSystemEntryValidator" />
        /// interface, for the current operation type.
        /// </summary>
        /// <remarks>
        /// The property is designed to be called as part of a fluent
        /// criteria-evaluation expression.
        /// </remarks>
        protected IFileSystemEntryValidator FileSystemEntryValidatorSays
            => GetFileSystemEntryValidator.For(OperationType);

        /// <summary>
        /// Gets one of the <see cref="T:MFR.Operations.Constants.OperationType" /> values
        /// that corresponds to the type of operation being performed.
        /// </summary>
        public abstract OperationType OperationType
        {
            get;
        }

        /// <summary>
        /// Gets a <see cref="T:System.String" /> containing the text to be
        /// searched, from the file-system <paramref name="entry" /> provided,
        /// given the current
        /// <see
        ///     cref="P:MFR.FileAndFolderTextValueRetriever.OperationType" />
        /// .
        /// </summary>
        /// <param name="entry">
        /// Reference to an instance of an object that implements the
        /// <see
        ///     cref="T:MFR.FileSystem.Interfaces.IFileSystemEntry" />
        /// interface.
        /// </param>
        /// <returns>
        /// A <see cref="T:System.String" /> containing the value data to be searched
        /// for the current operation type, or the empty string if the data source has
        /// no data.
        /// </returns>
        /// <exception cref="T:System.ArgumentNullException">
        /// Thrown if the required parameter, <paramref name="entry" />, is
        /// passed a <see langword="null" /> value.
        /// </exception>
        [return: NotLogged]
        public abstract string GetTextValue(IFileSystemEntry entry);

        /// <summary>
        /// Gets a <see cref="T:System.String" /> containing the text to be
        /// searched, from the file-system <paramref name="entry" /> provided,
        /// given the current
        /// <see
        ///     cref="P:MFR.FileAndFolderTextValueRetriever.OperationType" />
        /// .
        /// </summary>
        /// <param name="entry">
        /// Reference to an instance of an object that implements the
        /// <see
        ///     cref="T:MFR.FileSystem.Interfaces.IFileSystemEntry" />
        /// interface.
        /// </param>
        /// <returns>
        /// A <see cref="T:System.String" /> containing the value data to be searched
        /// for the current operation type, or the empty string if the data source has
        /// no data.
        /// </returns>
        /// <remarks>
        /// The base-class version of this method does nothing but always return
        /// the return value of the
        /// <see cref="M:MFR.TextValues.Retrievers.TextValueRetrieverBase.GetTextValue" />
        /// method.
        /// <para />
        /// Override this method if you want to do something else.  Child classes need not
        /// call the base-class version of this method.
        /// </remarks>
        /// <exception cref="T:System.ArgumentNullException">
        /// Thrown if the required parameter, <paramref name="entry" />, is
        /// passed a <see langword="null" /> value.
        /// </exception>
        public virtual Task<string> GetTextValueAsync(IFileSystemEntry entry)
            => Task.FromResult(GetTextValue(entry));
    }
}