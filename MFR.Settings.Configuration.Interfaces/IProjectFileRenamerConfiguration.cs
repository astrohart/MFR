using MFR.GUI.Models.Interfaces;
using MFR.Settings.Configuration.Events;
using System.Collections.Generic;

namespace MFR.Settings.Configuration.Interfaces
{
    /// <summary>
    /// Defines the public-exposed methods and properties of a
    /// configuration object.
    /// </summary>
    public interface IProjectFileRenamerConfiguration
    {
        /// <summary>
        /// Gets or sets a <see cref="T:System.Boolean" /> value indicating whether the
        /// application should automatically terminate once the user's requested operations
        /// are complete.
        /// </summary>
        bool AutoQuitOnCompletion
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets a value indicating whether the specified operation(s) should be
        /// automatically initiated when the application starts.  If this value is set to
        /// <see langword="true" /> then the application quits automatically after the
        /// specified operation(s) have been completed.
        /// </summary>
        /// <remarks>
        /// This flag is ignored if this configuration did not originate
        /// from the command
        /// line.
        /// </remarks>
        bool AutoStart
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the text to be found that was most-recently specified
        /// by the user.
        /// </summary>
        string FindWhat
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets a collection of strings consisting of the most-recently
        /// utilized values for Find What.
        /// </summary>
        List<string> FindWhatHistory
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets a reference to a collection of instances of
        /// <see cref="T:MFR.GUI.Models.OperationTypeInfo" /> instances, that represents
        /// all the operations the user can perform with this application.
        /// </summary>
        List<IOperationTypeInfo> InvokableOperations
        {
            get;
            set;
        }

        /// <summary>
        /// Gets a value indicating whether the form is in the Folded state.
        /// </summary>
        /// <remarks>
        /// If this value is <see langword="true" /> when the form is loaded, then ensure
        /// that the form displays in the folded state.
        /// </remarks>
        bool IsFolded
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets a value indicating whether this configuration
        /// was specified by the
        /// user on the command line.
        /// </summary>
        bool IsFromCommandLine
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets a value indicating whether we should match the case on
        /// found text.
        /// </summary>
        bool MatchCase
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets a value indicating whether we should match the whole
        /// word on found text.
        /// </summary>
        bool MatchExactWord
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets a value that indicates whether we should rename files
        /// in the folders encountered.
        /// </summary>
        bool RenameFiles
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets a <see cref="T:System.Boolean" /> value that indicates whether the
        /// containing folder(s) of solution(s) contained in the search should be renamed.
        /// </summary>
        bool RenameSolutionFolders
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets a value that indicates whether we should rename subfolders.
        /// </summary>
        bool RenameSubFolders
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets a flag that indicates whether to attempt to close and
        /// then re-open the Visual Studio solution, if open, that contains the
        /// project(s) being renamed.
        /// <para />
        /// </summary>
        /// <remarks>
        /// If this is set to <see langword="true" />, and the containing solution is open,
        /// then the solution will be closed prior to the start of the selected
        /// operation(s) and then re-opened when the selected operation(s) are complete.
        /// </remarks>
        bool ReOpenSolution
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets a value that indicates whether we should replace text
        /// in files.
        /// </summary>
        bool ReplaceTextInFiles
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the text that found text should be replaced with.
        /// </summary>
        string ReplaceWith
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets a collection of strings that correspond to the
        /// most-recently-used values for Replace With.
        /// </summary>
        List<string> ReplaceWithHistory
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets a number from 0...N, where N is the number of option
        /// tabs, of the one that is currently selected.
        /// </summary>
        int SelectedOptionTab
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets a string containing the path to the starting folder of
        /// the search.
        /// </summary>
        string StartingFolder
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets a collection of strings that correspond to the
        /// most-recently-used values for Starting Folder.
        /// </summary>
        List<string> StartingFolderHistory
        {
            get;
            set;
        }

        /// <summary>
        /// Occurs when the value of the
        /// <see
        ///     cref="P:MFR.Settings.ProjectFileRenamerConfiguration.Interfaces.IProjectFileRenamerConfiguration.StartingFolder" />
        /// property has been updated.
        /// </summary>
        event StartingFolderChangedEventHandler StartingFolderChanged;
    }
}