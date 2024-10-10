using MFR.GUI.Models.Extensions;
using MFR.GUI.Models.Interfaces;
using MFR.Operations.Constants;
using MFR.Settings.Configuration.Events;
using MFR.Settings.Configuration.Interfaces;
using MFR.Settings.Configuration.Properties;
using Newtonsoft.Json;
using PostSharp.Patterns.Diagnostics;
using System;
using System.Collections.Generic;
using System.Linq;
using xyLOGIX.Core.Debug;
using Initialize = MFR.GUI.Models.Actions.Initialize;

namespace MFR.Settings.Configuration
{
    /// <summary>
    /// Contains properties whose values are set by the user.
    /// </summary>
    /// <remarks>
    /// The values of this class' properties are used to affect the behavior of
    /// the application.
    /// </remarks>
    [Log(AttributeExclude = true)]
    public class ProjectFileRenamerConfig : IProjectFileRenamerConfig
    {
        /// <summary>
        /// A <see cref="T:System.String" /> containing the fully-qualified pathname of the
        /// folder in which the selected operation(s) should be initiated.
        /// </summary>
        private string _startingFolder;

        /// <summary>
        /// Constructs a new instance of
        /// <see
        ///     cref="T:MFR.Settings.Configuration.ProjectFileRenamerConfig" />
        /// and returns a reference to it.
        /// </summary>
        public ProjectFileRenamerConfig()
        {
            Reset();
        }

        /// <summary>
        /// Constructs a new instance of
        /// <see
        ///     cref="T:MFR.Settings.Configuration.ProjectFileRenamerConfig" />
        /// and returns a reference to it.
        /// </summary>
        /// <param name="source">
        /// (Required.) Reference to an instance of an object that implements the
        /// <see
        ///     cref="T:MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfig" />
        /// interface
        /// that contains existing config settings to copy into this object.
        /// </param>
        /// <exception cref="T:System.ArgumentNullException">
        /// Thrown if the required
        /// parameter, <paramref name="source" />, is passed a <see langword="null" />
        /// value.
        /// </exception>
        public ProjectFileRenamerConfig(IProjectFileRenamerConfig source)
        {
            if (source == null) throw new ArgumentNullException(nameof(source));

            Reset();

            AutoStart = source.AutoStart;
            AutoQuitOnCompletion = source.AutoQuitOnCompletion;
            FindWhat = source.FindWhat;
            FindWhatHistory = source.FindWhatHistory;
            IsFolded = source.IsFolded;
            IsFromCommandLine = source.IsFromCommandLine;
            MatchCase = source.MatchCase;
            MatchExactWord = source.MatchExactWord;
            InvokableOperations = source.InvokableOperations;
            ReOpenSolution = source.ReOpenSolution;
            RenameFilesInFolder = source.RenameFilesInFolder;
            RenameSolutionFolders = source.RenameSolutionFolders;
            RenameSubFolders = source.RenameSubFolders;
            ReplaceTextInFiles = source.ReplaceTextInFiles;
            ReplaceWith = source.ReplaceWith;
            ReplaceWithHistory = source.ReplaceWithHistory;
            SelectedOptionTab = source.SelectedOptionTab;
            StartingFolder = source.StartingFolder;
            StartingFolderHistory = source.StartingFolderHistory;
        }

        /// <summary>
        /// Constructs a new instance of
        /// <see cref="T:MFR.Settings.Configuration.ProjectFileRenamerConfig" /> and
        /// returns a reference to it.
        /// </summary>
        /// <param name="errantProcesses">
        /// (Required.) A collection of references to instances of
        /// <see cref="T:System.String" />, each element of which is the name of a process
        /// that is to be killed prior to the start of an operation.
        /// </param>
        /// <param name="operations">
        /// (Required.) Reference to an instance of a collection of instances of objects
        /// that implement the
        /// <see cref="T:MFR.GUI.Models.Interfaces.IOperationTypeInfo" /> interface, each
        /// element of which specifies configuration information, such as whether the
        /// operation is disabled, for each invokable operation.
        /// </param>
        [JsonConstructor]
        public ProjectFileRenamerConfig(
            IEnumerable<string> errantProcesses,
            IEnumerable<IOperationTypeInfo> operations
        )
        {
            Reset();

            if (!AddErrantProcessEntries(errantProcesses)) return;

            if (!AddInvokableOperationEntries(operations)) return;
        }

