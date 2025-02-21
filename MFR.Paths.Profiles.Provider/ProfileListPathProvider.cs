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
 */using MFR.Events.Common;
using MFR.GUI.Constants;
using MFR.Paths.Profiles.Provider.Actions;
using MFR.Paths.Profiles.Provider.Interfaces;
using System;
using System.ComponentModel;
using xyLOGIX.Core.Debug;

namespace MFR.Paths.Profiles.Provider
{
    /// <summary>
    /// Manages the loading and the storing of the pathname of the <c>profiles.json</c>
    /// file to/from the system Registry.
    /// </summary>
    public class ProfileListPathProvider : IProfileListPathProvider
    {
        /// <summary>
        /// A <see cref="T:System.String" /> that holds the path the JSON file that stores
        /// profiles.
        /// </summary>
        private string _profileCollectionFilePath;

        /// <summary>
        /// Empty, static constructor to prohibit direct allocation of this class.
        /// </summary>
        static ProfileListPathProvider() { }

        /// <summary>
        /// Empty, protected constructor to prohibit direct allocation of this class.
        /// </summary>
        protected ProfileListPathProvider() { }

        /// <summary>
        /// Gets a reference to the one and only instance of the object that implements the
        /// <see cref="T:MFR.Paths.Profiles.Provider.Interfaces.IProfileListPathProvider" />
        /// interface.
        /// </summary>
        public static IProfileListPathProvider Instance
        {
            get;
        } = new ProfileListPathProvider();

        /// <summary>
        /// Gets a string whose value is the fully-qualified pathname of the profile list
        /// file.
        /// </summary>
        /// <remarks>
        /// When this property's value is updated, the
        /// <see
        ///     cref="E:MFR.Settings.Profiles.Providers.ProfileProvider.ProfileCollectionFilePathChanged" />
        /// event  is raised.
        /// </remarks>
        public string ProfileCollectionFilePath
        {
            get => _profileCollectionFilePath;
            set {
                var changed =
                    !string.IsNullOrWhiteSpace(_profileCollectionFilePath) &&
                    _profileCollectionFilePath != value;
                _profileCollectionFilePath = value;
                if (changed) OnProfileCollectionFilePathChanged();
            }
        }

        /// <summary>
        /// Occurs when the process of loading the value of the
        /// <see
        ///     cref="P:MFR.Paths.Profiles.Provider.Interfaces.IProfileListPathProvider.ProfileCollectionFilePath" />
        /// property from the system Registry is about to begin.
        /// </summary>
        public event CancelEventHandler LoadingProfileCollectionFilePath;

        /// <summary>
        /// Occurs when the value of the
        /// <see
        ///     cref="P:MFR.Settings.Profiles.Providers.ProfileProvider.ProfileCollectionFilePath" />
        /// property is updated.
        /// </summary>
        public event EventHandler ProfileCollectionFilePathChanged;

        /// <summary>
        /// Occurs when the value of the
        /// <see
        ///     cref="P:MFR.Paths.Profiles.Provider.Interfaces.IProfileListPathProvider.ProfileCollectionFilePath" />
        /// property has been loaded from the system Registry.
        /// </summary>
        public event EventHandler ProfileCollectionFilePathLoaded;

        /// <summary>
        /// Occurs when the process of loading the value of the
        /// <see
        ///     cref="P:MFR.Paths.Profiles.Provider.Interfaces.IProfileListPathProvider.ProfileCollectionFilePath" />
        /// property from the system Registry has failed.
        /// </summary>
        public event ExceptionRaisedEventHandler
            ProfileCollectionFilePathLoadFailed;

        /// <summary>
        /// Occurs when the value of the
        /// <see
        ///     cref="P:MFR.Paths.Profiles.Provider.Interfaces.IProfileListPathProvider.ProfileCollectionFilePath" />
        /// property has been saved to the system Registry.
        /// </summary>
        public event EventHandler ProfileCollectionFilePathSaved;

        /// <summary>
        /// Occurs when the process of saving the value of the
        /// <see
        ///     cref="P:MFR.Paths.Profiles.Provider.Interfaces.IProfileListPathProvider.ProfileCollectionFilePath" />
        /// property to the system Registry has failed.
        /// </summary>
        public event ExceptionRaisedEventHandler
            ProfileCollectionFilePathSaveFailed;

