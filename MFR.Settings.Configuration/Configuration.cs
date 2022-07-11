using MFR.GUI.Models;
using MFR.GUI.Models.Extensions;
using MFR.Operations.Constants;
using MFR.Settings.Configuration.Interfaces;
using Newtonsoft.Json;
using PostSharp.Patterns.Diagnostics;
using System;
using System.Collections.Generic;
using System.Linq;
using xyLOGIX.Core.Debug;

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
    public class Configuration : IConfiguration
    {
        /// <summary>
        /// Constructs a new instance of
        /// <see
        ///     cref="T:MFR.Settings.Configuration.Configuration" />
        /// and returns a reference to it.
        /// </summary>
        public Configuration()
        {
            Reset();
        }

        /// <summary>
        /// Constructs a new instance of
        /// <see
        ///     cref="T:MFR.Settings.Configuration.Configuration" />
        /// and returns a reference to it.
        /// </summary>
        /// <param name="source">
        /// (Required.) Reference to an instance of an object that implements the
        /// <see cref="T:MFR.Settings.Configuration.Interfaces.IConfiguration" /> interface
        /// that contains existing configuration settings to copy into this object.
        /// </param>
        public Configuration(IConfiguration source)
        {
            if (source == null) throw new ArgumentNullException(nameof(source));

            FindWhat = source.FindWhat;
            FindWhatHistory = source.FindWhatHistory;
            IsFolded = source.IsFolded;
            MatchCase = source.MatchCase;
            MatchExactWord = source.MatchExactWord;
            OperationsToPerform = source.OperationsToPerform;
            ReOpenSolution = source.ReOpenSolution;
            RenameFiles = source.RenameFiles;
            RenameSubFolders = source.RenameSubFolders;
            ReplaceTextInFiles = source.ReplaceTextInFiles;
            ReplaceWith = source.ReplaceWith;
            ReplaceWithHistory = source.ReplaceWithHistory;
            SelectedOptionTab = source.SelectedOptionTab;
            StartingFolder = source.StartingFolder;
            StartingFolderHistory = source.StartingFolderHistory;
        }

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
        public List<string> FindWhatHistory
        {
            get;
            set;
        } = new List<string>();

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
        /// Gets or sets a reference to a collection of instances of
        /// <see cref="T:MFR.GUI.Models.OperationTypeInfo" /> instances, that can turn the
        /// operations to be performed on or off.
        /// </summary>
        [JsonProperty("operationsToPerform")]
        public List<OperationTypeInfo> OperationsToPerform
        {
            get;
            set;
        } = new List<OperationTypeInfo> {
            new OperationTypeInfo {
                Enabled = false,
                OperationType = OperationType.RenameFilesInFolder
            },
            new OperationTypeInfo {
                Enabled = false, OperationType = OperationType.RenameSubFolders
            },
            new OperationTypeInfo {
                Enabled = false,
                OperationType = OperationType.ReplaceTextInFiles
            }
        };

        /// <summary>
        /// Gets or sets a value that indicates whether we should rename files
        /// in the folders encountered.
        /// </summary>
        [JsonIgnore]
        public bool RenameFiles
        {
            get {
                var result = false;

                try
                {
                    if (!OperationsToPerform.HasAnyOperations()) return result;
                    if (!OperationsToPerform.Any(
                            o => o.IsOfType(OperationType.RenameFilesInFolder)
                        ))
                        return result;

                    result = OperationsToPerform[
                            (int)OperationType.RenameFilesInFolder]
                        .Enabled;
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
                    if (!OperationsToPerform.HasAnyOperations()) return;
                    if (!OperationsToPerform.Any(
                            o => o.IsOfType(OperationType.RenameFilesInFolder)
                        ))
                        return;

                    OperationsToPerform[(int)OperationType.RenameFilesInFolder]
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
        /// Gets or sets a value that indicates whether we should rename subfolders.
        /// </summary>
        [JsonIgnore]
        public bool RenameSubFolders
        {
            get {
                var result = false;

                try
                {
                    if (!OperationsToPerform.HasAnyOperations()) return result;
                    if (!OperationsToPerform.Any(
                            o => o.IsOfType(OperationType.RenameSubFolders)
                        ))
                        return result;

                    result = OperationsToPerform[
                            (int)OperationType.RenameSubFolders]
                        .Enabled;
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
                    if (!OperationsToPerform.HasAnyOperations()) return;
                    if (!OperationsToPerform.Any(
                            o => o.IsOfType(OperationType.RenameSubFolders)
                        ))
                        return;

                    OperationsToPerform[(int)OperationType.RenameSubFolders]
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
        /// If this is set to <see langword="true" />, and the containing solution is open,
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
                    if (!OperationsToPerform.HasAnyOperations()) return result;
                    if (!OperationsToPerform.Any(
                            o => o.IsOfType(OperationType.ReplaceTextInFiles)
                        ))
                        return result;

                    result = OperationsToPerform[
                            (int)OperationType.ReplaceTextInFiles]
                        .Enabled;
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
                    if (!OperationsToPerform.HasAnyOperations()) return;
                    if (!OperationsToPerform.Any(
                            o => o.IsOfType(OperationType.ReplaceTextInFiles)
                        ))
                        return;

                    OperationsToPerform[(int)OperationType.ReplaceTextInFiles]
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
        public List<string> ReplaceWithHistory
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
        /// Gets or sets a string containing the path to the starting folder of
        /// the search.
        /// </summary>
        [JsonProperty("startingFolder")]
        public string StartingFolder
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets a collection of strings that correspond to the
        /// most-recently-used values for Starting Folder.
        /// </summary>
        [JsonProperty("startingFolderHistory")]
        public List<string> StartingFolderHistory
        {
            get;
            set;
        } = new List<string>();

        /// <summary>
        /// Sets the values of this class' properties to their default values.
        /// </summary>
        /// <remarks>
        /// This method typically is called from a class constructor.
        /// </remarks>
        public void Reset()
            => ReOpenSolution = true;
    }
}