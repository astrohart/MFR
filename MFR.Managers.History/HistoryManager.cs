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

using MFR.Managers.History.Interfaces;
using MFR.Settings.Configuration;
using MFR.Settings.Configuration.Interfaces;
using MFR.Settings.Configuration.Providers.Factories;
using MFR.Settings.Configuration.Providers.Interfaces;
using PostSharp.Patterns.Diagnostics;
using System;
using System.Collections;
using System.Linq;
using System.Windows.Forms;
using xyLOGIX.Core.Extensions;

namespace MFR.Managers.History
{
    /// <summary>
    /// Manages the config history on behalf of the application.
    /// </summary>
    public class HistoryManager : ConfigurationComposedObjectBase,
        IHistoryManager
    {
        /// <summary>
        /// Reference to an instance of an object that implements the
        /// <see
        ///     cref="T:System.Windows.Forms.IWin32Window" />
        /// interface.
        /// </summary>
        /// <remarks>
        /// This field is supposed to be filled with a reference to an object
        /// that represents the main window of the application.
        /// </remarks>
        private readonly IWin32Window _messageBoxParentWindow;

        /// <summary>
        /// Initializes static data or performs actions that need to be performed once only
        /// for the <see cref="T:MFR.Managers.History.HistoryManager" /> class.
        /// </summary>
        /// <remarks>
        /// This constructor is called automatically prior to the first instance being
        /// created or before any static members are referenced.
        /// <para />
        /// We've decorated this constructor with the <c>[Log(AttributeExclude = true)]</c>
        /// attribute in order to simplify the logging output.
        /// </remarks>
        [Log(AttributeExclude = true)]
        static HistoryManager() { }

        /// <summary>
        /// Constructs a new instance of
        /// <see
        ///     cref="T:MFR.HistoryManager" />
        /// and returns a
        /// reference to it.
        /// </summary>
        /// <param name="messageBoxParentWindow">
        /// (Required.) Reference to an instance of an object that implements
        /// the <see cref="T:System.Windows.Forms.IWin32Window" /> interface and
        /// which will serve as the parent window for any message boxes
        /// displayed by this object.
        /// </param>
        /// <exception cref="T:System.ArgumentNullException">
        /// Thrown if the required parameter,
        /// <paramref
        ///     name="messageBoxParentWindow" />
        /// , is passed a <see langword="null" /> value.
        /// </exception>
        [Log(AttributeExclude = true)]
        public HistoryManager(IWin32Window messageBoxParentWindow)
        {
            _messageBoxParentWindow = messageBoxParentWindow ??
                                      throw new ArgumentNullException(
                                          nameof(messageBoxParentWindow)
                                      );
        }

        /// <summary>
        /// Gets a reference to the sole instance of the object that implements the
        /// <see
        ///     cref="T:MFR.Settings.Configuration.Providers.Interfaces.IProjectFileRenamerConfigProvider" />
        /// interface.
        /// </summary>
        /// <remarks>
        /// This object allows access to the user config and the
        /// actions
        /// associated with it.
        /// </remarks>
        private static IProjectFileRenamerConfigProvider
            ConfigProvider
            => GetProjectFileRenamerConfigProvider.SoleInstance();

        /// <summary>
        /// Gets or sets a reference to an instance of an object that implements
        /// the
        /// <see
        ///     cref="T:MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfig" />
        /// interface.
        /// </summary>
        public override IProjectFileRenamerConfig CurrentConfig
        {
            get;
            set;
        } = ConfigProvider.CurrentConfig;

        /// <summary>
        /// Clears all the history objects in a config object.
        /// </summary>
        /// <returns>
        /// <see langword="true" /> if the Clear operation was carried out
        /// successfully; <see langword="false" /> otherwise.
        /// </returns>
        [Log(AttributeExclude = true)]
        public bool ClearAll()
        {
            if (!CanClearAll())
                return false;

            // Since this config object may have god knows how many
            // history list properties, just use reflection to find and iterate
            // through all of them, invoking the System.Collections.IList.Clear
            // method on each one.
            var historyLists = CurrentConfig.GetType()
                                                   .GetProperties()
                                                   .Where(
                                                       x => x.PropertyType
                                                               .GetActualType() !=
                                                           x.PropertyType &&
                                                           x.Name.Contains(
                                                               "History"
                                                           )
                                                   )
                                                   .Select(
                                                       p => p.GetValue(
                                                           CurrentConfig
                                                       ) as IList
                                                   )
                                                   .ToArray();
            if (!historyLists.Any())
                return false;

            foreach (var list in historyLists)
                list.Clear();

            // Finally, clear out all the current values of the form. This
            // basically like a "Reset Form" button on a website.
            CurrentConfig.StartingFolder =
                CurrentConfig.FindWhat =
                    CurrentConfig.ReplaceWith = string.Empty;

            return true; // success
        }

        /// <summary>
        /// Gets a value indicating whether we can clear all the history objects
        /// or not.
        /// </summary>
        /// <returns>
        /// <see langword="true" /> if the user confirms that all the history can
        /// be cleared; <see langword="false" /> otherwise.
        /// </returns>
        /// <remarks>
        /// This method does nothing but return <see langword="false" /> if all
        /// the history lists are already clear, since, in that event, this
        /// means that there is nothing to do.
        /// </remarks>
        private bool CanClearAll()
        {
            if (!CurrentConfig.StartingFolderHistory.Any() &&
                !CurrentConfig.FindWhatHistory.Any() &&
                !CurrentConfig.ReplaceWithHistory.Any())
                return false;

            return DialogResult.Yes == MessageBox.Show(
                _messageBoxParentWindow,
                "Are you sure you want to erase all the items from your search history?\n\nThis action cannot be undone.",
                Application.ProductName, MessageBoxButtons.YesNo,
                MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2
            );
        }
    }
}