        /// <summary>
        /// Gets or sets a <see cref="T:System.Boolean" /> value indicating whether the
        /// application should automatically terminate once the user's requested operations
        /// are complete.
        /// </summary>
        [JsonProperty("autoQuitWhenRunInteractively")]
        public bool AutoQuitOnCompletion
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
        /// This flag is ignored if this config did not originate from the command
        /// line.
        /// </remarks>
        [JsonIgnore]
        public bool AutoStart
        {
            get;
            set;
        }

        public static IProjectFileRenamerConfig Blank
        {
            get;
        } = new ProjectFileRenamerConfig();

        /// <summary>
        /// Gets or sets a <see cref="T:System.String" /> containing the email address(es)
        /// of the author(s) of commits made to a local Git repository(ies) by this
        /// application.
        /// </summary>
        [JsonProperty("commitAuthorEmail")]
        public string CommitAuthorEmail
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets a <see cref="T:System.String" /> containing the name of the
        /// author(s) of commits made to a local Git repository(ies) by this application.
        /// </summary>
        [JsonProperty("commitAuthorName")]
        public string CommitAuthorName
        {
            get;
            set;
        }

        /// <summary>
        /// Gets a reference to an instance of a collection, each of whose elements are of
        /// type <see cref="T:System.String" />, representing the list of errant processes
        /// we should attempt to kill prior to the beginning of an operation.
        /// </summary>
        [JsonProperty("errantProcessesList")]
        public IList<string> ErrantProcessesList
        {
            get;
            set;
        } = new List<string>();

        /// <summary>
        /// Gets or sets the text to be found that was most-recently specified
        /// by the user.
        /// </summary>
        [JsonProperty("findWhat")]
        public string FindWhat
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets a collection of strings consisting of the most-recently
        /// utilized values for Find What.
        /// </summary>
        [JsonProperty("findWhatHistory")]
        public IList<string> FindWhatHistory
        {
            get;
            set;
        } = new List<string>();

        /// <summary>
        /// Gets or sets a reference to a collection of instances of
        /// <see cref="T:MFR.GUI.Models.OperationTypeInfo" /> instances, that represents
        /// all the operations the user can perform with this application.
        /// </summary>
        [JsonProperty("invokableOperations")]
        public IList<IOperationTypeInfo> InvokableOperations
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
        [JsonProperty("isFolded")]
        public bool IsFolded
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets a value indicating whether this config was specified by the
        /// user on the command line.
        /// </summary>
        public bool IsFromCommandLine
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets a value indicating whether we should match the case on
        /// found text.
        /// </summary>
        [JsonProperty("matchCase")]
        public bool MatchCase
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets a value indicating whether we should match the whole
        /// word on found text.
        /// </summary>
        [JsonProperty("matchExactWord")]
        public bool MatchExactWord
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets a <see cref="T:System.String" /> that, when formatted, becomes the
        /// commit message for pending changes that are committed prior to the start of the
        /// operations.
        /// </summary>
        [JsonProperty("pendingChangesCommitMessage")]
        public string PendingChangesCommitMessageFormat
        {
            get;
            set;
        } = Resources.Default_PendingChangesCommitMessage;

        /// <summary>
        /// Gets or sets a <see cref="T:System.String" /> that, when formatted, becomes the
        /// detailed commit message for pending changes that are committed prior to the
        /// start of the operations.
        /// </summary>
        [JsonProperty("pendingChangesDetailedCommitMessageFormat")]
        public string PendingChangesDetailedCommitMessageFormat
        {
            get;
            set;
        } = Resources.Default_PendingChangesDetailedCommitMessage;

        /// <summary>
        /// Gets or sets a <see cref="T:System.String" /> that, when formatted, becomes the
        /// commit message for the changed files once the operations have been completed.
        /// </summary>
        [JsonProperty("postOperationCommitMessage")]
        public string PostOperationCommitMessageFormat
        {
            get;
            set;
        } = Resources.Default_PostOperationCommitMessage;

