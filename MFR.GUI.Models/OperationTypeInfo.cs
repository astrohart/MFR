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

using MFR.GUI.Models.Converters;
using MFR.GUI.Models.Interfaces;
using MFR.Operations.Constants;
using Newtonsoft.Json;
using PostSharp.Patterns.Diagnostics;
using System;
using xyLOGIX.Core.Debug;

namespace MFR.GUI.Models
{
    /// <summary>
    /// Information about a type of operation to perform to indicate whether the user
    /// wants to perform the operation.
    /// <para />
    /// Provides a model for a particular item in the CheckedListBox in the Operations
    /// tab of the GUI.
    /// </summary>
    [Log(AttributeExclude = true)]
    public class OperationTypeInfo : IOperationTypeInfo
    {
        private bool _enabled;

        /// <summary>
        /// A <see cref="T:System.String" /> that contains a user -friendly name to display
        /// for this operation type information object.
        /// </summary>
        private string _name;

        /// <summary>
        /// One of the <see cref="T:MFR.Operations.Constants.OperationType" /> values that
        /// corresponds to the type of operation to perform.
        /// </summary>
        private OperationType _operationType;

        /// <summary>
        /// Gets or sets a value that indicates whether the user wants to perform the
        /// operation.
        /// </summary>
        /// <returns>
        /// <see langword="true" /> if this operation is allowed by the user to be
        /// performed; <see langword="false" /> otherwise.
        /// </returns>
        /// <remarks>
        /// This property raises the
        /// <see cref="E:MFR.GUI.Models.OperationTypeInfo.EnabledChanged" /> event when its
        /// value is updated.
        /// </remarks>
        [JsonProperty("enabled")]
        public bool Enabled
        {
            get => _enabled;
            set {
                var changed = _enabled != value;
                _enabled = value;
                if (changed) OnEnabledChanged();
            }
        }

        /// <summary>
        /// Gets or sets the name of the operation type.
        /// </summary>
        /// <returns>
        /// A <see cref="T:System.String" /> containing a user-friendly display
        /// name for the type of operation that this object represents.
        /// </returns>
        /// <remarks>
        /// This property raises the
        /// <see cref="E:MFR.GUI.Models.OperationTypeInfo.NameChanged" /> event when its
        /// value is updated.
        /// </remarks>
        [JsonProperty("name")]
        public string Name
        {
            get => _name;
            set {
                var changed = _name != value;
                _name = value;
                if (changed) OnNameChanged();
            }
        }

        /// <summary>
        /// Gets or sets the <see cref="T:MFR.Operations.Constants.OperationType" /> value
        /// that corresponds to the type of operation to perform.
        /// </summary>
        /// <returns>
        /// One of the <see cref="T:MFR.Operations.Constants.OperationType" />
        /// enumeration values that indicates to what type of operation this object
        /// corresponds.
        /// </returns>
        /// <remarks>
        /// Setting the value of this property also updates the value of the
        /// <see cref="P:MFR.GUI.Models.OperationTypeInfo.Name" /> property in order to
        /// correspond to the new <see cref="T:MFR.Operations.Constants.OperationType" />
        /// enumeration value that this property has been set to.
        /// <para />
        /// This property raises the
        /// <see cref="E:MFR.GUI.Models.OperationTypeInfo.OperationTypeChanged" /> event
        /// when its value is updated.
        /// </remarks>
        [JsonProperty("operationType")]
        public OperationType OperationType
        {
            get => _operationType;
            set {
                var changed = _operationType != value;
                _operationType = value;
                if (changed) OnOperationTypeChanged();

                Name = ConvertOperationType.ToString(value);
            }
        }

        /// <summary>
        /// Occurs when the value of the
        /// <see cref="P:MFR.GUI.Models.OperationTypeInfo.Enabled" /> property has been
        /// updated.
        /// </summary>
        public event EventHandler EnabledChanged;

        /// <summary>
        /// Occurs when the value of the
        /// <see cref="P:MFR.GUI.Models.OperationTypeInfo.Name" /> property has been
        /// updated.
        /// </summary>
        public event EventHandler NameChanged;

        /// <summary>
        /// Occurs when the value of the
        /// <see cref="P:MFR.GUI.Models.OperationTypeInfo.OperationType" /> property has
        /// been updated.
        /// </summary>
        public event EventHandler OperationTypeChanged;

        /// <summary>
        /// Determines whether the specified object is equal to the current
        /// object.
        /// </summary>
        /// <param name="obj">The object to compare with the current object.</param>
        /// <returns>
        /// <see langword="true" /> if the specified object  is equal to the current
        /// object; otherwise, <see langword="false" />.
        /// </returns>
        public override bool Equals(object obj)
        {
            var result = false;

            try
            {
                if (obj is null) return result;
                if (ReferenceEquals(this, obj)) return true;
                result = obj.GetType() == GetType() &&
                         Equals((OperationTypeInfo)obj);
            }
            catch (Exception ex)
            {
                // dump all the exception info to the log
                DebugUtils.LogException(ex);

                result = false;
            }

            return result;
        }

        /// <summary>Serves as the default hash function.</summary>
        /// <returns>A hash code for the current object.</returns>
        public override int GetHashCode()
        {
            unchecked
            {
                var result = 19;
                result = result * 31 + _enabled.GetHashCode();
                result = result * 31 + _name.GetHashCode();
                result = result * 31 + _operationType.GetHashCode();
                return result;
            }
        }

        /// <summary>Returns a string that represents the current object.</summary>
        /// <returns>A string that represents the current object.</returns>
        /// <remarks>
        /// This method returns the value of the
        /// <see cref="P:MFR.GUI.Models.OperationTypeInfo.Name" /> property.
        /// </remarks>
        public override string ToString()
            => Name;

        protected bool Equals(IOperationTypeInfo other)
        {
            var result = false;

            try
            {
                if (other is null) return result;

                result = Enabled == other.Enabled && Name == other.Name &&
                         OperationType == other.OperationType;
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
        /// Raises the <see cref="E:MFR.GUI.Models.OperationTypeInfo.EnabledChanged" />
        /// event.
        /// </summary>
        protected virtual void OnEnabledChanged()
            => EnabledChanged?.Invoke(this, EventArgs.Empty);

        /// <summary>
        /// Raises the <see cref="E:MFR.GUI.Models.OperationTypeInfo.NameChanged" /> event.
        /// </summary>
        protected virtual void OnNameChanged()
            => NameChanged?.Invoke(this, EventArgs.Empty);

        /// <summary>
        /// Raises the
        /// <see cref="E:MFR.GUI.Models.OperationTypeInfo.OperationTypeChanged" /> event.
        /// </summary>
        protected virtual void OnOperationTypeChanged()
            => OperationTypeChanged?.Invoke(this, EventArgs.Empty);
    }
}