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

using MFR.Metadata.Registry.Interfaces;
using System;

namespace MFR.Metadata.Registry
{
    /// <summary>
    /// Provides metadata for querying the data stored in a value contained
    /// within a key in the Windows system Registry database.
    /// </summary>
    /// <typeparam name="T">
    /// Type of the data to be accessed.
    /// </typeparam>
    /// <remarks>
    /// You may ask, what is the difference between this and a Registry Query
    /// Expression object?
    /// <para />
    /// The difference is in semantics only; the two types of object have exactly the
    /// same structure in terms of methods and properties.
    /// <para />
    /// A Registry Operation Metadata object is for
    /// <i>performing an operation on the Registry</i>, whereas a
    /// <i>Registry Query Expression</i> object is for
    /// <i>searching for information or querying data from the Registry.</i>
    /// </remarks>
    public class RegOperationMetadata<T> : RegMetadataBase,
        IRegOperationMetadata<T> where T : class
    {
        /// <summary>
        /// Gets or sets the instance of <typeparamref name="T" /> that is used
        /// as the data to be written to the system Registry.
        /// </summary>
        public T Value
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the name of the value under which data is to be stored
        /// or from which data is to be retrieved.
        /// </summary>
        /// <remarks>
        /// Set this property to <see langword="null" /> to retrieve data from, or store
        /// data to, the (Default) value under a particular registry key.
        /// </remarks>
        public string ValueName
        {
            get;
            set;
        }

        /// <summary>
        /// Assigns a value to the
        /// <see
        ///     cref="P:MFR.IRegOperationMetadata.ValueName" />
        /// property.
        /// </summary>
        /// <param name="valueName">
        /// (Required.) String containing the new value for the property.
        /// </param>
        /// <returns>
        /// Reference to the same instance of the object that called this
        /// method, for fluent use.
        /// </returns>
        public IRegOperationMetadata<T> AndValueName(string valueName)
        {
            // it's ok for this to be blank, but no whitespace allowed
            ValueName = valueName.Trim();

            return this;
        }

        /// <summary>
        /// Initializes this object with the path to the Registry key you wish
        /// to access.
        /// </summary>
        /// <returns>
        /// Reference to the same instance of the object that called this
        /// method, for fluent use.
        /// </returns>
        /// <remarks>
        /// If the hive ( <c>HKEY_</c>) is not included, then
        /// <c>HKEY_CURRENT_USER</c> is assumed.
        /// </remarks>
        /// <exception cref="T:System.ArgumentException">
        /// Thrown if the required parameter, <paramref name="keyPath" />, is
        /// passed a blank or <see langword="null" /> string for a value.
        /// </exception>
        public IRegOperationMetadata<T> ForKeyPath(string keyPath)
        {
            if (string.IsNullOrWhiteSpace(keyPath))
                throw new ArgumentException(
                    "Value cannot be null or whitespace.", nameof(keyPath)
                );

            KeyPath = keyPath;

            return this;
        }

        /// <summary>
        /// Assigns data to be written to the system Registry to the
        /// <see
        ///     cref="P:MFR.IRegOperationMetadata.Value" />
        /// property.
        /// </summary>
        /// <param name="value">
        /// (Required.) Instance of <typeparamref name="T" /> that contains the
        /// data to be written to the system Registry.
        /// </param>
        /// <returns>
        /// Reference to the same instance of the object that called this
        /// method, for fluent use.
        /// </returns>
        /// <remarks>
        /// Calling this method is optional.
        /// </remarks>
        public IRegOperationMetadata<T> WithValue(T value)
        {
            Value = value;

            return this;
        }
    }
}