        /// <summary>
        /// Gets or set a <see cref="T:System.String" /> that, when formatted, becomes the
        /// detailed commit message for the changed files once the operations have been
        /// completed.
        /// </summary>
        [JsonProperty("postOperationDetailedCommitMessage")]
        public string PostOperationDetailedCommitMessageFormat
        {
            get;
            set;
        } = Resources.Default_PostOperationDetailedCommitMessage;

        /// <summary>
        /// Gets or sets a value indicating whether the application should prompt the user
        /// if it detects that one or more instances of Visual Studio are open, but none of
        /// them have the target Solution(s) loaded.
        /// </summary>
        /// <remarks>
        /// The default value of this property is <see langword="true" />.
        /// <para />
        /// Set to <see langword="false" /> to suppress the display of the warning message
        /// box.  <b>NOTE:</b> If users suppress the message box, and one or more of the
        /// target Solution(s) are indeed loaded by a running instance of Visual Studio,
        /// then there may be file-sharing/permissions issues during the operation(s).
        /// </remarks>
        [JsonProperty("promptUserToReloadOpenSolution")]
        public bool PromptUserToReloadOpenSolution
        {
            get;
            set;
        } = true;

        /// <summary>
        /// Gets or sets a <see cref="T:System.Boolean" /> value indicating whether the
        /// application should automatically push the commits it creates to the remote
        /// repository when done with the requested operation(s).
        /// </summary>
        /// <remarks>This property is set to <see langword="true" /> by default.</remarks>
        [JsonProperty("pushChangesToRemoteWhenDone")]
        public bool PushChangesToRemoteWhenDone
        {
            get;
            set;
        } = true;

        /// <summary>
        /// Gets or sets a value that indicates whether we should rename files
        /// in the folders encountered.
        /// </summary>
        [JsonIgnore]
        public bool RenameFilesInFolder
        {
            get {
                var result = false;

                try
                {
                    if (InvokableOperations == null) return result;
                    if (!InvokableOperations.Any(
                            o => o.IsOfType(OperationType.RenameFilesInFolder)
                        ))
                        return result;

                    result =
                        InvokableOperations[
                            (int)OperationType.RenameFilesInFolder].Enabled;
                }
                catch (Exception ex)
                {
                    // dump all the exception info to the log
                    DebugUtils.LogException(ex);

                    result = false;
                }

                return result;
            }
            set {
                try
                {
                    if (InvokableOperations == null) return;
                    if (!InvokableOperations.Any(
                            o => OperationType.RenameFilesInFolder.Equals(
                                o.OperationType
                            )
                        )) return;

                    InvokableOperations[(int)OperationType.RenameFilesInFolder]
                        .Enabled = value;
                }
                catch (Exception ex)
                {
                    // dump all the exception info to the log
                    DebugUtils.LogException(ex);
                }
            }
        }

        /// <summary>
        /// Gets or sets a value that indicates whether we should rename folders that
        /// contain Visual Studio Solution (<c>*.sln</c>) files.
        /// </summary>
        [JsonIgnore]
        public bool RenameSolutionFolders
        {
            get {
                var result = false;

                try
                {
                    if (InvokableOperations == null) return result;
                    if (!InvokableOperations.Any(
                            o => o.IsOfType(OperationType.RenameSolutionFolders)
                        ))
                        return result;

                    result = InvokableOperations[
                        (int)OperationType.RenameSolutionFolders].Enabled;
                }
                catch (Exception ex)
                {
                    // dump all the exception info to the log
                    DebugUtils.LogException(ex);

                    result = false;
                }

                return result;
            }
            set {
                try
                {
                    if (InvokableOperations == null) return;
                    if (!InvokableOperations.Any(
                            o => o.IsOfType(OperationType.RenameSolutionFolders)
                        ))
                        return;

                    InvokableOperations[
                            (int)OperationType.RenameSolutionFolders].Enabled =
                        value;
                }
                catch (Exception ex)
                {
                    // dump all the exception info to the log
                    DebugUtils.LogException(ex);
                }
            }
        }

