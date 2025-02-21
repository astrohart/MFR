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

using MFR.Registry.Helpers;
using Microsoft.Win32;
using System;
using System.Linq;
using xyLOGIX.Core.Extensions;

namespace MFR.Metadata.Registry
{
    /// <summary>
    /// Base class for the common methods, properties, fields, and events
    /// between implementers of the
    /// <see
    ///     cref="T:MFR.IRegQueryExpression" />
    /// interface and the
    /// <see cref="T:MFR.IRegOperationMetadata" /> interface.
    /// </summary>
    public class RegMetadataBase
    {
        /// <summary>
        /// String containing the fully-qualified pathname of a Registry key.
        /// </summary>
        private string _keyPath;

        /// <summary>
        /// Gets the <see cref="T:Microsoft.Win32.RegistryHive" /> value that
        /// corresponds to the hive specified by the user, either by default or explicitly.
        /// </summary>
        public RegistryHive Hive
        {
            get;
            private set;
        }

        /// <summary>
        /// Gets or sets the path to the Registry key under which the desired
        /// data is stored.
        /// </summary>
        /// <remarks>
        /// Whenever the value of this property is updated, the value of the
        /// <see cref="P:MFR.IRegOperationMetadata.Hive" />
        /// property is updated to match.
        /// </remarks>
        public string KeyPath
        {
            get => _keyPath;
            set {
                _keyPath = value;
                DetermineRegistryHiveFromKeyPath(_keyPath);
            }
        }

        /// <summary>
        /// Attempts to parse the corresponding
        /// <see
        ///     cref="T:Microsoft.Win32.RegistryHive" />
        /// enumeration value from the
        /// <paramref name="keyPath" /> in the string provided.
        /// <para />
        /// Sets the value of the
        /// <see
        ///     cref="P:MFR.RegQueryExpression.Hive" />
        /// property
        /// to the result.
        /// </summary>
        /// <param name="keyPath">
        /// (Required.) String containing a fully-qualified pathname to a key in
        /// the system Registry.
        /// </param>
        /// <remarks>
        /// If the hive name cannot be parsed from <paramref name="keyPath" />,
        /// then the
        /// <see
        ///     cref="P:MFR.RegQueryExpression.Hive" />
        /// property
        /// is set to <see cref="T:Microsoft.Win32.RegistryHive.CurrentUser" />,
        /// except in the case where <paramref name="keyPath" /> is blank; if
        /// this the case, then this method does nothing.
        /// </remarks>
        /// <exception cref="T:System.ArgumentException">
        /// Thrown if <paramref name="keyPath" /> is not a valid key pathname.
        /// </exception>
        protected void DetermineRegistryHiveFromKeyPath(string keyPath)
        {
            if (string.IsNullOrWhiteSpace(keyPath)) return; // nothing to do

            if (!keyPath.Contains(@"\"))
                throw new ArgumentException(
                    "Value must contain at least one backslash.",
                    nameof(keyPath)
                );

            if (!keyPath.StartsWith("HKEY_"))
            {
                Hive = RegistryHive.CurrentUser;
                return;
            }

            var hiveName = keyPath.SplitOn(@"\")
                                  .First();
            if (string.IsNullOrWhiteSpace(hiveName))
            {
                Hive = RegistryHive.CurrentUser;
                return;
            }

            Hive = hiveName.ToRegistryHive();
        }
    }
}