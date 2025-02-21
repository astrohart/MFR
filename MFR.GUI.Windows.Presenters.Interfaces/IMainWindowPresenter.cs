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
 */using MFR.CommandLine.Models.Interfaces;
using MFR.Engines.Operations.Interfaces;
using MFR.Events.Common;
using MFR.GUI.Dialogs.Interfaces;
using MFR.GUI.Presenters.Interfaces;
using MFR.GUI.Windows.Interfaces;
using MFR.GUI.Windows.Presenters.Events;
using MFR.Managers.History.Interfaces;
using MFR.Operations.Events;
using MFR.Settings.Configuration.Events;
using System;

namespace MFR.GUI.Windows.Presenters.Interfaces
{
    /// <summary>
    /// Defines the public-exposed methods and properties of the presenter
    /// object for the main application window.
    /// </summary>
    public interface
        IMainWindowPresenter : IPresenter<IMainWindow, IMainWindowPresenter>
    {
        /// <summary>
        /// Gets a reference to an instance of an object that implements the
        /// <see cref="T:MFR.CommandLine.Models.Interfaces.ICommandLineInfo" /> interface,
        /// containing the settings that were specified by the user on the command line
        /// when this application  was launched.
        /// </summary>
        /// <remarks>
        /// This property raises the
        /// <see
        ///     cref="E:MFR.GUI.Windows.Presenters.Interfaces.IMainWindowPresenter.CommandLineInfoChanged" />
        /// event when its value is updated.
        /// </remarks>
        ICommandLineInfo CommandLineInfo
        {
            get;
        }

        /// <summary>
        /// Gets a value that indicates whether the values displayed to the user differ
        /// from those in the configuration file.
        /// </summary>
        bool IsDirty
        {
            get;
        }

        /// <summary>
        /// Gets a value that indicates whether a Profile is currently loaded.
        /// </summary>
        bool IsProfileLoaded
        {
            get;
        }

        /// <summary>
        /// Occurs when an Add Profile operation has failed.
        /// </summary>
        event AddProfileFailedEventHandler AddProfileFailed;

        /// <summary>
        /// Occurs when all the history has been cleared.
        /// </summary>
        event EventHandler AllHistoryCleared;

        /// <summary>
        /// Occurs when the value of the
        /// <see
        ///     cref="P:MFR.GUI.Windows.Presenters.Interfaces.IMainWindowPresenter.CommandLineInfo" />
        /// property is updated.
        /// </summary>
        event EventHandler CommandLineInfoChanged;

        /// <summary>
        /// Occurs when the config has been exported to a file.
        /// </summary>
        event ConfigurationExportedEventHandler ConfigurationExported;

        /// <summary>
        /// Occurs when the config has been imported successfully
        /// from a
        /// file on the file system.
        /// </summary>
        event ConfigurationImportedEventHandler ConfigurationImported;

        /// <summary>
        /// Occurs when the user issues a request to create a new, blank Profile.
        /// </summary>
        event CreateNewBlankProfileRequestedEventHandler
            CreateNewBlankProfileRequested;

        /// <summary>
        /// Occurs when an error happens during a data operation.
        /// </summary>
        event DataOperationErrorEventHandler DataOperationError;

        /// <summary>
        /// Occurs when data is finished being moved to and fro between the
        /// screen and the config data source.
        /// </summary>
        event EventHandler DataOperationFinished;

        /// <summary>
        /// Occurs when a data operation is about to start.
        /// </summary>
        event DataOperationEventHandler DataOperationStarted;

        /// <summary>
        /// Occurs when the processing is done.
        /// </summary>
        event EventHandler Finished;

        /// <summary>
        /// Occurs when an exception is thrown during a file operation.
        /// </summary>
        event ExceptionRaisedEventHandler OperationError;

        /// <summary>
        /// Occurs when the processing has started.
        /// </summary>
        event EventHandler Started;

        /// <summary>
        /// Creates a 'profile' (really a way of saving a group of
        /// config
        /// settings) and then adds it to the collection of profiles that the user has.
        /// </summary>
        /// <param name="name">
        /// (Required.) A descriptive name for the profile.
        /// <para />
        /// The name of the profile can't be reused.
        /// </param>
        /// <exception cref="T:System.ArgumentException">
        /// Thrown if the <paramref name="name" /> parameter has a
        /// <see langref="null" /> reference, or is the blank or whitespace string.
        /// <para />
        /// The <paramref name="name" /> parameter is required.
        /// </exception>
        void AddProfile(string name);

        /// <summary>
        /// Fluent-builder method for initializing the history manager
        /// dependency of this Presenter class. History Manager objects control
        /// the flow of values into and out of the list of previously-specified
        /// values in prior searches.
        /// </summary>
        /// <param name="historyManager">
        /// Reference to an instance of an object that implements the
        /// <see
        ///     cref="T:MFR.IHistoryManager" />
        /// on which this Presenter
        /// should depend.
        /// </param>
        /// <returns>
        /// Reference to the same instance of the object that called this
        /// method, for fluent use.
        /// </returns>
        IMainWindowPresenter AndHistoryManager(IHistoryManager historyManager);

        /// <summary>
        /// Clears all the history lists in the config.
        /// </summary>
        void ClearAllHistory();

        /// <summary>
        /// Executes the operations selected by the user.
        /// </summary>
        void DoSelectedOperations();

        /// <summary>
        /// Exports the current config data to the file on the
        /// user's hard drive having the specified <paramref name="pathname" />.
        /// </summary>
        /// <param name="pathname">
        /// (Required.) A <see cref="T:System.String" /> that contains the fully-qualified
        /// pathname of a file to which the config should be exported.
        /// </param>
        /// <remarks>
        /// If a file having the specified <paramref name="pathname" /> already
        /// exists on the file system at the time the export operation is performed, it will be
        /// overwritten.
        /// </remarks>
        void ExportConfiguration(string pathname);

        /// <summary>
        /// Determines whether the file having the specified <paramref name="pathname" />
        /// exists.
        /// </summary>
        /// <param name="pathname">
        /// (Required.) A <see cref="T:System.String" /> that contains the fully-qualified
        /// pathname of the file to be searched for.
        /// </param>
        /// <returns>
        /// <see langword="true" /> if the <paramref name="pathname" /> is
        /// non-blank and contains the fully-qualified pathname of a file that exists;
        /// <see langword="false" /> otherwise.
        /// </returns>
        bool FileExist(string pathname);

        /// <summary>
        /// This method is called to populate the Profiles combo box.
        /// </summary>
        void FillProfileDropDownList();

        /// <summary>
        /// Imports the config data for this application from the file with the
        /// specified <paramref name="pathname" />.
        /// </summary>
        /// <param name="pathname">
        /// (Required.) A <see cref="T:System.String" /> that contains the fully-qualified
        /// pathname of a file from which the config should be imported.
        /// </param>
        /// <remarks>
        /// The data is presumed to be located inside a JSON-formatted file
        /// that exists on the user's hard drive and has the <c>.json</c> extension.
        /// </remarks>
        void ImportConfiguration(
            string pathname /* path of the file to be imported */
        );

        /// <summary>
        /// Sets the state of the Operations to Perform checked list box items
        /// based on config settings.
        /// </summary>
        void InitializeOperationSelections();

        /// <summary>
        /// Determines whether a Profile having the specified
        /// <paramref name="profileName" /> is already defined.
        /// <para />
        /// The match that is done is case-insensitive.
        /// </summary>
        /// <param name="profileName">
        /// (Required.) String containing the name of the Profile
        /// to search for.
        /// </param>
        /// <returns>
        /// <see langword="true" /> if a Profile having the specified
        /// <paramref name="profileName" /> is defined; <see langword="false" /> otherwise.
        /// </returns>
        /// <exception cref="T:System.ArgumentException">
        /// Thrown if the required parameter,
        /// <paramref name="profileName" />, is passed a blank or <see langword="null" />
        /// string for a value.
        /// </exception>
        bool ProfileAlreadyExist(string profileName);

        /// <summary>
        /// If the user has changed the pathname of where the config file is to be
        /// stored, this method renames the existing config file to match.
        /// </summary>
        /// <param name="newConfigFilePath">
        /// (Required.) A <see cref="T:System.String" /> that contains the new value of the
        /// fully-qualified pathname of the config file.
        /// </param>
        void RenameConfigFileToMatchNewName(string newConfigFilePath);

        /// <summary>
        /// Saves data from the screen control and then saves the
        /// config to the persistence location.
        /// </summary>
        void SaveConfiguration();

        /// <summary>
        /// Runs code that should execute when either the OK or Apply buttons
        /// are clicked on the Tools -&gt; Options dialog box.
        /// </summary>
        /// <param name="dialog">
        /// (Required.) Reference to an instance of an object that implements
        /// the <see cref="T:MFR.GUI.Dialogs.Interfaces.IOptionsDialog" /> interface.
        /// </param>
        /// <exception cref="T:System.ArgumentNullException">
        /// Thrown if the required parameter, <paramref name="dialog" />, is
        /// passed a <see langword="null" /> value.
        /// </exception>
        void SaveConfigurationDataFrom(IOptionsDialog dialog);

        /// <summary>
        /// Transforms the current value of the
        /// <see
        ///     cref="P:MFR.Settings.Configuration.Providers.Interfaces.IConfigurationProvider.ProjectFileRenamerConfig" />
        /// property into a Profile with the <paramref name="profileName" /> specified.
        /// <para />
        /// If a Profile with the same name is already defined, then this method does
        /// nothing.
        /// </summary>
        /// <param name="profileName">
        /// (Required.) String containing the name to give the
        /// new Profile.
        /// </param>
        void SaveCurrentConfigurationAsProfile(string profileName);

        /// <summary>
        /// Updates the value of the
        /// <see
        ///     cref="P:MFR.GUI.Windows.Presenters.Interfaces.IMainWindowPresenter.CommandLineInfo" />
        /// property with the specified <paramref name="cmdInfo" /> reference.
        /// </summary>
        /// <param name="cmdInfo">
        /// (Required.) Reference to an instance of an object that implements the
        /// <see cref="T:MFR.CommandLine.Models.Interfaces.ICommandLineInfo" /> interface.
        /// </param>
        /// <remarks>
        /// If this method updates the value of the
        /// <see
        ///     cref="P:MFR.GUI.Windows.Presenters.Interfaces.IMainWindowPresenter.CommandLineInfo" />
        /// property, then the
        /// <see
        ///     cref="E:MFR.GUI.Windows.Presenters.Interfaces.IMainWindowPresenter.CommandLineInfoChanged" />
        /// event is raised.
        /// </remarks>
        void SetCommandLineInfo(ICommandLineInfo cmdInfo);

        /// <summary>
        /// Fluent-builder method for initializing the operation engine object.  This
        /// the object that actually schedules and runs the file-renaming tasks and
        /// provides user feedback.
        /// </summary>
        /// <param name="operationEngine">
        /// (Required.) Reference to an instance of an object that implements the
        /// <see cref="T:MFR.Engines.Interfaces.IFullGuiOperationEngine" /> interface on
        /// which this Presenter should depend.
        /// </param>
        /// <returns>
        /// Reference to the same instance of the object that called this
        /// method, for fluent use.
        /// </returns>
        IMainWindowPresenter WithOperationEngine(
            IFullGuiOperationEngine operationEngine
        );
    }
}