        /// <summary>
        /// Gets or sets a value that indicates whether we should rename subfolders.
        /// </summary>
        [JsonIgnore]
        public bool RenameSubFolders
        {
            get {
                var result = false;

                try
                {
                    if (InvokableOperations == null) return result;
                    if (!InvokableOperations.Any(
                            o => o.IsOfType(OperationType.RenameSubFolders)
                        ))
                        return result;

                    result = InvokableOperations[
                        (int)OperationType.RenameSubFolders].Enabled;
                }
                catch (Exception ex)
                {
                    // dump all the exception info to the log
                    DebugUtils.LogException(ex);

                    result = false;
                }

                return result;
            }
            set {
                try
                {
                    if (InvokableOperations == null) return;
                    if (!InvokableOperations.Any(
                            o => OperationType.RenameSubFolders.Equals(
                                o.OperationType
                            )
                        )) return;

                    InvokableOperations[(int)OperationType.RenameSubFolders]
                        .Enabled = value;
                }
                catch (Exception ex)
                {
                    // dump all the exception info to the log
                    DebugUtils.LogException(ex);
                }
            }
        }

        /// <summary>
        /// Gets or sets a flag that indicates whether to attempt to close and
        /// then re-open the Visual Studio solution, if open, that contains the
        /// project(s) being renamed.
        /// <para />
        /// </summary>
        /// <remarks>
        /// If this set to <see langword="true" />, and the containing solution is open,
        /// then the solution will be closed prior to the start of the selected
        /// operation(s) and then re-opened when the selected operation(s) are complete.
        /// </remarks>
        [JsonProperty("reOpenSolution")]
        public bool ReOpenSolution
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets a value that indicates whether we should replace text
        /// in files.
        /// </summary>
        [JsonIgnore]
        public bool ReplaceTextInFiles
        {
            get {
                var result = false;

                try
                {
                    if (InvokableOperations == null) return result;
                    if (!InvokableOperations.Any(
                            o => o.IsOfType(OperationType.ReplaceTextInFiles)
                        ))
                        return result;

                    result = InvokableOperations[
                        (int)OperationType.ReplaceTextInFiles].Enabled;
                }
                catch (Exception ex)
                {
                    // dump all the exception info to the log
                    DebugUtils.LogException(ex);

                    result = false;
                }

                return result;
            }
            set {
                try
                {
                    if (InvokableOperations == null) return;
                    if (!InvokableOperations.Any(
                            o => OperationType.ReplaceTextInFiles.Equals(
                                o.OperationType
                            )
                        )) return;

                    InvokableOperations[(int)OperationType.ReplaceTextInFiles]
                        .Enabled = value;
                }
                catch (Exception ex)
                {
                    // dump all the exception info to the log
                    DebugUtils.LogException(ex);
                }
            }
        }

        /// <summary>
        /// Gets or sets the text that found text should be replaced with.
        /// </summary>
        [JsonProperty("replaceWith")]
        public string ReplaceWith
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets a collection of strings that correspond to the
        /// most-recently-used values for Replace With.
        /// </summary>
        [JsonProperty("replaceWithHistory")]
        public IList<string> ReplaceWithHistory
        {
            get;
            set;
        } = new List<string>();

        /// <summary>
        /// Gets or sets a number from 0...N, where N is the number of option
        /// tabs, of the one that is currently selected.
        /// </summary>
        [JsonProperty("selectedOptionTab")]
        public int SelectedOptionTab
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets a value that indicates whether we are to attempt to commit pending
        /// changes to the user's local Git repository, on the current branch, prior to
        /// executing the operations.
        /// </summary>
        [JsonProperty("shouldCommitPendingChanges")]
        public bool ShouldCommitPendingChanges
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets a value that indicates whether we are to attempt to commit pending
        /// changes to the user's local Git repository, and on the current branch, the
        /// changes that have resulted from the operations we've performed.
        /// </summary>
        public bool ShouldCommitPostOperationChanges
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets a string containing the path to the starting folder of
        /// the search.
        /// </summary>
        [JsonProperty("startingFolder")]
        public string StartingFolder
        {
            get => _startingFolder;
            set {
                var oldValue = _startingFolder;
                var changed = _startingFolder != value;
                _startingFolder = value;
                if (changed)
                    OnStartingFolderChanged(
                        new StartingFolderChangedEventArgs(oldValue, value)
                    );
            }
        }

