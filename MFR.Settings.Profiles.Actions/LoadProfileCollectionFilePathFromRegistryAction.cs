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
 */using MFR.Expressions.Registry.Interfaces;
using MFR.Expressions.Registry.Validators.Factories;
using MFR.Expressions.Registry.Validators.Interfaces;
using MFR.FileSystem.Factories;
using MFR.FileSystem.Interfaces;
using MFR.Messages.Actions;
using MFR.Messages.Actions.Interfaces;
using MFR.Messages.Constants;
using MFR.Registry.Loaders.Factories;
using MFR.Settings.Profiles.Actions.Constants;
using PostSharp.Patterns.Diagnostics;
using System;
using xyLOGIX.Core.Debug;
using xyLOGIX.Core.Extensions;

namespace MFR.Settings.Profiles.Actions
{
    /// <summary>
    /// Accesses a key and value in the system Registry to load the pathname of
    /// the master config file.
    /// </summary>
    public class LoadProfileCollectionFilePathFromRegistryAction :
        CachedResultActionBase<IRegQueryExpression<string>, IFileSystemEntry>
    {
        /// <summary>
        /// Empty, static constructor to prohibit direct allocation of this class.
        /// </summary>
        [Log(AttributeExclude = true)]
        static LoadProfileCollectionFilePathFromRegistryAction() { }

        /// <summary>
        /// Empty, protected constructor to prohibit direct allocation of this class.
        /// </summary>
        [Log(AttributeExclude = true)]
        protected LoadProfileCollectionFilePathFromRegistryAction() { }

        /// <summary>
        /// Accesses a Registry query expression validator object that decides whether
        /// Registry query expression objects for <c>REG_SZ</c> values are initialized
        /// properly.
        /// </summary>
        private static IRegQueryExpressionValidator<string>
            AccessRegQueryExpressionValidator
        {
            get;
        } = GetRegistryExpressionValidator<string>.SoleInstance();

        /// <summary>
        /// Gets a reference to the one and only instance of
        /// <see
        ///     cref="T:MFR.Settings.Profiles.Actions.LoadProfileCollectionFilePathFromRegistryAction" />
        /// .
        /// </summary>
        public static IAction<IRegQueryExpression<string>, IFileSystemEntry> Instance
        {
            get;
        } = new LoadProfileCollectionFilePathFromRegistryAction();

        /// <summary>
        /// Gets the <see cref="T:MFR.MessageType" /> that is being used
        /// to identify which message this.
        /// </summary>
        [Log(AttributeExclude = true)]
        public override MessageType MessageType
        {
            get;
        } = ProfileCollectionActionType.LoadStringFromRegistry;

        /// <summary>
        /// Performs this action's operation if the result could not located in
        /// the result cache.
        /// </summary>
        /// <returns>
        /// Reference to an instance of an object that implements the
        /// <see
        ///     cref="T:MFR.FileSystem.Interfaces.IFileSystemEntry" />
        /// interface that corresponds to the result of executing the action.
        /// </returns>
        /// <remarks>
        /// Implementers shall override this method to provide the functionality
        /// of the request.
        /// <para />
        /// This a template method, the call to which is wrapped in a robust
        /// and fault-tolerant override of the
        /// <see
        ///     cref="M:MFR.ActionBase.CommonExecute" />
        /// method.
        /// <para />
        /// The parent method override (a) validates that the _input field is
        /// not null, (b) checks for thrown exceptions, and(c) checks the result
        /// cache first to see if data corresponding to the input is there.
        /// </remarks>
        protected override IFileSystemEntry ExecuteOperationIfNotCached()
        {
            IFileSystemEntry result = default;

            try
            {
                if (Input == null) return result;

                // Run validation on the properties of the input registry query
                // expression object.  Stop if validation fails.
                if (!AccessRegQueryExpressionValidator.ForRegQueryExpression(Input)
                                                 .Validate())
                    return result;

                var loadedValue = Load.String.FromRegistry(
                    Input.KeyPath, Input.ValueName, Input.DefaultValue
                );
                if (string.IsNullOrWhiteSpace(loadedValue)) return result;

                result = MakeNewFileSystemEntry.ForPath(
                    loadedValue.RemoveTrailingBackslashes()
                );
            }
            catch (Exception ex)
            {
                // dump all the exception info to the log
                DebugUtils.LogException(ex);

                result = default;
            }

            return result;
        }
    }
}