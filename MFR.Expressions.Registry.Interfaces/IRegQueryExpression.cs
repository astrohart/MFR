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

using Microsoft.Win32;

namespace MFR.Expressions.Registry.Interfaces
{
    /// <summary>
    /// Defines the public-exposed methods and properties of an object that
    /// contains the metadata for a query of a value in the system Registry.
    /// </summary>
    public interface IRegQueryExpression<T> where T : class
    {
                /// <summary>
        /// Gets the <see cref="T:Microsoft.Win32.RegistryHive" /> value that
        /// corresponds to the hive specified by the user, either by default or explicitly.
        /// </summary>
        RegistryHive Hive
        {
            get;
        }

        /// <summary>
        /// Gets or sets the path to the Registry key under which the desired
        /// data is stored.
        /// </summary>
        /// <remarks>
        /// This property should be set to the fully-qualified path of a key
        /// under the <c>HKEY_CURRENT_USER</c> hive. Other hives are not supported.
        /// </remarks>
        string KeyPath
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
        string ValueName
        {
            get;
            set;
        }

        /// <summary>
        /// Assigns a value to the
        /// <see
        ///     cref="P:MFR.Expressions.Registry.Interfaces.IRegQueryExpression.ValueName" />
        /// property.
        /// </summary>
        /// <param name="valueName">
        /// (Required.) String containing the new value for the property.
        /// </param>
        /// <returns>
        /// Reference to the same instance of the object that called this
        /// method, for fluent use.
        /// </returns>
        IRegQueryExpression<T> AndValueName(string valueName);

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
        IRegQueryExpression<T> ForKeyPath(string keyPath);

        /// <summary>
        /// Gets or sets <typeparamref name="T" /> that is used as the default
        /// value in case data cannot otherwise be accessed from the Registry.
        /// </summary>
        T DefaultValue
        {
            get;
            set;
        }

        /// <summary>
        /// Assigns a value to the
        /// <see
        ///     cref="P:MFR.Expressions.Registry.Interfaces.IRegQueryExpression.ValueName" />
        /// property.
        /// </summary>
        /// <param name="defaultValue">
        /// (Required.) Instance of <typeparamref name="T" /> that should serve
        /// as the default value to be returned in case no data is found.
        /// </param>
        /// <returns>
        /// Reference to the same instance of the object that called this
        /// method, for fluent use.
        /// </returns>
        /// <remarks>
        /// Calling this method is optional.
        /// </remarks>
        IRegQueryExpression<T> WithDefaultValue(T defaultValue);
    }
}