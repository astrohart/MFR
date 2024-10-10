using MFR.CommandLine.Models.Interfaces;
using MFR.GUI.Controls;
using MFR.GUI.Controls.Interfaces;
using MFR.GUI.Windows.Constants;
using MFR.GUI.Windows.Events;
using System.Diagnostics;
using System.Windows.Forms;
using xyLOGIX.Core.Extensions;
using xyLOGIX.UI.Dark.Controls;

namespace MFR.GUI.Windows.Interfaces
{
    /// <summary>
    /// Defines the public-exposed methods and properties of the main window of
    /// the application.
    /// </summary>
    public interface IMainWindow : IForm
    {
        /// <summary>
        /// Gets or sets the text displayed in the edit portion of the <b>Find What</b>
        /// combo box.
        /// </summary>
        string FindWhat
        {
            get;
            set;
        }

        /// <summary>
        /// Gets a reference to the text box control that allows the user to
        /// specify the text to be found.
        /// </summary>
        IEntryRespectingComboBox FindWhatComboBox
        {
            [DebuggerStepThrough] get;
        }

        /// <summary>
        /// Gets a reference to the
        /// <see
        ///     cref="T:MFR.GUI.Controls.FoldUnfoldButton" />
        /// that controls whether
        /// the form is the folded (smaller) size or unfolded (larger, with more
        /// options visible) size.
        /// </summary>

        // do not log this method
        FoldUnfoldButton FoldButton
        {
            [DebuggerStepThrough] get;
        }

        /// <summary>
        /// Gets the full name of this application, including the current version.
        /// </summary>
        string FullApplicationName
        {
            get;
        }

        /// <summary>
        /// Gets a value indicating whether the data entered on this form is valid.
        /// </summary>
        bool IsDataValid
        {
            get;
        }

        /// <summary>
        /// Gets or sets a value specifying whether the form is in the Folded state.
        /// </summary>
        bool IsFolded
        {
            [DebuggerStepThrough] get;
            set;
        }

        /// <summary>
        /// Gets or sets the value of the Match Case checkbox
        /// </summary>
        bool MatchCase
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the value of the Match Exact Word checkbox
        /// </summary>
        bool MatchExactWord
        {
            get;
            set;
        }

        /// <summary>
        /// Gets a reference to the
        /// <see
        ///     cref="T:System.Windows.Forms.CheckedListBox" />
        /// that has the list of operations.
        /// </summary>
        CheckedListBox OperationsCheckedListBox
        {
            [DebuggerStepThrough] get;
        }

        /// <summary>
        /// Gets a reference to a <see cref="T:System.Windows.Forms.ToolStripComboBox" />
        /// that has a drop-down list of the profiles that the user has created.
        /// </summary>
        DarkToolStripComboBox ProfileCollectionComboBox
        {
            get;
        }

        /// <summary>
        /// Gets or sets the text displayed in the edit portion of the <b>Replace With</b>
        /// combo box.
        /// </summary>
        string ReplaceWith
        {
            get;
            set;
        }

        /// <summary>
        /// Gets a reference to the dropdown that allows the user to specify the
        /// text to replace found text with.
        /// </summary>
        IEntryRespectingComboBox ReplaceWithComboBox
        {
            [DebuggerStepThrough] get;
        }

        /// <summary>
        /// Gets or sets the value of the Select/Deselect All checkbox
        /// </summary>
        bool SelectAll
        {
            [DebuggerStepThrough] get;
            set;
        }

        /// <summary>
        /// Gets or sets the index of the tab that is selected in the Options
        /// tab control.
        /// </summary>
        int SelectedOptionTab
        {
            [DebuggerStepThrough] get;
            set;
        }

        /// <summary>
        /// Gets or sets a <see cref="T:System.String" /> that is configured as the folder
        /// in which operations are to commence.
        /// </summary>
        string StartingFolder
        {
            get;
            set;
        }

        /// <summary>
        /// Gets a reference to the control that allows the user to specify the
        /// path to the starting folder.
        /// </summary>
        IEntryRespectingComboBox StartingFolderComboBox
        {
            [DebuggerStepThrough] get;
        }

        /// <summary>
        /// Gets  the <see cref="T:MFR.GUI.Windows.Constants.MainWindowState" />
        /// enumeration value that describes the current state.
        /// </summary>
        MainWindowState State
        {
            get;
        }

        /// <summary>
        /// Gets a string containing this application's version.
        /// </summary>
        /// <remarks>
        /// Thanks to
        /// <a
        ///     href="
        /// https://social.msdn.microsoft.com/Forums/vstudio/en-US/d9a69018-4840-4aeb-b9f1-4d98ab35f782/applicationproductversion?forum=csharpgeneral
        /// ">
        /// Kiran
        /// Suthar
        /// </a>
        /// 's answer on the Microsoft forums.
        /// </remarks>
        string Version
        {
            [DebuggerStepThrough] get;
        }

        /// <summary>
        /// Occurs when the value of the <see cref="P:MFR.GUI.Windows.MainWindow.State" />
        /// property is updated.
        /// </summary>
        event MainWindowStateChangedEventHandler StateChanged;

        /// <summary>
        /// Associates the specified <paramref name="cmdInfo" /> object with this window.
        /// </summary>
        /// <param name="cmdInfo">
        /// (Required.) Reference to an instance of an object that implements the
        /// <see cref="T:MFR.CommandLine.Models.Interfaces.ICommandLineInfo" /> interface
        /// that contains the settings specified by the user on the command line when this
        /// application was launched.
        /// </param>
        void AttachCommandLineInfo(ICommandLineInfo cmdInfo);

        /// <summary>
        /// Deselects all the available operations that are listed on the <b>Operations</b>
        /// tab.
        /// </summary>
        void DeselectAllOperations();

        /// <summary>
        /// Clears all the items from the Profile List combo box and then adds the
        /// <c>
        /// &lt;No profile selected&gt;
        /// </c>
        /// item and then selects the first element in the
        /// <see cref="P:System.Windows.Forms.ToolStripComboBox.Items" /> list.
        /// </summary>
        void ResetProfileCollectionComboBox();

        /// <summary>
        /// Selects all the available operations that are listed on the <b>Operations</b>
        /// tab.
        /// </summary>
        void SelectAllOperations();

        /// <summary>
        /// Updates the value of the <see cref="P:MFR.GUI.Windows.MainWindow.State" />
        /// property.
        /// </summary>
        /// <param name="newState">
        /// (Required.) One of the
        /// <see cref="T:MFR.GUI.Windows.Constants.MainWindowState" /> values that
        /// identifies the new state to be set.
        /// </param>
        void SetState(MainWindowState newState);
    }
}