        /// <summary>
        /// Occurs when the process of saving the value of the
        /// <see
        ///     cref="P:MFR.Paths.Profiles.Provider.Interfaces.IProfileListPathProvider.ProfileCollectionFilePath" />
        /// property to the system Registry is about to begin.
        /// </summary>
        public event CancelEventHandler SavingProfileCollectionFilePath;

        /// <summary>
        /// Loads the value of the
        /// <see
        ///     cref="P:MFR.Paths.Profiles.Provider.ProfileListPathProvider.ProfileCollectionFilePath" />
        /// property from the system Registry.
        /// </summary>
        /// <remarks>
        /// The
        /// <see
        ///     cref="E:MFR.Paths.Profiles.Provider.ProfileListPathProvider.LoadingProfileCollectionFilePath" />
        /// event is raised before this method begins its operations.  Setting the
        /// <see cref="P:System.ComponentModel.CancelEventArgs.Cancel" /> property to
        /// <see langword="true" /> on this event will prevent this method from executing
        /// further.
        /// <para />
        /// If the operation of obtaining the value of the
        /// <see
        ///     cref="P:MFR.Paths.Profiles.Provider.ProfileListPathProvider.ProfileCollectionFilePath" />
        /// property from the system Registry was successful, then the
        /// <see
        ///     cref="E:MFR.Paths.Profiles.Provider.ProfileListPathProvider.ProfileCollectionFilePathLoaded" />
        /// event is raised.
        /// <para />
        /// Otherwise, if a <see cref="T:System.Exception" /> is raised during the
        /// processing of the operation, then this method raises the
        /// <see
        ///     cref="E:MFR.Paths.Profiles.Provider.ProfileListPathProvider.ProfileCollectionFilePathLoadFailed" />
        /// event.
        /// </remarks>
        public void Load()
        {
            try
            {
                var ce = new CancelEventArgs();
                OnLoadingProfileCollectionFilePath(ce);
                if (ce.Cancel) return;

                ProfileCollectionFilePath = Obtain.ProfileCollectionFilePath(
                    ProgramText.CompanyName,
                    ProgramText.ProductNameWithoutCompany,
                    ProfileCollectionFilePath
                );

                /*
                 * We expect the value of the ProfileCollectionFilePath to not be
                 * blank as a result of a successful load from the system Registry.
                 *
                 * However, the load of a blank value from the system Registry is a
                 * distinct possibility, however.  So we do no checking for validity
                 * of the loaded pathname here.  We just raise the event.
                 *
                 * Checking the value of the ProfileCollectionFilePath property for
                 * non-blank or path exists is the job of the caller of this class.
                 *
                 * We will simply base raising the ProfileCollectionFilePathLoaded event
                 * on whether we made it this far with no Exception being thrown yet.
                 */

                OnProfileCollectionFilePathLoaded();
            }
            catch (Exception ex)
            {
                // dump all the exception info to the log
                DebugUtils.LogException(ex);

                OnProfileCollectionFilePathLoadFailed(
                    new ExceptionRaisedEventArgs(ex)
                );
            }
        }

        /// <summary>
        /// Saves the value of the
        /// <see
        ///     cref="P:MFR.Paths.Profiles.Provider.Interfaces.IProfileListPathProvider.ProfileCollectionFilePath" />
        /// property to the system Registry.
        /// </summary>
        /// <remarks>
        /// The
        /// <see
        ///     cref="E:MFR.Paths.Profiles.Provider.ProfileListPathProvider.SavingProfileCollectionFilePath" />
        /// event is raised before this method begins its operations.  Setting the
        /// <see cref="P:System.ComponentModel.CancelEventArgs.Cancel" /> property to
        /// <see langword="true" /> on this event will prevent this method from executing
        /// further.
        /// <para />
        /// If the operation of storing the value of the
        /// <see
        ///     cref="P:MFR.Paths.Profiles.Provider.ProfileListPathProvider.ProfileCollectionFilePath" />
        /// property to the system Registry was successful, then the
        /// <see
        ///     cref="E:MFR.Paths.Profiles.Provider.ProfileListPathProvider.ProfileCollectionFilePathSaved" />
        /// event is raised.
        /// <para />
        /// Otherwise, if a <see cref="T:System.Exception" /> is raised during the
        /// processing of the operation, then this method raises the
        /// <see
        ///     cref="E:MFR.Paths.Profiles.Provider.ProfileListPathProvider.ProfileCollectionFilePathSaveFailed" />
        /// event.
        /// </remarks>
        public void Save()
        {
            try
            {
                var ce = new CancelEventArgs();
                OnSavingProfileCollectionFilePath(ce);
                if (ce.Cancel) return;

                Store.ProfileCollectionFilePathToRegistry(
                    ProgramText.CompanyName,
                    ProgramText.ProductNameWithoutCompany,
                    ProfileCollectionFilePath
                );

                OnProfileCollectionFilePathSaved();
            }
            catch (Exception ex)
            {
                // dump all the exception info to the log
                DebugUtils.LogException(ex);

                OnProfileCollectListPathSaveFailed(
                    new ExceptionRaisedEventArgs(ex)
                );
            }
        }