        /// <summary>
        /// Gets or sets a collection of strings that correspond to the
        /// most-recently-used values for Starting Folder.
        /// </summary>
        [JsonProperty("startingFolderHistory")]
        public IList<string> StartingFolderHistory
        {
            get;
            set;
        } = new List<string>();

        /// <summary>
        /// Gets or sets a value indicating whether to update the user's local Git
        /// repository even when running in <c>Auto Start</c> mode.
        /// </summary>
        /// <remarks>The default value of this property is <see langword="true" />.</remarks>
        [JsonProperty("updateGitOnAutoStart")]
        public bool UpdateGitOnAutoStart
        {
            get;
            set;
        } = true;

        /// <summary>
        /// Occurs when the value of the
        /// <see
        ///     cref="P:MFR.Settings.ProjectFileRenamerConfig.ProjectFileRenamerConfig.StartingFolder" />
        /// property has been updated.
        /// </summary>
        public event StartingFolderChangedEventHandler StartingFolderChanged;

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

                result = obj.GetType() == GetType() && Equals(
                    (ProjectFileRenamerConfig)obj
                );
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

                result = result * 31 + AutoQuitOnCompletion.GetHashCode();
                result = result * 31 + AutoStart.GetHashCode();
                result = result * 31 + FindWhat.GetHashCode();
                result = FindWhatHistory.Aggregate(
                    result,
                    (current, element) => current * 31 + element.GetHashCode()
                );
                result = InvokableOperations.Aggregate(
                    result,
                    (current, element) => current * 31 + element.GetHashCode()
                );
                result = result * 31 + IsFolded.GetHashCode();
                result = result * 31 + IsFromCommandLine.GetHashCode();
                result = result * 31 + MatchCase.GetHashCode();
                result = result * 31 + MatchExactWord.GetHashCode();
                result = result * 31 + ReOpenSolution.GetHashCode();
                result = result * 31 + ReplaceWith.GetHashCode();
                result = ReplaceWithHistory.Aggregate(
                    result,
                    (current, element) => current * 31 + element.GetHashCode()
                );
                result = result * 31 + SelectedOptionTab.GetHashCode();
                result = StartingFolderHistory.Aggregate(
                    result,
                    (current, element) => current * 31 + element.GetHashCode()
                );
                return result;
            }
        }

        /// <summary>
        /// Sets the values of this class' properties to their default values.
        /// </summary>
        /// <remarks>
        /// This method typically is called from a class constructor.
        /// </remarks>
        public void Reset()
        {
            try
            {
                AutoQuitOnCompletion = true;

                IsFromCommandLine = false;

                ReOpenSolution = true;

                RenameFilesInFolder =
                    RenameSubFolders = ReplaceTextInFiles = true;

                MatchCase = true;
                MatchExactWord = false;

                StartingFolderHistory.Clear();
                FindWhatHistory.Clear();
                ReplaceWithHistory.Clear();

                FindWhat = ReplaceWith = string.Empty;
                StartingFolder = string.Empty;

                if (InvokableOperations != null && InvokableOperations.Any())
                    InvokableOperations.Clear();

                InvokableOperations = Initialize.OperationList();

                ErrantProcessesList.Clear();
            }
            catch (Exception ex)
            {
                // dump all the exception info to the log
                DebugUtils.LogException(ex);
            }
        }

        /// <summary>
        /// Determines whether the specified <paramref name="config" /> object
        /// instance is blank or a <see langword="null" /> reference.
        /// </summary>
        /// <param name="config">
        /// (Required.) Reference to an instance of an object that implements the
        /// <see
        ///     cref="T:MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfig" />
        /// interface that represents the object instance that is to be examined.
        /// </param>
        /// <returns>
        /// <see langword="true" /> if the specified
        /// <paramref name="config" /> object instance is blank or a
        /// <see langword="null" /> reference.
        /// </returns>
        public static bool IsBlankOrNull(IProjectFileRenamerConfig config)
        {
            bool result;

            try
            {
                result = config == null || Blank.Equals(config);
            }
            catch (Exception ex)
            {
                // dump all the exception info to the log
                DebugUtils.LogException(ex);

                result = false;
            }

            return result;
        }

        protected bool Equals(IProjectFileRenamerConfig other)
        {
            var result = false;

            try
            {
                if (other is null) return result;

                result = AutoQuitOnCompletion == other.AutoQuitOnCompletion &&
                         AutoStart == other.AutoStart &&
                         FindWhat == other.FindWhat &&
                         FindWhatHistory.SequenceEqual(other.FindWhatHistory) &&
                         InvokableOperations.SequenceEqual(
                             other.InvokableOperations
                         ) && IsFolded == other.IsFolded &&
                         IsFromCommandLine == other.IsFromCommandLine &&
                         MatchCase == other.MatchCase &&
                         MatchExactWord == other.MatchExactWord &&
                         ReOpenSolution == other.ReOpenSolution &&
                         ReplaceWith == other.ReplaceWith &&
                         ReplaceWithHistory.SequenceEqual(
                             other.ReplaceWithHistory
                         ) && SelectedOptionTab == other.SelectedOptionTab &&
                         StartingFolderHistory.SequenceEqual(
                             other.StartingFolderHistory
                         );
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
        /// Raises the
        /// <see
        ///     cref="E:MFR.Settings.ProjectFileRenamerConfig.ProjectFileRenamerConfig.StartingFolderChanged" />
        /// event.
        /// </summary>
        /// <param name="e">
        /// (Required.) A
        /// <see cref="T:MFR.Settings.Configuration.Events.StartingFolderChangedEventArgs" />
        /// that contains the event's data.
        /// </param>
        /// <remarks>
        /// This event is supposed to be raised when the value of the
        /// <see
        ///     cref="P:MFR.Settings.Configuration.ProjectFileRenamerConfig.StartingFolder" />
        /// property is updated.
        /// </remarks>
        protected virtual void OnStartingFolderChanged(
            StartingFolderChangedEventArgs e
        )
            => StartingFolderChanged?.Invoke(this, e);

        /// <summary>
        /// Adds the specified <paramref name="errantProcesses" /> to the configured list
        /// of errant processes that are to be killed prior to performing certain
        /// operations.
        /// </summary>
        /// <param name="errantProcesses">
        /// (Required.) A collection of references to instances of
        /// <see cref="T:System.String" />, each element of which is the name of a process
        /// that is to be killed prior to the start of an operation.
        /// </param>
        /// <returns>
        /// <see langword="true" /> if the invokable operation(s) were
        /// successfully added to the internal collection; <see langword="false" />
        /// otherwise.
        /// </returns>
        private bool AddErrantProcessEntries(
            IEnumerable<string> errantProcesses
        )
        {
            var result = false;

            try
            {
                if (errantProcesses == null) return result;
                if (!errantProcesses.Any()) return result;

                foreach (var errantProcess in errantProcesses)
                    ErrantProcessesList.Add(errantProcess);

                /*
                 * If we made it this far with no exceptions getting caught,
                 * then assume that this method succeeded.
                 */

                result = true;
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
        /// Adds the specified <paramref name="operations" /> to the configured list of
        /// invokable operations.
        /// </summary>
        /// <param name="operations">
        /// (Required.) Reference to an instance of a collection of instances of objects
        /// that implement the
        /// <see cref="T:MFR.GUI.Models.Interfaces.IOperationTypeInfo" /> interface, each
        /// element of which specifies configuration information, such as whether the
        /// operation is disabled, for each invokable operation.
        /// </param>
        /// <returns>
        /// <see langword="true" /> if the invokable operation(s) were
        /// successfully added to the internal collection; <see langword="false" />
        /// otherwise.
        /// </returns>
        private bool AddInvokableOperationEntries(
            IEnumerable<IOperationTypeInfo> operations
        )
        {
            var result = false;

            try
            {
                if (operations == null) return result;
                if (!operations.Any()) return result;

                foreach (var operation in operations)
                    InvokableOperations.Add(operation);

                /*
                 * If we made it this far with no exceptions getting caught,
                 * then assume that this method succeeded.
                 */

                result = true;
            }
            catch (Exception ex)
            {
                // dump all the exception info to the log
                DebugUtils.LogException(ex);

                result = false;
            }

            return result;
        }
    }
}