        /// <summary>
        /// Raises the
        /// <see
        ///     cref="E:MFR.Paths.Profiles.Provider.ProfileListPathProvider.LoadingProfileCollectionFilePath" />
        /// event.
        /// </summary>
        /// <param name="e">
        /// A <see cref="T:System.ComponentModel.CancelEventArgs" /> that
        /// allows us to cancel the operation that this event is notifying the caller of.
        /// <para />
        /// To cancel the operation, handlers should set the value of the
        /// <see cref="P:System.ComponentModel.CancelEventArgs.Cancel" /> property to
        /// <see langword="true" />.
        /// </param>
        protected virtual void OnLoadingProfileCollectionFilePath(
            CancelEventArgs e
        )
            => LoadingProfileCollectionFilePath?.Invoke(this, e);

        /// <summary>
        /// Raises the
        /// <see
        ///     cref="E:MFR.Settings.Profiles.Providers.ProfileProvider.ProfileCollectionFilePathChanged" />
        /// event.
        /// </summary>
        protected virtual void OnProfileCollectionFilePathChanged()
        {
            Save();

            ProfileCollectionFilePathChanged?.Invoke(this, EventArgs.Empty);
        }

        /// <summary>
        /// Raises the
        /// <see
        ///     cref="E:MFR.Paths.Profiles.Provider.ProfileListPathProvider.ProfileCollectionFilePathLoaded" />
        /// event.
        /// </summary>
        protected virtual void OnProfileCollectionFilePathLoaded()
            => ProfileCollectionFilePathLoaded?.Invoke(this, EventArgs.Empty);

        /// <summary>
        /// Raises the
        /// <see
        ///     cref="E:MFR.Paths.Profiles.Provider.ProfileListPathProvider.ProfileCollectionFilePathLoadFailed" />
        /// event.
        /// </summary>
        /// <param name="e">
        /// A <see cref="T:MFR.Events.Common.ExceptionRaisedEventArgs" />
        /// that contains the event data.
        /// </param>
        protected virtual void OnProfileCollectionFilePathLoadFailed(
            ExceptionRaisedEventArgs e
        )
            => ProfileCollectionFilePathLoadFailed?.Invoke(this, e);

        /// <summary>
        /// Raises the
        /// <see
        ///     cref="E:MFR.Paths.Profiles.Provider.ProfileListPathProvider.ProfileCollectionFilePathSaved" />
        /// event.
        /// </summary>
        protected virtual void OnProfileCollectionFilePathSaved()
            => ProfileCollectionFilePathSaved?.Invoke(this, EventArgs.Empty);

        /// <summary>
        /// Raises the
        /// <see
        ///     cref="E:MFR.Paths.Profiles.Provider.ProfileListPathProvider.ProfileCollectionFilePathSaveFailed" />
        /// event.
        /// </summary>
        /// <param name="e">
        /// A <see cref="T:MFR.Events.Common.ExceptionRaisedEventArgs" />
        /// that contains the event data.
        /// </param>
        protected virtual void OnProfileCollectListPathSaveFailed(
            ExceptionRaisedEventArgs e
        )
            => ProfileCollectionFilePathSaveFailed?.Invoke(this, e);

        /// <summary>
        /// Raises the
        /// <see
        ///     cref="E:MFR.Paths.Profiles.Provider.ProfileListPathProvider.SavingProfileCollectionFilePath" />
        /// event.
        /// </summary>
        /// <param name="e">
        /// A <see cref="T:System.ComponentModel.CancelEventArgs" /> that
        /// allows us to cancel the operation that this event is notifying the caller of.
        /// <para />
        /// To cancel the operation, handlers should set the value of the
        /// <see cref="P:System.ComponentModel.CancelEventArgs.Cancel" /> property to
        /// <see langword="true" />.
        /// </param>
        protected virtual void OnSavingProfileCollectionFilePath(
            CancelEventArgs e
        )
            => SavingProfileCollectionFilePath?.Invoke(this, e);
    }
}